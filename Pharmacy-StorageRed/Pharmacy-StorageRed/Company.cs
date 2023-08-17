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
    public partial class Company : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Pharmacy-StorageRed.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanyGridView.ReadOnly = true;
            CompanyGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Company()
        {
            InitializeComponent();
        }

        private void Emppasstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCompbtn_Click(object sender, EventArgs e)
        {
            if (CompIdtb.Text == "" || Compnametb.Text == "" || Compphonetb.Text == "" || CompAddresstb.Text == "")
            {
                MessageBox.Show("Wrong input. Fill All the fields.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tbl values('" + CompIdtb.Text + "','" + Compnametb.Text + "'," + Compphonetb.Text + ", '" + CompAddresstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Added.");
                Con.Close();
                populate();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateCompbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Company_tbl SET Compname = '" + Compnametb.Text + "',CompPhone = '" + Compphonetb.Text + "', CompAddress = '" + CompAddresstb.Text + "' WHERE CompId = '" + CompIdtb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully.");
            Con.Close();
            populate();
        }

        private void CompanyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompIdtb.Text = CompanyGridView.SelectedRows[0].Cells[0].Value.ToString();
            Compnametb.Text = CompanyGridView.SelectedRows[0].Cells[1].Value.ToString();
            Compphonetb.Text = CompanyGridView.SelectedRows[0].Cells[2].Value.ToString();
            CompAddresstb.Text = CompanyGridView.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void DelCompbtn_Click(object sender, EventArgs e)
        {
            if (CompIdtb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the Employee to be Deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from Company_tbl where CompId = '" + CompIdtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully.");
                Con.Close();
                populate();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
