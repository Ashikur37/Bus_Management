using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DataBase
    {
        public int checkusername(string name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "select* from user_info where Username='"+name+"'";
            

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {

                x++;
              

            }

            return x;
        
        }
        public int signincheck(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "select* from user_info where Username='" + username + "' and Password='"+password+"'";


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {

                x++;


            }

            return x;
        
        
        
        }
        public void register(string username, string password, string email)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "insert into  user_info (UserName,Password,Email,Status) values ('" + username + "','" + password + "','" + email + "',0)";
            if (checkusername(username) == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Signup successfull");

            }
            else
                MessageBox.Show("Username already exist");
        
        
        }
        public void uau(MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            
            con.Open();

            string query = "select* from user_info where status=0";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {




                b1.Items.Add(dr["UserName"].ToString());

            }
        }
        public void au(MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from user_info ";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {




                b1.Items.Add(dr["UserName"].ToString());

            }
        }
        public void aprove(string name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "update user_info set status ='1' where UserName = ('" + name + "') ";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
           
        }
        public void removeuser(string name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "delete from user_info where UserName = ('" + name+ "')";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        
        
        }
        public void changepass(string username,string password)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "update user_info set Password ='"+password+"' where UserName = ('" +username+ "') ";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }
        public void addbus(string busname, string source, string destination,int hour,int minute,string ampm,int price)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "insert into  bus_info (Busname,source,destination,hour,minute,ampm,price) values ('" + busname + "','" + source+ "','" +destination + "','"+hour+"','"+minute+"','"+ampm+"','"+price+"')";
           
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                


        }
        public void buslist(MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from bus_info ";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {




                b1.Items.Add(dr["busname"].ToString());

            }
        }
        public void removebus(string name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "delete from bus_info where busname = ('" + name + "')";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


        }
        public string getprice(string name)
        {
            string xx;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from bus_info where busname='"+name+"'";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            xx = "";

            while (dr.Read())
            {




                xx=dr["price"].ToString();

            }
            return xx;
        
        }
        public void updateprice(int price,string busname)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "update bus_info set price ='" + price + "' where BusName = ('" + busname + "') ";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Price updated to " + price);        
        
        
        }
        public void source(MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from bus_info ";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {




                b1.Items.Add(dr["Source"].ToString());

            }
        }
        public void destination(MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from bus_info ";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {




                b1.Items.Add(dr["Destination"].ToString());

            }
        }
        public int usertype(string name)
        {
            string xx;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from user_info where username='" + name + "'";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            xx = "";

            while (dr.Read())
            {




                xx = dr["status"].ToString();

            }
            return Convert.ToInt32(xx);

        }
        public void similar(MetroFramework.Controls.MetroComboBox b1,string a,string s)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from bus_info where "+s+" like ('%" + a + "%')";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            b1.Items.Clear();

            while (dr.Read())
            {
                


                b1.SelectedItem = dr[s].ToString();
                b1.Items.Add(dr[s].ToString());

            }
        }
        public int numbus(string s, string d, MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            int nn = 0;
            con.Open();
            string query;
           
            
            {
                 query = "select* from bus_info where source='" + s + "' and destination='"+d+"'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";
            b1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
          

            while (dr.Read())
            {

                b1.Items.Add(dr["busname"].ToString());

                nn++;

            }
            return nn;
        }
        public string bussource(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s="";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='"+b+"'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

             s= dr["source"].ToString();

                

            }
            return s;
        }
        public string busdestination(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='" + b + "'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["destination"].ToString();



            }
            return s;
        }
        public string busprice(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='" + b + "'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["price"].ToString();



            }
            return s;
        }
        public string bushour(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='" + b + "'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["hour"].ToString();



            }
            return s;
        }
        public string busminute(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='" + b + "'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["minute"].ToString();



            }
            return s;
        }
        public string busampm(string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from bus_info where busname='" + b + "'";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["ampm"].ToString();



            }
            return s;
        }
        public int busdatecheck(string busname, int date, string month)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "select* from ticket_info where busname='" + busname + "' and date ="+date+" and month='"+month+"'";


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {

                x++;


            }

            return x;
        
        }
        public void insertbusdate(string busname, int date, string month)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = "insert into  ticket_info (busname,date,month) values ('" + busname + "','" + date + "','" + month + "')";
            
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                
        
        
        }
        public string month(int x)
        {
            if (x == 1)
                return "January";
            else if (x == 2)
                return "February";
            else if (x == 3)
                return "March";
            else if (x == 4)
                return "April";
            else if (x == 5)
                return "May";
            else if (x == 6)
                return "June";
            else if (x == 7)
                return "July";
            else if (x == 8)
                return "August";
            else if (x == 9)
                return "September";
            else if (x == 10)
                return "October";
            else if (x == 11)
                return "November";
            else
                return "December";
        

        
        
        
        }
        public int buttonvalue(string busname, string month, int date, string sn)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from ticket_info where busname='" + busname + "' and month='"+month+"'and date="+date+"";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr[sn].ToString();



            }
            if (s.Equals("0"))
                return 0;
            else
                return 1;
        
        
        }
        public void updateseat(string busname, string month, int date, string sn,string user)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "update ticket_info set "+sn+"='"+user+"' where busname='"+busname+"' and date="+date+" and month='"+month+"' ";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        
        
        
        }
        public void insertschedule(string username, string busname, int date, string month,int nott)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string queryy = "select*  from schedule_info where username='"+username+"' and busname='"+busname+"' and date="+date+" and month='"+month+"'";

           int x = checkschedule(queryy);
            if (x == 0)
            {

                string query = "insert into  schedule_info (UserName,busname,date,month,nott) values ('" + username + "','" + busname + "'," + date + ",'"+month+"',"+nott+")";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
           else

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = queryy;
                cmd.ExecuteNonQuery();
                int xx = checkseatn(queryy);
                xx += nott;
                string querry =  "update schedule_info set nott =" + xx + " where username='"+username+"' and BusName = '" + busname + "' and month='"+month+"' and date="+date+" ";
                /*
                SqlCommand cmmd = con.CreateCommand();
                cmmd.CommandType = CommandType.Text;
                cmmd.CommandText = querry;
                cmmd.ExecuteNonQuery();*/
            
            
            }
        
        
        
        
        }
        public void addbusdate(int date, string month, MetroFramework.Controls.MetroComboBox b1)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            string query = "select* from sell_info where month='"+month+"' and date="+date+"";
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            b1.Items.Clear();

            while (dr.Read())
            {



                
                b1.Items.Add(dr["busname"].ToString());

            }
        
        
        }
        public string getsold(string busname, string month, int date)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            string query;


            {
                query = "select* from sell_info where busname='" + busname + "' and month='"+month+"' and date="+date+"";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["total"].ToString();



            }
            return s;
        
        
        
        }
        public int checkseatn(string query)
        { 
        
         
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();
            


            
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["nott"].ToString();



            }
            return Convert.ToInt32(s);
        
        
        
        }
        public int checkschedule(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {

                x++;


            }

            return x;
        
        
        
        }
        public int checksell(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {

                x++;


            }

            return x;



        }
        public void numb(string username, string month,int date, MetroFramework.Controls.MetroComboBox b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            
            con.Open();
            b1.Items.Clear();

            string query;


            {
                query = "select* from schedule_info where username='" +username + "' and month= '"+month+"' and date="+date+"";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                b1.Items.Add(dr["busname"].ToString());

                

            }
           
        }
        public int checksellt(string query)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "";
            con.Open();




            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                s = dr["total"].ToString();



            }
            return Convert.ToInt32(s);
        
        
        
        
        
        }
        public void datesell(string busname,int date,string month,int sell)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string queryy = "select*  from sell_info where busname='" + busname + "' and month='" + month + "' and date=" + date + "";

            int x = checksell(queryy);
            if (x == 0)
            {

                string query = "insert into  sell_info (busname,month,date,total) values ('" + busname + "','" + month + "'," + date + ","+sell+")";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = queryy;
                cmd.ExecuteNonQuery();
                int xx = checksellt(queryy);
                xx += sell;
                string querry = "update sell_info set  total=" + xx + " where busname='" + busname + "' and month = ('" + month+ "') and  and date=" + date + " ";

                SqlCommand cmdd = con.CreateCommand();
                cmdd.CommandType = CommandType.Text;
                cmdd.CommandText = querry;
                cmdd.ExecuteNonQuery();


            }
        
        
        
        
        }
        public string getnott(string username, string busname, string month, int date)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Piash\Documents\busmanagement.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string query;
            string s="";

            {
                query = "select* from schedule_info where username='" + username + "'and busname='"+busname+"' and month='" + month + "' and date=" + date + "";
            }
            //string query = "insert into  user_info (username,password,status) values ('abb','qwerd',5)";
          
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

               s= dr["nott"].ToString();



            }

            return s;
        
        }
    }
}
