using Student_Management.FORMS.Account;
using Student_Management.FORMS.Grade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Schedule
{ 

    public partial class ucDay : UserControl
    {
        public ucDay()
        {
            InitializeComponent();
        }

        DateTime _date;
        string weekday;
        public void dateDetails(int _day)
        {
            string date = frm_Schedule._month + "/" + _day + "/" + frm_Schedule._year;
            _date = Convert.ToDateTime(date);
            ScheduleInfo get = new ScheduleInfo();
            if(frm_Login.userLevel == 2)
            {
                get.getStudentDate(frm_Login.userName, _date);
            }
            else
            {
                get.getDateEvent(_date);
            }
            lbl_Day.Text = _date.Day.ToString();
            lbl_Event.Text = get.course;
        }

        private void sundays()
        {
            try
            {
                DateTime _day = _date;
                weekday = _day.ToString("ddd");
                if (weekday == "Sun")
                {
                    lbl_Day.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    lbl_Day.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception) { }
        }

        private void ucDay_Load(object sender, EventArgs e)
        {
            sundays();
            this.BackColor = lbl_Event.Text != "" ? Color.FromArgb(255, 150, 79) : Color.White;
            if(frm_Login.userLevel == 2)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = _date < DateTime.Today ? false : true;
            }
        }

        private void dateBlock_click(object sender, EventArgs e)
        {
            Point buttonPosition = lbl_Day.PointToScreen(new Point(0, lbl_Day.Height));
            optionMenu.Show(buttonPosition);         
            if (lbl_Event.Text == "")
            {
                editToolStripMenuItem.Text = "Add New Event";
                deleteToolStripMenuItem.Visible = false;
            }
            else
            {
                editToolStripMenuItem.Text = "Edit";
                deleteToolStripMenuItem.Visible = true;
            }
        }

        public static bool view = false;
        public static string public_date;
        public static string public_oldCourseSaved;
        public static bool blockClicked;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blockClicked = true;
            public_date = frm_Schedule._month + "/" + lbl_Day.Text + "/" + frm_Schedule._year;
            if (lbl_Event.Text != "")
            {
                public_oldCourseSaved = lbl_Event.Text;
                view = true;
                updatedTimer.Start();
            }
            else
            {
                view = false;
            }
            frm_SaveEvent form = new frm_SaveEvent();
            form.ShowDialog();
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveEvent.isUpdate)
            {
                ScheduleInfo get = new ScheduleInfo();
                DateTime _date = Convert.ToDateTime(public_date);
                DataTable dt = get.getDateDetails(_date);               
                DataRow firstRow = dt.Rows[0];
                lbl_Event.Text = firstRow["Course"].ToString();
                this.BackColor = lbl_Event.Text != "" ? Color.FromArgb(255, 150, 79) : Color.White;
                frm_SaveEvent.isUpdate = false;
            }
        }

        public static bool isDeleted = false;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            public_date = frm_Schedule._month + "/" + lbl_Day.Text + "/" + frm_Schedule._year;
            isDeleted = true;
            ScheduleInfo get = new ScheduleInfo();
            get.delete(Convert.ToDateTime(public_date));
        }


    }
}
