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
    public partial class TakeAttendanc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\AUST CSE\\3.2\\SDProject\\SDProject\\ClassRoom.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

        public int userID { get; set; }
        TextBox TextBox1;
        Label[] ids = new Label[100];


        public TakeAttendanc()
        {


            InitializeComponent();

            
            dataGridView1.KeyPress +=
                new KeyPressEventHandler(TakeAttendanc_KeyPress);
        }

        private void TakeAttendanc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoomDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.classRoomDataSet.Student);
            // TODO: This line of code loads data into the 'classRoomDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.classRoomDataSet.Attendance);

            button2.Visible=false;
            setComboItem();


            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "Present";
            chk.Name = "chk";
            dataGridView1.Rows[0].Cells[1].Value = true;

        }

        void generateTable()
        {
            try
            {
                string select = "SELECT * FROM Attendance WHERE CourseID='" + selectClassCombo.SelectedItem.ToString() + "' AND AdminID='" + userID + "'AND Date='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, con); //c.con is the connection string

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                //dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void setComboItem()
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
                    selectClassCombo.Items.Add(reader.GetString(3));
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

        private void selectClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   insertInfo();
            // generateTable();

        }

        void insertInfo()
        {
            selectData();
            try
            {
                string sql;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    sql = "INSERT INTO Attendance VALUES('" + dataGridView2.Rows[i].Cells[0].Value + "','" + selectClassCombo.SelectedItem.ToString() + "','" + userID + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + 1 + "')";
                    SqlCommand exsql = new SqlCommand(sql, con);
                    con.Open();
                    exsql.ExecuteNonQuery();
                    con.Close();
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

        void selectData()
        {
            try
            {
                string select = "SELECT * FROM Student WHERE ClassID='" + selectClassCombo.SelectedItem.ToString() + "' AND AdminID='" + userID + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, con); //c.con is the connection string

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                //dataGridView1.ReadOnly = true;
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertInfo();
            generateTable();
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string dlt = "DELETE Attendance Where CourseID='" + selectClassCombo.SelectedItem.ToString() + "' AND AdminID='" + userID + "' AND Date='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
                SqlCommand com = new SqlCommand(dlt, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int demVal = 1;
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[1].Value) == true)
                    {
                        demVal = 1;
                    }
                    else
                        demVal = 0;

                    sql = "INSERT INTO Attendance VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + selectClassCombo.SelectedItem.ToString() + "','" + userID + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + demVal + "')";
                    SqlCommand exsql = new SqlCommand(sql, con);
                    con.Open();
                    exsql.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Attendance Taken","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dash = new Dashboard();
                dash.userID = userID;
                this.Hide();
                dash.ShowDialog();
                this.Close();
                
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

        void TakeAttendanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                        MessageBox.Show("Form.KeyPress: '" +
                            e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }



        }


        





    }
}
