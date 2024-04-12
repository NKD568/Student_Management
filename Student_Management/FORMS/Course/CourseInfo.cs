using MySql.Data.MySqlClient;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management.FORMS.Course
{
    public class CourseInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "courses";
        string tableAttributes = "(name,description,credits,isOpen)";

        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int credits { get; set; }
        public bool isOpen { get; set; }
        public static List<CourseInfo> list = new List<CourseInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("name", this.name);
            cmd.Parameters.AddWithValue("description", this.description);
            cmd.Parameters.AddWithValue("credits", this.credits);
            cmd.Parameters.AddWithValue("isOpen", this.isOpen);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public bool checkDuplicateName(string _name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", _name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                cmd.Dispose();
                conn.Close();
                reader.Dispose();
                return true;
            }
            else
            {
                cmd.Dispose();
                conn.Close();
                reader.Dispose();
                return false;
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
                    CourseInfo details = new CourseInfo
                    {
                        id = reader["id"].ToString(),
                        name = reader["name"].ToString(),
                        description = reader["description"].ToString(),
                        credits = Convert.ToInt32(reader["credits"]),
                        isOpen = Convert.ToBoolean(reader["isOpen"]),
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
                id = reader["id"].ToString();
                name = reader["name"].ToString();
                description = reader["description"].ToString();
                credits = Convert.ToInt32(reader["credits"]);
                isOpen = Convert.ToBoolean(reader["isOpen"]);

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
            }catch (Exception ex)
            {
                get.showToast("ERROR", "Course existed in other data");              
            }

        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE " + CoursePage.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CourseInfo card = new CourseInfo
                    {
                        id = reader["id"].ToString(),
                        name = reader["name"].ToString(),
                        description = reader["description"].ToString(),
                        credits = Convert.ToInt32(reader["credits"]),
                        isOpen = Convert.ToBoolean(reader["isOpen"])
                    };
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string _name, string _description, int _credits, bool _isOpen, string _id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET name = @name, description = @description, credits = @credits, isOpen = @isOpen WHERE id = @id";
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@description", _description);
            cmd.Parameters.AddWithValue("@credits", _credits);
            cmd.Parameters.AddWithValue("@isOpen", _isOpen);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
          
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
                id = reader["id"].ToString();
                name = reader["name"].ToString();
                description = reader["description"].ToString();
                credits = Convert.ToInt32(reader["credits"]);
                isOpen = Convert.ToBoolean(reader["isOpen"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool isOccupied(string details_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM classes WHERE NOT state = 'Closed' AND course_id = '" + details_id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
                return true;

            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
                return false;

            }
        }


    }
}
