namespace Pharmacy_StorageRed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Percentage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(73, 142);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(355, 29);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(73, 44);
            label1.Name = "label1";
            label1.Size = new Size(267, 31);
            label1.TabIndex = 1;
            label1.Text = "Pharmacy Management";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(73, 75);
            label2.Name = "label2";
            label2.Size = new Size(258, 31);
            label2.TabIndex = 2;
            label2.Text = "Powered by SoftCo.Ltd";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Percentage.Location = new Point(297, 210);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(34, 31);
            Percentage.TabIndex = 3;
            Percentage.Text = "%";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(493, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 356);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(923, 455);
            Controls.Add(pictureBox1);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
        private PictureBox pictureBox1;
    }
}