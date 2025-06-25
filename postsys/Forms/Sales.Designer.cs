namespace postsys.Forms
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            textCode = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            textQuantity = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel10 = new Panel();
            button2 = new Button();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel11 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            pictureBox5 = new PictureBox();
            panel9 = new Panel();
            tableSale = new DataGridView();
            barCode = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSale).BeginInit();
            SuspendLayout();
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 84);
            panel1.TabIndex = 0;
            panel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.25532F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.74468F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(954, 84);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textCode);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 78);
            panel2.TabIndex = 0;
            panel2.UseWaitCursor = true;
            // 
            // textCode
            // 
            textCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textCode.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCode.Location = new Point(248, 22);
            textCode.Name = "textCode";
            textCode.PlaceholderText = "Ingrese el código";
            textCode.Size = new Size(413, 34);
            textCode.TabIndex = 20;
            textCode.UseWaitCursor = true;
            textCode.KeyDown += txtBarCodeSearch;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 16F);
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(239, 31);
            label3.TabIndex = 19;
            label3.Text = "Código de Producto:";
            label3.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(711, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 78);
            panel3.TabIndex = 1;
            panel3.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(23, 3);
            button1.Name = "button1";
            button1.Size = new Size(199, 70);
            button1.TabIndex = 13;
            button1.Text = "Enter - Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(954, 57);
            panel4.TabIndex = 1;
            panel4.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.85107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1489353F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(954, 57);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.UseWaitCursor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textQuantity);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(669, 51);
            panel6.TabIndex = 0;
            panel6.UseWaitCursor = true;
            // 
            // textQuantity
            // 
            textQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textQuantity.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textQuantity.Location = new Point(125, 8);
            textQuantity.Name = "textQuantity";
            textQuantity.PlaceholderText = "Ingrese la cantidad";
            textQuantity.Size = new Size(413, 34);
            textQuantity.TabIndex = 21;
            textQuantity.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 16F);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 21;
            label4.Text = "Cantidad:";
            label4.UseWaitCursor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(iconButton1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(678, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5, 0, 0, 0);
            panel7.Size = new Size(273, 51);
            panel7.TabIndex = 1;
            panel7.UseWaitCursor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.BackColor = Color.Gray;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton1.Font = new Font("Times New Roman", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.FromArgb(11, 47, 75);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(50, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(195, 44);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Buscar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.UseWaitCursor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 550);
            panel5.Name = "panel5";
            panel5.Size = new Size(954, 127);
            panel5.TabIndex = 2;
            panel5.UseWaitCursor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.65958F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3404255F));
            tableLayoutPanel3.Controls.Add(panel10, 0, 0);
            tableLayoutPanel3.Controls.Add(panel11, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(954, 127);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.UseWaitCursor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(button2);
            panel10.Controls.Add(iconButton3);
            panel10.Controls.Add(iconButton2);
            panel10.Controls.Add(label1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(687, 121);
            panel10.TabIndex = 0;
            panel10.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.PaleTurquoise;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(519, 28);
            button2.Name = "button2";
            button2.Size = new Size(142, 84);
            button2.TabIndex = 23;
            button2.Text = "F1 - Cobrar";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton3.BackColor = Color.Red;
            iconButton3.FlatAppearance.BorderColor = Color.Red;
            iconButton3.FlatAppearance.BorderSize = 2;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Times New Roman", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton3.IconColor = Color.FromArgb(11, 47, 75);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(200, 56);
            iconButton3.Name = "iconButton3";
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(171, 56);
            iconButton3.TabIndex = 22;
            iconButton3.Text = "Eliminar";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.UseWaitCursor = true;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton2.BackColor = Color.Yellow;
            iconButton2.FlatAppearance.BorderColor = Color.Yellow;
            iconButton2.FlatAppearance.BorderSize = 2;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Times New Roman", 12F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton2.IconColor = Color.FromArgb(11, 47, 75);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(6, 56);
            iconButton2.Name = "iconButton2";
            iconButton2.RightToLeft = RightToLeft.No;
            iconButton2.Size = new Size(171, 56);
            iconButton2.TabIndex = 21;
            iconButton2.Text = "Cambiar";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(328, 31);
            label1.TabIndex = 19;
            label1.Text = "Productos en la venta actual:";
            label1.UseWaitCursor = true;
            // 
            // panel11
            // 
            panel11.BackColor = Color.SeaShell;
            panel11.Controls.Add(label8);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(label2);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(696, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(255, 121);
            panel11.TabIndex = 1;
            panel11.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(139, 43);
            label8.Name = "label8";
            label8.Size = new Size(29, 33);
            label8.TabIndex = 18;
            label8.Text = "0";
            label8.UseWaitCursor = true;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 43);
            label9.Name = "label9";
            label9.Size = new Size(122, 33);
            label9.TabIndex = 17;
            label9.Text = "IVA 13%:";
            label9.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(139, 7);
            label6.Name = "label6";
            label6.Size = new Size(29, 33);
            label6.TabIndex = 16;
            label6.Text = "0";
            label6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 7);
            label7.Name = "label7";
            label7.Size = new Size(136, 33);
            label7.TabIndex = 15;
            label7.Text = "Sub. Total:";
            label7.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 81);
            label5.Name = "label5";
            label5.Size = new Size(29, 33);
            label5.TabIndex = 14;
            label5.Text = "0";
            label5.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 81);
            label2.Name = "label2";
            label2.Size = new Size(79, 33);
            label2.TabIndex = 13;
            label2.Text = "Total:";
            label2.UseWaitCursor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox5);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 536);
            panel8.Name = "panel8";
            panel8.Size = new Size(954, 14);
            panel8.TabIndex = 3;
            panel8.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(954, 14);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.UseWaitCursor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(tableSale);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 141);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(3, 0, 2, 0);
            panel9.Size = new Size(954, 395);
            panel9.TabIndex = 4;
            panel9.UseWaitCursor = true;
            // 
            // tableSale
            // 
            tableSale.AllowUserToAddRows = false;
            tableSale.AllowUserToDeleteRows = false;
            tableSale.AllowUserToResizeColumns = false;
            tableSale.AllowUserToResizeRows = false;
            tableSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSale.BackgroundColor = Color.FromArgb(11, 47, 75);
            tableSale.BorderStyle = BorderStyle.None;
            tableSale.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tableSale.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSale.Columns.AddRange(new DataGridViewColumn[] { barCode, Descripcion, price, quantity, totalPrice, Stock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableSale.DefaultCellStyle = dataGridViewCellStyle2;
            tableSale.Dock = DockStyle.Fill;
            tableSale.Location = new Point(3, 0);
            tableSale.Margin = new Padding(0);
            tableSale.Name = "tableSale";
            tableSale.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableSale.RowHeadersVisible = false;
            tableSale.RowHeadersWidth = 51;
            tableSale.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableSale.Size = new Size(949, 395);
            tableSale.TabIndex = 4;
            tableSale.UseWaitCursor = true;
            // 
            // barCode
            // 
            barCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            barCode.DataPropertyName = "barcode";
            barCode.HeaderText = "Código B.";
            barCode.MinimumWidth = 6;
            barCode.Name = "barCode";
            barCode.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "name";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.DataPropertyName = "price";
            price.HeaderText = "Precion U.";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Cantidad";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // totalPrice
            // 
            totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPrice.DataPropertyName = "totalPrice";
            totalPrice.HeaderText = "Precio T.";
            totalPrice.MinimumWidth = 6;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stock.DataPropertyName = "stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Visible = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(954, 677);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            UseWaitCursor = true;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableSale).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Label label3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel8;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel10;
        private Panel panel11;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button button2;
        private Label label2;
        private Panel panel9;
        private DataGridView tableSale;
        private Label label4;
        private TextBox textCode;
        private TextBox textQuantity;
        private DataGridViewTextBoxColumn barCode;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewTextBoxColumn Stock;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label9;
    }
}