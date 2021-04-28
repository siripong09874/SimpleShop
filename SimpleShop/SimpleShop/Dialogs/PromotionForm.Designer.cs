namespace SimpleShop.Dialogs
{
    partial class PromotionForm
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
            this.promotionCodeLabel = new System.Windows.Forms.Label();
            this.promotionCodeTextBox = new System.Windows.Forms.TextBox();
            this.promotionNameLabel = new System.Windows.Forms.Label();
            this.promotionNameTextBox = new System.Windows.Forms.TextBox();
            this.promotionDescriptionLabel = new System.Windows.Forms.Label();
            this.promotionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.startPeriodLabel = new System.Windows.Forms.Label();
            this.startPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endPeriodLabel = new System.Windows.Forms.Label();
            this.endPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createPromotionButton = new System.Windows.Forms.Button();
            this.promotionProductLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.promotionProductPriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.promotionProductPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promotionProductPriceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // promotionCodeLabel
            // 
            this.promotionCodeLabel.AutoSize = true;
            this.promotionCodeLabel.Location = new System.Drawing.Point(13, 13);
            this.promotionCodeLabel.Name = "promotionCodeLabel";
            this.promotionCodeLabel.Size = new System.Drawing.Size(82, 13);
            this.promotionCodeLabel.TabIndex = 0;
            this.promotionCodeLabel.Text = "Promotion Code";
            // 
            // promotionCodeTextBox
            // 
            this.promotionCodeTextBox.Location = new System.Drawing.Point(144, 10);
            this.promotionCodeTextBox.Name = "promotionCodeTextBox";
            this.promotionCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.promotionCodeTextBox.TabIndex = 1;
            // 
            // promotionNameLabel
            // 
            this.promotionNameLabel.AutoSize = true;
            this.promotionNameLabel.Location = new System.Drawing.Point(12, 38);
            this.promotionNameLabel.Name = "promotionNameLabel";
            this.promotionNameLabel.Size = new System.Drawing.Size(85, 13);
            this.promotionNameLabel.TabIndex = 2;
            this.promotionNameLabel.Text = "Promotion Name";
            // 
            // promotionNameTextBox
            // 
            this.promotionNameTextBox.Location = new System.Drawing.Point(144, 35);
            this.promotionNameTextBox.Name = "promotionNameTextBox";
            this.promotionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.promotionNameTextBox.TabIndex = 3;
            // 
            // promotionDescriptionLabel
            // 
            this.promotionDescriptionLabel.AutoSize = true;
            this.promotionDescriptionLabel.Location = new System.Drawing.Point(12, 64);
            this.promotionDescriptionLabel.Name = "promotionDescriptionLabel";
            this.promotionDescriptionLabel.Size = new System.Drawing.Size(110, 13);
            this.promotionDescriptionLabel.TabIndex = 4;
            this.promotionDescriptionLabel.Text = "Promotion Description";
            // 
            // promotionDescriptionTextBox
            // 
            this.promotionDescriptionTextBox.Location = new System.Drawing.Point(144, 61);
            this.promotionDescriptionTextBox.Name = "promotionDescriptionTextBox";
            this.promotionDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.promotionDescriptionTextBox.TabIndex = 5;
            // 
            // startPeriodLabel
            // 
            this.startPeriodLabel.AutoSize = true;
            this.startPeriodLabel.Location = new System.Drawing.Point(12, 147);
            this.startPeriodLabel.Name = "startPeriodLabel";
            this.startPeriodLabel.Size = new System.Drawing.Size(62, 13);
            this.startPeriodLabel.TabIndex = 6;
            this.startPeriodLabel.Text = "Start Period";
            // 
            // startPeriodDateTimePicker
            // 
            this.startPeriodDateTimePicker.Location = new System.Drawing.Point(144, 140);
            this.startPeriodDateTimePicker.Name = "startPeriodDateTimePicker";
            this.startPeriodDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.startPeriodDateTimePicker.TabIndex = 7;
            // 
            // endPeriodLabel
            // 
            this.endPeriodLabel.AutoSize = true;
            this.endPeriodLabel.Location = new System.Drawing.Point(13, 172);
            this.endPeriodLabel.Name = "endPeriodLabel";
            this.endPeriodLabel.Size = new System.Drawing.Size(59, 13);
            this.endPeriodLabel.TabIndex = 8;
            this.endPeriodLabel.Text = "End Period";
            // 
            // endPeriodDateTimePicker
            // 
            this.endPeriodDateTimePicker.Location = new System.Drawing.Point(144, 165);
            this.endPeriodDateTimePicker.MinimumSize = new System.Drawing.Size(132, 20);
            this.endPeriodDateTimePicker.Name = "endPeriodDateTimePicker";
            this.endPeriodDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.endPeriodDateTimePicker.TabIndex = 9;
            // 
            // createPromotionButton
            // 
            this.createPromotionButton.Location = new System.Drawing.Point(93, 196);
            this.createPromotionButton.Name = "createPromotionButton";
            this.createPromotionButton.Size = new System.Drawing.Size(100, 23);
            this.createPromotionButton.TabIndex = 10;
            this.createPromotionButton.Text = "CreatePromotion";
            this.createPromotionButton.UseVisualStyleBackColor = true;
            this.createPromotionButton.Click += new System.EventHandler(this.createPromotionButton_Click);
            // 
            // promotionProductLabel
            // 
            this.promotionProductLabel.AutoSize = true;
            this.promotionProductLabel.Location = new System.Drawing.Point(13, 88);
            this.promotionProductLabel.Name = "promotionProductLabel";
            this.promotionProductLabel.Size = new System.Drawing.Size(94, 13);
            this.promotionProductLabel.TabIndex = 12;
            this.promotionProductLabel.Text = "Promotion Product";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(144, 85);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 13;
            // 
            // promotionProductPriceUpDown
            // 
            this.promotionProductPriceUpDown.Location = new System.Drawing.Point(144, 114);
            this.promotionProductPriceUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.promotionProductPriceUpDown.Name = "promotionProductPriceUpDown";
            this.promotionProductPriceUpDown.Size = new System.Drawing.Size(120, 20);
            this.promotionProductPriceUpDown.TabIndex = 14;
            // 
            // promotionProductPriceLabel
            // 
            this.promotionProductPriceLabel.AutoSize = true;
            this.promotionProductPriceLabel.Location = new System.Drawing.Point(13, 116);
            this.promotionProductPriceLabel.Name = "promotionProductPriceLabel";
            this.promotionProductPriceLabel.Size = new System.Drawing.Size(121, 13);
            this.promotionProductPriceLabel.TabIndex = 15;
            this.promotionProductPriceLabel.Text = "Promotion Product Price";
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.promotionProductPriceLabel);
            this.Controls.Add(this.promotionProductPriceUpDown);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.promotionProductLabel);
            this.Controls.Add(this.createPromotionButton);
            this.Controls.Add(this.endPeriodDateTimePicker);
            this.Controls.Add(this.endPeriodLabel);
            this.Controls.Add(this.startPeriodDateTimePicker);
            this.Controls.Add(this.startPeriodLabel);
            this.Controls.Add(this.promotionDescriptionTextBox);
            this.Controls.Add(this.promotionDescriptionLabel);
            this.Controls.Add(this.promotionNameTextBox);
            this.Controls.Add(this.promotionNameLabel);
            this.Controls.Add(this.promotionCodeTextBox);
            this.Controls.Add(this.promotionCodeLabel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 300);
            this.Name = "PromotionForm";
            this.Text = "PromotionForm";
            ((System.ComponentModel.ISupportInitialize)(this.promotionProductPriceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promotionCodeLabel;
        private System.Windows.Forms.TextBox promotionCodeTextBox;
        private System.Windows.Forms.Label promotionNameLabel;
        private System.Windows.Forms.TextBox promotionNameTextBox;
        private System.Windows.Forms.Label promotionDescriptionLabel;
        private System.Windows.Forms.TextBox promotionDescriptionTextBox;
        private System.Windows.Forms.Label startPeriodLabel;
        private System.Windows.Forms.DateTimePicker startPeriodDateTimePicker;
        private System.Windows.Forms.Label endPeriodLabel;
        private System.Windows.Forms.DateTimePicker endPeriodDateTimePicker;
        private System.Windows.Forms.Button createPromotionButton;
        private System.Windows.Forms.Label promotionProductLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.NumericUpDown promotionProductPriceUpDown;
        private System.Windows.Forms.Label promotionProductPriceLabel;
    }
}