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
    public partial class confirmticket : MetroFramework.Forms.MetroForm
    {
        string username;
        string busname;
        string m;
        int price;
        int not;
        int da;
        string h;
        string mi;
        string am;
        public confirmticket(string u,string mm,int p,int n,int dd,string bn)
        {
            InitializeComponent();
            username = u;
            m = mm;
            price = p;
            not = n;
            da = dd;
            busname=bn;
            DataBase d = new DataBase();
            h = d.bushour(busname);
            mi = d.busminute(busname);
            am = d.busampm(busname);
            metroLabel2.Text = busname;
            metroLabel7.Text = username;
            metroLabel8.Text = da + " " + m;
            metroLabel9.Text = h + ":" + mi + " " + am;
            metroLabel10.Text =not.ToString();
            metroLabel11.Text = price.ToString();




        }

        private void confirmticket_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            u.Show();
            this.Hide();

        }
    }
}
