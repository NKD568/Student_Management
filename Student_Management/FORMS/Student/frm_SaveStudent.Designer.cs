namespace Student_Management.FORMS.Student
{
    partial class frm_SaveStudent
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
            this.txt_Email = new MaterialSkin.Controls.MaterialTextBox2();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.dtpBirthdate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.txt_Name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_ID = new MaterialSkin.Controls.MaterialTextBox2();
            this.gpDetails = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.AnimateReadOnly = false;
            this.txt_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Email.Depth = 0;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Email.HideSelection = true;
            this.txt_Email.Hint = "Email";
            this.txt_Email.LeadingIcon = null;
            this.txt_Email.Location = new System.Drawing.Point(41, 233);
            this.txt_Email.MaxLength = 32767;
            this.txt_Email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PrefixSuffixText = null;
            this.txt_Email.ReadOnly = false;
            this.txt_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Email.SelectedText = "";
            this.txt_Email.SelectionLength = 0;
            this.txt_Email.SelectionStart = 0;
            this.txt_Email.ShortcutsEnabled = true;
            this.txt_Email.Size = new System.Drawing.Size(483, 48);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.TabStop = false;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.TrailingIcon = null;
            this.txt_Email.UseSystemPasswordChar = false;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(36, 176);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(101, 28);
            this.nightLabel1.TabIndex = 3;
            this.nightLabel1.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(168, 168);
            this.dtpBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(356, 39);
            this.dtpBirthdate.TabIndex = 2;
            this.dtpBirthdate.Value = new System.DateTime(2024, 3, 12, 0, 0, 0, 0);
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            this.dtpBirthdate.MouseEnter += new System.EventHandler(this.dtpBirthdate_MouseEnter);
            // 
            // txt_Name
            // 
            this.txt_Name.AnimateReadOnly = false;
            this.txt_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Name.Depth = 0;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Name.HideSelection = true;
            this.txt_Name.Hint = "Name";
            this.txt_Name.LeadingIcon = null;
            this.txt_Name.Location = new System.Drawing.Point(41, 99);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PrefixSuffixText = null;
            this.txt_Name.ReadOnly = false;
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.ShortcutsEnabled = true;
            this.txt_Name.Size = new System.Drawing.Size(483, 48);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Name.TrailingIcon = null;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Text_KeyPress);
            this.txt_Name.Leave += new System.EventHandler(this.txt_NullCheck);
            // 
            // txt_ID
            // 
            this.txt_ID.AnimateReadOnly = false;
            this.txt_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ID.Depth = 0;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ID.HideSelection = true;
            this.txt_ID.Hint = "ID";
            this.txt_ID.LeadingIcon = null;
            this.txt_ID.Location = new System.Drawing.Point(41, 45);
            this.txt_ID.MaxLength = 32767;
            this.txt_ID.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PrefixSuffixText = null;
            this.txt_ID.ReadOnly = false;
            this.txt_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ID.SelectedText = "";
            this.txt_ID.SelectionLength = 0;
            this.txt_ID.SelectionStart = 0;
            this.txt_ID.ShortcutsEnabled = true;
            this.txt_ID.Size = new System.Drawing.Size(483, 48);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TabStop = false;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.TrailingIcon = null;
            this.txt_ID.UseSystemPasswordChar = false;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            this.txt_ID.Leave += new System.EventHandler(this.txt_NullCheck);
            // 
            // gpDetails
            // 
            this.gpDetails.BackColor = System.Drawing.Color.White;
            this.gpDetails.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpDetails.BorderWidth = 1;
            this.gpDetails.Controls.Add(this.btn_Save);
            this.gpDetails.Controls.Add(this.txt_ID);
            this.gpDetails.Controls.Add(this.txt_Email);
            this.gpDetails.Controls.Add(this.txt_Name);
            this.gpDetails.Controls.Add(this.nightLabel1);
            this.gpDetails.Controls.Add(this.dtpBirthdate);
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(6, 27);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(570, 362);
            this.gpDetails.TabIndex = 7;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Details";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(254, 307);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "     Save     ";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_SaveStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 398);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveStudent";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddStudent";
            this.Load += new System.EventHandler(this.frm_SaveStudent_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_ID;
        private ReaLTaiizor.Controls.PoisonDateTime dtpBirthdate;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Email;
        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton btn_Save;
    }
}