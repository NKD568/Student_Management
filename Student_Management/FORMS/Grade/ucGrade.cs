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

namespace Student_Management.FORMS.Grade
{
    public partial class ucGrade : UserControl
    {
        public ucGrade()
        {
            InitializeComponent();
        }

        private void ucCourse_Load(object sender, EventArgs e)
        {
            if (frm_SaveGrade.refresh == true)
            {
                displayNew();
            }
        }

        public void searchResult()
        {
            GradeInfo get = new GradeInfo();
            get.search(frm_Grade.searchKey);
        }

        public void cardDetails(GradeInfo e)
        {
            lbl_CourseId.Text = e.courseId.ToString();
            lbl_StuId.Text = e.studentId.ToString();
            lbl_StuName.Text = e.studentName.ToString();
            lbl_Course.Text = e.courseName;
            lbl_Grade.Text = e.grade;
        }

        public void displayNew()
        {
            GradeInfo get = new GradeInfo();
            get.getNewInsertedData();
            lbl_CourseId.Text = get.courseId.ToString();
            lbl_StuId.Text = get.studentId.ToString();
            lbl_StuName.Text = get.studentName.ToString();
            lbl_Course.Text = get.courseName;
            lbl_Grade.Text = get.grade;
        }

        public static bool view = false;
        public static int public_studentId;
        public static int public_courseId;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_studentId = Convert.ToInt32(lbl_StuId.Text);
            public_courseId = Convert.ToInt32(lbl_CourseId.Text);
            frm_SaveGrade form = new frm_SaveGrade();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveGrade.isUpdate == true)
            {
                GradeInfo get = new GradeInfo();
                get.getDetails(public_studentId, public_courseId);
                lbl_CourseId.Text = get.courseId.ToString();
                lbl_StuId.Text = get.studentId.ToString();
                lbl_Course.Text = get.courseName;
                lbl_Grade.Text = get.grade;
                frm_SaveGrade.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            GradeInfo get = new GradeInfo();
            get.delete(lbl_StuId.Text ,lbl_CourseId.Text);
        }


    }
}
