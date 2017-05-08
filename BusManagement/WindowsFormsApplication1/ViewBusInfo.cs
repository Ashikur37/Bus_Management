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
    public partial class ViewBusInfo : MetroFramework.Forms.MetroForm
    {
        string username;
        public ViewBusInfo(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void ViewBusInfo_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Owner o = new Owner(username);
            o.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Sellinfo s = new Sellinfo(username);
            s.Show();
            this.Hide();
        }
    }
}
