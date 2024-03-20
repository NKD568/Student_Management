namespace Student_Management.FORMS.Account
{
    partial class frm_Login
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
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.cb_RemeberMe = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox2();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.gpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDetails
            // 
            this.gpDetails.BackColor = System.Drawing.Color.Honeydew;
            this.gpDetails.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpDetails.BorderWidth = 1;
            this.gpDetails.Controls.Add(this.logoApp);
            this.gpDetails.Controls.Add(this.smallLabel1);
            this.gpDetails.Controls.Add(this.cb_RemeberMe);
            this.gpDetails.Controls.Add(this.btn_Login);
            this.gpDetails.Controls.Add(this.txt_Password);
            this.gpDetails.Controls.Add(this.txt_Username);
            this.gpDetails.Controls.Add(this.headerLabel1);
            this.gpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(3, 24);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(739, 399);
            this.gpDetails.TabIndex = 10;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Login Page";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.Image = global::Student_Management.Properties.Resources.student_center_100;
            this.logoApp.Location = new System.Drawing.Point(324, 13);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(100, 100);
            this.logoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoApp.TabIndex = 14;
            this.logoApp.TabStop = false;
            // 
            // smallLabel1
            // 
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.Black;
            this.smallLabel1.Location = new System.Drawing.Point(132, 146);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(483, 22);
            this.smallLabel1.TabIndex = 16;
            this.smallLabel1.Text = "---------------------------------------------------------------------------------" +
    "";
            this.smallLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_RemeberMe
            // 
            this.cb_RemeberMe.BackColor = System.Drawing.Color.Transparent;
            this.cb_RemeberMe.Location = new System.Drawing.Point(494, 294);
            this.cb_RemeberMe.Name = "cb_RemeberMe";
            this.cb_RemeberMe.Size = new System.Drawing.Size(121, 20);
            this.cb_RemeberMe.TabIndex = 13;
            this.cb_RemeberMe.Text = "Remember Me";
            this.cb_RemeberMe.UseSelectable = true;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(339, 322);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(82, 36);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "     Login     ";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.HideSelection = true;
            this.txt_Password.Hint = "Password";
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(132, 240);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PrefixSuffixText = null;
            this.txt_Password.ReadOnly = false;
            this.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(483, 48);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.TabStop = false;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TrailingIcon = null;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.HideSelection = true;
            this.txt_Username.Hint = "Username";
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(132, 171);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PrefixSuffixText = null;
            this.txt_Username.ReadOnly = false;
            this.txt_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.ShortcutsEnabled = true;
            this.txt_Username.Size = new System.Drawing.Size(483, 48);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TabStop = false;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.TrailingIcon = null;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.Black;
            this.headerLabel1.Location = new System.Drawing.Point(136, 100);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(479, 56);
            this.headerLabel1.TabIndex = 15;
            this.headerLabel1.Text = "Student Management Application";
            this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(745, 426);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Login_FormClosed);
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private ReaLTaiizor.Controls.PoisonCheckBox cb_RemeberMe;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Username;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private System.Windows.Forms.PictureBox logoApp;
    }
}