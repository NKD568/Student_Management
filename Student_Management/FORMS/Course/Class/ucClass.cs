using Student_Management.FORMS.Account;
using Student_Management.FORMS.Enrollment;
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
    public partial class ucClass : UserControl
    {
        public ucClass()
        {
            InitializeComponent();
        }
        private void ucClassCard_Load(object sender, EventArgs e)
        {
            if (frm_SaveClass.refresh == true)
            {
                displayNew();
            }
            btn_Options.Visible = frm_Login.userLevel == 2 ? false : true;
            if (ClassPage.enableRecheckView)
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        public void searchResult()
        {
            ClassInfo get = new ClassInfo();
            get.search(ClassPage.searchKey);
        }

        public void cardDetails(ClassInfo e)
        {
            lbl_Id.Text = e.id.ToString();
            e.getCourseName(e.course_id);
            lbl_Name.Text = e.name;
            lbl_Course.Text = e.course_name;
            lbl_Capacity.Text = e.capacity.ToString();
            lbl_State.Text = e.state;
        }

        public void displayNew()
        {
            ClassInfo get = new ClassInfo();
            get.getNewInsertedData();
            lbl_Id.Text = get.id.ToString();
            lbl_Name.Text = get.name;
            get.getCourseName(get.course_id);
            lbl_Course.Text = get.course_name;
            lbl_Capacity.Text = get.capacity.ToString();
            lbl_State.Text = get.state;
        }

        public static bool view = false;
        public static string public_id;
        public static string public_name;
        public static string public_state;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedTimer.Start();
            view = true;
            public_id = lbl_Id.Text;
            public_name = lbl_Name.Text;
            frm_SaveClass form = new frm_SaveClass();
            form.ShowDialog();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Point buttonPosition = btn_Options.PointToScreen(new Point(0, btn_Options.Height));
            optionMenu.Show(buttonPosition);
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveClass.isUpdate == true)
            {
                ClassInfo get = new ClassInfo();
                get.getDetails(public_id);
                lbl_Id.Text = get.id.ToString();
                lbl_Name.Text = get.name;
                get.getCourseName(get.course_id);
                lbl_Course.Text = get.course_name;
                lbl_Capacity.Text = get.capacity.ToString();
                lbl_State.Text = get.state;
                frm_SaveClass.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            ClassInfo get = new ClassInfo();
            get.delete(lbl_Id.Text);
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            public_id = lbl_Id.Text;
            public_state = lbl_State.Text;
            frm_Enrollment.isClassSide = true;
            Form background = new Form();
            try
            {
                using (frm_Enrollment frm = new frm_Enrollment())
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
