namespace Pharmacy_StorageRed
{
    partial class Company
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
            CompAddresstb = new TextBox();
            Compphonetb = new TextBox();
            Compnametb = new TextBox();
            CompIdtb = new TextBox();
            Backbtn = new Button();
            DelCompbtn = new Button();
            UpdateCompbtn = new Button();
            AddCompbtn = new Button();
            CompanyGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CompanyGridView).BeginInit();
            SuspendLayout();
            // 
            // Emplabel
            // 
            Emplabel.AutoSize = true;
            Emplabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Emplabel.ForeColor = Color.Brown;
            Emplabel.Location = new Point(24, 50);
            Emplabel.Name = "Emplabel";
            Emplabel.Size = new Size(370, 46);
            Emplabel.TabIndex = 2;
            Emplabel.Text = "Medicine Manufacturer";
            // 
            // CompAddresstb
            // 
            CompAddresstb.BackColor = SystemColors.Control;
            CompAddresstb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CompAddresstb.ForeColor = Color.Brown;
            CompAddresstb.Location = new Point(255, 241);
            CompAddresstb.Name = "CompAddresstb";
            CompAddresstb.Size = new Size(189, 43);
            CompAddresstb.TabIndex = 23;
            CompAddresstb.Text = "Address";
            CompAddresstb.TextChanged += Emppasstb_TextChanged;
            // 
            // Compphonetb
            // 
            Compphonetb.BackColor = SystemColors.Control;
            Compphonetb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Compphonetb.ForeColor = Color.Brown;
            Compphonetb.Location = new Point(265, 137);
            Compphonetb.Name = "Compphonetb";
            Compphonetb.Size = new Size(189, 43);
            Compphonetb.TabIndex = 22;
            Compphonetb.Text = "Phone Number";
            // 
            // Compnametb
            // 
            Compnametb.BackColor = SystemColors.Control;
            Compnametb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Compnametb.ForeColor = Color.Brown;
            Compnametb.Location = new Point(24, 241);
            Compnametb.Name = "Compnametb";
            Compnametb.Size = new Size(205, 43);
            Compnametb.TabIndex = 21;
            Compnametb.Text = "Company Name";
            // 
            // CompIdtb
            // 
            CompIdtb.BackColor = SystemColors.Control;
            CompIdtb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CompIdtb.ForeColor = Color.Brown;
            CompIdtb.Location = new Point(24, 137);
            CompIdtb.Name = "CompIdtb";
            CompIdtb.Size = new Size(189, 43);
            CompIdtb.TabIndex = 20;
            CompIdtb.Text = "Company Id";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.Brown;
            Backbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.White;
            Backbtn.Location = new Point(179, 435);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(123, 57);
            Backbtn.TabIndex = 27;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // DelCompbtn
            // 
            DelCompbtn.BackColor = Color.Brown;
            DelCompbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DelCompbtn.ForeColor = Color.White;
            DelCompbtn.Location = new Point(326, 360);
            DelCompbtn.Name = "DelCompbtn";
            DelCompbtn.Size = new Size(123, 57);
            DelCompbtn.TabIndex = 26;
            DelCompbtn.Text = "Delete";
            DelCompbtn.UseVisualStyleBackColor = false;
            DelCompbtn.Click += DelCompbtn_Click;
            // 
            // UpdateCompbtn
            // 
            UpdateCompbtn.BackColor = Color.Brown;
            UpdateCompbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateCompbtn.ForeColor = Color.White;
            UpdateCompbtn.Location = new Point(179, 360);
            UpdateCompbtn.Name = "UpdateCompbtn";
            UpdateCompbtn.Size = new Size(123, 57);
            UpdateCompbtn.TabIndex = 25;
            UpdateCompbtn.Text = "Update";
            UpdateCompbtn.UseVisualStyleBackColor = false;
            UpdateCompbtn.Click += UpdateCompbtn_Click;
            // 
            // AddCompbtn
            // 
            AddCompbtn.BackColor = Color.Brown;
            AddCompbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddCompbtn.ForeColor = Color.White;
            AddCompbtn.Location = new Point(33, 360);
            AddCompbtn.Name = "AddCompbtn";
            AddCompbtn.Size = new Size(129, 57);
            AddCompbtn.TabIndex = 24;
            AddCompbtn.Text = "ADD";
            AddCompbtn.UseVisualStyleBackColor = false;
            AddCompbtn.Click += AddCompbtn_Click;
            // 
            // CompanyGridView
            // 
            CompanyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompanyGridView.GridColor = SystemColors.ControlLightLight;
            CompanyGridView.Location = new Point(483, 22);
            CompanyGridView.Name = "CompanyGridView";
            CompanyGridView.RowHeadersWidth = 51;
            CompanyGridView.RowTemplate.Height = 30;
            CompanyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompanyGridView.Size = new Size(777, 558);
            CompanyGridView.TabIndex = 28;
            CompanyGridView.CellContentClick += CompanyGridView_CellContentClick;
            // 
            // Company
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 592);
            Controls.Add(CompanyGridView);
            Controls.Add(Backbtn);
            Controls.Add(DelCompbtn);
            Controls.Add(UpdateCompbtn);
            Controls.Add(AddCompbtn);
            Controls.Add(CompAddresstb);
            Controls.Add(Compphonetb);
            Controls.Add(Compnametb);
            Controls.Add(CompIdtb);
            Controls.Add(Emplabel);
            Name = "Company";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company";
            Load += Company_Load;
            ((System.ComponentModel.ISupportInitialize)CompanyGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Emplabel;
        private TextBox CompAddresstb;
        private TextBox Compphonetb;
        private TextBox Compnametb;
        private TextBox CompIdtb;
        private Button Backbtn;
        private Button DelCompbtn;
        private Button UpdateCompbtn;
        private Button AddCompbtn;
        private DataGridView CompanyGridView;
    }
}