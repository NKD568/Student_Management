namespace Student_Management.FORMS.Account
{
    partial class ucAccount
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Username = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Level = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_lblPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.updatedTimer = new System.Windows.Forms.Timer(this.components);
            this.optionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Id = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Options = new System.Windows.Forms.PictureBox();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.Location = new System.Drawing.Point(33, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username";
            // 
            // lbl_Username
            // 
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Username.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Username.Location = new System.Drawing.Point(126, 13);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(254, 19);
            this.lbl_Username.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel2.Location = new System.Drawing.Point(868, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Level";
            // 
            // lbl_Level
            // 
            this.lbl_Level.Depth = 0;
            this.lbl_Level.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Level.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Level.Location = new System.Drawing.Point(937, 14);
            this.lbl_Level.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(29, 19);
            this.lbl_Level.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(409, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Password";
            // 
            // txt_lblPassword
            // 
            this.txt_lblPassword.AnimateReadOnly = false;
            this.txt_lblPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_lblPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_lblPassword.Depth = 0;
            this.txt_lblPassword.Enabled = false;
            this.txt_lblPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lblPassword.HideSelection = true;
            this.txt_lblPassword.LeadingIcon = null;
            this.txt_lblPassword.Location = new System.Drawing.Point(497, 8);
            this.txt_lblPassword.MaxLength = 32767;
            this.txt_lblPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_lblPassword.Name = "txt_lblPassword";
            this.txt_lblPassword.PasswordChar = '●';
            this.txt_lblPassword.PrefixSuffixText = null;
            this.txt_lblPassword.ReadOnly = false;
            this.txt_lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lblPassword.SelectedText = "";
            this.txt_lblPassword.SelectionLength = 0;
            this.txt_lblPassword.SelectionStart = 0;
            this.txt_lblPassword.ShortcutsEnabled = true;
            this.txt_lblPassword.Size = new System.Drawing.Size(312, 36);
            this.txt_lblPassword.TabIndex = 1;
            this.txt_lblPassword.TabStop = false;
            this.txt_lblPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_lblPassword.TrailingIcon = null;
            this.txt_lblPassword.UseSystemPasswordChar = true;
            this.txt_lblPassword.UseTallSize = false;
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.borderPanel.BackColor = System.Drawing.Color.Green;
            this.borderPanel.Location = new System.Drawing.Point(0, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(10, 52);
            this.borderPanel.TabIndex = 2;
            // 
            // updatedTimer
            // 
            this.updatedTimer.Tick += new System.EventHandler(this.updatedTimer_Tick);
            // 
            // optionMenu
            // 
            this.optionMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.optionMenu.Name = "contextMenuStrip1";
            this.optionMenu.Size = new System.Drawing.Size(143, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Student_Management.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Student_Management.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.Depth = 0;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Id.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_Id.Location = new System.Drawing.Point(16, 16);
            this.lbl_Id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 19);
            this.lbl_Id.TabIndex = 3;
            this.lbl_Id.Visible = false;
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Options.Image = global::Student_Management.Properties.Resources.options;
            this.btn_Options.Location = new System.Drawing.Point(1028, 11);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(24, 24);
            this.btn_Options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Options.TabIndex = 16;
            this.btn_Options.TabStop = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // ucAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.borderPanel);
            this.Controls.Add(this.txt_lblPassword);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(1075, 50);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Options)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_Level;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txt_lblPassword;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Timer updatedTimer;
        private System.Windows.Forms.ContextMenuStrip optionMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lbl_Id;
        private System.Windows.Forms.PictureBox btn_Options;
    }
}
