using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.DAL;

namespace ZAMS
{
    public partial class Login_Form : Form
    {
        //////////////////////////////////////////////////////////////
       //////////        Member Variables            ////////////////
      //////////////////////////////////////////////////////////////
        private string user_name;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }

        private string user_password;

        public string User_password
        {
            get { return user_password; }
            set { user_password = value; }
        }

        private string user_role;

        public string User_role
        {
            get { return user_role; }
            set { user_role = value; }
        }


        public Login_Form()
        {
            InitializeComponent();
            Password_textBox.Select();
            Name_textBox.Select();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            User_name = Name_textBox.Text;    
            User_password = Password_textBox.Text;
            User_role = null;
                   
            if (user_name != "" && user_password != "")
            {
                //if (login(Login_name, login_password))
                //{
                //    ParentForm pf = new ParentForm(login_name);
                //    this.Hide();
                //    pf.Show();
                //}

                var list = ZAMSFactory.DataBase.GetLogin(user_name, user_password);
                if(list.Count>0)
                {
                    User_role = list[0].AccessSpecifier;
                     
                    if (list[0].Password == user_password && list[0].UserName == user_name)
                    {
                        ParentForm pf = new ParentForm(user_name, user_password , User_role);
                        this.Hide();
                        pf.Show();
                    }
                    else
                    {
                        Worning.Text = "wrong credential";
                        Worning.Show();
                        Name_textBox.Text = "";
                        Password_textBox.Text = "";
                    }
                
                }
                else
                {
                    Worning.Text = "wrong credential";
                    Worning.Show();
                    Name_textBox.Text = "";
                    Password_textBox.Text = "";
                }
            }
            else 
            {

                Worning.Show();
                 Name_textBox.Text = "";
                 Password_textBox.Text = "";
            }
            
        }



        bool login(string uname, string password)
        {
            string connectionString =
            "Data Source=HAIER-PC\\SECOND;Initial Catalog=Zams; User id=sa; Password=123;Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =String.Format(
                "SELECT * from Login where UserName = '{0}' and Password = '{1}'",uname,password);

            // Specify the parameter value.


            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);


                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception e)
                {
                   Console.Write( e.StackTrace);
                    return false;
                }
            }
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
