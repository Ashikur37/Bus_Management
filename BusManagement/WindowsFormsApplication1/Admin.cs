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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        string username;
        public Admin(string u)
        {
            InitializeComponent();
            username = u;
        }

       
        
       

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AproveUser a = new AproveUser(username);
            a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            RemoveUser r = new RemoveUser(username);
            r.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(username);
            c.Show();
            this.Hide();
        }
    }
}
