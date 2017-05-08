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
    public partial class Sellinfo : MetroFramework.Forms.MetroForm
    {
        int x;
        string m;
        string username;
        public Sellinfo(string u)
        {
            username = u;
            InitializeComponent();
            DataBase d = new DataBase();
            x = dateTimePicker1.Value.Date.Day;
            m = d.month(dateTimePicker1.Value.Month);
            d.addbusdate(x, m,metroComboBox1);

        }

        private void Sellinfo_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Owner o = new Owner(username);
            o.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            x = dateTimePicker1.Value.Date.Day;
            m = d.month(dateTimePicker1.Value.Month);
            d.addbusdate(x, m, metroComboBox1);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            string s = d.getsold(metroComboBox1.SelectedItem.ToString(), m, x);
            metroLabel4.Text = s;
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
