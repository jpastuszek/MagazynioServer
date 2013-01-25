using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'magazynioDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.magazynioDataSet.Product);
            this.ProductListRefresh_Action();
            
        }
        
        private void ProductListRefresh_Click(object sender, EventArgs e)
        {
            this.ProductListRefresh_Action();
        }

        private void ProductListRefresh_Action()
        {
            this.productsSaledProducedAvailableTableAdapter.Fill(this.magazynioDataSet.ProductsSaledProducedAvailable);
            //ProductDeleteSelect.Items.AddRange(this.magazynioDataSet.ProductsSaledProducedAvailable);
        }

        private void ProductDeleteConfirm_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView) ProductDeleteSelect.SelectedItem;
            String productId = item["Id"].ToString();
            String productName = item["Name"].ToString();
            
            var confirmation = MessageBox.Show("Serio wywalić: #" + productId + " - " + productName + "?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);

            if (confirmation.ToString() == "Yes") {
                this.productTableAdapter.Delete((int) item["Id"], item["Name"].ToString(), (double) item["Price"]);
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
                
                this.productTableAdapter.Insert(productName, productPrice, productDescription);
                this.productBindingSource.ResetBindings(false);
            }
            
            //ProductDeleteSelect.DataBindings.;
        }

    }
}
