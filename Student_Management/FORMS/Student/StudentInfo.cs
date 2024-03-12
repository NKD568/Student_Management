using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Student_Management.FORMS.Main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Management.FORMS.Student
{
    public class StudentInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "tbstudent";
        string tableAttributes = "(id,Name,Birthdate,Email)";

        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get ; set; }
        public string email { get ; set; }
        public static List<StudentInfo> list = new List<StudentInfo>();

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
                cmd.Parameters.AddWithValue("id", this.id);
                cmd.Parameters.AddWithValue("Name", this.name);
                cmd.Parameters.AddWithValue("Birthdate", this.birthdate);
                cmd.Parameters.AddWithValue("Email", this.email);
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Saved");
                cmd.Dispose();
                conn.Close();
                frm_SaveStudent.refresh = true;
            }
            catch (Exception ex) {
                get.showToast("WARNING", "This ID is already used!");
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
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    StudentInfo details = new StudentInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["Name"].ToString(),
                        birthdate = reader.GetDateTime("Birthdate"),
                        email = reader["Email"].ToString()
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
            string sql = "SELECT * FROM " + tableName + " ORDER BY created_at DESC LIMIT 1";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                name = reader["Name"].ToString();
                birthdate = Convert.ToDateTime(reader["Birthdate"]);
                email = reader["Email"].ToString();
            }
            cmd.Dispose ();
            reader.Dispose();
            conn.Close();
        }

        public void delete(string detail_id)
        {
            MySqlConnection conn = new MySqlConnection (connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "DELETE FROM " + tableName + " WHERE id = '" + detail_id + "'";
            cmd.CommandText= sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Deleted");
            cmd.Dispose ();
            conn.Close();
        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection (connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE " + frm_Student.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StudentInfo card = new StudentInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["Name"].ToString(),
                        birthdate = reader.GetDateTime("Birthdate"),
                        email = reader["Email"].ToString()
                    };
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string name, DateTime birthdate, string email, string Id)
        {
            // Duplicate ID Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "UPDATE " + tableName + " SET Name = @name, Birthdate = @birthdate, Email = @email WHERE id = @id";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Updated");
                cmd.Dispose();
                conn.Close();
                frm_SaveStudent.isUpdate = true;
            }catch (Exception ex)
            {
                get.showToast("WARNING", "This ID is already used!");
                frm_SaveStudent.isUpdate = false;
            }

        }

        public void getDetails(string details_id)
        {
            MySqlConnection conn = new MySqlConnection (connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id ='" + details_id + "'";
            cmd.CommandText= sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                name = reader["Name"].ToString();
                birthdate = reader.GetDateTime("Birthdate");
                email = reader["Email"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }


    }
}
