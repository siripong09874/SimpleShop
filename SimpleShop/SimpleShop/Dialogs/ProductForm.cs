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
    public partial class ProductForm : Form
    {
        public Product product;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {

            #region Validate
          
            if(string.IsNullOrEmpty(productCodeTextBox.Text))
            {
                MessageBox.Show("Please enter Product Code", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //CheckDupliate productCode

                if (Shop.productList != null)
                {
                    if (Shop.productList.Count > 0)
                        try
                        {
                            Product productDup = Shop.productList
                                .Where(p => p.productCode == productCodeTextBox.Text).FirstOrDefault();

                            if (productDup != null)
                            {
                                MessageBox.Show("Product Code Duplicate !! Please enter New Product Code "
                                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch
                        {

                        }
                    
                }
               
            }

            if (string.IsNullOrEmpty(productNameTextBox.Text))
            {
                MessageBox.Show("Please enter Product Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(productSloganTextBox.Text))
            {
                MessageBox.Show("Please enter Product Slogan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (productNetPriceUpDown.Value == 0)
            //{
            //    MessageBox.Show("Please enter Product Net Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}



            if (productSalesPriceUpDown.Value < productNetPriceUpDown.Value)
            {
                MessageBox.Show("Please enter Product Sales Price > Net Price (Sale Price can not lower than Net Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            #endregion



            product = new Product();


            int productId = 0;

            if (Shop.productList != null)
            {
                if (Shop.productList.Count > 0)
                    try
                    {
                        productId = Shop.productList.Max(t => t.id);
                    }
                    catch
                    {

                    }

                productId++;
            }
            else
                productId++;

            product.id = productId++;

            product.productCode = productCodeTextBox.Text;
            product.productName = productNameTextBox.Text;
            product.productDescription = productSloganTextBox.Text;
            product.slogan = productSloganTextBox.Text;
            product.productNetPrice = productNetPriceUpDown.Value;
            product.productSalesPrice = productSalesPriceUpDown.Value;
           

            this.DialogResult = DialogResult.OK;

        }
    }
}
