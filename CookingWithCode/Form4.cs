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
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Ansbox3.Text == "a is less than b")
            {
                lblcorrect3.Visible = true;
                lbl22.Visible = true;
                lbl21.Visible = true;
                lbl23.Visible = true;
                Ansbox4.Visible = true;
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Ansbox4.Text == "a is greater than b")
            {
                lblcorrect4.Visible = true;
                lblendwin3.Visible = true;
                
            }
        }
    }
}
