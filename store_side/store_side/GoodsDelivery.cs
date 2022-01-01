using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_side
{
    public partial class GoodsDelivery : Form
    {
        public GoodsDelivery()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void GoodsDelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        private void productTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productTable.ClearSelection();
        }
    }
}
