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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topBar = new Panel();
            mainPanel = new Panel();
            symbol = new PictureBox();
            userInfoPanel = new Panel();
            userPanel = new Panel();
            Num = new Label();
            userName = new Label();
            numLabel = new Label();
            nameLabel = new Label();
            User = new PictureBox();
            HomeBtn = new Button();
            symbolPanel = new Panel();
            SearchBtn = new Button();
            CurriculumBtn = new Button();
            MyPageBtn = new Button();
            exitBtn = new Button();
            settingBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)symbol).BeginInit();
            userInfoPanel.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            symbolPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1300, 39);
            topBar.TabIndex = 0;
            topBar.MouseDown += topBar_MouseDown;
            topBar.MouseMove += topBar_MouseMove;
            topBar.MouseUp += topBar_MouseUp;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Font = new Font("맑은 고딕", 9F);
            mainPanel.Location = new Point(213, 39);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(835, 642);
            mainPanel.TabIndex = 1;
            // 
            // symbol
            // 
            symbol.Image = (Image)resources.GetObject("symbol.Image");
            symbol.Location = new Point(5, 6);
            symbol.Name = "symbol";
            symbol.Size = new Size(200, 56);
            symbol.SizeMode = PictureBoxSizeMode.AutoSize;
            symbol.TabIndex = 2;
            symbol.TabStop = false;
            // 
            // userInfoPanel
            // 
            userInfoPanel.BackColor = Color.FromArgb(250, 250, 250);
            userInfoPanel.Controls.Add(userPanel);
            userInfoPanel.Location = new Point(1048, 39);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(213, 642);
            userInfoPanel.TabIndex = 3;
            // 
            // userPanel
            // 
            userPanel.BackColor = SystemColors.ButtonFace;
            userPanel.Controls.Add(Num);
            userPanel.Controls.Add(userName);
            userPanel.Controls.Add(numLabel);
            userPanel.Controls.Add(nameLabel);
            userPanel.Controls.Add(User);
            userPanel.Location = new Point(0, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(213, 50);
            userPanel.TabIndex = 0;
            // 
            // Num
            // 
            Num.AutoSize = true;
            Num.Location = new Point(85, 24);
            Num.Name = "Num";
            Num.Size = new Size(36, 15);
            Num.TabIndex = 4;
            Num.Text = "None";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(90, 6);
            userName.Name = "userName";
            userName.Size = new Size(36, 15);
            userName.TabIndex = 3;
            userName.Text = "None";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(52, 24);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(37, 15);
            numLabel.TabIndex = 2;
            numLabel.Text = "Num:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(52, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // User
            // 
            User.Image = (Image)resources.GetObject("User.Image");
            User.Location = new Point(6, 3);
            User.Name = "User";
            User.Size = new Size(40, 40);
            User.SizeMode = PictureBoxSizeMode.AutoSize;
            User.TabIndex = 0;
            User.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(107, 34, 48);
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(0, 126);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(213, 49);
            HomeBtn.TabIndex = 4;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += homeBtn_Click;
            // 
            // symbolPanel
            // 
            symbolPanel.Controls.Add(symbol);
            symbolPanel.Location = new Point(0, 39);
            symbolPanel.Name = "symbolPanel";
            symbolPanel.Size = new Size(213, 90);
            symbolPanel.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(107, 34, 48);
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("맑은 고딕", 10F);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Image = (Image)resources.GetObject("SearchBtn.Image");
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(0, 181);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(213, 49);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // CurriculumBtn
            // 
            CurriculumBtn.BackColor = Color.FromArgb(107, 34, 48);
            CurriculumBtn.FlatAppearance.BorderSize = 0;
            CurriculumBtn.FlatStyle = FlatStyle.Flat;
            CurriculumBtn.Font = new Font("맑은 고딕", 10F);
            CurriculumBtn.ForeColor = Color.White;
            CurriculumBtn.Image = (Image)resources.GetObject("CurriculumBtn.Image");
            CurriculumBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CurriculumBtn.Location = new Point(0, 236);
            CurriculumBtn.Name = "CurriculumBtn";
            CurriculumBtn.Size = new Size(213, 49);
            CurriculumBtn.TabIndex = 7;
            CurriculumBtn.Text = "Curriculum";
            CurriculumBtn.UseVisualStyleBackColor = false;
            CurriculumBtn.Click += CurriculumBtn_Click;
            // 
            // MyPageBtn
            // 
            MyPageBtn.BackColor = Color.FromArgb(107, 34, 48);
            MyPageBtn.FlatAppearance.BorderSize = 0;
            MyPageBtn.FlatStyle = FlatStyle.Flat;
            MyPageBtn.Font = new Font("맑은 고딕", 10F);
            MyPageBtn.ForeColor = Color.White;
            MyPageBtn.Image = (Image)resources.GetObject("MyPageBtn.Image");
            MyPageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MyPageBtn.Location = new Point(0, 291);
            MyPageBtn.Name = "MyPageBtn";
            MyPageBtn.Size = new Size(213, 49);
            MyPageBtn.TabIndex = 8;
            MyPageBtn.Text = "My Page";
            MyPageBtn.UseVisualStyleBackColor = false;
            MyPageBtn.Click += MyPageBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(107, 34, 48);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("맑은 고딕", 10F);
            exitBtn.ForeColor = Color.White;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(0, 629);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(213, 49);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "종료";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // settingBtn
            // 
            settingBtn.BackColor = Color.FromArgb(107, 34, 48);
            settingBtn.FlatAppearance.BorderSize = 0;
            settingBtn.FlatStyle = FlatStyle.Flat;
            settingBtn.Font = new Font("맑은 고딕", 10F);
            settingBtn.ForeColor = Color.White;
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingBtn.Location = new Point(0, 583);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(213, 49);
            settingBtn.TabIndex = 11;
            settingBtn.Text = "설정";
            settingBtn.UseVisualStyleBackColor = false;
            settingBtn.Click += settingBtn_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(107, 34, 48);
            ClientSize = new Size(1300, 720);
            Controls.Add(settingBtn);
            Controls.Add(exitBtn);
            Controls.Add(MyPageBtn);
            Controls.Add(CurriculumBtn);
            Controls.Add(SearchBtn);
            Controls.Add(symbolPanel);
            Controls.Add(HomeBtn);
            Controls.Add(userInfoPanel);
            Controls.Add(mainPanel);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)symbol).EndInit();
            userInfoPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            symbolPanel.ResumeLayout(false);
            symbolPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBar;
        private Panel mainPanel;
        private PictureBox symbol;
        private Panel userInfoPanel;
        private Button HomeBtn;
        private Panel symbolPanel;
        private Button SearchBtn;
        private Button CurriculumBtn;
        private Button MyPageBtn;
        private Panel userPanel;
        private PictureBox User;
        private Label nameLabel;
        private Label numLabel;
        private Label Num;
        private Label userName;
        private Button exitBtn;
        private Button settingBtn;
    }
}
