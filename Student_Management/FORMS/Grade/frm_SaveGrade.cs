using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Main;
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

namespace Student_Management.FORMS.Grade
{
    public partial class frm_SaveGrade : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        public frm_SaveGrade()
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
        private void frm_SaveGrade_Load(object sender, EventArgs e)
        {
            if (ucGrade.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                setVisibleControls(true);
                txt_StudentId.Enabled = false;
                txt_CourseName.Enabled = false;
                cmb_Grade.Enabled = true;
                update = true;
                ucGrade.view = false;
            }
            else
            {
                GradeInfo get = new GradeInfo();
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                if (courCellClicked == false || stuCellClicked == false)
                {
                    MessageBox.Show("Please Verify your input!\n Course must exist or open \n Student can not join in same course");
                    return;
                }
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (update == false)
            {
                GradeInfo save = new GradeInfo();
                save.studentId = Convert.ToInt32(txt_StudentId.Text);
                save.getCourseId(txt_CourseName.Text.ToString());
                save.grade = getCmbGradeItemValue();
                save.Save();
                refresh = true;
                stuCellClicked = false;          
                resetControls();
            }
            else
            {
                GradeInfo up = new GradeInfo();
                up.update(ucGrade.publicId, getCmbGradeItemValue());
                isUpdate = true;
                if (frm_Grade.isReChecked)
                {
                    up.removeRecheck(ucGrade.publicId);
                    frm_Grade.isReChecked = false;
                }
            }
        }

        private void txt_CourseName_TextChanged(object sender, EventArgs e)
        {
            if (txt_CourseName.Text != lastCourInput)
            {
                courCellClicked = false;
            }
            if (txt_CourseName.Text.Length > 4 && ucGrade.view == false)
            {
                GradeInfo get = new GradeInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT Name FROM tbcourse WHERE isOpen = true AND";
                    sql += " Name LIKE @data";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_CourseName.Text + "%");
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
            else if (txt_CourseName.TextLength <= 0)
            {
                searchResultCourName.Height = 0;
                setVisibleControls(false);
                resetControls();
                txt_CourseState.Text = "";
            }
        }

        private void txt_StudentId_TextChanged(object sender, EventArgs e)
        {
            if (txt_StudentId.Text != lastStuInput)
            {
                stuCellClicked = false;
            }
            if (txt_StudentId.Text.Length > 4)
            {
                GradeInfo get = new GradeInfo();
                get.getCourseId(txt_CourseName.Text);
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT id FROM tbstudent WHERE id NOT IN (SELECT StudentId FROM tbgrade WHERE CourseId = '" + get.courseId + "') AND";
                    sql += " id LIKE @data";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_StudentId.Text + "%");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        searchResultStuId.DataSource = dt;
                        searchResultStuId.Height = searchResultStuId.Rows.Count * 40;
                    }
                    else
                    {
                        searchResultStuId.Height = 0;
                    }
                    cmd.Dispose();
                    da.Dispose();
                    conn.Close();
                }
            }
            else if (txt_StudentId.TextLength <= 0)
            {
                searchResultStuId.Height = 0;
            }

        }

        private void getDetail()
        {
            GradeInfo get = new GradeInfo();
            get.getDetails(ucGrade.publicId);
            txt_CourseName.Text = get.courseName;
            if(get.courseState == true)
            {
                txt_CourseState.Text = "Open";
            }
            else
            {
                txt_CourseState.Text = "Closed";
            }
            txt_StudentId.Text = get.studentId.ToString();
            txt_StudentName.Text = get.studentName;
            cmb_Grade.SelectedItem = get.grade;    
        }

        bool courCellClicked = false;
        string lastCourInput;
        private void searchResultCourName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResultCourName.Rows[e.RowIndex];
            txt_CourseName.Text = row.Cells["resultCourName"].Value.ToString();
            lastCourInput = txt_CourseName.Text;
            searchResultCourName.Height = 0;
            ucGrade u = new ucGrade();
            setVisibleControls(true);
            GradeInfo get = new GradeInfo();
            get.getCourseId(txt_CourseName.Text);
            get.getCourseState(get.courseId);
            txt_CourseState.Text = get.courseState.ToString();
            courCellClicked = true;
        }

        bool stuCellClicked = false;
        string lastStuInput;
        private void searchResultStuId_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResultStuId.Rows[e.RowIndex];
            txt_StudentId.Text = row.Cells["resultStuId"].Value.ToString();
            lastStuInput = txt_StudentId.Text;
            searchResultStuId.Height = 0;
            ucGrade u = new ucGrade();
            GradeInfo get = new GradeInfo();
            get.getStudentName(Convert.ToInt32(txt_StudentId.Text));
            txt_StudentName.Text = get.studentName;
            stuCellClicked = true;  
        }

        private void setVisibleControls(bool s)
        {
            txt_StudentId.Visible = s;
            txt_StudentName.Visible = s;
            cmb_Grade.Visible = s;
        }

        private void resetControls()
        {
            txt_StudentId.Text = "";
            txt_StudentName.Text = "";
            cmb_Grade.SelectedIndex = 0;
        }

        private void txt_NullCheck(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 0)
            {
                txt.Focus();
                MessageBox.Show("This field must not be empty!");
            }
        }

        private void txt_CourseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                 txt_CourseName.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                txt_StudentId.TextLength >=9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private string getCmbGradeItemValue()
        {
            string selectedItem = cmb_Grade.SelectedItem.ToString();
            string selectedValue = "";
            if (selectedItem == "None")
            {
                selectedValue = null;
            }
            else
            {
                selectedValue = selectedItem;
            }
            return selectedValue;
        }

 
    }
}
