namespace Enrollment_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectCodeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.OfferingLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CourseCodeLabel = new System.Windows.Forms.Label();
            this.CurriculumYearLabel = new System.Windows.Forms.Label();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.PrerequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.CorequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.RequisiteTextBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Information";
            // 
            // SubjectCodeLabel
            // 
            this.SubjectCodeLabel.AutoSize = true;
            this.SubjectCodeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubjectCodeLabel.Location = new System.Drawing.Point(75, 214);
            this.SubjectCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectCodeLabel.Name = "SubjectCodeLabel";
            this.SubjectCodeLabel.Size = new System.Drawing.Size(105, 20);
            this.SubjectCodeLabel.TabIndex = 1;
            this.SubjectCodeLabel.Text = "Subject Code";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionLabel.Location = new System.Drawing.Point(75, 254);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitsLabel.Location = new System.Drawing.Point(75, 297);
            this.UnitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(46, 20);
            this.UnitsLabel.TabIndex = 3;
            this.UnitsLabel.Text = "Units";
            // 
            // OfferingLabel
            // 
            this.OfferingLabel.AutoSize = true;
            this.OfferingLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OfferingLabel.Location = new System.Drawing.Point(75, 345);
            this.OfferingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OfferingLabel.Name = "OfferingLabel";
            this.OfferingLabel.Size = new System.Drawing.Size(66, 20);
            this.OfferingLabel.TabIndex = 4;
            this.OfferingLabel.Text = "Offering";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryLabel.Location = new System.Drawing.Point(75, 394);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 20);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // CourseCodeLabel
            // 
            this.CourseCodeLabel.AutoSize = true;
            this.CourseCodeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CourseCodeLabel.Location = new System.Drawing.Point(75, 428);
            this.CourseCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseCodeLabel.Name = "CourseCodeLabel";
            this.CourseCodeLabel.Size = new System.Drawing.Size(102, 20);
            this.CourseCodeLabel.TabIndex = 6;
            this.CourseCodeLabel.Text = "Course Code";
            // 
            // CurriculumYearLabel
            // 
            this.CurriculumYearLabel.AutoSize = true;
            this.CurriculumYearLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurriculumYearLabel.Location = new System.Drawing.Point(75, 483);
            this.CurriculumYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurriculumYearLabel.Name = "CurriculumYearLabel";
            this.CurriculumYearLabel.Size = new System.Drawing.Size(122, 20);
            this.CurriculumYearLabel.TabIndex = 7;
            this.CurriculumYearLabel.Text = "Curriculum Year";
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(228, 209);
            this.SubjectCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.SubjectCodeTextBox.TabIndex = 8;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(228, 254);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(148, 26);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(228, 292);
            this.UnitsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(56, 26);
            this.UnitsTextBox.TabIndex = 10;
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 "});
            this.OfferingComboBox.Location = new System.Drawing.Point(228, 340);
            this.OfferingComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(180, 28);
            this.OfferingComboBox.TabIndex = 11;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lec",
            "Lab"});
            this.CategoryComboBox.Location = new System.Drawing.Point(228, 382);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(180, 28);
            this.CategoryComboBox.TabIndex = 12;
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            " BSIT",
            " BSIS",
            " ACT"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(228, 428);
            this.CourseCodeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(180, 28);
            this.CourseCodeComboBox.TabIndex = 13;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(228, 478);
            this.CurriculumYearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(148, 26);
            this.CurriculumYearTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(18, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 432);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(502, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Requisite Information";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubjectLabel.Location = new System.Drawing.Point(518, 283);
            this.SubjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(109, 20);
            this.SubjectLabel.TabIndex = 17;
            this.SubjectLabel.Text = "Subject Code:";
            // 
            // PrerequisiteRadioButton
            // 
            this.PrerequisiteRadioButton.AutoSize = true;
            this.PrerequisiteRadioButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrerequisiteRadioButton.Location = new System.Drawing.Point(842, 248);
            this.PrerequisiteRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrerequisiteRadioButton.Name = "PrerequisiteRadioButton";
            this.PrerequisiteRadioButton.Size = new System.Drawing.Size(131, 24);
            this.PrerequisiteRadioButton.TabIndex = 20;
            this.PrerequisiteRadioButton.TabStop = true;
            this.PrerequisiteRadioButton.Text = "Pre - requisite";
            this.PrerequisiteRadioButton.UseVisualStyleBackColor = false;
            // 
            // CorequisiteRadioButton
            // 
            this.CorequisiteRadioButton.AutoSize = true;
            this.CorequisiteRadioButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CorequisiteRadioButton.Location = new System.Drawing.Point(842, 283);
            this.CorequisiteRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CorequisiteRadioButton.Name = "CorequisiteRadioButton";
            this.CorequisiteRadioButton.Size = new System.Drawing.Size(123, 24);
            this.CorequisiteRadioButton.TabIndex = 21;
            this.CorequisiteRadioButton.TabStop = true;
            this.CorequisiteRadioButton.Text = "Co- requisite";
            this.CorequisiteRadioButton.UseVisualStyleBackColor = false;
            // 
            // RequisiteTextBox
            // 
            this.RequisiteTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RequisiteTextBox.Location = new System.Drawing.Point(638, 278);
            this.RequisiteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RequisiteTextBox.Name = "RequisiteTextBox";
            this.RequisiteTextBox.Size = new System.Drawing.Size(148, 26);
            this.RequisiteTextBox.TabIndex = 22;
            this.RequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequisiteTextBox_KeyPress);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.PreColumn});
            this.SubjectDataGridView.Location = new System.Drawing.Point(508, 318);
            this.SubjectDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 62;
            this.SubjectDataGridView.Size = new System.Drawing.Size(638, 231);
            this.SubjectDataGridView.TabIndex = 23;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.MinimumWidth = 8;
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.Width = 150;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 8;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 150;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.MinimumWidth = 8;
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.Width = 150;
            // 
            // PreColumn
            // 
            this.PreColumn.HeaderText = "Co/Pre";
            this.PreColumn.MinimumWidth = 8;
            this.PreColumn.Name = "PreColumn";
            this.PreColumn.Width = 150;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(477, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(705, 432);
            this.label5.TabIndex = 24;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SaveButton.Location = new System.Drawing.Point(450, 602);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 62);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton.Location = new System.Drawing.Point(579, 602);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 62);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(404, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 65);
            this.label4.TabIndex = 27;
            this.label4.Text = "Subject Entry";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(1083, 46);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 33);
            this.MenuButton.TabIndex = 28;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.RequisiteTextBox);
            this.Controls.Add(this.CorequisiteRadioButton);
            this.Controls.Add(this.PrerequisiteRadioButton);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurriculumYearTextBox);
            this.Controls.Add(this.CourseCodeComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.OfferingComboBox);
            this.Controls.Add(this.UnitsTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.CurriculumYearLabel);
            this.Controls.Add(this.CourseCodeLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.OfferingLabel);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectCodeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SubjectCodeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Label OfferingLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CourseCodeLabel;
        private System.Windows.Forms.Label CurriculumYearLabel;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.RadioButton PrerequisiteRadioButton;
        private System.Windows.Forms.RadioButton CorequisiteRadioButton;
        private System.Windows.Forms.TextBox RequisiteTextBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MenuButton;
    }
}

