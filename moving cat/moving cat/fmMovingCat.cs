/*
 * Created by: Zachary Franks
 * Created on: 17-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - moving cat
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

namespace moving_cat
{
    public partial class frmmovingcat : Form
    {
        public frmmovingcat()
        {
            InitializeComponent();
        }

        private void niceCatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.catstanding;
        }

        private void badCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.Catmoving;
        }
    }
}
