using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

// Define classes that match your JSON structure
public class Lecture
{
    public string course_id { get; set; }
    public string title { get; set; }
    public string dept_name { get; set; }
    public int credits { get; set; }
}

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

            getCreditsInfo();
            getElectLectures();
            getReqLectures();
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

                        // Assuming req_major_list is your CheckedListBox
                        req_major_list.Items.Clear(); // Clear existing items (if needed)

                        foreach (var lecture in lectures)
                        {
                            // Assuming lecture.course_id is the text you want to display
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
    }
}

