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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        string username;
        public Form2(string u)
        {
            InitializeComponent();
            username = u;
            DataBase d = new DataBase();
            d.buslist(metroComboBox1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  DataBase d=new DataBase();
        metroLabel6.Text = d.bussource(metroComboBox1.SelectedItem.ToString());
        metroLabel7.Text = d.busdestination(metroComboBox1.SelectedItem.ToString());
       // metroLabel8.Text = d.bushour(metroComboBox1.SelectedItem.ToString()) + ":" + d.busminute(metroComboBox1.SelectedItem.ToString()+" "+d.busampm(metroComboBox1.SelectedItem.ToString());
        metroLabel9.Text = d.busprice(metroComboBox1.SelectedItem.ToString());
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            BuyTicket b = new BuyTicket(username, metroComboBox1.SelectedItem.ToString());
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
