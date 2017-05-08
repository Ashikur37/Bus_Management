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
    public partial class SearchRoot : MetroFramework.Forms.MetroForm
    {
        string username;
        public SearchRoot(string u)
        {
            InitializeComponent();
            username = u;
            DataBase d = new DataBase();
            d.source(metroComboBox1);
            d.destination(metroComboBox2);
        }

        private void SearchRoot_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            d.similar(metroComboBox1, metroTextBox1.Text.ToString(),"source");
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            d.similar(metroComboBox2, metroTextBox2.Text.ToString(), "destination");
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nn = 0;
            metroTextBox2.Text = "";
            DataBase d = new DataBase();
            if (metroComboBox2.SelectedItem != null)
            {
                nn = d.numbus(metroComboBox1.SelectedItem.ToString(), metroComboBox2.SelectedItem.ToString(), metroComboBox3);
                metroLabel4.Text = nn.ToString();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nn = 0;
            metroTextBox1.Text = "";
            DataBase d = new DataBase();
            if (metroComboBox2.SelectedItem!= null)
            {
                nn = d.numbus(metroComboBox1.SelectedItem.ToString(), metroComboBox2.SelectedItem.ToString(), metroComboBox3);
                metroLabel4.Text = nn.ToString();
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {  
            
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusShow b = new BusShow(username, metroComboBox3.SelectedItem.ToString());
            b.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            u.Show();
            this.Hide();
        }
    }
}
