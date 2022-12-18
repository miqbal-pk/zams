using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.DAL;
using ZAMS.Model;

namespace ZAMS.uc
{
    public partial class ViewUsers : BaseControl
    {
        private string title;

        public ViewUsers()
        {
            InitializeComponent();
        }

        //           : base(title, "Bank and PettyCash Reports")
        //{
        //    InitializeComponent();
        //}


        public ViewUsers(string title)
            : base(title, "ViewUsers")
        {
            // TODO: Complete member initialization
            this.title = title;
            InitializeComponent();

            loadUsers();

        }


        public void loadUsers()
        {

            List<Login> usersList = new List<Login>();
            usersList = ZAMSFactory.DataBase.GetUsers();

            Users_gridView.Rows.Clear();
            foreach (Login user in usersList)
            {
                Users_gridView.Rows.Add(user.UserName, user.Password, user.Name, user.PhoneNumber, user.Address, user.AccessSpecifier);
            }


        }




        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_User_button_Click(object sender, EventArgs e)
        {

            bool deleteFlag;
            string delete_user_name = DeleteUser_Name_textBox.Text;
            string delete_user_pass = DeleteUser_Password_textBox.Text;

            if (!delete_user_name.Equals("") && !delete_user_pass.Equals(""))
            {
                 deleteFlag = ZAMSFactory.DataBase.deleteUser(delete_user_name, delete_user_pass);
                 if (deleteFlag)
                 {
                     MessageBox.Show(delete_user_name + " Account Removed SuccessFully");
                 }
                 else
                 {
                     MessageBox.Show("No Such User Exist...");
                 }

            }




        }

        private void Users_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
