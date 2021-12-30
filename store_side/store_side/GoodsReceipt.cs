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
    public partial class GoodsReceipt : Form
    {
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
                productPrice.Text = row.Cells[3].Value.ToString();
            }
            catch (NullReferenceException)
            {
                productID.Text = "";
                productName.Text = "";
                productUnit.Text = "";
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
            
            if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "")
            {
                int rowId = productTable.Rows.Add();
                // Grab the new row
                DataGridViewRow row = productTable.Rows[rowId];

                row.Cells[0].Value = productID.Text;
                row.Cells[1].Value = productName.Text;
                row.Cells[2].Value = productUnit.Text;
                row.Cells[3].Value = productPrice.Text;

                productID.Text = "";
                productName.Text = "";
                productUnit.Text = "";
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
                    if (productID.Text != "" && productName.Text != "" && productUnit.Text != "" && productPrice.Text != "")
                    {
                        row.Cells[0].Value = productID.Text;
                        row.Cells[1].Value = productName.Text;
                        row.Cells[2].Value = productUnit.Text;
                        row.Cells[3].Value = productPrice.Text;

                        productID.Text = "";
                        productName.Text = "";
                        productUnit.Text = "";
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

        private void addReceiptButton_Click(object sender, EventArgs e)
        {
          
        }

    }
}
