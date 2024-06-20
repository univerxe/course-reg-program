using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows;

namespace CourseRegistration
{
    public partial class Home : Form
    {
        List<CourseButton> buttons = new List<CourseButton>();
        List<RegisterInfo> registers = new List<RegisterInfo>();
        List<Panel> MonPanel = new List<Panel>();
        List<Label> MonLabel = new List<Label>();
        List<Panel> TuePanel = new List<Panel>();
        List<Label> TueLabel = new List<Label>();
        List<Panel> WedPanel = new List<Panel>();
        List<Label> WedLabel = new List<Label>();
        List<Panel> ThuPanel = new List<Panel>();
        List<Label> ThuLabel = new List<Label>();
        List<Label> CourseLabel = new List<Label>();
        List<Button> RegButton = new List<Button>();


        public delegate void DelegateMoveToSearchPage();
        public DelegateMoveToSearchPage? moveToSearchPage;
        public class RegisterInfo
        {
            private string course;
            private string profTime;

            public RegisterInfo(string course, string profTime)
            {
                this.course = course;
                this.profTime = profTime;
            }

            public string GetCourse()
            {
                return course;
            }

            public string GetProfTime()
            {
                return profTime;
            }
        }



        public class CourseButton
        {
            public Label course;
            private Label profTime;
            private Label numRate;
            private string time = "";
            private Button addBtn;
            private Button delBtn;
            private bool isCourse;

            public CourseButton(Label course, Label profTime, Label numRate, Button addBtn, Button delBtn)
            {
                this.course = course;
                this.profTime = profTime;
                this.numRate = numRate;
                this.isCourse = false;

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
                this.time = time;
                this.addBtn.Visible = false;
                this.delBtn.Visible = true;
                this.course.Visible = true;
                this.isCourse = true;
            }

            public void DeleteCourse()
            {
                this.course.Text = "";
                this.profTime.Text = "";
                this.numRate.Text = "";
                this.addBtn.Visible = true;
                this.delBtn.Visible = false;
                this.course.Visible = false;
                this.isCourse = false;
            }

            public bool CheckRegister()
            {
                return this.isCourse;
            }

            public string GetTime()
            {
                return this.time;
            }

            public void ResetTime()
            {
                this.time = "";
            }

            public string GetProfTime()
            {
                return (string)this.profTime.Text;
            }
        }

        public void SetCourseButton(int index, string course, string prof, string time, string num, string rate)
        {
            buttons[index].AddCourse(course, prof, time, num, rate);
            UpdateTable(true);
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
            InitializeTable();
            buttons.Add(new CourseButton(courseName1, profNum1, numRate1, courseBtn1, deleteBtn1));
            buttons.Add(new CourseButton(courseName2, profNum2, numRate2, courseBtn2, deleteBtn2));
            buttons.Add(new CourseButton(courseName3, profNum3, numRate3, courseBtn3, deleteBtn3));
            buttons.Add(new CourseButton(courseName4, profNum4, numRate4, courseBtn4, deleteBtn4));
            buttons.Add(new CourseButton(courseName5, profNum5, numRate5, courseBtn5, deleteBtn5));
            buttons.Add(new CourseButton(courseName6, profNum6, numRate6, courseBtn6, deleteBtn6));
            buttons.Add(new CourseButton(courseName7, profNum7, numRate7, courseBtn7, deleteBtn7));
            buttons.Add(new CourseButton(courseName8, profNum8, numRate8, courseBtn8, deleteBtn8));
            buttons.Add(new CourseButton(courseName9, profNum9, numRate9, courseBtn9, deleteBtn9));

            CourseLabel.Add(regCourse1);
            CourseLabel.Add(regCourse2);
            CourseLabel.Add(regCourse3);
            CourseLabel.Add(regCourse4);
            CourseLabel.Add(regCourse5);
            CourseLabel.Add(regCourse6);
            CourseLabel.Add(regCourse7);
            CourseLabel.Add(regCourse8);

            RegButton.Add(regBtn1);
            RegButton.Add(regBtn2);
            RegButton.Add(regBtn3);
            RegButton.Add(regBtn4);
            RegButton.Add(regBtn5);
            RegButton.Add(regBtn6);
            RegButton.Add(regBtn7);
            RegButton.Add(regBtn8);

            //ControlPaint.DrawBorder(.Graphics, this.Friday.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            moveToSearchPage!();
        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            buttons[0].DeleteCourse();
            UpdateTable(false);
            buttons[0].ResetTime();
        }

        private void deleteBtn2_Click(object sender, EventArgs e)
        {
            buttons[1].DeleteCourse();
            UpdateTable(false);
            buttons[1].ResetTime();
        }

        private void deleteBtn3_Click(object sender, EventArgs e)
        {
            buttons[2].DeleteCourse();
            UpdateTable(false);
            buttons[2].ResetTime();
        }

        private void deleteBtn4_Click(object sender, EventArgs e)
        {
            buttons[3].DeleteCourse();
            UpdateTable(false);
            buttons[3].ResetTime();
        }

        private void deleteBtn5_Click(object sender, EventArgs e)
        {
            buttons[4].DeleteCourse();
            UpdateTable(false);
            buttons[4].ResetTime();
        }

        private void deleteBtn6_Click(object sender, EventArgs e)
        {
            buttons[5].DeleteCourse();
            UpdateTable(false);
            buttons[5].ResetTime();
        }

        private void deleteBtn7_Click(object sender, EventArgs e)
        {
            buttons[6].DeleteCourse();
            UpdateTable(false);
            buttons[6].ResetTime();
        }

        private void deleteBtn8_Click(object sender, EventArgs e)
        {
            buttons[7].DeleteCourse();
            UpdateTable(false);
            buttons[7].ResetTime();
        }

        private void deleteBtn9_Click(object sender, EventArgs e)
        {
            buttons[8].DeleteCourse();
            UpdateTable(false);
            buttons[8].ResetTime();
        }


        public void ChangeTableText(Label label, string name)
        {
            string name1;
            string name2;
            string name3;
            if (name.Length <= 5)
            {
                label.Text = name;
            }
            else if (name.Length <= 10)
            {
                name1 = name.Substring(0, 5);
                name2 = name.Substring(5, name.Length - 5);
                label.Text = name1 + "\n" + name2;
            }
            else
            {
                name1 = name.Substring(0, 5);
                name2 = name.Substring(5, 5);
                name3 = name.Substring(10, name.Length - 10);
                label.Text = name1 + "\n" + name2 + "\n" + name3;
            }
            this.Update();
        }


        public void UpdateTable(bool check)
        {
            char day;
            char time;
            if (check == true)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].course.Text != "")
                    {
                        for (int j = 0; j < buttons[i].GetTime().Length; j += 2)
                        {
                            day = buttons[i].GetTime()[j];
                            time = buttons[i].GetTime()[j + 1];

                            SetDayPanel(day, int.Parse(time.ToString()), buttons[i].course.Text);
                            if (day == '금') break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].course.Text == "" && buttons[i].GetTime() != "")
                    {
                        for (int j = 0; j < buttons[i].GetTime().Length; j += 2)
                        {
                            day = buttons[i].GetTime()[j];
                            time = buttons[i].GetTime()[j + 1];
                            DeleteDayPanel(day, int.Parse(time.ToString()), buttons[i].course.Text);
                            if (day == '금') break;
                        }
                    }
                }
            }
        }

        public void SetDayPanel(char day, int time, string course)
        {
            if (day == '월')
            {
                ChangeTableText(MonLabel[time - 1], course);
                MonPanel[time - 1].Visible = true;
            }
            if (day == '화')
            {
                ChangeTableText(TueLabel[time - 1], course);
                TuePanel[time - 1].Visible = true;
            }
            if (day == '수')
            {
                ChangeTableText(WedLabel[time - 1], course);
                WedPanel[time - 1].Visible = true;
            }
            if (day == '목')
            {
                ChangeTableText(ThuLabel[time - 1], course);
                ThuPanel[time - 1].Visible = true;
            }
            if (day == '금')
            {
                ChangeTableText(Friday123_Label, course);
                Friday123.Visible = true;
            }
        }

        public void DeleteDayPanel(char day, int time, string course)
        {
            if (day == '월')
            {
                MonPanel[time - 1].Visible = false;
            }
            if (day == '화')
            {
                TuePanel[time - 1].Visible = false;
            }
            if (day == '수')
            {
                WedPanel[time - 1].Visible = false;
            }
            if (day == '목')
            {
                ThuPanel[time - 1].Visible = false;
            }
            if (day == '금')
            {
                Friday123.Visible = false;
            }
        }

        public void InitializeTable()
        {
            MonPanel.Add(Mon1);
            MonPanel.Add(Mon2);
            MonPanel.Add(Mon3);
            MonPanel.Add(Mon4);
            MonPanel.Add(Mon5);
            MonPanel.Add(Mon6);

            MonLabel.Add(Mon1_Label);
            MonLabel.Add(Mon2_Label);
            MonLabel.Add(Mon3_Label);
            MonLabel.Add(Mon4_Label);
            MonLabel.Add(Mon5_Label);
            MonLabel.Add(Mon6_Label);

            TuePanel.Add(Tue1);
            TuePanel.Add(Tue2);
            TuePanel.Add(Tue3);
            TuePanel.Add(Tue4);
            TuePanel.Add(Tue5);
            TuePanel.Add(Tue6);

            TueLabel.Add(Tue1_Label);
            TueLabel.Add(Tue2_Label);
            TueLabel.Add(Tue3_Label);
            TueLabel.Add(Tue4_Label);
            TueLabel.Add(Tue5_Label);
            TueLabel.Add(Tue6_Label);

            WedPanel.Add(Wed1);
            WedPanel.Add(Wed2);
            WedPanel.Add(Wed3);
            WedPanel.Add(Wed4);
            WedPanel.Add(Wed5);
            WedPanel.Add(Wed6);

            WedLabel.Add(Wed1_Label);
            WedLabel.Add(Wed2_Label);
            WedLabel.Add(Wed3_Label);
            WedLabel.Add(Wed4_Label);
            WedLabel.Add(Wed5_Label);
            WedLabel.Add(Wed6_Label);

            ThuPanel.Add(Thu1);
            ThuPanel.Add(Thu2);
            ThuPanel.Add(Thu3);
            ThuPanel.Add(Thu4);
            ThuPanel.Add(Thu5);
            ThuPanel.Add(Thu6);

            ThuLabel.Add(Thu1_Label);
            ThuLabel.Add(Thu2_Label);
            ThuLabel.Add(Thu3_Label);
            ThuLabel.Add(Thu4_Label);
            ThuLabel.Add(Thu5_Label);
            ThuLabel.Add(Thu6_Label);
        }


        public void RegisterCourse(int i)
        {
            if (buttons[i].CheckRegister())
            {
                if (registers.Count < 8)
                {
                    foreach(var register in registers)
                    {
                        if(register.GetCourse() == buttons[i].course.Text)
                        {
                            MessageBox.Show("이미 해당 강의를 수강신청 완료했습니다.");
                            return;
                        }
                    }   
                    registers.Add(new RegisterInfo(buttons[i].course.Text, buttons[i].GetProfTime()));
                    CourseUpdate();

                }
                else
                {
                    MessageBox.Show("수강신청가능한 학점을 초과하였습니다.");
                }
            }
            else
            {
                MessageBox.Show("즐겨찾기를 추가하세요.");
            }
        }
        public void Register1(object sender, EventArgs e)
        {
            RegisterCourse(0);
        }

        public void Register2(object sender, EventArgs e)
        {
            RegisterCourse(1);
        }

        public void Register3(object sender, EventArgs e)
        {
            RegisterCourse(2);
        }

        public void Register4(object sender, EventArgs e)
        {
            RegisterCourse(3);
        }

        public void Register5(object sender, EventArgs e)
        {
            RegisterCourse(4);
        }
        public void Register6(object sender, EventArgs e)
        {
            RegisterCourse(5);
        }

        public void Register7(object sender, EventArgs e)
        {
            RegisterCourse(6);
        }

        public void Register8(object sender, EventArgs e)
        {
            RegisterCourse(7);
        }

        public void Register9(object sender, EventArgs e)
        {
            RegisterCourse(8);
        }

        public void CourseUpdate()
        {
            int count = 0;
            
            if(registers.Count > 0) 
            {
                for (int i = registers.Count - 1; i < 8; i++)
                {
                    CourseLabel[i].Visible = false;
                    RegButton[i].Visible = false;
                }

                foreach (var courses in registers)
                {
                    CourseLabel[count].Text = courses.GetCourse() + "\n" + courses.GetProfTime();
                    CourseLabel[count].Visible = true;
                    RegButton[count].Visible = true;
                    ++count;
                }
            }
            else
            {
                CourseLabel[0].Visible = false;
                RegButton[count].Visible = false;
            }
        }

        private void regBtn1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(0);
                CourseUpdate();
            }
        }

        private void regBtn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(1);
                CourseUpdate();
            }
        }

        private void regBtn3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(2);
                CourseUpdate();
            }
        }

        private void regBtn4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(3);
                CourseUpdate();
            }
        }

        private void regBtn5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(4);
                CourseUpdate();
            }
        }

        private void regBtn6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(5);
                CourseUpdate();
            }
        }

        private void regBtn7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(6);
                CourseUpdate();
            }
        }

        private void regBtn8_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("해당 과목을 수강  취소하시겠습니까?", "수강취소 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registers.RemoveAt(7);
                CourseUpdate();
            } 
        }
    }
}

