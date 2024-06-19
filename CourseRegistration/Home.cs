using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class Home : Form
    {
        List<CourseButton> buttons = new List<CourseButton>();
        public delegate void DelegateMoveToSearchPage();
        public DelegateMoveToSearchPage? moveToSearchPage;

        public class CourseButton
        {
            public Label course;
            private Label profTime;
            private Label numRate;

            private Button addBtn;
            private Button delBtn;

            public CourseButton(Label course, Label profTime, Label numRate, Button addBtn, Button delBtn)
            {
                this.course = course;
                this.profTime = profTime;
                this.numRate = numRate;

                this.addBtn = addBtn;
                this.delBtn = delBtn;

                this.course.Text = "";
                this.profTime.Text = "";
                this.numRate.Text = "";
            }

            public void AddCourse(string course, string prof, string time, string num, string rate)
            {
                this.course.Text = course;
                this.profTime.Text = prof + " | " + time;
                this.numRate.Text = num + "담음 | " + rate;

                this.addBtn.Visible = false;
                this.delBtn.Visible = true;
            }

            public void DeleteCourse()
            {
                this.course.Text = "";
                this.profTime.Text = "";
                this.numRate.Text = "";
                this.addBtn.Visible = true;
                this.delBtn.Visible = false;
            }
        }

        public void SetCourseButton(int index, string course, string prof, string time, string num, string rate)
        {
            buttons[index].AddCourse(course, prof, time, num, rate);
        }

        public int GetFirstEmptyCourseButton()
        {
            int i = 0;

            foreach (CourseButton btn in buttons)
            {
                if (btn.course.Text == "") return i;
                i++;
            }
            return -1;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );



        public Home()
        {
            InitializeComponent();

            buttons.Add(new CourseButton(courseName1, profNum1, numRate1, courseBtn1, deleteBtn1));
            buttons.Add(new CourseButton(courseName2, profNum2, numRate2, courseBtn2, deleteBtn2));
            buttons.Add(new CourseButton(courseName3, profNum3, numRate3, courseBtn3, deleteBtn3));
            buttons.Add(new CourseButton(courseName4, profNum4, numRate4, courseBtn4, deleteBtn4));
            buttons.Add(new CourseButton(courseName5, profNum5, numRate5, courseBtn5, deleteBtn5));
            buttons.Add(new CourseButton(courseName6, profNum6, numRate6, courseBtn6, deleteBtn6));
            buttons.Add(new CourseButton(courseName7, profNum7, numRate7, courseBtn7, deleteBtn7));
            buttons.Add(new CourseButton(courseName8, profNum8, numRate8, courseBtn8, deleteBtn8));
            buttons.Add(new CourseButton(courseName9, profNum9, numRate9, courseBtn9, deleteBtn9));

            //ControlPaint.DrawBorder(.Graphics, this.Friday.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            moveToSearchPage!();
        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            buttons[0].DeleteCourse();
        }

        private void deleteBtn2_Click(object sender, EventArgs e)
        {
            buttons[1].DeleteCourse();
        }

        private void deleteBtn3_Click(object sender, EventArgs e)
        {
            buttons[2].DeleteCourse();
        }

        private void deleteBtn4_Click(object sender, EventArgs e)
        {
            buttons[3].DeleteCourse();
        }

        private void deleteBtn5_Click(object sender, EventArgs e)
        {
            buttons[4].DeleteCourse();
        }

        private void deleteBtn6_Click(object sender, EventArgs e)
        {
            buttons[5].DeleteCourse();
        }

        private void deleteBtn7_Click(object sender, EventArgs e)
        {
            buttons[6].DeleteCourse();
        }

        private void deleteBtn8_Click(object sender, EventArgs e)
        {
            buttons[7].DeleteCourse();
        }

        private void deleteBtn9_Click(object sender, EventArgs e)
        {
            buttons[8].DeleteCourse();
        }
    }
}
