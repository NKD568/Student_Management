using MySql.Data.MySqlClient;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_Management.FORMS.Schedule
{
    public class ScheduleInfo
    {

        public string connstring = frm_Main.connstring;
        public string tableName = "tbschedule";
        string tableAttributes = "(gradeId,date)";

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
            cmd.Parameters.AddWithValue("gradeId", this.gradeId);
            cmd.Parameters.AddWithValue("date", this.date);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public DataTable getGradeIds(string course_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbgrade.id FROM tbgrade JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbcourse.Name = @Name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", course_name);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            return dt;
        }

        public void getDateDetails(DateTime details_date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT tbschedule.* ,tbcourse.Name AS Course FROM tbschedule" +
                " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId WHERE tbschedule.Date = @date LIMIT 1";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", details_date);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                id = reader.GetInt32("id");
                gradeId = reader.GetInt32("GradeId");
                date = reader.GetDateTime("Date");
                course = reader["Course"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void update(int _gradeid, DateTime _date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET GradeId = @gradeid, Date = @date WHERE Date = @date ";
            cmd.Parameters.AddWithValue("@gradeid", _gradeid);
            cmd.Parameters.AddWithValue("@date", _date);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            frm_Main get = new frm_Main();
            get.showToast("SUCCESS", "Successfully Updated");
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
                get.showToast("ERROR", "Schedule existed in other tables");
            }

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
