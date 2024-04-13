namespace Student_Management.UTILITIES.Export
{
    partial class frm_Export
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
            this.cmb_Options = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Export = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cmb_Options
            // 
            this.cmb_Options.AutoResize = false;
            this.cmb_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Options.Depth = 0;
            this.cmb_Options.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Options.DropDownHeight = 174;
            this.cmb_Options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Options.DropDownWidth = 121;
            this.cmb_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Options.FormattingEnabled = true;
            this.cmb_Options.IntegralHeight = false;
            this.cmb_Options.ItemHeight = 43;
            this.cmb_Options.Items.AddRange(new object[] {
            ".jpg",
            ".png"});
            this.cmb_Options.Location = new System.Drawing.Point(186, 61);
            this.cmb_Options.MaxDropDownItems = 4;
            this.cmb_Options.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Options.Name = "cmb_Options";
            this.cmb_Options.Size = new System.Drawing.Size(272, 49);
            this.cmb_Options.StartIndex = 0;
            this.cmb_Options.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(31, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Export Options:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(211, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(220, 14);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Exported File will be delivered to Desktop";
            // 
            // btn_Export
            // 
            this.btn_Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Export.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Export.Depth = 0;
            this.btn_Export.HighEmphasis = true;
            this.btn_Export.Icon = null;
            this.btn_Export.Location = new System.Drawing.Point(199, 151);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Export.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Export.Size = new System.Drawing.Size(77, 36);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export";
            this.btn_Export.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Export.UseAccentColor = false;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // frm_Export
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(496, 224);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmb_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmb_Options;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_Export;
    }
}