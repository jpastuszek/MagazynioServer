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
            // TODO: This line of code loads data into the 'magazynioDataSet.ProductsSaledProducedAvailable' table. You can move, or remove it, as needed.
            this.ProductListRefresh_Action();
        }
        
        private void ProductListRefresh_Click(object sender, EventArgs e)
        {
            this.ProductListRefresh_Action();
        }

        private void ProductListRefresh_Action()
        {
            this.productsSaledProducedAvailableTableAdapter.Fill(this.magazynioDataSet.ProductsSaledProducedAvailable);
        }
    }
}
