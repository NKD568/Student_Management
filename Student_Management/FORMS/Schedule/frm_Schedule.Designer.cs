namespace Student_Management
{
    partial class frm_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Schedule));
            this.cardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.ic_ToRight = new System.Windows.Forms.PictureBox();
            this.ic_ToLeft = new System.Windows.Forms.PictureBox();
            this.btn_Add = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.dtp_SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Today = new MaterialSkin.Controls.MaterialButton();
            this.deleteTimer = new System.Windows.Forms.Timer(this.components);
            this.updateInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Export = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ic_ToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_ToLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // cardContainer
            // 
            this.cardContainer.Location = new System.Drawing.Point(53, 129);
            this.cardContainer.Name = "cardContainer";
            this.cardContainer.Size = new System.Drawing.Size(1100, 600);
            this.cardContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(100, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(245, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(397, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(535, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(695, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(856, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(997, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Saturday";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.Location = new System.Drawing.Point(99, 22);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(128, 39);
            this.lbl_Month.TabIndex = 1;
            this.lbl_Month.Text = "MONTH";
            // 
            // ic_ToRight
            // 
            this.ic_ToRight.Image = global::Student_Management.Properties.Resources.arrow_right;
            this.ic_ToRight.Location = new System.Drawing.Point(352, 20);
            this.ic_ToRight.Name = "ic_ToRight";
            this.ic_ToRight.Size = new System.Drawing.Size(41, 41);
            this.ic_ToRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ic_ToRight.TabIndex = 3;
            this.ic_ToRight.TabStop = false;
            this.ic_ToRight.Click += new System.EventHandler(this.ic_ToRight_Click);
            // 
            // ic_ToLeft
            // 
            this.ic_ToLeft.Image = global::Student_Management.Properties.Resources.arrow_left;
            this.ic_ToLeft.Location = new System.Drawing.Point(305, 20);
            this.ic_ToLeft.Name = "ic_ToLeft";
            this.ic_ToLeft.Size = new System.Drawing.Size(41, 41);
            this.ic_ToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ic_ToLeft.TabIndex = 2;
            this.ic_ToLeft.TabStop = false;
            this.ic_ToLeft.Click += new System.EventHandler(this.ic_ToLeft_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Add.Depth = 0;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Icon = ((System.Drawing.Image)(resources.GetObject("btn_Add.Icon")));
            this.btn_Add.Location = new System.Drawing.Point(1119, 74);
            this.btn_Add.Mini = true;
            this.btn_Add.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // dtp_SelectedDate
            // 
            this.dtp_SelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_SelectedDate.Location = new System.Drawing.Point(541, 30);
            this.dtp_SelectedDate.Name = "dtp_SelectedDate";
            this.dtp_SelectedDate.Size = new System.Drawing.Size(321, 35);
            this.dtp_SelectedDate.TabIndex = 13;
            this.dtp_SelectedDate.ValueChanged += new System.EventHandler(this.dtp_SelectedDate_ValueChanged);
            // 
            // btn_Today
            // 
            this.btn_Today.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Today.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Today.Depth = 0;
            this.btn_Today.Enabled = false;
            this.btn_Today.HighEmphasis = true;
            this.btn_Today.Icon = null;
            this.btn_Today.Location = new System.Drawing.Point(869, 29);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Today.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Today.Size = new System.Drawing.Size(69, 36);
            this.btn_Today.TabIndex = 14;
            this.btn_Today.Text = "Today";
            this.btn_Today.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Today.UseAccentColor = false;
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // deleteTimer
            // 
            this.deleteTimer.Enabled = true;
            this.deleteTimer.Interval = 50;
            this.deleteTimer.Tick += new System.EventHandler(this.deleteTimer_Tick);
            // 
            // updateInfoTimer
            // 
            this.updateInfoTimer.Enabled = true;
            this.updateInfoTimer.Interval = 30;
            this.updateInfoTimer.Tick += new System.EventHandler(this.updateInfoTimer_Tick);
            // 
            // btn_Export
            // 
            this.btn_Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Export.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Export.Depth = 0;
            this.btn_Export.HighEmphasis = true;
            this.btn_Export.Icon = null;
            this.btn_Export.Location = new System.Drawing.Point(1013, 29);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Export.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Export.Size = new System.Drawing.Size(77, 36);
            this.btn_Export.TabIndex = 19;
            this.btn_Export.Text = "Export";
            this.btn_Export.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Export.UseAccentColor = false;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Visible = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // frm_Schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Today);
            this.Controls.Add(this.dtp_SelectedDate);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ic_ToRight);
            this.Controls.Add(this.ic_ToLeft);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Schedule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ic_ToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_ToLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cardContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.PictureBox ic_ToLeft;
        private System.Windows.Forms.PictureBox ic_ToRight;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton btn_Add;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DateTimePicker dtp_SelectedDate;
        private MaterialSkin.Controls.MaterialButton btn_Today;
        private System.Windows.Forms.Timer deleteTimer;
        private System.Windows.Forms.Timer updateInfoTimer;
        private MaterialSkin.Controls.MaterialButton btn_Export;
    }
}

