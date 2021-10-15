using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LibraryManagementSystem
{ 
    public partial class FormMenu : Form
    {
        connect baglanti = new connect();

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
         
        //Constructor
        public FormMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,45);
            panelMenu.Controls.Add(leftBorderBtn);
            //FormMenu Settings
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            BtnCloseChildForm.Visible = false; 
        }

        //Color Change
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(102, 140, 255);
        }  

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68); 
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;    
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconChildForm.IconChar = currentBtn.IconChar;
                iconChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(56, 45, 114);
                currentBtn.ForeColor = Color.FromArgb(229, 204, 244);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(229, 204, 244);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = currentBtn.Text;
            lblTitleChildForm.ForeColor = Color.FromArgb(102, 140, 255);

        }

        private void CloseChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormDashboard());
           
            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnBorrowers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormBorrowers());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormBooks());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnPullOutBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormCatalog());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnAddCopy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormIssued());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormReturn());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void BtnUserAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormUserAccount());

            //For Closing Child Form
            BtnCloseChildForm.Visible = true;
            BtnCloseChildForm.BringToFront();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconChildForm.IconChar = IconChar.Home;
            iconChildForm.IconColor = Color.FromArgb(229, 204, 244);
            lblTitleChildForm.Text = "Anasayfa";
            lblTitleChildForm.ForeColor = Color.FromArgb(229, 204, 244);
            BtnCloseChildForm.Visible = false;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize Form
        private void BtnFormMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizelForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            CloseChildForm();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblusername.Text = FormLogin.username;
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();

            FormLogin lg = new FormLogin();
            lblusername.Text = FormLogin.username;

            string query = "select UserNameSurname from Tbl_User where username='" + FormLogin.username + "'";
            SqlConnection con = new SqlConnection(baglanti.Adres);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            lblusername.Text = ds.Tables[0].Rows[0][0].ToString();

        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = BtnSignOut.Text;
            lblTitleChildForm.ForeColor = Color.FromArgb(102, 140, 255);

            if (MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                FormLogin login = new FormLogin();
                login.Show();
            }

            else
            {
                CloseChildForm();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

    }
}
