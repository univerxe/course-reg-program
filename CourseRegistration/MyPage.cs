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

    public partial class MyPage : Form
    {
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

        int border = 20;

        public MyPage()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, border, border));
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, border, border));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, border, border));
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, border, border));
            panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, border, border));
            panel6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, border, border));
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, border, border));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, border, border));
            pictureBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, border, border));


            String[] lectures = ["대학영어", "C프로그래밍", "검퓨팅사고", "율합적사고와글쓰기", "광운인되기"];
            String[] l_status = ["전필", "전필", "전필", "전필", "전필"];
            String[] l_credit = ["3힉점", "3힉점", "3힉점", "3힉점", "3힉점"];
            String[] l_grade = ["A+", "A+", "A+", "A+", "A+"];

            for (int i = 0; i < lectures.Length; i++)
            {
                ListViewItem item = credits_list.Items.Add(lectures[i]);
                item.SubItems.Add(l_status[i]);
                item.SubItems.Add(l_credit[i]);
                item.SubItems.Add(l_grade[i]);

            }

        }
   
    }
}
