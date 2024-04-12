using Mysqlx.Crud;
using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Enrollment;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Recheck;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Grade
{
    public partial class frm_Grade : Form
    {
        public List<string> grades = new List<string>() {"A", "B+", "B", "C+" ,"C", "D", "F"};
        public frm_Grade()
        {
            InitializeComponent();
        }

        string lastProgress;
        string lastMidterm;
        string lastFinal;
        string lastOverall;
        private void btn_EditMode_ToggledChanged()
        {
            txt_Progress.ReadOnly = !txt_Progress.ReadOnly;
            txt_Midterm.ReadOnly = !txt_Midterm.ReadOnly;
            txt_Final.ReadOnly = !txt_Final.ReadOnly;
            btn_Save.Visible = !btn_Save.Visible;

            if(btn_EditMode.Toggled == false)
            {
                if (!isValid)
                {
                    txt_Progress.Text = lastProgress;
                    txt_Midterm.Text = lastMidterm;
                    txt_Final.Text = lastFinal;
                    txt_Overall.Text = lastOverall;
                }
            }
            else
            {
                isValid = false;
                lastProgress = txt_Progress.Text;
                lastMidterm = txt_Midterm.Text;
                lastFinal = txt_Final.Text;
                lastOverall = txt_Overall.Text;
            }
        }

        private void btn_Recheck_Click(object sender, EventArgs e)
        {
            RecheckInfo save = new RecheckInfo();
            GradeInfo get = new GradeInfo();
            DataTable dt = get.getDetails(ucEnrollment.public_id);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    save.grade_id = dr["id"].ToString();
                    save.Save();
                }
            }
            btn_Recheck.Enabled = false;
        }

        private void grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+' ||
                 txt.TextLength >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        bool isValid = false;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool validProgress = grades.Contains(txt_Progress.Text);
            bool validMidterm = grades.Contains(txt_Midterm.Text);
            bool validFinal = grades.Contains(txt_Final.Text);
            if(!validProgress || !validMidterm || !validFinal)
            {
                MessageBox.Show("Invalid Grade!\nOnly: A, B+, B, C+, C, D, F");
                return;
            }
            else
            {
                isValid = true;
                if (ucEnrollment.gradeChecking == true)
                {
                    RecheckInfo remove = new RecheckInfo();
                    remove.removeRecheck(lbl_ProgressId.Text);
                    remove.removeRecheck(lbl_MidtermId.Text);
                    remove.removeRecheck(lbl_FinalId.Text);
                    remove.removeRecheck(lbl_OverallId.Text);
                }
                if (txt_Progress.Text != lastProgress || txt_Midterm.Text != lastMidterm ||
                   txt_Final.Text != lastFinal || txt_Overall.Text != lastOverall)
                {
                    if(lastProgress == String.Empty && lastMidterm == String.Empty &&
                       lastFinal == String.Empty && lastOverall == String.Empty)
                    {
                        update = false;
                    }
                    else
                    {
                        update = true;
                    }
                }
                backgroundWorker1.RunWorkerAsync();
            }
        }

        bool update = false;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm_Main notify = new frm_Main();
            if (update == false)
            {
                GradeInfo save = new GradeInfo();
                save.enrollment_id = ucEnrollment.public_id;              
                save.type = lbl_Progress.Text;
                save.grade = txt_Progress.Text;
                save.Save();
                save.type = lbl_Midterm.Text;
                save.grade = txt_Midterm.Text;
                save.Save();
                save.type = lbl_Final.Text;
                save.grade = txt_Final.Text;
                save.Save();
                save.type = lbl_Overall.Text;
                save.grade = txt_Overall.Text;
                save.Save();
                notify.showToast("SUCESS", "Sucessfully Saved");
            }
            else
            {
                GradeInfo up = new GradeInfo();
                up.enrollment_id = ucEnrollment.public_id;
                if (txt_Progress.Text != lastProgress)
                {
                    up.type = lbl_Progress.Text;
                    up.grade = txt_Progress.Text;
                    up.update(up.enrollment_id, up.type, up.grade);
                }
                if (txt_Midterm.Text != lastMidterm)
                {
                    up.type = lbl_Midterm.Text;
                    up.grade = txt_Midterm.Text;
                    up.update(up.enrollment_id, up.type, up.grade);
                }
                if (txt_Final.Text != lastFinal)
                {
                    up.type = lbl_Final.Text;
                    up.grade = txt_Final.Text;
                    up.update(up.enrollment_id, up.type, up.grade);
                }
                if (txt_Overall.Text != lastOverall)
                {
                    up.type = lbl_Overall.Text;
                    up.grade = txt_Overall.Text;
                    up.update(up.enrollment_id, up.type, up.grade);
                }
                notify.showToast("SUCESS", "Sucessfully Updated");
            }
        }

        private void frm_Grade_Load(object sender, EventArgs e)
        {
            txt_Progress.Text = txt_Midterm.Text = txt_Final.Text = txt_Overall.Text = String.Empty;
            getDetails();
            if(frm_Enrollment.isClassSide == false && txt_Progress.Text != String.Empty &&
                txt_Midterm.Text != String.Empty && txt_Final.Text != String.Empty && txt_Overall.Text != String.Empty)
            {
                btn_Recheck.Visible = true;
                RecheckInfo get = new RecheckInfo();
                bool isSentProgress = get.checkRecheckSent(lbl_ProgressId.Text);
                bool isSentMidterm = get.checkRecheckSent(lbl_MidtermId.Text);
                bool isSentFinal = get.checkRecheckSent(lbl_FinalId.Text);
                bool isSentOverall = get.checkRecheckSent(lbl_OverallId.Text);
                if(isSentProgress || isSentMidterm || isSentFinal || isSentOverall)
                {
                    btn_Recheck.Enabled = false;
                }
                else
                {
                    btn_Recheck.Enabled = true;
                }
            }
            if(frm_Login.userLevel == 0)
            {
                btn_Recheck.Visible = false;
                lbl_EditMode.Visible = false;
                btn_EditMode.Visible = false;
            }
        }

        private void getDetails()
        {
            GradeInfo get = new GradeInfo();
            DataTable dt = get.getDetails(ucEnrollment.public_id);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    if (dr["type"].ToString() == lbl_Progress.Text)
                    {
                        lbl_ProgressId.Text = dr["id"].ToString();
                        txt_Progress.Text = dr["grade"].ToString();
                    }else if (dr["type"].ToString() == lbl_Midterm.Text)
                    {
                        lbl_MidtermId.Text = dr["id"].ToString();
                        txt_Midterm.Text = dr["grade"].ToString();
                    }
                    else if (dr["type"].ToString() == lbl_Final.Text)
                    {
                        lbl_FinalId.Text = dr["id"].ToString();
                        txt_Final.Text = dr["grade"].ToString();
                    }
                    else
                    {
                        lbl_OverallId.Text = dr["id"].ToString();
                        txt_Overall.Text = dr["grade"].ToString();
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validateTimer_Tick(object sender, EventArgs e)
        {
            bool validProgress = grades.Contains(txt_Progress.Text);
            bool validMidterm = grades.Contains(txt_Midterm.Text);
            bool validFinal = grades.Contains(txt_Final.Text);
            if (validProgress && validMidterm && validFinal)
            {
                calculateOverall();
            }
            else
            {
                txt_Overall.Text = String.Empty;
            }
            validateTimer.Stop();
        }

        private void grade_TextChanged(object sender, EventArgs e)
        {
            validateTimer.Start();
        }

        private void calculateOverall()
        {
            double progress = GradeToPoint(txt_Progress.Text);
            double midterm = GradeToPoint(txt_Midterm.Text);
            double final = GradeToPoint(txt_Final.Text);

            // Extract the percentage value and convert it to a double
            string percentText = lbl_ProgressPercent.Text.Trim('%'); // Remove the percentage sign
            double progressPercent = double.Parse(percentText) / 100.0; // Convert to a double and divide by 100 to get the decimal value
            percentText = lbl_MidTermPercent.Text.Trim('%');
            double midtermPercent = double.Parse(percentText) / 100.0;
            percentText = lbl_FinalPercent.Text.Trim('%');
            double finalPercent = double.Parse(percentText) / 100.0;

            double overall = progress * progressPercent + midterm * midtermPercent + final * finalPercent;
            txt_Overall.Text = PointToGrade(overall);
        }

        // Define a method to convert grades to points
        private double GradeToPoint(string grade)
        {
            switch (grade)
            {
                case "A": return 4.0;
                case "B+": return 3.5;
                case "B": return 3.0;
                case "C+": return 2.5;
                case "C": return 2.0;
                case "D": return 1.0;
                case "F": return 0.0;
                default: return 0.0; // Handle unknown grades
            }
        }

        private string PointToGrade(double avgPoint)
        {
            if (avgPoint >= 0.0 && avgPoint < 1.0)
            {
                return "F";
            }
            else if (avgPoint >= 1.0 && avgPoint < 2.0)
            {
                return "D";
            }
            else if (avgPoint >= 2.0 && avgPoint < 2.5)
            {
                return "C";
            }
            else if (avgPoint >= 2.5 && avgPoint < 3.0)
            {
                return "C+";
            }
            else if (avgPoint >= 3.0 && avgPoint < 3.5)
            {
                return "B";
            }
            else if (avgPoint >= 3.5 && avgPoint < 4.0)
            {
                return "B+";
            }
            else if (avgPoint == 4.0)
            {
                return "A";
            }
            else
            {
                return "Invalid"; // or throw an exception
            }
        }


    }
}
