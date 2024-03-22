using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Account
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            progressBar.Width = 47;
        }


        private void timerShow_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;
            if (progressBar.Width >= 599)
            {
                timerShow.Stop();
                frm_Login login = new frm_Login();
                login.Show();
                this.Hide();
            }
        }


    }
}

