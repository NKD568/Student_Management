using Student_Management.FORMS.Account;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Course
{
    public partial class ucCourse : UserControl
    {
        public ucCourse()
        {
            InitializeComponent();
        }

        private void ucCourse_Load(object sender, EventArgs e)
        {
            if (frm_SaveCourse.refresh == true)
            {
                displayNew();
            }
            btn_Options.Visible = frm_Login.userLevel == 2 ? false : true;
        }

        public void searchResult()
        {
            CourseInfo get = new CourseInfo();
            get.search(frm_Course.searchKey);
        }

        public void cardDetails(CourseInfo e)
        {
            lbl_Id.Text = e.id.ToString();
            lbl_Name.Text = e.name;
            lbl_Description.Text = e.description;
            lbl_Credits.Text = e.credits.ToString();
            lbl_isOpen.Text = e.isOpen.ToString();
        }

        public void displayNew()
        {
            CourseInfo get = new CourseInfo();
            get.getNewInsertedData();
            lbl_Id.Text = get.id.ToString();
            lbl_Name.Text = get.name;
            lbl_Description.Text = get.description;
            lbl_Credits.Text = get.credits.ToString();
            lbl_isOpen.Text = get.isOpen.ToString();
        }
        public static bool view = false;
        public static string public_id;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_id = lbl_Id.Text;
            frm_SaveCourse form = new frm_SaveCourse();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveCourse.isUpdate == true)
            {
                CourseInfo get = new CourseInfo();
                get.getDetails(public_id);
                lbl_Id.Text = get.id.ToString();
                lbl_Name.Text = get.name;
                lbl_Description.Text = get.description;
                lbl_Credits.Text = get.credits.ToString();
                lbl_isOpen.Text = get.isOpen.ToString();
                frm_SaveCourse.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            CourseInfo get = new CourseInfo();
            get.delete(lbl_Id.Text);
        }


    }
}
