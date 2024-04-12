using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course.Enrollment;
using Student_Management.FORMS.Enrollment;
using Student_Management.FORMS.Grade;
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
    public partial class ucEnrollment : UserControl
    {
        public ucEnrollment()
        {
            InitializeComponent();
        }

        private void ucEnrollment_Load(object sender, EventArgs e)
        {
            if (frm_SaveEnrollment.refresh == true)
            {
                displayNew();
            }
            switch (frm_Login.userLevel)
            {
                case 0:
                    editToolStripMenuItem.Visible = true;
                    deleteToolStripMenuItem.Visible = true; 
                    break;
                case 2:
                    editToolStripMenuItem.Visible = false;
                    deleteToolStripMenuItem.Visible = false;
                    break;
            }
            if (ClassPage.enableRecheckView)
            {
                viewGradesToolStripMenuItem.Text = "View Request";
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                ClassPage.enableRecheckView = false;
            }
            setLabel();
        }

        private void setLabel()
        {
            if (frm_Enrollment.isClassSide)
            {
                lbl_NameA.Text = "Name";
                lbl_NameB.Text = "Id";
                this.BackColor = Color.LightSteelBlue;
            }
            else
            {
                lbl_NameA.Text = "Class";
                lbl_NameB.Text = "State";
                this.BackColor = Color.FromArgb(140, 206, 255);
            }
        }

        public void searchResult()
        {
            EnrollmentInfo get = new EnrollmentInfo();
            if (frm_Enrollment.isClassSide)
            {
                get.searchClassSide(frm_Enrollment.searchKey);
            }
            else
            {
                get.searchStudentSide(frm_Enrollment.searchKey);
            }
        }

        public void cardDetails(EnrollmentInfo e)
        {
            setViewLevel(e);
        }

        private void setViewLevel(EnrollmentInfo details)
        {
            lbl_Id.Text = details.id;
            if (frm_Enrollment.isClassSide)
            {
                lbl_ContentA.Text = details.student_info.name;
                lbl_ContentB.Text = details.student_info.id.ToString();
            }
            else
            {
                lbl_ContentA.Text = details.class_info.name;
                lbl_ContentB.Text = details.class_info.state;
            }
        }

        public void displayNew()
        {
            EnrollmentInfo get = new EnrollmentInfo();
            if (frm_Enrollment.isClassSide)
            {
                get.getNewDataClassSide();
            }
            else
            {
                get.getNewDataStudentSide();
            }
            setViewLevel(get);
        }

        public static bool view = false;
        public static string public_id;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_id = lbl_Id.Text;
            frm_SaveEnrollment form = new frm_SaveEnrollment();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveEnrollment.isUpdate == true)
            {
                EnrollmentInfo get = new EnrollmentInfo();
                get.getDetails(public_id);
                setViewLevel(get);
                frm_SaveEnrollment.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            EnrollmentInfo get = new EnrollmentInfo();
            get.delete(lbl_Id.Text);
        }

        public static bool gradeChecking;
        private void viewGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassPage.enableRecheckView)
            {
                gradeChecking = true;
            }
            public_id = lbl_Id.Text;            
            Form background = new Form();
            try
            {
                using (frm_Grade frm = new frm_Grade())
                {
                    background.StartPosition = FormStartPosition.Manual;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .50d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;
                    background.Show();

                    frm.Owner = background;
                    frm.ShowDialog();
                    background.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                background.Dispose();
            }
        }


    }
}
