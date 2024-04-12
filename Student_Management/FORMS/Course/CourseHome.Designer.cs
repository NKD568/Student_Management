namespace Student_Management.FORMS.Course
{
    partial class CourseHome
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
            this.tabCtrl_Home = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage_Class = new System.Windows.Forms.TabPage();
            this.tabPage_Course = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabCtrl_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl_Home
            // 
            this.tabCtrl_Home.Controls.Add(this.tabPage_Class);
            this.tabCtrl_Home.Controls.Add(this.tabPage_Course);
            this.tabCtrl_Home.Depth = 0;
            this.tabCtrl_Home.Location = new System.Drawing.Point(12, 27);
            this.tabCtrl_Home.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabCtrl_Home.Multiline = true;
            this.tabCtrl_Home.Name = "tabCtrl_Home";
            this.tabCtrl_Home.SelectedIndex = 0;
            this.tabCtrl_Home.Size = new System.Drawing.Size(1201, 786);
            this.tabCtrl_Home.TabIndex = 0;
            // 
            // tabPage_Class
            // 
            this.tabPage_Class.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Class.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Class.Name = "tabPage_Class";
            this.tabPage_Class.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Class.Size = new System.Drawing.Size(1193, 753);
            this.tabPage_Class.TabIndex = 0;
            this.tabPage_Class.Text = "Class";
            this.tabPage_Class.UseVisualStyleBackColor = true;
            // 
            // tabPage_Course
            // 
            this.tabPage_Course.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Course.Name = "tabPage_Course";
            this.tabPage_Course.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Course.Size = new System.Drawing.Size(1193, 753);
            this.tabPage_Course.TabIndex = 1;
            this.tabPage_Course.Text = "Course";
            this.tabPage_Course.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabCtrl_Home;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Upper;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(412, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(375, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.TabIndicatorHeight = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // CourseHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1225, 825);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabCtrl_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_courseHome";
            this.tabCtrl_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabCtrl_Home;
        private System.Windows.Forms.TabPage tabPage_Class;
        private System.Windows.Forms.TabPage tabPage_Course;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}