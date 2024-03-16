﻿using MaterialSkin;
using MySql.Data.MySqlClient;
using Student_Management.FORMS.Course;
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
    public partial class frm_Grade : Form
    {
        MaterialSkinManager materialSkinManager;
        public frm_Grade()
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
            this.ControlBox = false;
        }

        private void frm_Grade_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            initDetails();
            loadCards();
        }
        int i;
        private void loadCards()
        {
            foreach (GradeInfo data in GradeInfo.list)
            {
                i++;
                ucGrade cards = new ucGrade();
                cards.cardDetails(data);
                gradeContainer.Controls.Add(cards);
            }
        }
        private void initDetails()
        {
            GradeInfo get = new GradeInfo();
            get.getList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveGrade frm = new frm_SaveGrade())
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

        public static string searchKey;
        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchKey = txt_Search.Text;
                gradeContainer.Controls.Clear();
                ucGrade u = new ucGrade();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucGrade.isDeleted == true)
            {
                gradeContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucGrade.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveGrade.refresh == true)
            {
                ucGrade uc = new ucGrade();
                gradeContainer.Controls.Add(uc);
                frm_SaveGrade.refresh = false;
            }
        }

        public static string searchType = "tbgrade.StudentId";
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmb_seachOptions.SelectedItem.ToString();
            switch (type)
            {
                case "Student Id": searchType = "tbgrade.StudentId"; break;
                case "Student Name": searchType = "tbstudent.Name"; break;
                case "Course": searchType = "tbcourse.Name"; break;
                case "Grade": searchType = "tbgrade.Grade"; break;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 4)
            {
                //searchResult.Columns[result.Name].DataPropertyName = searchType;
                GradeInfo get = new GradeInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if (searchType == "tbstudent.Name")
                    {
                        sql = "SELECT tbstudent.Name AS StudentName, tbcourse.Name AS CourseName, tbgrade.Grade AS Grade FROM " + get.tableName +
                                    " JOIN tbcourse on tbgrade.CourseId = tbcourse.id" +
                                    " JOIN tbstudent on tbgrade.StudentId = tbstudent.id";
                        searchResult.Columns[student.Name].DataPropertyName = "StudentName";
                        searchResult.Columns[course.Name].DataPropertyName = "CourseName";
                        searchResult.Columns[result.Name].DataPropertyName = "Grade";
                    }
                    else
                    {
                        sql = "SELECT tbgrade.StudentId AS StudentId, tbcourse.Name AS CourseName, tbgrade.Grade AS Grade FROM " + get.tableName +
                                    " JOIN tbcourse on tbgrade.CourseId = tbcourse.id";
                        searchResult.Columns[student.Name].DataPropertyName = "StudentId";
                        searchResult.Columns[course.Name].DataPropertyName = "CourseName";
                        searchResult.Columns[result.Name].DataPropertyName = "Grade";

                    }
                    sql += " WHERE " + searchType + " LIKE @data";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_Search.Text + "%");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        searchResult.DataSource = dt;
                        searchResult.Height = searchResult.Rows.Count * 40;
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
            else if (txt_Search.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            switch (searchType)
            {
                case "tbgrade.StudentId":
                case "tbstudent.Name": 
                    txt_Search.Text = row.Cells[student.Name].Value.ToString(); break;
                case "tbcourse.Name": txt_Search.Text = row.Cells[course.Name].Value.ToString(); break;
                case "tbgrade.Grade": txt_Search.Text = row.Cells[result.Name].Value.ToString(); break;
            }

            searchResult.Height = 0;
            ucGrade u = new ucGrade();
            searchKey = txt_Search.Text;
            gradeContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }


    }
}
