namespace Dashboard
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            textBoxId = new TextBox();
            textBoxTelephone = new TextBox();
            pictureBox5 = new PictureBox();
            textBoxIdentification = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            textBoxName = new TextBox();
            pictureBox3 = new PictureBox();
            dateTimePickerBirthDate = new DateTimePicker();
            label6 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            textBoxEmail = new TextBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            txtLastName = new TextBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel7 = new Panel();
            textBoxSecondName = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            txtSearch = new TextBox();
            panel10 = new Panel();
            panel11 = new Panel();
            tableUsers = new DataGridView();
            ColumnBirthDate = new DataGridViewTextBoxColumn();
            ColumnIdentification = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnsecondName = new DataGridViewTextBoxColumn();
            ColumnTelephone = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableUsers).BeginInit();
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
            panel2.Controls.Add(textBoxId);
            panel2.Controls.Add(textBoxTelephone);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(textBoxIdentification);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 227);
            panel2.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.BackColor = Color.White;
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Times New Roman", 13F);
            textBoxId.ForeColor = Color.Black;
            textBoxId.Location = new Point(195, 2);
            textBoxId.Margin = new Padding(2);
            textBoxId.Multiline = true;
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Digite su cédula";
            textBoxId.Size = new Size(34, 26);
            textBoxId.TabIndex = 33;
            textBoxId.Visible = false;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTelephone.BackColor = Color.White;
            textBoxTelephone.BorderStyle = BorderStyle.None;
            textBoxTelephone.Font = new Font("Times New Roman", 13F);
            textBoxTelephone.ForeColor = Color.Black;
            textBoxTelephone.Location = new Point(10, 174);
            textBoxTelephone.Margin = new Padding(2);
            textBoxTelephone.Multiline = true;
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.PlaceholderText = "Digite su teléfono";
            textBoxTelephone.Size = new Size(206, 26);
            textBoxTelephone.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 197);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(206, 12);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // textBoxIdentification
            // 
            textBoxIdentification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdentification.BackColor = Color.White;
            textBoxIdentification.BorderStyle = BorderStyle.None;
            textBoxIdentification.Font = new Font("Times New Roman", 13F);
            textBoxIdentification.ForeColor = Color.Black;
            textBoxIdentification.Location = new Point(12, 54);
            textBoxIdentification.Margin = new Padding(2);
            textBoxIdentification.Multiline = true;
            textBoxIdentification.Name = "textBoxIdentification";
            textBoxIdentification.PlaceholderText = "Digite su cédula";
            textBoxIdentification.Size = new Size(206, 26);
            textBoxIdentification.TabIndex = 1;
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
            label1.TabIndex = 4;
            label1.Text = "Cédula:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 13F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(5, 142);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 16;
            label5.Text = "Teléfono:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBoxName);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(dateTimePickerBirthDate);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(242, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 227);
            panel5.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = Color.White;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Times New Roman", 13F);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(14, 54);
            textBoxName.Margin = new Padding(2);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Digite su nombre";
            textBoxName.Size = new Size(203, 26);
            textBoxName.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 76);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(203, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerBirthDate.Font = new Font("Verdana", 12F);
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(12, 179);
            dateTimePickerBirthDate.Margin = new Padding(2);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.RightToLeft = RightToLeft.No;
            dateTimePickerBirthDate.Size = new Size(206, 32);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 13F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(226, 30);
            label6.TabIndex = 25;
            label6.Text = "Fecha Nacimiento:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(2, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textBoxEmail);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(txtLastName);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(479, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 227);
            panel6.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Times New Roman", 13F);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(16, 174);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Digite su correo";
            textBoxEmail.Size = new Size(203, 26);
            textBoxEmail.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 197);
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
            label3.TabIndex = 10;
            label3.Text = "Primer Apellido:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Times New Roman", 13F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(16, 54);
            txtLastName.Margin = new Padding(2);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Digite su apellido";
            txtLastName.Size = new Size(203, 26);
            txtLastName.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 76);
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
            label7.Location = new Point(3, 142);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 30);
            label7.TabIndex = 21;
            label7.Text = "Correo:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(textBoxSecondName);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(label4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(716, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 227);
            panel7.TabIndex = 3;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSecondName.BackColor = Color.White;
            textBoxSecondName.BorderStyle = BorderStyle.None;
            textBoxSecondName.Font = new Font("Times New Roman", 13F);
            textBoxSecondName.ForeColor = Color.Black;
            textBoxSecondName.Location = new Point(16, 54);
            textBoxSecondName.Margin = new Padding(2);
            textBoxSecondName.Multiline = true;
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.PlaceholderText = "Digite su apellido";
            textBoxSecondName.Size = new Size(205, 26);
            textBoxSecondName.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 76);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(2, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 30);
            label4.TabIndex = 13;
            label4.Text = "Segundo Apellido:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 255);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(954, 78);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 72);
            panel3.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.Yellow;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.Font = new Font("Times New Roman", 12F);
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnUpdate.IconColor = Color.FromArgb(11, 47, 75);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(155, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.No;
            btnUpdate.Size = new Size(165, 50);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.UseWaitCursor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(iconButton3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(480, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(471, 72);
            panel4.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton3.BackColor = Color.Red;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Red;
            iconButton3.FlatAppearance.BorderSize = 2;
            iconButton3.Font = new Font("Times New Roman", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton3.IconColor = Color.FromArgb(11, 47, 75);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(157, 11);
            iconButton3.Name = "iconButton3";
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(165, 50);
            iconButton3.TabIndex = 24;
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
            txtSearch.TabIndex = 11;
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
            panel11.Controls.Add(tableUsers);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(948, 252);
            panel11.TabIndex = 0;
            // 
            // tableUsers
            // 
            tableUsers.AllowUserToAddRows = false;
            tableUsers.AllowUserToDeleteRows = false;
            tableUsers.AllowUserToResizeColumns = false;
            tableUsers.AllowUserToResizeRows = false;
            tableUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableUsers.BackgroundColor = Color.FromArgb(11, 47, 75);
            tableUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUsers.Columns.AddRange(new DataGridViewColumn[] { ColumnBirthDate, ColumnIdentification, ColumnName, ColumnLastName, ColumnsecondName, ColumnTelephone, ColumnEmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableUsers.DefaultCellStyle = dataGridViewCellStyle2;
            tableUsers.Dock = DockStyle.Fill;
            tableUsers.GridColor = SystemColors.ControlDark;
            tableUsers.Location = new Point(0, 0);
            tableUsers.Margin = new Padding(0);
            tableUsers.Name = "tableUsers";
            tableUsers.ReadOnly = true;
            tableUsers.RowHeadersVisible = false;
            tableUsers.RowHeadersWidth = 62;
            tableUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableUsers.RowTemplate.Height = 33;
            tableUsers.Size = new Size(948, 252);
            tableUsers.TabIndex = 8;
            // 
            // ColumnBirthDate
            // 
            ColumnBirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnBirthDate.DataPropertyName = "birth_date";
            ColumnBirthDate.FillWeight = 100.12516F;
            ColumnBirthDate.HeaderText = "F° Nacimiento";
            ColumnBirthDate.MinimumWidth = 8;
            ColumnBirthDate.Name = "ColumnBirthDate";
            ColumnBirthDate.ReadOnly = true;
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
            ColumnLastName.DataPropertyName = "lastName";
            ColumnLastName.FillWeight = 96.98068F;
            ColumnLastName.HeaderText = "P. Apellido";
            ColumnLastName.MinimumWidth = 8;
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            // 
            // ColumnsecondName
            // 
            ColumnsecondName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnsecondName.DataPropertyName = "secondName";
            ColumnsecondName.FillWeight = 100.324692F;
            ColumnsecondName.HeaderText = "S. Apellido";
            ColumnsecondName.MinimumWidth = 8;
            ColumnsecondName.Name = "ColumnsecondName";
            ColumnsecondName.ReadOnly = true;
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
            // ColumnEmail
            // 
            ColumnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnEmail.DataPropertyName = "email";
            ColumnEmail.FillWeight = 100.060616F;
            ColumnEmail.HeaderText = "Correo";
            ColumnEmail.MinimumWidth = 8;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
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
            // UserForm
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
            Name = "UserForm";
            Text = "UserForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
            panel8.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtLastName;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBoxEmail;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label2;
        private TextBox textBoxSecondName;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePickerBirthDate;
        private TextBox textBoxTelephone;
        private PictureBox pictureBox5;
        private TextBox textBoxIdentification;
        private PictureBox pictureBox4;
        private TextBox textBoxName;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private TextBox txtSearch;
        private Panel panel11;
        private DataGridView tableUsers;
        private Panel panel1;
        private DataGridViewTextBoxColumn ColumnBirthDate;
        private DataGridViewTextBoxColumn ColumnIdentification;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnsecondName;
        private DataGridViewTextBoxColumn ColumnTelephone;
        private DataGridViewTextBoxColumn ColumnEmail;
        private TextBox textBoxId;
    }
}