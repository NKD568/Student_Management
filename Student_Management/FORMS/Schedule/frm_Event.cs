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
    public partial class frm_Event : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_Event()
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
                ScheduleInfo save = new ScheduleInfo();
                DataTable dt = save.getGradeIds(txt_Course.Text);
                foreach (DataRow row in dt.Rows)
                {
                    save.gradeId = Convert.ToInt32(row["id"]);
                    save.date = Convert.ToDateTime(dtp_Date.Text);
                    save.Save();
                }
                refresh = true;
                frm_Main get = new frm_Main();
                get.showToast("SUCCESS", "Successfully Saved");
            }
            else
            {
                ScheduleInfo up = new ScheduleInfo();
                DataTable dt = up.getGradeIds(txt_Course.Text);
                foreach (DataRow row in dt.Rows)
                {
                    up.gradeId = Convert.ToInt32(row["id"]);
                    up.date = Convert.ToDateTime(dtp_Date.Text);
                    up.update(up.gradeId, up.date);
                }
                isUpdate = true;
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
            get.getDateDetails(Convert.ToDateTime(ucDay.public_date));
            dtp_Date.Text = get.date.ToString();
            txt_Course.Text = get.course;
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
                    string sql = "SELECT tbcourse.Name FROM tbcourse WHERE isOpen = true AND" +
                        " id IN (SELECT CourseId FROM tbgrade WHERE Grade IS NULL AND id NOT IN (SELECT GradeId FROM tbschedule)) AND";
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
