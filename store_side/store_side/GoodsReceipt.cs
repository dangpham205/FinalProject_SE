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
            
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productCost.Text != "")
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
                    if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productCost.Text != "")
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
            createProductRow();
            
            /*foreach (DataGridViewRow r in productTable.Rows)
            {
                connection.Open();
                cmd = new SqlCommand("insert into product values('" + r.Cells[0].Value.ToString() +"', '" + r.Cells[1].Value.ToString() +"', '" + r.Cells[2].Value.ToString() +"', " +
                    "'" +  Int32.Parse(r.Cells[3].Value.ToString()) + "', '" + Int32.Parse(r.Cells[4].Value.ToString()) + "' , )", connection);
            }*/
        }

        private void createProductRow()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HAIDANG\SQLEXPRESS;Initial Catalog=cnpm;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select COUNT(*) from product  ", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
        }
    }
}
