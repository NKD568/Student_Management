namespace Student_Management.FORMS.Course
{
    partial class ucCourse
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
            this.optionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.updatedTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_isOpen = new System.Windows.Forms.Label();
            this.btn_Options = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Credits = new System.Windows.Forms.Label();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name: ";
            // 
            // optionMenu
            // 
            this.optionMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.optionMenu.Name = "contextMenuStrip1";
            this.optionMenu.Size = new System.Drawing.Size(143, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Student_Management.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Student_Management.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(72, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(231, 28);
            this.lbl_Name.TabIndex = 12;
            // 
            // updatedTimer
            // 
            this.updatedTimer.Tick += new System.EventHandler(this.updatedTimer_Tick);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AnimateReadOnly = false;
            this.lbl_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lbl_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Description.Depth = 0;
            this.lbl_Description.Enabled = false;
            this.lbl_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.HideSelection = true;
            this.lbl_Description.Location = new System.Drawing.Point(20, 71);
            this.lbl_Description.MaxLength = 32767;
            this.lbl_Description.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.PasswordChar = '\0';
            this.lbl_Description.ReadOnly = false;
            this.lbl_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_Description.SelectedText = "";
            this.lbl_Description.SelectionLength = 0;
            this.lbl_Description.SelectionStart = 0;
            this.lbl_Description.ShortcutsEnabled = true;
            this.lbl_Description.Size = new System.Drawing.Size(308, 64);
            this.lbl_Description.TabIndex = 16;
            this.lbl_Description.TabStop = false;
            this.lbl_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lbl_Description.UseSystemPasswordChar = false;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(15, 6);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 12);
            this.lbl_Id.TabIndex = 17;
            this.lbl_Id.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Open:";
            // 
            // lbl_isOpen
            // 
            this.lbl_isOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isOpen.Location = new System.Drawing.Point(77, 138);
            this.lbl_isOpen.Name = "lbl_isOpen";
            this.lbl_isOpen.Size = new System.Drawing.Size(85, 28);
            this.lbl_isOpen.TabIndex = 19;
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Options.Image = global::Student_Management.Properties.Resources.options;
            this.btn_Options.Location = new System.Drawing.Point(328, 3);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(24, 24);
            this.btn_Options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Options.TabIndex = 15;
            this.btn_Options.TabStop = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Credits: ";
            // 
            // lbl_Credits
            // 
            this.lbl_Credits.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credits.Location = new System.Drawing.Point(247, 138);
            this.lbl_Credits.Name = "lbl_Credits";
            this.lbl_Credits.Size = new System.Drawing.Size(81, 28);
            this.lbl_Credits.TabIndex = 19;
            // 
            // ucCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.lbl_Credits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_isOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.lbl_Name);
            this.Name = "ucCourse";
            this.Size = new System.Drawing.Size(355, 190);
            this.Load += new System.EventHandler(this.ucCourse_Load);
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip optionMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox btn_Options;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Timer updatedTimer;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 lbl_Description;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_isOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Credits;
    }
}
