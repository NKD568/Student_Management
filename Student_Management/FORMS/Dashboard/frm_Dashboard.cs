using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Student_Management.FORMS.Course.Enrollment;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Student_Management.FORMS.Dashboard
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            fillChart();
            loadEnrolledCount();
            loadPassPercentage();
            loadAverageGrade();
            loadOngoingSchedule();
            loadExamProgress();
        }
 
        DataTable gradeDt;
        private void fillChart()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);
            DataSet ds = new DataSet();
            gradeDt = new DataTable();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT grade, COUNT(*) AS Quantity FROM grades" +
                " JOIN enrollments ON enrollments.id = grades.enrollment_id" +
                " WHERE DATE(enrollments.created_at) >= CURDATE() - INTERVAL 30 DAY" +
                " AND grades.type = 'Overall' GROUP BY grades.grade";
            cmd.CommandText = sql;                       
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            da.Fill(gradeDt);
            gradeChart.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            gradeChart.Series["Grade"].XValueMember = "Grade";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            gradeChart.Series["Grade"].YValueMembers = "Quantity";     
            da.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void loadEnrolledCount()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);            
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM enrollments" +
                        " WHERE DATE(created_at) >= CURDATE() - INTERVAL 30 DAY";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_Enrolled.Text = reader["Quantity"].ToString();
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        int totalGradeCount;
        private void getTotalGrade()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM grades" +
                        " JOIN enrollments ON enrollments.id = grades.enrollment_id" +
                        " WHERE DATE(enrollments.created_at) >= CURDATE() - INTERVAL 30 DAY" +
                        " AND grades.type = 'Overall' ";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                totalGradeCount = reader.GetInt32("Quantity");
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        int totalPassCount;
        private void loadPassPercentage()
        {
            getTotalGrade();
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);            
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM grades" +
                        " JOIN enrollments ON enrollments.id = grades.enrollment_id" +
                        " WHERE DATE(enrollments.created_at) >= CURDATE() - INTERVAL 30 DAY" +
                        " AND grades.grade != 'F' AND grades.type = 'Overall'";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                totalPassCount = reader.GetInt32("Quantity");
            }            
            if(totalGradeCount > 0)
            {
                double percent = ((double)totalPassCount / (double)totalGradeCount) * 100;
                int roundPercent = (int)Math.Round(percent);
                lbl_Pass.Text = roundPercent.ToString() + "%";
            }
            else
            {
                lbl_Pass.Text = 0.ToString("P");
            }          
       
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        private void loadAverageGrade()
        {
            double sumPoint, sumPoints = 0.0;
            double point = 0.0;
            double avgPoint;
            foreach(DataRow row in gradeDt.Rows)
            {
                switch (row["grade"].ToString())
                {
                    case "A": point = 4.0;  break;
                    case "B+": point = 3.5;  break;
                    case "B": point = 3.0;  break;
                    case "C+": point = 2.5;  break;
                    case "C": point = 2.0;  break;
                    case "D": point = 1.0;  break;
                    case "F": point = 0.0;  break;                     
                }
                sumPoint = point * Convert.ToInt32(row["Quantity"]);
                sumPoints += sumPoint;
            }
            avgPoint = sumPoints / (double)totalGradeCount;
            if(avgPoint >= 0.0 && avgPoint < 1.0)
            {
                lbl_Average.Text = "F";
            }else if(avgPoint >= 1.0 && avgPoint < 2.0)
            {
                lbl_Average.Text = "D";
            }else if(avgPoint >= 2.0 && avgPoint < 2.5)
            {
                lbl_Average.Text = "C";
            }else if(avgPoint >= 2.5 && avgPoint < 3.0)
            {
                lbl_Average.Text = "C+";
            }else if(avgPoint >= 3.0 && avgPoint < 3.5)
            {
                lbl_Average.Text = "B";
            }else if(avgPoint >= 3.5 && avgPoint < 4.0)
            {
                lbl_Average.Text = "B+";
            }
            else if(avgPoint == 4.0)
            {
                lbl_Average.Text = "A";
            }
        }

        private void loadOngoingSchedule()
        {
            string connstring = frm_Main.connstring;
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT DISTINCT classes.name AS Class FROM schedules" +
                           " JOIN enrollments ON enrollments.id = schedules.enrollment_id" +
                           " JOIN classes ON classes.id = enrollments.class_id" +
                           " WHERE schedules.type = 'Exam' AND DATE(created_at) >= CURDATE() - INTERVAL 30 DAY" +
                           " ORDER BY schedules.id DESC LIMIT 3";
            cmd.CommandText = sql;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);    
            string event1, event2, event3;
            if (dt != null && dt.Rows.Count > 0)
            {
                switch (dt.Rows.Count)
                {
                    default:
                        event1 = event2 = event3 = String.Empty;
                        break;
                    case 1: 
                        event1 = dt.Rows[0]["Class"].ToString();
                        event2 = event3 = String.Empty;
                        break;
                    case 2: 
                        event1 = dt.Rows[0]["Class"].ToString();
                        event2 = dt.Rows[1]["Class"].ToString();
                        event3 = String.Empty;
                        break;
                    case 3:
                        event1 = dt.Rows[0]["Class"].ToString();
                        event2 = dt.Rows[1]["Class"].ToString();
                        event3 = dt.Rows[2]["Class"].ToString();
                        break;
                }
                // Tab
                lbl_Ongoing.Text = string.Format("1. {0,-25}\t 2. {1,-25}\t 3. {2,-25}", event1, event2, event3);
            }
            else
            {
                // Handle the case where there are not enough rows or the DataTable is null
                lbl_Ongoing.Text = "No recent events available.";
            }
            da.Dispose();
            cmd.Dispose();            
            conn.Close();
        }

        private void loadExamProgress()
        {
            getTotalSchedule();
            getTotalExamSchedule();
            if (totalSchedule > 0)
            {
                double percent = ((double)totalExamSchedule / (double)totalSchedule) * 100;
                int roundPercent = (int)Math.Round(percent);
                examProgress.Percentage = roundPercent;
            }
            else
            {
                examProgress.Percentage = 0;
            }
        }

        int totalSchedule;
        private void getTotalSchedule()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM schedules" +
                        " JOIN enrollments ON enrollments.id = schedules.enrollment_id" +
                        " WHERE DATE(enrollments.created_at) >= CURDATE() - INTERVAL 30 DAY";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                totalSchedule = reader.GetInt32("Quantity");
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        int totalExamSchedule;
        private void getTotalExamSchedule()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM schedules" +
                        " JOIN enrollments ON enrollments.id = schedules.enrollment_id" +
                        " WHERE DATE(enrollments.created_at) >= CURDATE() - INTERVAL 30 DAY" +
                        " AND schedules.type = 'Exam' ";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                totalExamSchedule = reader.GetInt32("Quantity");
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }


    }
}

