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
    public partial class EnrollmentEntry : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMI\Downloads\Tabil.accdb";

        public EnrollmentEntry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IDnumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM STUDENTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;
                string lastname = "";
                string firstname = "";
                string middlename = "";
                string course = "";
                int year = 0;

                while (thisDataReader.Read())
                {
                    //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                    if (thisDataReader["STFSTUDID"].ToString().Trim().ToUpper() == IDnumberTextBox.Text.Trim().ToUpper())
                    {
                        lastname = thisDataReader["STFSTUDLNAME"].ToString();
                        firstname = thisDataReader["STFSTUDFNAME"].ToString();
                        middlename = thisDataReader["STFSTUDMNAME"].ToString();
                        course = thisDataReader["STFSTUDCOURSE"].ToString();
                        year = Convert.ToInt16(thisDataReader["STFSTUDYEAR"]);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    string fullname = "";
                    if (middlename != string.Empty)
                        fullname = lastname + ", " + firstname + " " + middlename.Substring(0, 1) + ".";
                    else
                        fullname = lastname + ", " + firstname;
                    NameLabel2.Text = fullname;
                    CourseLabel2.Text = course;
                    YearLabel2.Text = year + "";
                }
                else
                    MessageBox.Show("Student ID not Found");
            }
        }

        private void EDPcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string days = "";
                string start = "";
                string end = "";
                bool conflict = false;
                bool closed = false;
                int i = 0;
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EDPcodeTextBox.Text.Trim().ToUpper())
                    {
                        days = thisDataReader["SSFDAYS"].ToString().ToUpper();
                        start = thisDataReader["SSFSTARTTIME"].ToString();
                        end = thisDataReader["SSFENDTIME"].ToString();
                    }
                }

                if (dataGridView1.Rows[0].Cells[0].Value != null)
                    i = -1;

                while (i < dataGridView1.Rows.Count - 1)
                {
                    string daysindatagrid = dataGridView1.Rows[i + 1].Cells[4].Value.ToString().ToUpper();
                    if (days == daysindatagrid)
                    {
                        conflict = true;
                        break;
                    }
                    else if ((days == "MW" && (daysindatagrid == "MON" || daysindatagrid == "WED")) || (daysindatagrid == "MW" && (days == "MON" || days == "WED")))
                    {
                        conflict = true;
                        break;
                    }
                    else if ((days == "MWF" && (daysindatagrid == "MON" || daysindatagrid == "WED" || daysindatagrid == "FRI")) || (daysindatagrid == "MWF" && (days == "MON" || days == "WED" || days == "WED")))
                    {
                        conflict = true;
                        break;
                    }
                    else if ((days == "TTH" && (daysindatagrid == "TUE" || daysindatagrid == "THU")) || (daysindatagrid == "TTH" && (days == "TUE" || days == "THU")))
                    {
                        conflict = true;
                        break;
                    }
                    else if ((days == "TTHS" && (daysindatagrid == "TUE" || daysindatagrid == "THU" || daysindatagrid == "SAT")) || (daysindatagrid == "TTHS" && (days == "TUE" || days == "THU" || days == "SAT")))
                    {
                        conflict = true;
                        break;
                    }
                    else if ((days == "FS" && (daysindatagrid == "FRI" || daysindatagrid == "SAT")) || (daysindatagrid == "FS" && (days == "FRI" || days == "SAT")))
                    {
                        conflict = true;
                        break;
                    }
                    i++;
                }

                i = 0;

                if (conflict)
                {
                    if (dataGridView1.Rows[0].Cells[0].Value != null)
                        i = -1;

                    while (i < dataGridView1.Rows.Count - 1)
                    {
                        TimeSpan starttime1 = DateTime.Parse(DateTime.Parse(start).ToString("HH:mm")).TimeOfDay;
                        TimeSpan starttime2 = DateTime.Parse(DateTime.Parse(dataGridView1.Rows[i + 1].Cells[2].Value.ToString()).ToString("HH:mm")).TimeOfDay;
                        TimeSpan endtime1 = DateTime.Parse(DateTime.Parse(end).ToString("HH:mm")).TimeOfDay;
                        TimeSpan endtime2 = DateTime.Parse(DateTime.Parse(dataGridView1.Rows[i + 1].Cells[3].Value.ToString()).ToString("HH:mm")).TimeOfDay;

                        if ((starttime1 < endtime2 && endtime1 > starttime2) || (starttime1 == starttime2 && endtime1 == endtime2))
                        {
                            conflict = true;
                            break;
                        }
                        else
                        {
                            conflict = false;
                        }
                        i++;
                    }
                }

                thisDataReader.Close();
                thisDataReader = thisCommand.ExecuteReader();

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EDPcodeTextBox.Text.Trim().ToUpper())
                    {
                        if (thisDataReader["SSFSTATUS"].ToString().Trim().ToUpper() == "IN")
                        {
                            closed = true;
                            break;
                        }
                    }
                }

                if (!conflict && !closed)
                {
                    if (dataGridView1.Rows[0].Cells[0].Value != null)
                        dataGridView1.Rows.Insert(0, new object[] { });
                    thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();
                    thisCommand = thisConnection.CreateCommand();

                    sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
                    thisCommand.CommandText = sql;

                    thisDataReader = thisCommand.ExecuteReader();

                    while (thisDataReader.Read())
                    {
                        //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                        if (thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EDPcodeTextBox.Text.Trim().ToUpper())
                        {
                            DateTime starttime = DateTime.Parse(thisDataReader["SSFSTARTTIME"] + "");
                            DateTime endtime = DateTime.Parse(thisDataReader["SSFENDTIME"] + "");
                            dataGridView1.Rows[0].Cells[0].Value = EDPcodeTextBox.Text.Trim().ToUpper();
                            dataGridView1.Rows[0].Cells[1].Value = thisDataReader["SSFSUBJCODE"].ToString();
                            dataGridView1.Rows[0].Cells[2].Value = starttime.ToShortTimeString();
                            dataGridView1.Rows[0].Cells[3].Value = endtime.ToShortTimeString();
                            dataGridView1.Rows[0].Cells[4].Value = thisDataReader["SSFDAYS"].ToString();
                            dataGridView1.Rows[0].Cells[5].Value = thisDataReader["SSFROOM"].ToString();
                            break;
                        }
                    }

                    thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();
                    thisCommand = thisConnection.CreateCommand();

                    sql = "SELECT * FROM SUBJECTFILE";
                    thisCommand.CommandText = sql;

                    thisDataReader = thisCommand.ExecuteReader();

                    while (thisDataReader.Read())
                    {
                        //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                        if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().Trim().ToUpper())
                        {
                            dataGridView1.Rows[0].Cells[6].Value = thisDataReader["SFSUBJUNITS"].ToString();
                            break;
                        }
                    }

                    i = 0;
                    int totalunits = 0;
                    while (i < dataGridView1.Rows.Count)
                    {
                        totalunits += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                        i++;
                    }
                    label3.Text = "Units:" + totalunits;
                }
                else if (conflict)
                    MessageBox.Show("Schedule is Conflict");
                else if (closed)
                    MessageBox.Show("Schedule is Closed");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(IDnumberTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter ID Number");
                return;
            }

            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please add schedule");
                return;
            }

            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();

            string sql = "SELECT * FROM ENROLLMENTHEADERFILE";
            thisCommand.CommandText = sql;

            OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

            bool found = false;

            while (thisDataReader.Read())
            {
                //MessageBox.Show(thisDataReader["SFSUBJCODE"].ToString());
                if (thisDataReader["ENRHFSTUDID"].ToString().Trim().ToUpper() == IDnumberTextBox.Text.Trim().ToUpper())
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                thisConnection = new OleDbConnection(connectionString);
                string Ole = "Select * From ENROLLMENTHEADERFILE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "EnrollmentHeaderFile");

                DataRow thisRow = thisDataSet.Tables["EnrollmentHeaderFile"].NewRow();
                thisRow["ENRHFSTUDID"] = IDnumberTextBox.Text;
                thisRow["ENHRFSTUDATEENROLL"] = DateTime.Now;
                thisRow["ENHRFSRUDSCHLYR"] = "2023-2024";
                thisRow["ENHRFSTUDENCODER"] = "Tabil";
                thisRow["ENHRFSTUDTOALUNITS"] = label3.Text.Substring((label3.Text.IndexOf(':') + 1));
                thisRow["ENHRFSTUDSTATUS"] = "EN";

                thisDataSet.Tables["EnrollmentHeaderFile"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "EnrollmentHeaderFile");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int classsize = 0;
                    thisConnection = new OleDbConnection(connectionString);
                    Ole = "Select * From ENROLLMENTDETAILFILE";
                    thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                    thisBuilder = new OleDbCommandBuilder(thisAdapter);
                    thisDataSet = new DataSet();
                    thisAdapter.Fill(thisDataSet, "EnrollmentDetailFile");

                    thisRow = thisDataSet.Tables["EnrollmentDetailFile"].NewRow();
                    thisRow["ENRDFSTUDID"] = IDnumberTextBox.Text;
                    thisRow["ENRDFSTUDSUBJCODE"] = dataGridView1.Rows[i].Cells[1].Value;
                    thisRow["ENRDFSTUDEDPCODE"] = dataGridView1.Rows[i].Cells[0].Value;

                    thisDataSet.Tables["EnrollmentDetailFile"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "EnrollmentDetailFile");


                    thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();
                    thisCommand = thisConnection.CreateCommand();

                    sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
                    thisCommand.CommandText = sql;

                    thisDataReader = thisCommand.ExecuteReader();

                    while (thisDataReader.Read())
                    {
                        if (thisDataReader["SSFEDPCODE"].ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            classsize = Convert.ToInt32(thisDataReader["SSFCLASSSIZE"]);
                            break;
                        }
                    }

                    sql = "UPDATE SUBJECTSCHEDULEFILE SET SSFCLASSSIZE = @ClassSize Where SSFEDPCODE = @EDPCode";

                    string classsizeupdate = (classsize + 1).ToString();
                    string edpcode = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    using (thisCommand = new OleDbCommand(sql, thisConnection))
                    {
                        thisCommand.Parameters.AddWithValue("@ClassSize", classsizeupdate);
                        thisCommand.Parameters.AddWithValue("@EDPCode", edpcode);
                        thisCommand.ExecuteNonQuery();
                        thisConnection.Close();
                    }

                    thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();
                    thisCommand = thisConnection.CreateCommand();

                    sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
                    thisCommand.CommandText = sql;

                    thisDataReader = thisCommand.ExecuteReader();

                    while (thisDataReader.Read())
                    {
                        if (thisDataReader["SSFEDPCODE"].ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            if (thisDataReader["SSFMAXSIZE"].ToString() == thisDataReader["SSFCLASSSIZE"].ToString())
                            {
                                sql = "UPDATE SUBJECTSCHEDULEFILE SET SSFSTATUS = @Status Where SSFEDPCODE = @EDPCode";

                                string statusupdate = "IN";
                                edpcode = dataGridView1.Rows[i].Cells[0].Value.ToString();

                                using (thisCommand = new OleDbCommand(sql, thisConnection))
                                {
                                    thisCommand.Parameters.AddWithValue("@Status", statusupdate);
                                    thisCommand.Parameters.AddWithValue("@EDPCode", edpcode);
                                    thisCommand.ExecuteNonQuery();
                                    thisConnection.Close();
                                }
                            }
                            break;
                        }
                    }
                }
                MessageBox.Show("Enrolled");
            }
            else
                MessageBox.Show("Student is already enrolled");
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IDnumberTextBox.Text = null;
            EDPcodeTextBox.Text = null;
        }
    }
}
