namespace Enrollment_System
{
    partial class Menu
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
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.EnrollmentEntryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.Location = new System.Drawing.Point(414, 203);
            this.SubjectEntryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(372, 54);
            this.SubjectEntryButton.TabIndex = 0;
            this.SubjectEntryButton.Text = "Subject Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = true;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(414, 267);
            this.SubjectScheduleEntryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(372, 54);
            this.SubjectScheduleEntryButton.TabIndex = 1;
            this.SubjectScheduleEntryButton.Text = "Subject Schedule Entry";
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = true;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // EnrollmentEntryButton
            // 
            this.EnrollmentEntryButton.Location = new System.Drawing.Point(414, 330);
            this.EnrollmentEntryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnrollmentEntryButton.Name = "EnrollmentEntryButton";
            this.EnrollmentEntryButton.Size = new System.Drawing.Size(372, 54);
            this.EnrollmentEntryButton.TabIndex = 2;
            this.EnrollmentEntryButton.Text = "Enrollment Entry";
            this.EnrollmentEntryButton.UseVisualStyleBackColor = true;
            this.EnrollmentEntryButton.Click += new System.EventHandler(this.EnrollmentEntryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(410, 394);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(376, 51);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 96);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enrollment System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnrollmentEntryButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentEntryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}