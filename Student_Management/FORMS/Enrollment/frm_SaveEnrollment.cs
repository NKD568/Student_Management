using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Enrollment;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Student_Management.FORMS.Course.Enrollment
{
    public partial class frm_SaveEnrollment : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_SaveEnrollment()
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
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm_Main notify = new frm_Main();
            if (update == false)
            {
                EnrollmentInfo save = new EnrollmentInfo();
                if (frm_Enrollment.isClassSide)
                {
                    save.class_id = ucClass.public_id;
                    save.student_id = txt_ContentA.Text;
                }
                else
                {
                    save.class_info = new ClassInfo();
                    save.class_info.getClassId(txt_ContentA.Text);
                    save.class_id = save.class_info.id;
                    save.student_id = ucStudent.public_id;
                }
                save.Save();
                refresh = true;
                notify.showToast("SUCESS", "Sucessfully Saved");
            }
            else
            {
                EnrollmentInfo up = new EnrollmentInfo();
                if (frm_Enrollment.isClassSide)
                {
                    up.class_id = ucClass.public_id;
                    up.student_id = txt_ContentA.Text;
                    up.updateClassSide(up.student_id, ucEnrollment.public_id);
                }
                else
                {
                    up.class_info = new ClassInfo();
                    up.class_info.getClassId(txt_ContentA.Text);
                    up.class_id = up.class_info.id;
                    up.student_id = ucStudent.public_id;
                    up.updateStudentSide(up.class_id, ucEnrollment.public_id);
                }
                isUpdate = true;
                notify.showToast("SUCESS", "Sucessfully Updated");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_ContentA.Text == "")
            {
                MessageBox.Show("Please type in valid info!");
                return;
            }
            else
            {
                EnrollmentInfo get = new EnrollmentInfo();
                if (frm_Enrollment.isClassSide)
                {
                    bool inClass = get.checkStudentInClass(txt_ContentA.Text);
                    StudentInfo exist = new StudentInfo();
                    exist.getDetails(txt_ContentA.Text);
                    if (inClass || exist.name == String.Empty)
                    {
                        MessageBox.Show("Student must either have not in Class or Exist!");
                        return;
                    }
                }
                else
                {
                    get.class_info = new ClassInfo();
                    get.class_info.getClassId(txt_ContentA.Text);
                    bool inClass = get.checkEnrolledClass(get.class_info.id);
                    ClassInfo exist = new ClassInfo();
                    exist.getDetails(txt_ContentA.Text);
                    if (inClass || exist.id == String.Empty)
                    {
                        MessageBox.Show("Student already in Class or Class not exist!");
                        return;
                    }
                }
            }
            backgroundWorker1.RunWorkerAsync();
        }

        bool update = false;
        private void frm_SaveEnrollment_Load(object sender, EventArgs e)
        {
            if (frm_Enrollment.isClassSide == false) setViewStudentSide();
            if (ucEnrollment.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                update = true;
                ucEnrollment.view = false;
            }
            else
            {
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void setViewStudentSide()
        {
            txt_ContentA.Hint = "Class Name";
            txt_ContentB.Hint = "Capacity";
            txt_ContentC.Hint = "State";
            lbl_Birhdate.Visible = false;
            dtpStuBirthdate.Visible = false;
        }

        private void getDetail()
        {
            EnrollmentInfo get = new EnrollmentInfo();
            get.getDetails(ucEnrollment.public_id);
            if (frm_Enrollment.isClassSide)
            {
                txt_ContentA.Text = get.student_id;
                txt_ContentB.Text = get.student_info.name;
                txt_ContentC.Text = get.student_info.email;
                dtpStuBirthdate.Value = get.student_info.birthdate;
            }
            else
            {
                txt_ContentA.Text = get.class_info.course_name;
                txt_ContentB.Text = get.class_info.capacity.ToString();
                txt_ContentC.Text = get.class_info.state;
            }
        }

        private void txt_ContentA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm_Enrollment.isClassSide == false)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) 
                    && !char.IsDigit(e.KeyChar) || txt_ContentA.TextLength >= 50 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                    || txt_ContentA.TextLength >= 50 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }

        }

        // AutoComplete
        private void txt_ContentA_TextChanged(object sender, EventArgs e)
        {
            if (txt_ContentA.Text.Length > 4)
            {
                EnrollmentInfo get = new EnrollmentInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if (frm_Enrollment.isClassSide)
                    {
                        sql = "SELECT id FROM students" +
                            " WHERE id NOT IN (SELECT student_id FROM enrollments WHERE class_id = " + ucClass.public_id + ")" +
                            " AND";
                        sql += " id LIKE @data";
                        searchResult.Columns[result.Name].DataPropertyName = "id";
                    }
                    else
                    {
                        sql = "SELECT name FROM classes" +
                            " WHERE id NOT IN (SELECT class_id FROM enrollments WHERE student_id = " + ucStudent.public_id + ")" +
                            " AND state = 'Opened' AND";
                        sql += " name LIKE @data";
                        searchResult.Columns[result.Name].DataPropertyName = "name";
                    }
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_ContentA.Text + "%");
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
            else if (txt_ContentA.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }        

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            txt_ContentA.Text = row.Cells["result"].Value.ToString();
            searchResult.Height = 0;
            EnrollmentInfo get = new EnrollmentInfo();
            if (frm_Enrollment.isClassSide)
            {
                get.student_info = new StudentInfo();
                get.student_info.getDetails(txt_ContentA.Text);
                txt_ContentB.Text = get.student_info.name;
                txt_ContentC.Text = get.student_info.email;
                dtpStuBirthdate.Visible = true;
                dtpStuBirthdate.Value = get.student_info.birthdate;
            }
            else
            {
                get.class_info = new ClassInfo();
                get.class_info.getClassId(txt_ContentA.Text);
                get.class_info.getDetails(get.class_info.id);
                txt_ContentB.Text = get.class_info.capacity.ToString();
                txt_ContentC.Text = get.class_info.state;
            }
        }

        private void txt_ContentA_Leave(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }

        private void txt_ContentA_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }


    }
}
