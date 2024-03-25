namespace Student_Management.FORMS.Dashboard
{
    partial class frm_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Average = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.examProgress = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gradeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Enrolled = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Ongoing = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeChart)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Average);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management.Properties.Resources.average_100;
            this.pictureBox1.Location = new System.Drawing.Point(258, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Average
            // 
            this.lbl_Average.AutoSize = true;
            this.lbl_Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_Average.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.lbl_Average.Location = new System.Drawing.Point(96, 70);
            this.lbl_Average.Name = "lbl_Average";
            this.lbl_Average.Size = new System.Drawing.Size(114, 73);
            this.lbl_Average.TabIndex = 3;
            this.lbl_Average.Text = "B+";
            this.lbl_Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(49, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Details of last 30 days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Average Grade";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_Pass);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(485, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 200);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Student_Management.Properties.Resources.percentage_100;
            this.pictureBox2.Location = new System.Drawing.Point(261, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lbl_Pass.Location = new System.Drawing.Point(74, 70);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(164, 73);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "64%";
            this.lbl_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(50, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Details of last 30 days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 54);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pass Percentage";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.examProgress);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 371);
            this.panel3.TabIndex = 1;
            // 
            // examProgress
            // 
            this.examProgress.AnimationSpeed = 5;
            this.examProgress.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.examProgress.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.examProgress.FilledColorAlpha = 130;
            this.examProgress.FilledThickness = 40;
            this.examProgress.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.examProgress.IsAnimated = false;
            this.examProgress.Location = new System.Drawing.Point(89, 73);
            this.examProgress.Name = "examProgress";
            this.examProgress.Percentage = 46;
            this.examProgress.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.examProgress.ShowText = true;
            this.examProgress.Size = new System.Drawing.Size(225, 225);
            this.examProgress.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.examProgress.TabIndex = 3;
            this.examProgress.TextColor = System.Drawing.Color.Gray;
            this.examProgress.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.examProgress.TextSize = 25;
            this.examProgress.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.examProgress.UnfilledThickness = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 54);
            this.label10.TabIndex = 2;
            this.label10.Text = "Final Exam Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(123, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details of last 30 days";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.gradeChart);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(485, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 258);
            this.panel4.TabIndex = 1;
            // 
            // gradeChart
            // 
            this.gradeChart.BackColor = System.Drawing.Color.Azure;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.BackColor = System.Drawing.Color.MintCream;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.gradeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gradeChart.Legends.Add(legend1);
            this.gradeChart.Location = new System.Drawing.Point(33, 57);
            this.gradeChart.Name = "gradeChart";
            this.gradeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Grade";
            this.gradeChart.Series.Add(series1);
            this.gradeChart.Size = new System.Drawing.Size(588, 187);
            this.gradeChart.TabIndex = 3;
            this.gradeChart.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 54);
            this.label12.TabIndex = 2;
            this.label12.Text = "Grade Chart";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label15.Location = new System.Drawing.Point(310, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 32);
            this.label15.TabIndex = 2;
            this.label15.Text = "Details of last 30 days";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lbl_Enrolled);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(931, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 200);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(26, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "Details of last 30 days";
            // 
            // lbl_Enrolled
            // 
            this.lbl_Enrolled.AutoSize = true;
            this.lbl_Enrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_Enrolled.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_Enrolled.Location = new System.Drawing.Point(14, 70);
            this.lbl_Enrolled.Name = "lbl_Enrolled";
            this.lbl_Enrolled.Size = new System.Drawing.Size(273, 73);
            this.lbl_Enrolled.TabIndex = 3;
            this.lbl_Enrolled.Text = "100,000";
            this.lbl_Enrolled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(11, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 54);
            this.label13.TabIndex = 2;
            this.label13.Text = "Enrolled Count";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.lbl_Ongoing);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(485, 610);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(659, 94);
            this.panel6.TabIndex = 1;
            // 
            // lbl_Ongoing
            // 
            this.lbl_Ongoing.AutoSize = true;
            this.lbl_Ongoing.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.lbl_Ongoing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lbl_Ongoing.Location = new System.Drawing.Point(39, 48);
            this.lbl_Ongoing.Name = "lbl_Ongoing";
            this.lbl_Ongoing.Size = new System.Drawing.Size(250, 38);
            this.lbl_Ongoing.TabIndex = 2;
            this.lbl_Ongoing.Text = "Text  ............................";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(432, 54);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ongoing Test Schedule";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(181)))), ((int)(((byte)(196)))));
            this.searchPanel.Controls.Add(this.txt_Search);
            this.searchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchPanel.Location = new System.Drawing.Point(680, 19);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(426, 54);
            this.searchPanel.TabIndex = 17;
            this.searchPanel.Visible = false;
            // 
            // txt_Search
            // 
            this.txt_Search.AnimateReadOnly = false;
            this.txt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Depth = 0;
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.HideSelection = true;
            this.txt_Search.Hint = "Search";
            this.txt_Search.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_Search.LeadingIcon")));
            this.txt_Search.Location = new System.Drawing.Point(0, 0);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PrefixSuffixText = null;
            this.txt_Search.ReadOnly = false;
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(426, 48);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.TabStop = false;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TrailingIcon = null;
            this.txt_Search.UseAccent = false;
            this.txt_Search.UseSystemPasswordChar = false;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_Ongoing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel searchPanel;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private System.Windows.Forms.DataVisualization.Charting.Chart gradeChart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Enrolled;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar examProgress;
        private System.Windows.Forms.Label label3;
    }
}