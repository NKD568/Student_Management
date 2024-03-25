using MySql.Data.MySqlClient;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Student_Management.FORMS.Grade
{
    public class GradeInfo
    {
        public string connstring = frm_Main.connstring;
        public string tableName = "tbgrade";
        string tableAttributes = "(StudentId,CourseId,Grade)";

        public int id { get; set; }
        public int studentId { get; set; }
        public string studentName { get; set; }
        public int courseId { get; set; }
        public string courseName { get; set; }
        public bool courseState { get; set; }
        public string grade { get; set; }
        public static List<GradeInfo> list = new List<GradeInfo>();
        public static List<GradeInfo> recheckList = new List<GradeInfo>();

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

        public void SaveRecheckInfo()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO tbrecheck (StudentId,GradeId)VALUES(?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("StudentId", this.studentId);
            cmd.Parameters.AddWithValue("GradeId", this.id);
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
                    GradeInfo details = new GradeInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
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

        public void getRecheckList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbgrade.id, tbgrade.StudentId, tbgrade.CourseId, tbgrade.Grade FROM tbrecheck" +
                        " JOIN tbgrade ON tbgrade.id = tbrecheck.GradeId";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            recheckList.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GradeInfo details = new GradeInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
                        studentId = Convert.ToInt32(reader["StudentId"]),
                        courseId = Convert.ToInt32(reader["CourseId"]),
                        grade = reader["Grade"].ToString(),
                    };
                    details.getStudentName(details.studentId);
                    details.getCourseName(details.courseId);
                    details.getCourseState(details.courseId);
                    recheckList.Add(details);
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
            }catch (Exception ex)
            {
                get.showToast("ERROR", "Grade existed in other data!");
            }
        }

        public void removeRecheck(int _gradeId)
        {
            foreach(GradeInfo data in recheckList)
            {
                if(data.id == _gradeId)
                {
                    recheckList.Remove(data);
                    break;
                }
            }
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "DELETE FROM tbrecheck WHERE GradeId = @gradeId";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@gradeId", _gradeId);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
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
                        id = Convert.ToInt32(reader["id"]),
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

        public void searchStudentId(string _studentId)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM " + tableName + " WHERE StudentId = @studentid";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@studentid", _studentId);
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GradeInfo card = new GradeInfo
                    {
                        id = Convert.ToInt32(reader["id"]),
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
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public void update(int id, string grade)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET Grade = @grade WHERE id = @id ";
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Updated");
            cmd.Dispose();
            conn.Close();
        }

        public void getDetails(int id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            this.id = id;
            if (reader.Read())
            {
                studentId = Convert.ToInt32(reader["StudentId"]);
                courseId = Convert.ToInt32(reader["CourseId"]);
                grade = reader["Grade"].ToString();
                getStudentName(studentId);
                getCourseName(courseId);
                getCourseState(courseId);
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
            string sql = "SELECT Name FROM tbstudent WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", student_id);
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
            string sql = "SELECT id FROM tbcourse WHERE Name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", course_Name);
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
            string sql = "SELECT Name FROM tbcourse WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", course_Id);
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
            string sql = "SELECT isOpen FROM tbcourse WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", course_Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                courseState = Convert.ToBoolean(reader["isOpen"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }


    }
}

