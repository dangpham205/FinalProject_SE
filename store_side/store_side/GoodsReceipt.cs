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
        SqlCommand cmd;


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
            if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
            {
                MessageBox.Show("Money value must be integer");
                return;
            }
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "")
            {
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
                    if (int.TryParse(productCost.Text, out i) == false || int.TryParse(productPrice.Text, out i) == false)
                    {
                        MessageBox.Show("Money value must be integer");
                        return;
                    }
                    if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "")
                    {
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
                MessageBox.Show("Please fill the receipt's information");
                return;
            }
            else if (productTable.RowCount == 1)
            {
                MessageBox.Show("You will need to add products first");
                return;
            }
            else
            {
                try
                {
                    connection.Open();
                    try
                    {
                        cmd = new SqlCommand("insert into receipt values(N'" + receiptID.Text + "', N'" + receiptName.Text + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("There is already a receipt with the ID: " + receiptID);
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    foreach (DataGridViewRow r in productTable.Rows)
                    {
                        try
                        {
                            connection.Open();
                            cmd = new SqlCommand("insert into product values(N'" + r.Cells[0].Value.ToString() + "', N'" + r.Cells[1].Value.ToString() + "', N'" + r.Cells[2].Value.ToString() + "', " +
                                "N'" + Int32.Parse(r.Cells[3].Value.ToString()) + "', '" + Int32.Parse(r.Cells[4].Value.ToString()) + "' , N'" + receiptID.Text + "')", connection);
                            try
                            {
                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }
                            catch (System.Data.SqlClient.SqlException)
                            {
                                MessageBox.Show("There is already a product with the ID: " + r.Cells[0].Value.ToString());
                                return;
                            }

                            receiptID.Text = "";
                            receiptName.Text = "";
                            productTable.Rows.Clear();
                            productTable.Refresh();
                        }
                        catch (NullReferenceException)
                        {

                        }
                    }
                }
                catch (System.InvalidOperationException)
                {
                    connection.Close();

                }
            }
        }
    }
}
