using Student_Management.FORMS.Account;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS
{
    public partial class Toast_Message : Form
    {
        int toastX, toastY;
        public Toast_Message(string type, string message)
        {
            InitializeComponent();
            lbl_Type.Text = type;
            lbl_Message.Text = message;
            switch (type)
            {
                case "SUCCESS":
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picIcon.Image = Properties.Resources.ok_32;
                    break;
                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picIcon.Image = Properties.Resources.cancel_32;
                    break;
                case "INFO":
                    toastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Properties.Resources.info_32;
                    break;
                case "WARNING":
                    toastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    picIcon.Image = Properties.Resources.error_32;
                    break;
            }
        }

        private void Toast_Message_Load(object sender, EventArgs e)
        {
            this.Hide();
            Position();             
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if(toastY <= visibleY + 50)
            {
                this.Show();
                toastTimer.Stop();
                toastHide.Start();
            }
        }

        int y = 150;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if(y <= 0) {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if(toastY > 800)
                {
                    toastHide.Stop();
                    y = 150;
                    this.Close();
                }
            }
        }

        int visibleY;
        private void Position()
        {
            toastX = frm_Main.appBottomRightX - this.Width - 5;
            toastY = frm_Main.appBottomRightY - this.Height + 100;
            visibleY = frm_Main.appBottomRightY - this.Height + 5;
            this.Location = new Point(toastX, toastY);
            this.Show();
        }

    }
}
