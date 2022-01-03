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
        int qtt = 0;
        public GoodsDelivery()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void GoodsDelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet1.product2' table. You can move, or remove it, as needed.
            this.product2TableAdapter.Fill(this.cnpmDataSet1.product2);
            // TODO: This line of code loads data into the 'cnpmDataSet1.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.cnpmDataSet1.bill);
            // TODO: This line of code loads data into the 'cnpmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        public void productTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productTable.ClearSelection();
        }

        public void billTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            billTable.ClearSelection();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (productTable.SelectedCells.Count > 0)
            {
                quantity.Value = 0;
                quantity.Visible = true;
                quantityButton.Visible = true;
                quantityDialog.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a product to add.");
            }
        }

        private void quantityButton_Click(object sender, EventArgs e)
        {
            int rowIndex = this.productTable.CurrentCell.RowIndex;
            if (quantity.Value > Int32.Parse(productTable.Rows[rowIndex].Cells[2].Value.ToString()))
            {
                quantity.Visible = false;
                quantityButton.Visible = false;
                quantityDialog.Visible = false;
                MessageBox.Show("Don't have enough product in stock");
                return;
            }
            else if (quantity.Value == 0)
            {
                qtt = 0;
                quantity.Visible = false;
                quantityButton.Visible = false;
                quantityDialog.Visible = false;
                return;
            }
            else
            {
                qtt = Convert.ToInt32(quantity.Value);
                quantity.Visible = false;
                quantityButton.Visible = false;
                quantityDialog.Visible = false;
                DataGridViewRow rowProduct = productTable.Rows[rowIndex];
                if (productTable.RowCount > 0)
                {
                    foreach (DataGridViewRow r in billTable.Rows)
                    {
                        try
                        {
                            if (r.Cells[0].Value.ToString().Equals(productTable.Rows[rowIndex].Cells[0].Value.ToString()))
                            {
                                int oldQtt = Int32.Parse(r.Cells[2].Value.ToString());
                                int newQtt = oldQtt + qtt;
                                if (newQtt <= Int32.Parse(productTable.Rows[rowIndex].Cells[2].Value.ToString()))
                                {
                                    r.Cells[2].Value = oldQtt + qtt;
                                    int oldPrice = Int32.Parse(r.Cells[3].Value.ToString());
                                    int newPrice = oldPrice + (Int32.Parse(rowProduct.Cells[3].Value.ToString()) * qtt);
                                    r.Cells[3].Value = newPrice;
                                    int oldTotal = Int32.Parse(billPrice.Text);
                                    int newTotal = oldTotal + (Int32.Parse(rowProduct.Cells[3].Value.ToString()) * qtt);
                                    billPrice.Text = newTotal.ToString();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Don't have enough product in stock");
                                    return;
                                }
                            }
                        }
                        catch (NullReferenceException)
                        {

                        }
                    }
                }
                if (qtt > 0)
                {
                    int rowId = billTable.Rows.Add();
                    // Grab the new row
                    DataGridViewRow rowBill = billTable.Rows[rowId];
                    rowBill.Cells[0].Value = rowProduct.Cells[0].Value;
                    rowBill.Cells[1].Value = rowProduct.Cells[1].Value;
                    rowBill.Cells[2].Value = qtt;
                    rowBill.Cells[3].Value = Int32.Parse(rowProduct.Cells[3].Value.ToString()) * qtt;
                    int oldTotal = Int32.Parse(billPrice.Text);
                    billPrice.Text = ((Int32.Parse(rowProduct.Cells[3].Value.ToString()) * qtt)+ oldTotal).ToString();

                    billTable.ClearSelection();
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (billTable.RowCount > 0)
            {
                if (billTable.SelectedCells.Count > 0)
                {
                    int rowId = billTable.CurrentCell.RowIndex;
                    billTable.Rows.RemoveAt(rowId);
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
            else
            {
                MessageBox.Show("You don't have any products yet");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            billTable.Rows.Clear();
            billTable.Refresh();

            billID.Text = "";
            billName.Text = "";
            billAdress.Text = "";
            billPrice.Text = "0";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (billID.Text == "" || billName.Text == "" || billAdress.Text == "" || billDelivery.Text == "" || billPayment.Text =="" )
            {
                MessageBox.Show("Please fill the receipt's information.");
                return;
            }
            else if (billPrice.Text == "0")
            {
                MessageBox.Show("You will need to add your products first.");
                return;
            }
            else
            {
                try
                {
                    try
                    {
                        cnpmDataSet1.billRow bill = this.cnpmDataSet1.bill.AddbillRow(
                        billID.Text, billName.Text, billAdress.Text.ToString(), DateTime.Now.ToString("M/d/yyyy"),
                        billDelivery.Text, billPayment.Text, Int32.Parse(billPrice.Text));
                        this.billTableAdapter.Update(bill);
                    }
                    catch (ArgumentException)
                    {

                    }
                    foreach (DataGridViewRow row in billTable.Rows)
                    {
                        try
                        {
                            cnpmDataSet1.product2Row products = this.cnpmDataSet1.product2.Addproduct2Row(
                                row.Cells[0].Value.ToString()+"_"+ billID.Text, row.Cells[1].Value.ToString(),
                                Int32.Parse(row.Cells[2].Value.ToString()), Int32.Parse(row.Cells[3].Value.ToString()),
                                billID.Text);
                            this.product2TableAdapter.Update(products);
                            foreach (DataGridViewRow stock in productTable.Rows)
                            {
                                if (row.Cells[0].Value.ToString().Equals(stock.Cells[0].Value.ToString()))
                                {
                                    cnpmDataSet.productRow product = (cnpmDataSet.productRow)this.cnpmDataSet.product.Rows[productTable.Rows.IndexOf(stock)];
                                    int oldQtt = Int32.Parse(product.prod_unit);
                                    int newQtt = oldQtt - Int32.Parse(row.Cells[2].Value.ToString());
                                    product.prod_unit = newQtt.ToString();
                                    this.productTableAdapter.Update(product);
                                }
                                else
                                {
                                    continue;
                                }
                            }

                        }
                        catch (System.Data.ConstraintException)
                        {
                            MessageBox.Show("Something went wrong :( ");
                            return;
                        }
                    }
                    MessageBox.Show("Add Succeed!");

                    billTable.Rows.Clear();
                    billTable.Refresh();

                    billID.Text = "";
                    billName.Text = "";
                    billAdress.Text = "";
                    billPrice.Text = "0";
                    return;

                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("There is already a Note with the ID: " + billID.Text);
                    return;
                }
            }
        }

        
    }
}
