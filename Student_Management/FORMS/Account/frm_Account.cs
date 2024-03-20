using MaterialSkin;
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

namespace Student_Management.FORMS.Account
{
    public partial class frm_Account : Form
    {
        MaterialSkinManager materialSkinManager;
        public frm_Account()
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

        private void frm_Account_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            initDetails();
            loadCards();
        }
        int i;
        private void loadCards()
        {
            foreach (AccountInfo data in AccountInfo.list)
            {
                i++;
                ucAccount cards = new ucAccount();
                cards.cardDetails(data);
                cardContainer.Controls.Add(cards);
            }
        }
        private void initDetails()
        {
            AccountInfo get = new AccountInfo();
            get.getList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (frm_SaveAccount frm = new frm_SaveAccount())
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
                string key = txt_Search.Text;
                if(searchType == "isBlocked")
                {
                    if(txt_Search.Text == "True")
                    {
                        key = "1";
                    }else if (txt_Search.Text == "False")
                    {
                        key= "0";
                    }
                }
                searchKey = key;
                cardContainer.Controls.Clear();
                ucAccount u = new ucAccount();
                u.searchResult();
                loadCards();
            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (ucAccount.isDeleted == true)
            {
                cardContainer.Controls.Clear();
                initDetails();
                loadCards();
                ucAccount.isDeleted = false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (frm_SaveAccount.refresh == true)
            {
                ucAccount uc = new ucAccount();
                cardContainer.Controls.Add(uc);
                frm_SaveAccount.refresh = false;
            }
        }

        public static string searchType = "username";
        private void cmb_seachOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchType = cmb_seachOptions.SelectedItem.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text.Length > 4)
            {
                searchResult.Columns[result.Name].DataPropertyName = searchType;
                AccountInfo get = new AccountInfo();
                using (MySqlConnection conn = new MySqlConnection(get.connstring))
                {
                    conn.Open();
                    string sql = "SELECT Username, isBlocked FROM " + get.tableName;
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
            txt_Search.Text = row.Cells["result"].Value.ToString();
            searchResult.Height = 0;
            ucAccount u = new ucAccount();
            searchKey = txt_Search.Text;
            cardContainer.Controls.Clear();
            u.searchResult();
            loadCards();
        }

    }
}
