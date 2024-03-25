namespace Student_Management.FORMS.Grade
{
    partial class ucGrade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.optionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatedTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Grade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CourseId = new System.Windows.Forms.Label();
            this.btn_Options = new System.Windows.Forms.PictureBox();
            this.lbl_StuId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_StuName = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.requestRecheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Course:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id:";
            // 
            // lbl_Course
            // 
            this.lbl_Course.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(87, 102);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(221, 28);
            this.lbl_Course.TabIndex = 21;
            // 
            // optionMenu
            // 
            this.optionMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.requestRecheckToolStripMenuItem});
            this.optionMenu.Name = "contextMenuStrip1";
            this.optionMenu.Size = new System.Drawing.Size(249, 133);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Student_Management.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Student_Management.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updatedTimer
            // 
            this.updatedTimer.Tick += new System.EventHandler(this.updatedTimer_Tick);
            // 
            // lbl_Grade
            // 
            this.lbl_Grade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grade.Location = new System.Drawing.Point(77, 141);
            this.lbl_Grade.Name = "lbl_Grade";
            this.lbl_Grade.Size = new System.Drawing.Size(231, 28);
            this.lbl_Grade.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grade:";
            // 
            // lbl_CourseId
            // 
            this.lbl_CourseId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CourseId.Location = new System.Drawing.Point(55, 13);
            this.lbl_CourseId.Name = "lbl_CourseId";
            this.lbl_CourseId.Size = new System.Drawing.Size(10, 10);
            this.lbl_CourseId.TabIndex = 25;
            this.lbl_CourseId.Visible = false;
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Options.Image = global::Student_Management.Properties.Resources.options;
            this.btn_Options.Location = new System.Drawing.Point(328, 5);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(24, 24);
            this.btn_Options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Options.TabIndex = 23;
            this.btn_Options.TabStop = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // lbl_StuId
            // 
            this.lbl_StuId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StuId.Location = new System.Drawing.Point(87, 23);
            this.lbl_StuId.Name = "lbl_StuId";
            this.lbl_StuId.Size = new System.Drawing.Size(226, 28);
            this.lbl_StuId.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name:";
            // 
            // lbl_StuName
            // 
            this.lbl_StuName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StuName.Location = new System.Drawing.Point(92, 64);
            this.lbl_StuName.Name = "lbl_StuName";
            this.lbl_StuName.Size = new System.Drawing.Size(221, 28);
            this.lbl_StuName.TabIndex = 28;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(3, 13);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 10);
            this.lbl_Id.TabIndex = 29;
            this.lbl_Id.Visible = false;
            // 
            // requestRecheckToolStripMenuItem
            // 
            this.requestRecheckToolStripMenuItem.Image = global::Student_Management.Properties.Resources.search;
            this.requestRecheckToolStripMenuItem.Name = "requestRecheckToolStripMenuItem";
            this.requestRecheckToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.requestRecheckToolStripMenuItem.Text = "Request Recheck";
            this.requestRecheckToolStripMenuItem.Click += new System.EventHandler(this.requestRecheckToolStripMenuItem_Click);
            // 
            // ucGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_StuName);
            this.Controls.Add(this.lbl_StuId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_CourseId);
            this.Controls.Add(this.btn_Options);
            this.Name = "ucGrade";
            this.Size = new System.Drawing.Size(355, 190);
            this.Load += new System.EventHandler(this.ucCourse_Load);
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.ContextMenuStrip optionMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer updatedTimer;
        private System.Windows.Forms.Label lbl_Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CourseId;
        private System.Windows.Forms.PictureBox btn_Options;
        private System.Windows.Forms.Label lbl_StuId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_StuName;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ToolStripMenuItem requestRecheckToolStripMenuItem;
    }
}
