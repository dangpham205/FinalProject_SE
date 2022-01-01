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
    }
}
