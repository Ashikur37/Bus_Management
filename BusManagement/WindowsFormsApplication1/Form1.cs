using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            int x = d.signincheck(metroTextBox1.Text, metroTextBox2.Text);
            if (x == 0)
                MessageBox.Show("Invalid login");
            else
            {
                int ax = d.usertype(metroTextBox1.Text.ToString());
                if (ax == 0)
                {
                    MessageBox.Show("Sorry you are still unaproved");
                }
                else if (ax == 1)
                {

                    User u = new User(metroTextBox1.Text.ToString());
                    u.Show();
                    this.Hide();
                }
                else if (ax == 2)
                {
                    Admin a = new Admin(metroTextBox1.Text.ToString());
                    a.Show();
                    this.Hide();
                }
                else if (ax == 3)
                {
                    Owner o = new Owner(metroTextBox1.Text.ToString());
                    o.Show();
                    this.Hide();
                
                }
               
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
