namespace CourseRegistration
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            programName = new Label();
            txt_username = new TextBox();
            Username = new Label();
            Pwd = new Label();
            LoginBtn = new Button();
            topBar = new Panel();
            exitBtn = new Button();
            txt_pwd = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // programName
            // 
            programName.AutoSize = true;
            programName.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            programName.ForeColor = SystemColors.Window;
            programName.Location = new Point(107, 117);
            programName.Name = "programName";
            programName.Size = new Size(214, 30);
            programName.TabIndex = 1;
            programName.Text = "Registration Program";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txt_username.Location = new Point(121, 237);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(186, 33);
            txt_username.TabIndex = 2;
            txt_username.KeyDown += txt_KeyDown;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("맑은 고딕", 15.75F);
            Username.ForeColor = Color.White;
            Username.Location = new Point(161, 197);
            Username.Name = "Username";
            Username.Size = new Size(107, 30);
            Username.TabIndex = 4;
            Username.Text = "Username";
            // 
            // Pwd
            // 
            Pwd.AutoSize = true;
            Pwd.Font = new Font("맑은 고딕", 15.75F);
            Pwd.ForeColor = Color.White;
            Pwd.Location = new Point(163, 275);
            Pwd.Name = "Pwd";
            Pwd.Size = new Size(102, 30);
            Pwd.TabIndex = 5;
            Pwd.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LoginBtn.Location = new Point(137, 368);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(153, 51);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // topBar
            // 
            topBar.BackColor = Color.White;
            topBar.Controls.Add(exitBtn);
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(428, 27);
            topBar.TabIndex = 7;
            topBar.MouseDown += topBar_MouseDown;
            topBar.MouseMove += topBar_MouseMove;
            topBar.MouseUp += topBar_MouseUp;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(107, 34, 48);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Location = new Point(405, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(20, 20);
            exitBtn.TabIndex = 0;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.BeepOnError = true;
            txt_pwd.Font = new Font("맑은 고딕", 14.25F);
            txt_pwd.Location = new Point(121, 308);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.PasswordChar = '•';
            txt_pwd.Size = new Size(186, 33);
            txt_pwd.TabIndex = 3;
            txt_pwd.KeyDown += txt_KeyDown;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(107, 34, 48);
            ClientSize = new Size(428, 445);
            Controls.Add(txt_pwd);
            Controls.Add(topBar);
            Controls.Add(LoginBtn);
            Controls.Add(Pwd);
            Controls.Add(Username);
            Controls.Add(txt_username);
            Controls.Add(programName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label programName;
        private TextBox txt_username;
        private Label Username;
        private Label Pwd;
        private Button LoginBtn;
        private Panel topBar;
        private Button exitBtn;
        private MaskedTextBox txt_pwd;
    }
}