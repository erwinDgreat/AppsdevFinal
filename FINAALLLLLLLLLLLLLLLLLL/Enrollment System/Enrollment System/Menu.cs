using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void SubjectScheduleEntryButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntry subjectScheduleEntry = new SubjectScheduleEntry();
            subjectScheduleEntry.Show();
            Hide();
        }

        private void EnrollmentEntryButton_Click(object sender, EventArgs e)
        {
            EnrollmentEntry entry = new EnrollmentEntry();
            entry.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
