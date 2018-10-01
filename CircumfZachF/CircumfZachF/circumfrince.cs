/*
 * Created by: zachary franks
 * Created on: 25-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - circumfrince
 * This program reqirs the user to insert an number wich is than insterd into a formual and diplyed on screen
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumfZachF
{
    public partial class circumfrece : Form
    {
        public circumfrece()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this hides the labes

            this.lblanwser1.Hide();
            this.lblanwser2.Hide();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

       
        {
            //show when press the buton

            this.lblanwser1.Show();
            this.lblanwser2.Show();

            //declare the local vairbles

            double circumfrece , radius;

            //convetrs the sting of the textbox to a double

            radius = double.Parse(txtcircum.Text);

            //calulates the circumfrece

            circumfrece = (radius * 2 * Math.PI);

            //conver the anwsers of the circmfrece to the lable

            lblanwser2.Text = Convert.ToString(circumfrece);

            circumfrece = Math.Round

        }
    }
}
