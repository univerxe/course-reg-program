using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Net;


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

        public class Lecture
        {
            public string course_id { get; set; }
            public string title { get; set; }
            public string dept_name { get; set; }
            public int credits { get; set; }
        }

        public class Student
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
            //student_id.Text = "";
            //student_name.Text = "";
            //student_major.Text = "";
            //student_sec_major.Text = "";
            //student_year.Text = "";
            //student_credits.Text = "";
            //student_elec_credits.Text = "";
            //student_major_credits.Text = "";
            //student_rating.Text = "";
            
            //average_grade.Text = "";
            //credits_sum.Text = "";

            string studentImageUrl = "https://avatars.githubusercontent.com/u/116807110?s=400&u=5d4699be20a0a4b5adac2dcd25dad399d31b443d&v=4";
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
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/courses";

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

                        // Clear existing items in the ListView
                        credits_list.Items.Clear();

                        // Add items to ListView
                        foreach (var lecture in lectures)
                        {
                            ListViewItem item = new ListViewItem(lecture.course_id);
                            item.SubItems.Add(lecture.title);
                            item.SubItems.Add(lecture.dept_name);
                            item.SubItems.Add(lecture.credits.ToString());

                            credits_list.Items.Add(item);
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
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/courses";

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

                        req_major_list.Items.Clear(); // Clear existing items (if needed)

                        foreach (var lecture in lectures)
                        {
                            req_major_list.Items.Add(lecture.course_id, false); // Add item with unchecked state
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
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/courses";

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

                        // Assuming req_major_list is your CheckedListBox
                        elective_lec_list.Items.Clear(); // Clear existing items (if needed)

                        foreach (var lecture in lectures)
                        {
                            // Assuming lecture.course_id is the text you want to display
                            elective_lec_list.Items.Add(lecture.course_id, false); // Add item with unchecked state
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

