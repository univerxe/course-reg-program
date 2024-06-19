using System.Runtime.InteropServices;
using System.Text.Json;


namespace CourseRegistration
{
    public partial class SearchPage : Form
    {
        List<Root>? roots = null;


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
        public SearchPage()
        {
            InitializeComponent();
            SearchCmb.SelectedIndex = 0;

            SearchListView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SearchListView.Width, SearchListView.Height, 16, 16));

            LoadCourseData();
        }

        void LoadCourseData()
        {
            string jsonString = File.ReadAllText("everytime-lectures.json");
            roots = JsonSerializer.Deserialize<List<Root>>(jsonString);
            Random rnd = new();

            string[] times = ["월4수3", "화2목3", "수6", "목5", "금123"];
            if (roots != null)
            {
                foreach (Root root in roots)
                {
                    ListViewItem item = SearchListView.Items.Add(root.name);
                    item.SubItems.Add(root.professor);
                    item.SubItems.Add(times[rnd.Next(times.Length)]);
                    item.SubItems.Add("0000-000-0000");
                    item.SubItems.Add("-"); // Room
                    item.SubItems.Add("3"); // Credit
                    item.SubItems.Add(root.rate?.average.ToString());
                }
            }
        }

        private void SearchListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchListView.SelectedIndices.Count == 0) return;

            int index = SearchListView.SelectedIndices[0];
            if (index != -1)
            {
                _UpdateDetailsView(index);
                _UpdateCommentsView(index);
            }
        }

        private void _UpdateDetailsView(int index)
        {
            Root data = roots![index];

            courseNameLabel.Text = data.name + "(" + data.professor + ")";
            RatingLabel.Text = data.rate?.average.ToString();

            int i = 0;
            int max = -1;
            int maxIndex = -1;

            Detail? assignment = null;
            while (assignment == null)
            {
                if (data.details![i].name == "과제")
                    assignment = data.details![i];
                i++;
            }
            for (i = 0; i < assignment!.items!.Count; i++)
            {
                Item assignItem = assignment!.items![i];
                if (assignItem.count > max)
                {
                    max = assignItem.count;
                    maxIndex = i;
                }
            }
            AssignmentLabel.Text = assignment!.items![maxIndex].text;

            i = 0;
            max = -1;
            maxIndex = -1;
            Detail? attendance = null;
            while (attendance == null)
            {
                if (data.details![i].name == "출결")
                    attendance = data.details![i];
                i++;
            }
            for (i = 0; i < attendance!.items!.Count; i++)
            {
                Item attendItem = attendance!.items![i];
                if (attendItem.count > max)
                {
                    max = attendItem.count;
                    maxIndex = i;
                }
            }
            AttendanceLabel.Text = attendance!.items![maxIndex].text;

            i = 0;
            max = -1;
            maxIndex = -1;
            Detail? exam = null;
            while (exam == null)
            {
                if (data.details![i].name == "시험")
                    exam = data.details![i];
                i++;
            }
            for (i = 0; i < exam!.items!.Count; i++)
            {
                Item examItem = exam!.items![i];
                if (examItem.count > max)
                {
                    max = examItem.count;
                    maxIndex = i;
                }
            }
            ExamLabel.Text = exam!.items![maxIndex].text;

            i = 0;
            max = -1;
            maxIndex = -1;
            Detail? team = null;
            while (team == null)
            {
                if (data.details![i].name == "조모임")
                    team = data.details![i];
                i++;
            }
            for (i = 0; i < team!.items!.Count; i++)
            {
                Item teamItem = team!.items![i];
                if (teamItem.count > max)
                {
                    max = teamItem.count;
                    maxIndex = i;
                }
            }
            TeamProjLabel.Text = team!.items![maxIndex].text;

            i = 0;
            max = -1;
            maxIndex = -1;
            Detail? grading = null;
            while (grading == null)
            {
                if (data.details![i].name == "성적")
                    grading = data.details![i];
                i++;
            }
            for (i = 0; i < grading!.items!.Count; i++)
            {
                Item gradingItem = grading!.items![i];
                if (gradingItem.count > max)
                {
                    max = gradingItem.count;
                    maxIndex = i;
                }
            }
            GradingLabel.Text = grading!.items![maxIndex].text;
        }

        private void _UpdateCommentsView(int index)
        {
            commentListView.Items.Clear();

            Root data = roots![index];

            string[] fakeDates = ["19년 1학기", "19년 2학기", "18년 1학기", "18년 2학기",
                "22년 1학기", "22년 2학기", "23년 1학기", "23년 2학기", "24년 1학기"];
            Random rnd = new();

            ListViewItem item;
            for (int i = 0; i < 32; ++i)
            {
                item = commentListView.Items.Add(fakeDates[rnd.Next(fakeDates.Length)]);
                item.SubItems.Add(" - "); // Rating
                item.SubItems.Add("This is a comment #" + i + " for " + data.name + "(" + data.professor + ")");
            }
        }

        private void Search()
        {
            SearchListView.Items.Clear();

            string jsonString = File.ReadAllText("everytime-lectures.json");
            string query = SearchText.Text;
            List<Root>? tmpRoots = JsonSerializer.Deserialize<List<Root>>(jsonString);
            roots!.Clear();

            if (SearchCmb.Text == "과목명")
            {
                for (int i = 0; i < tmpRoots!.Count; ++i)
                {
                    Root root = tmpRoots![i];
                    if (root.name!.Contains(query))
                        roots.Add(root);
                }
            }
            else if (SearchCmb.Text == "담당교수")
            {
                for (int i = 0; i < tmpRoots!.Count; ++i)
                {
                    Root root = tmpRoots![i];
                    if (root.professor!.Contains(query))
                        roots.Add(root);
                }
            }

            Random rnd = new();

            string[] times = ["월4수3", "화2목3", "수6", "목5", "금123"];
            if (roots != null)
            {
                if (roots.Count == 0)
                    MessageBox.Show("No matched data!");
                foreach (Root root in roots)
                {
                    ListViewItem item = SearchListView.Items.Add(root.name);
                    item.SubItems.Add(root.professor);
                    item.SubItems.Add(times[rnd.Next(times.Length)]);
                    item.SubItems.Add("0000-000-0000");
                    item.SubItems.Add("-"); // Room
                    item.SubItems.Add("3"); // Credit
                    item.SubItems.Add(root.rate?.average.ToString());

                }
            }
            else
            {
                MessageBox.Show("Data is null!");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }

    public class Detail
    {
        public string? name { get; set; }
        public int count { get; set; }
        public List<Item>? items { get; set; }
    }

    public class Item
    {
        public int value { get; set; }
        public int count { get; set; }
        public string? text { get; set; }
    }

    public class Rate
    {
        public double average { get; set; }
        public int count { get; set; }
        public List<Item>? items { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? professor { get; set; }
        public Rate? rate { get; set; }
        public List<Detail>? details { get; set; }
    }
}
