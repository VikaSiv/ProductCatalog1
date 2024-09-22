namespace ProductCatalog1.UserControls
{
    partial class Product
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            NameLbl = new Label();
            DescLbl = new Label();
            ManufacturerLbl = new Label();
            PriceLbl = new Label();
            CountLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 114);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(243, 17);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(69, 20);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "NameLbl";
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Location = new Point(243, 46);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(61, 20);
            DescLbl.TabIndex = 2;
            DescLbl.Text = "DescLbl";
            // 
            // ManufacturerLbl
            // 
            ManufacturerLbl.AutoSize = true;
            ManufacturerLbl.Location = new Point(243, 82);
            ManufacturerLbl.Name = "ManufacturerLbl";
            ManufacturerLbl.Size = new Size(117, 20);
            ManufacturerLbl.TabIndex = 3;
            ManufacturerLbl.Text = "ManufacturerLbl";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(243, 111);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(61, 20);
            PriceLbl.TabIndex = 4;
            PriceLbl.Text = "PriceLbl";
            // 
            // CountLbl
            // 
            CountLbl.AutoSize = true;
            CountLbl.Location = new Point(689, 61);
            CountLbl.Name = "CountLbl";
            CountLbl.Size = new Size(68, 20);
            CountLbl.TabIndex = 5;
            CountLbl.Text = "CountLbl";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CountLbl);
            Controls.Add(PriceLbl);
            Controls.Add(ManufacturerLbl);
            Controls.Add(DescLbl);
            Controls.Add(NameLbl);
            Controls.Add(pictureBox1);
            Name = "Product";
            Size = new Size(800, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label NameLbl;
        private Label DescLbl;
        private Label ManufacturerLbl;
        private Label PriceLbl;
        private Label CountLbl;
    }
}
