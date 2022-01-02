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
    public partial class ManageGoodsDelivery : Form
    {
        public ManageGoodsDelivery()
        {
            InitializeComponent();
        }

        private void ManageGoodsDelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet2.exportProduct' table. You can move, or remove it, as needed.
            this.exportProductTableAdapter.Fill(this.cnpmDataSet2.exportProduct);
            // TODO: This line of code loads data into the 'cnpmDataSet1.product2' table. You can move, or remove it, as needed.
            this.product2TableAdapter.Fill(this.cnpmDataSet1.product2);
            // TODO: This line of code loads data into the 'cnpmDataSet1.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.cnpmDataSet1.bill);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }
    }
}
