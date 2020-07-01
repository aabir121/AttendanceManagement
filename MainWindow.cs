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
    public partial class MainWindow : Form
    {
        public static SqlConnection con;
        int userID;
        string userName = "";
        string userContact = "";
        string userPass = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='G:\\AUST CSE\\3.2\\SDProject\\SDProject\\ClassRoom.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sql = "SELECT * FROM Admin WHERE AdminName='" + logUser.Text + "'";
                SqlCommand exsql = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();
                reader = exsql.ExecuteReader();
                if (reader.Read())
                {
                    userID = reader.GetInt32(0) ;
                    userName = reader.GetString(1);
                    userPass = reader.GetString(2);

                    if (userPass.Equals(logPass.Text))
                    {

                        Dashboard dash = new Dashboard();
                        this.Hide();
                        dash.userID = userID;
                        dash.userName = userName;
                        dash.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password dont match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The username is not registerd. Please register first to continue.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (regContact.Text.Length != 11)
            {
                MessageBox.Show("Invalid Conatact Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (regPass.Text == regConfirm.Text)
                {
                    try
                    {
                        string sql = "INSERT INTO Admin values('" + regUser.Text + "','" + regPass.Text + "','" + regContact.Text + "')";
                        SqlCommand com = new SqlCommand(sql, con);
                        con.Open();
                        com.ExecuteNonQuery();
                        regUser.Text = "";
                        regPass.Text = "";
                        regConfirm.Text = "";
                        regContact.Text = "";
                        MessageBox.Show("Registered Succesfully. You may login now.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid input! Try Again.", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Passwords dont match", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public int getUserID()
        {
            return userID;
        }
        public string getUserContact()
        {
            return userContact;
        }
        public string getUserName()
        {
            return userName;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
