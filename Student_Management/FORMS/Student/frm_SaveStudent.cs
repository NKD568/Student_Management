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
    public partial class frm_SaveStudent : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public frm_SaveStudent()
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

        // For Image
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public static bool refresh = false;
        public static bool isUpdate = false;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(update == false)
            {
                StudentInfo save = new StudentInfo();
                save.id = Convert.ToInt32(txt_ID.Text);
                save.name = txt_Name.Text;
                save.birthdate = dtpBirthdate.Value;
                save.email = txt_Email.Text;
                save.Save();
                refresh = true;
            }
            else{
                StudentInfo up = new StudentInfo();
                up.update(txt_Name.Text, dtpBirthdate.Value, txt_Email.Text, ucStudent.public_id);
                isUpdate = true;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        bool update = false;
        private void frm_AddStudent_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (ucStudent.view == true)
            {
                txt_ID.Enabled = false;
                getDetail();
                btn_Save.Text = "UPDATE";
                update = true;
                ucStudent.view = false;
            }
            else
            {
                txt_ID.Enabled = true;
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void getDetail()
        {
            StudentInfo get = new StudentInfo();
            get.getDetails(ucStudent.public_id);
            txt_ID.Text = get.id.ToString();
            txt_Name.Text = get.name;
            dtpBirthdate.Value = get.birthdate;
            txt_Email.Text = get.email;
        }

    }
}
