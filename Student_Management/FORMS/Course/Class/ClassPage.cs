using MaterialSkin;
using MySql.Data.MySqlClient;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Recheck;
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
    public partial class ClassPage : UserControl
    {
        MaterialSkinManager materialSkinManager;
        public ClassPage()
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

        private void ucClassPage_Load(object sender, EventArgs e)
        {
            switch (frm_Login.userLevel)
            {
                case 0:
                    btn_Add.Visible = true;
                    lbl_ViewRecheck.Visible = true;
                    btn_ViewRechecks.Visible = true;
                    break;
                case 2:
                    btn_Add.Visible = false;
                    lbl_ViewRecheck.Visible = false;
                    btn_ViewRechecks.Visible = false;
                    break;
            }
            initDetails();
            loadCards();
        }

        int i;
        private void loadCards()
        {
            foreach (ClassInfo data in ClassInfo.list)
            {
                i++;
                ucClass cards = new ucClass();
                cards.cardDetails(data);
                cardContainer.Controls.Add(cards);
            }
        }

        public static bool enableRecheckView;
        private void btn_ViewRechecks_ToggledChanged()
        {
            cardContainer.Controls.Clear();
            if (btn_ViewRechecks.Toggled == true)
            {
                RecheckInfo get = new RecheckInfo();
                get.getClassList();
                foreach (ClassInfo data in RecheckInfo.listClass)
                {
                    i++;
                    ucClass cards = new ucClass();
                    cards.cardDetails(data);
                    cardContainer.Controls.Add(cards);
                }
                enableRecheckView = true;
            }
            else
            {
                enableRecheckView = false;
                loadCards();
            }
        }

        private void initDetails()
        {
            ClassInfo get = new ClassInfo();
            get.getList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveClass frm = new frm_SaveClass())
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
                ucClass u = new ucClass();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucClass.isDeleted == true)
            {
                cardContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucClass.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveClass.refresh == true)
            {
                ucClass stu = new ucClass();
                cardContainer.Controls.Add(stu);
                frm_SaveClass.refresh = false;
            }
        }

        public static string searchType = "Course";
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType = cmb_seachOptions.SelectedItem.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 4)
            {
                searchResult.Columns[result.Name].DataPropertyName = searchType;
                ClassInfo get = new ClassInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if (searchType == "Course")
                    {
                        sql = "SELECT classes.name AS id, courses.name AS course FROM " + get.tableName +
                                " JOIN courses ON courses.id = classes.course_id" +
                                " WHERE courses.name LIKE @data";
                        searchResult.Columns[result.Name].DataPropertyName = "course";
                    }
                    else if (searchType == "Name")
                    {
                        sql = "SELECT name AS id, state FROM " + get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = "state";
                        sql += " WHERE " + searchType + " LIKE @data";
                    }
                    else
                    {
                        sql = "SELECT name AS id, " + searchType + " FROM " + get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = searchType;
                        sql += " WHERE " + searchType + " LIKE @data";
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
            if (searchType != "Name")
            {
                txt_Search.Text = row.Cells["result"].Value.ToString();
            }
            else
            {
                txt_Search.Text = row.Cells["id"].Value.ToString();
            }
            searchResult.Height = 0;
            ucClass u = new ucClass();
            searchKey = txt_Search.Text;
            cardContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }


    }
}
