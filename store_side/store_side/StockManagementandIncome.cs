using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_side
{
    public partial class StockManagementandIncome : Form
    {
        public StockManagementandIncome()
        {
            InitializeComponent();
            month.Items.Add("1");
            month.Items.Add("2");
            month.Items.Add("3");
            month.Items.Add("4");
            month.Items.Add("5");
            month.Items.Add("6");
            month.Items.Add("7");
            month.Items.Add("8");
            month.Items.Add("9");
            month.Items.Add("10");
            month.Items.Add("11");
            month.Items.Add("12");
            month.DropDownStyle = ComboBoxStyle.DropDownList;
            year.Items.Add("2022");
            year.Items.Add("2023");
            year.Items.Add("2024");
            year.Items.Add("2025");
            year.Items.Add("2026");
            year.Items.Add("2027");
            year.Items.Add("2028");
            year.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nextForm = new Main();
            nextForm.Show();
        }

        private void StockManagementandIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cnpmDataSet1.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.cnpmDataSet1.bill);
            // TODO: This line of code loads data into the 'cnpmDataSet1.product2' table. You can move, or remove it, as needed.
            this.product2TableAdapter.Fill(this.cnpmDataSet1.product2);
            // TODO: This line of code loads data into the 'cnpmDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cnpmDataSet.product);

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            rp.Text = "";
            long income = 0;
            DateTime dateTime;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    dateTime = DateTime.ParseExact(row.Cells[3].Value.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    if (dateTime.Month.ToString().Equals(month.Text) && dateTime.Year.ToString().Equals(year.Text))
                    {
                        income += long.Parse(row.Cells[6].Value.ToString());
                    }
                }
                catch (FormatException)
                {
                    dateTime = DateTime.ParseExact(row.Cells[3].Value.ToString(), "M/d/yyyy", CultureInfo.InvariantCulture);
                    if (dateTime.Month.ToString().Equals(month.Text) && dateTime.Year.ToString().Equals(year.Text))
                    {
                        income += long.Parse(row.Cells[6].Value.ToString());
                    }
                }
            }
            rp.Text = "Total revenue: " + income.ToString() + " VNĐ";
            rp.Visible = true;
            return;
        }

        private void instockTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            instockTable.ClearSelection();
        }

        private void soldTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            soldTable.ClearSelection();
        }
    }
}
