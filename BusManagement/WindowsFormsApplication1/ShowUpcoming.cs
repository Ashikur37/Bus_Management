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
    public partial class ShowUpcoming : MetroFramework.Forms.MetroForm
    {
        string username,m;
        int x;
        public ShowUpcoming(string u)
        {
            InitializeComponent();
            username = u;
            DataBase d = new DataBase();
            x = dateTimePicker2.Value.Date.Day;
            m = d.month(dateTimePicker2.Value.Month);
            d.numb(username, m, x, metroComboBox1);
        }

        private void ShowUpcoming_Load(object sender, EventArgs e)
        {

        }

       

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            x = dateTimePicker2.Value.Date.Day;
            m = d.month(dateTimePicker2.Value.Month);
            d.numb(username, m, x, metroComboBox1);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  DataBase d=new DataBase();
       // d.numb(username, m, x, metroComboBox1);
       string s = d.getnott(username, metroComboBox1.SelectedItem.ToString(), m, x);
        metroLabel8.Text = s;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            u.Show();
            this.Hide();
        }

        private void ShowUpcoming_Load_1(object sender, EventArgs e)
        {

        }

    }
}
