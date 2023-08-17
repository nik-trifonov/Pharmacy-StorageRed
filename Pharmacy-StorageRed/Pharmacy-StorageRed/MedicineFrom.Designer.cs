namespace Pharmacy_StorageRed
{
    partial class MedicineFrom
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
            MedicineGridView = new DataGridView();
            Mednametb = new TextBox();
            Bptb = new TextBox();
            sptb = new TextBox();
            qtytb = new TextBox();
            ExpireDate = new DateTimePicker();
            companycb = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MedicineGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 0;
            label1.Text = "Medicine Stock";
            // 
            // MedicineGridView
            // 
            MedicineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicineGridView.GridColor = SystemColors.ControlLightLight;
            MedicineGridView.Location = new Point(483, 12);
            MedicineGridView.Name = "MedicineGridView";
            MedicineGridView.RowHeadersWidth = 51;
            MedicineGridView.RowTemplate.Height = 30;
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MedicineGridView.Size = new Size(777, 558);
            MedicineGridView.TabIndex = 1;
            MedicineGridView.CellContentClick += MedicineGridView_CellContentClick;
            // 
            // Mednametb
            // 
            Mednametb.BackColor = SystemColors.Control;
            Mednametb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Mednametb.ForeColor = Color.Brown;
            Mednametb.Location = new Point(22, 84);
            Mednametb.Name = "Mednametb";
            Mednametb.Size = new Size(189, 43);
            Mednametb.TabIndex = 2;
            Mednametb.Text = "MedicneName";
            // 
            // Bptb
            // 
            Bptb.BackColor = SystemColors.Control;
            Bptb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Bptb.ForeColor = Color.Brown;
            Bptb.Location = new Point(288, 84);
            Bptb.Name = "Bptb";
            Bptb.Size = new Size(189, 43);
            Bptb.TabIndex = 3;
            Bptb.Text = "BuyingPrice";
            // 
            // sptb
            // 
            sptb.BackColor = SystemColors.Control;
            sptb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sptb.ForeColor = Color.Brown;
            sptb.Location = new Point(288, 167);
            sptb.Name = "sptb";
            sptb.Size = new Size(189, 43);
            sptb.TabIndex = 4;
            sptb.Text = "SellingPrice";
            // 
            // qtytb
            // 
            qtytb.BackColor = SystemColors.Control;
            qtytb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            qtytb.ForeColor = Color.Brown;
            qtytb.Location = new Point(288, 261);
            qtytb.Name = "qtytb";
            qtytb.Size = new Size(189, 43);
            qtytb.TabIndex = 5;
            qtytb.Text = "Quantity";
            // 
            // ExpireDate
            // 
            ExpireDate.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ExpireDate.CalendarMonthBackground = Color.YellowGreen;
            ExpireDate.Location = new Point(22, 179);
            ExpireDate.Name = "ExpireDate";
            ExpireDate.Size = new Size(195, 27);
            ExpireDate.TabIndex = 6;
            // 
            // companycb
            // 
            companycb.FormattingEnabled = true;
            companycb.Location = new Point(22, 275);
            companycb.Name = "companycb";
            companycb.Size = new Size(151, 28);
            companycb.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 447);
            button1.Name = "button1";
            button1.Size = new Size(129, 57);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(168, 447);
            button2.Name = "button2";
            button2.Size = new Size(123, 57);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(315, 447);
            button3.Name = "button3";
            button3.Size = new Size(123, 57);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(168, 522);
            button4.Name = "button4";
            button4.Size = new Size(123, 57);
            button4.TabIndex = 11;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MedicineFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 592);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(companycb);
            Controls.Add(ExpireDate);
            Controls.Add(qtytb);
            Controls.Add(sptb);
            Controls.Add(Bptb);
            Controls.Add(Mednametb);
            Controls.Add(MedicineGridView);
            Controls.Add(label1);
            Name = "MedicineFrom";
            Text = "MedicineFrom";
            Load += MedicineFrom_Load;
            ((System.ComponentModel.ISupportInitialize)MedicineGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView MedicineGridView;
        private TextBox Mednametb;
        private TextBox Bptb;
        private TextBox sptb;
        private TextBox qtytb;
        private DateTimePicker ExpireDate;
        private ComboBox companycb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}