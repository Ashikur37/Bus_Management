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
    public partial class UpdatePrice : MetroFramework.Forms.MetroForm
    {
        string username;
        public UpdatePrice(string u)
        {
            InitializeComponent();
            username = u;
            DataBase d = new DataBase();
            d.buslist(metroComboBox1);
        }

        private void UpdatePrice_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            string a = d.getprice(metroComboBox1.SelectedItem.ToString());
            metroLabel3.Text = a;

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            d.updateprice(Convert.ToInt32(metroTextBox1.Text.ToString()),metroComboBox1.SelectedItem.ToString());
            string a = d.getprice(metroComboBox1.SelectedItem.ToString());
            metroLabel3.Text = a;
            metroTextBox1.Text = "";


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Owner o = new Owner(username);
            o.Show();
            this.Hide();
        }
    }
}
