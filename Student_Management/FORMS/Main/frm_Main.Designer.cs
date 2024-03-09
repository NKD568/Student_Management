﻿namespace Student_Management.FORMS.Main
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Topbar = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient_SidebarPanel1 = new Student_Management.FORMS.Main.Gradient_SidebarPanel();
            this.Schedule = new Student_Management.FORMS.Main.ucMenu();
            this.Student = new Student_Management.FORMS.Main.ucMenu();
            this.Course = new Student_Management.FORMS.Main.ucMenu();
            this.Grade = new Student_Management.FORMS.Main.ucMenu();
            this.Topbar.SuspendLayout();
            this.gradient_SidebarPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Topbar.Controls.Add(this.nightControlBox1);
            this.Topbar.Controls.Add(this.label1);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(1200, 34);
            this.Topbar.TabIndex = 0;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1061, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management Application";
            // 
            // gradient_SidebarPanel1
            // 
            this.gradient_SidebarPanel1.Controls.Add(this.Schedule);
            this.gradient_SidebarPanel1.Controls.Add(this.Student);
            this.gradient_SidebarPanel1.Controls.Add(this.Course);
            this.gradient_SidebarPanel1.Controls.Add(this.Grade);
            this.gradient_SidebarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient_SidebarPanel1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(130)))));
            this.gradient_SidebarPanel1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.gradient_SidebarPanel1.Location = new System.Drawing.Point(0, 34);
            this.gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            this.gradient_SidebarPanel1.Size = new System.Drawing.Size(100, 716);
            this.gradient_SidebarPanel1.TabIndex = 1;
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.Transparent;
            this.Schedule.BorderColor = System.Drawing.Color.Transparent;
            this.Schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schedule.Icon = global::Student_Management.Properties.Resources.schedule_24;
            this.Schedule.Location = new System.Drawing.Point(3, 314);
            this.Schedule.Menu = "Schedule";
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(94, 52);
            this.Schedule.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.Transparent;
            this.Student.BorderColor = System.Drawing.Color.Transparent;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.Icon = global::Student_Management.Properties.Resources.student_24;
            this.Student.Location = new System.Drawing.Point(3, 239);
            this.Student.Menu = "Student";
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(94, 52);
            this.Student.TabIndex = 0;
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.Transparent;
            this.Course.BorderColor = System.Drawing.Color.Transparent;
            this.Course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Course.Icon = global::Student_Management.Properties.Resources.book_24;
            this.Course.Location = new System.Drawing.Point(3, 162);
            this.Course.Menu = "Course";
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(94, 52);
            this.Course.TabIndex = 0;
            // 
            // Grade
            // 
            this.Grade.BackColor = System.Drawing.Color.Transparent;
            this.Grade.BorderColor = System.Drawing.Color.Transparent;
            this.Grade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grade.Icon = global::Student_Management.Properties.Resources.grade_24;
            this.Grade.Location = new System.Drawing.Point(3, 90);
            this.Grade.Menu = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(94, 52);
            this.Grade.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.gradient_SidebarPanel1);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.gradient_SidebarPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Gradient_SidebarPanel gradient_SidebarPanel1;
        private ucMenu Schedule;
        private ucMenu Student;
        private ucMenu Course;
        private ucMenu Grade;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}