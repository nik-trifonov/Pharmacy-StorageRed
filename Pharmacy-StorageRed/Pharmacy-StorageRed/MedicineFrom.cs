using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_StorageRed
{

    public partial class MedicineFrom : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Pharmacy-StorageRed.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Medicine_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public MedicineFrom()
        {
            InitializeComponent();
        }
        public void fillcombobox()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select  Compname from Company_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Compname", typeof(string));
            dt.Load(rdr);
            companycb.ValueMember = "Compname";
            companycb.DataSource = dt;
            Con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Mednametb.Text == "" || sptb.Text == "" || Bptb.Text == "" || qtytb.Text == "" || companycb.SelectedItem == null)
            {
                MessageBox.Show("Missing Data.Fill All The Information.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + Mednametb.Text + "'," + Bptb.Text + ", " + sptb.Text + ", " + qtytb.Text + ",'" + ExpireDate.Text + "','" + companycb.SelectedItem.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added.");
                Con.Close();
                populate();
            }
        }

        private void MedicineFrom_Load(object sender, EventArgs e)
        {
            populate();
            fillcombobox();
        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mednametb.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            Bptb.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            sptb.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Medicine_tbl SET Bprice = " + Bptb.Text + ",Sprice = " + sptb.Text + ", MedQty = " + qtytb.Text + ", ExpDate = '" + ExpireDate.Text + "', Company = '" + companycb.SelectedItem.ToString() + "' WHERE Medname = '" + Mednametb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully.");
            Con.Close();
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mednametb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the medicine to be Deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from Medicine_tbl where Medname = '" + Mednametb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully.");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
