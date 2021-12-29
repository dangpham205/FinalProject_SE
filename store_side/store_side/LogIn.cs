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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HAIDANG\SQLEXPRESS;Initial Catalog=cnpm;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select COUNT(*) from accountant WHERE acc_username='" + loginUsername.Text + "' and acc_pass='"+ loginPassword.Text+"' ",connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1") {
                this.Hide();
                Main nextForm = new Main();
                nextForm.Show();
            }
            else
            {
                    MessageBox.Show("Invalid account!!!");
            }
        }

        private void loginUsername_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
