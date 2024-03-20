using MaterialSkin;
using MaterialSkin.Controls;
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

namespace Student_Management.FORMS.Account
{
    public partial class frm_Login : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Accent.Cyan700,
                TextShade.WHITE
                );
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public static bool isRemebered;
        private void frm_Login_Load(object sender, EventArgs e)
        {
            // For checkbox Remeber Me to save info for next login
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txt_Username.Text = Properties.Settings.Default.Username;
                txt_Password.Text = Properties.Settings.Default.Password;
            }
        }

        bool isCorrected = false;
        public static int loginLevel;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (cb_RemeberMe.Checked)
            {
                Properties.Settings.Default.Username = txt_Username.Text;
                Properties.Settings.Default.Password = txt_Password.Text;
                Properties.Settings.Default.Save();
            }
            AccountInfo get = new AccountInfo();
            string pass = MD5_Hash.Hash(txt_Password.Text);
            isCorrected = get.checkLogin(txt_Username.Text, pass);
            if (get.isBlocked)
            {
                frm_Main form = new frm_Main();
                form.showToast("ERROR", "Your account is blocked");
                return;
            }
            else if (isCorrected)
            {
                loginLevel = get.level;
                frm_Main form = new frm_Main();
                form.Show();
                this.Close();
            }
            else
            {
                frm_Main form = new frm_Main();
                form.showToast("ERROR", "Login Info is not corrected");
                return;
            }

        }

        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isCorrected == false)
            {
                Application.Exit();
            }
        }


    }
}
