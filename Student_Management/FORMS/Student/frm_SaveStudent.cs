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
using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

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
            }
            else{
                StudentInfo up = new StudentInfo();
                up.update(txt_Name.Text, dtpBirthdate.Value, txt_Email.Text, ucStudent.public_id);           
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_Name.Text == "" || txt_Email.Text == "")
            {
                MessageBox.Show("Please type all informations!");
                return;
            }

            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        bool update = false;

        private void getDetail()
        {
            StudentInfo get = new StudentInfo();
            get.getDetails(ucStudent.public_id);
            txt_ID.Text = get.id.ToString();
            txt_Name.Text = get.name;
            dtpBirthdate.Value = get.birthdate;
            txt_Email.Text = get.email;
        }

        private void frm_SaveStudent_Load(object sender, EventArgs e)
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
                dtpBirthdate.Value = DateTime.Today.AddDays(-1);
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                 txt_ID.TextLength >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) &&  !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) ||
                 txt.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Email.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private DateTime selectedDate;
        private void dtpBirthdate_MouseEnter(object sender, EventArgs e)
        {
            selectedDate = dtpBirthdate.Value;
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBirthdate.Value == DateTime.Today || dtpBirthdate.Value > DateTime.Today)
            {
                // Your logic here, e.g., display an error message or prevent future selection
                MessageBox.Show("Please select a date that is not today or in the future.");
                // Optionally, set the datepicker value to the current date:
                dtpBirthdate.Value = selectedDate;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (validateEmail(txt_Email.Text) == false)
            {
                TextBox txt = (TextBox)sender;
                txt.Focus();
                MessageBox.Show("Please enter a valid email address.");
                
            }
        }

        private bool validateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
        }

        private void txt_NullCheck(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 0)
            {
                txt.Focus();
                MessageBox.Show("This field must not be empty!");
            }
        }


    }
}
