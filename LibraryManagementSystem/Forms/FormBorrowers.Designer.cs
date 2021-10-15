
namespace LibraryManagementSystem.Forms
{
    partial class FormBorrowers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridMember = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.TxtNameSurname = new System.Windows.Forms.TextBox();
            this.ComboxGender = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnUpdate2 = new System.Windows.Forms.Button();
            this.TxtTCSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMember)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnList
            // 
            this.BtnList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnList.FlatAppearance.BorderSize = 0;
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnList.Location = new System.Drawing.Point(783, 406);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(150, 42);
            this.BtnList.TabIndex = 106;
            this.BtnList.Text = "Listeyi Getir";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUpdate.Location = new System.Drawing.Point(783, 463);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 42);
            this.BtnUpdate.TabIndex = 105;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.Location = new System.Drawing.Point(783, 520);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 42);
            this.BtnDelete.TabIndex = 104;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.Location = new System.Drawing.Point(783, 349);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 42);
            this.BtnSearch.TabIndex = 103;
            this.BtnSearch.Text = "Ara";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(780, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 107;
            this.label3.Text = "TC ile arama";
            // 
            // DataGridMember
            // 
            this.DataGridMember.AllowUserToAddRows = false;
            this.DataGridMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridMember.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridMember.Location = new System.Drawing.Point(180, 282);
            this.DataGridMember.Name = "DataGridMember";
            this.DataGridMember.ReadOnly = true;
            this.DataGridMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridMember.RowHeadersWidth = 55;
            this.DataGridMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridMember.Size = new System.Drawing.Size(567, 280);
            this.DataGridMember.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label14.Location = new System.Drawing.Point(177, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 18);
            this.label14.TabIndex = 114;
            this.label14.Text = "TC:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(177, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "Adres:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(177, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Ad Soyad:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label12.Location = new System.Drawing.Point(588, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 117;
            this.label12.Text = "Telefon:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label13.Location = new System.Drawing.Point(588, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 116;
            this.label13.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(588, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 115;
            this.label4.Text = "Cinsiyet:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.BackColor = System.Drawing.Color.LightGray;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(661, 159);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(272, 26);
            this.TxtEmail.TabIndex = 118;
            // 
            // TxtTel
            // 
            this.TxtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTel.BackColor = System.Drawing.Color.LightGray;
            this.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTel.Location = new System.Drawing.Point(661, 78);
            this.TxtTel.MaxLength = 10;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(272, 26);
            this.TxtTel.TabIndex = 119;
            this.TxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // TxtTC
            // 
            this.TxtTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTC.BackColor = System.Drawing.Color.LightGray;
            this.TxtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTC.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTC.Location = new System.Drawing.Point(260, 118);
            this.TxtTC.MaxLength = 11;
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(272, 26);
            this.TxtTC.TabIndex = 120;
            this.TxtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTC_KeyPress);
            // 
            // TxtAdress
            // 
            this.TxtAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAdress.BackColor = System.Drawing.Color.LightGray;
            this.TxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdress.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdress.Location = new System.Drawing.Point(260, 157);
            this.TxtAdress.Multiline = true;
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(272, 79);
            this.TxtAdress.TabIndex = 121;
            // 
            // TxtNameSurname
            // 
            this.TxtNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNameSurname.BackColor = System.Drawing.Color.LightGray;
            this.TxtNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNameSurname.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNameSurname.Location = new System.Drawing.Point(260, 78);
            this.TxtNameSurname.Name = "TxtNameSurname";
            this.TxtNameSurname.Size = new System.Drawing.Size(272, 26);
            this.TxtNameSurname.TabIndex = 122;
            // 
            // ComboxGender
            // 
            this.ComboxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboxGender.BackColor = System.Drawing.Color.LightGray;
            this.ComboxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboxGender.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboxGender.FormattingEnabled = true;
            this.ComboxGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.ComboxGender.Location = new System.Drawing.Point(661, 118);
            this.ComboxGender.Name = "ComboxGender";
            this.ComboxGender.Size = new System.Drawing.Size(272, 26);
            this.ComboxGender.TabIndex = 123;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSave.Location = new System.Drawing.Point(661, 200);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 42);
            this.BtnSave.TabIndex = 124;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnDeleteAll.FlatAppearance.BorderSize = 0;
            this.BtnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteAll.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDeleteAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDeleteAll.Location = new System.Drawing.Point(803, 200);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(130, 42);
            this.BtnDeleteAll.TabIndex = 125;
            this.BtnDeleteAll.Text = "Tümünü Sil";
            this.BtnDeleteAll.UseVisualStyleBackColor = false;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnUpdate2
            // 
            this.BtnUpdate2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnUpdate2.FlatAppearance.BorderSize = 0;
            this.BtnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate2.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUpdate2.Location = new System.Drawing.Point(803, 200);
            this.BtnUpdate2.Name = "BtnUpdate2";
            this.BtnUpdate2.Size = new System.Drawing.Size(130, 42);
            this.BtnUpdate2.TabIndex = 126;
            this.BtnUpdate2.Text = "Güncelle";
            this.BtnUpdate2.UseVisualStyleBackColor = false;
            this.BtnUpdate2.Click += new System.EventHandler(this.BtnUpdate2_Click);
            // 
            // TxtTCSearch
            // 
            this.TxtTCSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTCSearch.BackColor = System.Drawing.Color.LightGray;
            this.TxtTCSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTCSearch.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTCSearch.Location = new System.Drawing.Point(783, 299);
            this.TxtTCSearch.MaxLength = 11;
            this.TxtTCSearch.Name = "TxtTCSearch";
            this.TxtTCSearch.Size = new System.Drawing.Size(150, 26);
            this.TxtTCSearch.TabIndex = 127;
            this.TxtTCSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTCSearch_KeyPress);
            // 
            // FormBorrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1114, 612);
            this.Controls.Add(this.TxtTCSearch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDeleteAll);
            this.Controls.Add(this.BtnUpdate2);
            this.Controls.Add(this.ComboxGender);
            this.Controls.Add(this.TxtNameSurname);
            this.Controls.Add(this.TxtAdress);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Name = "FormBorrowers";
            this.Text = "FormBorrowers";
            this.Load += new System.EventHandler(this.FormBorrowers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridMember;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox TxtNameSurname;
        private System.Windows.Forms.ComboBox ComboxGender;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.Button BtnUpdate2;
        private System.Windows.Forms.TextBox TxtTCSearch;
    }
}