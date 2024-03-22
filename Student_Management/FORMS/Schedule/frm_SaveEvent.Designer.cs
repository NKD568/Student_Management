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
            this.txt_Course = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.gpEventInfo = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.dtp_Date = new ReaLTaiizor.Controls.PoisonDateTime();
            this.searchResultCourName = new System.Windows.Forms.DataGridView();
            this.resultCourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpEventInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultCourName)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Course
            // 
            this.txt_Course.AnimateReadOnly = false;
            this.txt_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Course.Depth = 0;
            this.txt_Course.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Course.LeadingIcon = null;
            this.txt_Course.Location = new System.Drawing.Point(55, 157);
            this.txt_Course.MaxLength = 50;
            this.txt_Course.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Course.Multiline = false;
            this.txt_Course.Name = "txt_Course";
            this.txt_Course.Size = new System.Drawing.Size(544, 50);
            this.txt_Course.TabIndex = 0;
            this.txt_Course.Text = "";
            this.txt_Course.TrailingIcon = null;
            this.txt_Course.TextChanged += new System.EventHandler(this.txt_Course_TextChanged);
            this.txt_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Course_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(66, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(34, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Date";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(66, 135);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Course";
            // 
            // gpEventInfo
            // 
            this.gpEventInfo.BackColor = System.Drawing.Color.White;
            this.gpEventInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpEventInfo.BorderWidth = 1;
            this.gpEventInfo.Controls.Add(this.dtp_Date);
            this.gpEventInfo.Controls.Add(this.searchResultCourName);
            this.gpEventInfo.Controls.Add(this.btn_Save);
            this.gpEventInfo.Controls.Add(this.materialLabel1);
            this.gpEventInfo.Controls.Add(this.materialLabel2);
            this.gpEventInfo.Controls.Add(this.txt_Course);
            this.gpEventInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEventInfo.Location = new System.Drawing.Point(6, 27);
            this.gpEventInfo.Name = "gpEventInfo";
            this.gpEventInfo.ShowText = true;
            this.gpEventInfo.Size = new System.Drawing.Size(651, 363);
            this.gpEventInfo.TabIndex = 10;
            this.gpEventInfo.TabStop = false;
            this.gpEventInfo.Text = "Event Info";
            this.gpEventInfo.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Segoe UI", 14F);
            this.dtp_Date.Location = new System.Drawing.Point(55, 68);
            this.dtp_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(544, 39);
            this.dtp_Date.TabIndex = 22;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            this.dtp_Date.MouseEnter += new System.EventHandler(this.dtp_Date_MouseEnter);
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
            this.searchResultCourName.Location = new System.Drawing.Point(55, 204);
            this.searchResultCourName.Name = "searchResultCourName";
            this.searchResultCourName.RowHeadersVisible = false;
            this.searchResultCourName.RowHeadersWidth = 62;
            this.searchResultCourName.RowTemplate.Height = 30;
            this.searchResultCourName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultCourName.Size = new System.Drawing.Size(544, 0);
            this.searchResultCourName.TabIndex = 21;
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
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(294, 318);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(64, 36);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_Event
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(663, 396);
            this.Controls.Add(this.gpEventInfo);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_Event";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Event_FormClosed);
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.gpEventInfo.ResumeLayout(false);
            this.gpEventInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultCourName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_Course;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.ParrotGroupBox gpEventInfo;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private System.Windows.Forms.DataGridView searchResultCourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultCourName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.PoisonDateTime dtp_Date;
    }
}