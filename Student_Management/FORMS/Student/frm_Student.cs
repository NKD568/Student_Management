using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Student_Management.FORMS.Student
{
    public partial class frm_Student : Form
    {
        MaterialSkinManager materialSkinManager;
        public frm_Student()
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

        private void frm_Student_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            initDetails();
            loadCards();
        }
        int i;
        private void loadCards()
        {
            foreach(StudentInfo data in StudentInfo.list)
            {
                i++;
                ucStudent cards = new ucStudent();
                cards.cardDetails(data);
                studentContainer.Controls.Add(cards);
            }
        }
        private void initDetails()
        {
            StudentInfo get = new StudentInfo();
            get.getList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveStudent frm = new frm_SaveStudent())
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
            }catch (Exception ex)
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
            if(e.KeyChar == (char)Keys.Enter)
            {
                searchKey = txt_Search.Text;
                studentContainer.Controls.Clear();
                ucStudent u = new ucStudent();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if(ucStudent.isDeleted == true) { 
                studentContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucStudent.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveStudent.refresh == true)
            {
                ucStudent stu = new ucStudent();
                studentContainer.Controls.Add(stu);
                frm_SaveStudent.refresh = false;
            }
        }

        public static string searchType = "id";
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType = cmb_seachOptions.SelectedItem.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text.Length > 4) {
                StudentInfo get = new StudentInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql;
                    if(searchType == "id")
                    {
                        sql = "SELECT id, Name  FROM "+ get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = "Name";
                    }
                    else
                    {
                        sql = "SELECT id, " + searchType + " FROM " + get.tableName;
                        searchResult.Columns[result.Name].DataPropertyName = searchType;
                    }
                    sql += " WHERE " + searchType + " LIKE @data";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data",txt_Search.Text + "%");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if(dt != null && dt.Rows.Count > 0)
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
            }else if (txt_Search.TextLength <= 0){
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            if (searchType != "id") {
                txt_Search.Text = row.Cells["result"].Value.ToString();
            }
            else
            {
                txt_Search.Text = row.Cells["id"].Value.ToString();
            }
            searchResult.Height = 0;
            ucStudent u = new ucStudent();
            searchKey = txt_Search.Text;
            studentContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }
    

    }
 }

