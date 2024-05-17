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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (AnsBox1.Text == "2" && lblq11.Visible == true)
            {
                lblq11.Visible = false;
                lblq12.Visible = false; 
                lblq21.Visible = true; 
                lblq22.Visible = true;
                lblwin.Visible = true;
                lbllose.Visible = false;
                AnsBox1.Clear();
               
            }
            if (AnsBox1.Text == "1" && lblq21.Visible == true)
            {
                lblq21.Visible = false;
                lblq22.Visible = false;
                lblq31.Visible = true;
                lblq32.Visible = true;
                lblq33.Visible = true;
                lblwin.Visible = true;
                lbllose.Visible = false;
                AnsBox1.Clear();
            }
            if (AnsBox1.Text == "3" && lblq31.Visible == true)
            {
                lblq31.Visible = false;
                lblq32.Visible = false;
                lblwin.Visible = true;
                lblq32.Visible = false;
                lblendwin.Visible = true;
                lbllose.Visible = false;
                AnsBox1.Clear();
            }
           
          
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblendwin_Click(object sender, EventArgs e)
        {

        }
    }
}
