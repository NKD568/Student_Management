namespace Student_Management.FORMS.Course
{
    partial class frm_SaveClass
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
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.cmb_State = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.txt_Capacity = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Course = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gpDetails.Controls.Add(this.cmb_State);
            this.gpDetails.Controls.Add(this.btn_Save);
            this.gpDetails.Controls.Add(this.txt_Capacity);
            this.gpDetails.Controls.Add(this.txt_Name);
            this.gpDetails.Controls.Add(this.txt_Course);
            this.gpDetails.Controls.Add(this.materialLabel2);
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(6, 27);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(570, 319);
            this.gpDetails.TabIndex = 9;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Details";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.searchResult.Visible = false;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultCourName_CellClick);
            // 
            // cmb_State
            // 
            this.cmb_State.AutoResize = false;
            this.cmb_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_State.Depth = 0;
            this.cmb_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_State.DropDownHeight = 174;
            this.cmb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_State.DropDownWidth = 121;
            this.cmb_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.IntegralHeight = false;
            this.cmb_State.ItemHeight = 43;
            this.cmb_State.Items.AddRange(new object[] {
            "Opened",
            "Ongoing",
            "Closed"});
            this.cmb_State.Location = new System.Drawing.Point(352, 154);
            this.cmb_State.MaxDropDownItems = 4;
            this.cmb_State.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(172, 49);
            this.cmb_State.StartIndex = 0;
            this.cmb_State.TabIndex = 4;
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
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "     Save     ";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.AnimateReadOnly = false;
            this.txt_Capacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Capacity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Capacity.Depth = 0;
            this.txt_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Capacity.HideSelection = true;
            this.txt_Capacity.Hint = "Capacity";
            this.txt_Capacity.LeadingIcon = null;
            this.txt_Capacity.Location = new System.Drawing.Point(41, 92);
            this.txt_Capacity.MaxLength = 32767;
            this.txt_Capacity.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.PasswordChar = '\0';
            this.txt_Capacity.PrefixSuffixText = null;
            this.txt_Capacity.ReadOnly = false;
            this.txt_Capacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Capacity.SelectedText = "";
            this.txt_Capacity.SelectionLength = 0;
            this.txt_Capacity.SelectionStart = 0;
            this.txt_Capacity.ShortcutsEnabled = true;
            this.txt_Capacity.Size = new System.Drawing.Size(483, 48);
            this.txt_Capacity.TabIndex = 3;
            this.txt_Capacity.TabStop = false;
            this.txt_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Capacity.TrailingIcon = null;
            this.txt_Capacity.UseSystemPasswordChar = false;
            this.txt_Capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Capacity_KeyPress);
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
            this.txt_Name.Location = new System.Drawing.Point(41, 154);
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
            this.txt_Name.Size = new System.Drawing.Size(225, 48);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Name.TrailingIcon = null;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Course_KeyPress);
            // 
            // txt_Course
            // 
            this.txt_Course.AnimateReadOnly = false;
            this.txt_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Course.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Course.Depth = 0;
            this.txt_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Course.HideSelection = true;
            this.txt_Course.Hint = "Course";
            this.txt_Course.LeadingIcon = null;
            this.txt_Course.Location = new System.Drawing.Point(41, 38);
            this.txt_Course.MaxLength = 32767;
            this.txt_Course.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Course.Name = "txt_Course";
            this.txt_Course.PasswordChar = '\0';
            this.txt_Course.PrefixSuffixText = null;
            this.txt_Course.ReadOnly = false;
            this.txt_Course.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Course.SelectedText = "";
            this.txt_Course.SelectionLength = 0;
            this.txt_Course.SelectionStart = 0;
            this.txt_Course.ShortcutsEnabled = true;
            this.txt_Course.Size = new System.Drawing.Size(483, 48);
            this.txt_Course.TabIndex = 2;
            this.txt_Course.TabStop = false;
            this.txt_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Course.TrailingIcon = null;
            this.txt_Course.UseSystemPasswordChar = false;
            this.txt_Course.Enter += new System.EventHandler(this.txt_Course_Enter);
            this.txt_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Course_KeyPress);
            this.txt_Course.TextChanged += new System.EventHandler(this.txt_Course_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(304, 169);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "State:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.HeaderText = "result";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
            // 
            // frm_SaveClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(583, 351);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveClass";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaveClass";
            this.Load += new System.EventHandler(this.frm_SaveClass_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmb_State;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Course;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Capacity;
        private System.Windows.Forms.DataGridView searchResult;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}