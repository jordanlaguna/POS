namespace postsys.Forms
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            label1 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            dateTimeSince = new DateTimePicker();
            label2 = new Label();
            panel8 = new Panel();
            dateTimePickerUntil = new DateTimePicker();
            label3 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            pictureBox10 = new PictureBox();
            txtSearch = new TextBox();
            panel5 = new Panel();
            tableInvoice = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            sale_number = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            payment_method = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 89);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(936, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(930, 83);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 47);
            label1.Name = "label1";
            label1.Size = new Size(195, 33);
            label1.TabIndex = 4;
            label1.Text = "Consulta Ventas";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(337, 6);
            label7.Name = "label7";
            label7.Size = new Size(252, 33);
            label7.TabIndex = 3;
            label7.Text = "Historial De Facturas";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 125);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Controls.Add(panel8, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3, 0, 3, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(936, 125);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(dateTimeSince);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(6, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(3);
            panel7.Size = new Size(459, 119);
            panel7.TabIndex = 0;
            // 
            // dateTimeSince
            // 
            dateTimeSince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeSince.Font = new Font("Verdana", 12F);
            dateTimeSince.Format = DateTimePickerFormat.Short;
            dateTimeSince.Location = new Point(98, 53);
            dateTimeSince.Margin = new Padding(2);
            dateTimeSince.Name = "dateTimeSince";
            dateTimeSince.RightToLeft = RightToLeft.No;
            dateTimeSince.Size = new Size(243, 32);
            dateTimeSince.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 18);
            label2.Name = "label2";
            label2.Size = new Size(84, 33);
            label2.TabIndex = 5;
            label2.Text = "Desde";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonHighlight;
            panel8.Controls.Add(dateTimePickerUntil);
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(471, 3);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(3);
            panel8.Size = new Size(459, 119);
            panel8.TabIndex = 1;
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerUntil.Font = new Font("Verdana", 12F);
            dateTimePickerUntil.Format = DateTimePickerFormat.Short;
            dateTimePickerUntil.Location = new Point(112, 53);
            dateTimePickerUntil.Margin = new Padding(2);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.RightToLeft = RightToLeft.No;
            dateTimePickerUntil.Size = new Size(243, 32);
            dateTimePickerUntil.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 18);
            label3.Name = "label3";
            label3.Size = new Size(77, 33);
            label3.TabIndex = 7;
            label3.Text = "Hasta";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(936, 416);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 349F));
            tableLayoutPanel1.Size = new Size(936, 416);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(930, 61);
            panel4.TabIndex = 0;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(374, 14);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 40);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtSearch.Font = new Font("Times New Roman", 14F);
            txtSearch.Location = new Point(5, 14);
            txtSearch.Margin = new Padding(2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(365, 39);
            txtSearch.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableInvoice);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(930, 343);
            panel5.TabIndex = 1;
            // 
            // tableInvoice
            // 
            tableInvoice.AllowUserToAddRows = false;
            tableInvoice.AllowUserToDeleteRows = false;
            tableInvoice.AllowUserToResizeColumns = false;
            tableInvoice.AllowUserToResizeRows = false;
            tableInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableInvoice.BackgroundColor = Color.FromArgb(11, 47, 75);
            tableInvoice.BorderStyle = BorderStyle.None;
            tableInvoice.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tableInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableInvoice.Columns.AddRange(new DataGridViewColumn[] { id, sale_number, created_at, payment_method, total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            tableInvoice.Dock = DockStyle.Fill;
            tableInvoice.Location = new Point(0, 0);
            tableInvoice.Name = "tableInvoice";
            tableInvoice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableInvoice.RowHeadersVisible = false;
            tableInvoice.RowHeadersWidth = 51;
            tableInvoice.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableInvoice.Size = new Size(930, 343);
            tableInvoice.TabIndex = 4;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // sale_number
            // 
            sale_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sale_number.DataPropertyName = "sale_number";
            sale_number.HeaderText = "N. de Venta";
            sale_number.MinimumWidth = 6;
            sale_number.Name = "sale_number";
            sale_number.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Fecha";
            created_at.MinimumWidth = 6;
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // payment_method
            // 
            payment_method.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            payment_method.DataPropertyName = "payment_method";
            payment_method.HeaderText = "M. de Pago";
            payment_method.MinimumWidth = 6;
            payment_method.Name = "payment_method";
            payment_method.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.DataPropertyName = "total";
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Invoice";
            Text = "Invoice";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
        private DataGridView tableInvoice;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel7;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox10;
        private TextBox txtSearch;
        private DateTimePicker dateTimeSince;
        private DateTimePicker dateTimePickerUntil;
        private Label label3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn sale_number;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn payment_method;
        private DataGridViewTextBoxColumn total;
    }
}