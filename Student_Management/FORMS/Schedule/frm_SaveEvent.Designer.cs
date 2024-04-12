namespace Student_Management.FORMS.Schedule
{
    partial class frm_SaveEvent
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
            this.txt_Class = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.gpEventInfo = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_MoveDate = new ReaLTaiizor.Controls.ToggleButton();
            this.lbl_MoveDate = new System.Windows.Forms.Label();
            this.dtp_Date = new ReaLTaiizor.Controls.PoisonDateTime();
            this.cmb_Type = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpEventInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Class
            // 
            this.txt_Class.AnimateReadOnly = false;
            this.txt_Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Class.Depth = 0;
            this.txt_Class.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Class.LeadingIcon = null;
            this.txt_Class.Location = new System.Drawing.Point(35, 73);
            this.txt_Class.MaxLength = 50;
            this.txt_Class.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Class.Multiline = false;
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(530, 50);
            this.txt_Class.TabIndex = 2;
            this.txt_Class.Text = "";
            this.txt_Class.TrailingIcon = null;
            this.txt_Class.TextChanged += new System.EventHandler(this.txt_Class_TextChanged);
            this.txt_Class.Enter += new System.EventHandler(this.txt_Class_Enter);
            this.txt_Class.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Class_KeyPress);
            this.txt_Class.Leave += new System.EventHandler(this.txt_Class_Leave);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(54, 51);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Class";
            // 
            // gpEventInfo
            // 
            this.gpEventInfo.BackColor = System.Drawing.Color.White;
            this.gpEventInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpEventInfo.BorderWidth = 1;
            this.gpEventInfo.Controls.Add(this.searchResult);
            this.gpEventInfo.Controls.Add(this.btn_MoveDate);
            this.gpEventInfo.Controls.Add(this.lbl_MoveDate);
            this.gpEventInfo.Controls.Add(this.dtp_Date);
            this.gpEventInfo.Controls.Add(this.cmb_Type);
            this.gpEventInfo.Controls.Add(this.materialLabel3);
            this.gpEventInfo.Controls.Add(this.btn_Save);
            this.gpEventInfo.Controls.Add(this.materialLabel2);
            this.gpEventInfo.Controls.Add(this.txt_Class);
            this.gpEventInfo.Controls.Add(this.materialLabel1);
            this.gpEventInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEventInfo.Location = new System.Drawing.Point(6, 27);
            this.gpEventInfo.Name = "gpEventInfo";
            this.gpEventInfo.ShowText = true;
            this.gpEventInfo.Size = new System.Drawing.Size(602, 291);
            this.gpEventInfo.TabIndex = 10;
            this.gpEventInfo.TabStop = false;
            this.gpEventInfo.Text = "Class Schedule";
            this.gpEventInfo.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.searchResult.Location = new System.Drawing.Point(35, 113);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.RowHeadersWidth = 62;
            this.searchResult.RowTemplate.Height = 30;
            this.searchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResult.Size = new System.Drawing.Size(530, 0);
            this.searchResult.TabIndex = 2;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultCourName_CellClick);
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.HeaderText = "result";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
            // 
            // btn_MoveDate
            // 
            this.btn_MoveDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(103)))));
            this.btn_MoveDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MoveDate.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MoveDate.Location = new System.Drawing.Point(159, 210);
            this.btn_MoveDate.Name = "btn_MoveDate";
            this.btn_MoveDate.Size = new System.Drawing.Size(76, 33);
            this.btn_MoveDate.TabIndex = 27;
            this.btn_MoveDate.Toggled = false;
            this.btn_MoveDate.Type = ReaLTaiizor.Controls.ToggleButton._Type.CheckMark;
            this.btn_MoveDate.Visible = false;
            this.btn_MoveDate.ToggledChanged += new ReaLTaiizor.Controls.ToggleButton.ToggledChangedEventHandler(this.btn_MoveDate_ToggledChanged);
            // 
            // lbl_MoveDate
            // 
            this.lbl_MoveDate.AutoSize = true;
            this.lbl_MoveDate.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_MoveDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_MoveDate.Location = new System.Drawing.Point(67, 215);
            this.lbl_MoveDate.Name = "lbl_MoveDate";
            this.lbl_MoveDate.Size = new System.Drawing.Size(132, 32);
            this.lbl_MoveDate.TabIndex = 28;
            this.lbl_MoveDate.Text = "Move Date";
            this.lbl_MoveDate.Visible = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Segoe UI", 14F);
            this.dtp_Date.Location = new System.Drawing.Point(35, 165);
            this.dtp_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(230, 39);
            this.dtp_Date.TabIndex = 3;
            this.dtp_Date.CloseUp += new System.EventHandler(this.dtp_Date_CloseUp);
            this.dtp_Date.MouseEnter += new System.EventHandler(this.dtp_Date_MouseEnter);
            // 
            // cmb_Type
            // 
            this.cmb_Type.AutoResize = false;
            this.cmb_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Type.Depth = 0;
            this.cmb_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Type.DropDownHeight = 174;
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.DropDownWidth = 121;
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.IntegralHeight = false;
            this.cmb_Type.ItemHeight = 43;
            this.cmb_Type.Items.AddRange(new object[] {
            "Timetable",
            "Exam"});
            this.cmb_Type.Location = new System.Drawing.Point(385, 155);
            this.cmb_Type.MaxDropDownItems = 4;
            this.cmb_Type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(180, 49);
            this.cmb_Type.StartIndex = 0;
            this.cmb_Type.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(337, 143);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Type:";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(269, 236);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(64, 36);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(54, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(34, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Date";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_SaveEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(613, 321);
            this.Controls.Add(this.gpEventInfo);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveEvent";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Event_FormClosed);
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.gpEventInfo.ResumeLayout(false);
            this.gpEventInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_Class;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.ParrotGroupBox gpEventInfo;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private System.Windows.Forms.DataGridView searchResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.PoisonDateTime dtp_Date;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_Type;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private ReaLTaiizor.Controls.ToggleButton btn_MoveDate;
        private System.Windows.Forms.Label lbl_MoveDate;
    }
}