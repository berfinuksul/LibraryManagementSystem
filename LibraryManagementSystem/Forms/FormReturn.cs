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
    public partial class FormReturn : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader reader;
        SqlCommandBuilder builder;
        DataTable dt;
        public FormReturn()
        {
            InitializeComponent();
        }

        //TC ile aratma yapılır.
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtTC.Text == "")
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Tbl_IR where MemberTC = " + TxtTC.Text + " and ReturnDate= '" + TxtReturn.Text + "'";
                sda = new SqlDataAdapter(query, Con);
                builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridReturn.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void BtnClearTC_Click(object sender, EventArgs e)
        {
            TxtTC.Clear();
        }

        private void FormReturn_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel5.Controls)
            {
                c.Enabled = false;
            }
            populate();
            populateSearch();
            ClearAllText();
        }

        //Tüm kutulardaki yazıları siler.
        private void ClearAllText()
        {
            TxtTC.Clear();
            TxtNameSurname.Clear();
            TxtAdress.Clear();
            TxtTel.Clear();
            TxtEmail.Clear();
            TxtBookAuthor.Clear();
            TxtBookName.Clear();
            ComboxBookID.ResetText();
            ComboxGender.ResetText();
            DTPIssue.Value = DateTime.Now;
            DTPReturn.Value = DateTime.Now;
        }

        private void populate()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_IR where ReturnDate='" + TxtReturn.Text + "'";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridReturn.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNameSurname.Text))
            {
                MessageBox.Show("Lütfen iade edilecek kitabı seçin seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "UPDATE Tbl_IR SET ReturnDate='" + DTPReturn.Text + "' where BookID=" + ComboxBookID.Text + " and MemberTC=" + TxtMemberTC.Text + " ";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap başarıyla iade edildi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                    ClearAllText();
                    TxtTC.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = AddReturn;
        }

        private void DataGridReturn_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNameSurname.Text = DataGridReturn.CurrentRow.Cells["MemberNameSurname"].Value.ToString();
            TxtMemberTC.Text = DataGridReturn.CurrentRow.Cells["MemberTC"].Value.ToString();
            TxtAdress.Text = DataGridReturn.CurrentRow.Cells["Adress"].Value.ToString();
            TxtTel.Text = DataGridReturn.CurrentRow.Cells["MemberTel"].Value.ToString();
            ComboxGender.Text = DataGridReturn.CurrentRow.Cells["MemberGender"].Value.ToString();
            TxtEmail.Text = DataGridReturn.CurrentRow.Cells["MemberEmail"].Value.ToString();
            ComboxBookID.Text = DataGridReturn.CurrentRow.Cells["BookID"].Value.ToString();
            TxtBookName.Text = DataGridReturn.CurrentRow.Cells["BookName"].Value.ToString();
            TxtBookAuthor.Text = DataGridReturn.CurrentRow.Cells["BookAuthor"].Value.ToString();
            DTPIssue.Text = DataGridReturn.CurrentRow.Cells["IssueDate"].Value.ToString();
        }

        private void BtnListReturn_Click(object sender, EventArgs e)
        {
            populateSearch();
            TabControl.SelectedTab = ListReturn;
            ClearAllText();
            TxtTC.Clear();
        }

        private void populateSearch()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_IR where ReturnDate!='"+TxtReturn.Text+"'";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridReturnSearch.DataSource = ds.Tables[0];
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

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "İade Tarihi ile Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız tarihi yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                if (LblSearchBy.Text == "Kitap Adı ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where BookName like '%" + TxtSearchBy.Text + "%' and ReturnDate!= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridReturnSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else if (LblSearchBy.Text == "Kitap ID ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where BookID=" + TxtSearchBy.Text + " and ReturnDate!= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridReturnSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else if (LblSearchBy.Text == "İade Tarihi ile Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where ReturnDate like '%" + TxtSearchBy.Text + "%' and ReturnDate!= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridReturnSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_IR where MemberTC=" + TxtSearchBy.Text + " and ReturnDate!= '" + TxtReturn.Text + "'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridReturnSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

            }
        }

        private void BtnListAllSearchBy_Click(object sender, EventArgs e)
        {
            populateSearch();
            TxtSearchBy.Clear();
        }

        private void ComboxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in panel5.Controls)
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

            else if (ComboxSearchBy.Text == "İade Tarihi")
            {
                LblSearchBy.Text = "İade Tarihi ile Ara:";
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

