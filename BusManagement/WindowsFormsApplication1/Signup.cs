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
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
          



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
        public int checktext(MetroFramework.Controls.MetroTextBox t)
        { 
            if (t.Text.Equals(""))
                return 0;
            else
                return 1;
        }
      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (checktext(metroTextBox1) == 1 && checktext(metroTextBox2) == 1 && checktext(metroTextBox3) == 1 && checktext(metroTextBox4) == 1 && checktext(metroTextBox5) == 1 && checktext(metroTextBox6) == 1)
            {
                if (metroTextBox5.Text.Equals(metroTextBox6.Text))
                {
                    if (metroCheckBox1.Checked == true)
                    {
                        if (metroRadioButton1.Checked == false && metroRadioButton1.Checked == false)
                        {
                            MessageBox.Show("Select Gender");
                        }
                        else
                        {
                            DataBase d = new DataBase();
                            d.register(metroTextBox3.Text, metroTextBox5.Text, metroTextBox4.Text);

                        }
                    }
                    else
                        MessageBox.Show("You must agree with our terms and conditions");
                }
                else
                {
                    MessageBox.Show("Password doesnt match");

                }

            }
            else
                MessageBox.Show("Wrong Input");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
