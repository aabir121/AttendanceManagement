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
    public partial class EditForm : Form
    {
        SqlConnection con;
        public int userID { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoomDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.classRoomDataSet.Student);
            // TODO: This line of code loads data into the 'classRoomDataSet3.Student' table. You can move, or remove it, as needed.
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\AUST CSE\\3.2\\SDProject\\SDProject\\ClassRoom.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

            setComboItem();
            
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

        void showStudentInfo()
        {
            panel1.Show();
            try
            {
                string select = "SELECT * FROM Student WHERE ClassID='" + selectClassCombo.SelectedItem.ToString() + "' AND AdminID='" + userID + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, con); //c.con is the connection string

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                //dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStudentInfo();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string sql;
            string dlt = "DELETE Student Where ClassID='" + selectClassCombo.SelectedItem.ToString() + "' AND AdminID='" + userID + "'";
            SqlCommand com = new SqlCommand(dlt,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                sql = "INSERT INTO Student VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + selectClassCombo.SelectedItem.ToString() + "','" + userID + "','" + dataGridView1.Rows[i].Cells[1].Value + "')";
                SqlCommand exsql = new SqlCommand(sql, con);
                con.Open();
                exsql.ExecuteNonQuery();
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
