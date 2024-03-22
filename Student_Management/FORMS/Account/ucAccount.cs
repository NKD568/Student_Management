using Student_Management.FORMS.Course;
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
    public partial class ucAccount : UserControl
    {
        public ucAccount()
        {
            InitializeComponent();
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            if (frm_SaveAccount.refresh == true)
            {
                displayNew();
            }
            deleteToolStripMenuItem.Visible = frm_Login.userLevel == 2 ? false : true;            
        }

        public void searchResult()
        {
            AccountInfo get = new AccountInfo();
            get.search(frm_Account.searchKey);
        }

        public void cardDetails(AccountInfo e)
        {
            lbl_Id.Text = e.id.ToString();
            lbl_Username.Text = e.username;
            txt_lblPassword.Text = e.password;
            lbl_Level.Text = e.level.ToString();
            setBlockedStateColor(e.isBlocked);
        }

        public void displayNew()
        {
            AccountInfo get = new AccountInfo();
            get.getNewInsertedData();
            lbl_Id.Text = get.id.ToString();
            lbl_Username.Text = get.username;
            txt_lblPassword.Text = get.password;
            lbl_Level.Text = get.level.ToString();
            setBlockedStateColor(get.isBlocked);
        }

        public static bool view = false;
        public static string public_id;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_id = lbl_Id.Text;
            frm_SaveAccount form = new frm_SaveAccount();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveAccount.isUpdate == true)
            {
                AccountInfo get = new AccountInfo();
                get.getDetails(public_id);
                lbl_Id.Text = get.id.ToString();
                lbl_Username.Text = get.username;
                txt_lblPassword.Text = get.password;
                lbl_Level.Text = get.level.ToString();
                setBlockedStateColor(get.isBlocked) ;
                frm_SaveAccount.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            AccountInfo get = new AccountInfo();
            get.delete(lbl_Id.Text);
        }

        private void setBlockedStateColor(bool state)
        {
            if(state == true)
            {
                this.borderPanel.BackColor = Color.Red;
            }
            else
            {
                this.borderPanel.BackColor = Color.Green;
            }
        }

    }
}
