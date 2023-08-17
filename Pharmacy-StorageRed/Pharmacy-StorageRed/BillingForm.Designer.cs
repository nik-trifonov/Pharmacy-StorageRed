namespace Pharmacy_StorageRed
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            Emplabel = new Label();
            MedicineCb = new ComboBox();
            Qty = new TextBox();
            Stocklbl = new Label();
            Addbtn = new Button();
            BillGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Medname = new DataGridViewTextBoxColumn();
            MedQty = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            totalamount = new Label();
            Printbtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)BillGridView).BeginInit();
            SuspendLayout();
            // 
            // Emplabel
            // 
            Emplabel.AutoSize = true;
            Emplabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Emplabel.ForeColor = Color.Brown;
            Emplabel.Location = new Point(81, 58);
            Emplabel.Name = "Emplabel";
            Emplabel.Size = new Size(257, 60);
            Emplabel.TabIndex = 3;
            Emplabel.Text = "Billing Form";
            // 
            // MedicineCb
            // 
            MedicineCb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MedicineCb.FormattingEnabled = true;
            MedicineCb.Location = new Point(81, 156);
            MedicineCb.Name = "MedicineCb";
            MedicineCb.Size = new Size(207, 39);
            MedicineCb.TabIndex = 4;
            MedicineCb.Text = "Select Medicine";
            MedicineCb.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // Qty
            // 
            Qty.BackColor = SystemColors.Control;
            Qty.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Qty.ForeColor = Color.Brown;
            Qty.Location = new Point(81, 294);
            Qty.Name = "Qty";
            Qty.Size = new Size(189, 43);
            Qty.TabIndex = 5;
            Qty.Text = "Quantity";
            // 
            // Stocklbl
            // 
            Stocklbl.AutoSize = true;
            Stocklbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stocklbl.Location = new Point(81, 230);
            Stocklbl.Name = "Stocklbl";
            Stocklbl.Size = new Size(168, 31);
            Stocklbl.TabIndex = 6;
            Stocklbl.Text = "Available Stock";
            Stocklbl.Visible = false;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Brown;
            Addbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(81, 396);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(189, 57);
            Addbtn.TabIndex = 9;
            Addbtn.Text = "Add To Bill";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // BillGridView
            // 
            BillGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Medname, MedQty, UnitPrice, TotalPrice });
            BillGridView.GridColor = SystemColors.ControlLightLight;
            BillGridView.Location = new Point(463, 22);
            BillGridView.Name = "BillGridView";
            BillGridView.RowHeadersWidth = 51;
            BillGridView.RowTemplate.Height = 30;
            BillGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillGridView.Size = new Size(777, 431);
            BillGridView.TabIndex = 10;
            // 
            // Id
            // 
            Id.HeaderText = "MedId";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Medname
            // 
            Medname.HeaderText = "Medname";
            Medname.MinimumWidth = 6;
            Medname.Name = "Medname";
            Medname.Width = 125;
            // 
            // MedQty
            // 
            MedQty.HeaderText = "Quantity";
            MedQty.MinimumWidth = 6;
            MedQty.Name = "MedQty";
            MedQty.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // totalamount
            // 
            totalamount.AutoSize = true;
            totalamount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            totalamount.ForeColor = Color.Brown;
            totalamount.Location = new Point(578, 459);
            totalamount.Name = "totalamount";
            totalamount.Size = new Size(287, 60);
            totalamount.TabIndex = 11;
            totalamount.Text = "Total Amount";
            // 
            // Printbtn
            // 
            Printbtn.BackColor = Color.Brown;
            Printbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Printbtn.ForeColor = Color.White;
            Printbtn.Location = new Point(1051, 459);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(189, 57);
            Printbtn.TabIndex = 12;
            Printbtn.Text = "Print";
            Printbtn.UseVisualStyleBackColor = false;
            Printbtn.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(463, 459);
            button1.Name = "button1";
            button1.Size = new Size(109, 57);
            button1.TabIndex = 13;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 592);
            Controls.Add(button1);
            Controls.Add(Printbtn);
            Controls.Add(totalamount);
            Controls.Add(BillGridView);
            Controls.Add(Addbtn);
            Controls.Add(Stocklbl);
            Controls.Add(Qty);
            Controls.Add(MedicineCb);
            Controls.Add(Emplabel);
            Name = "BillingForm";
            Text = "BillingForm";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)BillGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Emplabel;
        private ComboBox MedicineCb;
        private TextBox Qty;
        private Label Stocklbl;
        private Button Addbtn;
        private DataGridView BillGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Medname;
        private DataGridViewTextBoxColumn MedQty;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private Label totalamount;
        private Button Printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button1;
    }
}