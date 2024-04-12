using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.FORMS.Course
{
    public partial class CourseHome : Form
    {
        public CourseHome()
        {
            InitializeComponent();
            CoursePage _course = new CoursePage();
            tabPage_Course.Controls.Add(_course);
            ClassPage _class = new ClassPage();
            tabPage_Class.Controls.Add(_class);
        }
    }
}
