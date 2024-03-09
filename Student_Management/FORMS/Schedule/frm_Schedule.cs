using Student_Management.FORMS;
using Student_Management.FORMS.Schedule;
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
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void ic_ToLeft_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
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
            showDays(_month, _year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanelSchedule.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbl_Month.Text = monthName.ToUpper() + " " + year;
            DateTime startoTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startoTheMonth.DayOfWeek.ToString("d")) + 1;
            for(int i = 1; i < week; i++)
            {
                ucDay uc = new ucDay("");
                flowLayoutPanelSchedule.Controls.Add(uc);
            }
            for(int i = 1; i < day; i++)
            {
                ucDay uc = new ucDay(i + "");
                flowLayoutPanelSchedule.Controls.Add(uc);
            }

        }
    }
}
