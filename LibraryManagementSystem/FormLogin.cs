using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class FormLogin : Form
    {
        connect baglanti = new connect();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public FormLogin()
        {
            InitializeComponent();  
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCloseForm_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        //Kullanıcı adı ve şifre girilince klavyedeki enter tuşu ile girşi sağlar.
        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        public static string username;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tbl_User where username=@username COLLATE Latin1_General_CS_AS AND password=@password COLLATE Latin1_General_CS_AS";
            con = new SqlConnection(baglanti.Adres);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", Txtusername.Text);
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = Txtusername.Text;
                FormMenu fm = new FormMenu();
                this.Hide();
                fm.Show();
            }

            else
            {
                if (string.IsNullOrWhiteSpace(Txtusername.Text) && (string.IsNullOrWhiteSpace(TxtPassword.Text)))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifre girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (string.IsNullOrWhiteSpace(Txtusername.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    MessageBox.Show("Lütfen şifre girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya parola", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
        

    }
}
