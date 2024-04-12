using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Course.Enrollment;
using Student_Management.FORMS.Recheck;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Student_Management.FORMS.Enrollment
{
    public partial class frm_Enrollment : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_Enrollment()
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
        }

        public static bool isClassSide = true;
        private void frm_Enrollment_Load(object sender, EventArgs e)
        {
            setViewSide();
            switch (frm_Login.userLevel)
            {
                case 0:
                    btn_Add.Visible = true;
                    break;
                case 2:
                    btn_Add.Visible = false;
                    break;
            }
        }

        private void setViewSide()
        {
            if (isClassSide)
            {
                btn_Add.Enabled = ucClass.public_state == "Closed" ? false : true;
                txt_Search.Hint = "Search Student in Class";
                cmb_seachOptions.Controls.Clear();
                cmb_seachOptions.Items.Add("Id");
                cmb_seachOptions.Items.Add("Name");
                searchType = "id";
                if (ClassPage.enableRecheckView)
                {
                    cardContainer.Controls.Clear();
                    RecheckInfo get = new RecheckInfo();
                    get.getEnrollmentList();
                    foreach (EnrollmentInfo data in RecheckInfo.listEnrollment)
                    {
                        i++;
                        ucEnrollment cards = new ucEnrollment();
                        cards.cardDetails(data);
                        cardContainer.Controls.Add(cards);
                    }
                }
                else
                {
                    initDetails();
                    loadCards();
                }
            }
            else
            {
                txt_Search.Hint = "Search Enrolled Classes";
                cmb_seachOptions.Controls.Clear();
                cmb_seachOptions.Items.Add("Name");
                cmb_seachOptions.Items.Add("State");
                searchType = "name";
                initDetails();
                loadCards();
            }

        }

        int i;
        private void loadCards()
        {
            foreach (EnrollmentInfo data in EnrollmentInfo.list)
            {
                i++;
                ucEnrollment cards = new ucEnrollment();
                cards.cardDetails(data);
                cardContainer.Controls.Add(cards);
            }
        }
        private void initDetails()
        {
            EnrollmentInfo get = new EnrollmentInfo();
            if (isClassSide)
            {
                get.getListClassSide();
            }
            else
            {
                get.getListStudentSide();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveEnrollment frm = new frm_SaveEnrollment())
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
                cardContainer.Controls.Clear();
                ucEnrollment u = new ucEnrollment();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucEnrollment.isDeleted == true)
            {
                cardContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucEnrollment.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveEnrollment.refresh == true)
            {
                ucEnrollment uc = new ucEnrollment();
                cardContainer.Controls.Add(uc);
                frm_SaveEnrollment.refresh = false;
            }
        }

        public static string searchType;
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType = cmb_seachOptions.SelectedItem.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 4)
            {
                EnrollmentInfo get = new EnrollmentInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if (isClassSide)
                    {
                        sql = "SELECT students." + searchType + " FROM " + get.tableName +
                              " JOIN students ON students.id = enrollments.student_id" +
                              " WHERE class_id = " + ucClass.public_id;
                        sql += " AND students." + searchType + " LIKE @data";
                        searchResult.Columns[result.Name].DataPropertyName = searchType;
                    }
                    else
                    {
                        sql = "SELECT classes." + searchType + " FROM " + get.tableName +
                              " JOIN classes ON classes.id = enrollments.class_id" +
                              " WHERE student_id = " + ucStudent.public_id;
                        sql += " AND classes." + searchType + " LIKE @data";
                        searchResult.Columns[result.Name].DataPropertyName = searchType;
                    }
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_Search.Text + "%");
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
            else if (txt_Search.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            txt_Search.Text = row.Cells["result"].Value.ToString();
            searchResult.Height = 0;
            ucEnrollment u = new ucEnrollment();
            searchKey = txt_Search.Text;
            cardContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }


    }
}
