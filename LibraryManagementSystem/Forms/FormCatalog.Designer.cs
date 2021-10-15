
namespace LibraryManagementSystem.Forms
{
    partial class FormCatalog
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
            this.BtnListAllSearchBy = new System.Windows.Forms.Button();
            this.BtnSearchBy = new System.Windows.Forms.Button();
            this.ComboxSearchBy = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DataGridSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearchBy = new System.Windows.Forms.TextBox();
            this.LblSearchBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnListAllSearchBy
            // 
            this.BtnListAllSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnListAllSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnListAllSearchBy.FlatAppearance.BorderSize = 0;
            this.BtnListAllSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListAllSearchBy.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListAllSearchBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnListAllSearchBy.Location = new System.Drawing.Point(588, 121);
            this.BtnListAllSearchBy.Name = "BtnListAllSearchBy";
            this.BtnListAllSearchBy.Size = new System.Drawing.Size(127, 36);
            this.BtnListAllSearchBy.TabIndex = 190;
            this.BtnListAllSearchBy.Text = "Tüm Liste";
            this.BtnListAllSearchBy.UseVisualStyleBackColor = false;
            this.BtnListAllSearchBy.Click += new System.EventHandler(this.BtnListAllSearchBy_Click_1);
            // 
            // BtnSearchBy
            // 
            this.BtnSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BtnSearchBy.FlatAppearance.BorderSize = 0;
            this.BtnSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchBy.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearchBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSearchBy.Location = new System.Drawing.Point(453, 121);
            this.BtnSearchBy.Name = "BtnSearchBy";
            this.BtnSearchBy.Size = new System.Drawing.Size(127, 36);
            this.BtnSearchBy.TabIndex = 189;
            this.BtnSearchBy.Text = "Ara";
            this.BtnSearchBy.UseVisualStyleBackColor = false;
            this.BtnSearchBy.Click += new System.EventHandler(this.BtnSearchBy_Click);
            // 
            // ComboxSearchBy
            // 
            this.ComboxSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboxSearchBy.BackColor = System.Drawing.Color.LightGray;
            this.ComboxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboxSearchBy.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboxSearchBy.FormattingEnabled = true;
            this.ComboxSearchBy.Items.AddRange(new object[] {
            "Kitap ID",
            "Kitap Adı",
            "Yazar Adı",
            "Kitap Türü"});
            this.ComboxSearchBy.Location = new System.Drawing.Point(453, 42);
            this.ComboxSearchBy.Name = "ComboxSearchBy";
            this.ComboxSearchBy.Size = new System.Drawing.Size(262, 26);
            this.ComboxSearchBy.TabIndex = 188;
            this.ComboxSearchBy.SelectedIndexChanged += new System.EventHandler(this.ComboxSearchBy_SelectedIndexChanged_1);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label17.Location = new System.Drawing.Point(344, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 18);
            this.label17.TabIndex = 187;
            this.label17.Text = "Arama Kriteri:";
            // 
            // DataGridSearch
            // 
            this.DataGridSearch.AllowUserToAddRows = false;
            this.DataGridSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridSearch.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridSearch.Location = new System.Drawing.Point(95, 185);
            this.DataGridSearch.Name = "DataGridSearch";
            this.DataGridSearch.ReadOnly = true;
            this.DataGridSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridSearch.RowHeadersWidth = 55;
            this.DataGridSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridSearch.Size = new System.Drawing.Size(925, 380);
            this.DataGridSearch.TabIndex = 186;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.TxtSearchBy);
            this.panel1.Controls.Add(this.LblSearchBy);
            this.panel1.Location = new System.Drawing.Point(320, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 41);
            this.panel1.TabIndex = 191;
            // 
            // TxtSearchBy
            // 
            this.TxtSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearchBy.BackColor = System.Drawing.Color.LightGray;
            this.TxtSearchBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearchBy.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearchBy.Location = new System.Drawing.Point(132, 5);
            this.TxtSearchBy.MaxLength = 11;
            this.TxtSearchBy.Name = "TxtSearchBy";
            this.TxtSearchBy.Size = new System.Drawing.Size(262, 26);
            this.TxtSearchBy.TabIndex = 166;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.LblSearchBy.Location = new System.Drawing.Point(23, 7);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(35, 18);
            this.LblSearchBy.TabIndex = 165;
            this.LblSearchBy.Text = "Ara:";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1114, 606);
            this.Controls.Add(this.BtnListAllSearchBy);
            this.Controls.Add(this.BtnSearchBy);
            this.Controls.Add(this.ComboxSearchBy);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DataGridSearch);
            this.Controls.Add(this.panel1);
            this.Name = "FormCatalog";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListAllSearchBy;
        private System.Windows.Forms.Button BtnSearchBy;
        private System.Windows.Forms.ComboBox ComboxSearchBy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView DataGridSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSearchBy;
        private System.Windows.Forms.Label LblSearchBy;
    }
}