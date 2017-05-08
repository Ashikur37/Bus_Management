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
    public partial class AddBus : MetroFramework.Forms.MetroForm
    {
        string username;
        public AddBus(string u)
        {
            InitializeComponent();
            username = u;
            metroComboBox1.Items.Add("Hour");
            metroComboBox1.SelectedItem = "Hour";

            metroComboBox2.Items.Add("Minute");
            metroComboBox2.SelectedItem = "Minute";
            metroComboBox3.Items.Add("AM");
            metroComboBox3.Items.Add("PM");
            metroComboBox3.SelectedItem = "AM";
            for (int i = 0; i <= 60; i++)
            {  if(i<=12&&i>0)
                metroComboBox1.Items.Add(Convert.ToString(i));

                metroComboBox2.Items.Add(Convert.ToString(i));
            
            }

        }

        private void AddBus_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
       

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            if (s.checktext(metroTextBox1) == 1 && s.checktext(metroTextBox2) == 1 && s.checktext(metroTextBox3) == 1 && s.checktext(metroTextBox4) == 1)
            {
                if (metroComboBox1.SelectedItem.ToString().Equals("Hour") ||metroComboBox1.Text.ToString().Equals("Hour")||metroComboBox2.Text.ToString().Equals("Minute")|| metroComboBox1.SelectedItem.ToString().Equals("Minute"))
                {
                    MessageBox.Show("Wrong Input");
                }
                else
                {
                    DataBase d = new DataBase();
                    d.addbus(metroTextBox1.Text.ToString(), metroTextBox2.Text.ToString(), metroTextBox3.Text.ToString(), Convert.ToInt32(metroComboBox1.SelectedItem.ToString()), Convert.ToInt32(metroComboBox2.SelectedItem.ToString()), metroComboBox3.SelectedItem.ToString(),Convert.ToInt32(metroTextBox4.Text.ToString()));

                    MessageBox.Show(metroTextBox1.Text.ToString() + " has been added");
                
                }

            }
            else
                MessageBox.Show("Wrong input");
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Owner o = new Owner(username);
            this.Hide();
            o.Show();
        }
    }
}
