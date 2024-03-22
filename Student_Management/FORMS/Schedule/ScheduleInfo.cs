using MySql.Data.MySqlClient;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Mysqlx.Notice.Warning.Types;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management.FORMS.Schedule
{
    public class ScheduleInfo
    {

        public string connstring = frm_Main.connstring;
        public string tableName = "tbschedule";
        string tableAttributes = "(GradeId,Date)";

        public int id { get; set; }
        public int gradeId { get; set; }
        public string course { get; set; }
        public DateTime date { get; set; }
        public static List<ScheduleInfo> list = new List<ScheduleInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("GradeId", this.gradeId);
            cmd.Parameters.AddWithValue("Date", this.date);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void update(int _id ,int _gradeid, DateTime _date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET GradeId = @gradeid WHERE Date = @date AND id = @id";
            cmd.Parameters.AddWithValue("@gradeid", _gradeid);
            cmd.Parameters.AddWithValue("@date", _date);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void delete(DateTime _date)
        {
            // ID is being used for foreign key Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM " + tableName + " WHERE Date = @date";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@date", _date);
                cmd.ExecuteNonQuery();
                get.showToast("SUCCESS", "Successfully Deleted");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                get.showToast("ERROR", "Schedule existed in other data");
            }

        }

        public DataTable getGradeIds(string course_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbgrade.id FROM  tbgrade" +
                        " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbcourse.Name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", course_name);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            return dt;

        }

        public DataTable getEventDetails(string course_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM tbschedule" +
                " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbcourse.Name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", course_name);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            return dt;
        }

        // Get All Events
        public DataTable getDateDetails(DateTime details_date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbschedule.* ,tbcourse.Name AS Course FROM tbschedule" +
                " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbschedule.Date = @date";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", details_date);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            conn.Close();
            return dt;
        }

        // Get 1 Event
        public void getDateEvent(DateTime details_date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbcourse.Name AS Course FROM tbschedule" +
                " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbschedule.Date = @date LIMIT 1";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", details_date);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                course = reader["Course"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        // Get 1 Student Event 
        public void getStudentDate(string _studentId, DateTime details_date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbcourse.Name AS Course FROM tbschedule" +
                " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId" +
                " WHERE tbschedule.Date = @date AND tbgrade.StudentId = @studentId LIMIT 1";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@studentId", _studentId);
            cmd.Parameters.AddWithValue("@date", details_date);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                course = reader["Course"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public bool checkDateExisted(DateTime _date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM tbschedule WHERE Date = @date";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", _date);
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

        public DateTime getMinDate()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT COALESCE(MIN(Date), CURRENT_DATE) AS minDate FROM tbschedule";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            DateTime minDate = DateTime.Now;
            if (reader.Read())
            {
                minDate = Convert.ToDateTime(reader["minDate"]);
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
            return minDate;
        }



    }
}
