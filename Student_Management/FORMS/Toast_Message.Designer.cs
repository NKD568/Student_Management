namespace Student_Management.FORMS
{
    partial class Toast_Message
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
            this.toastBorder = new System.Windows.Forms.Panel();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toastBorder
            // 
            this.toastBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.toastBorder.Location = new System.Drawing.Point(-1, 0);
            this.toastBorder.Name = "toastBorder";
            this.toastBorder.Size = new System.Drawing.Size(10, 59);
            this.toastBorder.TabIndex = 0;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Type.Location = new System.Drawing.Point(53, 3);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(51, 25);
            this.lbl_Type.TabIndex = 2;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(54, 29);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(110, 21);
            this.lbl_Message.TabIndex = 2;
            this.lbl_Message.Text = "Toast Message";
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Student_Management.Properties.Resources.ok_32;
            this.picIcon.Location = new System.Drawing.Point(21, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(20, 20);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // Toast_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 59);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.toastBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast_Message";
            this.Text = "Toast_Message";
            this.Load += new System.EventHandler(this.Toast_Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastBorder;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}