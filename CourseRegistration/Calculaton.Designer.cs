namespace CourseRegistration
{
    partial class Calculaton
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(225, 261);
            label1.Name = "label1";
            label1.Size = new Size(393, 65);
            label1.TabIndex = 1;
            label1.Text = "Calculation Page";
            // 
            // Calculaton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 642);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculaton";
            Text = "Calculaton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}