﻿using MaterialSkin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public static int frmBottomRightX;
        public static int frmBottomRightY;
        private void frm_Login_Load(object sender, EventArgs e)
        {
            frmBottomRightX = this.Location.X + this.Size.Width;
            frmBottomRightY = this.Location.Y + this.Size.Height;
            // For checkbox Remeber Me to save info for next login
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txt_Username.Text = Properties.Settings.Default.Username;
                txt_Password.Text = Properties.Settings.Default.Password;
            }
        }

        bool isCorrected = false;
        public static int userLevel;
        public static string userName;
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
                MessageBox.Show("Your account is blocked");
                return;
            }
            else if (isCorrected)
            {
                userLevel = get.level;
                userName = get.username;
                frm_Main form = new frm_Main();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Info is not corrected");
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
