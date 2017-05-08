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
    public partial class User : MetroFramework.Forms.MetroForm
    {
        string username;
        public User(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SearchRoot s = new SearchRoot(username);
            s.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(username);
            f.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(username);
            c.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ShowUpcoming s = new ShowUpcoming(username);
            s.Show();
            this.Hide();

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }
    }
}
