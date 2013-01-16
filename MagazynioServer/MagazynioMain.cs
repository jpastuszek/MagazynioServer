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
            
        }

        private void MagazynioMain_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynioDataSet.ProductsSaledProducedAvailable' table. You can move, or remove it, as needed.
            this.productsSaledProducedAvailableTableAdapter.Fill(this.magazynioDataSet.ProductsSaledProducedAvailable);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
