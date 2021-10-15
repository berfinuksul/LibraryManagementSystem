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
    public partial class FormDashboard : Form
    {
        connect baglanti = new connect();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from Tbl_Book", Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            LblBook.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from Tbl_IR where ReturnDate= '" + TxtReturn.Text + "'", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            LblIssue.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from Tbl_Member", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            LblMember.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from Tbl_User", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            LblUser.Text = dt4.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
