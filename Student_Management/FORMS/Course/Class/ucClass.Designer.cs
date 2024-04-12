namespace Student_Management.FORMS.Course
{
    partial class ucClass
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
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatedTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_State = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Options = new System.Windows.Forms.PictureBox();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Course: ";
            // 
            // lbl_Course
            // 
            this.lbl_Course.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(87, 58);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(221, 28);
            this.lbl_Course.TabIndex = 21;
            // 
            // optionMenu
            // 
            this.optionMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.optionMenu.Name = "contextMenuStrip1";
            this.optionMenu.Size = new System.Drawing.Size(204, 100);
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Image = global::Student_Management.Properties.Resources.info_32;
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Student_Management.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Student_Management.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updatedTimer
            // 
            this.updatedTimer.Tick += new System.EventHandler(this.updatedTimer_Tick);
            // 
            // lbl_State
            // 
            this.lbl_State.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(92, 141);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(216, 28);
            this.lbl_State.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "State:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(15, 17);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 12);
            this.lbl_Id.TabIndex = 25;
            this.lbl_Id.Visible = false;
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Options.Image = global::Student_Management.Properties.Resources.options;
            this.btn_Options.Location = new System.Drawing.Point(328, 4);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(24, 24);
            this.btn_Options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Options.TabIndex = 23;
            this.btn_Options.TabStop = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacity.Location = new System.Drawing.Point(92, 99);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(216, 28);
            this.lbl_Capacity.TabIndex = 21;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(87, 17);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(221, 28);
            this.lbl_Name.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name: ";
            // 
            // ucClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Capacity);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_Options);
            this.Name = "ucClass";
            this.Size = new System.Drawing.Size(355, 190);
            this.Load += new System.EventHandler(this.ucClassCard_Load);
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
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.PictureBox btn_Options;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label5;
    }
}
