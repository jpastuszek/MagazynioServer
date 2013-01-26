using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MagazynioServer
{
    public partial class MagazynioMain : Form
    {
        public MagazynioMain()
        {
            InitializeComponent();
        }

        private void MagazynioMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynioDataSet.SalesHistory' table. You can move, or remove it, as needed.
            this.salesHistoryTableAdapter.Fill(this.magazynioDataSet.SalesHistory);
            // TODO: This line of code loads data into the 'magazynioDataSet.Salesman' table. You can move, or remove it, as needed.
            this.salesmanTableAdapter.Fill(this.magazynioDataSet.Salesman);
            // TODO: This line of code loads data into the 'magazynioDataSet.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.magazynioDataSet.Production);
            this.ProductListRefresh_Action();
            
        }
        
        private void ProductListRefresh_Click(object sender, EventArgs e)
        {
            this.ProductListRefresh_Action();
        }

        private void ProductListRefresh_Action()
        {
            this.productsSaledProducedAvailableTableAdapter.Fill(
                this.magazynioDataSet.ProductsSaledProducedAvailable
            );
            this.productTableAdapter.Fill(
                this.magazynioDataSet.Product
            );
            this.salesHistoryTableAdapter.Fill(
                this.magazynioDataSet.SalesHistory
            );
            
        }

        private void ProductDeleteConfirm_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("To delete: " + ProductDeleteSelect.SelectedValue);
            // return;
            DataRowView item = (DataRowView) ProductDeleteSelect.SelectedItem;
            String productId = item["Id"].ToString();
            String productName = item["Name"].ToString();

            Debug.WriteLine(this.productBindingSource.ToString());

            var confirmation = MessageBox.Show("Serio wywalić: #" + productId + " - " + productName + "?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);

            if (confirmation.ToString() == "Yes") {
                
                this.productTableAdapter.Delete(
                    (int) item["Id"], 
                    item["Name"].ToString(), 
                    (double) item["Price"]
                );
                this.ProductListRefresh_Action();
            }
            
        }

        private void ProductCreateConfirm_Click(object sender, EventArgs e)
        {
            String productName = ProductCreateName.Text;
            Double productPrice = Double.Parse(ProductCreatePrice.Text.Replace('.', ','));
            String productDescription = ProductCreateDescription.Text;

            var confirmation = MessageBox.Show(
                "Popełnić: " + productName + "\n" + 
                "W cenie: " + productPrice.ToString() + "\n" +
                "Z opisem: " + productDescription
                , "Potwierdź dodanie", MessageBoxButtons.YesNo);
            
            if (confirmation.ToString() == "Yes") {
                this.productTableAdapter.Insert(
                    productName, 
                    productPrice, 
                    productDescription
                );
                ProductCreateName.Text = "";
                ProductCreatePrice.Text = "";
                ProductCreateDescription.Text = "";

                this.ProductListRefresh_Action();
            }
        }

        private void ProductProduceConfirm_Click(object sender, EventArgs e)
        {
            int productId = (int)ProductProduceSelect.SelectedValue;
            int productQuantity = Int32.Parse(ProductProduceQuantity.Text);
            this.productionTableAdapter.Insert(productId, DateTime.Now, productQuantity);
            ProductProduceQuantity.Clear();
            this.ProductListRefresh_Action();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ProductListRefresh_Action();
        }

    }
}
