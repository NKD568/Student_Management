using MySql.Data.MySqlClient;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;


namespace Student_Management.FORMS.Grade
{
    public class GradeInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "grades";
        string tableAttributes = "(enrollment_id,type,grade)";

        public string id { get; set; }
        public string enrollment_id { get; set; }
        public EnrollmentInfo enrollment_info = new EnrollmentInfo();
        public string type { get; set; }      
        public string grade { get; set; }
        public static List<GradeInfo> list = new List<GradeInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("enrollment_id", this.enrollment_id);
            cmd.Parameters.AddWithValue("type", this.type);
            cmd.Parameters.AddWithValue("grade", this.grade);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string _enrollment_id, string _type, string _grade)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET grade = @grade" +
                " WHERE enrollment_id = @enrollment_id AND type = @type";
            cmd.Parameters.AddWithValue("@grade", _grade);
            cmd.Parameters.AddWithValue("@enrollment_id", _enrollment_id);
            cmd.Parameters.AddWithValue("@type", _type);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void delete(string id)
        {
            // ID is being used for foreign key Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM " + tableName + " WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Deleted");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                get.showToast("ERROR", "Grade existed in other data!");
            }
        }

        public DataTable getDetails(string _enrollment_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE enrollment_id = @enrollment_id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@enrollment_id", _enrollment_id);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            return dt;
        }

        public void getGradeDetails(string _id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", _id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                enrollment_id = reader["enrollment_id"].ToString();
                type = reader["type"].ToString();
                grade = reader["grade"].ToString();
                enrollment_info.getDetails(enrollment_id);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }


    }
}

