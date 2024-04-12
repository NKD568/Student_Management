 using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Student_Management.FORMS.Course;
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
        private void EventForm_Load(object sender, EventArgs e)
        {
            if (ucDay.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                dtp_Date.Enabled = false;
                txt_Class.Enabled = false;
                searchResult.Visible = false;
                lbl_MoveDate.Visible = true;
                btn_MoveDate.Visible = true;
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
                    dtp_Date.Value = getDefaultDate();
                }
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private DateTime getDefaultDate()
        {
            ScheduleInfo get = new ScheduleInfo();
            DateTime minDate = get.getMinDate();
            DateTime _date;
            if (minDate > DateTime.Today)
            {
                minDate = DateTime.Today;
            }
            else if (minDate == DateTime.Today)
            {
                minDate.AddDays(+1);
            }
            _date = minDate;
            while (get.checkOccupiedDate(_date))
            {
                _date = _date.AddDays(+1);
            }
            return _date;
        }

        string lastDate;
        private void btn_MoveDate_ToggledChanged()
        {
            dtp_Date.Enabled = !dtp_Date.Enabled;
            if(btn_MoveDate.Toggled == false)
            {
                if (!isVerified)
                {
                    dtp_Date.Text = lastDate;
                }
            }
            else
            {
                isVerified = false;
                lastDate = dtp_Date.Value.ToString();
            }
        }

        bool isVerified = false;
        public static bool changeDate = false;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Class.Text == "")
            {
                MessageBox.Show("Please type all informations!");
                return;
            }
            ScheduleInfo get = new ScheduleInfo();
            bool isValid = get.checkValidClass(txt_Class.Text);
            if (!isValid)
            {
                MessageBox.Show("Class must either Exist or Ongoing \n And has students!");
                return;
            }
            bool isDuplicate = get.checkDuplicateEvent(txt_Class.Text);
            if (isDuplicate && txt_Class.Text != ucDay.public_event)
            {
                MessageBox.Show("Duplicate Event! \n Only 1 Event in 1 Date");
                return;
            }
            if(update == true)
            {
                DateTime slected_date = Convert.ToDateTime(dtp_Date.Value);
                DateTime _publicDate = Convert.ToDateTime(ucDay.public_date);
                if (slected_date != _publicDate)
                {
                    changeDate = true;
                }
            }
            isVerified = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm_Main notify = new frm_Main();
            if (update == false)
            {
                ScheduleInfo save = new ScheduleInfo();
                DataTable dt = save.getEnrollmentIds(txt_Class.Text);
                foreach (DataRow row in dt.Rows)
                {
                    save.enrollment_id = row["id"].ToString();
                    save.date = Convert.ToDateTime(dtp_Date.Text);
                    save.type = cmb_Type.SelectedItem.ToString();
                    save.Save();
                }
                notify.showToast("SUCCESS", "Successfully Saved!");
                save.enrollment_info.getDetails(save.enrollment_id);
                ucDay.public_event = save.enrollment_info.class_info.name;
                refresh = true;
            }
            else
            {
                ScheduleInfo up = new ScheduleInfo();
                DataTable dt = up.getEnrollmentIds(txt_Class.Text);
                foreach (DataRow row in dt.Rows)
                {
                    up.enrollment_id = row["id"].ToString();
                    up.date = Convert.ToDateTime(dtp_Date.Text);
                    up.type = cmb_Type.SelectedItem.ToString();
                    up.update(up.enrollment_id, up.type, up.date);
                }
                notify.showToast("SUCCESS", "Successfully Updated!");
                isVerified = false;
                isUpdate = true;
            }
            this.Close();
        }

        private void getDetail()
        {
            ScheduleInfo get = new ScheduleInfo();
            get.getDetails(ucDay.public_id);
            txt_Class.Text = get.enrollment_info.class_info.name;
            dtp_Date.Value = get.date;
            cmb_Type.SelectedItem = get.type;
        }

        private void txt_Class_TextChanged(object sender, EventArgs e)
        {
            if (txt_Class.Text.Length > 4)
            {
                ScheduleInfo get = new ScheduleInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT DISTINCT classes.name FROM classes" +
                        " JOIN enrollments ON enrollments.class_id = classes.id" +
                        " WHERE classes.state = @state AND" +
                        " enrollments.id NOT IN (SELECT enrollment_id FROM schedules) AND";
                    sql += " classes.name LIKE @data";
                    searchResult.Columns[result.Name].DataPropertyName = "name";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@state", "Ongoing");
                    cmd.Parameters.AddWithValue("@data", txt_Class.Text + "%");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        searchResult.DataSource = dt;
                        searchResult.Height = searchResult.Rows.Count * 30;
                    }
                    else
                    {
                        searchResult.Height = 0;
                    }
                    cmd.Dispose();
                    da.Dispose();
                    conn.Close();
                }
            }
            else if (txt_Class.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResultCourName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            txt_Class.Text = row.Cells["result"].Value.ToString();
            searchResult.Height = 0;           
        }

        private void txt_Class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                 txt_Class.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Class_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }

        private void txt_Class_Leave(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }

        private DateTime selectedDate;
        private void dtp_Date_MouseEnter(object sender, EventArgs e)
        {
            selectedDate = dtp_Date.Value;
        }

        private void dtp_Date_CloseUp(object sender, EventArgs e)
        {
            ScheduleInfo get = new ScheduleInfo();     
            DateTime _date = Convert.ToDateTime(dtp_Date.Value);
            if (dtp_Date.Value < DateTime.Today)
            {
                MessageBox.Show("Please select a date that is not in the past!");
                dtp_Date.Value = selectedDate;
                return;
            }
            bool isOccupied = get.checkOccupiedDate(_date);
            if (update == true)
            {

                DateTime _publicDate = Convert.ToDateTime(ucDay.public_date);
                if (isOccupied && _date != _publicDate)
                {
                    MessageBox.Show("Selected Date is Occupied!");
                    dtp_Date.Value = selectedDate;
                    return;
                }
            }
            else
            {
                if (isOccupied)
                {
                    MessageBox.Show("Selected Date is Occupied!");
                    dtp_Date.Value = selectedDate;
                    return;
                }
            }
        }

        private void frm_Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucDay.blockClicked = false;
        }




    }
}
