namespace CourseRegistration
{
    partial class SearchPage
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
            columnHeader1 = new ColumnHeader();
            label1 = new Label();
            SearchText = new TextBox();
            SearchBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            SearchListView = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox2 = new GroupBox();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            GradingLabel = new Label();
            TeamProjLabel = new Label();
            ExamLabel = new Label();
            AttendanceLabel = new Label();
            AssignmentLabel = new Label();
            RatingLabel = new Label();
            groupBox3 = new GroupBox();
            commentListView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            SearchCmb = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "과목명";
            columnHeader1.Width = 160;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 28F, FontStyle.Bold);
            label1.Location = new Point(55, 56);
            label1.Name = "label1";
            label1.Size = new Size(299, 51);
            label1.TabIndex = 0;
            label1.Text = "Search Courses";
            // 
            // SearchText
            // 
            SearchText.Location = new Point(55, 135);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(422, 23);
            SearchText.TabIndex = 1;
            SearchText.KeyUp += SearchText_KeyUp;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(610, 134);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 27);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 28F, FontStyle.Bold);
            label2.Location = new Point(706, 110);
            label2.Name = "label2";
            label2.Size = new Size(283, 51);
            label2.TabIndex = 3;
            label2.Text = "Course Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 28F, FontStyle.Bold);
            label3.Location = new Point(706, 463);
            label3.Name = "label3";
            label3.Size = new Size(355, 51);
            label3.TabIndex = 4;
            label3.Text = "Course Comments";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchListView);
            groupBox1.Location = new Point(55, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 710);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // SearchListView
            // 
            SearchListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            SearchListView.Dock = DockStyle.Fill;
            SearchListView.FullRowSelect = true;
            SearchListView.GridLines = true;
            SearchListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            SearchListView.Location = new Point(3, 19);
            SearchListView.MultiSelect = false;
            SearchListView.Name = "SearchListView";
            SearchListView.Size = new Size(624, 688);
            SearchListView.TabIndex = 0;
            SearchListView.UseCompatibleStateImageBehavior = false;
            SearchListView.View = View.Details;
            SearchListView.SelectedIndexChanged += SearchListView_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "담당교수";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "시간";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "과목코드";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "강의실";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "학점";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "평점";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer1);
            groupBox2.Location = new Point(721, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(536, 254);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Window;
            splitContainer1.Panel2.Controls.Add(GradingLabel);
            splitContainer1.Panel2.Controls.Add(TeamProjLabel);
            splitContainer1.Panel2.Controls.Add(ExamLabel);
            splitContainer1.Panel2.Controls.Add(AttendanceLabel);
            splitContainer1.Panel2.Controls.Add(AssignmentLabel);
            splitContainer1.Panel2.Controls.Add(RatingLabel);
            splitContainer1.Size = new Size(530, 232);
            splitContainer1.SplitterDistance = 218;
            splitContainer1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 0;
            label4.Text = "Ratings";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label9.Location = new Point(12, 195);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 5;
            label9.Text = "Grading";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 45);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 1;
            label5.Text = "Assignment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 2;
            label6.Text = "Attendance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label8.Location = new Point(12, 158);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 4;
            label8.Text = "Team Project";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label7.Location = new Point(11, 119);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 3;
            label7.Text = "Exam";
            // 
            // GradingLabel
            // 
            GradingLabel.AutoSize = true;
            GradingLabel.Location = new Point(18, 201);
            GradingLabel.Name = "GradingLabel";
            GradingLabel.Size = new Size(12, 15);
            GradingLabel.TabIndex = 5;
            GradingLabel.Text = "-";
            // 
            // TeamProjLabel
            // 
            TeamProjLabel.AutoSize = true;
            TeamProjLabel.Location = new Point(18, 164);
            TeamProjLabel.Name = "TeamProjLabel";
            TeamProjLabel.Size = new Size(12, 15);
            TeamProjLabel.TabIndex = 4;
            TeamProjLabel.Text = "-";
            // 
            // ExamLabel
            // 
            ExamLabel.AutoSize = true;
            ExamLabel.Location = new Point(18, 125);
            ExamLabel.Name = "ExamLabel";
            ExamLabel.Size = new Size(12, 15);
            ExamLabel.TabIndex = 3;
            ExamLabel.Text = "-";
            // 
            // AttendanceLabel
            // 
            AttendanceLabel.AutoSize = true;
            AttendanceLabel.Location = new Point(18, 88);
            AttendanceLabel.Name = "AttendanceLabel";
            AttendanceLabel.Size = new Size(12, 15);
            AttendanceLabel.TabIndex = 2;
            AttendanceLabel.Text = "-";
            // 
            // AssignmentLabel
            // 
            AssignmentLabel.AutoSize = true;
            AssignmentLabel.Location = new Point(18, 51);
            AssignmentLabel.Name = "AssignmentLabel";
            AssignmentLabel.Size = new Size(12, 15);
            AssignmentLabel.TabIndex = 1;
            AssignmentLabel.Text = "-";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(18, 15);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(12, 15);
            RatingLabel.TabIndex = 0;
            RatingLabel.Text = "-";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(commentListView);
            groupBox3.Location = new Point(721, 517);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(536, 354);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // commentListView
            // 
            commentListView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10 });
            commentListView.GridLines = true;
            commentListView.Location = new Point(15, 19);
            commentListView.MultiSelect = false;
            commentListView.Name = "commentListView";
            commentListView.Size = new Size(518, 332);
            commentListView.TabIndex = 0;
            commentListView.UseCompatibleStateImageBehavior = false;
            commentListView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "수강기간";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "평점";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "내용";
            columnHeader10.Width = 360;
            // 
            // SearchCmb
            // 
            SearchCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchCmb.FormattingEnabled = true;
            SearchCmb.Items.AddRange(new object[] { "과목명", "담당교수" });
            SearchCmb.Location = new Point(483, 135);
            SearchCmb.Name = "SearchCmb";
            SearchCmb.Size = new Size(121, 23);
            SearchCmb.TabIndex = 8;
            // 
            // SearchPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1299, 951);
            Controls.Add(SearchCmb);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SearchBtn);
            Controls.Add(SearchText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchPage";
            Text = "Registration";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchText;
        private Button SearchBtn;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView SearchListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox SearchCmb;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private SplitContainer splitContainer1;
        private Label label8;
        private Label label9;
        private Label GradingLabel;
        private Label TeamProjLabel;
        private Label ExamLabel;
        private Label AttendanceLabel;
        private Label AssignmentLabel;
        private Label RatingLabel;
        private ListView commentListView;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}