namespace postsys.Forms
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel15 = new Panel();
            dateTimeAt = new DateTimePicker();
            label6 = new Label();
            panel16 = new Panel();
            btnAddCategories = new FontAwesome.Sharp.IconButton();
            textCategories = new TextBox();
            label10 = new Label();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel13 = new Panel();
            label5 = new Label();
            textBarCode = new TextBox();
            panel14 = new Panel();
            cmbCategory = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            textName = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            textDescription = new TextBox();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel10 = new Panel();
            label3 = new Label();
            textPrice = new TextBox();
            panel11 = new Panel();
            textStock = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            label8 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            panel12 = new Panel();
            tableInventory = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnBarCode = new DataGridViewTextBoxColumn();
            ColumnCreatedAt = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 336);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel7, 0, 5);
            tableLayoutPanel1.Controls.Add(panel6, 0, 4);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.669445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6661148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666111F));
            tableLayoutPanel1.Size = new Size(936, 336);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(tableLayoutPanel5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 279);
            panel7.Name = "panel7";
            panel7.Size = new Size(930, 54);
            panel7.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel15, 0, 0);
            tableLayoutPanel5.Controls.Add(panel16, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(930, 54);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.Controls.Add(dateTimeAt);
            panel15.Controls.Add(label6);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(459, 48);
            panel15.TabIndex = 0;
            // 
            // dateTimeAt
            // 
            dateTimeAt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeAt.Font = new Font("Verdana", 12F);
            dateTimeAt.Format = DateTimePickerFormat.Short;
            dateTimeAt.Location = new Point(194, 8);
            dateTimeAt.Margin = new Padding(2);
            dateTimeAt.Name = "dateTimeAt";
            dateTimeAt.RightToLeft = RightToLeft.No;
            dateTimeAt.Size = new Size(255, 32);
            dateTimeAt.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 11);
            label6.Name = "label6";
            label6.Size = new Size(177, 26);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Ingreso:";
            // 
            // panel16
            // 
            panel16.Controls.Add(btnAddCategories);
            panel16.Controls.Add(textCategories);
            panel16.Controls.Add(label10);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(468, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(459, 48);
            panel16.TabIndex = 1;
            // 
            // btnAddCategories
            // 
            btnAddCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCategories.BackColor = Color.FromArgb(11, 47, 75);
            btnAddCategories.Cursor = Cursors.Hand;
            btnAddCategories.FlatAppearance.BorderColor = Color.White;
            btnAddCategories.FlatAppearance.BorderSize = 2;
            btnAddCategories.FlatStyle = FlatStyle.Flat;
            btnAddCategories.Font = new Font("Times New Roman", 12F);
            btnAddCategories.ForeColor = Color.White;
            btnAddCategories.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddCategories.IconColor = Color.White;
            btnAddCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddCategories.IconSize = 1;
            btnAddCategories.Location = new Point(367, 5);
            btnAddCategories.Name = "btnAddCategories";
            btnAddCategories.RightToLeft = RightToLeft.No;
            btnAddCategories.Size = new Size(92, 38);
            btnAddCategories.TabIndex = 15;
            btnAddCategories.Text = "Agregar";
            btnAddCategories.TextAlign = ContentAlignment.MiddleRight;
            btnAddCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCategories.UseVisualStyleBackColor = false;
            btnAddCategories.UseWaitCursor = true;
            btnAddCategories.Click += btnAddCategories_Click;
            // 
            // textCategories
            // 
            textCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textCategories.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCategories.Location = new Point(181, 7);
            textCategories.Name = "textCategories";
            textCategories.PlaceholderText = "Nueva categoría";
            textCategories.Size = new Size(187, 34);
            textCategories.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 11);
            label10.Name = "label10";
            label10.Size = new Size(172, 26);
            label10.TabIndex = 13;
            label10.Text = "Nueva Categoría:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(tableLayoutPanel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 224);
            panel6.Name = "panel6";
            panel6.Size = new Size(930, 49);
            panel6.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel13, 0, 0);
            tableLayoutPanel4.Controls.Add(panel14, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(930, 49);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(label5);
            panel13.Controls.Add(textBarCode);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(459, 43);
            panel13.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(185, 26);
            label5.TabIndex = 11;
            label5.Text = "Código de Barras: ";
            // 
            // textBarCode
            // 
            textBarCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBarCode.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBarCode.Location = new Point(197, 4);
            textBarCode.Name = "textBarCode";
            textBarCode.PlaceholderText = "Ingrese el código de barras";
            textBarCode.Size = new Size(255, 34);
            textBarCode.TabIndex = 10;
            // 
            // panel14
            // 
            panel14.Controls.Add(cmbCategory);
            panel14.Controls.Add(label9);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(468, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(459, 43);
            panel14.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(135, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(318, 34);
            cmbCategory.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(112, 26);
            label9.TabIndex = 12;
            label9.Text = "Categoría: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 49);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(212, 8);
            textName.Name = "textName";
            textName.PlaceholderText = "Ingrese el nombre del prodcuto";
            textName.Size = new Size(709, 34);
            textName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textDescription);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 49);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(135, 26);
            label2.TabIndex = 3;
            label2.Text = "Descripción: ";
            // 
            // textDescription
            // 
            textDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textDescription.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescription.Location = new Point(212, 9);
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Ingrese la descripción del producto";
            textDescription.Size = new Size(709, 34);
            textDescription.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(930, 49);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel10, 0, 0);
            tableLayoutPanel3.Controls.Add(panel11, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(930, 49);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(label3);
            panel10.Controls.Add(textPrice);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(459, 43);
            panel10.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 26);
            label3.TabIndex = 6;
            label3.Text = "Precio: ";
            // 
            // textPrice
            // 
            textPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPrice.Location = new Point(101, 5);
            textPrice.Name = "textPrice";
            textPrice.PlaceholderText = "Ingrese el precio";
            textPrice.Size = new Size(355, 34);
            textPrice.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Controls.Add(textStock);
            panel11.Controls.Add(label4);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(468, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(459, 43);
            panel11.TabIndex = 1;
            // 
            // textStock
            // 
            textStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textStock.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStock.Location = new Point(135, 5);
            textStock.Name = "textStock";
            textStock.PlaceholderText = "Ingrese existencias";
            textStock.Size = new Size(318, 34);
            textStock.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 26);
            label4.TabIndex = 8;
            label4.Text = "Existencias: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(930, 50);
            panel5.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 6);
            label7.Name = "label7";
            label7.Size = new Size(349, 33);
            label7.TabIndex = 2;
            label7.Text = "Insertar producto al inventario";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 336);
            panel8.Name = "panel8";
            panel8.Size = new Size(936, 294);
            panel8.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel9, 0, 0);
            tableLayoutPanel2.Controls.Add(panel12, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4081631F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 79.591835F));
            tableLayoutPanel2.Size = new Size(936, 294);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Controls.Add(btnAgregar);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(930, 54);
            panel9.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(367, 10);
            label8.Name = "label8";
            label8.Size = new Size(221, 33);
            label8.TabIndex = 14;
            label8.Text = "Lista de Inventario";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(11, 47, 75);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(3, -1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(165, 54);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.UseWaitCursor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(tableInventory);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 63);
            panel12.Name = "panel12";
            panel12.Size = new Size(930, 228);
            panel12.TabIndex = 1;
            // 
            // tableInventory
            // 
            tableInventory.AllowUserToAddRows = false;
            tableInventory.AllowUserToDeleteRows = false;
            tableInventory.AllowUserToResizeColumns = false;
            tableInventory.AllowUserToResizeRows = false;
            tableInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableInventory.BackgroundColor = Color.FromArgb(11, 47, 75);
            tableInventory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableInventory.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnDescription, ColumnPrice, ColumnStock, ColumnBarCode, ColumnCreatedAt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableInventory.DefaultCellStyle = dataGridViewCellStyle2;
            tableInventory.Dock = DockStyle.Fill;
            tableInventory.GridColor = SystemColors.ControlDark;
            tableInventory.Location = new Point(0, 0);
            tableInventory.Margin = new Padding(0);
            tableInventory.Name = "tableInventory";
            tableInventory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableInventory.RowHeadersVisible = false;
            tableInventory.RowHeadersWidth = 62;
            tableInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            tableInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            tableInventory.RowTemplate.Height = 33;
            tableInventory.Size = new Size(930, 228);
            tableInventory.TabIndex = 9;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnName.DataPropertyName = "name";
            ColumnName.FillWeight = 101.1602F;
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            ColumnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescription.DataPropertyName = "description";
            ColumnDescription.FillWeight = 96.98068F;
            ColumnDescription.HeaderText = "Descripción";
            ColumnDescription.MinimumWidth = 8;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            ColumnPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnPrice.DataPropertyName = "price";
            ColumnPrice.FillWeight = 100.324692F;
            ColumnPrice.HeaderText = "Precio";
            ColumnPrice.MinimumWidth = 8;
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.ReadOnly = true;
            // 
            // ColumnStock
            // 
            ColumnStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnStock.DataPropertyName = "stock";
            ColumnStock.HeaderText = "Existencias";
            ColumnStock.MinimumWidth = 6;
            ColumnStock.Name = "ColumnStock";
            ColumnStock.ReadOnly = true;
            // 
            // ColumnBarCode
            // 
            ColumnBarCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnBarCode.DataPropertyName = "barcode";
            ColumnBarCode.FillWeight = 101.253265F;
            ColumnBarCode.HeaderText = "C. de Barras";
            ColumnBarCode.MinimumWidth = 8;
            ColumnBarCode.Name = "ColumnBarCode";
            ColumnBarCode.ReadOnly = true;
            ColumnBarCode.Resizable = DataGridViewTriState.True;
            // 
            // ColumnCreatedAt
            // 
            ColumnCreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCreatedAt.DataPropertyName = "created_at";
            ColumnCreatedAt.HeaderText = "F. Registro";
            ColumnCreatedAt.MinimumWidth = 6;
            ColumnCreatedAt.Name = "ColumnCreatedAt";
            ColumnCreatedAt.ReadOnly = true;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(936, 630);
            Controls.Add(panel8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private TextBox textName;
        private Panel panel3;
        private Label label2;
        private TextBox textDescription;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel10;
        private Label label3;
        private TextBox textPrice;
        private Panel panel11;
        private TextBox textStock;
        private Label label4;
        private Panel panel7;
        private Panel panel5;
        private Label label7;
        private Panel panel12;
        private Label label8;
        private DataGridView tableInventory;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnBarCode;
        private DataGridViewTextBoxColumn ColumnCreatedAt;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel13;
        private Label label5;
        private TextBox textBarCode;
        private Panel panel14;
        private ComboBox cmbCategory;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel15;
        private DateTimePicker dateTimeAt;
        private Label label6;
        private Panel panel16;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnAddCategories;
        private TextBox textCategories;
    }
}