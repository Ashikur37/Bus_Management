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
    public partial class AproveUser : MetroFramework.Forms.MetroForm
    {
        string username;
        public AproveUser(string u)
        {
            InitializeComponent();
            DataBase d = new DataBase();
            d.uau(metroComboBox1);
            username = u;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

      

        private void AproveUser_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            d.aprove(metroComboBox1.SelectedItem.ToString());



            MessageBox.Show(metroComboBox1.SelectedItem.ToString() + " is aproved");
            metroComboBox1.Items.Remove(metroComboBox1.SelectedItem.ToString());
            metroComboBox1.SelectedItem = "";
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
    }
}
