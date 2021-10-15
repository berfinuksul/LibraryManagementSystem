using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FormIssued : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader reader;
        SqlCommandBuilder builder;
        DataTable dt;

        public FormIssued()
        {
            InitializeComponent();
        }

        private void Btnıssue_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = AddIssue;
        }

        private void BtnListIssue_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = ListIssue;
            ClearAllText();
            populate();
            foreach (Control c in panelInformations.Controls)
            {
                c.Enabled = false;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtTC.Text == "")
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (string.IsNullOrWhiteSpace(TxtNameSurname.Text) || (string.IsNullOrWhiteSpace(TxtEmail.Text)) ||
                    (string.IsNullOrWhiteSpace(TxtTel.Text)) || (string.IsNullOrWhiteSpace(ComboxGender.Text)))
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_Member where MemberTC = " + TxtTC.Text + "";
                    cmd = new SqlCommand(query, Con);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        TxtTcc.Text = reader[2].ToString();
                        TxtNameSurname.Text = reader[1].ToString();
                        TxtAdress.Text = reader[3].ToString();
                        TxtTel.Text = reader[4].ToString();
                        ComboxGender.Text = reader[5].ToString();
                        TxtEmail.Text = reader[6].ToString();

                        foreach (Control c in panelInformations.Controls)
                        {
                            c.Enabled = true;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Bu TC'ye ait üye bulunamadı!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    Con.Close();
                }
            }
        }

        void populateCombox()
        {
            Con = new SqlConnection(baglanti.Adres);
            string query = "SELECT * FROM Tbl_Book";
            cmd = new SqlCommand(query, Con);
            try
            {
                Con.Open();
                dt = new DataTable();
                dt.Columns.Add("BookID", typeof(int));
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                ComboxBookID.ValueMember = "BookID";
                ComboxBookID.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string BookAuthor;
        string BookName;
        private void fetchData()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_Book where BookID=" + ComboxBookID.SelectedValue.ToString() + "";
            cmd = new SqlCommand(query, Con);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BookAuthor = dr["BookAuthor"].ToString();
                TxtBookAuthor.Text = BookAuthor;
                BookName = dr["BookName"].ToString();
                TxtBookName.Text = BookName;
            }
            Con.Close();
        }


        private void FormIssued_Load(object sender, EventArgs e)
        {
            populate();
            populateCombox();
            ClearAllText();
            foreach (Control c in panelInformations.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in panel3.Controls)
            {
                c.Enabled = false;
            }
        }

        private void BtnClearTC_Click(object sender, EventArgs e)
        {
            TxtTC.Clear(); 
        }

        private void ClearAllText()
        {
            TxtTC.Clear();
            TxtNameSurname.Clear();
            TxtAdress.Clear();
            TxtTel.Clear();
            TxtEmail.Clear();
            TxtBookAuthor.Clear();
            TxtBookName.Clear();
            ComboxBookID.SelectedIndex = -1;
            ComboxGender.ResetText();
            DTPIssue.Value = DateTime.Now;
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllText();
            foreach (Control c in panelInformations.Controls)
            {
                c.Enabled = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtNameSurname.Text == "")
            {
                MessageBox.Show("Lütfen önce ödünç alacak üyenin TC'sini girin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBookName.Text)|| string.IsNullOrWhiteSpace(TxtBookAuthor.Text))
            {
                MessageBox.Show("Lütfen ödünç alınacak kitabın ID'sini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "insert into Tbl_IR values('" + ComboxBookID.SelectedValue.ToString() + "','" + TxtNameSurname.Text + "','" + TxtTcc.Text + "','" + TxtAdress.Text + "','" + TxtTel.Text + "','" + ComboxGender.SelectedItem.ToString() + "','" + TxtEmail.Text + "','" + TxtBookName.Text + "','" + TxtBookAuthor.Text + "','" + DTPIssue.Text + "','" + TxtReturn.Text + "')";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap başarıyla ödünç alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                    ClearAllText();

                    foreach (Control c in panelInformations.Controls)
                    {
                        c.Enabled = false;
                    }
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ComboxBookName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchData();
        }

        private void populate()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_IR where ReturnDate= '" + TxtReturn.Text + "'";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridIssued.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BtnSearchBy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboxSearchBy.Text))
            {
                MessageBox.Show("Lütfen önce arama yapacağınız türü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Üye TC ile Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız üyenin TC'sini yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Kitap ID ile Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız kitabın ID'sini yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Kitap Adı ile Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız kitabın adını yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Ödünç Tarihi ile Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız ödünç tarihini yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (LblSearchBy.Text == "Kitap Adı ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where BookName like '%" + TxtSearchBy.Text + "%' and ReturnDate= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridIssued.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else if (LblSearchBy.Text == "Kitap ID ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where BookID=" + TxtSearchBy.Text + " and ReturnDate= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridIssued.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else if (LblSearchBy.Text == "Ödünç Tarihi ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where IssueDate like '%" + TxtSearchBy.Text + "%' and ReturnDate= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridIssued.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where MemberTC=" + TxtSearchBy.Text + " and ReturnDate= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridIssued.DataSource = ds.Tables[0];
                    Con.Close();
                }

            }
        }

        private void BtnListAllSearchBy_Click(object sender, EventArgs e)
        {
            populate();
            TxtSearchBy.Clear();
        }

        private void ComboxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in panel3.Controls)
            {
                c.Enabled = true;
            }

            if (ComboxSearchBy.Text == "Üye TC")
            {
                LblSearchBy.Text = "Üye TC ile Ara:";
            }

            else if (ComboxSearchBy.Text == "Kitap ID")
            {
                LblSearchBy.Text = "Kitap ID ile Ara:";
            }

            else if (ComboxSearchBy.Text == "Ödünç Tarihi")
            {
                LblSearchBy.Text = "Ödünç Tarihi ile Ara:";
            }

            else
            {
                LblSearchBy.Text = "Kitap Adı ile Ara:";
            }
        }

        private void TxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
