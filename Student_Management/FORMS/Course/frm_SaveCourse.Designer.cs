namespace Student_Management.FORMS.Course
{
    partial class frm_SaveCourse
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
            this.gpDetails = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.txt_Name = new MaterialSkin.Controls.MaterialTextBox2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar_Credits = new ReaLTaiizor.Controls.HopeTrackBar();
            this.gpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDetails
            // 
            this.gpDetails.BackColor = System.Drawing.Color.White;
            this.gpDetails.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpDetails.BorderWidth = 1;
            this.gpDetails.Controls.Add(this.trackBar_Credits);
            this.gpDetails.Controls.Add(this.materialLabel1);
            this.gpDetails.Controls.Add(this.txt_Description);
            this.gpDetails.Controls.Add(this.btn_Save);
            this.gpDetails.Controls.Add(this.txt_Name);
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(6, 30);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(570, 362);
            this.gpDetails.TabIndex = 8;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Details";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(38, 245);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Credits";
            // 
            // txt_Description
            // 
            this.txt_Description.AnimateReadOnly = false;
            this.txt_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Description.Depth = 0;
            this.txt_Description.HideSelection = true;
            this.txt_Description.Hint = "Description";
            this.txt_Description.Location = new System.Drawing.Point(41, 92);
            this.txt_Description.MaxLength = 32767;
            this.txt_Description.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PasswordChar = '\0';
            this.txt_Description.ReadOnly = false;
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Description.SelectedText = "";
            this.txt_Description.SelectionLength = 0;
            this.txt_Description.SelectionStart = 0;
            this.txt_Description.ShortcutsEnabled = true;
            this.txt_Description.Size = new System.Drawing.Size(483, 135);
            this.txt_Description.TabIndex = 7;
            this.txt_Description.TabStop = false;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Description.UseSystemPasswordChar = false;
            this.txt_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Description_KeyPress);
            this.txt_Description.Leave += new System.EventHandler(this.txt_NullCheck);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(254, 307);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "     Save     ";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.AnimateReadOnly = false;
            this.txt_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Name.Depth = 0;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Name.HideSelection = true;
            this.txt_Name.Hint = "Name";
            this.txt_Name.LeadingIcon = null;
            this.txt_Name.Location = new System.Drawing.Point(41, 38);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PrefixSuffixText = null;
            this.txt_Name.ReadOnly = false;
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.ShortcutsEnabled = true;
            this.txt_Name.Size = new System.Drawing.Size(483, 48);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Name.TrailingIcon = null;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            this.txt_Name.Leave += new System.EventHandler(this.txt_NullCheck);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // trackBar_Credits
            // 
            this.trackBar_Credits.AlwaysValueVisible = false;
            this.trackBar_Credits.BallonArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar_Credits.BallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar_Credits.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.trackBar_Credits.BaseColor = System.Drawing.Color.Azure;
            this.trackBar_Credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Credits.FillBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar_Credits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.trackBar_Credits.ForeColor = System.Drawing.Color.White;
            this.trackBar_Credits.HeadBorderColor = System.Drawing.Color.PowderBlue;
            this.trackBar_Credits.HeadColor = System.Drawing.Color.White;
            this.trackBar_Credits.Location = new System.Drawing.Point(94, 233);
            this.trackBar_Credits.MaxValue = 6;
            this.trackBar_Credits.MinValue = 1;
            this.trackBar_Credits.Name = "trackBar_Credits";
            this.trackBar_Credits.ShowValue = true;
            this.trackBar_Credits.Size = new System.Drawing.Size(430, 45);
            this.trackBar_Credits.TabIndex = 10;
            this.trackBar_Credits.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar_Credits.UnknownColor = System.Drawing.Color.White;
            this.trackBar_Credits.Value = 1;
            // 
            // frm_SaveCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 398);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveCourse";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "frm_SaveCourse";
            this.Load += new System.EventHandler(this.frm_SaveCourse_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_Description;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.HopeTrackBar trackBar_Credits;
    }
}