using MySql.Data.MySqlClient;
using Student_Management.FORMS.Enrollment;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.FORMS.Course
{
    public class EnrollmentInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "enrollments";
        string tableAttributes = "(class_id,student_id)";

        public string id { get; set; }
        public string class_id { get; set; }
        public string student_id { get; set; }
        public StudentInfo student_info = new StudentInfo();
        public ClassInfo class_info = new ClassInfo();
        public static List<EnrollmentInfo> list = new List<EnrollmentInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("class_id", this.class_id);
            cmd.Parameters.AddWithValue("student_id", this.student_id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void getListClassSide()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE class_id = @class_id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@class_id", ucClass.public_id);
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EnrollmentInfo details = new EnrollmentInfo
                    {
                        id = reader["id"].ToString(),
                        class_id = reader["class_id"].ToString(),
                        student_id = reader["student_id"].ToString(),
                    };
                    details.student_info.getDetails(details.student_id);
                    list.Add(details);
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public void getListStudentSide()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE student_id = @student_id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@student_id", ucStudent.public_id);

            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EnrollmentInfo details = new EnrollmentInfo
                    {
                        id = reader["id"].ToString(),
                        class_id = reader["class_id"].ToString(),
                        student_id = reader["student_id"].ToString(),
                    };
                    details.class_info.getDetails(details.class_id);
                    list.Add(details);
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public void getNewDataClassSide()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE class_id = " +
                         ucClass.public_id + " ORDER BY id DESC LIMIT 1";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                class_id = reader["class_id"].ToString();
                student_id = reader["student_id"].ToString();
                student_info.getDetails(student_id);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getNewDataStudentSide()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE student_id = " +
                         ucStudent.public_id + " ORDER BY id DESC LIMIT 1";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                class_id = reader["class_id"].ToString();
                student_id = reader["student_id"].ToString();
                class_info.getDetails(class_id);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void updateClassSide(string _student_id, string _id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET student_id = @student_id WHERE id = @id";
            cmd.Parameters.AddWithValue("@student_id", _student_id);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void updateStudentSide(string _class_id, string _id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET class_id = @class_id WHERE id = @id";
            cmd.Parameters.AddWithValue("@class_id", _class_id);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
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
                string sql = "DELETE FROM " + tableName + " WHERE id = @id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", detail_id);
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Deleted");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                get.showToast("ERROR", "Enrollment existed in other data");
            }

        }

        public void searchClassSide(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName +
                " JOIN students ON students.id = enrollments.student_id" +
                " WHERE class_id = " + ucClass.public_id +
                " AND students." + frm_Enrollment.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EnrollmentInfo card = new EnrollmentInfo
                    {
                        id = reader["id"].ToString(),
                        class_id = reader["class_id"].ToString(),
                        student_id = reader["student_id"].ToString(),
                    };
                    card.student_info.getDetails(card.student_id);
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void searchStudentSide(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql;
            sql = "SELECT * FROM " + tableName +
                  " JOIN classes ON classes.id = enrollments.class_id" +
                 " WHERE student_id = " + ucStudent.public_id +
                 " AND classes." + frm_Enrollment.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EnrollmentInfo card = new EnrollmentInfo
                    {
                        id = reader["id"].ToString(),
                        class_id = reader["class_id"].ToString(),
                        student_id = reader["student_id"].ToString(),
                    };
                    card.class_info.getDetails(card.class_id);
                    list.Add(card);
                }
            }
            reader.Dispose();
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
                class_id = reader["class_id"].ToString();
                student_id = reader["student_id"].ToString();
                student_info.getDetails(student_id);
                class_info.getDetails(class_id);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool checkStudentInClass(string _student_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT student_id FROM " + tableName + " WHERE student_id = @student_id AND class_id = " + ucClass.public_id;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@student_id", _student_id);
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

        public bool checkEnrolledClass(string _class_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT class_id FROM " + tableName + " WHERE class_id = @class_id AND student_id = " + ucStudent.public_id;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@class_id", _class_id);
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
