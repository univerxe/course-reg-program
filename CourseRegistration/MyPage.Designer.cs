﻿namespace CourseRegistration
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
            label1 = new Label();
            favorites = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(519, 424);
            label1.Name = "label1";
            label1.Size = new Size(203, 65);
            label1.TabIndex = 2;
            label1.Text = "MyPage";
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
            // MyPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1299, 951);
            Controls.Add(favorites);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyPage";
            Text = "Curriculum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label favorites;
    }
}