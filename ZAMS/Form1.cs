using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.uc;

namespace ZAMS
{
    public partial class ParentForm : Form
    {
        public static bool isAdmin;
        public static string LoadedUCName = string.Empty;
        public static List<UserControl> Screens;
        BaseControl bc;
        public string admin_name;
        public string user_password;
        public string user_role;
        

        public ParentForm(string aName , string userPassword , string userRole)
        {
            
            Screens = new List<UserControl>();
            setAdminName(aName);
            setUserPassword(userPassword);
            setUserRole(userRole);

            //Projects p = new Projects(aName , 1);
            if(getUserRole().ToUpper() == "ADMIN")
            {
                isAdmin = true;
            }
            else
            {
                isAdmin =false;
            }

            
            initializeForms();

            ///////////////////////////////////////////////////////////getAdminName().ToUpper() != "ADMIN"

            InitializeComponent();

            if (!isAdmin)
            {
                SignUp_Button.Hide();
                View_User.Hide();
               
            }

        }
        public ParentForm()
        {

            //Screens = new List<UserControl>();
            //initializeForms();

            //setAdminName(aName);
            InitializeComponent();

        }
        ////////////////////////////////////////////////////////////////////
        //////                      JUST PRACTICE                     //////
        ////////////////////////////////////////////////////////////////////

        public void setAdminName(string aName)
        {
            admin_name = aName;
        }

        public string getAdminName()
        {
            return admin_name;
        }

        public void setUserPassword(string userPassword)
        {
            this.user_password = userPassword;
        }

        public string getUserPassword()
        {
            return this.user_password;
        }

        public void setUserRole(string userRole)
        {
            this.user_role = userRole;
        }
        public string getUserRole()
        {
            return this.user_role;
        }


        #region Registry and Loader
        public void initializeForms()
        {
            Screens.Add(new Companies(Program.UCTitle_Company));
            Screens.Add(new Dealer(Program.UCTitle_Dealer));
            Screens.Add(new Projects(Program.UCTitle_Project, getAdminName() , getUserRole()));  // *** //
            Screens.Add(new ReportHome(Program.UCTitle_Reports));
            Screens.Add(new SearchTransactions(Program.UCTitle_SearchTransactions));
            Screens.Add(new NewCompany(Program.UCTitle_NewCompany));
            Screens.Add(new NewProject(Program.UCTitle_NewProject));
            Screens.Add(new NewDealer(Program.UCTitle_NewDealer));
            Screens.Add(new Banks(Program.UCTitle_Bank));
            Screens.Add(new Bank_an_PettyCash_Reports(Program.UCTitle_otherReports , getAdminName() , getUserRole()));
            Screens.Add(new ViewUsers(Program.UCTitle_ViewUsers));

            

            
        }

        /// <summary>
        /// Deloads the Already Loaded User Control and Loads a new one from the list.
        /// </summary>
        /// <param name="Name"></param>
        public void LoadUserControl(string Name)
        {
            bc = (BaseControl)Screens.Where(p => p.Name.Equals(Name)).FirstOrDefault();
            if (ContentPanel.Controls.Contains(bc))
            {
                //Do Nothing, Just Bring to Front
            }
            else
            {
                this.ContentPanel.Controls.Add(bc);


            } 
            bc.BringToFront();

            this.ContentPanel.Update();

           
        }

        #endregion

        #region Main Link Controls
        private void link_Companies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Companies");
           // new Companies().Companies_Load(new object(), new EventArgs());
        }

        private void link_Dealers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Dealer");
        }

        private void link_Projects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Projects pr = new Projects();
            //pr.checkBox_reverse.Hide();
            //checkBox1_reverse.Hide();

            LoadUserControl("Projects");
             
            
        }

        private void link_Reports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("ReportHome");
        }

        private void link_SearchTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("SearchTransactions");
        }

        #endregion

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkBank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Banks");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Bank_an_PettyCash_Reports");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
            protected override void OnFormClosing(FormClosingEventArgs e)
                 {
                     base.OnFormClosing(e);

                     if (e.CloseReason == CloseReason.WindowsShutDown) return;

                // Confirm user wants to close
                     switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
                       {
                         case DialogResult.No:
                         e.Cancel = true;

                         break;
                        
                         default:
                          
                             break;
                }        
               }

            private void ParentForm_Load(object sender, EventArgs e)
            {

            }

            private void SignOut_Click(object sender, EventArgs e)
            {
                this.Hide();
                Login_Form lg = new Login_Form();
                lg.Show();

            }

            private void SignUp_Button_Click(object sender, EventArgs e)
            {
                this.Hide();
                SignUpForm sign_up_form = new SignUpForm(getAdminName() , getUserPassword() , getUserRole());
                sign_up_form.Show();
            }

            private void Change_Password_Button_Click(object sender, EventArgs e)
            {
               
                ChangePasswordForm changePasswordForm = new ChangePasswordForm(getAdminName() , getUserPassword());
                changePasswordForm.Show();
            }

            private void View_User_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                LoadUserControl("ViewUsers");
            }

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }
        
    }
}
