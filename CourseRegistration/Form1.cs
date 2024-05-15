using System;

namespace CourseRegistration
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(97, 24, 38);
            Color btnColor = Color.FromArgb(107, 34, 48);
            HomeBtn.BackColor = btnColor;
            SearchBtn.BackColor = btnColor;
            CurriculumBtn.BackColor = btnColor;
            MyPageBtn.BackColor = btnColor;
            settingBtn.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(HomeBtn);
            this.mainPanel.Controls.Clear();
            Home homePage = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(homePage);
            homePage.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(SearchBtn);
            this.mainPanel.Controls.Clear();
            SearchPage registrationPage = new SearchPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(registrationPage);
            registrationPage.Show();
        }

        private void CurriculumBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(CurriculumBtn);
            this.mainPanel.Controls.Clear();
            CurriculumPage calculationPage = new CurriculumPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(calculationPage);
            calculationPage.Show();
        }

        private void MyPageBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(MyPageBtn);
            this.mainPanel.Controls.Clear();
            MyPage curriculumPage = new MyPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(curriculumPage);
            curriculumPage.Show();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(settingBtn);
            this.mainPanel.Controls.Clear();
            Setting settingPage = new Setting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(settingPage);
            settingPage.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
