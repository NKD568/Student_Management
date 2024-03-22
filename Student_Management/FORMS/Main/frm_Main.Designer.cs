namespace Student_Management.FORMS.Main
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
            this.menuSidebar = new Student_Management.FORMS.Main.Gradient_SidebarPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuDashboard = new Student_Management.FORMS.Main.ucMenu();
            this.menuGrade = new Student_Management.FORMS.Main.ucMenu();
            this.menuCourse = new Student_Management.FORMS.Main.ucMenu();
            this.menuStudent = new Student_Management.FORMS.Main.ucMenu();
            this.menuSchedule = new Student_Management.FORMS.Main.ucMenu();
            this.menuAccount = new Student_Management.FORMS.Main.ucMenu();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.Topbar.SuspendLayout();
            this.menuSidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
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
            this.Topbar.Size = new System.Drawing.Size(1300, 34);
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
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1161, 0);
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
            // menuSidebar
            // 
            this.menuSidebar.Controls.Add(this.menuContainer);
            this.menuSidebar.Controls.Add(this.smallLabel1);
            this.menuSidebar.Controls.Add(this.headerLabel1);
            this.menuSidebar.Controls.Add(this.logoApp);
            this.menuSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuSidebar.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuSidebar.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuSidebar.Location = new System.Drawing.Point(0, 34);
            this.menuSidebar.Name = "menuSidebar";
            this.menuSidebar.Size = new System.Drawing.Size(107, 766);
            this.menuSidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.Controls.Add(this.menuDashboard);
            this.menuContainer.Controls.Add(this.menuGrade);
            this.menuContainer.Controls.Add(this.menuCourse);
            this.menuContainer.Controls.Add(this.menuStudent);
            this.menuContainer.Controls.Add(this.menuSchedule);
            this.menuContainer.Controls.Add(this.menuAccount);
            this.menuContainer.Location = new System.Drawing.Point(-5, 138);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(104, 625);
            this.menuContainer.TabIndex = 4;
            // 
            // menuDashboard
            // 
            this.menuDashboard.BackColor = System.Drawing.Color.Transparent;
            this.menuDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.menuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDashboard.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDashboard.Icon = global::Student_Management.Properties.Resources.dashboard_24;
            this.menuDashboard.Location = new System.Drawing.Point(5, 5);
            this.menuDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.menuDashboard.Menu = "Dashboard";
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(104, 52);
            this.menuDashboard.TabIndex = 0;
            // 
            // menuGrade
            // 
            this.menuGrade.BackColor = System.Drawing.Color.Transparent;
            this.menuGrade.BorderColor = System.Drawing.Color.Transparent;
            this.menuGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuGrade.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGrade.Icon = global::Student_Management.Properties.Resources.grade_24;
            this.menuGrade.Location = new System.Drawing.Point(10, 72);
            this.menuGrade.Margin = new System.Windows.Forms.Padding(10);
            this.menuGrade.Menu = "Grade";
            this.menuGrade.Name = "menuGrade";
            this.menuGrade.Size = new System.Drawing.Size(94, 52);
            this.menuGrade.TabIndex = 0;
            // 
            // menuCourse
            // 
            this.menuCourse.BackColor = System.Drawing.Color.Transparent;
            this.menuCourse.BorderColor = System.Drawing.Color.Transparent;
            this.menuCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuCourse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCourse.Icon = global::Student_Management.Properties.Resources.book_24;
            this.menuCourse.Location = new System.Drawing.Point(10, 144);
            this.menuCourse.Margin = new System.Windows.Forms.Padding(10);
            this.menuCourse.Menu = "Course";
            this.menuCourse.Name = "menuCourse";
            this.menuCourse.Size = new System.Drawing.Size(94, 52);
            this.menuCourse.TabIndex = 0;
            // 
            // menuStudent
            // 
            this.menuStudent.BackColor = System.Drawing.Color.Transparent;
            this.menuStudent.BorderColor = System.Drawing.Color.Transparent;
            this.menuStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStudent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStudent.Icon = global::Student_Management.Properties.Resources.student_24;
            this.menuStudent.Location = new System.Drawing.Point(10, 216);
            this.menuStudent.Margin = new System.Windows.Forms.Padding(10);
            this.menuStudent.Menu = "Student";
            this.menuStudent.Name = "menuStudent";
            this.menuStudent.Size = new System.Drawing.Size(94, 52);
            this.menuStudent.TabIndex = 0;
            // 
            // menuSchedule
            // 
            this.menuSchedule.BackColor = System.Drawing.Color.Transparent;
            this.menuSchedule.BorderColor = System.Drawing.Color.Transparent;
            this.menuSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSchedule.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSchedule.Icon = global::Student_Management.Properties.Resources.schedule_24;
            this.menuSchedule.Location = new System.Drawing.Point(10, 288);
            this.menuSchedule.Margin = new System.Windows.Forms.Padding(10);
            this.menuSchedule.Menu = "Schedule";
            this.menuSchedule.Name = "menuSchedule";
            this.menuSchedule.Size = new System.Drawing.Size(94, 52);
            this.menuSchedule.TabIndex = 0;
            // 
            // menuAccount
            // 
            this.menuAccount.BackColor = System.Drawing.Color.Transparent;
            this.menuAccount.BorderColor = System.Drawing.Color.Transparent;
            this.menuAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAccount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAccount.Icon = global::Student_Management.Properties.Resources.account_24;
            this.menuAccount.Location = new System.Drawing.Point(10, 360);
            this.menuAccount.Margin = new System.Windows.Forms.Padding(10);
            this.menuAccount.Menu = "Account";
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(94, 52);
            this.menuAccount.TabIndex = 0;
            // 
            // smallLabel1
            // 
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.Black;
            this.smallLabel1.Location = new System.Drawing.Point(1, 114);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(111, 21);
            this.smallLabel1.TabIndex = 3;
            this.smallLabel1.Text = "-------------------";
            this.smallLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel1
            // 
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel1.Location = new System.Drawing.Point(-3, 67);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(114, 56);
            this.headerLabel1.TabIndex = 2;
            this.headerLabel1.Text = "Student\r\nManagement";
            this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.Image = global::Student_Management.Properties.Resources.management_100;
            this.logoApp.Location = new System.Drawing.Point(3, 0);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(100, 75);
            this.logoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoApp.TabIndex = 1;
            this.logoApp.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.menuSidebar);
            this.Controls.Add(this.Topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.menuSidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Gradient_SidebarPanel menuSidebar;
        private ucMenu menuSchedule;
        private ucMenu menuStudent;
        private ucMenu menuCourse;
        private ucMenu menuGrade;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ucMenu menuDashboard;
        private System.Windows.Forms.PictureBox logoApp;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ucMenu menuAccount;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
    }
}