using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCost
{
    public partial class PizzaCost : Form
    {
        public PizzaCost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        double diameter, subtotal , total , pizzas, HST ;

            pizzas = (double)(nubpizzas.Value);
            diameter = (double)(nudpizza.Value);

            subtotal =  ((0.5 * diameter ) + 0.99 + 0.75) * pizzas ;
            total = (subtotal * 0.13) + subtotal;
            HST = (subtotal * 0.13);
            

            lblanswersub.Text = string.Format("${0:0.00}", subtotal);
            lblanwsertotal.Text = string.Format("${0:0.00}", total);
            lbltax.Text = string.Format("${0:0.00}", HST);
        }

        private void nudpizza_ValueChanged(object sender, EventArgs e)
        {
    
        }

        private void PizzaCost_Load(object sender, EventArgs e)
        {
           

        }
    }
}
