using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDProject
{
    public partial class Dashboard : Form
    {
        public string userName { get; set; }
        public int userID { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            //button7.Hide();
            welcomeText.Text = "Welcome "+userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // button7.Show();
            TakeAttendanc ta = new TakeAttendanc();
            this.Hide();
            ta.userID = userID;
            ta.ShowDialog();
            this.Close();
            
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
            //button7.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           // button7.Hide();

            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                
                this.Opacity = 0.5;
            }
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            classPanel.Show();
        }
        private void classesBtn_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
            //classPanel.Show();
            //button7.Show();
        }

        private void classesBtn_MouseLeave(object sender, EventArgs e)
        {
            // button7.Hide();

        }


        private void editCrsBtn_MouseLeave(object sender, EventArgs e)
        {
            classPanel.Hide();
        }

        private void addCrsBtn_Click(object sender, EventArgs e)
        {
            AddForm addFrm = new AddForm();
            addFrm.userID = userID;
            addFrm.userName = userName;
            this.Hide();
            addFrm.ShowDialog();
            this.Close();
        }

        private void editCrsBtn_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            this.Hide();
            ef.userID = userID;
            ef.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            this.Hide();
            rpt.userID = userID;
            rpt.ShowDialog();
            this.Close();
        }
  
    }
}
