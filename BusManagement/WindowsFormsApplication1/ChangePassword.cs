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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        string username;
        public ChangePassword(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
           int x= d.signincheck(username, metroTextBox1.Text.ToString());
           if (x == 0)
           {
               MessageBox.Show("Wrong Old password");

           }
           else
           {
               d.changepass(username, metroTextBox2.Text.ToString());
           
           
           }

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            int ax = d.usertype(username);
             if (ax == 1)
            {

                User u = new User(username);
                u.Show();
                this.Hide();
            }
            else if (ax == 2)
            {
                Admin a = new Admin(username);
                a.Show();
                this.Hide();
            }
            else if (ax == 3)
            {
                Owner o = new Owner(username);
                o.Show();
                this.Hide();

            }
        }
    }
}
