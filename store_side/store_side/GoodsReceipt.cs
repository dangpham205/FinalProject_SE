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
    public partial class GoodsReceipt : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=HAIDANG\SQLEXPRESS;Initial Catalog=cnpm;Integrated Security=True");


        public GoodsReceipt()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.productTable.Rows[e.RowIndex];
                try
                {
                    productID.Text = row.Cells[0].Value.ToString();
                    productName.Text = row.Cells[1].Value.ToString();
                    productUnit.Text = row.Cells[2].Value.ToString();
                    productCost.Text = row.Cells[3].Value.ToString();
                    productPrice.Text = row.Cells[4].Value.ToString();
                }
                catch (NullReferenceException)
                {
                    productID.Text = "";
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            productID.Text = "";
            productName.Text = "";
            productUnit.Text = "";
            productCost.Text = "";
            productPrice.Text = "";

            receiptID.Text = "";
            receiptName.Text = "";
            productTable.Rows.Clear();
            productTable.Refresh();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(productTable.RowCount >1)
            {
                foreach (DataGridViewRow r in productTable.Rows)
                {
                    try
                    {
                        if (r.Cells[0].Value.ToString().Equals(productID.Text))
                        {
                            MessageBox.Show("Can not add because this ID already existed");
                            return;
                        }
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }
            int i;
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "" && productCost.Text != "")
            {
                if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
                {
                    MessageBox.Show("Money value must be integer");
                    return;
                }
                if (int.TryParse(productUnit.Text, out i) == false )
                {
                    MessageBox.Show("Unit value must be integer");
                    return;
                }
                int rowId = productTable.Rows.Add();
                // Grab the new row
                DataGridViewRow row = productTable.Rows[rowId];

                row.Cells[0].Value = productID.Text;
                row.Cells[1].Value = productName.Text;
                row.Cells[2].Value = productUnit.Text;
                row.Cells[3].Value = productCost.Text;
                row.Cells[4].Value = productPrice.Text;

                productID.Text = "";
                productName.Text = "";
                productUnit.Text = "";
                productCost.Text = "";
                productPrice.Text = "";

            }
            else
            {
                MessageBox.Show("Please enter all the information!!!");
            }

        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (productTable.RowCount > 1)
            {
                try
                {
                    int rowId = productTable.CurrentCell.RowIndex;
                    DataGridViewRow row = productTable.Rows[rowId];
                    int i;
                    if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "" && productCost.Text != "")
                    {
                        if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
                        {
                            MessageBox.Show("Money value must be integer");
                            return;
                        }
                        if (int.TryParse(productUnit.Text, out i) == false)
                        {
                            MessageBox.Show("Unit value must be integer");
                            return;
                        }
                        row.Cells[0].Value = productID.Text;
                        row.Cells[1].Value = productName.Text;
                        row.Cells[2].Value = productUnit.Text;
                        row.Cells[3].Value = productCost.Text;
                        row.Cells[4].Value = productPrice.Text;

                        productID.Text = "";
                        productName.Text = "";
                        productUnit.Text = "";
                        productCost.Text = "";
                        productPrice.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Can not update");
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Can not update");
                }
            }
            else
            {
                MessageBox.Show("Can not update");
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productTable.RowCount > 1)
            {
                try
                {
                    int rowId = productTable.CurrentCell.RowIndex;
                    productTable.Rows.RemoveAt(rowId);

                    productID.Text = "";
                    productName.Text = "";
                    productUnit.Text = "";
                    productCost.Text = "";
                    productPrice.Text = "";
                }
                catch(InvalidOperationException )
                {
                    MessageBox.Show("Can not delete");
                }
            }
            else
            {
                MessageBox.Show("Can not delete");
            }
       
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (receiptID.Text == "" || receiptName.Text == "")
            {
                MessageBox.Show("Please fill the receipt's information.");
                return;
            }
            else if (productTable.RowCount == 1)
            {
                MessageBox.Show("You will need to add your products first.");
                return;
            }
            else
            {
                try
                {
                    cnpmDataSet.receiptRow receipt = this.cnpmDataSet.receipt.AddreceiptRow(
                    receiptID.Text, receiptName.Text);
                    this.receiptTableAdapter.Update(receipt);
                    foreach (DataGridViewRow row in productTable.Rows)
                    {
                        try
                        {
                            try
                            {
                                cnpmDataSet.productRow product = this.cnpmDataSet.product.AddproductRow(
                                row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(),
                                Int32.Parse(row.Cells[3].Value.ToString()), Int32.Parse(row.Cells[4].Value.ToString()), receiptID.Text);
                                this.productTableAdapter.Update(product);
                            }
                            catch (System.NullReferenceException)
                            {
                                MessageBox.Show("Add Succeed!!");

                                productID.Text = "";
                                productName.Text = "";
                                productUnit.Text = "";
                                productCost.Text = "";
                                productPrice.Text = "";

                                receiptID.Text = "";
                                receiptName.Text = "";
                                productTable.Rows.Clear();
                                productTable.Refresh();
                                return;
                            }
                        }
                        catch (System.Data.ConstraintException)
                        {
                            MessageBox.Show("There is already a Product with the ID: " + row.Cells[0].Value.ToString());
                            return;
                        }
                    }

                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("There is already a Receipt with the ID: " + receiptID.Text);
                    return;
                }

            }
        }


        private void GoodsReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.cnpmDataSet.receipt);
            // TODO: This line of code loads data into the 'cnpmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        private void productTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productTable.ClearSelection();
        }
    }
}
