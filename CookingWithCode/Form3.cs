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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Ansbox2.Text == "Cooked at medium with two slices of cheese")
            {
                lbllose2.Visible = false;
                lblcorrectv.Visible = true;
                lblwin2.Visible = true;
            }
            else
            {
                lbllose2.Visible = true;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
