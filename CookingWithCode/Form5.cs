using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingWithCode
{
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltxt1.Visible = true;
            lbltxt2.Visible = true; 
            pctrBox1.Visible = true;
            label6.Visible = true;
            label8.Visible = true; 
            Ansbox8.Visible = true; 
            btn3.Visible = true;    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Ansbox8.Text == "private void button3_Click(object sender, EventArgs e)")
            {
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = false;
            }
            else
            {
                label12.Visible = true;
            }
        }
    }

}
