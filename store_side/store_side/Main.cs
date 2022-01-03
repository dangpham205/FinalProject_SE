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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoodsReceipt nextForm = new GoodsReceipt();
            nextForm.Show();
        }

        private void manageReceiptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGoodsReceipts nextForm = new ManageGoodsReceipts();
            nextForm.Show();
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoodsDelivery nextForm = new GoodsDelivery();
            nextForm.Show();
        }

        private void manageBillsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGoodsDelivery nextForm = new ManageGoodsDelivery();
            nextForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Do you really want to leave? :(", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                LogIn nextForm = new LogIn();
                nextForm.Show();
                return;
            }
            else
            {
                return;
            }
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagementandIncome nextForm = new StockManagementandIncome();
            nextForm.Show();
        }
    }
}
