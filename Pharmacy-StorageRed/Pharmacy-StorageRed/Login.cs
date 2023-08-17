using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_StorageRed
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Pharmacy-StorageRed.mdf;Integrated Security=True;Connect Timeout=30");


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            /*
            if(Username.Text == "Admin" && Password.Text == "admin")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
            */
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee1_tbl where Empname ='" + Username.Text + "' and EmpPassword = '" + Password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
            Con.Close();
        }
    }
}
