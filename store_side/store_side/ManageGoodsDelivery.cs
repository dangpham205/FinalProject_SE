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
            billDelivery.Items.Add("Not Arrived");
            billDelivery.Items.Add("Arriving");
            billDelivery.Items.Add("Arrived");
            billDelivery.DropDownStyle = ComboBoxStyle.DropDownList;
            billPayment.Items.Add("Unpaid");
            billPayment.Items.Add("Paid");
            billPayment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ManageGoodsDelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet1.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.cnpmDataSet1.bill);
            // TODO: This line of code loads data into the 'cnpmDataSet1.product2' table. You can move, or remove it, as needed.
            this.product2TableAdapter.Fill(this.cnpmDataSet1.product2);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void billTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            billTable.ClearSelection();
        }

        private void productTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productTable.ClearSelection();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.product2TableAdapter.Fill(this.cnpmDataSet1.product2);
            billTable.ClearSelection();
            productTable.ClearSelection();
        }

        private void billTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow r = this.billTable.Rows[e.RowIndex];
            billDelivery.Text = r.Cells[4].Value.ToString();
            billPayment.Text = r.Cells[5].Value.ToString();
            foreach (DataGridViewRow row in productTable.Rows)
            {
                try
                {
                    if (row.Cells[4].Value.ToString() == r.Cells[0].Value.ToString())
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        CurrencyManager currencyManager = (CurrencyManager)BindingContext[productTable.DataSource];
                        currencyManager.SuspendBinding();
                        productTable.Rows[productTable.Rows.IndexOf(row)].Visible = false;
                        currencyManager.ResumeBinding();
                    }
                }
                catch (NullReferenceException)
                {
                    continue;
                }
            }
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (billTable.SelectedCells.Count > 0)
            {
                int rowIndex = this.billTable.CurrentCell.RowIndex;
                cnpmDataSet1.billRow bill = (cnpmDataSet1.billRow)this.cnpmDataSet1.bill.Rows[rowIndex];
                bill.delivery_status = billDelivery.Text;
                bill.payment_status = billPayment.Text;
                this.billTableAdapter.Update(bill);
            }
            else
            {
                MessageBox.Show("Please select a note to update.");
            }
        }

        private void deleteReceiptButton_Click(object sender, EventArgs e)
        {
            if (billTable.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                "Are you sure?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int rowIndex = this.billTable.CurrentCell.RowIndex;
                    cnpmDataSet1.billRow bill = (cnpmDataSet1.billRow)this.cnpmDataSet1.bill.Rows[rowIndex];
                    string id = billTable.Rows[rowIndex].Cells[0].Value.ToString();
                    bill.Delete();
                    this.billTableAdapter.Update(bill);
                    for (int i = productTable.Rows.Count - 1; i >= 0; i--)
                    {
                        cnpmDataSet1.product2Row product2 = (cnpmDataSet1.product2Row)this.cnpmDataSet1.product2.Rows[i];
                        if (product2.prod_belong.Equals(id))
                        {
                            product2.Delete();
                            this.product2TableAdapter.Update(product2);

                        }
                    }
                    MessageBox.Show("Deleted!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a note to remove.");
                return;
            }
        }
    }
}
