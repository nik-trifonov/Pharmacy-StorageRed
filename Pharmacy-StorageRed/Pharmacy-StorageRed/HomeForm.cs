using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_StorageRed
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MedicineFrom MedForm = new MedicineFrom();
        Employees Empform = new Employees();
        Company Cmpform = new Company();
        BillingForm billForm = new BillingForm();
        private void button1_Click(object sender, EventArgs e)
        {
            MedForm.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Empform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmpform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            billForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
