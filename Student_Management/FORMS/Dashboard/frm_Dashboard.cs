using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            string sql = "SELECT Grade, COUNT(*) AS Quantity FROM  tbgrade" +
                " WHERE DATE(created_at) >= CURDATE() - INTERVAL 30 DAY" +
                " GROUP BY Grade";
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

        int totalGradeCount;
        private void loadEnrolledCount()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);            
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(*) AS Quantity FROM tbgrade" +
                        " WHERE DATE(created_at) >= CURDATE() - INTERVAL 30 DAY";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_Enrolled.Text = reader["Quantity"].ToString();
                totalGradeCount = reader.GetInt32("Quantity");
            }
            cmd.Dispose();
            reader.Dispose();
            conn.Close();
        }

        int totalPassCount;
        private void loadPassPercentage()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);            
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(Grade) AS Quantity FROM tbgrade" +
                        " WHERE DATE(created_at) >= CURDATE() - INTERVAL 30 DAY" +
                        " AND Grade != 'F'";
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
            double point= 0.0;
            double avgPoint;
            foreach(DataRow row in gradeDt.Rows)
            {
                switch (row["Grade"].ToString())
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
            string sql = "SELECT DISTINCT tbcourse.Name AS Course FROM tbschedule" +
                           " JOIN tbgrade ON tbgrade.id = tbschedule.GradeId" +
                           " JOIN tbcourse ON tbcourse.id = tbgrade.CourseId" +
                           " WHERE tbgrade.Grade IS NULL AND DATE(created_at) >= CURDATE() - INTERVAL 30 DAY" +
                           " ORDER BY tbschedule.id DESC LIMIT 3";
            cmd.CommandText = sql;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);    
            string course1, course2, course3;
            if (dt != null && dt.Rows.Count >= 1)
            {
                course1 = dt.Rows[0]["Course"].ToString();
                if(dt.Rows.Count == 2) {
                    course2 = dt.Rows[1]["Course"].ToString();
                    course3 = "";
                }
                else
                {
                    course2 = dt.Rows[1]["Course"].ToString();
                    course3 = dt.Rows[2]["Course"].ToString();
                }
                // Tab
                lbl_Ongoing.Text = string.Format("1. {0,-25}\t 2. {1,-25}\t 3. {2,-25}", course1, course2, course3);
            }
            else
            {
                // Handle the case where there are not enough rows or the DataTable is null
                lbl_Ongoing.Text = "No recent courses available.";
            }
            da.Dispose();
            cmd.Dispose();            
            conn.Close();
        }

        int totalNotNullGrade;
        private void loadExamProgress()
        {
            string connstring = frm_Main.connstring;
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "SELECT COUNT(Grade) AS Quantity FROM tbgrade" +
                        " WHERE DATE(created_at) >= CURDATE() - INTERVAL 30 DAY";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();            
            if (reader.Read())
            {
                totalNotNullGrade = reader.GetInt32("Quantity");
            }
            if (totalGradeCount > 0)
            {
                double percent = ((double)totalNotNullGrade / (double)totalGradeCount) * 100;
                int roundPercent = (int)Math.Round(percent);
                examProgress.Percentage = roundPercent;
            }
            else
            {
                examProgress.Percentage = 0;
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }



    }
}

