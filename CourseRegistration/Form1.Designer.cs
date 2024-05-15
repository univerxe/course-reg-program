namespace CourseRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topBar_left = new Panel();
            mainPanel = new Panel();
            topBar_right = new Panel();
            minimizeBtn = new Button();
            maximizeBtn = new Button();
            exitBtn = new Button();
            symbol = new PictureBox();
            HomeBtn = new Button();
            symbolPanel = new Panel();
            SearchBtn = new Button();
            CurriculumBtn = new Button();
            MyPageBtn = new Button();
            timer = new System.Windows.Forms.Timer(components);
            time = new Label();
            topBar_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbol).BeginInit();
            symbolPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBar_left
            // 
            topBar_left.Location = new Point(0, 0);
            topBar_left.Name = "topBar_left";
            topBar_left.Size = new Size(213, 32);
            topBar_left.TabIndex = 0;
            topBar_left.MouseDown += topBar_MouseDown;
            topBar_left.MouseMove += topBar_MouseMove;
            topBar_left.MouseUp += topBar_MouseUp;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Font = new Font("맑은 고딕", 9F);
            mainPanel.Location = new Point(213, 31);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1299, 951);
            mainPanel.TabIndex = 1;
            // 
            // topBar_right
            // 
            topBar_right.BackColor = Color.White;
            topBar_right.Controls.Add(minimizeBtn);
            topBar_right.Controls.Add(maximizeBtn);
            topBar_right.Controls.Add(exitBtn);
            topBar_right.Location = new Point(213, 0);
            topBar_right.Name = "topBar_right";
            topBar_right.Size = new Size(1299, 32);
            topBar_right.TabIndex = 0;
            topBar_right.MouseDown += topBar_MouseDown;
            topBar_right.MouseMove += topBar_MouseMove;
            topBar_right.MouseUp += topBar_MouseUp;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = Color.FromArgb(107, 34, 48);
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1215, 9);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(20, 20);
            minimizeBtn.TabIndex = 10;
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // maximizeBtn
            // 
            maximizeBtn.BackColor = Color.FromArgb(107, 34, 48);
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.Location = new Point(1241, 9);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(20, 20);
            maximizeBtn.TabIndex = 10;
            maximizeBtn.UseVisualStyleBackColor = false;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(107, 34, 48);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Location = new Point(1267, 9);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(20, 20);
            exitBtn.TabIndex = 9;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // symbol
            // 
            symbol.Image = (Image)resources.GetObject("symbol.Image");
            symbol.Location = new Point(7, 0);
            symbol.Name = "symbol";
            symbol.Size = new Size(200, 56);
            symbol.SizeMode = PictureBoxSizeMode.AutoSize;
            symbol.TabIndex = 2;
            symbol.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(101, 29, 44);
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(25, 399);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(163, 49);
            HomeBtn.TabIndex = 4;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += homeBtn_Click;
            // 
            // symbolPanel
            // 
            symbolPanel.Controls.Add(symbol);
            symbolPanel.Location = new Point(0, 33);
            symbolPanel.Name = "symbolPanel";
            symbolPanel.Size = new Size(213, 85);
            symbolPanel.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(101, 29, 44);
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("맑은 고딕", 12F);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Image = (Image)resources.GetObject("SearchBtn.Image");
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(25, 454);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(163, 49);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // CurriculumBtn
            // 
            CurriculumBtn.BackColor = Color.FromArgb(101, 29, 44);
            CurriculumBtn.FlatAppearance.BorderSize = 0;
            CurriculumBtn.FlatStyle = FlatStyle.Flat;
            CurriculumBtn.Font = new Font("맑은 고딕", 12F);
            CurriculumBtn.ForeColor = Color.White;
            CurriculumBtn.Image = (Image)resources.GetObject("CurriculumBtn.Image");
            CurriculumBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CurriculumBtn.Location = new Point(25, 509);
            CurriculumBtn.Name = "CurriculumBtn";
            CurriculumBtn.Size = new Size(163, 49);
            CurriculumBtn.TabIndex = 7;
            CurriculumBtn.Text = " Curriculum";
            CurriculumBtn.UseVisualStyleBackColor = false;
            CurriculumBtn.Click += CurriculumBtn_Click;
            // 
            // MyPageBtn
            // 
            MyPageBtn.BackColor = Color.FromArgb(101, 29, 44);
            MyPageBtn.FlatAppearance.BorderSize = 0;
            MyPageBtn.FlatStyle = FlatStyle.Flat;
            MyPageBtn.Font = new Font("맑은 고딕", 12F);
            MyPageBtn.ForeColor = Color.White;
            MyPageBtn.Image = (Image)resources.GetObject("MyPageBtn.Image");
            MyPageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MyPageBtn.Location = new Point(25, 564);
            MyPageBtn.Name = "MyPageBtn";
            MyPageBtn.Size = new Size(163, 49);
            MyPageBtn.TabIndex = 8;
            MyPageBtn.Text = "My Page";
            MyPageBtn.UseVisualStyleBackColor = false;
            MyPageBtn.Click += MyPageBtn_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("맑은 고딕", 30F);
            time.ForeColor = Color.White;
            time.Location = new Point(20, 332);
            time.Name = "time";
            time.Size = new Size(173, 54);
            time.TabIndex = 9;
            time.Text = "12:12:12";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(107, 34, 48);
            ClientSize = new Size(1512, 982);
            Controls.Add(time);
            Controls.Add(topBar_right);
            Controls.Add(MyPageBtn);
            Controls.Add(CurriculumBtn);
            Controls.Add(SearchBtn);
            Controls.Add(symbolPanel);
            Controls.Add(HomeBtn);
            Controls.Add(mainPanel);
            Controls.Add(topBar_left);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            topBar_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)symbol).EndInit();
            symbolPanel.ResumeLayout(false);
            symbolPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topBar_left;
        private Panel mainPanel;
        private PictureBox symbol;
        private Button HomeBtn;
        private Panel symbolPanel;
        private Button SearchBtn;
        private Button CurriculumBtn;
        private Button MyPageBtn;
        private System.Windows.Forms.Timer timer;
        private Panel topBar_right;
        private Button exitBtn;
        private Button minimizeBtn;
        private Button maximizeBtn;
        private Label time;
    }
}
