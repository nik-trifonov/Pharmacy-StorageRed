namespace Pharmacy_StorageRed
{
    public partial class Form1 : Form
    {
        int startpoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;

            progressBar1.Value = startpoint;
            Percentage.Text = startpoint + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login Mylogin = new Login();
                this.Hide();
                Mylogin.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}