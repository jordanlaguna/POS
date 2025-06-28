namespace postsys.Forms
{
    partial class Bills
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnPay = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            cmbMethodPay = new ComboBox();
            textPay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 187);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(557, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 31);
            btnClose.TabIndex = 26;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 115);
            label3.Name = "label3";
            label3.Size = new Size(29, 33);
            label3.TabIndex = 25;
            label3.Text = "0";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 115);
            label2.Name = "label2";
            label2.Size = new Size(201, 33);
            label2.TabIndex = 24;
            label2.Text = "Monto a Cobrar:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 53);
            label1.TabIndex = 23;
            label1.Text = "Facturación";
            label1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 187);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.5022049F));
            tableLayoutPanel1.Size = new Size(599, 425);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbMethodPay);
            panel2.Controls.Add(textPay);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 419);
            panel2.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPay.BackColor = Color.Green;
            btnPay.FlatAppearance.BorderColor = Color.Yellow;
            btnPay.FlatAppearance.BorderSize = 2;
            btnPay.Font = new Font("Times New Roman", 12F);
            btnPay.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnPay.IconColor = Color.FromArgb(11, 47, 75);
            btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPay.Location = new Point(193, 216);
            btnPay.Name = "btnPay";
            btnPay.RightToLeft = RightToLeft.No;
            btnPay.Size = new Size(204, 68);
            btnPay.TabIndex = 31;
            btnPay.Text = "Confirmar";
            btnPay.TextAlign = ContentAlignment.MiddleRight;
            btnPay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.UseWaitCursor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(227, 146);
            label7.Name = "label7";
            label7.Size = new Size(29, 33);
            label7.TabIndex = 26;
            label7.Text = "0";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 146);
            label6.Name = "label6";
            label6.Size = new Size(97, 33);
            label6.TabIndex = 30;
            label6.Text = "Vuelto:";
            label6.UseWaitCursor = true;
            // 
            // cmbMethodPay
            // 
            cmbMethodPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbMethodPay.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMethodPay.FormattingEnabled = true;
            cmbMethodPay.Location = new Point(313, 25);
            cmbMethodPay.Name = "cmbMethodPay";
            cmbMethodPay.Size = new Size(192, 34);
            cmbMethodPay.TabIndex = 29;
            // 
            // textPay
            // 
            textPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textPay.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPay.Location = new Point(227, 88);
            textPay.Name = "textPay";
            textPay.PlaceholderText = "Ingrese el monto";
            textPay.Size = new Size(263, 34);
            textPay.TabIndex = 28;
            textPay.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 26);
            label5.Name = "label5";
            label5.Size = new Size(203, 33);
            label5.TabIndex = 27;
            label5.Text = "Método de pago:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(106, 87);
            label4.Name = "label4";
            label4.Size = new Size(115, 33);
            label4.TabIndex = 26;
            label4.Text = "Efectivo:";
            label4.UseWaitCursor = true;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 612);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bills";
            Text = "Bills";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private TextBox textPay;
        private Label label7;
        private Label label6;
        private ComboBox cmbMethodPay;
        private FontAwesome.Sharp.IconButton btnPay;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}