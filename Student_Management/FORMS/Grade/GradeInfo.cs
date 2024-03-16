using MySql.Data.MySqlClient;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.FORMS.Grade
{
    public class GradeInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "tbgrade";
        string tableAttributes = "(StudentId,CourseId,Grade)";

        public int studentId { get; set; }
        public string studentName { get; set; }
        public int courseId { get; set; }
        public string courseName { get; set; }
        public bool courseState { get; set; }
        public string grade { get; set; }
        public static List<GradeInfo> list = new List<GradeInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("StudentId", this.studentId);
            cmd.Parameters.AddWithValue("CourseId", this.courseId);
            cmd.Parameters.AddWithValue("Grade", this.grade);
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
                    GradeInfo details = new GradeInfo
                    {
                        studentId = Convert.ToInt32(reader["StudentId"]),
                        courseId = Convert.ToInt32(reader["CourseId"]),
                        grade = reader["Grade"].ToString(),
                    };
                    details.getStudentName(details.studentId);
                    details.getCourseName(details.courseId);
                    details.getCourseState(details.courseId);
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
                studentId = Convert.ToInt32(reader["StudentId"]);
                courseId = Convert.ToInt32(reader["CourseId"]);
                grade = reader["Grade"].ToString();
            }
            getStudentName(studentId);
            getCourseName(courseId);
            getCourseState(courseId);
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void delete(string student_Id, string course_Id)
        {
            // ID is being used for foreign key Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM " + tableName + " WHERE StudentId = '" + student_Id + "' AND CourseId = '" + course_Id + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Deleted");
                cmd.Dispose();
                conn.Close();
            }catch (Exception ex)
            {
                get.showToast("ERROR", "Grade existed in other tables!");
            }
        }

        public void search(string key)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + "" +
                " JOIN tbstudent ON tbstudent.id = tbgrade.StudentId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId" +
                " WHERE " + frm_Grade.searchType + " LIKE @data";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GradeInfo card = new GradeInfo
                    {
                        studentId = Convert.ToInt32(reader["StudentId"]),
                        courseId = Convert.ToInt32(reader["CourseId"]),
                        grade = reader["Grade"].ToString(),
                    };
                    card.getStudentName(card.studentId);
                    card.getCourseName(card.courseId);
                    card.getCourseState(card.courseId);
                    list.Add(card);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(int student_Id, int course_Id, string grade)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET Grade = @grade WHERE StudentId = @studentId AND CourseId = @courseId";
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@studentId", student_Id);
            cmd.Parameters.AddWithValue("@courseId", course_Id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Updated");
            cmd.Dispose();
            conn.Close();
        }

        public void getDetails(int student_Id, int course_Id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT Grade FROM " + tableName + " WHERE StudentId ='" + student_Id + "' AND CourseId = '" + course_Id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            studentId = student_Id;
            courseId = course_Id;
            getStudentName(student_Id);
            getCourseName(course_Id);
            getCourseState(course_Id);
            if (reader.Read())
            {
                grade = reader["Grade"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getStudentName(int student_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id ,Name FROM tbstudent WHERE id = '" + student_id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                studentName = reader["Name"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getCourseId(string course_Name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id FROM tbcourse WHERE Name = '" + course_Name + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                courseId = Convert.ToInt32(reader["id"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getCourseName(int course_Id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT Name FROM tbcourse WHERE id = '" + course_Id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                courseName = reader["Name"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void getCourseState(int course_Id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT isOpen FROM tbcourse WHERE id = '" + course_Id + "'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                courseState = Convert.ToBoolean(reader["isOpen"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public DataTable getAllCourseNames(bool isOpen)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT Name FROM tbcourse WHERE isOpen = @isOpen";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@isOpen", isOpen);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            conn.Close();
            return dt;
        }

        public DataTable getEnrolledStudentId(int course_Id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT id FROM tbstudent WHERE id IN (SELECT StudentId FROM " + tableName + " WHERE CourseId = @courseId)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@courseId", course_Id);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            conn.Close();
            return dt;
        }


    }
}

