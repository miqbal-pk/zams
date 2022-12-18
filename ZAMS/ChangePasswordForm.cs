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

namespace ZAMS
{
    public partial class ChangePasswordForm : Form
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string userPassword;

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }



        public ChangePasswordForm(string userName , string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            InitializeComponent();
        }

        private void Change_Password_NewForm_Button_Click(object sender, EventArgs e)
        {

            string newPassword = NewPassword_TextBox.Text;

            if (Current_Password_TextBox.Text == userPassword)
            {
                CurrentPassword_invalid_label.Hide();

                if (NewPassword_TextBox.Text == Conform_New_Password_TextBox.Text && NewPassword_TextBox.Text != "")
                {
                    pass_and_confPass_Label_Condition.Hide();

                    int status = ZAMSFactory.DataBase.ChangePassword(this.userName, this.userPassword, newPassword);

                    if (status > 0)
                    {
                        MessageBox.Show(userName + " ! Password Change Successfully...");

                        Current_Password_TextBox.Text = "";
                        NewPassword_TextBox.Text = "";
                        Conform_New_Password_TextBox.Text = "";

                    }
                    else
                    {
                        MessageBox.Show(userName + " ! Password Not Change");
                    }
                }
                else
                {
                    pass_and_confPass_Label_Condition.Show();
                }


            }
            else 
            {
                CurrentPassword_invalid_label.Show();
            }

        }
    }
}
