using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDProject
{
    public partial class Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\AUST CSE\\3.2\\SDProject\\SDProject\\ClassRoom.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

        public int userID { get; set; }
        public Report()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            setCourseComboItem();

        }

        void setCourseComboItem()
        {
            try
            {
                string sql = "SELECT * FROM Course WHERE AdminID='" + userID + "'";
                SqlCommand exsql = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();
                reader = exsql.ExecuteReader();
                while (reader.Read())
                {
                    courseComboBox.Items.Add(reader.GetString(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        void setIDComboItem()
        {
            try
            {
                string sql = "SELECT * FROM Student WHERE AdminID='" + userID + "' AND ClassID='"+courseComboBox.SelectedItem.ToString()+"'";
                SqlCommand exsql = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();
                reader = exsql.ExecuteReader();
                while (reader.Read())
                {
                    idComboBox.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setIDComboItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int present = 0;
            int absent = 0;
            try
            {
                
                string sql = "SELECT * FROM Attendance WHERE AdminID='" + userID + "' AND CourseID='" + courseComboBox.SelectedItem.ToString() + "' AND StudentID='" + idComboBox.SelectedItem.ToString() + "'";
                SqlCommand exsql = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();
                reader = exsql.ExecuteReader();
                while (reader.Read())
                {
                    total++;
                    if (reader.GetInt32(4) == 1)
                    {
                        present++;
                    }
                    else
                        absent++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            double percent;
            percent=(double)((double)present/(double)total)*100;
            presentTextBox.Text = "" + present;
            absentTextBox .Text= "" + absent;
            percentageTextBox.Text = "" + percent + "%";
            idTextBox.Text = idComboBox.SelectedItem.ToString();
            nameTextBox.Text = "";
        
        }



       
    }
}
