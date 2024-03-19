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
        string _day, date, weekday;

        public ucDay()
        {
            InitializeComponent();
            lbl_Day.Text = "";
        }

        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            lbl_Day.Text = day;
            date = frm_Schedule._month + "/" + _day + "/" + frm_Schedule._year;
            ScheduleInfo get = new ScheduleInfo();
            get.getDateDetails(Convert.ToDateTime(date));
            lbl_Id.Text = get.id.ToString();
            lbl_Event.Text = get.course;
            this.BackColor = lbl_Event.Text != "" ? Color.FromArgb(255, 150, 79) : Color.White;
            if (Convert.ToDateTime(date) < DateTime.Today)
            {
                this.Enabled = false;
            }
        }

        public static bool blockClicked;
        private void dateBlock_click(object sender, EventArgs e)
        {
            Point buttonPosition = lbl_Day.PointToScreen(new Point(0, lbl_Day.Height));
            optionMenu.Show(buttonPosition);         
            if (lbl_Event.Text == "")
            {
                editToolStripMenuItem.Text = "Add New Event";
                deleteToolStripMenuItem.Visible = false;
                blockClicked = true;
            }
            else
            {
                editToolStripMenuItem.Text = "Edit";
                deleteToolStripMenuItem.Visible = true;
            }
        }

        public static bool view = false;
        public static string public_date;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            public_date = frm_Schedule._month + "/" + lbl_Day.Text + "/" + frm_Schedule._year;
            updatedTimer.Start();
            if (lbl_Event.Text != "")
            {
                view = true;
                frm_Event form = new frm_Event();
                form.ShowDialog();
            }
            else {
                frm_Event form = new frm_Event();
                form.ShowDialog();
            }
        }

        private void updatedTimer_Tick(object sender, EventArgs e)
        {
            if (frm_Event.isUpdate || frm_Event.refresh)
            {
                ScheduleInfo get = new ScheduleInfo();
                get.getDateDetails(Convert.ToDateTime(public_date));
                lbl_Id.Text = get.id.ToString();
                lbl_Event.Text = get.course;
                this.BackColor = lbl_Event.Text != "" ? Color.FromArgb(255, 150, 79) : Color.White;
                frm_Event.isUpdate = false;
                frm_Event.refresh = false;
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

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if(weekday == "Sun")
                {
                    lbl_Day.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    lbl_Day.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }catch(Exception) { }
        }

        private void ucDay_Load(object sender, EventArgs e)
        {
            sundays();
        }




    }
}
