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
    public partial class BillingForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Pharmacy-StorageRed.mdf;Integrated Security=True;Connect Timeout=30");
        public void populatecombobox()
        {
            string sql = "select * from Medicine_tbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Medname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                MedicineCb.ValueMember = "Medname";
                MedicineCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        int x, unitp;
        public void fetchQty()
        {
            Con.Open();
            string mysql = "Select * from Medicine_tbl where MedName = '" + MedicineCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["medQty"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                Stocklbl.Text = "Available Stock is " + dr["medQty"].ToString();
                Stocklbl.Visible = true;
            }
            Con.Close();
        }
        public void updateMedicine()
        {
            Con.Open();
            int newQty = x - Convert.ToInt32(Qty.Text);
            string Myquery = "UPDATE Medicine_tbl SET MedQty = " + newQty + "  WHERE Medname = '" + MedicineCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Medicine Updated Successfully.");
            Con.Close();


        }
        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select  MedName from Medicine_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MedName", typeof(string));
            dt.Load(rdr);
            MedicineCb.ValueMember = "MedName";
            MedicineCb.DataSource = dt;
            Con.Close();
            // populatecombobox();
        }
        int GrdTotal = 0;
        private void Addbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            //total = Convert.ToInt32(Qty.Text) * unitp;
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > x)
            {
                MessageBox.Show("Not Enough Stock, Please Check Available Stock.");
            }
            else
            {
                int total = Convert.ToInt32(Qty.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = MedicineCb.SelectedValue.ToString();
                newRow.Cells[2].Value = Qty.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(Qty.Text);
                BillGridView.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                totalamount.Text = "Total price is: " + GrdTotal;
                updateMedicine();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 0, 0);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
