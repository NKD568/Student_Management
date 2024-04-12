namespace Student_Management.FORMS.Course.Enrollment
{
    partial class frm_SaveEnrollment
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
            this.lbl_Birhdate = new ReaLTaiizor.Controls.NightLabel();
            this.dtpStuBirthdate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.txt_ContentC = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_ContentB = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_ContentA = new MaterialSkin.Controls.MaterialTextBox2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDetails
            // 
            this.gpDetails.BackColor = System.Drawing.Color.White;
            this.gpDetails.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpDetails.BorderWidth = 1;
            this.gpDetails.Controls.Add(this.searchResult);
            this.gpDetails.Controls.Add(this.dtpStuBirthdate);
            this.gpDetails.Controls.Add(this.btn_Save);
            this.gpDetails.Controls.Add(this.txt_ContentC);
            this.gpDetails.Controls.Add(this.txt_ContentB);
            this.gpDetails.Controls.Add(this.txt_ContentA);
            this.gpDetails.Controls.Add(this.lbl_Birhdate);
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(6, 27);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(570, 319);
            this.gpDetails.TabIndex = 1;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Details";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // lbl_Birhdate
            // 
            this.lbl_Birhdate.AutoSize = true;
            this.lbl_Birhdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Birhdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birhdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lbl_Birhdate.Location = new System.Drawing.Point(36, 211);
            this.lbl_Birhdate.Name = "lbl_Birhdate";
            this.lbl_Birhdate.Size = new System.Drawing.Size(101, 28);
            this.lbl_Birhdate.TabIndex = 23;
            this.lbl_Birhdate.Text = "Birthdate:";
            // 
            // dtpStuBirthdate
            // 
            this.dtpStuBirthdate.Enabled = false;
            this.dtpStuBirthdate.Location = new System.Drawing.Point(168, 203);
            this.dtpStuBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStuBirthdate.Name = "dtpStuBirthdate";
            this.dtpStuBirthdate.Size = new System.Drawing.Size(356, 39);
            this.dtpStuBirthdate.TabIndex = 5;
            this.dtpStuBirthdate.Value = new System.DateTime(2024, 3, 12, 0, 0, 0, 0);
            this.dtpStuBirthdate.Visible = false;
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            this.searchResult.AllowUserToResizeRows = false;
            this.searchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.ColumnHeadersVisible = false;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.result});
            this.searchResult.Location = new System.Drawing.Point(41, 76);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.RowHeadersWidth = 62;
            this.searchResult.RowTemplate.Height = 30;
            this.searchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResult.Size = new System.Drawing.Size(483, 0);
            this.searchResult.TabIndex = 21;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellClick);
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.HeaderText = "result";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
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
            this.btn_Save.Location = new System.Drawing.Point(247, 268);
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
            // txt_ContentC
            // 
            this.txt_ContentC.AnimateReadOnly = false;
            this.txt_ContentC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ContentC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ContentC.Depth = 0;
            this.txt_ContentC.Enabled = false;
            this.txt_ContentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ContentC.HideSelection = true;
            this.txt_ContentC.Hint = "Student Email";
            this.txt_ContentC.LeadingIcon = null;
            this.txt_ContentC.Location = new System.Drawing.Point(41, 146);
            this.txt_ContentC.MaxLength = 32767;
            this.txt_ContentC.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ContentC.Name = "txt_ContentC";
            this.txt_ContentC.PasswordChar = '\0';
            this.txt_ContentC.PrefixSuffixText = null;
            this.txt_ContentC.ReadOnly = false;
            this.txt_ContentC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ContentC.SelectedText = "";
            this.txt_ContentC.SelectionLength = 0;
            this.txt_ContentC.SelectionStart = 0;
            this.txt_ContentC.ShortcutsEnabled = true;
            this.txt_ContentC.Size = new System.Drawing.Size(483, 48);
            this.txt_ContentC.TabIndex = 4;
            this.txt_ContentC.TabStop = false;
            this.txt_ContentC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ContentC.TrailingIcon = null;
            this.txt_ContentC.UseSystemPasswordChar = false;
            // 
            // txt_ContentB
            // 
            this.txt_ContentB.AnimateReadOnly = false;
            this.txt_ContentB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ContentB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ContentB.Depth = 0;
            this.txt_ContentB.Enabled = false;
            this.txt_ContentB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ContentB.HideSelection = true;
            this.txt_ContentB.Hint = "Student Name";
            this.txt_ContentB.LeadingIcon = null;
            this.txt_ContentB.Location = new System.Drawing.Point(41, 92);
            this.txt_ContentB.MaxLength = 32767;
            this.txt_ContentB.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ContentB.Name = "txt_ContentB";
            this.txt_ContentB.PasswordChar = '\0';
            this.txt_ContentB.PrefixSuffixText = null;
            this.txt_ContentB.ReadOnly = false;
            this.txt_ContentB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ContentB.SelectedText = "";
            this.txt_ContentB.SelectionLength = 0;
            this.txt_ContentB.SelectionStart = 0;
            this.txt_ContentB.ShortcutsEnabled = true;
            this.txt_ContentB.Size = new System.Drawing.Size(483, 48);
            this.txt_ContentB.TabIndex = 3;
            this.txt_ContentB.TabStop = false;
            this.txt_ContentB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ContentB.TrailingIcon = null;
            this.txt_ContentB.UseSystemPasswordChar = false;
            // 
            // txt_ContentA
            // 
            this.txt_ContentA.AnimateReadOnly = false;
            this.txt_ContentA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ContentA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ContentA.Depth = 0;
            this.txt_ContentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ContentA.HideSelection = true;
            this.txt_ContentA.Hint = "Student Id";
            this.txt_ContentA.LeadingIcon = null;
            this.txt_ContentA.Location = new System.Drawing.Point(41, 38);
            this.txt_ContentA.MaxLength = 32767;
            this.txt_ContentA.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ContentA.Name = "txt_ContentA";
            this.txt_ContentA.PasswordChar = '\0';
            this.txt_ContentA.PrefixSuffixText = null;
            this.txt_ContentA.ReadOnly = false;
            this.txt_ContentA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ContentA.SelectedText = "";
            this.txt_ContentA.SelectionLength = 0;
            this.txt_ContentA.SelectionStart = 0;
            this.txt_ContentA.ShortcutsEnabled = true;
            this.txt_ContentA.Size = new System.Drawing.Size(483, 48);
            this.txt_ContentA.TabIndex = 2;
            this.txt_ContentA.TabStop = false;
            this.txt_ContentA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ContentA.TrailingIcon = null;
            this.txt_ContentA.UseSystemPasswordChar = false;
            this.txt_ContentA.Enter += new System.EventHandler(this.txt_ContentA_Enter);
            this.txt_ContentA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ContentA_KeyPress);
            this.txt_ContentA.Leave += new System.EventHandler(this.txt_ContentA_Leave);
            this.txt_ContentA.TextChanged += new System.EventHandler(this.txt_ContentA_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_SaveEnrollment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(591, 354);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveEnrollment";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaveEnrollment";
            this.Load += new System.EventHandler(this.frm_SaveEnrollment_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private System.Windows.Forms.DataGridView searchResult;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialTextBox2 txt_ContentB;
        private MaterialSkin.Controls.MaterialTextBox2 txt_ContentA;
        private MaterialSkin.Controls.MaterialTextBox2 txt_ContentC;
        private ReaLTaiizor.Controls.NightLabel lbl_Birhdate;
        private ReaLTaiizor.Controls.PoisonDateTime dtpStuBirthdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}