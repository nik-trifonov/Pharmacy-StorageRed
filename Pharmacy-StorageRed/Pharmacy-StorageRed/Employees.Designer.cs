namespace Pharmacy_StorageRed
{
    partial class Employees
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
            Emplabel = new Label();
            empgendercb = new ComboBox();
            empsaltb = new TextBox();
            empagetb = new TextBox();
            Empnametb = new TextBox();
            Empidtb = new TextBox();
            empphonetb = new TextBox();
            Backbtn = new Button();
            DelEmpbtn = new Button();
            UpdateEmpbtn = new Button();
            AddEmpbtn = new Button();
            EmployeeGridView = new DataGridView();
            Emppasstb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeGridView).BeginInit();
            SuspendLayout();
            // 
            // Emplabel
            // 
            Emplabel.AutoSize = true;
            Emplabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Emplabel.ForeColor = Color.Brown;
            Emplabel.Location = new Point(136, 72);
            Emplabel.Name = "Emplabel";
            Emplabel.Size = new Size(180, 46);
            Emplabel.TabIndex = 1;
            Emplabel.Text = "Employees";
            // 
            // empgendercb
            // 
            empgendercb.FormattingEnabled = true;
            empgendercb.Items.AddRange(new object[] { "Male", "Female" });
            empgendercb.Location = new Point(274, 304);
            empgendercb.Name = "empgendercb";
            empgendercb.Size = new Size(151, 28);
            empgendercb.TabIndex = 12;
            // 
            // empsaltb
            // 
            empsaltb.BackColor = SystemColors.Control;
            empsaltb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            empsaltb.ForeColor = Color.Brown;
            empsaltb.Location = new Point(285, 181);
            empsaltb.Name = "empsaltb";
            empsaltb.Size = new Size(189, 43);
            empsaltb.TabIndex = 11;
            empsaltb.Text = "Salary";
            // 
            // empagetb
            // 
            empagetb.BackColor = SystemColors.Control;
            empagetb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            empagetb.ForeColor = Color.Brown;
            empagetb.Location = new Point(39, 325);
            empagetb.Name = "empagetb";
            empagetb.Size = new Size(189, 43);
            empagetb.TabIndex = 10;
            empagetb.Text = "Employee Age";
            // 
            // Empnametb
            // 
            Empnametb.BackColor = SystemColors.Control;
            Empnametb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Empnametb.ForeColor = Color.Brown;
            Empnametb.Location = new Point(37, 247);
            Empnametb.Name = "Empnametb";
            Empnametb.Size = new Size(205, 43);
            Empnametb.TabIndex = 9;
            Empnametb.Text = "Employee Name";
            // 
            // Empidtb
            // 
            Empidtb.BackColor = SystemColors.Control;
            Empidtb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Empidtb.ForeColor = Color.Brown;
            Empidtb.Location = new Point(39, 181);
            Empidtb.Name = "Empidtb";
            Empidtb.Size = new Size(189, 43);
            Empidtb.TabIndex = 8;
            Empidtb.Text = "Employee Id";
            // 
            // empphonetb
            // 
            empphonetb.BackColor = SystemColors.Control;
            empphonetb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            empphonetb.ForeColor = Color.Brown;
            empphonetb.Location = new Point(274, 395);
            empphonetb.Name = "empphonetb";
            empphonetb.Size = new Size(189, 43);
            empphonetb.TabIndex = 13;
            empphonetb.Text = "Phone Number";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.Brown;
            Backbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.White;
            Backbtn.Location = new Point(183, 528);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(123, 57);
            Backbtn.TabIndex = 17;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // DelEmpbtn
            // 
            DelEmpbtn.BackColor = Color.Brown;
            DelEmpbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DelEmpbtn.ForeColor = Color.White;
            DelEmpbtn.Location = new Point(330, 453);
            DelEmpbtn.Name = "DelEmpbtn";
            DelEmpbtn.Size = new Size(123, 57);
            DelEmpbtn.TabIndex = 16;
            DelEmpbtn.Text = "Delete";
            DelEmpbtn.UseVisualStyleBackColor = false;
            DelEmpbtn.Click += DelEmpbtn_Click;
            // 
            // UpdateEmpbtn
            // 
            UpdateEmpbtn.BackColor = Color.Brown;
            UpdateEmpbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateEmpbtn.ForeColor = Color.White;
            UpdateEmpbtn.Location = new Point(183, 453);
            UpdateEmpbtn.Name = "UpdateEmpbtn";
            UpdateEmpbtn.Size = new Size(123, 57);
            UpdateEmpbtn.TabIndex = 15;
            UpdateEmpbtn.Text = "Update";
            UpdateEmpbtn.UseVisualStyleBackColor = false;
            UpdateEmpbtn.Click += UpdateEmpbtn_Click;
            // 
            // AddEmpbtn
            // 
            AddEmpbtn.BackColor = Color.Brown;
            AddEmpbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddEmpbtn.ForeColor = Color.White;
            AddEmpbtn.Location = new Point(37, 453);
            AddEmpbtn.Name = "AddEmpbtn";
            AddEmpbtn.Size = new Size(129, 57);
            AddEmpbtn.TabIndex = 14;
            AddEmpbtn.Text = "ADD";
            AddEmpbtn.UseVisualStyleBackColor = false;
            AddEmpbtn.Click += AddEmpbtn_Click;
            // 
            // EmployeeGridView
            // 
            EmployeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeGridView.GridColor = SystemColors.ControlLightLight;
            EmployeeGridView.Location = new Point(483, 12);
            EmployeeGridView.Name = "EmployeeGridView";
            EmployeeGridView.RowHeadersWidth = 51;
            EmployeeGridView.RowTemplate.Height = 30;
            EmployeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeGridView.Size = new Size(777, 558);
            EmployeeGridView.TabIndex = 18;
            EmployeeGridView.CellContentClick += EmployeeGridView_CellContentClick;
            // 
            // Emppasstb
            // 
            Emppasstb.BackColor = SystemColors.Control;
            Emppasstb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Emppasstb.ForeColor = Color.Brown;
            Emppasstb.Location = new Point(39, 395);
            Emppasstb.Name = "Emppasstb";
            Emppasstb.Size = new Size(189, 43);
            Emppasstb.TabIndex = 19;
            Emppasstb.Text = "EmpPassword";
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 592);
            Controls.Add(Emppasstb);
            Controls.Add(EmployeeGridView);
            Controls.Add(Backbtn);
            Controls.Add(DelEmpbtn);
            Controls.Add(UpdateEmpbtn);
            Controls.Add(AddEmpbtn);
            Controls.Add(empphonetb);
            Controls.Add(empgendercb);
            Controls.Add(empsaltb);
            Controls.Add(empagetb);
            Controls.Add(Empnametb);
            Controls.Add(Empidtb);
            Controls.Add(Emplabel);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Emplabel;
        private ComboBox empgendercb;
        private TextBox empsaltb;
        private TextBox empagetb;
        private TextBox Empnametb;
        private TextBox Empidtb;
        private TextBox empphonetb;
        private Button Backbtn;
        private Button DelEmpbtn;
        private Button UpdateEmpbtn;
        private Button AddEmpbtn;
        private DataGridView EmployeeGridView;
        private TextBox Emppasstb;
    }
}