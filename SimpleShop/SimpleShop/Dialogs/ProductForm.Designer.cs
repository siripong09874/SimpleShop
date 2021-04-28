namespace SimpleShop.Dialogs
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productSloganLabel = new System.Windows.Forms.Label();
            this.productSloganTextBox = new System.Windows.Forms.TextBox();
            this.productNetPrice = new System.Windows.Forms.Label();
            this.productSalesPrice = new System.Windows.Forms.Label();
            this.createProductButton = new System.Windows.Forms.Button();
            this.productNetPriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.productSalesPriceUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productNetPriceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesPriceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(90, 6);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCodeTextBox.TabIndex = 0;
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(72, 13);
            this.productCodeLabel.TabIndex = 1;
            this.productCodeLabel.Text = "Product Code";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(12, 32);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(90, 29);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productSloganLabel
            // 
            this.productSloganLabel.AutoSize = true;
            this.productSloganLabel.Location = new System.Drawing.Point(12, 55);
            this.productSloganLabel.Name = "productSloganLabel";
            this.productSloganLabel.Size = new System.Drawing.Size(40, 13);
            this.productSloganLabel.TabIndex = 4;
            this.productSloganLabel.Text = "Slogan";
            // 
            // productSloganTextBox
            // 
            this.productSloganTextBox.Location = new System.Drawing.Point(90, 52);
            this.productSloganTextBox.Name = "productSloganTextBox";
            this.productSloganTextBox.Size = new System.Drawing.Size(100, 20);
            this.productSloganTextBox.TabIndex = 5;
            // 
            // productNetPrice
            // 
            this.productNetPrice.AutoSize = true;
            this.productNetPrice.Location = new System.Drawing.Point(12, 78);
            this.productNetPrice.Name = "productNetPrice";
            this.productNetPrice.Size = new System.Drawing.Size(51, 13);
            this.productNetPrice.TabIndex = 6;
            this.productNetPrice.Text = "Net Price";
            // 
            // productSalesPrice
            // 
            this.productSalesPrice.AutoSize = true;
            this.productSalesPrice.Location = new System.Drawing.Point(12, 101);
            this.productSalesPrice.Name = "productSalesPrice";
            this.productSalesPrice.Size = new System.Drawing.Size(60, 13);
            this.productSalesPrice.TabIndex = 9;
            this.productSalesPrice.Text = "Sales Price";
            // 
            // createProductButton
            // 
            this.createProductButton.Location = new System.Drawing.Point(138, 136);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(99, 23);
            this.createProductButton.TabIndex = 10;
            this.createProductButton.Text = "Create Product";
            this.createProductButton.UseVisualStyleBackColor = true;
            this.createProductButton.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // productNetPriceUpDown
            // 
            this.productNetPriceUpDown.Location = new System.Drawing.Point(90, 76);
            this.productNetPriceUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.productNetPriceUpDown.Name = "productNetPriceUpDown";
            this.productNetPriceUpDown.Size = new System.Drawing.Size(120, 20);
            this.productNetPriceUpDown.TabIndex = 11;
            // 
            // productSalesPriceUpDown
            // 
            this.productSalesPriceUpDown.Location = new System.Drawing.Point(90, 99);
            this.productSalesPriceUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.productSalesPriceUpDown.Name = "productSalesPriceUpDown";
            this.productSalesPriceUpDown.Size = new System.Drawing.Size(120, 20);
            this.productSalesPriceUpDown.TabIndex = 12;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 199);
            this.Controls.Add(this.productSalesPriceUpDown);
            this.Controls.Add(this.productNetPriceUpDown);
            this.Controls.Add(this.createProductButton);
            this.Controls.Add(this.productSalesPrice);
            this.Controls.Add(this.productNetPrice);
            this.Controls.Add(this.productSloganTextBox);
            this.Controls.Add(this.productSloganLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 238);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.productNetPriceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesPriceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productSloganLabel;
        private System.Windows.Forms.TextBox productSloganTextBox;
        private System.Windows.Forms.Label productNetPrice;
        private System.Windows.Forms.Label productSalesPrice;
        private System.Windows.Forms.Button createProductButton;
        private System.Windows.Forms.NumericUpDown productNetPriceUpDown;
        private System.Windows.Forms.NumericUpDown productSalesPriceUpDown;
    }
}