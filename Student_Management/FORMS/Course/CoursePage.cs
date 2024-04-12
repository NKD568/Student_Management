using MaterialSkin;
using MySql.Data.MySqlClient;
using Student_Management.FORMS.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Course
{
    public partial class CoursePage : UserControl
    {
        MaterialSkinManager materialSkinManager;
        public CoursePage()
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

        private void uc_CoursePage_Load(object sender, EventArgs e)
        {
            btn_Add.Visible = frm_Login.userLevel == 2 ? false : true;
            initDetails();
            loadCards();
        }
        int i;
        private void loadCards()
        {
            foreach (CourseInfo data in CourseInfo.list)
            {
                i++;
                ucCourse cards = new ucCourse();
                cards.cardDetails(data);
                cardContainer.Controls.Add(cards);
            }
        }
        private void initDetails()
        {
            CourseInfo get = new CourseInfo();
            get.getList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveCourse frm = new frm_SaveCourse())
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
                ucCourse u = new ucCourse();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucCourse.isDeleted == true)
            {
                cardContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucCourse.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveCourse.refresh == true)
            {
                ucCourse stu = new ucCourse();
                cardContainer.Controls.Add(stu);
                frm_SaveCourse.refresh = false;
            }
        }

        public static string searchType = "name";
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType = cmb_seachOptions.SelectedItem.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 4)
            {
                searchResult.Columns[result.Name].DataPropertyName = searchType;
                CourseInfo get = new CourseInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if (searchType == "name")
                    {
                        sql = "SELECT name, isOpen  FROM " + get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = "name";
                    }
                    else
                    {
                        sql = "SELECT name, " + searchType + " FROM " + get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = searchType;
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
            if (searchType != "name")
            {
                txt_Search.Text = row.Cells["result"].Value.ToString();
            }
            else
            {
                txt_Search.Text = row.Cells["name"].Value.ToString();
            }
            searchResult.Height = 0;
            ucCourse u = new ucCourse();
            searchKey = txt_Search.Text;
            cardContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }


    }
}
