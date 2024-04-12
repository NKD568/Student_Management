namespace Student_Management.FORMS.Grade
{
    partial class frm_Grade
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Progress = new System.Windows.Forms.TextBox();
            this.lbl_ProgressId = new System.Windows.Forms.Label();
            this.lbl_ProgressPercent = new System.Windows.Forms.Label();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Midterm = new System.Windows.Forms.TextBox();
            this.lbl_MidtermId = new System.Windows.Forms.Label();
            this.lbl_MidTermPercent = new System.Windows.Forms.Label();
            this.lbl_Midterm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Final = new System.Windows.Forms.TextBox();
            this.lbl_FinalId = new System.Windows.Forms.Label();
            this.lbl_FinalPercent = new System.Windows.Forms.Label();
            this.lbl_Final = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_Overall = new System.Windows.Forms.Label();
            this.lbl_OverallId = new System.Windows.Forms.Label();
            this.lbl_Overall = new System.Windows.Forms.Label();
            this.btn_EditMode = new ReaLTaiizor.Controls.ToggleButton();
            this.lbl_EditMode = new System.Windows.Forms.Label();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.btn_Exit = new ReaLTaiizor.Controls.LostCancelButton();
            this.validateTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Recheck = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade Display";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txt_Progress);
            this.panel1.Controls.Add(this.lbl_ProgressId);
            this.panel1.Controls.Add(this.lbl_ProgressPercent);
            this.panel1.Controls.Add(this.lbl_Progress);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 200);
            this.panel1.TabIndex = 2;
            // 
            // txt_Progress
            // 
            this.txt_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_Progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.txt_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.txt_Progress.Location = new System.Drawing.Point(107, 71);
            this.txt_Progress.Name = "txt_Progress";
            this.txt_Progress.ReadOnly = true;
            this.txt_Progress.Size = new System.Drawing.Size(57, 73);
            this.txt_Progress.TabIndex = 2;
            this.txt_Progress.Text = "A";
            this.txt_Progress.TextChanged += new System.EventHandler(this.grade_TextChanged);
            this.txt_Progress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grade_KeyPress);
            // 
            // lbl_ProgressId
            // 
            this.lbl_ProgressId.AutoSize = true;
            this.lbl_ProgressId.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_ProgressId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_ProgressId.Location = new System.Drawing.Point(6, 90);
            this.lbl_ProgressId.Name = "lbl_ProgressId";
            this.lbl_ProgressId.Size = new System.Drawing.Size(0, 32);
            this.lbl_ProgressId.TabIndex = 2;
            this.lbl_ProgressId.Visible = false;
            // 
            // lbl_ProgressPercent
            // 
            this.lbl_ProgressPercent.AutoSize = true;
            this.lbl_ProgressPercent.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_ProgressPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_ProgressPercent.Location = new System.Drawing.Point(107, 162);
            this.lbl_ProgressPercent.Name = "lbl_ProgressPercent";
            this.lbl_ProgressPercent.Size = new System.Drawing.Size(60, 32);
            this.lbl_ProgressPercent.TabIndex = 2;
            this.lbl_ProgressPercent.Text = "30%";
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.lbl_Progress.ForeColor = System.Drawing.Color.White;
            this.lbl_Progress.Location = new System.Drawing.Point(68, 0);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(173, 54);
            this.lbl_Progress.TabIndex = 2;
            this.lbl_Progress.Text = "Progress";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txt_Midterm);
            this.panel2.Controls.Add(this.lbl_MidtermId);
            this.panel2.Controls.Add(this.lbl_MidTermPercent);
            this.panel2.Controls.Add(this.lbl_Midterm);
            this.panel2.Location = new System.Drawing.Point(275, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 200);
            this.panel2.TabIndex = 3;
            // 
            // txt_Midterm
            // 
            this.txt_Midterm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_Midterm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Midterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.txt_Midterm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.txt_Midterm.Location = new System.Drawing.Point(107, 71);
            this.txt_Midterm.Name = "txt_Midterm";
            this.txt_Midterm.ReadOnly = true;
            this.txt_Midterm.Size = new System.Drawing.Size(100, 73);
            this.txt_Midterm.TabIndex = 3;
            this.txt_Midterm.Text = "B+";
            this.txt_Midterm.TextChanged += new System.EventHandler(this.grade_TextChanged);
            this.txt_Midterm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grade_KeyPress);
            // 
            // lbl_MidtermId
            // 
            this.lbl_MidtermId.AutoSize = true;
            this.lbl_MidtermId.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_MidtermId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_MidtermId.Location = new System.Drawing.Point(3, 90);
            this.lbl_MidtermId.Name = "lbl_MidtermId";
            this.lbl_MidtermId.Size = new System.Drawing.Size(0, 32);
            this.lbl_MidtermId.TabIndex = 2;
            this.lbl_MidtermId.Visible = false;
            // 
            // lbl_MidTermPercent
            // 
            this.lbl_MidTermPercent.AutoSize = true;
            this.lbl_MidTermPercent.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_MidTermPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_MidTermPercent.Location = new System.Drawing.Point(104, 162);
            this.lbl_MidTermPercent.Name = "lbl_MidTermPercent";
            this.lbl_MidTermPercent.Size = new System.Drawing.Size(60, 32);
            this.lbl_MidTermPercent.TabIndex = 3;
            this.lbl_MidTermPercent.Text = "20%";
            // 
            // lbl_Midterm
            // 
            this.lbl_Midterm.AutoSize = true;
            this.lbl_Midterm.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.lbl_Midterm.ForeColor = System.Drawing.Color.White;
            this.lbl_Midterm.Location = new System.Drawing.Point(64, 0);
            this.lbl_Midterm.Name = "lbl_Midterm";
            this.lbl_Midterm.Size = new System.Drawing.Size(176, 54);
            this.lbl_Midterm.TabIndex = 2;
            this.lbl_Midterm.Text = "Midterm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txt_Final);
            this.panel3.Controls.Add(this.lbl_FinalId);
            this.panel3.Controls.Add(this.lbl_FinalPercent);
            this.panel3.Controls.Add(this.lbl_Final);
            this.panel3.Location = new System.Drawing.Point(538, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 200);
            this.panel3.TabIndex = 4;
            // 
            // txt_Final
            // 
            this.txt_Final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_Final.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.txt_Final.ForeColor = System.Drawing.Color.DarkSalmon;
            this.txt_Final.Location = new System.Drawing.Point(101, 71);
            this.txt_Final.Name = "txt_Final";
            this.txt_Final.ReadOnly = true;
            this.txt_Final.Size = new System.Drawing.Size(57, 73);
            this.txt_Final.TabIndex = 4;
            this.txt_Final.Text = "C";
            this.txt_Final.TextChanged += new System.EventHandler(this.grade_TextChanged);
            this.txt_Final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grade_KeyPress);
            // 
            // lbl_FinalId
            // 
            this.lbl_FinalId.AutoSize = true;
            this.lbl_FinalId.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_FinalId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_FinalId.Location = new System.Drawing.Point(3, 90);
            this.lbl_FinalId.Name = "lbl_FinalId";
            this.lbl_FinalId.Size = new System.Drawing.Size(0, 32);
            this.lbl_FinalId.TabIndex = 2;
            this.lbl_FinalId.Visible = false;
            // 
            // lbl_FinalPercent
            // 
            this.lbl_FinalPercent.AutoSize = true;
            this.lbl_FinalPercent.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_FinalPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_FinalPercent.Location = new System.Drawing.Point(101, 162);
            this.lbl_FinalPercent.Name = "lbl_FinalPercent";
            this.lbl_FinalPercent.Size = new System.Drawing.Size(60, 32);
            this.lbl_FinalPercent.TabIndex = 4;
            this.lbl_FinalPercent.Text = "50%";
            // 
            // lbl_Final
            // 
            this.lbl_Final.AutoSize = true;
            this.lbl_Final.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.lbl_Final.ForeColor = System.Drawing.Color.White;
            this.lbl_Final.Location = new System.Drawing.Point(90, 0);
            this.lbl_Final.Name = "lbl_Final";
            this.lbl_Final.Size = new System.Drawing.Size(106, 54);
            this.lbl_Final.TabIndex = 4;
            this.lbl_Final.Text = "Final";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.txt_Overall);
            this.panel6.Controls.Add(this.lbl_OverallId);
            this.panel6.Controls.Add(this.lbl_Overall);
            this.panel6.Location = new System.Drawing.Point(261, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 80);
            this.panel6.TabIndex = 9;
            // 
            // txt_Overall
            // 
            this.txt_Overall.AutoSize = true;
            this.txt_Overall.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.txt_Overall.ForeColor = System.Drawing.Color.Violet;
            this.txt_Overall.Location = new System.Drawing.Point(163, 12);
            this.txt_Overall.Name = "txt_Overall";
            this.txt_Overall.Size = new System.Drawing.Size(114, 73);
            this.txt_Overall.TabIndex = 9;
            this.txt_Overall.Text = "B+";
            this.txt_Overall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_OverallId
            // 
            this.lbl_OverallId.AutoSize = true;
            this.lbl_OverallId.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_OverallId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_OverallId.Location = new System.Drawing.Point(3, 0);
            this.lbl_OverallId.Name = "lbl_OverallId";
            this.lbl_OverallId.Size = new System.Drawing.Size(0, 32);
            this.lbl_OverallId.TabIndex = 2;
            this.lbl_OverallId.Visible = false;
            // 
            // lbl_Overall
            // 
            this.lbl_Overall.AutoSize = true;
            this.lbl_Overall.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.lbl_Overall.ForeColor = System.Drawing.Color.White;
            this.lbl_Overall.Location = new System.Drawing.Point(21, 18);
            this.lbl_Overall.Name = "lbl_Overall";
            this.lbl_Overall.Size = new System.Drawing.Size(147, 54);
            this.lbl_Overall.TabIndex = 2;
            this.lbl_Overall.Text = "Overall";
            // 
            // btn_EditMode
            // 
            this.btn_EditMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(103)))));
            this.btn_EditMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditMode.ForeColor = System.Drawing.Color.Transparent;
            this.btn_EditMode.Location = new System.Drawing.Point(712, 42);
            this.btn_EditMode.Name = "btn_EditMode";
            this.btn_EditMode.Size = new System.Drawing.Size(76, 33);
            this.btn_EditMode.TabIndex = 1;
            this.btn_EditMode.Toggled = false;
            this.btn_EditMode.Type = ReaLTaiizor.Controls.ToggleButton._Type.OnOff;
            this.btn_EditMode.ToggledChanged += new ReaLTaiizor.Controls.ToggleButton.ToggledChangedEventHandler(this.btn_EditMode_ToggledChanged);
            // 
            // lbl_EditMode
            // 
            this.lbl_EditMode.AutoSize = true;
            this.lbl_EditMode.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_EditMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_EditMode.Location = new System.Drawing.Point(620, 47);
            this.lbl_EditMode.Name = "lbl_EditMode";
            this.lbl_EditMode.Size = new System.Drawing.Size(132, 32);
            this.lbl_EditMode.TabIndex = 3;
            this.lbl_EditMode.Text = "Enable Edit";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(632, 332);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(64, 36);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = true;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Crimson;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.Image = null;
            this.btn_Exit.Location = new System.Drawing.Point(769, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // validateTimer
            // 
            this.validateTimer.Tick += new System.EventHandler(this.validateTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_Recheck
            // 
            this.btn_Recheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Recheck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Recheck.Depth = 0;
            this.btn_Recheck.HighEmphasis = true;
            this.btn_Recheck.Icon = null;
            this.btn_Recheck.Location = new System.Drawing.Point(112, 332);
            this.btn_Recheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Recheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Recheck.Name = "btn_Recheck";
            this.btn_Recheck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Recheck.Size = new System.Drawing.Size(87, 36);
            this.btn_Recheck.TabIndex = 11;
            this.btn_Recheck.Text = "Recheck";
            this.btn_Recheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Recheck.UseAccentColor = true;
            this.btn_Recheck.UseVisualStyleBackColor = true;
            this.btn_Recheck.Visible = false;
            this.btn_Recheck.Click += new System.EventHandler(this.btn_Recheck_Click);
            // 
            // frm_Grade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Recheck);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_EditMode);
            this.Controls.Add(this.lbl_EditMode);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Grade";
            this.Load += new System.EventHandler(this.frm_Grade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Midterm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Final;
        private System.Windows.Forms.Label lbl_ProgressPercent;
        private System.Windows.Forms.Label lbl_MidTermPercent;
        private System.Windows.Forms.Label lbl_FinalPercent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_Overall;
        private ReaLTaiizor.Controls.ToggleButton btn_EditMode;
        private System.Windows.Forms.TextBox txt_Final;
        private System.Windows.Forms.TextBox txt_Progress;
        private System.Windows.Forms.TextBox txt_Midterm;
        private System.Windows.Forms.Label txt_Overall;
        private System.Windows.Forms.Label lbl_EditMode;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private ReaLTaiizor.Controls.LostCancelButton btn_Exit;
        private System.Windows.Forms.Timer validateTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton btn_Recheck;
        private System.Windows.Forms.Label lbl_ProgressId;
        private System.Windows.Forms.Label lbl_MidtermId;
        private System.Windows.Forms.Label lbl_FinalId;
        private System.Windows.Forms.Label lbl_OverallId;
    }
}