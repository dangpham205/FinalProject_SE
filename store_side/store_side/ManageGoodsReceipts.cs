using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace store_side
{
    public partial class ManageGoodsReceipts : Form
    {
        public ManageGoodsReceipts()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void ManageGoodsReceipts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.cnpmDataSet.receipt);
            // TODO: This line of code loads data into the 'cnpmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        private void receiptTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = this.receiptTable.Rows[e.RowIndex];

                foreach (DataGridViewRow row in productTable.Rows)
                {
                    try
                    {
                        if (row.Cells[1].Value.ToString() == r.Cells[0].Value.ToString())
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
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.productTable.Rows[e.RowIndex];
                try
                {
                    productID.Text = row.Cells[0].Value.ToString();
                    productReceipt.Text = row.Cells[1].Value.ToString();
                    productName.Text = row.Cells[2].Value.ToString();
                    productUnit.Text = row.Cells[3].Value.ToString();
                    productCost.Text = row.Cells[4].Value.ToString();
                    productPrice.Text = row.Cells[5].Value.ToString();
                    productID.Enabled = false;
                    productReceipt.Enabled = false;
                }
                catch (NullReferenceException)
                {
                    productID.Text = "";
                    productReceipt.Text = "";
                    productName.Text = "";
                    productUnit.Text = "";
                    productCost.Text = "";
                    productPrice.Text = "";
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void allProductButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        private void productTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productTable.ClearSelection();
        }

        private void receiptTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            receiptTable.ClearSelection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productID.Text = "";
            productReceipt.Text = "";
            productName.Text = "";
            productUnit.Text = "";
            productCost.Text = "";
            productPrice.Text = "";
            productID.Enabled = true;
            productReceipt.Enabled = true;
            productTable.ClearSelection();
            receiptTable.ClearSelection();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            int t1 = productTable.RowCount;
            int i;
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "" && productCost.Text != "" && productReceipt.Text != "")
            {
                if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
                {
                    MessageBox.Show("Money value must be integer");
                    return;
                }
                foreach (DataGridViewRow r in receiptTable.Rows)
                {
                    if (r.Cells[0].Value.ToString().Equals(productReceipt.Text))
                    {
                        try
                        {
                            cnpmDataSet.productRow product = this.cnpmDataSet.product.AddproductRow(
                            productID.Text, productName.Text, productUnit.Text, Int32.Parse(productCost.Text),
                            Int32.Parse(productPrice.Text), productReceipt.Text);
                            this.productTableAdapter.Update(product);
                            MessageBox.Show("Add Succeed!!");

                            productID.Text = "";
                            productReceipt.Text = "";
                            productName.Text = "";
                            productUnit.Text = "";
                            productCost.Text = "";
                            productPrice.Text = "";
                            productID.Enabled = true;
                            productReceipt.Enabled = true;
                            productTable.ClearSelection();
                            receiptTable.ClearSelection();
                            return;
                        }
                        catch (System.Data.ConstraintException)
                        {
                            MessageBox.Show("There is already a Product with the ID: " + productID.Text);
                            return;
                        }
                    }
                }
                int t2 = productTable.RowCount;
                if (t1 == t2)
                {
                    MessageBox.Show("Receipt ID does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the information.");
            }
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            int i;
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "" && productCost.Text != "")
            {
                if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
                {
                    MessageBox.Show("Money value must be integer");
                    return;
                }
                int rowIndex = this.productTable.CurrentCell.RowIndex;
                cnpmDataSet.productRow product = (cnpmDataSet.productRow)this.cnpmDataSet.product.Rows[rowIndex];
                product.prod_id = productID.Text;
                product.prod_name = productName.Text;
                product.prod_unit = productUnit.Text;
                product.prod_cost = Int32.Parse(productCost.Text.ToString());
                product.prod_price = Int32.Parse(productPrice.Text.ToString());
                product.prod_belong = productReceipt.Text;
                this.productTableAdapter.Update(product);

                productID.Text = "";
                productReceipt.Text = "";
                productName.Text = "";
                productUnit.Text = "";
                productCost.Text = "";
                productPrice.Text = "";
                productID.Enabled = true;
                productReceipt.Enabled = true;
                productTable.ClearSelection();
                receiptTable.ClearSelection();
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Please fill out all the information");
            }


        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productTable.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                "Are you sure?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int rowIndex = this.productTable.CurrentCell.RowIndex;
                    cnpmDataSet.productRow product = (cnpmDataSet.productRow)this.cnpmDataSet.product.Rows[rowIndex];
                    product.Delete();
                    this.productTableAdapter.Update(product);
                    productID.Text = "";
                    productReceipt.Text = "";
                    productName.Text = "";
                    productUnit.Text = "";
                    productCost.Text = "";
                    productPrice.Text = "";
                    productID.Enabled = true;
                    productReceipt.Enabled = true;
                    productTable.ClearSelection();
                    receiptTable.ClearSelection();

                    MessageBox.Show("Deleted!!!");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
            
        }

        private void deleteReceiptButton_Click(object sender, EventArgs e)
        {
            if (receiptTable.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                "Are you sure?", "Delete Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int rowIndex = this.receiptTable.CurrentCell.RowIndex;
                    cnpmDataSet.receiptRow receipt = (cnpmDataSet.receiptRow)this.cnpmDataSet.receipt.Rows[rowIndex];
                    string id = receiptTable.Rows[rowIndex].Cells[0].Value.ToString();
                    receipt.Delete();
                    this.receiptTableAdapter.Update(receipt);

                    for (int i = productTable.Rows.Count -1; i >=0; i--)
                    {
                        cnpmDataSet.productRow product = (cnpmDataSet.productRow)this.cnpmDataSet.product.Rows[i];
                        if (product.prod_belong.Equals(id))
                        {
                            product.Delete();
                            this.productTableAdapter.Update(product);

                        }
                    }
                    MessageBox.Show("Deleted!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a receipt to delete.");
                return;
            }
        }
    }
}
