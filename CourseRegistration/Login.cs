using System.Runtime.InteropServices;
using static CourseRegistration.MyPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.Json;

namespace CourseRegistration
{

    public partial class Login : Form
    {
        public static class GlobalVariables
        {
            public static string Username { get; set; }
        }

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
                Form1 mainForm = new();
                Hide();
                mainForm.ShowDialog();
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
                    Form1 mainForm = new();
                    Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    login();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        public class LoginRequest
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class LoginResponce
        {
            public string message { get; set; }
        }


        private async void login()
        {
            try
            {
                string apiUrl = "https://kwureg-56f6901164d7.herokuapp.com/login";

                // Create an HttpClient instance
                using (HttpClient client = new HttpClient())
                {
                    // Create the login request payload
                    var loginRequest = new LoginRequest
                    {
                        username = txt_username.Text,
                        password = txt_pwd.Text
                    };

                    // Serialize the login request to JSON
                    string jsonPayload = JsonSerializer.Serialize(loginRequest);
                    var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");

                    // Send a POST request asynchronously
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);


                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content asynchronously
                        string json = await response.Content.ReadAsStringAsync();
                        LoginResponce res = JsonSerializer.Deserialize<LoginResponce>(json);
                        
                        if (res.message != "Invalid credentials")
                        {
                            GlobalVariables.Username = loginRequest.username;
                            Form1 mainForm = new();
                            Hide();
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
