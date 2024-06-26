﻿using MaterialSkin;
using MaterialSkin.Controls;
using Student_Management.FORMS.Main;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Management.FORMS.Course
{
    public partial class frm_SaveCourse : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        public frm_SaveCourse()
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
        public static bool refresh = false;
        public static bool isUpdate = false;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm_Main notify = new frm_Main();
            if (update == false)
            {
                CourseInfo save = new CourseInfo();
                save.name = txt_Name.Text;
                save.description = txt_Description.Text;
                save.credits = trackBar_Credits.Value;
                save.isOpen = getCmbIsOpenItemValue();
                save.Save();
                refresh = true;
                notify.showToast("SUCESS", "Sucessfully Saved");
            }
            else
            {
                CourseInfo up = new CourseInfo();
                up.update(txt_Name.Text, txt_Description.Text, trackBar_Credits.Value, getCmbIsOpenItemValue(), ucCourse.public_id);
                isUpdate = true;
                notify.showToast("SUCESS", "Sucessfully Updated");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CourseInfo save = new CourseInfo();
            bool isExist = save.checkDuplicateName(txt_Name.Text);
            if (txt_Name.Text == "" || txt_Description.Text == "")
            {
                MessageBox.Show("Please type all informations!");
                return;
            }
            if (isExist && txt_Name.Text != ucCourse.public_name)
            {
                MessageBox.Show("Name is already taken!");
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        bool update = false;
        private void frm_SaveCourse_Load(object sender, EventArgs e)
        {
            if (ucCourse.view == true)
            {
                getDetail();
                btn_Save.Text = "UPDATE";
                update = true;
                ucCourse.view = false;
            }
            else
            {
                btn_Save.Text = "SAVE";
                update = false;
            }
        }

        private void getDetail()
        {
            CourseInfo get = new CourseInfo();
            get.getDetails(ucCourse.public_id);           
            txt_Name.Text = get.name;
            txt_Description.Text = get.description;
            trackBar_Credits.Value = get.credits;
            cmb_isOpen.SelectedItem = get.isOpen == true? "True" : "False" ;
            bool isOccupied = get.isOccupied(ucCourse.public_id);
            if (isOccupied)
            {
                frm_Main show = new frm_Main();
                show.showToast("INFO", "This Course is Occupied!");
                cmb_isOpen.Enabled = false;
            }
            else
            {
                cmb_isOpen.Enabled = true;
            }
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

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                 txt_Name.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private bool getCmbIsOpenItemValue()
        {
            string selectedItem = cmb_isOpen.SelectedItem.ToString();
            bool selectedBoolValue = false;
            if (selectedItem == "True")
            {
                selectedBoolValue = true;
            }
            else if (selectedItem == "False")
            {
                selectedBoolValue = false;
            }
            return selectedBoolValue;
        }

    }
}
