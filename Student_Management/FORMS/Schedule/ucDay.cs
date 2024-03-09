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

        private void panel1_Click(object sender, EventArgs e)
        {
            if(checkBoxDay.Checked == false)
            {
                checkBoxDay.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBoxDay.Checked = false;
                this.BackColor = Color.White;
            }
        }

        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            lbl_Day.Text = day;
            checkBoxDay.Hide();
            date = frm_Schedule._month + "/" + _day + "/" + frm_Schedule._year;
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
