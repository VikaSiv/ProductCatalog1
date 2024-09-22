using System;
using System.Windows.Forms;
using ProductCatalog1.Models;

namespace ProductCatalog1.UserControls
{
    public partial class Product : UserControl
    {
        public Product(Models.Product product)
        {
            InitializeComponent();
            SetProductData(product);
        }

        private void SetProductData(Models.Product product)
        {
            // Устанавливаем значения для меток
            NameLbl.Text = product.Name;
            DescLbl.Text = product.Description;
            ManufacturerLbl.Text = product.Manufacturer?.Name;
            PriceLbl.Text = $"Цена: {product.Price:C}";
            CountLbl.Text = $"Количество: {product.Count}";

            // Устанавливаем изображение
            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                try
                {
                    pictureBox1.Load(product.ImageUrl);
                }
                catch
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\1\\Desktop\\ProductCatalog1\\img\\picture.png");
                }
            }
        }
    }
}
