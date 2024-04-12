using MySql.Data.MySqlClient;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
        public string tableName = "schedules";
        string tableAttributes = "(enrollment_id,type,date)";

        public string id { get; set; }
        public string enrollment_id { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public EnrollmentInfo enrollment_info = new EnrollmentInfo();
        public static List<ScheduleInfo> oneDateEventList = new List<ScheduleInfo>();

        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "INSERT INTO " + tableName + tableAttributes + "VALUES(?,?,?)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("enrollment_id", this.enrollment_id);
            cmd.Parameters.AddWithValue("type", this.type);
            cmd.Parameters.AddWithValue("date", this.date);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void update(string _enrollment_id, string _type, DateTime _date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "UPDATE " + tableName + " SET type = @type, date = @date WHERE enrollment_id = @enrollment_id";
            cmd.Parameters.AddWithValue("@enrollment_id", _enrollment_id);
            cmd.Parameters.AddWithValue("@type", _type);
            cmd.Parameters.AddWithValue("@date", _date);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void delete(string _id)
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
                cmd.Parameters.AddWithValue("@id", _id);
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

        public void deleteAllEventDate(DateTime _date)
        {
            // ID is being used for foreign key Exception
            frm_Main get = new frm_Main();
            try
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM " + tableName + " WHERE date = @date";
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

        public void getList()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName;
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            oneDateEventList.Clear();
            if (reader.HasRows)
            {
                DateTime lastDate = getMinDate().AddDays(-1);
                while (reader.Read())
                {
                    date = reader.GetDateTime("date");
                    if (date != lastDate)
                    {
                        ScheduleInfo details = new ScheduleInfo
                        {
                            id = reader["id"].ToString(),
                            enrollment_id = reader["enrollment_id"].ToString(),
                            type = reader["type"].ToString(),
                            date = reader.GetDateTime("date"),
                        };
                        details.enrollment_info.getDetails(details.enrollment_id);
                        oneDateEventList.Add(details);
                        lastDate = details.date;
                    }
                    else
                    {
                        continue;
                    }
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        // Get Student Event
        public void getListStudentEvent(string _studentId)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT schedules.* FROM schedules" +
                        " JOIN enrollments ON enrollments.id = schedules.enrollment_id" +
                        " JOIN students ON students.id = enrollments.student_id" +
                        " WHERE students.id = @student_id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@student_id", _studentId);
            MySqlDataReader reader = cmd.ExecuteReader();
            oneDateEventList.Clear();
            if (reader.HasRows)
            {
                DateTime lastDate = getMinDate().AddDays(-1);
                while (reader.Read())
                {
                    date = reader.GetDateTime("date");
                    if (date != lastDate)
                    {
                        ScheduleInfo details = new ScheduleInfo
                        {
                            id = reader["id"].ToString(),
                            enrollment_id = reader["enrollment_id"].ToString(),
                            type = reader["type"].ToString(),
                            date = reader.GetDateTime("date"),
                        };
                        details.enrollment_info.getDetails(details.enrollment_id);
                        oneDateEventList.Add(details);
                        lastDate = details.date;
                    }
                    else
                    {
                        continue;
                    }
                }
                cmd.Dispose();
                reader.Dispose();
                conn.Close();
            }
        }

        public void getDetails(string details_id)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", details_id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                enrollment_id = reader["enrollment_id"].ToString();
                type = reader["type"].ToString();
                date = reader.GetDateTime("date");
                enrollment_info.getDetails(enrollment_id);
            }
            else
            {
                enrollment_id = "";
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        public bool checkValidClass(string _name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT classes.id FROM classes" +
                " JOIN enrollments ON enrollments.class_id = classes.id" +
                " WHERE classes.name = @name AND classes.state = @state";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@state", "Ongoing");
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

        public bool checkDuplicateEvent(string _event)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName +
                " JOIN enrollments ON enrollments.id = schedules.enrollment_id" +
                " JOIN classes ON classes.id = enrollments.class_id" +
                " WHERE classes.name = @event";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@event", _event);
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

        public bool checkOccupiedDate(DateTime _date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE date = @date";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", _date);
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

        // Get All Student in Class
        public DataTable getEnrollmentIds(string _class_name)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT enrollments.id FROM enrollments" +
                        " JOIN classes ON classes.id = enrollments.class_id WHERE classes.name = @name";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", _class_name);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            return dt;

        }

        // Get 1 Event in Date
        public void getDateDetails(DateTime details_date)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT * FROM " + tableName + " WHERE date = @date";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", details_date);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader["id"].ToString();
                enrollment_id = reader["enrollment_id"].ToString();
                type = reader["type"].ToString();
                date = reader.GetDateTime("date");
                enrollment_info.getDetails(enrollment_id);
            }
            else
            {
                id = String.Empty;
            }
            cmd.Dispose();
            conn.Close();
            conn.Close();
        }

        public DateTime getMinDate()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT COALESCE(MIN(date), CURRENT_DATE) AS minDate FROM schedules";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            DateTime minDate;
            if (reader.HasRows)
            {
                reader.Read();
                minDate = Convert.ToDateTime(reader["minDate"]);
            }
            else
            {
                minDate = DateTime.Today;
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
            return minDate;
        }



    }
}
