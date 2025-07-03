namespace postsys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnOut = new FontAwesome.Sharp.IconButton();
            btnUserForm = new FontAwesome.Sharp.IconButton();
            btnClientForm = new FontAwesome.Sharp.IconButton();
            btnInventory = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnSales = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            bntMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 211, 238);
            panelMenu.Controls.Add(btnOut);
            panelMenu.Controls.Add(btnUserForm);
            panelMenu.Controls.Add(btnClientForm);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(btnSales);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 661);
            panelMenu.TabIndex = 0;
            // 
            // btnOut
            // 
            btnOut.Dock = DockStyle.Bottom;
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Times New Roman", 13.8F);
            btnOut.ForeColor = Color.White;
            btnOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnOut.IconColor = Color.FromArgb(11, 47, 75);
            btnOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOut.IconSize = 40;
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(0, 616);
            btnOut.Name = "btnOut";
            btnOut.Padding = new Padding(10, 0, 0, 0);
            btnOut.Size = new Size(230, 45);
            btnOut.TabIndex = 7;
            btnOut.Tag = "Salir";
            btnOut.Text = "iconButton8";
            btnOut.TextAlign = ContentAlignment.MiddleLeft;
            btnOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnUserForm
            // 
            btnUserForm.Dock = DockStyle.Top;
            btnUserForm.FlatAppearance.BorderSize = 0;
            btnUserForm.FlatStyle = FlatStyle.Flat;
            btnUserForm.Font = new Font("Times New Roman", 13.8F);
            btnUserForm.ForeColor = Color.White;
            btnUserForm.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUserForm.IconColor = Color.FromArgb(11, 47, 75);
            btnUserForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserForm.IconSize = 40;
            btnUserForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserForm.Location = new Point(0, 349);
            btnUserForm.Name = "btnUserForm";
            btnUserForm.Padding = new Padding(10, 0, 0, 0);
            btnUserForm.Size = new Size(230, 45);
            btnUserForm.TabIndex = 6;
            btnUserForm.Tag = "Usuarios";
            btnUserForm.Text = "iconButton7";
            btnUserForm.TextAlign = ContentAlignment.MiddleLeft;
            btnUserForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserForm.UseVisualStyleBackColor = true;
            btnUserForm.Click += btnUserForm_Click;
            // 
            // btnClientForm
            // 
            btnClientForm.Dock = DockStyle.Top;
            btnClientForm.FlatAppearance.BorderSize = 0;
            btnClientForm.FlatStyle = FlatStyle.Flat;
            btnClientForm.Font = new Font("Times New Roman", 13.8F);
            btnClientForm.ForeColor = Color.White;
            btnClientForm.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnClientForm.IconColor = Color.FromArgb(11, 47, 75);
            btnClientForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientForm.IconSize = 40;
            btnClientForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientForm.Location = new Point(0, 304);
            btnClientForm.Name = "btnClientForm";
            btnClientForm.Padding = new Padding(10, 0, 0, 0);
            btnClientForm.Size = new Size(230, 45);
            btnClientForm.TabIndex = 5;
            btnClientForm.Tag = "Clientes";
            btnClientForm.Text = "iconButton6";
            btnClientForm.TextAlign = ContentAlignment.MiddleLeft;
            btnClientForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientForm.UseVisualStyleBackColor = true;
            btnClientForm.Click += btnClientForm_Click;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Times New Roman", 13.8F);
            btnInventory.ForeColor = Color.White;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.Store;
            btnInventory.IconColor = Color.FromArgb(11, 47, 75);
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventory.IconSize = 40;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 259);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(10, 0, 0, 0);
            btnInventory.Size = new Size(230, 45);
            btnInventory.TabIndex = 4;
            btnInventory.Tag = "Inventario";
            btnInventory.Text = "iconButton5";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += iconInventory_Click;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Times New Roman", 13.8F);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            iconButton4.IconColor = Color.FromArgb(11, 47, 75);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 214);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 0, 0);
            iconButton4.Size = new Size(230, 45);
            iconButton4.TabIndex = 3;
            iconButton4.Tag = "Facturación";
            iconButton4.Text = "iconButton4";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 13.8F);
            btnSales.ForeColor = Color.White;
            btnSales.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnSales.IconColor = Color.FromArgb(11, 47, 75);
            btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSales.IconSize = 40;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 169);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(10, 0, 0, 0);
            btnSales.Size = new Size(230, 45);
            btnSales.TabIndex = 2;
            btnSales.Tag = "Ventas";
            btnSales.Text = "iconButton3";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Times New Roman", 13.8F);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton2.IconColor = Color.FromArgb(11, 47, 75);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 124);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(230, 45);
            iconButton2.TabIndex = 1;
            iconButton2.Tag = "Inicio";
            iconButton2.Text = "iconButton2";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 124);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.FromArgb(11, 47, 75);
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 40;
            btnMenu.Location = new Point(167, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(60, 71);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(11, 47, 75);
            panelTitleBar.Controls.Add(bntMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(940, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // bntMinimize
            // 
            bntMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMinimize.BackColor = Color.Cyan;
            bntMinimize.FlatStyle = FlatStyle.Flat;
            bntMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            bntMinimize.IconColor = Color.FromArgb(11, 47, 75);
            bntMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntMinimize.IconSize = 30;
            bntMinimize.Location = new Point(824, 0);
            bntMinimize.Name = "bntMinimize";
            bntMinimize.Size = new Size(39, 31);
            bntMinimize.TabIndex = 4;
            bntMinimize.UseVisualStyleBackColor = false;
            bntMinimize.Click += bntMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Gray;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 30;
            btnMaximize.Location = new Point(863, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(39, 31);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
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
            btnClose.Location = new Point(901, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 31);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.WhiteSmoke;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(230, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(940, 601);
            panelDesktop.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1170, 661);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Resize += Form1_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnOut;
        private FontAwesome.Sharp.IconButton btnUserForm;
        private FontAwesome.Sharp.IconButton btnClientForm;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton bntMinimize;
    }
}
