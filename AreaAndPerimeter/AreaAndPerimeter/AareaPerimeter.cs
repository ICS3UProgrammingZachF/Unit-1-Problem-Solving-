/*
 * Created by: zachary franks
 * Created on: 19-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - perimeter and area
 * This program dose do math of perimeter and area when isterd into a textbox
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

namespace AreaAndPerimeter
{
    public partial class AareaPerimeter : Form
    {
        public AareaPerimeter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local varirables

            double lenght, width, area, perimeter;

            //converts the string from each text box to a double

            lenght = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //calculates the  perimeter and area

            area = lenght * width;
            perimeter = (2 * lenght) + (2 * width);

            //this displays the perimeter and area itno their respective labels

            this.lblanswerarea.Text = Convert.ToString(area) + "cm2";
            this.lblanswerperimeter.Text = Convert.ToString(perimeter) + "cm";

            //tis shows the labes when the buton is pushed

            this.lblanswerarea.Show();
            this.lblanswerperimeter.Show();
            this.lblnamearea.Show();
            this.lblnameperimeter.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AareaPerimeter_Load(object sender, EventArgs e)
        {
            //this hides all the lables on the bottem
            this.lblanswerarea.Hide();
            this.lblanswerperimeter.Hide();
                this.lblnamearea.Hide();
            this.lblnameperimeter.Hide();
        }

        private void lblLenght_Click(object sender, EventArgs e)
        {

        }
    }
}
