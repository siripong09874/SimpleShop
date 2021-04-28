using SimpleShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShop.Dialogs
{
    public partial class PromotionForm : Form
    {

        public Promotion promotion;
        public PromotionForm()
        {
            InitializeComponent();

            productComboBox.DataSource = null;
            productComboBox.DataSource = Shop.productList;
            productComboBox.ValueMember = "id";
            productComboBox.DisplayMember = "productName";
            productComboBox.Update();
            productComboBox.Refresh();
        }

        private void createPromotionButton_Click(object sender, EventArgs e)
        {

            #region Validate

            if (string.IsNullOrEmpty(promotionCodeTextBox.Text))
            {
                MessageBox.Show("Please enter Promotion Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //CheckDupliate promotionCode

                if (Shop.promotionList != null)
                {
                    if (Shop.promotionList.Count > 0)
                        try
                        {
                            Promotion promotionDup = Shop.promotionList
                                .Where(p => p.promotionCode == promotionCodeTextBox.Text).FirstOrDefault();

                            if (promotionDup != null)
                            {

                                MessageBox.Show("Promotion Code Duplicate !! Please enter New Promotion Code "
                                  , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch
                        {

                        }

                }

            }

            if (string.IsNullOrEmpty(promotionNameTextBox.Text))
            {
                MessageBox.Show("Please enter Promotion Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please Select  Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(promotionDescriptionTextBox.Text))
            {
                MessageBox.Show("Please enter Promotion Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (endPeriodDateTimePicker.Value.Date < startPeriodDateTimePicker.Value.Date)
            {
                MessageBox.Show("Please enter Promotion End Period > Start Period", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Promotion productPromotion
                    = Shop.promotionList.Where(p => p.productId == Convert.ToInt32(productComboBox.SelectedValue)).FirstOrDefault();

                if (productPromotion != null)
                {
                    bool promotionOverlapped = IsOverlapped(productPromotion.startDate, productPromotion.endDate
                        , startPeriodDateTimePicker.Value.Date, endPeriodDateTimePicker.Value.Date);

                    if (promotionOverlapped)

                    {
                        MessageBox.Show(string.Format("Promotion Period is Overlapped({0})", productPromotion.promotionCode), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            if(promotionProductPriceUpDown.Value ==0)
            {
                MessageBox.Show("Please enter Promotion Product Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (Shop.productList != null)
                {
                    if (Shop.productList.Count > 0)
                        try
                        {
                            Product productInfo = Shop.productList
                                .Where(p => p.id == Convert.ToInt32(productComboBox.SelectedValue)).FirstOrDefault();

                            if (productInfo != null)
                            {
                                if (promotionProductPriceUpDown.Value < productInfo.productNetPrice)
                                {
                                    MessageBox.Show(string.Format("Product Promotion Price  = {0} can not lower than Product net price({1})", promotionProductPriceUpDown.Value, productInfo.productNetPrice)
                                        , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                        catch
                        {

                        }

                }
            }

            #endregion 

            promotion = new Promotion();

            int promotionId = 0;

            if (Shop.promotionList != null)
            {
                if (Shop.promotionList.Count > 0)
                    try
                    {
                        promotionId = Shop.promotionList.Max(t => t.id);
                    }
                    catch
                    {

                    }

                promotionId++;
            }
            else
                promotionId++;

            promotion.id = promotionId;
            promotion.promotionCode = promotionCodeTextBox.Text;
            promotion.promotionName = promotionNameTextBox.Text;
            promotion.promotionDescription = promotionDescriptionTextBox.Text;
            promotion.productId = Convert.ToInt32(productComboBox.SelectedValue);
            promotion.productPromotionPrice = promotionProductPriceUpDown.Value;
            promotion.startDate = startPeriodDateTimePicker.Value.Date;
            promotion.endDate = endPeriodDateTimePicker.Value.Date;

            this.DialogResult = DialogResult.OK;
        }

        private bool IsOverlapped(DateTime start1, DateTime end1, DateTime start2, DateTime end2)

        {


            //DateTime dtStart1 = DateTime.ParseExact(start1, "yyyyMMdd", null);
            //DateTime dtEnd1 = DateTime.ParseExact(end1, "yyyyMMdd", null);
            //DateTime dtStart2 = DateTime.ParseExact(start2, "yyyyMMdd", null);
            //DateTime dtEnd2 = DateTime.ParseExact(end2, "yyyyMMdd", null);

            bool isOverlap = start1 <= end2 && start2 <= end1;


            if (isOverlap)
                Console.WriteLine("OverLap");
            else
                Console.WriteLine("Not OverLap");

            return isOverlap;

        }
    }
}
