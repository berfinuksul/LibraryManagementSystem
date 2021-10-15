using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar.Value = startpoint;
            if(ProgressBar.Value ==100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            } 
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
