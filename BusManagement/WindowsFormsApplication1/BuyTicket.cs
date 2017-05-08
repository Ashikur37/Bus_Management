using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Controls;

namespace WindowsFormsApplication1
{
    public partial class BuyTicket : MetroFramework.Forms.MetroForm
    {
        string username,m;
        string busname;
        int price;
        int sel=0;
        int total=0;
        int a1, a2, a3, a4, a5, b1, b2, b3, b4, b5, c1, c2, c3, c4, c5, d1, d2, d3, d4, d5,x;
        int a11=0, a22=0, a33=0, a44=0, a55=0, b11=0, b22=0, b33=0, b44=0, b55=0, c11=0, c22=0, c33=0, c44=0, c55=0, d11=0, d22=0, d33=0, d44=0, d55=0;
        public BuyTicket(string u,string b)
        {
            
            InitializeComponent();
            username=u;
            busname = b;
            DataBase d = new DataBase();
             x = dateTimePicker1.Value.Date.Day;
            m = d.month(dateTimePicker1.Value.Month);
          
            
            int ch=d.busdatecheck(busname, x, m);
            if (ch == 0)
            {
                d.insertbusdate(busname, x, m);
            }
            price = Convert.ToInt32(d.busprice(busname));
            buttonvalue();
            buttoncolor();
        }
        public void buttonvalue()
        { 
            DataBase d=new DataBase();
        a1=d.buttonvalue(busname,m,x,"a1");
        a2=d.buttonvalue(busname,m,x,"a2");
        a3=d.buttonvalue(busname,m,x,"a3");
        a4=d.buttonvalue(busname,m,x,"a4");
        a5 = d.buttonvalue(busname, m, x, "a5");
        b1 = d.buttonvalue(busname, m, x, "b1");
        b2 = d.buttonvalue(busname, m, x, "b2");
        b3 = d.buttonvalue(busname, m, x, "b3");
        b4 = d.buttonvalue(busname, m, x, "b4");
        b5 = d.buttonvalue(busname, m, x, "b5");
        c1 = d.buttonvalue(busname, m, x, "c1");
        c2 = d.buttonvalue(busname, m, x, "c2");
        c3 = d.buttonvalue(busname, m, x, "c3");
        c4 = d.buttonvalue(busname, m, x, "c4");
        c5 = d.buttonvalue(busname, m, x, "c5");
        d1 = d.buttonvalue(busname, m, x, "d1");
        d2 = d.buttonvalue(busname, m, x, "d2");
        d3 = d.buttonvalue(busname, m, x, "d3");
        d4 = d.buttonvalue(busname, m, x, "d4");
        d5 = d.buttonvalue(busname, m, x, "d5");
        
        
        }
        public void buttoncolor()
        {

            if (a1 == 0)
                button1.BackColor = Color.Green;
            else
                button1.BackColor = Color.Red;
            if (a2 == 0)
                button2.BackColor = Color.Green;
            else
                button2.BackColor = Color.Red;
            if (a3 == 0)
                button3.BackColor = Color.Green;
            else
                button3.BackColor = Color.Red;
            if (a4 == 0)
                button4.BackColor = Color.Green;
            else
                button4.BackColor = Color.Red;
            if (a5 == 0)
                button5.BackColor = Color.Green;
            else
                button5.BackColor = Color.Red;
            if (b1 == 0)
                button10.BackColor = Color.Green;
            else
                button10.BackColor = Color.Red;
            if (b2 == 0)
                button9.BackColor = Color.Green;
            else
                button9.BackColor = Color.Red;
            if (b3 == 0)
                button8.BackColor = Color.Green;
            else
                button8.BackColor = Color.Red;
            if (b4 == 0)
                button7.BackColor = Color.Green;
            else
                button7.BackColor = Color.Red;
            if (b5 == 0)
                button6.BackColor = Color.Green;
            else
                button6.BackColor = Color.Red;
            if (c1 == 0)
                button15.BackColor = Color.Green;
            else
                button15.BackColor = Color.Red;
            if (c2 == 0)
                button14.BackColor = Color.Green;
            else
                button14.BackColor = Color.Red;
            if (c3 == 0)
                button13.BackColor = Color.Green;
            else
                button13.BackColor = Color.Red;
            if (c4 == 0)
                button12.BackColor = Color.Green;
            else
                button12.BackColor = Color.Red;
            if (c5 == 0)
                button11.BackColor = Color.Green;
            else
                button11.BackColor = Color.Red;
            if (d1 == 0)
                button20.BackColor = Color.Green;
            else
                button20.BackColor = Color.Red;
            if (d2 == 0)
                button19.BackColor = Color.Green;
            else
                button19.BackColor = Color.Red;
            if (d3 == 0)
                button18.BackColor = Color.Green;
            else
                button18.BackColor = Color.Red;
            if (d4 == 0)
                button17.BackColor = Color.Green;
            else
                button17.BackColor = Color.Red;
            if (d5 == 0)
                button16.BackColor = Color.Green;
            else
                button16.BackColor = Color.Red;
        
        }
        private void BuyTicket_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            DataBase d = new DataBase();
            x = dateTimePicker1.Value.Date.Day;
            m = d.month(dateTimePicker1.Value.Month);
            int ch = d.busdatecheck(busname, x, m);
            if (ch == 0)
            {
                d.insertbusdate(busname, x, m);
            }
            buttonvalue();
            buttoncolor();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a1 == 0 && a11 == 0)
            {

                button1.BackColor = Color.Blue;
                a11 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (a1 == 0 && a11 == 1)
            {

                button1.BackColor = Color.Green;
                a11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (a2 == 0 && a22 == 0)
            {

                button2.BackColor = Color.Blue;
                a22 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (a2 == 0 && a22 == 1)
            {

                button2.BackColor = Color.Green;
                a22 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (a3 == 0 && a33 == 0)
            {

                button3.BackColor = Color.Blue;
                a33 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (a3 == 0 && a33 == 1)
            {

                button3.BackColor = Color.Green;
                a33 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (a4 == 0 && a44 == 0)
            {

                button4.BackColor = Color.Blue;
                a44 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (a4 == 0 && a44 == 1)
            {

                button4.BackColor = Color.Green;
                a11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (a5 == 0 && a55 == 0)
            {

                button5.BackColor = Color.Blue;
                a55 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (a5 == 0 && a55 == 1)
            {

                button5.BackColor = Color.Green;
                a11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (b5 == 0 && b55 == 0)
            {

                button6.BackColor = Color.Blue;
                b55 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (b5 == 0 && b55 == 1)
            {

                button6.BackColor = Color.Green;
                b55 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (b4 == 0 && b44 == 0)
            {

                button7.BackColor = Color.Blue;
                b44 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (b4 == 0 && b44 == 1)
            {

                button7.BackColor = Color.Green;
                b44 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b3 == 0 && b33 == 0)
            {

                button8.BackColor = Color.Blue;
                b33 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (b3 == 0 && b33 == 1)
            {

                button8.BackColor = Color.Green;
                b33 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
            {
                MessageBox.Show("This seat is not available");

            
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (b2 == 0 && b22 == 0)
            {

                button9.BackColor = Color.Blue;
                b22 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (b2 == 0 && b22 == 1)
            {

                button9.BackColor = Color.Green;
                b22 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (b1 == 0 && b11 == 0)
            {

                button10.BackColor = Color.Blue;
                b11 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (b1 == 0 && b11 == 1)
            {

                button10.BackColor = Color.Green;
                b11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (c5 == 0 && c55 == 0)
            {

                button11.BackColor = Color.Blue;
                c55 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (c5 == 0 && c55 == 1)
            {

                button11.BackColor = Color.Green;
                c55 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (c4 == 0 && c44 == 0)
            {

                button12.BackColor = Color.Blue;
                c44 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (c4 == 0 && c44 == 1)
            {

                button12.BackColor = Color.Green;
                c44 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (c3 == 0 && c33 == 0)
            {

                button13.BackColor = Color.Blue;
                c33 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (c3 == 0 && c33 == 1)
            {

                button13.BackColor = Color.Green;
                c33 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (c2 == 0 && c22 == 0)
            {

                button14.BackColor = Color.Blue;
                c22 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (c2 == 0 && c22 == 1)
            {

                button14.BackColor = Color.Green;
                c22 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (c1 == 0 && c11 == 0)
            {

                button15.BackColor = Color.Blue;
                c11 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (c1 == 0 && c11 == 1)
            {

                button15.BackColor = Color.Green;
                c11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (d5 == 0 && d55 == 0)
            {

                button16.BackColor = Color.Blue;
                d55 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (d5 == 0 && d55 == 1)
            {

                button16.BackColor = Color.Green;
                d55 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (d4 == 0 && d44 == 0)
            {

                button17.BackColor = Color.Blue;
                d44 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (d4 == 0 && d44 == 1)
            {

                button17.BackColor = Color.Green;
                d44 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (d3 == 0 && d33 == 0)
            {

                button18.BackColor = Color.Blue;
                d33 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (d3 == 0 && d33 == 1)
            {

                button18.BackColor = Color.Green;
                d33 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (d2 == 0 && d22 == 0)
            {

                button19.BackColor = Color.Blue;
                d22 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (d2 == 0 && d22 == 1)
            {

                button19.BackColor = Color.Green;
                d22 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (d1 == 0 && d11 == 0)
            {

                button20.BackColor = Color.Blue;
                d11 = 1;
                sel++;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else if (d1 == 0 && d11 == 1)
            {

                button20.BackColor = Color.Green;
                d11 = 0;
                sel--;
                total = price * sel;
                metroLabel4.Text = total.ToString();
                metroLabel5.Text = sel.ToString();
            }
            else
                MessageBox.Show("This seat is not available");
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            if( a11 == 1)
            {
                d.updateseat(busname, m, x, "a1", username);
            }
            if (a22 == 1)
            {
                d.updateseat(busname, m, x, "a2", username);
            }
            if (a33 == 1)
            {
                d.updateseat(busname, m, x, "a3", username);
            }
            if (a44 == 1)
            {
                d.updateseat(busname, m, x, "a4", username);
            }
            if (a55 == 1)
            {
                d.updateseat(busname, m, x, "a5", username);
            }
            if (b11 == 1)
            {
                d.updateseat(busname, m, x, "b1", username);
            }
            if (b22 == 1)
            {
                d.updateseat(busname, m, x, "b2", username);
            }
            if (b33 == 1)
            {
                d.updateseat(busname, m, x, "b3", username);
            }
            if (b44 == 1)
            {
                d.updateseat(busname, m, x, "b4", username);
            }
            if (b55 == 1)
            {
                d.updateseat(busname, m, x, "b5", username);
            }
            if (c11 == 1)
            {
                d.updateseat(busname, m, x, "c1", username);
            }
            if (c22 == 1)
            {
                d.updateseat(busname, m, x, "c2", username);
            }
            if (c33 == 1)
            {
                d.updateseat(busname, m, x, "c3", username);
            }
            if (c44 == 1)
            {
                d.updateseat(busname, m, x, "c4", username);
            }
            if (c55 == 1)
            {
                d.updateseat(busname, m, x, "c5", username);
            }
            if (d11 == 1)
            {
                d.updateseat(busname, m, x, "d1", username);
            }
            if (d22 == 1)
            {
                d.updateseat(busname, m, x, "d2", username);
            }
            if (d33 == 1)
            {
                d.updateseat(busname, m, x, "d3", username);
            }
            if (d44 == 1)
            {
                d.updateseat(busname, m, x, "d4", username);
            }
            if (d55 == 1)
            {
                d.updateseat(busname, m, x, "d5", username);
            }
           //d.insertschedule(username, busname, x, m, sel);
           d.datesell(busname, x, m, price);
            confirmticket c = new confirmticket(username, m, total, sel, x, busname);
            c.Show();
            this.Hide();
        }

      
    }
}
