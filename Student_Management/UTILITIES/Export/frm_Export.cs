using Student_Management.FORMS.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.UTILITIES.Export
{
    public partial class frm_Export : Form
    {
        Form frm;
        public frm_Export(Form _frm)
        {
            InitializeComponent();
            frm = _frm;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Capture the form as a bitmap
            Bitmap bitmap = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(bitmap, new Rectangle(0, 0, frm.Width, frm.Height));

            // Get the path to the desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName;
            switch (cmb_Options.SelectedItem.ToString())
            {
                default:
                case ".jpg":
                    fileName = frm.Name +".jpg";
                    string pngFilePath = Path.Combine(desktopPath, fileName);
                    bitmap.Save(pngFilePath, ImageFormat.Jpeg);
                    break;
                case ".png":
                    fileName = frm.Name + ".png";
                    string jpgFilePath = Path.Combine(desktopPath, fileName);
                    bitmap.Save(jpgFilePath, ImageFormat.Png);
                    break;

            }
            // Dispose bitmap
            bitmap.Dispose();
            frm_Main notify = new frm_Main();
            notify.showToast("INFO","File Saved to Desktop!");
            this.Close();
        }

    }
}

