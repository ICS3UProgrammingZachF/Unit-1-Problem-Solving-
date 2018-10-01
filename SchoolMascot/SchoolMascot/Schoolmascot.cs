/*
 * Created by: zachary Franks
 * Created on: 14-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Schoolmascot
 * This program
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

namespace SchoolMascot
{
    public partial class frmSchoolmascot : Form
    {
        public frmSchoolmascot()
        {
            InitializeComponent();
        }
        private void immaculataHighSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this chages the label of the school name and motto
            this.lblschools.Text = "Immaculata";
            this.lblSchoolMotto.Text = "Studdy build caerter";
        }

        private void louisRielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this chages the label of the school name and motto
            this.lblschools.Text = "Louis - Riel";
            this.lblSchoolMotto.Text = "Louis - Riel active for life";
        }

        private void ashburyCollegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this chages the label of the school name and motto
            this.lblschools.Text = "Lisgar";
            this.lblSchoolMotto.Text = "Nourish the Flame";
        }

        private void lisgarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this chages the label of the school name and motto
            this.lblschools.Text = "Ashbury";
                this.lblSchoolMotto.Text = "Honesty, Courage, Kindness";
        }

 
        {

        }
    }
}
