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
    public partial class FormUserAccount : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlCommandBuilder builder;
        DataTable dt;
        public FormUserAccount()
        {
            InitializeComponent();
        }

        //Yeni kullanıcı ekler.
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text != TxtPassword2.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(TxtNameSurname.Text) || (string.IsNullOrWhiteSpace(TxtUserName.Text)) || (string.IsNullOrWhiteSpace(TxtEmail.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtEmail.Text.Contains("@") == false || TxtEmail.Text.Contains(".com") == false)
            {
                MessageBox.Show("Mail adresinizi hatalı yazdınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((string.IsNullOrWhiteSpace(TxtTel.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtTel.TextLength < 10)
            {
                MessageBox.Show("Telefon numaranızı eksik girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((string.IsNullOrWhiteSpace(TxtPassword.Text)) ||
                    (string.IsNullOrWhiteSpace(TxtPassword2.Text)) || (string.IsNullOrWhiteSpace(ComboxRole.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "insert into Tbl_User values('" + TxtNameSurname.Text + "','" + TxtUserName.Text + "','" + TxtEmail.Text + "','" + TxtTel.Text + "','" + TxtPassword.Text + "','" + ComboxRole.Text + "')";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni kullanıcı başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    TxtNameSurname.Text = "";
                    TxtUserName.Text = "";
                    TxtEmail.Text = "";
                    TxtTel.Text = "";
                    TxtPassword.Text = "";
                    TxtPassword2.Text = "";
                    ComboxRole.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Telefon numarasının sadece klavyeden sayı ve silme tuşunun girilmesine izin verir.
        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //Textbox'ların içini temizler.
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtNameSurname.Text = "";
            TxtUserName.Text = "";
            TxtEmail.Text = "";
            TxtTel.Text = "";
            TxtPassword.Text = "";
            TxtPassword2.Text = "";
            ComboxRole.Text = "";
        }

        //Profili görüntüle kısmında kullanıcı bilgilerini getirir.
         private void populate()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_User where username='" + FormLogin.username + "'";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();

            lblNameSurname.Text = dataGridView1.CurrentRow.Cells["UserNameSurname"].Value.ToString();
            lblEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            lblTel.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
            lblRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
        }

        private void FormUserAccount_Load(object sender, EventArgs e)
        {
            populate();
            lblUN.Text = FormLogin.username;
            lblusername.Text = FormLogin.username;

            foreach (Control c in panel7.Controls)
            {
                c.Enabled = false;
            }
            BtnOkChange.Enabled = false;
        }

        //Eski şifre girildiğinde aynı mı değil mi kontrol edder. Yani databaseden verileri okur.
        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtexistpassword.Text))
            {
                MessageBox.Show("Lütfen önce mevcut şifrenizi girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         else
         {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_User where username='" + FormLogin.username + "' and password='" + txtexistpassword.Text + "'";
            cmd = new SqlCommand(query, Con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Eski Şifrenizi doğru girdiniz! Şimdi yeni şifre belirleyebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control c in panel7.Controls)
                {
                    c.Enabled = true;
                }
                    BtnOkChange.Enabled = true;
            }

            else
            {
                MessageBox.Show("Eski Şifrenizi hatalı girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
          }
        }

        //Şifre değitirme işlemini yapar. Yani eski şifreyi güncelleme işlemidir.
        private void BtnOkChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtchangepassword.Text) || string.IsNullOrWhiteSpace(txtchangepassword2.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtchangepassword.Text != txtchangepassword2.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "update Tbl_User set password='" + txtchangepassword.Text + "' where username='" + FormLogin.username + "'";
            cmd = new SqlCommand(query, Con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Con.Close();
                txtchangepassword.Text = "";
                txtchangepassword2.Text = "";
                txtexistpassword.Text = "";
                foreach (Control c in panel7.Controls)
                {
                    c.Enabled = false;
                }
                BtnOkChange.Enabled = false;

            }
        }

        //Hesap silme işlemi yapılır.
        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu hesabı silmek istediğinize emin misiniz?", "Hesabımı Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "delete from Tbl_User where username='" + FormLogin.username + "'";
                cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bu hesap silinmiştir.", "Bilgi", MessageBoxButtons.OK);
                Con.Close();

                Application.Exit();
            }
        }

        private void BtnSeeProfile_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = SeeAccount;
            txtchangepassword.Text = "";
            txtchangepassword2.Text = "";
            txtexistpassword.Text = "";
            foreach (Control c in panel7.Controls)
            {
                c.Enabled = false;
            }

            BtnOkChange.Enabled = false;
            TxtNameSurname.Text = "";
            TxtUserName.Text = "";
            TxtEmail.Text = "";
            TxtTel.Text = "";
            TxtPassword.Text = "";
            TxtPassword2.Text = "";
            ComboxRole.Text = "";

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = ChangePassword;
            TxtNameSurname.Text = "";
            TxtUserName.Text = "";
            TxtEmail.Text = "";
            TxtTel.Text = "";
            TxtPassword.Text = "";
            TxtPassword2.Text = "";
            ComboxRole.Text = "";
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = AddUser;
            txtchangepassword.Text = "";
            txtchangepassword2.Text = "";
            txtexistpassword.Text = "";
            foreach (Control c in panel7.Controls)
            {
                c.Enabled = false;
            }
            BtnOkChange.Enabled = false;

        }

    }
}
