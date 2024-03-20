namespace Student_Management.FORMS.Account
{
    partial class splashScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Location = new System.Drawing.Point(-1, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 16);
            this.panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(145)))));
            this.progressBar.Location = new System.Drawing.Point(-1, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(47, 12);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(122)))), ((int)(((byte)(167)))));
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 19);
            this.panel2.TabIndex = 2;
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.Image = global::Student_Management.Properties.Resources.student_center_100;
            this.logoApp.Location = new System.Drawing.Point(255, 145);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(100, 100);
            this.logoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoApp.TabIndex = 15;
            this.logoApp.TabStop = false;
            // 
            // splashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(599, 345);
            this.Controls.Add(this.logoApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoApp;
    }
}