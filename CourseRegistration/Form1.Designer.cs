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
            homeBtn = new Button();
            symbolPanel = new Panel();
            registrationBtn = new Button();
            calBtn = new Button();
            curBtn = new Button();
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
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(107, 34, 48);
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            homeBtn.ForeColor = Color.White;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 126);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(213, 49);
            homeBtn.TabIndex = 4;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // symbolPanel
            // 
            symbolPanel.Controls.Add(symbol);
            symbolPanel.Location = new Point(0, 39);
            symbolPanel.Name = "symbolPanel";
            symbolPanel.Size = new Size(213, 90);
            symbolPanel.TabIndex = 5;
            // 
            // registrationBtn
            // 
            registrationBtn.BackColor = Color.FromArgb(107, 34, 48);
            registrationBtn.FlatAppearance.BorderSize = 0;
            registrationBtn.FlatStyle = FlatStyle.Flat;
            registrationBtn.Font = new Font("맑은 고딕", 10F);
            registrationBtn.ForeColor = Color.White;
            registrationBtn.Image = (Image)resources.GetObject("registrationBtn.Image");
            registrationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registrationBtn.Location = new Point(0, 181);
            registrationBtn.Name = "registrationBtn";
            registrationBtn.Size = new Size(213, 49);
            registrationBtn.TabIndex = 6;
            registrationBtn.Text = "수강 신청";
            registrationBtn.UseVisualStyleBackColor = false;
            registrationBtn.Click += registrationBtn_Click;
            // 
            // calBtn
            // 
            calBtn.BackColor = Color.FromArgb(107, 34, 48);
            calBtn.FlatAppearance.BorderSize = 0;
            calBtn.FlatStyle = FlatStyle.Flat;
            calBtn.Font = new Font("맑은 고딕", 10F);
            calBtn.ForeColor = Color.White;
            calBtn.Image = (Image)resources.GetObject("calBtn.Image");
            calBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calBtn.Location = new Point(0, 236);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(213, 49);
            calBtn.TabIndex = 7;
            calBtn.Text = "확률 계산기";
            calBtn.UseVisualStyleBackColor = false;
            calBtn.Click += calBtn_Click;
            // 
            // curBtn
            // 
            curBtn.BackColor = Color.FromArgb(107, 34, 48);
            curBtn.FlatAppearance.BorderSize = 0;
            curBtn.FlatStyle = FlatStyle.Flat;
            curBtn.Font = new Font("맑은 고딕", 10F);
            curBtn.ForeColor = Color.White;
            curBtn.Image = (Image)resources.GetObject("curBtn.Image");
            curBtn.ImageAlign = ContentAlignment.MiddleLeft;
            curBtn.Location = new Point(0, 291);
            curBtn.Name = "curBtn";
            curBtn.Size = new Size(213, 49);
            curBtn.TabIndex = 8;
            curBtn.Text = "커리큘럼";
            curBtn.UseVisualStyleBackColor = false;
            curBtn.Click += curBtn_Click;
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
            Controls.Add(curBtn);
            Controls.Add(calBtn);
            Controls.Add(registrationBtn);
            Controls.Add(symbolPanel);
            Controls.Add(homeBtn);
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
        private Button homeBtn;
        private Panel symbolPanel;
        private Button registrationBtn;
        private Button calBtn;
        private Button curBtn;
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
