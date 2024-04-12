using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace Student_Management.FORMS.Course
{
    public partial class frm_SaveClass : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_SaveClass()
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
                ClassInfo save = new ClassInfo();
                save.getCourseId(txt_Course.Text);
                save.name = txt_Name.Text;
                save.capacity = Convert.ToInt32(txt_Capacity.Text);
                save.state = cmb_State.SelectedItem.ToString();
                save.Save();
                refresh = true;
                notify.showToast("SUCESS", "Sucessfully Saved");
            }
            else
            {
                ClassInfo up = new ClassInfo();
                up.getCourseId(txt_Course.Text);
                up.name = txt_Name.Text;
                up.update(up.course_id, up.name, Convert.ToInt32(txt_Capacity.Text), cmb_State.SelectedItem.ToString(), ucClass.public_id);
                isUpdate = true;
                notify.showToast("SUCESS", "Sucessfully Updated");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Course.Text == "" || txt_Capacity.Text == "" || txt_Name.Text == "")
            {
                MessageBox.Show("Please type all informations!");
                return;
            }
            ClassInfo get = new ClassInfo();
            bool isValid = get.checkValidCourse(txt_Course.Text);
            if (!isValid)
            {
                MessageBox.Show("Course must either exist or open!");
                return;
            }
            bool isDuplicate = get.checkDuplicateName(txt_Name.Text);
            if (isDuplicate && txt_Name.Text != ucClass.public_name)
            {
                MessageBox.Show("Name is already taken!");
                return;
            }
            int cap = Convert.ToInt32(txt_Capacity.Text);
            if (cap > 50 || cap < 1)
            {
                MessageBox.Show("Max capacity is 50 and Min is 1");
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        bool update = false;
        private void frm_SaveClass_Load(object sender, EventArgs e)
        {
            if (ucClass.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                gpDetails.TabIndex = txt_Name.TabIndex;
                update = true;
                ucClass.view = false;
            }
            else
            {
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void getDetail()
        {
            ClassInfo get = new ClassInfo();
            get.getDetails(ucClass.public_id);
            txt_Course.Text = get.course_name;
            txt_Name.Text = get.name;
            txt_Capacity.Text = get.capacity.ToString();
            cmb_State.SelectedItem = get.state;
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

        private void txt_Course_TextChanged(object sender, EventArgs e)
        {
            if (txt_Course.Text.Length > 4)
            {
                ClassInfo get = new ClassInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT name FROM courses WHERE isOpen = true AND";
                    sql += " name LIKE @data";
                    searchResult.Columns[result.Name].DataPropertyName = "name";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", txt_Course.Text + "%");
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
            else if (txt_Course.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResultCourName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            txt_Course.Text = row.Cells["result"].Value.ToString();
            searchResult.Height = 0;
        }

        private void txt_Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Course_Enter(object sender, EventArgs e)
        {
            searchResult.Visible = true;
        }

    }
}
