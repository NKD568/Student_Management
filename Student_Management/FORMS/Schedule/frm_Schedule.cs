using Student_Management.FORMS;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Schedule;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Management
{
    public partial class frm_Schedule : Form
    {
        public static int _year, _month;
        public frm_Schedule()
        {
            InitializeComponent();

        }

        private void frm_Schedule_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            btn_Add.Visible = frm_Login.userLevel == 2 ? false : true;
            dtp_SelectedDate.Value = DateTime.Now;
            showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
        }

        private void dtp_SelectedDate_ValueChanged(object sender, EventArgs e)
        {
            btn_Today.Enabled = (dtp_SelectedDate.Value.Month != DateTime.Now.Month) ? true : false;
            showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
        }

        private void showDays(int month, int year)
        {
            cardContainer.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbl_Month.Text = monthName.ToUpper() + " " + year;
            DateTime startoTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startoTheMonth.DayOfWeek.ToString("d")) + 1;
            // Get date from previous month in week
            for (int i = 1; i < week; i++)
            {
                ucDay uc = new ucDay();
                cardContainer.Controls.Add(uc);
            }
            // Get date from current month
            for (int i = 1; i <= day; i++)
            {
                ucDay uc = new ucDay();
                uc.dateDetails(i);
                cardContainer.Controls.Add(uc);
            }
        }

        private void ic_ToLeft_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            int _day = dtp_SelectedDate.Value.Day;
            dtp_SelectedDate.Value = new DateTime(_year, _month, _day);
            showDays(_month, _year);
        }

        private void ic_ToRight_Click(object sender, EventArgs e)
        {
            _month += 1;
            if(_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            int _day = dtp_SelectedDate.Value.Day;
            dtp_SelectedDate.Value = new DateTime(_year, _month, _day);
            showDays(_month, _year);
        }

        private void btn_Today_Click(object sender, EventArgs e)
        {
            dtp_SelectedDate.Value = DateTime.Now;
            showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveEvent.refresh == true)
            {
                showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
                frm_SaveEvent.refresh = false;
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucDay.isDeleted == true)
            {
                cardContainer.Controls.Clear();
                showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
                ucDay.isDeleted = false;
            }
        }

        private void updateInfoTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveCourse.isUpdate || frm_SaveStudent.isUpdate)
            {
                showDays(dtp_SelectedDate.Value.Month, dtp_SelectedDate.Value.Year);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveEvent frm = new frm_SaveEvent())
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
