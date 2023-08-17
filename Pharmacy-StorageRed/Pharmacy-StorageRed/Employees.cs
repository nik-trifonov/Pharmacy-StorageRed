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
    public partial class Employees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Pharmacy-StorageRed.mdf;Integrated Security=True;Connect Timeout=30");

        public Employees()
        {
            InitializeComponent();
        }
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Employee1_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtb.Text == "" || Empnametb.Text == "" || empsaltb.Text == "" || empagetb.Text == "" || empphonetb.Text == "" || Emppasstb.Text == "")
            {
                MessageBox.Show("Wrong input. Fill All the fields.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee1_tbl values('" + Empidtb.Text + "','" + Empnametb.Text + "'," + empsaltb.Text + ", " + empagetb.Text + ", '" + empphonetb.Text + "', '" + Emppasstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added.");
                Con.Close();
                populate();
            }

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empidtb.Text = EmployeeGridView.SelectedRows[0].Cells[0].Value.ToString();
            Empnametb.Text = EmployeeGridView.SelectedRows[0].Cells[1].Value.ToString();
            empsaltb.Text = EmployeeGridView.SelectedRows[0].Cells[2].Value.ToString();
            empagetb.Text = EmployeeGridView.SelectedRows[0].Cells[3].Value.ToString();
            empphonetb.Text = EmployeeGridView.SelectedRows[0].Cells[4].Value.ToString();
            Emppasstb.Text = EmployeeGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void UpdateEmpbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Employee1_tbl SET Empname = '" + Empnametb.Text + "',Empsalary = " + empsaltb.Text + ", EmpAge = " + empagetb.Text + ", EmpPhone = '" + empphonetb.Text + "', EmpPassword = '" + Emppasstb.Text + "' WHERE EmpId = '" + Empidtb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated Successfully.");
            Con.Close();
            populate();
        }

        private void DelEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the Employee to be Deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from Employee1_tbl where EmpId = '" + Empidtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully.");
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
