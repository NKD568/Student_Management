using Student_Management.FORMS.Account;
using Student_Management.FORMS.Grade;
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

namespace Student_Management.FORMS.Student
{
    public partial class ucStudent : UserControl
    {
        public ucStudent()
        {
            InitializeComponent();
        }

        private void ucStudent_Load(object sender, EventArgs e)
        {
            if (frm_SaveStudent.refresh == true)
            {
                displayNew();
            }
            deleteToolStripMenuItem.Visible = frm_Login.userLevel == 2 ? false : true;
        }

        public void searchResult()
        {
            StudentInfo get = new StudentInfo();
            get.search(frm_Student.searchKey);
        }

        public void cardDetails(StudentInfo e)
        {
            lbl_Id.Text = e.id.ToString();
            lbl_Name.Text = e.name;
            dtp_Birthdate.Value = e.birthdate;
            lbl_Email.Text = e.email;
        }

        public void displayNew()
        {
            StudentInfo get = new StudentInfo();
            get.getNewInsertedData();
            lbl_Id.Text = get.id.ToString();
            lbl_Name.Text = get.name;
            dtp_Birthdate.Value = get.birthdate;
            lbl_Email.Text = get.email;
        }
        public static bool view = false;
        public static string public_id;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_id = lbl_Id.Text;
            frm_SaveStudent form = new frm_SaveStudent();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveStudent.isUpdate == true)
            {
                StudentInfo get = new StudentInfo();
                get.getDetails(public_id);
                lbl_Id.Text = get.id.ToString();
                lbl_Name.Text = get.name;
                dtp_Birthdate.Value = get.birthdate;
                lbl_Email.Text = get.email;
                frm_SaveStudent.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            StudentInfo get = new StudentInfo();
            get.delete(lbl_Id.Text);
        }


    }
}
