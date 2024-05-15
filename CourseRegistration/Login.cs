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
    public partial class Login : Form
    {
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
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoginBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginBtn.Width, LoginBtn.Height, 25, 25));
            exitBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBtn.Width, exitBtn.Height, 20, 20));
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == string.Empty)
            {
                MessageBox.Show("Please write your Username");
            }

            else if (txt_pwd.Text == string.Empty)
            {
                MessageBox.Show("Please write your Password");
            }
            else if (txt_pwd.Text == "pwd" && txt_username.Text == "user")
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Undefined Username or Password");
            }
        }
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_username.Text == string.Empty)
                {
                    MessageBox.Show("Please write your Username");
                }

                else if (txt_pwd.Text == string.Empty)
                {
                    MessageBox.Show("Please write your Password");
                }
                else if (txt_pwd.Text == "pwd" && txt_username.Text == "user")
                {
                    Form1 mainForm = new Form1();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Undefined Username or Password");
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
