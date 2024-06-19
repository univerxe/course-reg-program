using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CourseRegistration
{
    public partial class Form1 : Form
    {
        Home homePage = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        SearchPage searchPage = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        CurriculumPage curriculumPage = new () { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        MyPage myPage = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
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

        public Form1()
        {
            InitializeComponent();
            //Set the Region of the Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set page delegates
            homePage.moveToSearchPage = this.MoveToSearchPage;
            searchPage.delegateAddToFav = homePage.SetCourseButton;
            searchPage.delegateGetFirstEmptyCourseButton = homePage.GetFirstEmptyCourseButton;

            //Set the mainPanel to HomePage
            ButtonColorReset(HomeBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(homePage);
            homePage.Show();

            //Set the Region of the button(Round)
            HomeBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, HomeBtn.Width, HomeBtn.Height, 30, 30));
            SearchBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, SearchBtn.Width, SearchBtn.Height, 30, 30));
            CurriculumBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CurriculumBtn.Width, CurriculumBtn.Height, 30, 30));
            MyPageBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, MyPageBtn.Width, MyPageBtn.Height, 30, 30));
            exitBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBtn.Width, exitBtn.Height, 20, 20));
            maximizeBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, maximizeBtn.Width, maximizeBtn.Height, 20, 20));
            minimizeBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, minimizeBtn.Width, minimizeBtn.Height, 20, 20));
        }

        //Set the color of the button When it clicked and others
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(83, 32, 43);
            Color btnColor = Color.FromArgb(101, 29, 44);
            HomeBtn.BackColor = btnColor;
            SearchBtn.BackColor = btnColor;
            CurriculumBtn.BackColor = btnColor;
            MyPageBtn.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        //Drag the Form - MouseDown
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        //Drag the Form - MouseMove
        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        //Drag the Form - MouseUp
        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(HomeBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(homePage);
            homePage.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(SearchBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(searchPage);
            searchPage.Show();
        }

        public void MoveToSearchPage()
        {
            ButtonColorReset(SearchBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(searchPage);
            searchPage.Show();
        }

        private void CurriculumBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(CurriculumBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(curriculumPage);
            curriculumPage.Show();
        }

        private void MyPageBtn_Click(object sender, EventArgs e)
        {
            ButtonColorReset(MyPageBtn);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(myPage);
            myPage.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            timer.Start();
        }

     
    }
}
