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
    public partial class FormBooks : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlCommandBuilder builder;

        public FormBooks()
        {
            InitializeComponent();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TabAddBook;
            ClearText2();
            TxtSearchAuthorName.Clear();
            TxtSearchBookName.Clear();
            foreach (Control c in panelControls.Controls)
            {
                c.Enabled = false;
            }
            BtnUpdate2.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBookName1.Text) || (string.IsNullOrWhiteSpace(TxtAuthorname1.Text)) || 
                (string.IsNullOrWhiteSpace(ComboxType1.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "insert into Tbl_Book values('" + TxtBookName1.Text + "','" + TxtAuthorname1.Text + "','" + TxtPublishName1.Text + "','" + ComboxType1.Text + "','" + TxtPageNumber1.Text + "','" + DTPPublishYear1.Text + "')";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                    ClearText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearText()
        {
            TxtBookName1.Clear();
            TxtAuthorname1.Clear();

            TxtPublishName1.Clear();

            ComboxType1.ResetText();
            TxtPageNumber1.Clear();
            DTPPublishYear1.Value = DateTime.Now;
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnUpDelBook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabUpDelBook;
            ClearText();
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            populate();
            ClearText();
            ClearText2();

            foreach (Control c in panelControls.Controls)
            {
                c.Enabled = false;
            }
        }

        private void populate()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_Book";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridChooseUpDel.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BtnListAll_Click(object sender, EventArgs e)
        {
            populate();
            ClearText2();
            foreach (Control c in panelControls.Controls)
            {
                c.Enabled = false;
            }
            BtnUpdate2.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtSearchBookName.Text) || string.IsNullOrWhiteSpace(TxtSearchAuthorName.Text))
            {
                MessageBox.Show("Lütfen önce arama yapacağınız kitabın adını ve yazar adını yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Tbl_Book where BookName like '%" + TxtSearchBookName.Text + "%' and BookAuthor like '%" + TxtSearchAuthorName.Text + "%'";
                sda = new SqlDataAdapter(query, Con);
                builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridChooseUpDel.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void ClearText2()
        {
            TxtBookName2.Clear();
            TxtAuthor2.Clear();

            TxtPublish2.Clear();

            ComboxType2.ResetText();
            TxtPageNumber2.Clear();
            DTPPublishYear2.Value = DateTime.Now;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtSearchBookName.Text) || string.IsNullOrWhiteSpace(TxtSearchAuthorName.Text))
            {
                MessageBox.Show("Lütfen önce güncelleyeceğiniz kitabın adını ve yazar adını yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (string.IsNullOrWhiteSpace(TxtBookName2.Text) || (string.IsNullOrWhiteSpace(TxtAuthor2.Text)) ||
               (string.IsNullOrWhiteSpace(ComboxType2.Text)))
                {
                    TxtBookName2.Text = DataGridChooseUpDel.CurrentRow.Cells["BookName"].Value.ToString();
                    TxtAuthor2.Text = DataGridChooseUpDel.CurrentRow.Cells["BookAuthor"].Value.ToString();
                    TxtPublish2.Text = DataGridChooseUpDel.CurrentRow.Cells["BookPublish"].Value.ToString();
                    ComboxType2.Text = DataGridChooseUpDel.CurrentRow.Cells["BookType"].Value.ToString();
                    TxtPageNumber2.Text = DataGridChooseUpDel.CurrentRow.Cells["NumberOfPage"].Value.ToString();
                    DTPPublishYear2.Text = DataGridChooseUpDel.CurrentRow.Cells["PublishYear"].Value.ToString();
                    foreach (Control c in panelControls.Controls)
                    {
                        c.Enabled = true;
                    }
                    BtnUpdate2.Visible = true;
                }

                else
                {
                    try
                    {
                        Con = new SqlConnection(baglanti.Adres);
                        Con.Open();
                        string query = "UPDATE Tbl_Book SET BookName='" + TxtBookName2.Text + "', BookAuthor='" + TxtAuthor2.Text + "', BookPublish='" + TxtPublish2.Text + "', BookType='" + ComboxType2.SelectedItem.ToString() + "', NumberOfPage='" + TxtPageNumber2.Text + "', PublishYear='" + DTPPublishYear2.Text + "' WHERE BookName like '%" + TxtSearchBookName.Text + "%' and BookAuthor like '%" + TxtSearchAuthorName.Text + "%'";
                        cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
                        Con.Close();
                        populate();
                        ClearText2();
                        TxtSearchBookName.Clear();
                        TxtSearchAuthorName.Clear();
                        foreach (Control c in panelControls.Controls)
                        {
                            c.Enabled = false;
                        }
                        BtnUpdate2.Visible = false;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void TxtPageNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtPageNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void BtnUpdate2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBookName2.Text) || (string.IsNullOrWhiteSpace(TxtAuthor2.Text)) ||
                 (string.IsNullOrWhiteSpace(ComboxType2.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "UPDATE Tbl_Book SET BookName='" + TxtBookName2.Text + "', BookAuthor='" + TxtAuthor2.Text + "', BookPublish='" + TxtPublish2.Text + "', BookType='" + ComboxType2.SelectedItem.ToString() + "', NumberOfPage='" + TxtPageNumber2.Text + "', PublishYear='" + DTPPublishYear2.Text + "' WHERE BookName like '%" + TxtSearchBookName.Text + "%' and BookAuthor like '%" + TxtSearchAuthorName.Text + "%'";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                    ClearText2();
                    TxtSearchBookName.Clear();
                    TxtSearchAuthorName.Clear();
                    foreach (Control c in panelControls.Controls)
                    {
                        c.Enabled = false;
                    }
                    BtnUpdate2.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtSearchBookName.Text) || string.IsNullOrWhiteSpace(TxtSearchAuthorName.Text))
            {
                MessageBox.Show("Lütfen önce güncelleyeceğiniz kitabın adını ve yazar adını yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        Con = new SqlConnection(baglanti.Adres);
                        Con.Open();
                        string query = "DELETE FROM Tbl_Book where BookName like '%" + TxtSearchBookName.Text + "%' and BookAuthor like '%" + TxtSearchAuthorName.Text + "%'";
                        cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
                        Con.Close();
                        populate();
                        TxtSearchBookName.Clear();
                        TxtSearchAuthorName.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    populate();
                    TxtSearchAuthorName.Clear();
                    TxtSearchBookName.Clear();
                }
            }
        }

        }
    }

