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
    public partial class AddForm : Form
    {
        SqlConnection con;
        public int userID { get; set; }
        public string userName { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Course values('" + userID + "','" + addCrsNameText.Text + "','" + addCrsText.Text + "')";
                SqlCommand exsql = new SqlCommand(sql, con);
                con.Open();
                exsql.ExecuteNonQuery();
                MessageBox.Show("Please insert student info now.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                panel2.Show();
                showDataView();
                EditForm ef = new EditForm();
              //  ef.selectClassCombo.Items.Add(addCrsText.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void showDataView()
        {
            try
            {
                string select = "SELECT * FROM Student WHERE ClassID='" + addCrsText.Text + "' AND AdminID='" + userID + "'";
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRoomDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.classRoomDataSet.Course);
           this.studentTableAdapter.Fill(this.classRoomDataSet.Student);
con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\AUST CSE\\3.2\\SDProject\\SDProject\\ClassRoom.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql;
            //attndnceTable();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                sql = "INSERT INTO Student VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','"+addCrsText.Text+"','"+userID+"','"+dataGridView1.Rows[i].Cells[1].Value+"')";
                 SqlCommand exsql = new SqlCommand(sql, con);
                con.Open();
                exsql.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Successfully inserted.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Dashboard dash = new Dashboard();
            dash.userID = userID;
            dash.userName = userName;
            this.Hide();
            dash.ShowDialog();
            this.Close();

        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
