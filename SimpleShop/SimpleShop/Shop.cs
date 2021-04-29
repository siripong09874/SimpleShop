using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleShop.Dialogs;
using SimpleShop.Models;
using Newtonsoft.Json;
using System.IO;

namespace SimpleShop
{


    public partial class Shop : Form
    {

        public static List<Product> productList;
        public static List<Promotion> promotionList;
        public static List<Sales> salesList;
        public static List<PriceApplicable> priceApplicableList;

        public static string productFileName = "product.txt";
        public static string promotionFileName = "promotion.txt";

        public static decimal VatRatio = 1.07m;

        public Shop()
        {
            productList = new List<Product>();
            promotionList = new List<Promotion>();
            salesList = new List<Sales>();

            InitializeComponent();

            GetProductData();

            GetPromotionData();
            //createProduct();
        }

        //private void createProduct()
        //{
        //    Product p1 = new Product();
        //    p1.id = 1;
        //    p1.productCode = "C1";
        //    p1.productDescription = "Desc";
        //    p1.productName = "Test Product";
        //    p1.productNetPrice = 142.33M;
        //    p1.productSalesPrice = 150;
        //    //p1.productSalesPriceWithVatRatio = 159.5M;

        //    productList.Add(p1);

        //    productGridView.DataSource = productList;

        //}

        private void GetProductData()
        {
            string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");

            try
            {
                string textFile = Path.Combine(directoryPath, productFileName);
                if (File.Exists(textFile))
                {
                    string text = File.ReadAllText(textFile);

                    if (!string.IsNullOrEmpty(text))
                    {

                        productList = (List<Product>)JsonConvert.DeserializeObject(text, typeof(List<Product>));

                        productGridView.DataSource = null;

                        productGridView.DataSource = productList;

                        productGridView.Update();

                        productGridView.Refresh();

                    }
                }


            }
            catch (Exception ex)
            {
                productList = new List<Product>();

                productGridView.DataSource = null;

                productGridView.DataSource = productList;

                productGridView.Update();

                productGridView.Refresh();
            }


        }

        private void GetPromotionData()
        {
            string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");

            try
            {
                string textFile = Path.Combine(directoryPath, promotionFileName);
                if (File.Exists(textFile))
                {
                    string text = File.ReadAllText(textFile);

                    if (!string.IsNullOrEmpty(text))
                    {

                        promotionList = (List<Promotion>)JsonConvert.DeserializeObject(text, typeof(List<Promotion>));

                        promotionGridView.DataSource = null;

                        promotionGridView.DataSource = promotionList;

                        promotionGridView.Update();

                        promotionGridView.Refresh();

                    }
                }


            }
            catch (Exception ex)
            {
                promotionList = new List<Promotion>();

                promotionGridView.DataSource = null;

                promotionGridView.DataSource = productList;

                promotionGridView.Update();

                promotionGridView.Refresh();
            }
        }

        private void productTabPage_Click(object sender, EventArgs e)
        {
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();

            if (productForm.ShowDialog(this) == DialogResult.OK)
            {
                productList.Add(productForm.product);

                productGridView.DataSource = null;

                productGridView.DataSource = productList;

                productGridView.Update();

                productGridView.Refresh();


            }

            productForm.Dispose();
        }

        private void createPromotionButton_Click(object sender, EventArgs e)
        {
            PromotionForm promotionForm = new PromotionForm();

            if (promotionForm.ShowDialog(this) == DialogResult.OK)
            {
                promotionList.Add(promotionForm.promotion);

                promotionGridView.DataSource = null;

                promotionGridView.DataSource = promotionList;

                promotionGridView.Update();

                promotionGridView.Refresh();


            }

            promotionForm.Dispose();
        }

        private void saveProductDataButton_Click(object sender, EventArgs e)
        {
            if (productList != null)
            {
                if (productList.Count <= 0)
                {
                    MessageBox.Show("product data is null or empty", "Warning"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                string productJson = JsonConvert.SerializeObject(productList);

                string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");


                try
                {
                    if (Directory.Exists(directoryPath))
                    {

                        string path = Path.Combine(directoryPath, productFileName);
                        File.WriteAllText(path, productJson);

                        MessageBox.Show("Save Product Data Success!", "Success"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(directoryPath);

                        string path = Path.Combine(directoryPath, productFileName);
                        File.WriteAllText(path, productJson);

                        MessageBox.Show("Save Product Data Success!", "Success"
                          , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning"
                          , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    throw new Exception(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("product data is null or empty", "Warning"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void savePromotionDataButton_Click(object sender, EventArgs e)
        {
            if (promotionList != null)
            {
                if (promotionList.Count <= 0)
                {
                    MessageBox.Show("promotion data is null or empty", "Warning"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                string promotionJson = JsonConvert.SerializeObject(promotionList);

                string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");


                try
                {
                    if (Directory.Exists(directoryPath))
                    {

                        string path = Path.Combine(directoryPath, promotionFileName);
                        File.WriteAllText(path, promotionJson);

                        MessageBox.Show("Save Promotion Data Success!", "Success"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(directoryPath);

                        string path = Path.Combine(directoryPath, promotionFileName);
                        File.WriteAllText(path, promotionJson);

                        MessageBox.Show("Save Promotion Data Success!", "Success"
                          , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning"
                          , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    throw new Exception(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Promotion data is null or empty", "Warning"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void saleProductCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {


                #region validate
                string saleProductCode = saleProductCodeTextBox.Text;

                if (string.IsNullOrEmpty(saleProductCode))
                {
                    MessageBox.Show("Sale  - Product Code  is  empty", "Warning"
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (productList == null)
                {
                    MessageBox.Show("Product code not found : product data is null", "Warning"
                          , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (productList.Count > 0)
                    {
                        Product productCheck = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                        if (productCheck == null)
                        {
                            MessageBox.Show("Product Code not found !! Please enter valid product code "
                                , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product code not found : product data is null", "Warning"
                         , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }




                #endregion

                if (salesList != null)
                {
                    Sales salesProductCheck = salesList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                    if (salesProductCheck != null)
                    {
                        salesProductCheck.productAmount++;

                        salesGridView.DataSource = null;

                        salesGridView.DataSource = salesList;

                        salesGridView.Update();

                        salesGridView.Refresh();
                    }
                    else
                    {
                        Product productInfo = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                        if (productInfo != null)
                        {
                            Sales saleProduct = new Sales();
                            saleProduct.productCode = productInfo.productCode;
                            saleProduct.productName = productInfo.productName;
                            saleProduct.productPrice = productInfo.productSalesPrice;
                            saleProduct.productAmount = 1;
                            CheckProductPromotion(productInfo.id, ref saleProduct);
                            salesList.Add(saleProduct);

                            salesGridView.DataSource = null;

                            salesGridView.DataSource = salesList;

                            salesGridView.Update();

                            salesGridView.Refresh();
                        }
                    }
                }
                else
                {
                    salesList = new List<Sales>();

                    Product productInfo = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                    if (productInfo != null)
                    {
                        Sales saleProduct = new Sales();
                        saleProduct.productCode = productInfo.productCode;
                        saleProduct.productName = productInfo.productName;
                        saleProduct.productPrice = productInfo.productSalesPrice;
                        saleProduct.productAmount = 1;
                        CheckProductPromotion(productInfo.id, ref saleProduct);
                        salesList.Add(saleProduct);

                        salesGridView.DataSource = null;

                        salesGridView.DataSource = salesList;

                        salesGridView.Update();

                        salesGridView.Refresh();
                    }
                }


            }
        }

        private void submitSaleProducCodeButton_Click(object sender, EventArgs e)
        {
            #region validate
            string saleProductCode = saleProductCodeTextBox.Text;

            if (string.IsNullOrEmpty(saleProductCode))
            {
                MessageBox.Show("Sale  - Product Code  is  empty", "Warning"
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (productList == null)
            {
                MessageBox.Show("Product code not found : product data is null", "Warning"
                      , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (productList.Count > 0)
                {
                    Product productCheck = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                    if (productCheck == null)
                    {
                        MessageBox.Show("Product Code not found !! Please enter valid product code "
                            , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Product code not found : product data is null", "Warning"
                     , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }




            #endregion

            if (salesList != null)
            {
                Sales salesProductCheck = salesList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                if (salesProductCheck != null)
                {
                    salesProductCheck.productAmount++;

                    salesGridView.DataSource = null;

                    salesGridView.DataSource = salesList;

                    salesGridView.Update();

                    salesGridView.Refresh();
                }
                else
                {
                    Product productInfo = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                    if (productInfo != null)
                    {
                        Sales saleProduct = new Sales();
                        saleProduct.productCode = productInfo.productCode;
                        saleProduct.productName = productInfo.productName;
                        saleProduct.productPrice = productInfo.productSalesPrice;
                        saleProduct.productAmount = 1;

                        CheckProductPromotion(productInfo.id, ref saleProduct);


                        salesList.Add(saleProduct);

                        salesGridView.DataSource = null;

                        salesGridView.DataSource = salesList;

                        salesGridView.Update();

                        salesGridView.Refresh();
                    }
                }
            }
            else
            {
                salesList = new List<Sales>();

                Product productInfo = productList.Where(p => p.productCode == saleProductCode).FirstOrDefault();

                if (productInfo != null)
                {
                    Sales saleProduct = new Sales();
                    saleProduct.productCode = productInfo.productCode;
                    saleProduct.productName = productInfo.productName;
                    saleProduct.productPrice = productInfo.productSalesPrice;
                    saleProduct.productAmount = 1;

                    CheckProductPromotion(productInfo.id, ref saleProduct);

                    salesList.Add(saleProduct);

                    salesGridView.DataSource = null;

                    salesGridView.DataSource = salesList;

                    salesGridView.Update();

                    salesGridView.Refresh();
                }
            }
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            decimal sumTotal = salesList.Sum(s => s.totalPrice);

            totalPriceValueLabel.Text = sumTotal.ToString("#.##");
            totalPriceInculdeVatValueLabel.Text = (sumTotal * VatRatio).ToString("#.##");


        }

        private void clearSaleButton_Click(object sender, EventArgs e)
        {
            totalPriceValueLabel.Text = "0";
            totalPriceInculdeVatValueLabel.Text = "0";

            salesGridView.DataSource = null;

            salesList = new List<Sales>();

            salesGridView.DataSource = salesList;

            salesGridView.Update();

            salesGridView.Refresh();
        }

        private void CheckProductPromotion(int productId, ref Sales saleProduct)
        {


            Promotion promotion = promotionList.Where(p => p.productId == productId
                                         & DateTime.Now.Date >= p.startDate & DateTime.Now.Date <= p.endDate).FirstOrDefault();

            if (promotion != null)
            {
                if (promotion.productPromotionPrice <= 0)
                    saleProduct.productPromotionDiscountSalesPrice = null;
                else
                    saleProduct.productPromotionDiscountSalesPrice = promotion.productPromotionPrice;
            }

            //return promotion;
        }

        private void priceApplicableSubmitButton_Click(object sender, EventArgs e)
        {

            if (priceApplicableDateTimePicker.Value != null)
            {
                priceApplicableList = new List<PriceApplicable>();

                var query = //from promotion in promotionList
                            // join product in productList on promotion.productId equals product.id into ds
                            //from product in ds.DefaultIfEmpty()
                            //where priceApplicableDateTimePicker.Value.Date >= promotion.startDate
                            //& priceApplicableDateTimePicker.Value.Date <= promotion.endDate
                            //select new PriceApplicable()
                            //{
                            //    //productId = product.id
                            //    // ,
                            //    productCode = product.productCode
                            //    ,
                            //    productName = product.productName
                            //    ,
                            //    slogan = product.slogan
                            //    ,
                            //    productNetPrice = product.productNetPrice
                            //    ,
                            //    productSalesPrice = product.productSalesPrice
                            //    ,
                            //    promotionCode = promotion.promotionCode
                            //    ,
                            //    promotionName = promotion.promotionName
                            //    ,
                            //    promotionDescription = promotion.promotionDescription
                            //    ,
                            //    productPromotionPrice = promotion.productPromotionPrice
                            //    ,
                            //    startDate = promotion.startDate
                            //    ,
                            //    endDate = promotion.endDate


                //};

                from product in productList

                from promotion in promotionList


                .Where(pro => priceApplicableDateTimePicker.Value.Date >= pro.startDate
                & priceApplicableDateTimePicker.Value.Date <= pro.endDate
                & product.id == pro.id).DefaultIfEmpty()
                select new PriceApplicable()
                {
                    //productId = product.id
                    // ,
                    productCode = product.productCode
                    ,
                    productName = product.productName
                    ,
                    slogan = product.slogan
                    ,
                    productNetPrice = product.productNetPrice
                    ,
                    productSalesPrice = product.productSalesPrice
                    ,
                    promotionCode = (promotion == null ? "" : promotion.promotionCode)

                    ,
                    promotionName = (promotion == null ? "" : promotion.promotionName)
                    ,
                    promotionDescription = (promotion == null ? "" : promotion.promotionDescription)
                    ,
                    productPromotionPrice = (promotion == null ? 0 : promotion.productPromotionPrice)
                    //,
                    //startDate = (promotion == null ? null : promotion.startDate)
                    //,
                    //endDate = (promotion == null ? null: promotion.endDate)


                };

                priceApplicableList = query.ToList();

                if (priceApplicableList != null)
                {
                    priceApplicableGridView.DataSource = null;

                    priceApplicableGridView.DataSource = priceApplicableList;

                    priceApplicableGridView.Update();

                    priceApplicableGridView.Refresh();
                }
                else
                {
                    priceApplicableGridView.DataSource = null;

                    priceApplicableList = new List<PriceApplicable>();

                    priceApplicableGridView.DataSource = new List<PriceApplicable>();

                    priceApplicableGridView.Update();

                    priceApplicableGridView.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select specifie date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void clearProductDataButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to delete product data ?,If delete product data .promotion data will be delete"
                , "Confirm Delete!!"
                , MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                productList = new List<Product>();

                productGridView.DataSource = null;

                productGridView.DataSource = productList;

                productGridView.Update();

                productGridView.Refresh();
                //
                //

                promotionList = new List<Promotion>();


                promotionGridView.DataSource = null;

                promotionGridView.DataSource = promotionList;

                promotionGridView.Update();

                promotionGridView.Refresh();

                try
                {
                    string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");

                    string productTextFile = Path.Combine(directoryPath, productFileName);
                    if (File.Exists(productTextFile))
                        File.Delete(productTextFile);


                    string promotionTextFile = Path.Combine(directoryPath, promotionFileName);

                    if (File.Exists(promotionTextFile))

                        File.Delete(promotionTextFile);


                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                MessageBox.Show("Product and Promotion are deleted"
                           , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void clearPromotionDataButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to delete promotion data ?", "Confirm Delete!!"
                , MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                promotionList = new List<Promotion>();


                promotionGridView.DataSource = null;

                promotionGridView.DataSource = promotionList;

                promotionGridView.Update();

                promotionGridView.Refresh();


                try
                {
                    string directoryPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Data");

                    string promotionTextFile = Path.Combine(directoryPath, promotionFileName);

                    if (File.Exists(promotionTextFile))
                        File.Delete(promotionTextFile);
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                MessageBox.Show("Promotion are deleted"
                           , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
