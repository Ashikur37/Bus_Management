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
    public partial class Owner : MetroFramework.Forms.MetroForm
    {
        string username;
          
        public Owner(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            UpdatePrice u = new UpdatePrice("admin");
            u.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddBus a = new AddBus("admin");
            a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RemoveBus r = new RemoveBus("admin");
            r.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(username);
            c.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ViewBusInfo v = new ViewBusInfo(username);
            v.Show();
            this.Hide();
        }
    }
}
