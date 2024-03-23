 using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
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
    public partial class frm_SaveEvent : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_SaveEvent()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Accent.Cyan700,
                TextShade.WHITE
                );
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public static bool refresh = false;
        public static bool isUpdate = false;

        bool update = false;
        bool isGetDefaultDate = false;
        private void EventForm_Load(object sender, EventArgs e)
        {
            if (ucDay.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                dtp_Date.Enabled = false;
                update = true;
                ucDay.view = false;
            }
            else
            {
                if (ucDay.blockClicked == true)
                {
                    dtp_Date.Enabled = false;
                    dtp_Date.Text = ucDay.public_date;
                }
                else
                {
                    isGetDefaultDate = true;
                    dtp_Date.Value = getDefaultDate();
                    isGetDefaultDate = false;
                }
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Course.Text == "" || courCellClicked == false)
            {
                MessageBox.Show("Please Verify your input!\n Course must open and has students");
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (update == false)
            {
                setCourseSchedule();
                refresh = true;
                this.Close();
            }
            else
            {
                updateCourseSchedule();
                isUpdate = true;
                this.Close();
            }
        }

        private void setCourseSchedule()
        {
            frm_Main notify = new frm_Main();
            ScheduleInfo save = new ScheduleInfo();
            DataTable dt = save.getGradeIds(txt_Course.Text);
            foreach (DataRow row in dt.Rows)
            {
                save.gradeId = Convert.ToInt32(row["id"]);
                save.date = Convert.ToDateTime(dtp_Date.Text);
                save.Save();
            }
            notify.showToast("SUCCESS", "Successfully Saved");
        }

        private void updateCourseSchedule()
        {
            frm_Main notify = new frm_Main();
            ScheduleInfo up = new ScheduleInfo();
            DataTable dtIsUpdated = up.getEventDetails(ucDay.public_oldCourseSaved);
            DataTable dtDataUpdate = up.getGradeIds(txt_Course.Text);
            int rowDifference = dtIsUpdated.Rows.Count - dtDataUpdate.Rows.Count;
            DateTime _date = Convert.ToDateTime(ucDay.public_date);
            if (rowDifference == 0)
            {
                int i = 0;
                foreach (DataRow row in dtDataUpdate.Rows)
                {
                    DataRow r = dtIsUpdated.Rows[i];
                    up.id = Convert.ToInt32(r["id"]);
                    int _gradeId = Convert.ToInt32(row["id"]);
                    up.update(up.id ,_gradeId, _date);
                    i++;
                }
                notify.showToast("SUCCESS", "Successfully Updated");
            }
            //else if (rowDifference < 0)
            //{
            //    int i = 0;
            //    foreach (DataRow row in dtIsUpdated.Rows)
            //    {
            //        up.id = Convert.ToInt32(row["id"]);
            //        DataRow r = dtDataUpdate.Rows[i];
            //        int _gradeId = Convert.ToInt32(r["id"]);
            //        up.update(up.id, _gradeId, _date);
            //        i++;
            //    }
            //    while (i < dtDataUpdate.Rows.Count)
            //    {
            //        DataRow row = dtDataUpdate.Rows[i];
            //        up.gradeId = Convert.ToInt32(row["id"]);
            //        up.date = _date;
            //        up.Save();
            //        i++;
            //    }
            //    notify.showToast("SUCCESS", "Successfully Updated");
            //}
            else
            {
                notify.showToast("ERROR", "Not all Students in new Course");
                return;
            }
        }

        private DateTime getDefaultDate()
        {
            dtp_Date.Enabled = true;
            ScheduleInfo get = new ScheduleInfo();
            DateTime minDate = get.getMinDate();
            DateTime _date;
            if(minDate > DateTime.Now)
            {
                minDate = DateTime.Now;
            }
            else if(minDate == DateTime.Now)
            {
                minDate.AddDays(+1);
            }
            _date = minDate;
            while (get.checkDateExisted(_date))
            {
                _date = _date.AddDays(+1);
            }
            return _date;
        }

        private void getDetail()
        {
            ScheduleInfo get = new ScheduleInfo();
            DateTime _date = Convert.ToDateTime(ucDay.public_date);
            DataTable dt = get.getDateDetails(_date);
            DataRow firstRow = dt.Rows[0];           
            dtp_Date.Text = ucDay.public_date;
            txt_Course.Text = firstRow["Course"].ToString();
        }

        private void txt_Course_TextChanged(object sender, EventArgs e)
        {
            if (txt_Course.Text != lastCourInput)
            {
                courCellClicked = false;
            }
            if (txt_Course.Text.Length > 4)
            {
                ScheduleInfo get = new ScheduleInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT DISTINCT tbcourse.Name FROM tbcourse" +
                        " JOIN tbgrade ON tbgrade.CourseId = tbcourse.id" +
                        " WHERE tbgrade.Grade IS NULL AND tbcourse.isOpen = true" +
                        " AND tbgrade.id NOT IN (SELECT GradeId FROM tbschedule) AND";
                    sql += " tbcourse.Name LIKE @data";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_Course.Text + "%");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        searchResultCourName.DataSource = dt;
                        searchResultCourName.Height = searchResultCourName.Rows.Count * 40;
                    }
                    else
                    {
                        searchResultCourName.Height = 0;
                    }
                    cmd.Dispose();
                    da.Dispose();
                    conn.Close();
                }
            }
            else if (txt_Course.TextLength <= 0)
            {
                searchResultCourName.Height = 0;
            }
        }

        bool courCellClicked = false;
        string lastCourInput;
        private void searchResultCourName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResultCourName.Rows[e.RowIndex];
            txt_Course.Text = row.Cells["resultCourName"].Value.ToString();
            lastCourInput = txt_Course.Text;
            searchResultCourName.Height = 0;           
            courCellClicked = true;
        }

        private void txt_Course_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                 txt_Course.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private DateTime selectedDate;
        private void dtp_Date_MouseEnter(object sender, EventArgs e)
        {
            selectedDate = dtp_Date.Value;
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            if (ucDay.blockClicked == false && isGetDefaultDate == false)
            {
                ScheduleInfo get = new ScheduleInfo();
                if (dtp_Date.Value < DateTime.Today || get.checkDateExisted(dtp_Date.Value) == false)
                {
                    // Your logic here, e.g., display an error message or prevent future selection
                    MessageBox.Show("Please select a date that is not in the past \nOr already occupied by others.");
                    // Optionally, set the datepicker value to the current date:
                    dtp_Date.Value = selectedDate;
                }
            }
        }

        private void frm_Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucDay.blockClicked = false;
        }


    }
}
