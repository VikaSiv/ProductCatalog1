namespace ProductCatalog1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpProducts = new FlowLayoutPanel();
            txtSearch = new TextBox();
            cbSort = new ComboBox();
            cbManufacturer = new ComboBox();
            nudPage = new NumericUpDown();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPage).BeginInit();
            SuspendLayout();
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(78, 142);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1220, 635);
            flpProducts.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(372, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(556, 27);
            txtSearch.TabIndex = 1;
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(1009, 49);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(151, 28);
            cbSort.TabIndex = 2;
            // 
            // cbManufacturer
            // 
            cbManufacturer.FormattingEnabled = true;
            cbManufacturer.Location = new Point(1009, 97);
            cbManufacturer.Name = "cbManufacturer";
            cbManufacturer.Size = new Size(151, 28);
            cbManufacturer.TabIndex = 3;
            // 
            // nudPage
            // 
            nudPage.Location = new Point(631, 785);
            nudPage.Name = "nudPage";
            nudPage.Size = new Size(150, 27);
            nudPage.TabIndex = 4;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(508, 783);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(94, 29);
            btnPrevPage.TabIndex = 5;
            btnPrevPage.Text = "<-";
            btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(816, 785);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 6;
            btnNextPage.Text = "->";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ImageAlign = ContentAlignment.TopLeft;
            lblInfo.Location = new Point(273, 53);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 7;
            lblInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(lblInfo);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(nudPage);
            Controls.Add(cbManufacturer);
            Controls.Add(cbSort);
            Controls.Add(txtSearch);
            Controls.Add(flpProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpProducts;
        private TextBox txtSearch;
        private ComboBox cbSort;
        private ComboBox cbManufacturer;
        private NumericUpDown nudPage;
        private Button btnPrevPage;
        private Button btnNextPage;
        private Label lblInfo;
    }
}
