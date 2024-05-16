using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectScheduleEntry : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMI\Downloads\Tabil.accdb";
        public SubjectScheduleEntry()
        {
            InitializeComponent();
        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;
                string description = "";

                while (thisDataReader.Read())
                {
                    //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == SubjectCodeTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        DescriptionLabel2.Text = description;
                        break;
                    }
                }
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();

            string sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
            thisCommand.CommandText = sql;

            OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

            bool found = false;

            while (thisDataReader.Read())
            {
                //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                if (thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EDPCodeTextBox.Text.Trim().ToUpper())
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
                MessageBox.Show("EDP Code is Duplicate");
            else
            {
                thisConnection = new OleDbConnection(connectionString);
                string Ole = "Select * From SUBJECTSCHEDULEFILE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SUBJECTSCHEDULEFILE");

                DataRow thisRow = thisDataSet.Tables["SUBJECTSCHEDULEFILE"].NewRow();
                thisRow["SSFEDPCODE"] = EDPCodeTextBox.Text;
                thisRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;
                thisRow["SSFSTARTTIME"] = StartTimeDatePicker.Text;
                thisRow["SSFENDTIME"] = ExitTimeDatePicker.Text;
                thisRow["SSFDAYS"] = DaysTextBox.Text.Substring(0, 3);
                thisRow["SSFROOM"] = RoomTextBox.Text;
                thisRow["SSFXM"] = DayComboBox.Text;
                thisRow["SSFSECTION"] = SectionTextBox.Text;
                thisRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text;
                thisRow["SSFMAXSIZE"] = 5;
                thisRow["SSFCLASSSIZE"] = 0;
                thisRow["SSFSTATUS"] = "AC";

                thisDataSet.Tables["SUBJECTSCHEDULEFILE"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "SUBJECTSCHEDULEFILE");

                MessageBox.Show("Recorded");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EDPCodeTextBox.Text = null;
            SubjectCodeTextBox.Text = null;
            StartTimeDatePicker.Text = null;
            ExitTimeDatePicker.Text = null;
            DaysTextBox.Text = null;
            SectionTextBox.Text = null;
            RoomTextBox.Text = null;
            SchoolYearTextBox.Text = null;
            DayComboBox.Text = null;
        }
    }
}

