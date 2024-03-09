namespace Student_Management.FORMS.Main
{
    partial class ucMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Label();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = global::Student_Management.Properties.Resources.schedule_24;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(94, 52);
            this.menu.TabIndex = 0;
            this.menu.Text = "label";
            this.menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.borderPanel.BackColor = System.Drawing.Color.White;
            this.borderPanel.Location = new System.Drawing.Point(-4, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(10, 52);
            this.borderPanel.TabIndex = 1;
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.borderPanel);
            this.Controls.Add(this.menu);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(94, 52);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Panel borderPanel;
    }
}
