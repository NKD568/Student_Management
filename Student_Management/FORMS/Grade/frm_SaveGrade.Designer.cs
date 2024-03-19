namespace Student_Management.FORMS.Grade
{
    partial class frm_SaveGrade
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
            this.gpCourseInfo = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.searchResultCourName = new System.Windows.Forms.DataGridView();
            this.resultCourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CourseName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_CourseState = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.gpGradeInfo = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.lbl_leftInQueue = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_Grade = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_getNext = new MaterialSkin.Controls.MaterialButton();
            this.gpStudentInfo = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.searchResultStuId = new System.Windows.Forms.DataGridView();
            this.resultStuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_StudentId = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_StudentName = new MaterialSkin.Controls.MaterialTextBox2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultCourName)).BeginInit();
            this.gpGradeInfo.SuspendLayout();
            this.gpStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultStuId)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCourseInfo
            // 
            this.gpCourseInfo.BackColor = System.Drawing.Color.White;
            this.gpCourseInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpCourseInfo.BorderWidth = 1;
            this.gpCourseInfo.Controls.Add(this.searchResultCourName);
            this.gpCourseInfo.Controls.Add(this.txt_CourseName);
            this.gpCourseInfo.Controls.Add(this.txt_CourseState);
            this.gpCourseInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCourseInfo.Location = new System.Drawing.Point(21, 27);
            this.gpCourseInfo.Name = "gpCourseInfo";
            this.gpCourseInfo.ShowText = true;
            this.gpCourseInfo.Size = new System.Drawing.Size(571, 179);
            this.gpCourseInfo.TabIndex = 9;
            this.gpCourseInfo.TabStop = false;
            this.gpCourseInfo.Text = "Course Info";
            this.gpCourseInfo.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // searchResultCourName
            // 
            this.searchResultCourName.AllowUserToAddRows = false;
            this.searchResultCourName.AllowUserToDeleteRows = false;
            this.searchResultCourName.AllowUserToResizeColumns = false;
            this.searchResultCourName.AllowUserToResizeRows = false;
            this.searchResultCourName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResultCourName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchResultCourName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultCourName.ColumnHeadersVisible = false;
            this.searchResultCourName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultCourName});
            this.searchResultCourName.Location = new System.Drawing.Point(41, 81);
            this.searchResultCourName.Name = "searchResultCourName";
            this.searchResultCourName.RowHeadersVisible = false;
            this.searchResultCourName.RowHeadersWidth = 62;
            this.searchResultCourName.RowTemplate.Height = 30;
            this.searchResultCourName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultCourName.Size = new System.Drawing.Size(483, 0);
            this.searchResultCourName.TabIndex = 20;
            this.searchResultCourName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultCourName_CellClick);
            // 
            // resultCourName
            // 
            this.resultCourName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resultCourName.DataPropertyName = "Name";
            this.resultCourName.HeaderText = "result";
            this.resultCourName.MinimumWidth = 8;
            this.resultCourName.Name = "resultCourName";
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.AnimateReadOnly = false;
            this.txt_CourseName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_CourseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_CourseName.Depth = 0;
            this.txt_CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_CourseName.HideSelection = true;
            this.txt_CourseName.Hint = "Course Name";
            this.txt_CourseName.LeadingIcon = null;
            this.txt_CourseName.Location = new System.Drawing.Point(41, 38);
            this.txt_CourseName.MaxLength = 32767;
            this.txt_CourseName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.PasswordChar = '\0';
            this.txt_CourseName.PrefixSuffixText = null;
            this.txt_CourseName.ReadOnly = false;
            this.txt_CourseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseName.SelectedText = "";
            this.txt_CourseName.SelectionLength = 0;
            this.txt_CourseName.SelectionStart = 0;
            this.txt_CourseName.ShortcutsEnabled = true;
            this.txt_CourseName.Size = new System.Drawing.Size(483, 48);
            this.txt_CourseName.TabIndex = 24;
            this.txt_CourseName.TabStop = false;
            this.txt_CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CourseName.TrailingIcon = null;
            this.txt_CourseName.UseSystemPasswordChar = false;
            this.txt_CourseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CourseName_KeyPress);
            this.txt_CourseName.Leave += new System.EventHandler(this.txt_NullCheck);
            this.txt_CourseName.TextChanged += new System.EventHandler(this.txt_CourseName_TextChanged);
            // 
            // txt_CourseState
            // 
            this.txt_CourseState.AnimateReadOnly = false;
            this.txt_CourseState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_CourseState.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_CourseState.Depth = 0;
            this.txt_CourseState.Enabled = false;
            this.txt_CourseState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_CourseState.HideSelection = true;
            this.txt_CourseState.Hint = "Open";
            this.txt_CourseState.LeadingIcon = null;
            this.txt_CourseState.Location = new System.Drawing.Point(41, 109);
            this.txt_CourseState.MaxLength = 32767;
            this.txt_CourseState.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_CourseState.Name = "txt_CourseState";
            this.txt_CourseState.PasswordChar = '\0';
            this.txt_CourseState.PrefixSuffixText = null;
            this.txt_CourseState.ReadOnly = false;
            this.txt_CourseState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseState.SelectedText = "";
            this.txt_CourseState.SelectionLength = 0;
            this.txt_CourseState.SelectionStart = 0;
            this.txt_CourseState.ShortcutsEnabled = true;
            this.txt_CourseState.Size = new System.Drawing.Size(483, 48);
            this.txt_CourseState.TabIndex = 24;
            this.txt_CourseState.TabStop = false;
            this.txt_CourseState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CourseState.TrailingIcon = null;
            this.txt_CourseState.UseSystemPasswordChar = false;
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
            this.btn_Save.Location = new System.Drawing.Point(408, 148);
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
            // gpGradeInfo
            // 
            this.gpGradeInfo.BackColor = System.Drawing.Color.White;
            this.gpGradeInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpGradeInfo.BorderWidth = 1;
            this.gpGradeInfo.Controls.Add(this.lbl_leftInQueue);
            this.gpGradeInfo.Controls.Add(this.materialLabel1);
            this.gpGradeInfo.Controls.Add(this.cmb_Grade);
            this.gpGradeInfo.Controls.Add(this.btn_getNext);
            this.gpGradeInfo.Controls.Add(this.btn_Save);
            this.gpGradeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGradeInfo.Location = new System.Drawing.Point(145, 221);
            this.gpGradeInfo.Name = "gpGradeInfo";
            this.gpGradeInfo.ShowText = true;
            this.gpGradeInfo.Size = new System.Drawing.Size(915, 193);
            this.gpGradeInfo.TabIndex = 11;
            this.gpGradeInfo.TabStop = false;
            this.gpGradeInfo.Text = "Grade Info";
            this.gpGradeInfo.TextColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // lbl_leftInQueue
            // 
            this.lbl_leftInQueue.AutoSize = true;
            this.lbl_leftInQueue.Depth = 0;
            this.lbl_leftInQueue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_leftInQueue.Location = new System.Drawing.Point(860, 81);
            this.lbl_leftInQueue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_leftInQueue.Name = "lbl_leftInQueue";
            this.lbl_leftInQueue.Size = new System.Drawing.Size(1, 0);
            this.lbl_leftInQueue.TabIndex = 20;
            this.lbl_leftInQueue.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(774, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Queue:";
            this.materialLabel1.Visible = false;
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.AutoResize = false;
            this.cmb_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.cmb_Grade.Depth = 0;
            this.cmb_Grade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Grade.DropDownHeight = 174;
            this.cmb_Grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Grade.DropDownWidth = 121;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Hint = "Grade";
            this.cmb_Grade.IntegralHeight = false;
            this.cmb_Grade.ItemHeight = 43;
            this.cmb_Grade.Items.AddRange(new object[] {
            "None",
            "A",
            "B+",
            "B",
            "C+",
            "C",
            "D",
            "F"});
            this.cmb_Grade.Location = new System.Drawing.Point(199, 62);
            this.cmb_Grade.MaxDropDownItems = 4;
            this.cmb_Grade.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(481, 49);
            this.cmb_Grade.StartIndex = 0;
            this.cmb_Grade.TabIndex = 18;
            this.cmb_Grade.Visible = false;
            // 
            // btn_getNext
            // 
            this.btn_getNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_getNext.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_getNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_getNext.Depth = 0;
            this.btn_getNext.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btn_getNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_getNext.HighEmphasis = true;
            this.btn_getNext.Icon = null;
            this.btn_getNext.Location = new System.Drawing.Point(795, 148);
            this.btn_getNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_getNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_getNext.Name = "btn_getNext";
            this.btn_getNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_getNext.Size = new System.Drawing.Size(66, 36);
            this.btn_getNext.TabIndex = 6;
            this.btn_getNext.Text = "Clear";
            this.btn_getNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_getNext.UseAccentColor = false;
            this.btn_getNext.UseVisualStyleBackColor = false;
            this.btn_getNext.Visible = false;
            // 
            // gpStudentInfo
            // 
            this.gpStudentInfo.BackColor = System.Drawing.Color.White;
            this.gpStudentInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpStudentInfo.BorderWidth = 1;
            this.gpStudentInfo.Controls.Add(this.searchResultStuId);
            this.gpStudentInfo.Controls.Add(this.txt_StudentId);
            this.gpStudentInfo.Controls.Add(this.txt_StudentName);
            this.gpStudentInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpStudentInfo.Location = new System.Drawing.Point(613, 27);
            this.gpStudentInfo.Name = "gpStudentInfo";
            this.gpStudentInfo.ShowText = true;
            this.gpStudentInfo.Size = new System.Drawing.Size(570, 179);
            this.gpStudentInfo.TabIndex = 11;
            this.gpStudentInfo.TabStop = false;
            this.gpStudentInfo.Text = "Student Info";
            this.gpStudentInfo.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // searchResultStuId
            // 
            this.searchResultStuId.AllowUserToAddRows = false;
            this.searchResultStuId.AllowUserToDeleteRows = false;
            this.searchResultStuId.AllowUserToResizeColumns = false;
            this.searchResultStuId.AllowUserToResizeRows = false;
            this.searchResultStuId.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResultStuId.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchResultStuId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultStuId.ColumnHeadersVisible = false;
            this.searchResultStuId.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultStuId});
            this.searchResultStuId.Location = new System.Drawing.Point(41, 81);
            this.searchResultStuId.Name = "searchResultStuId";
            this.searchResultStuId.RowHeadersVisible = false;
            this.searchResultStuId.RowHeadersWidth = 62;
            this.searchResultStuId.RowTemplate.Height = 30;
            this.searchResultStuId.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultStuId.Size = new System.Drawing.Size(483, 0);
            this.searchResultStuId.TabIndex = 20;
            this.searchResultStuId.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultStuId_CellClick);
            // 
            // resultStuId
            // 
            this.resultStuId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resultStuId.DataPropertyName = "id";
            this.resultStuId.HeaderText = "result";
            this.resultStuId.MinimumWidth = 8;
            this.resultStuId.Name = "resultStuId";
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.AnimateReadOnly = false;
            this.txt_StudentId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_StudentId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_StudentId.Depth = 0;
            this.txt_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_StudentId.HideSelection = true;
            this.txt_StudentId.Hint = "Student Id";
            this.txt_StudentId.LeadingIcon = null;
            this.txt_StudentId.Location = new System.Drawing.Point(41, 38);
            this.txt_StudentId.MaxLength = 32767;
            this.txt_StudentId.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.PasswordChar = '\0';
            this.txt_StudentId.PrefixSuffixText = null;
            this.txt_StudentId.ReadOnly = false;
            this.txt_StudentId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StudentId.SelectedText = "";
            this.txt_StudentId.SelectionLength = 0;
            this.txt_StudentId.SelectionStart = 0;
            this.txt_StudentId.ShortcutsEnabled = true;
            this.txt_StudentId.Size = new System.Drawing.Size(483, 48);
            this.txt_StudentId.TabIndex = 1;
            this.txt_StudentId.TabStop = false;
            this.txt_StudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_StudentId.TrailingIcon = null;
            this.txt_StudentId.UseSystemPasswordChar = false;
            this.txt_StudentId.Visible = false;
            this.txt_StudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StudentId_KeyPress);
            this.txt_StudentId.Leave += new System.EventHandler(this.txt_NullCheck);
            this.txt_StudentId.TextChanged += new System.EventHandler(this.txt_StudentId_TextChanged);
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.AnimateReadOnly = false;
            this.txt_StudentName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_StudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_StudentName.Depth = 0;
            this.txt_StudentName.Enabled = false;
            this.txt_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_StudentName.HideSelection = true;
            this.txt_StudentName.Hint = "Student Name";
            this.txt_StudentName.LeadingIcon = null;
            this.txt_StudentName.Location = new System.Drawing.Point(41, 109);
            this.txt_StudentName.MaxLength = 32767;
            this.txt_StudentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.PasswordChar = '\0';
            this.txt_StudentName.PrefixSuffixText = null;
            this.txt_StudentName.ReadOnly = false;
            this.txt_StudentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StudentName.SelectedText = "";
            this.txt_StudentName.SelectionLength = 0;
            this.txt_StudentName.SelectionStart = 0;
            this.txt_StudentName.ShortcutsEnabled = true;
            this.txt_StudentName.Size = new System.Drawing.Size(483, 48);
            this.txt_StudentName.TabIndex = 1;
            this.txt_StudentName.TabStop = false;
            this.txt_StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_StudentName.TrailingIcon = null;
            this.txt_StudentName.UseSystemPasswordChar = false;
            this.txt_StudentName.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_SaveGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.gpStudentInfo);
            this.Controls.Add(this.gpCourseInfo);
            this.Controls.Add(this.gpGradeInfo);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveGrade";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaveGrade";
            this.Load += new System.EventHandler(this.frm_SaveGrade_Load);
            this.gpCourseInfo.ResumeLayout(false);
            this.gpCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultCourName)).EndInit();
            this.gpGradeInfo.ResumeLayout(false);
            this.gpGradeInfo.PerformLayout();
            this.gpStudentInfo.ResumeLayout(false);
            this.gpStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultStuId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpCourseInfo;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private ReaLTaiizor.Controls.ParrotGroupBox gpGradeInfo;
        private ReaLTaiizor.Controls.ParrotGroupBox gpStudentInfo;
        private MaterialSkin.Controls.MaterialButton btn_getNext;
        private MaterialSkin.Controls.MaterialTextBox2 txt_StudentName;
        private MaterialSkin.Controls.MaterialComboBox cmb_Grade;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_leftInQueue;
        private MaterialSkin.Controls.MaterialTextBox2 txt_CourseState;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_CourseName;
        private MaterialSkin.Controls.MaterialTextBox2 txt_StudentId;
        private System.Windows.Forms.DataGridView searchResultCourName;
        private System.Windows.Forms.DataGridView searchResultStuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultCourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultStuId;
    }
}