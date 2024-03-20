using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Student_Management.FORMS.Account
{
    public class AccountInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "tbaccount";
        string tableAttributes = "(Username,Password,Level,isBlocked)";

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int level { get; set; }
        public bool isBlocked { get; set; }
        public static List<AccountInfo> list = new List<AccountInfo>();

        public void Save()
        {
            frm_Main get = new frm_Main();
            // Duplicate ID Exception
            try
            {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Username", this.username);
            cmd.Parameters.AddWithValue("Password", this.password);
            cmd.Parameters.AddWithValue("Level", this.level);
            cmd.Parameters.AddWithValue("isBlocked", this.isBlocked);
            cmd.ExecuteNonQuery();
            get.showToast("SUCCESS", "Successfully Saved");
            cmd.Dispose();
            conn.Close();
            frm_SaveAccount.refresh = true;
            }
            catch (Exception ex)
            {
                get.showToast("WARNING", "Username is already used!");
                frm_SaveAccount.refresh = false;
            }
        }

        public void getList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName;
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AccountInfo details = new AccountInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
                        username = reader["Username"].ToString(),
                        password = reader["Password"].ToString(),
                        level = Convert.ToInt32(reader["Level"]),
                        isBlocked = Convert.ToBoolean(reader["isBlocked"]),
                    };
                    list.Add(details);
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public void getNewInsertedData()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " ORDER BY id DESC LIMIT 1";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                username = reader["Username"].ToString();
                password = reader["Password"].ToString();
                level = Convert.ToInt32(reader["Level"]);
                isBlocked = Convert.ToBoolean(reader["isBlocked"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void delete(string detail_id)
        {
            // ID is being used for foreign key Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM " + tableName + " WHERE id = '" + detail_id + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Deleted");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                get.showToast("ERROR", "Account existed in other tables");
            }

        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE " + frm_Account.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AccountInfo card = new AccountInfo
                    {
                    id = Convert.ToInt32(reader["id"]),
                    username = reader["Username"].ToString(),
                    password = reader["Password"].ToString(),
                    level = Convert.ToInt32(reader["Level"]),
                    isBlocked = Convert.ToBoolean(reader["isBlocked"])
                };
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string _username, string _password, int _level, bool _isBlocked, string _id)
        {
            frm_Main get = new frm_Main();
            // Duplicate ID Exception
            try
            {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET Username = @username, Password = @password, Level = @level, isBlocked = @isBlocked WHERE id = @id";
            cmd.Parameters.AddWithValue("@username", _username);
            cmd.Parameters.AddWithValue("@password", _password);
            cmd.Parameters.AddWithValue("@level", _level);
            cmd.Parameters.AddWithValue("@isBlocked", _isBlocked);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            get.showToast("SUCCESS", "Successfully Updated");
            cmd.Dispose();
            conn.Close();
            frm_SaveAccount.isUpdate = true;
            }
            catch (Exception ex)
            {
                get.showToast("WARNING", "Username is already used!");
                frm_SaveAccount.refresh = false;
                frm_SaveAccount.isUpdate = false;
            }
        }

        public void getDetails(string details_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id = '" + details_id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                username = reader["Username"].ToString();
                password = reader["Password"].ToString();
                level = Convert.ToInt32(reader["Level"]);
                isBlocked = Convert.ToBoolean(reader["isBlocked"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool checkLogin(string _username, string _password)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE Username = @username AND Password = @password";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@username", _username);
            cmd.Parameters.AddWithValue("@password", _password);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                level = reader.GetInt32("Level");
                isBlocked = reader.GetBoolean("isBlocked");
                reader.Dispose();
                cmd.Dispose();
                conn.Close();
                return true;
            }
            else
            {
                reader.Dispose();
                cmd.Dispose();
                conn.Close();
                return false;
            }
        }

    }
}
