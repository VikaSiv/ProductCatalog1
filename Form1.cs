using Microsoft.EntityFrameworkCore;
using ProductCatalog1.Models;
using ProductCatalog1.UserControls;

namespace ProductCatalog1
{
    public partial class Form1 : Form
    {
        private int pageSize = 4;
        private int currentPage = 1;
        private List<Models.Product> products;
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
            LoadManufacturers();
            LoadData();
        }
        private void InitializeControls()
        {
            // Сортировка
            cbSort.Items.Add("Price Ascending");
            cbSort.Items.Add("Price Descending");
            cbSort.SelectedIndex = 0;

            // Фильтрация
            cbManufacturer.Items.Add("All Manufacturers");
            cbManufacturer.SelectedIndex = 0;
            cbManufacturer.SelectedIndexChanged += (s, e) => LoadData();

            // Поиск
            txtSearch.TextChanged += (s, e) => LoadData();

            // Событие для изменения страницы
            nudPage.Minimum = 1;
            nudPage.Value = 1;
            nudPage.ValueChanged += (s, e) => { currentPage = (int)nudPage.Value; LoadData(); };

            // Кнопки пагинации
            btnPrevPage.Click += (s, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    nudPage.Value = currentPage;
                    LoadData();
                }
            };

            btnNextPage.Click += (s, e) =>
            {
                currentPage++;
                nudPage.Value = currentPage;
                LoadData();
            };

            cbSort.SelectedIndexChanged += (s, e) => LoadData();
        }

        // Загрузка списка производителей в выпадающий список
        private void LoadManufacturers()
        {
            using (var db = new DBContext())
            {
                var manufacturers = db.Manufacturers.ToList();
                foreach (var manufacturer in manufacturers)
                {
                    cbManufacturer.Items.Add(manufacturer.Name);
                }
            }
        }

        private void LoadData()
        {
            using (var db = new DBContext())
            {
                IQueryable<Models.Product> query = db.Products.Include(p => p.Manufacturer);

                // Поиск
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    query = query.Where(p =>
                        p.Name.Contains(txtSearch.Text) ||
                        p.Description.Contains(txtSearch.Text) ||
                        p.Manufacturer.Name.Contains(txtSearch.Text));
                }

                // Фильтрация
                if (cbManufacturer.SelectedIndex > 0)
                {
                    var selectedManufacturer = cbManufacturer.SelectedItem.ToString();
                    query = query.Where(p => p.Manufacturer.Name == selectedManufacturer);
                }

                // Сортировка
                switch (cbSort.SelectedItem.ToString())
                {
                    case "Price Ascending":
                        query = query.OrderBy(p => p.Price);
                        break;
                    case "Price Descending":
                        query = query.OrderByDescending(p => p.Price);
                        break;
                }

                // Пагинация
                int totalProducts = query.Count();
                int totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);
                nudPage.Maximum = totalPages;

                // Получаем данные для текущей страницы
                query = query.Skip((currentPage - 1) * pageSize).Take(pageSize);

                products = query.ToList();

                // Обновление информации о количестве записей
                lblInfo.Text = $"{products.Count} из {totalProducts}";

                // Очистка контейнера и добавление товаров
                flpProducts.Controls.Clear();
                foreach (var product in products)
                {
                    var productControl = new ProductCatalog1.UserControls.Product(product);

                    // Проверяем наличие на складе
                    if (product.Count == 0)
                    {
                        productControl.BackColor = System.Drawing.Color.LightGray;
                    }

                    flpProducts.Controls.Add(productControl);
                }

                // Обновляем состояние кнопок навигации
                btnPrevPage.Enabled = currentPage > 1;
                btnNextPage.Enabled = currentPage < totalPages;
            }
        }
    }
}
