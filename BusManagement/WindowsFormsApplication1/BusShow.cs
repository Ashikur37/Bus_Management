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
    public partial class BusShow : MetroFramework.Forms.MetroForm
    {
        string username;
        string busname;
        public BusShow(string u,string b)
        {
            InitializeComponent();
            username = u;
            busname = b;
            metroLabel1.Text = b;
            DataBase d = new DataBase();
            metroLabel2.Text = d.bussource(b);
            metroLabel3.Text = d.busdestination(b);
            metroLabel8.Text = d.bushour(b);
            metroLabel10.Text = d.busminute(b);
            metroLabel11.Text = d.busampm(b);
            metroLabel7.Text = d.busprice(b);
        }

        private void BusShow_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            u.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            BuyTicket b = new BuyTicket(username,busname);
            b.Show();
            this.Hide();


        }
    }
}
