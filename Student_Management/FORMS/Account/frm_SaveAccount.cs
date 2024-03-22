using MaterialSkin;
using MaterialSkin.Controls;
using Student_Management.FORMS.Course;
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
    public partial class frm_SaveAccount : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_SaveAccount()
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

        public static bool refresh = false;
        public static bool isUpdate = false;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (update == false)
            {
                AccountInfo save = new AccountInfo();
                save.username = txt_Username.Text;
                save.password= MD5_Hash.Hash(txt_Password.Text.Trim());
                save.level = Convert.ToInt32(cmb_Level.SelectedItem);
                save.isBlocked = getCmbIsBlockedItemValue();
                save.Save();
            }
            else
            {
                AccountInfo up = new AccountInfo();
                string pass = txt_Password.Text == string.Empty? lastSavedPass : MD5_Hash.Hash(txt_Password.Text.Trim());
                up.update(txt_Username.Text, pass, Convert.ToInt32(cmb_Level.SelectedItem), getCmbIsBlockedItemValue(), ucAccount.public_id);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "" && cb_RestPass.Checked)
            {
                MessageBox.Show("Please type all informations!");
                return;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        bool update = false;
        private void frm_SaveAccount_Load(object sender, EventArgs e)
        {
            if (ucAccount.view == true)
            {
                checkUserLevel();
                getDetail();
                btn_Save.Text = "UPDATE";
                update = true;
                txt_Password.Hint = "New Password";
                txt_Password.Enabled = false;
                cb_RestPass.Visible = true;
                ucAccount.view = false;
            }
            else
            {
                btn_Save.Text = "SAVE";
                txt_Password.Hint = "Password";
                txt_Password.Enabled = true;
                cb_RestPass.Visible = false;
                update = false;
            }
        }

        private void checkUserLevel()
        {
            if (frm_Login.userLevel == 2)
            {
                txt_Username.Enabled = false;
                cmb_isBlocked.Enabled = false;
                cmb_Level.Enabled = false;
            }
            else
            {
                txt_Username.Enabled = true;
                cmb_isBlocked.Enabled = true;
                cmb_Level.Enabled = true;
            }
        }

        string lastSavedPass;
        private void getDetail()
        {
            AccountInfo get = new AccountInfo();
            get.getDetails(ucAccount.public_id);
            txt_Username.Text = get.username;
            txt_Password.Text = "";
            lastSavedPass = get.password;
            // Modify later if more levels are added
            cmb_Level.SelectedItem = get.level == 2 ? "2" : "0";
            cmb_isBlocked.SelectedItem = get.isBlocked == false ? "False" : "True";
        }

        private void txt_NullCheck(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(cb_RestPass.Checked == true)
            {
                
            }
            else
            {
                if (txt.Text.Length == 0)
                {
                    txt.Focus();
                    MessageBox.Show("This field must not be empty!");
                    return;
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.TextLength >= 50 && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private bool getCmbIsBlockedItemValue()
        {
            string selectedItem = cmb_isBlocked.SelectedItem.ToString();
            bool selectedBoolValue = false;
            if (selectedItem == "True")
            {
                selectedBoolValue = true;
            }
            else if (selectedItem == "False")
            {
                selectedBoolValue = false;
            }
            return selectedBoolValue;
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_showPass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void cb_RestPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RestPass.Checked == true)
            {
                txt_Password.Text = "";
                txt_Password.Enabled = true;
            }
            else
            {
                txt_Password.Text = "";
                txt_Password.Enabled = false;
            }
        }


    }
}
