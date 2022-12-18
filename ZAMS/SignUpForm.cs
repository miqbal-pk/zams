using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.DAL;
using ZAMS.Model;

namespace ZAMS
{
    public partial class SignUpForm : Form
    {
        private string UserName;
        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private string UserPassword;

        public string UserPassword1
        {
            get { return UserPassword; }
            set { UserPassword = value; }
        }

        private string userRole;

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }


        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(string userName , string userpassword , string userRole)
        {
            this.UserName = userName;
            this.UserPassword = userpassword;
            this.userRole = userRole;
            InitializeComponent();
        }



        private void Conform_UserPassword_Label_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_Label_Click(object sender, EventArgs e)
        {

        }

        private void UserPassword_Label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void create_Accoutn_Button_Click(object sender, EventArgs e)
        {


            Login login = new Login();
            login.UserName = UserName_TextBox.Text;

            login.Password = UserPassword_TextBox.Text;
            login.Name = "ABC";
            login.PhoneNumber = PhoneNumber_TextBox.Text;
            login.Address = UserAddress_TextBox.Text;
           // login.AccessSpecifier = UserRole_TextBox.Text;
            login.AccessSpecifier = (string) Role_comboBox.SelectedItem;

            bool userExist = ZAMSFactory.DataBase.FindSignUpName(UserName_TextBox.Text);

            if (userExist == true)
            {

                if (UserName_TextBox.Text == "" || UserPassword_TextBox.Text == "" || Conform_UserPassword_TextBox.Text == "" || PhoneNumber_TextBox.Text == "" )   // ! Role_comboBox.SelectedValue.Equals(null))
                {
                    All_FieldsCondition_Label.Show();
                }
                else
                {

                    if (UserPassword_TextBox.Text != Conform_UserPassword_TextBox.Text)
                    {
                        pass_conpassCodition_label.Show();
                    }
                    else
                    {
                        int result = ZAMSFactory.DataBase.createAccount(login);

                        if (result > 0)
                        {
                            MessageBox.Show(UserName_TextBox.Text + " Account! Created Successfullu...");

                            UserName_TextBox.Text = "";
                            UserPassword_TextBox.Text = "";
                            Conform_UserPassword_TextBox.Text = "";
                            PhoneNumber_TextBox.Text = "";
                            UserAddress_TextBox.Text = "";
                            UserRole_TextBox.Text = "";

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("User With This Name Already Exist!!! PLEASE Change It");
            }
            


        }
 

        private void Back_Button_Click(object sender, EventArgs e)
        {
             ParentForm pf = new ParentForm(UserName , UserPassword , userRole);
             this.Hide();
             pf.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void Role_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
