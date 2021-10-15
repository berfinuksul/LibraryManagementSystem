
namespace LibraryManagementSystem
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignOut = new FontAwesome.Sharp.IconButton();
            this.BtnUserAccount = new FontAwesome.Sharp.IconButton();
            this.BtnReturn = new FontAwesome.Sharp.IconButton();
            this.BtnIssuedBook = new FontAwesome.Sharp.IconButton();
            this.BtnCatalog = new FontAwesome.Sharp.IconButton();
            this.BtnAddBook = new FontAwesome.Sharp.IconButton();
            this.BtnBorrowers = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.BtnFormMaximize = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizeForm = new FontAwesome.Sharp.IconButton();
            this.BtnCloseForm = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.BtnCloseChildForm = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.BtnSignOut);
            this.panelMenu.Controls.Add(this.BtnUserAccount);
            this.panelMenu.Controls.Add(this.BtnReturn);
            this.panelMenu.Controls.Add(this.BtnIssuedBook);
            this.panelMenu.Controls.Add(this.BtnCatalog);
            this.panelMenu.Controls.Add(this.BtnAddBook);
            this.panelMenu.Controls.Add(this.BtnBorrowers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 729);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 683);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 23;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSignOut.FlatAppearance.BorderSize = 0;
            this.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignOut.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnSignOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnSignOut.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSignOut.IconSize = 35;
            this.BtnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSignOut.Location = new System.Drawing.Point(0, 684);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnSignOut.Size = new System.Drawing.Size(220, 45);
            this.BtnSignOut.TabIndex = 12;
            this.BtnSignOut.Text = "Oturumu Kapat";
            this.BtnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnUserAccount
            // 
            this.BtnUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnUserAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUserAccount.FlatAppearance.BorderSize = 0;
            this.BtnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnUserAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUserAccount.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.BtnUserAccount.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnUserAccount.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnUserAccount.IconSize = 35;
            this.BtnUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserAccount.Location = new System.Drawing.Point(0, 410);
            this.BtnUserAccount.Name = "BtnUserAccount";
            this.BtnUserAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnUserAccount.Size = new System.Drawing.Size(220, 45);
            this.BtnUserAccount.TabIndex = 10;
            this.BtnUserAccount.Text = "Kullanıcı Hesap İşlemleri";
            this.BtnUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserAccount.UseVisualStyleBackColor = false;
            this.BtnUserAccount.Click += new System.EventHandler(this.BtnUserAccount_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnReturn.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.BtnReturn.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnReturn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnReturn.IconSize = 35;
            this.BtnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.Location = new System.Drawing.Point(0, 365);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnReturn.Size = new System.Drawing.Size(220, 45);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Kitap İade İşlemi";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnIssuedBook
            // 
            this.BtnIssuedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnIssuedBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIssuedBook.FlatAppearance.BorderSize = 0;
            this.BtnIssuedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssuedBook.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnIssuedBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnIssuedBook.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.BtnIssuedBook.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnIssuedBook.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnIssuedBook.IconSize = 35;
            this.BtnIssuedBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssuedBook.Location = new System.Drawing.Point(0, 320);
            this.BtnIssuedBook.Name = "BtnIssuedBook";
            this.BtnIssuedBook.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnIssuedBook.Size = new System.Drawing.Size(220, 45);
            this.BtnIssuedBook.TabIndex = 5;
            this.BtnIssuedBook.Text = "Kitap Ödünç İşlemi";
            this.BtnIssuedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssuedBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIssuedBook.UseVisualStyleBackColor = false;
            this.BtnIssuedBook.Click += new System.EventHandler(this.BtnAddCopy_Click);
            // 
            // BtnCatalog
            // 
            this.BtnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCatalog.FlatAppearance.BorderSize = 0;
            this.BtnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalog.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnCatalog.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCatalog.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.BtnCatalog.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCatalog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCatalog.IconSize = 35;
            this.BtnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalog.Location = new System.Drawing.Point(0, 275);
            this.BtnCatalog.Name = "BtnCatalog";
            this.BtnCatalog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCatalog.Size = new System.Drawing.Size(220, 45);
            this.BtnCatalog.TabIndex = 4;
            this.BtnCatalog.Text = "Katalog";
            this.BtnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCatalog.UseVisualStyleBackColor = false;
            this.BtnCatalog.Click += new System.EventHandler(this.BtnPullOutBook_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddBook.FlatAppearance.BorderSize = 0;
            this.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBook.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnAddBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAddBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BtnAddBook.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddBook.IconSize = 35;
            this.BtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddBook.Location = new System.Drawing.Point(0, 230);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAddBook.Size = new System.Drawing.Size(220, 45);
            this.BtnAddBook.TabIndex = 3;
            this.BtnAddBook.Text = "Kitap İşlemleri";
            this.BtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnBorrowers
            // 
            this.BtnBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.BtnBorrowers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBorrowers.FlatAppearance.BorderSize = 0;
            this.BtnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrowers.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.BtnBorrowers.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnBorrowers.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.BtnBorrowers.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnBorrowers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBorrowers.IconSize = 35;
            this.BtnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrowers.Location = new System.Drawing.Point(0, 185);
            this.BtnBorrowers.Name = "BtnBorrowers";
            this.BtnBorrowers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnBorrowers.Size = new System.Drawing.Size(220, 45);
            this.BtnBorrowers.TabIndex = 2;
            this.BtnBorrowers.Text = "Kütüphane Üye İşlemleri";
            this.BtnBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBorrowers.UseVisualStyleBackColor = false;
            this.BtnBorrowers.Click += new System.EventHandler(this.BtnBorrowers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(45)))), ((int)(((byte)(114)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 35;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Gösterge Paneli";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblusername);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblusername.Location = new System.Drawing.Point(87, 72);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(85, 18);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(86, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(3, -11);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(162, 161);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.panelTitleBar.Controls.Add(this.lbltime);
            this.panelTitleBar.Controls.Add(this.lbldate);
            this.panelTitleBar.Controls.Add(this.BtnFormMaximize);
            this.panelTitleBar.Controls.Add(this.BtnMinimizeForm);
            this.panelTitleBar.Controls.Add(this.BtnCloseForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1130, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltime.Location = new System.Drawing.Point(897, 16);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(61, 25);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "time";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Century", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbldate.Location = new System.Drawing.Point(898, 45);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 18);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "date";
            // 
            // BtnFormMaximize
            // 
            this.BtnFormMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFormMaximize.FlatAppearance.BorderSize = 0;
            this.BtnFormMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFormMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.BtnFormMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFormMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFormMaximize.IconSize = 25;
            this.BtnFormMaximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFormMaximize.Location = new System.Drawing.Point(1078, 0);
            this.BtnFormMaximize.Name = "BtnFormMaximize";
            this.BtnFormMaximize.Size = new System.Drawing.Size(25, 25);
            this.BtnFormMaximize.TabIndex = 4;
            this.BtnFormMaximize.UseVisualStyleBackColor = true;
            this.BtnFormMaximize.Click += new System.EventHandler(this.BtnFormMaximize_Click);
            // 
            // BtnMinimizeForm
            // 
            this.BtnMinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizeForm.FlatAppearance.BorderSize = 0;
            this.BtnMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizeForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizeForm.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinimizeForm.IconSize = 25;
            this.BtnMinimizeForm.Location = new System.Drawing.Point(1053, 0);
            this.BtnMinimizeForm.Name = "BtnMinimizeForm";
            this.BtnMinimizeForm.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizeForm.TabIndex = 3;
            this.BtnMinimizeForm.UseVisualStyleBackColor = true;
            this.BtnMinimizeForm.Click += new System.EventHandler(this.BtnMinimizelForm_Click);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCloseForm.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseForm.IconSize = 25;
            this.BtnCloseForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCloseForm.Location = new System.Drawing.Point(1103, 0);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCloseForm.Size = new System.Drawing.Size(25, 25);
            this.BtnCloseForm.TabIndex = 2;
            this.BtnCloseForm.UseVisualStyleBackColor = true;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(53, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(70, 18);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Anasayfa";
            // 
            // iconChildForm
            // 
            this.iconChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.iconChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildForm.IconSize = 35;
            this.iconChildForm.Location = new System.Drawing.Point(18, 23);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(35, 35);
            this.iconChildForm.TabIndex = 0;
            this.iconChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(39)))), ((int)(((byte)(104)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1130, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.panelDesktop.Controls.Add(this.BtnCloseChildForm);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1130, 645);
            this.panelDesktop.TabIndex = 3;
            // 
            // BtnCloseChildForm
            // 
            this.BtnCloseChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseChildForm.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseChildForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCloseChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnCloseChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseChildForm.IconSize = 39;
            this.BtnCloseChildForm.Location = new System.Drawing.Point(1092, 1);
            this.BtnCloseChildForm.Name = "BtnCloseChildForm";
            this.BtnCloseChildForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCloseChildForm.Size = new System.Drawing.Size(39, 39);
            this.BtnCloseChildForm.TabIndex = 21;
            this.BtnCloseChildForm.UseVisualStyleBackColor = false;
            this.BtnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1310, 700);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton BtnSignOut;
        private FontAwesome.Sharp.IconButton BtnUserAccount;
        private FontAwesome.Sharp.IconButton BtnReturn;
        private FontAwesome.Sharp.IconButton BtnIssuedBook;
        private FontAwesome.Sharp.IconButton BtnCatalog;
        private FontAwesome.Sharp.IconButton BtnAddBook;
        private FontAwesome.Sharp.IconButton BtnBorrowers;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton BtnCloseForm;
        private FontAwesome.Sharp.IconButton BtnFormMaximize;
        private FontAwesome.Sharp.IconButton BtnMinimizeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnCloseChildForm;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
    }
}

