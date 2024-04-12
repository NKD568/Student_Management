using MySql.Data.MySqlClient;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.FORMS.Recheck
{
    public class RecheckInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "rechecks";
        string tableAttributes = "(grade_id)";

        public string grade_id { get; set; }
        public GradeInfo grade_info = new GradeInfo();
        public static List<ClassInfo> listClass = new List<ClassInfo>();
        public static List<EnrollmentInfo> listEnrollment = new List<EnrollmentInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("grade_id", this.grade_id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void getClassList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT DISTINCT classes.* FROM " + tableName +
                        " JOIN grades ON grades.id = rechecks.grade_id" +
                        " JOIN enrollments ON enrollments.id = grades.enrollment_id" +
                        " JOIN classes ON classes.id = enrollments.class_id";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            listClass.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ClassInfo details = new ClassInfo
                    {
                        id = reader["id"].ToString(),
                        course_id = reader["course_id"].ToString(),
                        name = reader["name"].ToString(),
                        capacity = reader.GetInt32("capacity"),
                        state = reader["state"].ToString(),
                    };
                    details.getCourseName(details.course_id);
                    listClass.Add(details);
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public void getEnrollmentList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT DISTINCT enrollments.* FROM " + tableName +
                        " JOIN grades ON grades.id = rechecks.grade_id" +
                        " JOIN enrollments ON enrollments.id = grades.enrollment_id";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            listEnrollment.Clear();
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
                    details.student_info.getDetails(details.student_id);
                    listEnrollment.Add(details);
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public bool checkRecheckSent(string _grade_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE grade_id = '" +_grade_id+"'";
            cmd.CommandText = sql;

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

        public void removeRecheck(string _grade_id)
        {
            removeFromList(_grade_id);
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "DELETE FROM rechecks WHERE grade_id = @grade_id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@grade_id", _grade_id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void removeFromList(string _grade_id)
        {
            grade_info.getGradeDetails(_grade_id);
            string _class = grade_info.enrollment_info.class_info.id;
            foreach (ClassInfo data in listClass)
            {
                if (data.id == _class)
                {
                    listClass.Remove(data);
                    break;
                }
            }
            string _enrollment = grade_info.enrollment_info.id;
            foreach (EnrollmentInfo data in listEnrollment)
            {
                if (data.id == _enrollment)
                {
                    listEnrollment.Remove(data);
                    break;
                }
            }
        }


    }
}
