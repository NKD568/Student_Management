using MySql.Data.MySqlClient;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.FORMS.Course
{
    public class CourseInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "tbcourse";
        string tableAttributes = "(Name,Description,Credits)";

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int credits { get; set; }
        public static List<CourseInfo> list = new List<CourseInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Name", this.name);
            cmd.Parameters.AddWithValue("Description", this.description);
            cmd.Parameters.AddWithValue("Credits", this.credits);
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();

            get.showToast("SUCCESS", "Successfully Saved");
            cmd.Dispose();
            conn.Close();
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
                        name = reader["Name"].ToString(),
                        description = reader["Description"].ToString(),
                        credits = Convert.ToInt32(reader["Credits"])
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
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                credits = Convert.ToInt32(reader["Credits"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void delete(string detail_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "DELETE FROM " + tableName + " WHERE id = '" + detail_id + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Deleted");
            cmd.Dispose();
            conn.Close();
        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE " + frm_Course.searchType + " LIKE @data";
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
                        name = reader["Name"].ToString(),
                        description = reader["Description"].ToString(),
                        credits = Convert.ToInt32(reader["Credits"])
                    };
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string name, string description, int credits, string Id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET Name = @name, Description = @description, Credits = @credits WHERE id = @id";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@credits", credits);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Updated");
            cmd.Dispose();
            conn.Close();
        }

        public void getDetails(string details_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id ='" + details_id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                credits = Convert.ToInt32(reader["Credits"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }


    }
}
