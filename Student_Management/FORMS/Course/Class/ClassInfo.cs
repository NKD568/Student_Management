using MySql.Data.MySqlClient;
using Student_Management.FORMS.Grade;
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
    public class ClassInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "classes";
        string tableAttributes = "(course_id,name,capacity,state)";

        public string id { get; set; }
        public string name { get; set; }
        public string course_id { get; set; }
        public string course_name { get; set; }
        public int capacity { get; set; }
        public string state { get; set; }
        public static List<ClassInfo> list = new List<ClassInfo>();
        public List<ClassInfo> recheckList = new List<ClassInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("course_id", this.course_id);
            cmd.Parameters.AddWithValue("name", this.name);
            cmd.Parameters.AddWithValue("capacity", this.capacity);
            cmd.Parameters.AddWithValue("state", this.state);
            cmd.ExecuteNonQuery();
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
                    ClassInfo details = new ClassInfo
                    {
                        id = reader["id"].ToString(),
                        course_id = reader["course_id"].ToString(),
                        name = reader["name"].ToString(),
                        capacity = Convert.ToInt32(reader["capacity"]),
                        state = reader["state"].ToString()
                    };
                    getCourseName(details.course_id);
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
                course_id = reader["course_id"].ToString();
                name = reader["name"].ToString();
                getCourseName(course_id);
                capacity = Convert.ToInt32(reader["capacity"]);
                state = reader["state"].ToString();
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
                get.showToast("ERROR", "Class existed in other data");
            }

        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql;
            if(ClassPage.searchType == "Course")
            {
                sql = "SELECT * FROM " + tableName +
                     " JOIN courses ON courses.id = classes.course_id" +
                     " WHERE courses.name LIKE @data";
            }
            else
            {
                sql = "SELECT * FROM " + tableName +
                     " WHERE " + ClassPage.searchType + " LIKE @data";
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClassInfo card = new ClassInfo
                    {
                        id = reader["id"].ToString(),
                        course_id = reader["course_id"].ToString(),
                        name = reader["name"].ToString(),
                        capacity = Convert.ToInt32(reader["capacity"]),
                        state = reader["state"].ToString()
                    };
                    getCourseName(card.course_id);
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string _course_id, string _name, int _capacity, string _state, string _id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET course_id = @course_id, name = @name, capacity = @capacity, state = @state WHERE id = @id";
            cmd.Parameters.AddWithValue("@course_id", _course_id);
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@capacity", _capacity);
            cmd.Parameters.AddWithValue("@state", _state);
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
            string sql = "SELECT * FROM " + tableName + " WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id",details_id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                course_id = reader["course_id"].ToString();
                name = reader["name"].ToString();
                getCourseName(course_id);
                capacity = Convert.ToInt32(reader["capacity"]);
                state = reader["state"].ToString();
            }
            else
            {
                name = "";
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getCourseName(string _course_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT name FROM courses WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", _course_id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                course_name = reader["name"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getCourseId(string _course_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id FROM courses WHERE name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", _course_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                course_id = reader["id"].ToString();
            }
            else
            {
                course_id = "";
            }
            cmd.Dispose();
            reader.Dispose();
        }

        public void getClassId(string class_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id FROM classes WHERE name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", class_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool checkValidCourse(string _course_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id FROM courses" +
                " WHERE name = @name AND isOpen = true";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", _course_name);
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


    }
}
