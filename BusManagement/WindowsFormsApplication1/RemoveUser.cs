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
    public partial class RemoveUser : MetroFramework.Forms.MetroForm
    {
        string username;
        public RemoveUser(string u)
        {
            InitializeComponent();
            DataBase d = new DataBase();
            d.au(metroComboBox1);
            username = u;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

      
        private void RemoveUser_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(username);
            a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            d.removeuser(metroComboBox1.SelectedItem.ToString());
            MessageBox.Show(metroComboBox1.SelectedItem.ToString() + " is removed");
            metroComboBox1.Items.Remove(metroComboBox1.SelectedItem.ToString());
        }
    }
}
