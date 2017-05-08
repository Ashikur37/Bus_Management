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
    public partial class RemoveBus : MetroFramework.Forms.MetroForm
    {
        string username;
        public RemoveBus(string u)
        {
            InitializeComponent();
            username = u;
            DataBase d = new DataBase();
            d.buslist(metroComboBox1);
        }

        private void RemoveBus_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text.ToString().Equals(""))
            {
                MessageBox.Show("Wrong input");

            }
            else
            {

                DataBase d = new DataBase();
                d.removebus(metroComboBox1.SelectedItem.ToString());
                MessageBox.Show(metroComboBox1.SelectedItem.ToString() + " has been removed");
                metroComboBox1.Items.Remove(metroComboBox1.SelectedItem.ToString());

            
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Owner o = new Owner(username);
            o.Show();
            this.Hide();
        }
    }
}
