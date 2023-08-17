namespace Pharmacy_StorageRed
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(100, 138);
            label1.Name = "label1";
            label1.Size = new Size(102, 34);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Username.ForeColor = Color.Brown;
            Username.Location = new Point(64, 209);
            Username.Name = "Username";
            Username.Size = new Size(172, 38);
            Username.TabIndex = 1;
            Username.Text = "UserId";
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.Brown;
            Password.Location = new Point(64, 265);
            Password.Name = "Password";
            Password.Size = new Size(172, 38);
            Password.TabIndex = 2;
            Password.Text = "Password";
            Password.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Brown;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(64, 337);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(172, 58);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 551);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Button LoginBtn;
    }
}