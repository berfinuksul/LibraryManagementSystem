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
    public partial class FormCatalog : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlDataAdapter sda;
        SqlCommandBuilder builder;
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void ComboxSearchBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = true;
            }

            if (ComboxSearchBy.Text == "Kitap Adı")
            {
                LblSearchBy.Text = "Kitap Adı Ara:";
            }

            else if (ComboxSearchBy.Text == "Yazar Adı")
            {
                LblSearchBy.Text = "Yazar Adı Ara:";
            }

            else if (ComboxSearchBy.Text == "Kitap ID")
            {
                LblSearchBy.Text = "Kitap ID Ara:";
            }

            else
            {
                LblSearchBy.Text = "Kitap Türü Ara:";
            }
        }

        private void BtnListAllSearchBy_Click_1(object sender, EventArgs e)
        {

            populate();
            TxtSearchBy.Clear();
        }

        private void BtnSearchBy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboxSearchBy.Text))
            {
                MessageBox.Show("Lütfen önce arama yapacağınız türü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Kitap Adı Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız kitabın adını yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Yazar Adı Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız yazarın adını yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Kitap Türü Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız kitap türünü yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else if (string.IsNullOrWhiteSpace(TxtSearchBy.Text) && LblSearchBy.Text == "Kitap ID Ara:")
            {
                MessageBox.Show("Lütfen arama yapacağınız kitap ID'sini yazın !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (LblSearchBy.Text == "Kitap Adı Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_Book where BookName like '%" + TxtSearchBy.Text + "%'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else if (LblSearchBy.Text == "Yazar Adı Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_Book where BookAuthor like '%" + TxtSearchBy.Text + "%'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }
                
                else if (LblSearchBy.Text == "Kitap ID Ara:")
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_Book where BookID=" + TxtSearchBy.Text + "";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

                else
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "select * from Tbl_Book where BookType like '%" + TxtSearchBy.Text + "%'";
                    sda = new SqlDataAdapter(query, Con);
                    builder = new SqlCommandBuilder();
                    var ds = new DataSet();
                    sda.Fill(ds);
                    DataGridSearch.DataSource = ds.Tables[0];
                    Con.Close();
                }

            }
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {

            foreach (Control c in panel1.Controls)
            {
                c.Enabled = false;
            }
            populate();
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
            DataGridSearch.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
