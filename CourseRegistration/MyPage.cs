﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CourseRegistration
{
    public partial class MyPage : Form
    {
        String username = Login.GlobalVariables.Username;


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

        public class Lecture
        {
            public string course_id { get; set; }
            public string course_title { get; set; }
            public int credits { get; set; }
            public string grade { get; set; }
        }

        public class StudentFullInfo
        {
            public string student_id { get; set; }
            public string student_name { get; set; }
            public string student_major { get; set; }
            public string student_sec_major { get; set; }
            public int student_year { get; set; }
            public int student_credits { get; set; }
            public int student_major_credits { get; set; }
            public int student_elec_credits { get; set; }
            public int student_rating { get; set; }
            public int student_img_link { get; set; }
        }


        public class Student
        {
            public string ID { get; set; }
            public string dept_name { get; set; }
            public string name { get; set; }
            public int tot_cred { get; set; }
        }



        public class Proffesor
        {
            public string prof_id { get; set; }
            public string prof_name { get; set; }
            public string prof_img_link { get; set; }
        }

        public MyPage()
        {
            InitializeComponent();
            makeAllRounded();

            getStudentInfo();
            getProffesorInfo();
            getCreditsInfo();
            getElectLectures();
            getReqLectures();
        }

        private async void getStudentInfo()
        {
            try
            {
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/student_info/" + username;


                // Create an HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send a GET request asynchronously
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content asynchronously
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON
                        var student = JsonSerializer.Deserialize<List<Student>>(json);
                       
                        student_id.Text = student[0].ID;
                        student_name.Text = student[0].name;
                        student_major.Text = student[0].dept_name;
                        //student_sec_major.Text = "";
                        //student_year.Text = "";
                        //student_credits.Text = "";
                        //student_elec_credits.Text = "";
                        //student_major_credits.Text = "";
                        //student_rating.Text = "";

                        //average_grade.Text = "";
                        credits_sum.Text = student[0].tot_cred.ToString() + "/" + "133";

                    }
                    else
                    {
                        MessageBox.Show("Failed to get data from the API: " + response.ReasonPhrase,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string studentImageUrl;
            if (username == "2022203510")
            {
                studentImageUrl = "https://scontent-ssn1-1.xx.fbcdn.net/v/t1.15752-9/448315222_489166016902602_7736305252103526069_n.jpg?stp=dst-jpg_p1080x2048&_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=9PFAcenrEukQ7kNvgFGI4MV&_nc_ht=scontent-ssn1-1.xx&oh=03_Q7cD1QGV3CaW8By-P2FZYEr79mq76P-itW6kAUCyCYdl8erNpQ&oe=669BBF18";
            }
            else
            {
                studentImageUrl = "https://klas.kw.ac.kr/spv/cmn/image/PersonImageRead.do?imgGubunCode=11&imgMemberNo=2022203502&imgHash=935012825b";
            }
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(studentImageUrl);
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    student_img.Image = Image.FromStream(ms);
                }
            }
        }

        private async void getProffesorInfo()
        {
            //prof_email.Text = "";
            //prof_name.Text = "";

            string profImageUrl = "https://klas.kw.ac.kr/spv/cmn/image/PersonImageRead.do?imgGubunCode=21&imgMemberNo=12013070&imgHash=f040c1facb";
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(profImageUrl);
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    prof_img.Image = Image.FromStream(ms);
                }
            }
        }

        private async void getCreditsInfo()
        {
            try
            {
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/student_lectures/" + username;


                // Create an HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send a GET request asynchronously
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content asynchronously
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON to List<Lecture>
                        var lectures = JsonSerializer.Deserialize<List<Lecture>>(json);

                        // Check if deserialization was successful
                        if (lectures != null)
                        {
                            // Clear existing items in the ListView
                            credits_list.Items.Clear();

                            // Add items to ListView
                            foreach (var lecture in lectures)
                            {
                                ListViewItem item = new ListViewItem(lecture.course_title);
                                item.SubItems.Add(lecture.course_id);
                                item.SubItems.Add(lecture.credits.ToString());
                                item.SubItems.Add(lecture.grade);

                                credits_list.Items.Add(item);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to get data from the API: " + response.ReasonPhrase,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getReqLectures()
        {
            try
            {
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/student_lectures/" + username;

                // Create an HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send a GET request asynchronously
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content asynchronously
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON to List<Lecture>
                        var lectures = JsonSerializer.Deserialize<List<Lecture>>(json);

                        req_major_list.Items.Clear(); 

                        foreach (var lecture in lectures)
                        {
                            req_major_list.Items.Add(lecture.course_title, false);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to get data from the API: " + response.ReasonPhrase,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getElectLectures()
        {
            try
            {
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/student_lectures/" + username;

                // Create an HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Send a GET request asynchronously
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content asynchronously
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON to List<Lecture>
                        var lectures = JsonSerializer.Deserialize<List<Lecture>>(json);

                        elective_lec_list.Items.Clear();

                        foreach (var lecture in lectures)
                        {
                            elective_lec_list.Items.Add(lecture.course_title, false);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to get data from the API: " + response.ReasonPhrase,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void makeAllRounded()
        {
            int border = 20;

            main_panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, main_panel.Width, main_panel.Height, border, border));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, border, border));
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, border, border));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, border, border));
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, border, border));
            panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, border, border));
            panel6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, border, border));
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, border, border));
            student_img.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, student_img.Width, student_img.Height, border, border));
            prof_img.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, prof_img.Width, prof_img.Height, border, border));
        }
    }
}

