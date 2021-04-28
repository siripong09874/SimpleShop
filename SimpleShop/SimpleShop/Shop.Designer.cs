namespace SimpleShop
{
    partial class Shop
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
            this.saleTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saleButton = new System.Windows.Forms.Button();
            this.vatLabel = new System.Windows.Forms.Label();
            this.clearSaleButton = new System.Windows.Forms.Button();
            this.totalPriceInculdeVatLabel = new System.Windows.Forms.Label();
            this.totalPriceInculdeVatValueLabel = new System.Windows.Forms.Label();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitSaleProducCodeButton = new System.Windows.Forms.Button();
            this.saleProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.saleProductCodeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.saveProductDataButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.createProductButton = new System.Windows.Forms.Button();
            this.promotionTabPage = new System.Windows.Forms.TabPage();
            this.savePromotionDataButton = new System.Windows.Forms.Button();
            this.promotionGridView = new System.Windows.Forms.DataGridView();
            this.createPromotionButton = new System.Windows.Forms.Button();
            this.priceApplicableTabPage = new System.Windows.Forms.TabPage();
            this.priceApplicableDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceApplicableSubmitButton = new System.Windows.Forms.Button();
            this.priceApplicableDateLabel = new System.Windows.Forms.Label();
            this.priceApplicableGridView = new System.Windows.Forms.DataGridView();
            this.clearProductDataButton = new System.Windows.Forms.Button();
            this.clearPromotionDataButton = new System.Windows.Forms.Button();
            this.saleTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.promotionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).BeginInit();
            this.priceApplicableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceApplicableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleTabPage
            // 
            this.saleTabPage.Controls.Add(this.panel2);
            this.saleTabPage.Controls.Add(this.panel1);
            this.saleTabPage.Controls.Add(this.submitSaleProducCodeButton);
            this.saleTabPage.Controls.Add(this.saleProductCodeTextBox);
            this.saleTabPage.Controls.Add(this.saleProductCodeLabel);
            this.saleTabPage.Location = new System.Drawing.Point(4, 22);
            this.saleTabPage.Name = "saleTabPage";
            this.saleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.saleTabPage.Size = new System.Drawing.Size(824, 428);
            this.saleTabPage.TabIndex = 0;
            this.saleTabPage.Text = "Sale Order";
            this.saleTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.salesGridView);
            this.panel2.Location = new System.Drawing.Point(11, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 341);
            this.panel2.TabIndex = 13;
            // 
            // salesGridView
            // 
            this.salesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGridView.Location = new System.Drawing.Point(0, 0);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.Size = new System.Drawing.Size(556, 341);
            this.salesGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.totalPriceLabel);
            this.panel1.Controls.Add(this.saleButton);
            this.panel1.Controls.Add(this.vatLabel);
            this.panel1.Controls.Add(this.clearSaleButton);
            this.panel1.Controls.Add(this.totalPriceInculdeVatLabel);
            this.panel1.Controls.Add(this.totalPriceInculdeVatValueLabel);
            this.panel1.Controls.Add(this.totalPriceValueLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(577, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 167);
            this.panel1.TabIndex = 12;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(17, 23);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "TotalPrice :";
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(20, 105);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(75, 23);
            this.saleButton.TabIndex = 11;
            this.saleButton.Text = "Sale Sumbit";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(17, 49);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(46, 13);
            this.vatLabel.TabIndex = 5;
            this.vatLabel.Text = "Vat 7% :";
            // 
            // clearSaleButton
            // 
            this.clearSaleButton.Location = new System.Drawing.Point(101, 105);
            this.clearSaleButton.Name = "clearSaleButton";
            this.clearSaleButton.Size = new System.Drawing.Size(75, 23);
            this.clearSaleButton.TabIndex = 10;
            this.clearSaleButton.Text = "Clear";
            this.clearSaleButton.UseVisualStyleBackColor = true;
            this.clearSaleButton.Click += new System.EventHandler(this.clearSaleButton_Click);
            // 
            // totalPriceInculdeVatLabel
            // 
            this.totalPriceInculdeVatLabel.AutoSize = true;
            this.totalPriceInculdeVatLabel.Location = new System.Drawing.Point(17, 77);
            this.totalPriceInculdeVatLabel.Name = "totalPriceInculdeVatLabel";
            this.totalPriceInculdeVatLabel.Size = new System.Drawing.Size(121, 13);
            this.totalPriceInculdeVatLabel.TabIndex = 6;
            this.totalPriceInculdeVatLabel.Text = "Total Price Include Vat :";
            // 
            // totalPriceInculdeVatValueLabel
            // 
            this.totalPriceInculdeVatValueLabel.AutoSize = true;
            this.totalPriceInculdeVatValueLabel.Location = new System.Drawing.Point(144, 77);
            this.totalPriceInculdeVatValueLabel.Name = "totalPriceInculdeVatValueLabel";
            this.totalPriceInculdeVatValueLabel.Size = new System.Drawing.Size(13, 13);
            this.totalPriceInculdeVatValueLabel.TabIndex = 9;
            this.totalPriceInculdeVatValueLabel.Text = "0";
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.Location = new System.Drawing.Point(144, 23);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(13, 13);
            this.totalPriceValueLabel.TabIndex = 7;
            this.totalPriceValueLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "7%";
            // 
            // submitSaleProducCodeButton
            // 
            this.submitSaleProducCodeButton.Location = new System.Drawing.Point(277, 3);
            this.submitSaleProducCodeButton.Name = "submitSaleProducCodeButton";
            this.submitSaleProducCodeButton.Size = new System.Drawing.Size(75, 23);
            this.submitSaleProducCodeButton.TabIndex = 2;
            this.submitSaleProducCodeButton.Text = "Sumbit";
            this.submitSaleProducCodeButton.UseVisualStyleBackColor = true;
            this.submitSaleProducCodeButton.Click += new System.EventHandler(this.submitSaleProducCodeButton_Click);
            // 
            // saleProductCodeTextBox
            // 
            this.saleProductCodeTextBox.Location = new System.Drawing.Point(144, 7);
            this.saleProductCodeTextBox.Name = "saleProductCodeTextBox";
            this.saleProductCodeTextBox.Size = new System.Drawing.Size(126, 20);
            this.saleProductCodeTextBox.TabIndex = 1;
            this.saleProductCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saleProductCodeTextBox_KeyDown);
            // 
            // saleProductCodeLabel
            // 
            this.saleProductCodeLabel.AutoSize = true;
            this.saleProductCodeLabel.Location = new System.Drawing.Point(8, 10);
            this.saleProductCodeLabel.Name = "saleProductCodeLabel";
            this.saleProductCodeLabel.Size = new System.Drawing.Size(130, 13);
            this.saleProductCodeLabel.TabIndex = 0;
            this.saleProductCodeLabel.Text = "Enter Sale - Product Code";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.saleTabPage);
            this.tabControl1.Controls.Add(this.productTabPage);
            this.tabControl1.Controls.Add(this.promotionTabPage);
            this.tabControl1.Controls.Add(this.priceApplicableTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.clearProductDataButton);
            this.productTabPage.Controls.Add(this.saveProductDataButton);
            this.productTabPage.Controls.Add(this.productGridView);
            this.productTabPage.Controls.Add(this.createProductButton);
            this.productTabPage.Location = new System.Drawing.Point(4, 22);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productTabPage.Size = new System.Drawing.Size(824, 428);
            this.productTabPage.TabIndex = 1;
            this.productTabPage.Text = "Product";
            this.productTabPage.UseVisualStyleBackColor = true;
            this.productTabPage.Click += new System.EventHandler(this.productTabPage_Click);
            // 
            // saveProductDataButton
            // 
            this.saveProductDataButton.Location = new System.Drawing.Point(114, 5);
            this.saveProductDataButton.Name = "saveProductDataButton";
            this.saveProductDataButton.Size = new System.Drawing.Size(131, 23);
            this.saveProductDataButton.TabIndex = 2;
            this.saveProductDataButton.Text = "Save Product Data";
            this.saveProductDataButton.UseVisualStyleBackColor = true;
            this.saveProductDataButton.Click += new System.EventHandler(this.saveProductDataButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(8, 35);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(810, 354);
            this.productGridView.TabIndex = 1;
            // 
            // createProductButton
            // 
            this.createProductButton.Location = new System.Drawing.Point(6, 6);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(101, 23);
            this.createProductButton.TabIndex = 0;
            this.createProductButton.Text = "Create Product";
            this.createProductButton.UseVisualStyleBackColor = true;
            this.createProductButton.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // promotionTabPage
            // 
            this.promotionTabPage.Controls.Add(this.clearPromotionDataButton);
            this.promotionTabPage.Controls.Add(this.savePromotionDataButton);
            this.promotionTabPage.Controls.Add(this.promotionGridView);
            this.promotionTabPage.Controls.Add(this.createPromotionButton);
            this.promotionTabPage.Location = new System.Drawing.Point(4, 22);
            this.promotionTabPage.Name = "promotionTabPage";
            this.promotionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.promotionTabPage.Size = new System.Drawing.Size(824, 428);
            this.promotionTabPage.TabIndex = 2;
            this.promotionTabPage.Text = "Promotion";
            this.promotionTabPage.UseVisualStyleBackColor = true;
            // 
            // savePromotionDataButton
            // 
            this.savePromotionDataButton.Location = new System.Drawing.Point(118, 5);
            this.savePromotionDataButton.Name = "savePromotionDataButton";
            this.savePromotionDataButton.Size = new System.Drawing.Size(126, 23);
            this.savePromotionDataButton.TabIndex = 3;
            this.savePromotionDataButton.Text = "Save Promotion Data";
            this.savePromotionDataButton.UseVisualStyleBackColor = true;
            this.savePromotionDataButton.Click += new System.EventHandler(this.savePromotionDataButton_Click);
            // 
            // promotionGridView
            // 
            this.promotionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.promotionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionGridView.Location = new System.Drawing.Point(6, 35);
            this.promotionGridView.Name = "promotionGridView";
            this.promotionGridView.Size = new System.Drawing.Size(810, 349);
            this.promotionGridView.TabIndex = 2;
            // 
            // createPromotionButton
            // 
            this.createPromotionButton.Location = new System.Drawing.Point(8, 6);
            this.createPromotionButton.Name = "createPromotionButton";
            this.createPromotionButton.Size = new System.Drawing.Size(103, 23);
            this.createPromotionButton.TabIndex = 0;
            this.createPromotionButton.Text = "Create Promotion";
            this.createPromotionButton.UseVisualStyleBackColor = true;
            this.createPromotionButton.Click += new System.EventHandler(this.createPromotionButton_Click);
            // 
            // priceApplicableTabPage
            // 
            this.priceApplicableTabPage.Controls.Add(this.priceApplicableGridView);
            this.priceApplicableTabPage.Controls.Add(this.priceApplicableDateLabel);
            this.priceApplicableTabPage.Controls.Add(this.priceApplicableSubmitButton);
            this.priceApplicableTabPage.Controls.Add(this.priceApplicableDateTimePicker);
            this.priceApplicableTabPage.Location = new System.Drawing.Point(4, 22);
            this.priceApplicableTabPage.Name = "priceApplicableTabPage";
            this.priceApplicableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.priceApplicableTabPage.Size = new System.Drawing.Size(824, 428);
            this.priceApplicableTabPage.TabIndex = 3;
            this.priceApplicableTabPage.Text = "Price Applicable";
            this.priceApplicableTabPage.UseVisualStyleBackColor = true;
            // 
            // priceApplicableDateTimePicker
            // 
            this.priceApplicableDateTimePicker.Location = new System.Drawing.Point(86, 14);
            this.priceApplicableDateTimePicker.Name = "priceApplicableDateTimePicker";
            this.priceApplicableDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.priceApplicableDateTimePicker.TabIndex = 0;
            // 
            // priceApplicableSubmitButton
            // 
            this.priceApplicableSubmitButton.Location = new System.Drawing.Point(292, 13);
            this.priceApplicableSubmitButton.Name = "priceApplicableSubmitButton";
            this.priceApplicableSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.priceApplicableSubmitButton.TabIndex = 1;
            this.priceApplicableSubmitButton.Text = "Search";
            this.priceApplicableSubmitButton.UseVisualStyleBackColor = true;
            this.priceApplicableSubmitButton.Click += new System.EventHandler(this.priceApplicableSubmitButton_Click);
            // 
            // priceApplicableDateLabel
            // 
            this.priceApplicableDateLabel.AutoSize = true;
            this.priceApplicableDateLabel.Location = new System.Drawing.Point(9, 18);
            this.priceApplicableDateLabel.Name = "priceApplicableDateLabel";
            this.priceApplicableDateLabel.Size = new System.Drawing.Size(71, 13);
            this.priceApplicableDateLabel.TabIndex = 2;
            this.priceApplicableDateLabel.Text = "Specific Date";
            // 
            // priceApplicableGridView
            // 
            this.priceApplicableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceApplicableGridView.Location = new System.Drawing.Point(12, 40);
            this.priceApplicableGridView.Name = "priceApplicableGridView";
            this.priceApplicableGridView.Size = new System.Drawing.Size(804, 382);
            this.priceApplicableGridView.TabIndex = 3;
            // 
            // clearProductDataButton
            // 
            this.clearProductDataButton.Location = new System.Drawing.Point(680, 5);
            this.clearProductDataButton.Name = "clearProductDataButton";
            this.clearProductDataButton.Size = new System.Drawing.Size(136, 23);
            this.clearProductDataButton.TabIndex = 3;
            this.clearProductDataButton.Text = "Clear Product Data";
            this.clearProductDataButton.UseVisualStyleBackColor = true;
            this.clearProductDataButton.Click += new System.EventHandler(this.clearProductDataButton_Click);
            // 
            // clearPromotionDataButton
            // 
            this.clearPromotionDataButton.Location = new System.Drawing.Point(690, 5);
            this.clearPromotionDataButton.Name = "clearPromotionDataButton";
            this.clearPromotionDataButton.Size = new System.Drawing.Size(126, 23);
            this.clearPromotionDataButton.TabIndex = 4;
            this.clearPromotionDataButton.Text = "Clear Promotion Data";
            this.clearPromotionDataButton.UseVisualStyleBackColor = true;
            this.clearPromotionDataButton.Click += new System.EventHandler(this.clearPromotionDataButton_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 454);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 457);
            this.Name = "Shop";
            this.Text = "SimpleShop";
            this.saleTabPage.ResumeLayout(false);
            this.saleTabPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.promotionTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).EndInit();
            this.priceApplicableTabPage.ResumeLayout(false);
            this.priceApplicableTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceApplicableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage saleTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productTabPage;
      
       
        private System.Windows.Forms.Button createProductButton;
        private System.Windows.Forms.TabPage promotionTabPage;
        private System.Windows.Forms.Button createPromotionButton;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridView promotionGridView;
        private System.Windows.Forms.Button saveProductDataButton;
        private System.Windows.Forms.Button savePromotionDataButton;
        private System.Windows.Forms.TextBox saleProductCodeTextBox;
        private System.Windows.Forms.Label saleProductCodeLabel;
        private System.Windows.Forms.Button submitSaleProducCodeButton;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Label totalPriceInculdeVatValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalPriceValueLabel;
        private System.Windows.Forms.Label totalPriceInculdeVatLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button clearSaleButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage priceApplicableTabPage;
        private System.Windows.Forms.DataGridView priceApplicableGridView;
        private System.Windows.Forms.Label priceApplicableDateLabel;
        private System.Windows.Forms.Button priceApplicableSubmitButton;
        private System.Windows.Forms.DateTimePicker priceApplicableDateTimePicker;
        private System.Windows.Forms.Button clearProductDataButton;
        private System.Windows.Forms.Button clearPromotionDataButton;
    }
}

