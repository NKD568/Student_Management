﻿namespace Student_Management.FORMS.Student
{
    partial class frm_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student));
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Add = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_seachOptions = new MaterialSkin.Controls.MaterialComboBox();
            this.cardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // deleteTimer
            // 
            this.deleteTimer.Enabled = true;
            this.deleteTimer.Tick += new System.EventHandler(this.deleteTimer_Tick);
            // 
            // btn_Add
            // 
            this.btn_Add.Depth = 0;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Icon = ((System.Drawing.Image)(resources.GetObject("btn_Add.Icon")));
            this.btn_Add.Location = new System.Drawing.Point(1124, 709);
            this.btn_Add.Mini = true;
            this.btn_Add.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.AnimateReadOnly = false;
            this.txt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Depth = 0;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.HideSelection = true;
            this.txt_Search.Hint = "Search";
            this.txt_Search.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_Search.LeadingIcon")));
            this.txt_Search.Location = new System.Drawing.Point(24, 51);
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
            this.txt_Search.Size = new System.Drawing.Size(355, 48);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.TabStop = false;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TrailingIcon = null;
            this.txt_Search.UseSystemPasswordChar = false;
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_seachOptions
            // 
            this.cmb_seachOptions.AutoResize = false;
            this.cmb_seachOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.cmb_seachOptions.Depth = 0;
            this.cmb_seachOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_seachOptions.DropDownHeight = 174;
            this.cmb_seachOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seachOptions.DropDownWidth = 121;
            this.cmb_seachOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_seachOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_seachOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_seachOptions.FormattingEnabled = true;
            this.cmb_seachOptions.Hint = "By";
            this.cmb_seachOptions.IntegralHeight = false;
            this.cmb_seachOptions.ItemHeight = 43;
            this.cmb_seachOptions.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Email"});
            this.cmb_seachOptions.Location = new System.Drawing.Point(385, 50);
            this.cmb_seachOptions.MaxDropDownItems = 4;
            this.cmb_seachOptions.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_seachOptions.Name = "cmb_seachOptions";
            this.cmb_seachOptions.Size = new System.Drawing.Size(178, 49);
            this.cmb_seachOptions.StartIndex = 0;
            this.cmb_seachOptions.TabIndex = 6;
            this.cmb_seachOptions.SelectedIndexChanged += new System.EventHandler(this.cmb_seachOptions_SelectedIndexChanged);
            // 
            // cardContainer
            // 
            this.cardContainer.AutoScroll = true;
            this.cardContainer.BackColor = System.Drawing.Color.MintCream;
            this.cardContainer.Location = new System.Drawing.Point(24, 103);
            this.cardContainer.Name = "cardContainer";
            this.cardContainer.Size = new System.Drawing.Size(1100, 600);
            this.cardContainer.TabIndex = 8;
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            this.searchResult.AllowUserToResizeRows = false;
            this.searchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.ColumnHeadersVisible = false;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.result});
            this.searchResult.Location = new System.Drawing.Point(24, 93);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.RowHeadersWidth = 62;
            this.searchResult.RowTemplate.Height = 30;
            this.searchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResult.Size = new System.Drawing.Size(340, 0);
            this.searchResult.TabIndex = 9;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.HeaderText = "result";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // frm_Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.cardContainer);
            this.Controls.Add(this.cmb_seachOptions);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Student";
            this.Text = "frm_Student";
            this.Load += new System.EventHandler(this.frm_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialFloatingActionButton btn_Add;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Timer deleteTimer;
        private MaterialSkin.Controls.MaterialComboBox cmb_seachOptions;
        private System.Windows.Forms.FlowLayoutPanel cardContainer;
        private System.Windows.Forms.DataGridView searchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}