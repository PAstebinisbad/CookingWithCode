using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingWithCode
{
    public partial class Form : System.Windows.Forms.Form
    {
        int size = 2; // Size of the grid (e.g., 3x3)
        int x = 0; // Initial x-coordinate
        int y = 1; // Initial y-coordinate

        string[,] output = { { "String1", "String2" }, { "String3", "String4" } };


        PictureBox[,] pictures = new PictureBox[2, 2];

        string imgPlayer = Directory.GetCurrentDirectory() + "/Images/CustomerSelect.jpeg";
        string imgBackround = Directory.GetCurrentDirectory() + "/Images/Customer1.jpeg";
       
        public Form()
        {
            InitializeComponent();

            if (!this.Focus())
            {
                this.Focus();
            }
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyDown);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pictures[i, j] = new PictureBox();
                    pictures[i, j].Image = Image.FromFile(imgBackround, true);
                    pictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                   table.Controls.Add(pictures[i, j]);
                }
                   
            }
            pictures[y, x].Image = Image.FromFile(imgPlayer);
        }


        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (x < size - 1)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackround);
                    x++;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (x > 0)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackround);
                    x--;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (y < size - 1)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackround);
                    y++;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                if (y > 0)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackround);
                    y--;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            
            if (output[x,y] == "String1") { 
                
                Lbl1.Visible = true;
                Lbl2.Visible = false;
                Lbl3.Visible = false;
                Lbl4.Visible = false;
                lblLL.Visible = true;
                lblVV.Visible = false;
                lblCC.Visible = false;
                LblEE.Visible = false;
            } 
            if (output[x, y] == "String2")
            {

                Lbl1.Visible = false;
                Lbl2.Visible = false;
                Lbl3.Visible = true;
                Lbl4.Visible = false;
                lblLL.Visible = false;
                lblVV.Visible = true;
                lblCC.Visible = false;
                LblEE.Visible = false;
            }

            if (output[x, y] == "String3")
            {

                Lbl1.Visible = false;
                Lbl2.Visible = true;
                Lbl3.Visible = false;
                Lbl4.Visible = false;
                lblLL.Visible = false;
                lblVV.Visible = false;
                lblCC.Visible = true;
                LblEE.Visible = false;
            }
            if (output[x, y] == "String4")
            {

                Lbl1.Visible = false;
                Lbl2.Visible = false;
                Lbl3.Visible = false;
                Lbl4.Visible = true;
                lblLL.Visible = false;
                lblVV.Visible = false;
                lblCC.Visible = false;
                LblEE.Visible = true;
            }
        }

         
        
        
        void button1_Click(object sender, EventArgs e)
            {
                this.Owner.Show();
                this.Close();
            }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Game1_KeyDown(object sender, KeyPressEventArgs e)
        {

        }
         
        public void button2_Click(object sender, EventArgs e)
        {
            string[,] output = { { "String1", "String2" }, { "String3", "String4" } };


            if (output[x, y] == "String1")
            {
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = this.Location;
                f2.Show();
                this.Hide();
            }
            if (output[x, y] == "String2")
            {
                Form3 f2 = new Form3();
                f2.Owner = this;
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = this.Location;
                f2.Show();
                this.Hide();
            }
            if (output[x, y] == "String3")
            {
                Form4 f2 = new Form4();
                f2.Owner = this;
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = this.Location;
                f2.Show();
                this.Hide();
            }
            if (output[x, y] == "String4")
            {
                Form5 f2 = new Form5();
                f2.Owner = this;
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = this.Location;
                f2.Show();
                this.Hide();
            }
        }
        private void Lbl3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl4_Click(object sender, EventArgs e)
        {

        }

        private void Lbl2_Click(object sender, EventArgs e)
        {

        }
    }
    } 
