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
        public string tableName = "tbcourse";
        string tableAttributes = "(Name,Description,Credits,isOpen)";

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int credits { get; set; }
        public bool isOpen { get; set; }
        public static List<CourseInfo> list = new List<CourseInfo>();

        public void Save()
        {
            frm_Main get = new frm_Main();
            // Duplicate Name Exception
            try
            {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Name", this.name);
            cmd.Parameters.AddWithValue("Description", this.description);
            cmd.Parameters.AddWithValue("Credits", this.credits);
            cmd.Parameters.AddWithValue("isOpen", this.isOpen);
            cmd.ExecuteNonQuery();
            get.showToast("SUCCESS", "Successfully Saved");
            cmd.Dispose();
            conn.Close();
            frm_SaveCourse.refresh = true;
            }
            catch (Exception ex)
            {
                get.showToast("WARNING", "This Name is already used!");
                frm_SaveStudent.refresh = false;
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
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["Name"].ToString(),
                        description = reader["Description"].ToString(),
                        credits = Convert.ToInt32(reader["Credits"]),
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
                id = Convert.ToInt32(reader["id"]);
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                credits = Convert.ToInt32(reader["Credits"]);
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
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["Name"].ToString(),
                        description = reader["Description"].ToString(),
                        credits = Convert.ToInt32(reader["Credits"]),
                        isOpen = Convert.ToBoolean(reader["isOpen"])
                    };
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string name, string description, int credits, bool isOpen, string Id)
        {
            frm_Main get = new frm_Main();
            // Duplicate Name Exception
            try
            {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET Name = @name, Description = @description, Credits = @credits, isOpen = @isOpen WHERE id = @id";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@credits", credits);
            cmd.Parameters.AddWithValue("@isOpen", isOpen);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            get.showToast("SUCCESS", "Successfully Updated");
            cmd.Dispose();
            conn.Close();
            frm_SaveCourse.isUpdate = true;
            }
            catch (Exception ex)
            {
                get.showToast("WARNING", "This Name is already used!");
                frm_SaveCourse.isUpdate = false;
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
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                credits = Convert.ToInt32(reader["Credits"]);
                isOpen = Convert.ToBoolean(reader["isOpen"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool isOccupied(int details_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM tbgrade WHERE id IN (SELECT GradeId FROM tbschedule) AND CourseId = '" + details_id + "'";
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
