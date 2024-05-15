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
            homeBtn.BackColor = btnColor;
            registrationBtn.BackColor = btnColor;
            calBtn.BackColor = btnColor;
            curBtn.BackColor = btnColor;
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
            ButtonColorReset(homeBtn);
            this.mainPanel.Controls.Clear();
            Home homePage = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(homePage);
            homePage.Show();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(registrationBtn);
            this.mainPanel.Controls.Clear();
            Registration registrationPage = new Registration() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(registrationPage);
            registrationPage.Show();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(calBtn);
            this.mainPanel.Controls.Clear();
            Calculaton calculationPage = new Calculaton() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainPanel.Controls.Add(calculationPage);
            calculationPage.Show();
        }

        private void curBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(curBtn);
            this.mainPanel.Controls.Clear();
            Curriculum curriculumPage = new Curriculum() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
