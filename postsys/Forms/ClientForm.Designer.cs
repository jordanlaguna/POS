namespace Dashboard
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            textEmail = new TextBox();
            pictureBox9 = new PictureBox();
            label9 = new Label();
            textIdentification = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panel5 = new Panel();
            textTelephone = new TextBox();
            textName = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            textAddress = new TextBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            textLastName = new TextBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel7 = new Panel();
            textSecondName = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimeRegister = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel12 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            txtSearch = new TextBox();
            panel10 = new Panel();
            panel11 = new Panel();
            tableClients = new DataGridView();
            ColumnIdentification = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnsecondName = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTelephone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableClients).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Controls.Add(panel7, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 18);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(954, 237);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textEmail);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textIdentification);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 227);
            panel2.TabIndex = 0;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.BackColor = Color.White;
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Times New Roman", 13F);
            textEmail.ForeColor = Color.Black;
            textEmail.Location = new Point(12, 175);
            textEmail.Margin = new Padding(2);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Digite el correo";
            textEmail.Size = new Size(205, 26);
            textEmail.TabIndex = 5;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 197);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(205, 12);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 13F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(6, 143);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(88, 30);
            label9.TabIndex = 5;
            label9.Text = "Correo:";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // textIdentification
            // 
            textIdentification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textIdentification.BackColor = Color.White;
            textIdentification.BorderStyle = BorderStyle.None;
            textIdentification.Font = new Font("Times New Roman", 13F);
            textIdentification.ForeColor = Color.Black;
            textIdentification.Location = new Point(12, 54);
            textIdentification.Margin = new Padding(2);
            textIdentification.Multiline = true;
            textIdentification.Name = "textIdentification";
            textIdentification.PlaceholderText = "Digite la cédula";
            textIdentification.Size = new Size(206, 26);
            textIdentification.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 76);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(206, 12);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 13F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(2, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 1;
            label1.Text = "Cédula:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textTelephone);
            panel5.Controls.Add(textName);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(242, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 227);
            panel5.TabIndex = 1;
            // 
            // textTelephone
            // 
            textTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTelephone.BackColor = Color.White;
            textTelephone.BorderStyle = BorderStyle.None;
            textTelephone.Font = new Font("Times New Roman", 13F);
            textTelephone.ForeColor = Color.Black;
            textTelephone.Location = new Point(9, 175);
            textTelephone.Margin = new Padding(2);
            textTelephone.Multiline = true;
            textTelephone.Name = "textTelephone";
            textTelephone.PlaceholderText = "Digite el teléfono";
            textTelephone.Size = new Size(206, 26);
            textTelephone.TabIndex = 6;
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textName.BackColor = Color.White;
            textName.BorderStyle = BorderStyle.None;
            textName.Font = new Font("Times New Roman", 13F);
            textName.ForeColor = Color.Black;
            textName.Location = new Point(14, 53);
            textName.Margin = new Padding(2);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.PlaceholderText = "Digite el nombre";
            textName.Size = new Size(203, 26);
            textName.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 197);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(206, 12);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 75);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(203, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(2, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 13F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(5, 144);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 6;
            label5.Text = "Teléfono:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textAddress);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(textLastName);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(479, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 227);
            panel6.TabIndex = 2;
            // 
            // textAddress
            // 
            textAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textAddress.BackColor = Color.White;
            textAddress.BorderStyle = BorderStyle.None;
            textAddress.Font = new Font("Times New Roman", 13F);
            textAddress.ForeColor = Color.Black;
            textAddress.Location = new Point(16, 174);
            textAddress.Margin = new Padding(2);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "Provincia/Cantón/Distrito";
            textAddress.Size = new Size(203, 26);
            textAddress.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 196);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(203, 12);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 21);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 3;
            label3.Text = "Primer Apellido:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textLastName
            // 
            textLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textLastName.BackColor = Color.White;
            textLastName.BorderStyle = BorderStyle.None;
            textLastName.Font = new Font("Times New Roman", 13F);
            textLastName.ForeColor = Color.Black;
            textLastName.Location = new Point(16, 53);
            textLastName.Margin = new Padding(2);
            textLastName.Multiline = true;
            textLastName.Name = "textLastName";
            textLastName.PlaceholderText = "Digite el apellido";
            textLastName.Size = new Size(203, 26);
            textLastName.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 75);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 12);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 13F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(5, 142);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 30);
            label7.TabIndex = 7;
            label7.Text = "Dirección:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(textSecondName);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(dateTimeRegister);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(716, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 227);
            panel7.TabIndex = 3;
            // 
            // textSecondName
            // 
            textSecondName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSecondName.BackColor = Color.White;
            textSecondName.BorderStyle = BorderStyle.None;
            textSecondName.Font = new Font("Times New Roman", 13F);
            textSecondName.ForeColor = Color.Black;
            textSecondName.Location = new Point(16, 53);
            textSecondName.Margin = new Padding(2);
            textSecondName.Multiline = true;
            textSecondName.Name = "textSecondName";
            textSecondName.PlaceholderText = "Digite el apellido";
            textSecondName.Size = new Size(205, 26);
            textSecondName.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 75);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dateTimeRegister
            // 
            dateTimeRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeRegister.Font = new Font("Verdana", 12F);
            dateTimeRegister.Format = DateTimePickerFormat.Short;
            dateTimeRegister.Location = new Point(11, 174);
            dateTimeRegister.Margin = new Padding(2);
            dateTimeRegister.Name = "dateTimeRegister";
            dateTimeRegister.RightToLeft = RightToLeft.No;
            dateTimeRegister.Size = new Size(172, 32);
            dateTimeRegister.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(2, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 30);
            label4.TabIndex = 4;
            label4.Text = "Segundo Apellido:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 13F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(5, 144);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 30);
            label6.TabIndex = 8;
            label6.Text = "Fecha Registro:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel12, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 255);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(954, 78);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnAgregar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(311, 72);
            panel3.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Green;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregar.IconColor = Color.FromArgb(11, 47, 75);
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(74, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(172, 50);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.UseWaitCursor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(iconButton1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(320, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(311, 72);
            panel4.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.BackColor = Color.Yellow;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Yellow;
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Times New Roman", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton1.IconColor = Color.FromArgb(11, 47, 75);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(74, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.RightToLeft = RightToLeft.No;
            iconButton1.Size = new Size(172, 50);
            iconButton1.TabIndex = 10;
            iconButton1.Text = "Actualizar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.UseWaitCursor = true;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(iconButton3);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(637, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(314, 72);
            panel12.TabIndex = 2;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton3.BackColor = Color.Red;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Red;
            iconButton3.FlatAppearance.BorderSize = 2;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Times New Roman", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton3.IconColor = Color.FromArgb(11, 47, 75);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(74, 10);
            iconButton3.Name = "iconButton3";
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(172, 50);
            iconButton3.TabIndex = 11;
            iconButton3.Text = "Desactivar";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.UseWaitCursor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 333);
            panel8.Name = "panel8";
            panel8.Size = new Size(954, 344);
            panel8.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel9, 0, 0);
            tableLayoutPanel3.Controls.Add(panel10, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Size = new Size(954, 344);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox10);
            panel9.Controls.Add(pictureBox8);
            panel9.Controls.Add(txtSearch);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(948, 80);
            panel9.TabIndex = 0;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(373, 31);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 40);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Top;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(948, 22);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtSearch.Font = new Font("Times New Roman", 14F);
            txtSearch.Location = new Point(4, 31);
            txtSearch.Margin = new Padding(2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(365, 39);
            txtSearch.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 89);
            panel10.Name = "panel10";
            panel10.Size = new Size(948, 252);
            panel10.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(tableClients);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(948, 252);
            panel11.TabIndex = 0;
            // 
            // tableClients
            // 
            tableClients.AllowUserToAddRows = false;
            tableClients.AllowUserToDeleteRows = false;
            tableClients.AllowUserToResizeColumns = false;
            tableClients.AllowUserToResizeRows = false;
            tableClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableClients.BackgroundColor = Color.FromArgb(26, 46, 53);
            tableClients.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableClients.Columns.AddRange(new DataGridViewColumn[] { ColumnIdentification, ColumnName, ColumnLastName, ColumnsecondName, ColumnEmail, ColumnTelephone, ColumnAddress, ColumnDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableClients.DefaultCellStyle = dataGridViewCellStyle2;
            tableClients.Dock = DockStyle.Fill;
            tableClients.GridColor = SystemColors.ControlDark;
            tableClients.Location = new Point(0, 0);
            tableClients.Margin = new Padding(0);
            tableClients.Name = "tableClients";
            tableClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableClients.RowHeadersVisible = false;
            tableClients.RowHeadersWidth = 62;
            tableClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableClients.RowTemplate.Height = 33;
            tableClients.Size = new Size(948, 252);
            tableClients.TabIndex = 8;
            // 
            // ColumnIdentification
            // 
            ColumnIdentification.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnIdentification.DataPropertyName = "identification";
            ColumnIdentification.FillWeight = 99.07545F;
            ColumnIdentification.HeaderText = "Cédula";
            ColumnIdentification.MinimumWidth = 8;
            ColumnIdentification.Name = "ColumnIdentification";
            ColumnIdentification.ReadOnly = true;
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
            // ColumnLastName
            // 
            ColumnLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLastName.DataPropertyName = "last_name";
            ColumnLastName.FillWeight = 96.98068F;
            ColumnLastName.HeaderText = "P. Apellido";
            ColumnLastName.MinimumWidth = 8;
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            // 
            // ColumnsecondName
            // 
            ColumnsecondName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnsecondName.DataPropertyName = "second_name";
            ColumnsecondName.FillWeight = 100.324692F;
            ColumnsecondName.HeaderText = "S. Apellido";
            ColumnsecondName.MinimumWidth = 8;
            ColumnsecondName.Name = "ColumnsecondName";
            ColumnsecondName.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            ColumnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnEmail.DataPropertyName = "email";
            ColumnEmail.HeaderText = "Correo";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            // 
            // ColumnTelephone
            // 
            ColumnTelephone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTelephone.DataPropertyName = "telephone";
            ColumnTelephone.FillWeight = 101.253265F;
            ColumnTelephone.HeaderText = "Teléfono";
            ColumnTelephone.MinimumWidth = 8;
            ColumnTelephone.Name = "ColumnTelephone";
            ColumnTelephone.ReadOnly = true;
            ColumnTelephone.Resizable = DataGridViewTriState.True;
            // 
            // ColumnAddress
            // 
            ColumnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAddress.DataPropertyName = "address";
            ColumnAddress.HeaderText = "Dirección";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDate.DataPropertyName = "register_date";
            ColumnDate.HeaderText = "F. Registro";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 18);
            panel1.TabIndex = 1;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(954, 677);
            Controls.Add(panel8);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ClientForm";
            Text = "UserForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableClients).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textLastName;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox textAddress;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label2;
        private TextBox textBox3;
        private PictureBox pictureBox7;
        private TextBox textSecondName;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimeRegister;
        private TextBox textTelephone;
        private PictureBox pictureBox5;
        private TextBox textIdentification;
        private PictureBox pictureBox4;
        private TextBox textName;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private TextBox txtSearch;
        private Panel panel11;
        private DataGridView tableClients;
        private Panel panel1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel12;
        private TextBox textEmail;
        private PictureBox pictureBox9;
        private Label label9;
        private DataGridViewTextBoxColumn ColumnIdentification;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnsecondName;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTelephone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnDate;
    }
}