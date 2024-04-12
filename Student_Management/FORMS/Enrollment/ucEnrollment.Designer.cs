namespace Student_Management.FORMS.Course
{
    partial class ucEnrollment
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
            this.lbl_ContentA = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NameA = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_NameB = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ContentB = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Id = new MaterialSkin.Controls.MaterialLabel();
            this.optionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Options = new System.Windows.Forms.PictureBox();
            this.updatedTimer = new System.Windows.Forms.Timer(this.components);
            this.viewGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ContentA
            // 
            this.lbl_ContentA.Depth = 0;
            this.lbl_ContentA.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ContentA.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_ContentA.Location = new System.Drawing.Point(111, 12);
            this.lbl_ContentA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ContentA.Name = "lbl_ContentA";
            this.lbl_ContentA.Size = new System.Drawing.Size(337, 23);
            this.lbl_ContentA.TabIndex = 17;
            // 
            // lbl_NameA
            // 
            this.lbl_NameA.Depth = 0;
            this.lbl_NameA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_NameA.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_NameA.Location = new System.Drawing.Point(49, 16);
            this.lbl_NameA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_NameA.Name = "lbl_NameA";
            this.lbl_NameA.Size = new System.Drawing.Size(56, 24);
            this.lbl_NameA.TabIndex = 18;
            this.lbl_NameA.Text = "Name";
            // 
            // lbl_NameB
            // 
            this.lbl_NameB.Depth = 0;
            this.lbl_NameB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_NameB.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_NameB.Location = new System.Drawing.Point(454, 16);
            this.lbl_NameB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_NameB.Name = "lbl_NameB";
            this.lbl_NameB.Size = new System.Drawing.Size(53, 24);
            this.lbl_NameB.TabIndex = 18;
            this.lbl_NameB.Text = "Id";
            // 
            // lbl_ContentB
            // 
            this.lbl_ContentB.Depth = 0;
            this.lbl_ContentB.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ContentB.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_ContentB.Location = new System.Drawing.Point(520, 14);
            this.lbl_ContentB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ContentB.Name = "lbl_ContentB";
            this.lbl_ContentB.Size = new System.Drawing.Size(358, 22);
            this.lbl_ContentB.TabIndex = 17;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Depth = 0;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Id.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_Id.Location = new System.Drawing.Point(24, 16);
            this.lbl_Id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 19);
            this.lbl_Id.TabIndex = 21;
            this.lbl_Id.Visible = false;
            // 
            // optionMenu
            // 
            this.optionMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGradesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Options.Image = global::Student_Management.Properties.Resources.options;
            this.btn_Options.Location = new System.Drawing.Point(884, 11);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(24, 24);
            this.btn_Options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Options.TabIndex = 20;
            this.btn_Options.TabStop = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // updatedTimer
            // 
            this.updatedTimer.Tick += new System.EventHandler(this.updatedTimer_Tick);
            // 
            // viewGradesToolStripMenuItem
            // 
            this.viewGradesToolStripMenuItem.Image = global::Student_Management.Properties.Resources.info_32;
            this.viewGradesToolStripMenuItem.Name = "viewGradesToolStripMenuItem";
            this.viewGradesToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.viewGradesToolStripMenuItem.Text = "View Grades";
            this.viewGradesToolStripMenuItem.Click += new System.EventHandler(this.viewGradesToolStripMenuItem_Click);
            // 
            // ucEnrollment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.lbl_ContentB);
            this.Controls.Add(this.lbl_NameB);
            this.Controls.Add(this.lbl_ContentA);
            this.Controls.Add(this.lbl_NameA);
            this.Name = "ucEnrollment";
            this.Size = new System.Drawing.Size(920, 50);
            this.Load += new System.EventHandler(this.ucEnrollment_Load);
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_ContentA;
        private MaterialSkin.Controls.MaterialLabel lbl_NameA;
        private System.Windows.Forms.PictureBox btn_Options;
        private MaterialSkin.Controls.MaterialLabel lbl_NameB;
        private MaterialSkin.Controls.MaterialLabel lbl_ContentB;
        private MaterialSkin.Controls.MaterialLabel lbl_Id;
        private System.Windows.Forms.ContextMenuStrip optionMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer updatedTimer;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGradesToolStripMenuItem;
    }
}
