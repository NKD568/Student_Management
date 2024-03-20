namespace Student_Management.FORMS.Account
{
    partial class frm_SaveAccount
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
            this.cb_showPass = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_Level = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_isBlocked = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_RestPass = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.gpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDetails
            // 
            this.gpDetails.BackColor = System.Drawing.Color.White;
            this.gpDetails.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpDetails.BorderWidth = 1;
            this.gpDetails.Controls.Add(this.cb_RestPass);
            this.gpDetails.Controls.Add(this.cb_showPass);
            this.gpDetails.Controls.Add(this.materialLabel2);
            this.gpDetails.Controls.Add(this.cmb_Level);
            this.gpDetails.Controls.Add(this.cmb_isBlocked);
            this.gpDetails.Controls.Add(this.materialLabel1);
            this.gpDetails.Controls.Add(this.btn_Save);
            this.gpDetails.Controls.Add(this.txt_Password);
            this.gpDetails.Controls.Add(this.txt_Username);
            this.gpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetails.Location = new System.Drawing.Point(6, 27);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.ShowText = true;
            this.gpDetails.Size = new System.Drawing.Size(570, 327);
            this.gpDetails.TabIndex = 9;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Details";
            this.gpDetails.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // cb_showPass
            // 
            this.cb_showPass.Location = new System.Drawing.Point(403, 161);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(121, 20);
            this.cb_showPass.TabIndex = 13;
            this.cb_showPass.Text = "Show Password";
            this.cb_showPass.UseSelectable = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(48, 201);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Blocked";
            // 
            // cmb_Level
            // 
            this.cmb_Level.AutoResize = false;
            this.cmb_Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Level.Depth = 0;
            this.cmb_Level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Level.DropDownHeight = 174;
            this.cmb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Level.DropDownWidth = 121;
            this.cmb_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Level.FormattingEnabled = true;
            this.cmb_Level.IntegralHeight = false;
            this.cmb_Level.ItemHeight = 43;
            this.cmb_Level.Items.AddRange(new object[] {
            "2",
            "0"});
            this.cmb_Level.Location = new System.Drawing.Point(393, 187);
            this.cmb_Level.MaxDropDownItems = 4;
            this.cmb_Level.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Level.Name = "cmb_Level";
            this.cmb_Level.Size = new System.Drawing.Size(131, 49);
            this.cmb_Level.StartIndex = 0;
            this.cmb_Level.TabIndex = 11;
            // 
            // cmb_isBlocked
            // 
            this.cmb_isBlocked.AutoResize = false;
            this.cmb_isBlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_isBlocked.Depth = 0;
            this.cmb_isBlocked.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_isBlocked.DropDownHeight = 174;
            this.cmb_isBlocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_isBlocked.DropDownWidth = 121;
            this.cmb_isBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_isBlocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_isBlocked.FormattingEnabled = true;
            this.cmb_isBlocked.IntegralHeight = false;
            this.cmb_isBlocked.ItemHeight = 43;
            this.cmb_isBlocked.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmb_isBlocked.Location = new System.Drawing.Point(124, 187);
            this.cmb_isBlocked.MaxDropDownItems = 4;
            this.cmb_isBlocked.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_isBlocked.Name = "cmb_isBlocked";
            this.cmb_isBlocked.Size = new System.Drawing.Size(131, 49);
            this.cmb_isBlocked.StartIndex = 0;
            this.cmb_isBlocked.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(330, 201);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Level";
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
            this.btn_Save.Location = new System.Drawing.Point(249, 275);
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
            this.txt_Password.Location = new System.Drawing.Point(41, 107);
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
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Password.Leave += new System.EventHandler(this.txt_NullCheck);
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
            this.txt_Username.Location = new System.Drawing.Point(41, 38);
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
            this.txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt_Username.Leave += new System.EventHandler(this.txt_NullCheck);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cb_RestPass
            // 
            this.cb_RestPass.Location = new System.Drawing.Point(41, 161);
            this.cb_RestPass.Name = "cb_RestPass";
            this.cb_RestPass.Size = new System.Drawing.Size(121, 20);
            this.cb_RestPass.TabIndex = 13;
            this.cb_RestPass.Text = "Reset Password";
            this.cb_RestPass.UseSelectable = true;
            this.cb_RestPass.Visible = false;
            this.cb_RestPass.CheckedChanged += new System.EventHandler(this.cb_RestPass_CheckedChanged);
            // 
            // frm_SaveAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(586, 361);
            this.Controls.Add(this.gpDetails);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frm_SaveAccount";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaveAccount";
            this.Load += new System.EventHandler(this.frm_SaveAccount_Load);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox gpDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmb_isBlocked;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Password;
        private MaterialSkin.Controls.MaterialComboBox cmb_Level;
        private ReaLTaiizor.Controls.PoisonCheckBox cb_showPass;
        private ReaLTaiizor.Controls.PoisonCheckBox cb_RestPass;
    }
}