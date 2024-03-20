using Student_Management.FORMS.Account;
using Student_Management.FORMS.Course;
using Student_Management.FORMS.Grade;
using Student_Management.FORMS.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Main
{
    public partial class frm_Main : Form
    {
        // UI
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;


        private const int CS_DROPSAHDOW = 0x0020000;
        private const int WM_NC_PAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nToptRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSAHDOW; return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if(Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1)? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg) {

                case WM_NC_PAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0,
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                    default: break;

            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        // UX 
        public static string connstring = "server=localhost;user=root;database=student_managementdb;sslmode=none;ConvertZeroDateTime=True";
        List<ucMenu> menuButtons;
        frm_Student student;
        frm_Course course;
        frm_Grade grade;
        frm_Schedule schedule;
        frm_Account account;

        public int mdiScreenWidth;
        public int mdiScreenHeight;

        public frm_Main()
        {
            InitializeComponent();
            mdiProp();
            menuButtons = new List<ucMenu>() {menuDashboard, menuGrade, menuCourse, menuStudent, menuSchedule, menuAccount};
            ClickMenu(menuButtons);          
            mdiScreenWidth = this.Width - menuSidebar.Size.Width;
            mdiScreenHeight = this.Height - Topbar.Size.Height;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            switch (frm_Login.loginLevel)
            {
                case 0:
                    break;
                case 2:
                    menuDashboard.Hide();
                    break;
            }
        }

        private void ClickMenu(List<ucMenu> _menu)
        {
            foreach(var menu in _menu)
            {
                menu.menuClick += Menu_menuClick;
            }
        }

        private void Menu_menuClick(object sender, EventArgs e)
        {
            ucMenu _menuButton = (ucMenu)sender;

            switch(_menuButton.Menu) {

                case "Dashboard":
                    activeMenu(menuDashboard, menuGrade, menuCourse, menuStudent, menuSchedule, menuAccount);
                    Grade_Click();
                    break;
                case "Grade":
                    activeMenu(menuGrade, menuCourse, menuStudent, menuSchedule, menuDashboard, menuAccount);
                    Grade_Click();
                    break;
                case "Course":
                    activeMenu(menuCourse, menuGrade, menuStudent, menuSchedule, menuDashboard, menuAccount);
                    Course_Click();
                    break;
                case "Student":
                    activeMenu(menuStudent, menuGrade, menuCourse, menuSchedule, menuDashboard, menuAccount);
                    Student_Click();
                    break;
                case "Schedule":
                    activeMenu(menuSchedule, menuGrade, menuStudent, menuCourse, menuDashboard, menuAccount);
                    Schedule_Click();
                    break;                   
                case "Account":
                    activeMenu(menuAccount ,menuSchedule, menuGrade, menuStudent, menuCourse, menuDashboard);
                    Account_Click();
                    break;
            }
        }

        private void activeMenu(ucMenu _active, params ucMenu[] _inactive)
        {
            _active.BorderColor = Color.White;
            foreach(ucMenu inactive in _inactive)
            {
                inactive.BorderColor = Color.Transparent;
            }
        }

        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }

        private void Schedule_Click()
        {
            if (schedule == null)
            {
                schedule = new frm_Schedule();
                schedule.FormClosed += Schedule_FormClosed;
                schedule.MdiParent = this;
                schedule.Dock = DockStyle.Fill;

                schedule.Show();
            }
            else
            {
                schedule.Activate();
            }
        }
        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            schedule = null;
        }

        private void Student_Click()
        {
            if (student == null)
            {
                student = new frm_Student();
                student.FormClosed += Student_FormClosed;
                student.MdiParent = this;
                student.Dock = DockStyle.Fill;

                student.Show();
            }
            else
            {
                student.Activate();
            }
        }
        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            student = null;
        }

        private void Course_Click()
        {
            if (course == null)
            {
                course = new frm_Course();
                course.FormClosed += Course_FormClosed;
                course.MdiParent = this;
                course.Dock = DockStyle.Fill;

                course.Show();
            }
            else
            {
                course.Activate();
            }
        }
        private void Course_FormClosed(object sender, FormClosedEventArgs e)
        {
            course = null;
        }

        private void Grade_Click()
        {
            if (grade == null)
            {
                grade = new frm_Grade();
                grade.FormClosed += Grade_FormClosed;
                grade.MdiParent = this;
                grade.Dock = DockStyle.Fill;

                grade.Show();
            }
            else
            {
                grade.Activate();
            }
        }
        private void Grade_FormClosed(object sender, FormClosedEventArgs e)
        {
            grade = null;
        }

        private void Account_Click()
        {
            if (account == null)
            {
                account = new frm_Account();
                account.FormClosed += Account_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;

                account.Show();
            }
            else
            {
                account.Activate();
            }
        }
        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            account = null;
        }


        public void showToast(string type, string message)
        {
            Toast_Message toast = new Toast_Message(type, message);
            toast.Show();
        }


    }
}
