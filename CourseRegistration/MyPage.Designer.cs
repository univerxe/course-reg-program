namespace CourseRegistration
{
    partial class MyPage
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
            favorites = new Label();
            main_panel = new Panel();
            panel7 = new Panel();
            prof_email = new Label();
            prof_name = new Label();
            label1 = new Label();
            prof_img = new PictureBox();
            panel6 = new Panel();
            req_major_list = new CheckedListBox();
            txtOutput = new Label();
            panel4 = new Panel();
            elective_lec_list = new CheckedListBox();
            label8 = new Label();
            panel5 = new Panel();
            average_grade = new Label();
            label6 = new Label();
            credits_sum = new Label();
            label4 = new Label();
            panel3 = new Panel();
            credits_list = new ListView();
            lecture_name = new ColumnHeader();
            lecture_info = new ColumnHeader();
            lecture_grade = new ColumnHeader();
            lecture_credit = new ColumnHeader();
            label20 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            student_major_credits = new Label();
            student_credits = new Label();
            student_rating = new Label();
            label98 = new Label();
            student_elec_credits = new Label();
            label99 = new Label();
            label100 = new Label();
            student_year = new Label();
            student_sec_major = new Label();
            student_major = new Label();
            student_id = new Label();
            student_name = new Label();
            panel1 = new Panel();
            student_img = new PictureBox();
            main_label = new Label();
            main_panel.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prof_img).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_img).BeginInit();
            SuspendLayout();
            // 
            // favorites
            // 
            favorites.AutoSize = true;
            favorites.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            favorites.Location = new Point(33, 34);
            favorites.Name = "favorites";
            favorites.Size = new Size(0, 45);
            favorites.TabIndex = 3;
            // 
            // main_panel
            // 
            main_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_panel.BackColor = Color.FromArgb(244, 244, 244);
            main_panel.Controls.Add(panel7);
            main_panel.Controls.Add(panel6);
            main_panel.Controls.Add(panel4);
            main_panel.Controls.Add(panel5);
            main_panel.Controls.Add(panel3);
            main_panel.Controls.Add(panel2);
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(main_label);
            main_panel.Location = new Point(40, 40);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1220, 870);
            main_panel.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(87, 33, 43);
            panel7.Controls.Add(prof_email);
            panel7.Controls.Add(prof_name);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(prof_img);
            panel7.Location = new Point(943, 599);
            panel7.Name = "panel7";
            panel7.Size = new Size(229, 244);
            panel7.TabIndex = 2;
            // 
            // prof_email
            // 
            prof_email.AutoSize = true;
            prof_email.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prof_email.ForeColor = Color.White;
            prof_email.Location = new Point(57, 215);
            prof_email.Name = "prof_email";
            prof_email.Size = new Size(114, 24);
            prof_email.TabIndex = 10;
            prof_email.Text = "eglee96@kw.ac.kr\n";
            // 
            // prof_name
            // 
            prof_name.AutoSize = true;
            prof_name.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prof_name.ForeColor = Color.White;
            prof_name.Location = new Point(73, 184);
            prof_name.Name = "prof_name";
            prof_name.Size = new Size(81, 34);
            prof_name.TabIndex = 11;
            prof_name.Text = "이윤구";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 14);
            label1.Name = "label1";
            label1.Size = new Size(103, 34);
            label1.TabIndex = 10;
            label1.Text = "지도교수";
            // 
            // prof_img
            // 
            prof_img.Location = new Point(57, 53);
            prof_img.Name = "prof_img";
            prof_img.Size = new Size(112, 128);
            prof_img.SizeMode = PictureBoxSizeMode.StretchImage;
            prof_img.TabIndex = 1;
            prof_img.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(217, 217, 217);
            panel6.Controls.Add(req_major_list);
            panel6.Controls.Add(txtOutput);
            panel6.Location = new Point(286, 599);
            panel6.Name = "panel6";
            panel6.Size = new Size(639, 244);
            panel6.TabIndex = 2;
            // 
            // req_major_list
            // 
            req_major_list.BackColor = Color.FromArgb(217, 217, 217);
            req_major_list.BorderStyle = BorderStyle.None;
            req_major_list.Cursor = Cursors.SizeWE;
            req_major_list.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            req_major_list.ForeColor = Color.Black;
            req_major_list.FormattingEnabled = true;
            req_major_list.HorizontalScrollbar = true;
            req_major_list.ImeMode = ImeMode.Off;
            req_major_list.Location = new Point(18, 52);
            req_major_list.Name = "req_major_list";
            req_major_list.Size = new Size(579, 175);
            req_major_list.TabIndex = 21;
            // 
            // txtOutput
            // 
            txtOutput.AutoSize = true;
            txtOutput.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = Color.Black;
            txtOutput.Location = new Point(14, 9);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(103, 34);
            txtOutput.TabIndex = 21;
            txtOutput.Text = "전공필수";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(87, 33, 43);
            panel4.Controls.Add(elective_lec_list);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(39, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(639, 244);
            panel4.TabIndex = 1;
            // 
            // elective_lec_list
            // 
            elective_lec_list.BackColor = Color.FromArgb(87, 33, 43);
            elective_lec_list.BorderStyle = BorderStyle.None;
            elective_lec_list.Cursor = Cursors.SizeWE;
            elective_lec_list.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elective_lec_list.ForeColor = Color.White;
            elective_lec_list.FormattingEnabled = true;
            elective_lec_list.HorizontalScrollbar = true;
            elective_lec_list.ImeMode = ImeMode.Off;
            elective_lec_list.Location = new Point(23, 47);
            elective_lec_list.Name = "elective_lec_list";
            elective_lec_list.Size = new Size(579, 175);
            elective_lec_list.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 9);
            label8.Name = "label8";
            label8.Size = new Size(103, 34);
            label8.TabIndex = 10;
            label8.Text = "교양필수";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(107, 34, 48);
            panel5.Controls.Add(average_grade);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(credits_sum);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(39, 599);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 244);
            panel5.TabIndex = 2;
            // 
            // average_grade
            // 
            average_grade.AutoSize = true;
            average_grade.Font = new Font("Agency FB", 27.75F, FontStyle.Bold);
            average_grade.ForeColor = Color.White;
            average_grade.Location = new Point(48, 74);
            average_grade.Name = "average_grade";
            average_grade.Size = new Size(132, 44);
            average_grade.TabIndex = 12;
            average_grade.Text = "4.32/4.5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(63, 136);
            label6.Name = "label6";
            label6.Size = new Size(103, 34);
            label6.TabIndex = 11;
            label6.Text = "취득점수";
            // 
            // credits_sum
            // 
            credits_sum.AutoSize = true;
            credits_sum.Font = new Font("Agency FB", 27.75F, FontStyle.Bold);
            credits_sum.ForeColor = Color.White;
            credits_sum.Location = new Point(60, 166);
            credits_sum.Name = "credits_sum";
            credits_sum.Size = new Size(108, 44);
            credits_sum.TabIndex = 11;
            credits_sum.Text = "36/133";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(60, 43);
            label4.Name = "label4";
            label4.Size = new Size(115, 34);
            label4.TabIndex = 10;
            label4.Text = "평균 학점 ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.Controls.Add(credits_list);
            panel3.Controls.Add(label20);
            panel3.Location = new Point(693, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 507);
            panel3.TabIndex = 2;
            // 
            // credits_list
            // 
            credits_list.Columns.AddRange(new ColumnHeader[] { lecture_name, lecture_info, lecture_grade, lecture_credit });
            credits_list.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credits_list.GridLines = true;
            credits_list.Location = new Point(21, 56);
            credits_list.Name = "credits_list";
            credits_list.Scrollable = false;
            credits_list.Size = new Size(432, 427);
            credits_list.TabIndex = 11;
            credits_list.UseCompatibleStateImageBehavior = false;
            credits_list.View = View.Details;
            // 
            // lecture_name
            // 
            lecture_name.Text = "과목명";
            lecture_name.Width = 230;
            // 
            // lecture_info
            // 
            lecture_info.Text = "이수구분";
            lecture_info.TextAlign = HorizontalAlignment.Center;
            // 
            // lecture_grade
            // 
            lecture_grade.Text = "학점";
            lecture_grade.TextAlign = HorizontalAlignment.Center;
            // 
            // lecture_credit
            // 
            lecture_credit.Text = "성적";
            lecture_credit.TextAlign = HorizontalAlignment.Center;
            lecture_credit.Width = 80;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(13, 14);
            label20.Name = "label20";
            label20.Size = new Size(103, 34);
            label20.TabIndex = 10;
            label20.Text = "성적내역";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 34, 48);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(student_major_credits);
            panel2.Controls.Add(student_credits);
            panel2.Controls.Add(student_rating);
            panel2.Controls.Add(label98);
            panel2.Controls.Add(student_elec_credits);
            panel2.Controls.Add(label99);
            panel2.Controls.Add(label100);
            panel2.Controls.Add(student_year);
            panel2.Controls.Add(student_sec_major);
            panel2.Controls.Add(student_major);
            panel2.Controls.Add(student_id);
            panel2.Controls.Add(student_name);
            panel2.Location = new Point(286, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 244);
            panel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(18, 210);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 12;
            label11.Text = "필수교양     |";
            // 
            // student_major_credits
            // 
            student_major_credits.AutoSize = true;
            student_major_credits.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_major_credits.ForeColor = Color.White;
            student_major_credits.Location = new Point(102, 190);
            student_major_credits.Name = "student_major_credits";
            student_major_credits.Size = new Size(49, 20);
            student_major_credits.TabIndex = 11;
            student_major_credits.Text = "33 / 60 ";
            // 
            // student_credits
            // 
            student_credits.AutoSize = true;
            student_credits.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_credits.ForeColor = Color.White;
            student_credits.Location = new Point(102, 166);
            student_credits.Name = "student_credits";
            student_credits.Size = new Size(52, 20);
            student_credits.TabIndex = 10;
            student_credits.Text = "54 / 133 ";
            // 
            // student_rating
            // 
            student_rating.AutoSize = true;
            student_rating.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_rating.ForeColor = Color.White;
            student_rating.Location = new Point(330, 201);
            student_rating.Name = "student_rating";
            student_rating.Size = new Size(44, 25);
            student_rating.TabIndex = 9;
            student_rating.Text = "7/97";
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label98.ForeColor = Color.White;
            label98.Location = new Point(323, 181);
            label98.Name = "label98";
            label98.Size = new Size(57, 20);
            label98.TabIndex = 8;
            label98.Text = "학과석차";
            // 
            // student_elec_credits
            // 
            student_elec_credits.AutoSize = true;
            student_elec_credits.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_elec_credits.ForeColor = Color.White;
            student_elec_credits.Location = new Point(102, 210);
            student_elec_credits.Name = "student_elec_credits";
            student_elec_credits.Size = new Size(43, 20);
            student_elec_credits.TabIndex = 7;
            student_elec_credits.Text = " 6 / 18 ";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label99.ForeColor = Color.White;
            label99.Location = new Point(18, 188);
            label99.Name = "label99";
            label99.Size = new Size(75, 20);
            label99.TabIndex = 6;
            label99.Text = "전공학점     |";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label100.ForeColor = Color.White;
            label100.Location = new Point(18, 166);
            label100.Name = "label100";
            label100.Size = new Size(78, 20);
            label100.TabIndex = 5;
            label100.Text = "최득학점     | ";
            // 
            // student_year
            // 
            student_year.AutoSize = true;
            student_year.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_year.ForeColor = Color.White;
            student_year.Location = new Point(18, 116);
            student_year.Name = "student_year";
            student_year.Size = new Size(39, 20);
            student_year.TabIndex = 4;
            student_year.Text = "3학년";
            // 
            // student_sec_major
            // 
            student_sec_major.AutoSize = true;
            student_sec_major.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_sec_major.ForeColor = Color.White;
            student_sec_major.Location = new Point(18, 96);
            student_sec_major.Name = "student_sec_major";
            student_sec_major.Size = new Size(168, 20);
            student_sec_major.TabIndex = 3;
            student_sec_major.Text = "소프트웨어학부 인공지능전공";
            // 
            // student_major
            // 
            student_major.AutoSize = true;
            student_major.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_major.ForeColor = Color.White;
            student_major.Location = new Point(18, 76);
            student_major.Name = "student_major";
            student_major.Size = new Size(93, 20);
            student_major.TabIndex = 2;
            student_major.Text = "소프트웨어학과";
            // 
            // student_id
            // 
            student_id.AutoSize = true;
            student_id.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_id.ForeColor = Color.White;
            student_id.Location = new Point(18, 52);
            student_id.Name = "student_id";
            student_id.Size = new Size(90, 24);
            student_id.TabIndex = 1;
            student_id.Text = "2022203502";
            // 
            // student_name
            // 
            student_name.AutoSize = true;
            student_name.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_name.ForeColor = Color.White;
            student_name.Location = new Point(18, 18);
            student_name.Name = "student_name";
            student_name.Size = new Size(81, 34);
            student_name.TabIndex = 0;
            student_name.Text = "최바딤";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(student_img);
            panel1.Location = new Point(39, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 244);
            panel1.TabIndex = 1;
            // 
            // student_img
            // 
            student_img.Location = new Point(25, 16);
            student_img.Name = "student_img";
            student_img.Size = new Size(181, 214);
            student_img.SizeMode = PictureBoxSizeMode.StretchImage;
            student_img.TabIndex = 0;
            student_img.TabStop = false;
            // 
            // main_label
            // 
            main_label.AutoSize = true;
            main_label.Font = new Font("Arial Narrow", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            main_label.Location = new Point(28, 13);
            main_label.Name = "main_label";
            main_label.Size = new Size(167, 52);
            main_label.TabIndex = 0;
            main_label.Text = "My Page";
            // 
            // MyPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1299, 951);
            Controls.Add(main_panel);
            Controls.Add(favorites);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyPage";
            Text = "Curriculum";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prof_img).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label favorites;
        private Panel main_panel;
        private Label main_label;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private PictureBox prof_img;
        private PictureBox student_img;
        private Label student_id;
        private Label student_name;
        private Label student_sec_major;
        private Label student_major;
        private Label label100;
        private Label student_year;
        private Label student_elec_credits;
        private Label label99;
        private Label prof_name;
        private Label label1;
        private Label student_rating;
        private Label label98;
        private Label prof_email;
        private Label average_grade;
        private Label label6;
        private Label credits_sum;
        private Label label4;
        private Label label8;
        private Label txtOutput;
        private Label label20;
        private ListView credits_list;
        private ColumnHeader lecture_name;
        private ColumnHeader lecture_info;
        private ColumnHeader lecture_grade;
        private ColumnHeader lecture_credit;
        private CheckedListBox elective_lec_list;
        private CheckedListBox req_major_list;
        private Label student_credits;
        private Label label11;
        private Label student_major_credits;
    }
}