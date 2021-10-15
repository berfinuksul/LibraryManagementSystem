
namespace LibraryManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimizeForm = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCloseForm = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.BtnMinimizeForm);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 174);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtnMinimizeForm
            // 
            this.BtnMinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(73)))));
            this.BtnMinimizeForm.FlatAppearance.BorderSize = 0;
            this.BtnMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizeForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizeForm.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinimizeForm.IconSize = 25;
            this.BtnMinimizeForm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimizeForm.Location = new System.Drawing.Point(296, 1);
            this.BtnMinimizeForm.Name = "BtnMinimizeForm";
            this.BtnMinimizeForm.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizeForm.TabIndex = 32;
            this.BtnMinimizeForm.UseVisualStyleBackColor = false;
            this.BtnMinimizeForm.Click += new System.EventHandler(this.BtnMinimizeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(73)))));
            this.BtnCloseForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCloseForm.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseForm.IconSize = 25;
            this.BtnCloseForm.Location = new System.Drawing.Point(321, 1);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCloseForm.Size = new System.Drawing.Size(25, 25);
            this.BtnCloseForm.TabIndex = 31;
            this.BtnCloseForm.UseVisualStyleBackColor = false;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(83, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogin.Location = new System.Drawing.Point(86, 360);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(174, 40);
            this.BtnLogin.TabIndex = 30;
            this.BtnLogin.Text = "Giriş";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtPassword.Location = new System.Drawing.Point(86, 299);
            this.TxtPassword.MaxLength = 16;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(174, 26);
            this.TxtPassword.TabIndex = 27;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(83, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Şifre";
            // 
            // Txtusername
            // 
            this.Txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txtusername.BackColor = System.Drawing.Color.Gainsboro;
            this.Txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtusername.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Txtusername.Location = new System.Drawing.Point(86, 234);
            this.Txtusername.MaxLength = 250;
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(174, 26);
            this.Txtusername.TabIndex = 26;
            this.Txtusername.Tag = "    ";
            this.Txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsername_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(346, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnMinimizeForm;
        private FontAwesome.Sharp.IconButton BtnCloseForm;
    }
}