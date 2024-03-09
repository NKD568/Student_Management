using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Student_Management.FORMS.Student
{
    public partial class frm_AddStudent : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_AddStudent()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Accent.Cyan700,
                TextShade.WHITE
                );
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void frm_AddStudent_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
