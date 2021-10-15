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
    public partial class FormBorrowers : Form
    {
        connect baglanti = new connect();
        SqlConnection Con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlCommandBuilder builder;

        public FormBorrowers()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNameSurname.Text) ||
                (string.IsNullOrWhiteSpace(TxtTC.Text)) || (string.IsNullOrWhiteSpace(TxtEmail.Text)) ||
                (string.IsNullOrWhiteSpace(TxtTel.Text)) || (string.IsNullOrWhiteSpace(ComboxGender.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtTC.TextLength < 11)
            {
                MessageBox.Show("Tc kimlik numarası 11 haneli olmalıdır..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TxtTel.TextLength < 10)
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalılır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("Mail adresinizi hatalı yazdınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "insert into Tbl_Member values('" + TxtNameSurname.Text + "','" + TxtTC.Text + "','" + TxtAdress.Text + "','" + TxtTel.Text + "','" + ComboxGender.SelectedItem.ToString() + "','" + TxtEmail.Text + "')";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            TxtNameSurname.Clear();
            TxtTC.Clear();
            ComboxGender.SelectedIndex = -1;
            TxtTel.Clear();
            TxtTel.Clear();
            TxtAdress.Clear();
            TxtEmail.Clear();
        }

        private void TxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtTCSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void populate()
        {
            Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Tbl_Member";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridMember.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FormBorrowers_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtTCSearch.Text != "")
            {
                Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Tbl_Member where MemberTC = " + TxtTCSearch.Text + "";
                sda = new SqlDataAdapter(query, Con);
                builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridMember.DataSource = ds.Tables[0];
                Con.Close();
            }

            else
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtTCSearch.Text == "")
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (string.IsNullOrWhiteSpace(TxtNameSurname.Text) ||
                    (string.IsNullOrWhiteSpace(TxtTC.Text)) || (string.IsNullOrWhiteSpace(TxtEmail.Text)) ||
                    (string.IsNullOrWhiteSpace(TxtTel.Text)) || (string.IsNullOrWhiteSpace(ComboxGender.Text)))
                {
                    TxtNameSurname.Text = DataGridMember.CurrentRow.Cells["MemberNameSurname"].Value.ToString();
                    TxtTC.Text = DataGridMember.CurrentRow.Cells["MemberTC"].Value.ToString();
                    TxtAdress.Text = DataGridMember.CurrentRow.Cells["Adress"].Value.ToString();
                    TxtTel.Text = DataGridMember.CurrentRow.Cells["MemberTel"].Value.ToString();
                    TxtEmail.Text = DataGridMember.CurrentRow.Cells["MemberEmail"].Value.ToString();
                    ComboxGender.Text = DataGridMember.CurrentRow.Cells["MemberGender"].Value.ToString();

                    BtnUpdate2.BringToFront();
                    BtnSave.Visible = false;
                }

                else
                {
                    try
                    {
                        Con = new SqlConnection(baglanti.Adres);
                        Con.Open();
                        string query = "UPDATE Tbl_Member SET MemberNameSurname='" + TxtNameSurname.Text + "', MemberTC='" + TxtTC.Text + "', Adress='" + TxtAdress.Text + "', MemberTel='" + TxtTel.Text + "', MemberGender='" + ComboxGender.SelectedItem.ToString() + "', MemberEmail='" + TxtEmail.Text + "' WHERE MemberTC=" + TxtTCSearch.Text + "";
                        cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Üye başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
                        Con.Close();
                        populate();
                        ClearTextBoxes();
                        TxtTCSearch.Clear();
                        BtnUpdate2.SendToBack();
                        BtnSave.Visible = true;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtTCSearch.Text == "")
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        Con = new SqlConnection(baglanti.Adres);
                        Con.Open();
                        string query = "DELETE FROM Tbl_Member where MemberTC=" + TxtTCSearch.Text + "";
                        cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Üye başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
                        Con.Close();
                        populate();
                        TxtTCSearch.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    TxtTCSearch.Clear();
                    populate();
                }
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            populate();
            TxtTCSearch.Clear();
        }

        private void BtnUpdate2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtNameSurname.Text) ||
               (string.IsNullOrWhiteSpace(TxtTC.Text)) || (string.IsNullOrWhiteSpace(TxtEmail.Text)) ||
               (string.IsNullOrWhiteSpace(TxtTel.Text)) || (string.IsNullOrWhiteSpace(ComboxGender.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "UPDATE Tbl_Member SET MemberNameSurname='" + TxtNameSurname.Text + "', MemberTC='" + TxtTC.Text + "', Adress='" + TxtAdress.Text + "', MemberTel='" + TxtTel.Text + "', MemberGender='" + ComboxGender.SelectedItem.ToString() + "', MemberEmail='" + TxtEmail.Text + "' WHERE MemberTC=" + TxtTCSearch.Text + "";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                    ClearTextBoxes();
                    TxtTCSearch.Clear();
                    BtnUpdate2.SendToBack();
                    BtnSave.Visible = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

    }
}
