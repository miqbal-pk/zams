using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.Model;
using ZAMS.DAL;

namespace ZAMS
{
    public partial class Projects : BaseControl
    {
        List<Project> list;
        private string admin_name;
        private string user_role;

        public Projects()
        {
            InitializeComponent();
        }

        public Projects(string title, string aName , string userRole)
            : base(title, "Projects")
        {
            admin_name = aName;
            this.user_role = userRole;
            
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////      HIDING COMPONENTS        ////////////////
            ////////////////////////////////////////////////////////////////////////////

            if (user_role.ToUpper() != "ADMIN")
            {
                checkBox_reverse.Hide();
                checkBox1_reverse.Hide();
                checkBox_customDebit.Hide();
                panel_pattyCash.Visible = true;
            }

            if (user_role.ToUpper() == "BANKUSER")
            {

                checkBox_reverse.Visible = false;
                checkBox1_reverse.Visible = false;
                checkBox_customDebit.Visible = false;
                radioButton_pattyCash.Visible = false;
                panel_pattyCash.Visible = false;
            }

            if (user_role.ToUpper() == "PATTYCASHUSER")
            {
                checkBox_reverse.Visible = false;
                checkBox1_reverse.Visible = false;
                checkBox_customDebit.Visible = false;
                radioButton_Bank.Visible = false;

                
                this.Ended_Projects.TabPages.Remove(this.tabPage5);

                //label_pattyCash.Show();
                //richTextBox_pattyCashDescription.Show();

                panel_pattyCash.Visible = true;

                label_SelectBank.Visible = false;


                comboBox_Bank.Visible = false; label_SelectBranch.Visible = false; comboBox_Branch.Visible = false; label_SelectAccount.Visible = false;
                comboBox_Account.Visible = false; label_BankCheck.Visible = false; textBox_BankChequeNo.Visible = false;
                label_bankDescription.Visible = false;
                richTextBox_BankDescription.Visible = false;

            }


            list = ZAMSFactory.DataBase.GetProjects();
            List<ProjectDummy> list_pd=ZAMSFactory.DataBase.GetProjectsDummy();
            gridView_projects.Rows.Clear();
            foreach (ProjectDummy pd in list_pd)
            {
                gridView_projects.Rows.Add(pd.Id, pd.OwnerParty, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
             //   onGoingProjects_dataGridView.Rows.Add(pd.Id, pd.OwnerParty, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
            }

            //autocomplete for search projects
            textBox_searchProjects.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_searchProjects.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AddSuggestions();


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////      Ended Projects            ////////////////EndedProjects_dataGridView
            ////////////////////////////////////////////////////////////////////////////
          
            List<Project> EndedProjectsList = new List<Project>();
            EndedProjectsList = ZAMSFactory.DataBase.EndedProjects();

            EndedProjects_dataGridView.Rows.Clear();
            foreach (Project pd in EndedProjectsList)
            {
                EndedProjects_dataGridView.Rows.Add(pd.Id, pd.OwnerPartyId, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
            }

            //onGoingProjects_dataGridView.Rows.Clear();
            //for (int i = 0; i < EndedProjectsList.Count; i++)
            //{
            //    Project pd = EndedProjectsList[i];
            //    onGoingProjects_dataGridView.Rows.Add(pd.Id, pd.OwnerPartyId, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
            //}



            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////      OnGoing Projects            ////////////////
            ////////////////////////////////////////////////////////////////////////////

            List<Project> OngoinProjectsList = new List<Project>();
            OngoinProjectsList = ZAMSFactory.DataBase.OngoinProjects();

            OnGoing_Projects_GridView.Rows.Clear();
            foreach (Project pd in OngoinProjectsList)
            {
                OnGoing_Projects_GridView.Rows.Add(pd.Id, pd.OwnerPartyId, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
            }


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////      Pending Projects          ////////////////
            ////////////////////////////////////////////////////////////////////////////

            List<Project> PendingProjectsList = new List<Project>();
            PendingProjectsList = ZAMSFactory.DataBase.getPendingProjects();

            PendingProjects_GridView.Rows.Clear();
            foreach (Project pd in PendingProjectsList)
            {
                PendingProjects_GridView.Rows.Add(pd.Id, pd.OwnerPartyId, pd.ProjectName, pd.Status, pd.EstimatedStartDate, pd.StartDate, pd.EstimatedEndDate, pd.EndDate, pd.InitialBalance, pd.CurrentBalance, pd.Credit);
            }
         
        }


        void AddSuggestions()
        {
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (Project p in list)
            {
                DataCollection.Add(p.ProjectName);
            }
            textBox_searchProjects.AutoCompleteCustomSource = DataCollection;
        }

        private void gridView_projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridView_projects.CellMouseClick += new DataGridViewCellMouseEventHandler(handler);
            
        }




        public void handler(object sender, EventArgs e)
        {
            List<PartyDummy> lp=ZAMSFactory.DataBase.GetClient();
            cb_ownerParty.DataSource = lp;
            cb_ownerParty.ValueMember = "Id";
            cb_ownerParty.DisplayMember = "Party_Name";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button_saveProject_Click(object sender, EventArgs e)
        {
            if(tb_projectName.Text.Equals("")||tb_initialAmount.Text.Equals(""))
            {
                label_status.Text = "Please fill all the required fields";
                label_status.Visible = true;
                return;
            }
            
            Project proj = new Project();
            proj.ProjectName = tb_projectName.Text;
            proj.InitialBalance = Convert.ToInt64(tb_initialAmount.Text);
            proj.EstimatedStartDate = dtp_startDate.Value.Date;
            proj.EstimatedEndDate = dtp_EstimatedEndingDate.Value.Date;
            proj.OwnerPartyId = Convert.ToInt32(cb_ownerParty.SelectedValue);
            //proj
            proj.Status = "Ongoing";
            int status=ZAMSFactory.DataBase.SaveProject(proj);
            if (status > 0)
            {
                label_status.Text = "Project Added Successfully";
                list.Add(proj);
                AddSuggestions();
                //Project p = proj;
                //gridView_projects.Rows.Add(new ProjectDummy { Id = p.Id, ProjectName = p.ProjectName, OwnerPartyId = p.OwnerPartyId, Credit = p.Credit, EstimatedStartDate = p.EstimatedStartDate, StartDate = p.StartDate, Status = p.Status, EstimatedEndDate = p.EstimatedEndDate, EndDate = p.EndDate, InitialBalance = p.InitialBalance, CurrentBalance = p.CurrentBalance });
                Projects_Load(sender,e);
                tb_projectName.Text = "";
                tb_initialAmount.Text = "";
                //cb_ownerParty.SelectedValue=cb_ownerParty.Items[0];
                handler(sender, e);
                dtp_startDate.Value = System.DateTime.Now;
                dtp_EstimatedEndingDate.Value = System.DateTime.Now;
            }
            else
            {
                label_status.Text = "Operation Failed!";
            }

            label_status.Visible = true;
            
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.projectsTableAdapter1.FillBy(this.database1DataSet1.Projects);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Client") || Convert.ToString(comboBox_party.Text).Equals("Select Vendor") || textBox_amount.Text.Equals("") || comboBox_type.Text.Equals(""))
            //{
            //    label_Transaction_error.Text = "Please fill all the required fields";
            //    //label_Transaction_error.ForeColor=;
            //    label_Transaction_error.Visible = true;
            //    return;
            //}
            //label_Transaction_error.Visible = false;
            //Transaction transaction = new Transaction();
            //transaction.Amount = int.Parse(textBox_amount.Text);
            //transaction.TransactionType = comboBox_type.Text;
            ////if (comboBox_type.Text.Equals("Credit"))
            //    transaction.PaymentType = comboBox_paymentType.Text;
            ////else
            ////    transaction.PaymentType = "Cash";
            ////if (comboBox_type.Text.Equals("Deposit"))
            ////{
            ////    re
            ////    //transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
            ////    //transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
            ////    //transaction.PayerId = int.Parse(comboBox_party.SelectedValue.ToString());
            ////}
            ////else
            ////{
            ////    transaction.RecipientId = int.Parse(comboBox_party.SelectedValue.ToString());
            ////        //int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
            ////    transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
            ////}
            //transaction.PartyId = int.Parse(comboBox_party.SelectedValue.ToString());
            //transaction.ProjectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
            //transaction.Description = richTextBox_description.Text;
            //transaction.OtherDetails = textBox_chequeNo.Text;
            //transaction.DateTime = System.DateTime.Now;
            //int status=ZAMSFactory.DataBase.SaveTransaction(transaction);
            //if (status > 0)
            //{
            //    int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
            //    int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
            //    if(ZAMSFactory.DataBase.SaveContractParty(partyId,projectId)>0)
            //    {
            //        label_Transaction_error.Text = "Transaction Saved Successfully";
            //        label_Transaction_error.Visible = true;
            //        textBox_amount.Clear();
            //        richTextBox_description.Clear();
            //        //richTextBox_otherDetails.Clear();
            //        textBox_chequeNo.Clear();
            //    }
            //    //label_error.Text = "Transaction Saved";
            //    else
            //    {
            //        label_Transaction_error.Text = "Transaction can't be saved";
            //        label_Transaction_error.Visible = true;
            //    }
                
                
            //    //panel2.Dispose();

            //}

            //else
            //{
            //    label_Transaction_error.Text = "Transaction can't be saved";
            //    label_Transaction_error.Visible = true;
            //}

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("saasas");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         //   MessageBox.Show("saasas");
        }

        private void MakeTransaction(object sender, EventArgs e)
        {
            //this.Parent.Hide();

            //MessageBox.Show("Hello");
        }

        private void MakeTransaction1(object sender, MouseEventArgs e)
        {

            //this.Parent.Hide();

            //MessageBox.Show("Hello1");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 3:
                    // Let's suppose TabPage index 1 is the one for the transactions.
                    // Assuming you have put a DataGridView control so that the transactions can be listed.
                    // currentCustomer.Id can be obtained through the CurrencyManager of your BindingSource object used to data bind your data to your Windows form controls.
                    // dataGridview1.DataSource = GetTransactions(currentCustomer.Id);




                    /////// List<Project> lp=ZAMSFactory.DataBase.GetProjects();

                    List<Project> lp = ZAMSFactory.DataBase.OngoinProjects();
                    Project p = new Project();
                    //p.ProjectName = "Select Project";
                    //lp.Add(p);
                    comboBox_project.DataSource = lp;
                    comboBox_project.ValueMember = "Id";
                    comboBox_project.DisplayMember = "ProjectName";
                    comboBox_project.Text = "Select Project";
                    //comboBox_project.SelectedIndex = lp.Count-1;
                    // comboBox_party.Text = "Select Project First";
                    radioButton_Client.Checked = true;
                    List<Party> cp = ZAMSFactory.DataBase.getClient1();
                    if (cp != null && cp.Count > 0)
                    {
                        comboBox_party.DataSource = cp;
                        comboBox_party.ValueMember = "Id";
                        comboBox_party.DisplayMember = "Party_Name";
                    }
                    comboBox_party.Text = "Select Client";
                    // For Bank Info
                    List<String> bankName = ZAMSFactory.DataBase.GetBankNames();
                    bankName.Add("Select Bank");
                    comboBox_Bank.DataSource = bankName;
                    comboBox_Bank.SelectedIndex = bankName.Count - 1;
                    comboBox_Account.DataSource = null;
                    comboBox_Branch.DataSource = null;
                    radioButton_Bank.Checked = true;
                    radioButton_Client.Checked = true;

                    // panel_pattyCash.Visible = false;
                    //
                    break;
                case 4:

                    if (user_role.ToUpper() == "PATTYCASHUSER")
                    {


                    }
                    else {

                        List<String> bankName1 = ZAMSFactory.DataBase.GetBankNames();
                        bankName1.Add("Select Bank");
                        comboBox_Bank2.DataSource = bankName1;
                        comboBox_Bank2.SelectedIndex = bankName1.Count - 1;
                        comboBox_AccountNo2.DataSource = null;
                        comboBox_Branch2.DataSource = null;
                    }


                    break;
            }
        }

        private void comboBox_project_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_party_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_project_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_project_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_project_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_project_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_project_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int id = int.Parse(comboBox_project.ValueMember); 
           //string name = comboBox_party.Text;
            //string idp=ZAMSFactory.DataBase.getProjectId(comboBox_project.Text);
            
            //comboBox_party.Text = "aaa";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox_searchProjects_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel_searchProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            label_noProject.Visible = false;
            button_saveChanges.Visible = false;
            label_edit_status.Visible = false;
            if (textBox_searchProjects.Text.Equals(""))
                return;
            Project proj=ZAMSFactory.DataBase.GetProjectByName(textBox_searchProjects.Text);
            if (proj != null)
            {
                panel_searchProject.Visible = true;
                label_poject_id.Text = proj.Id.ToString();
                textBox_projectName.Text = proj.ProjectName;
                textBox_credit.Text = proj.Credit.ToString();
                textBox_currentBalance.Text = proj.CurrentBalance.ToString();
                textBox_endDate.Text = proj.EndDate.ToString();
                textBox_estEndingDate.Text = proj.EstimatedEndDate.ToString();
                textBox_initialBalance.Text = proj.InitialBalance.ToString();
                textBox_ownerParty.Text = proj.Party.Party_Name;
                textBox_startingDate.Text = proj.StartDate.ToString();
                //  comboBox_project_status. = proj.Status;
                //making fields readonly
                textBox_projectName.ReadOnly = true;
                textBox_credit.ReadOnly = true;
                textBox_currentBalance.ReadOnly = true;
                textBox_endDate.ReadOnly = true;
                textBox_estEndingDate.ReadOnly = true;
                textBox_initialBalance.ReadOnly = true;
                textBox_ownerParty.ReadOnly = true;
                textBox_startingDate.ReadOnly = true;
                comboBox_project_status.SelectedItem = proj.Status;
                //comboBox_project_status.
                label_project_status.Text = proj.Status;
              
            }
            else
            {
                panel_searchProject.Visible = false;
                label_noProject.Text = "Invalid Project Name";
                label_noProject.Visible = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
           //comboBox_project_status.
            //textBox_projectName.ReadOnly = false;
            //textBox_credit.ReadOnly = false;
            //textBox_currentBalance.ReadOnly = false;
           /// textBox_endDate.ReadOnly = false;
            //textBox_estEndingDate.ReadOnly = false;
            //textBox_initialBalance.ReadOnly = false;
            //textBox_ownerParty.ReadOnly = false;
            //textBox_startingDate.ReadOnly = false;
           // comboBox_project_status.ReadOnly = false;
            button_saveChanges.Visible = true;
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(textBox_amount.Text); }
            catch (Exception ex) { textBox_amount.Text = ""; }
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            int status;
            p.Id = int.Parse(label_poject_id.Text);
            p.Status = comboBox_project_status.SelectedItem.ToString();
            if (p.Status.Equals(label_project_status.Text))
                status = 1;
            else if (p.Status.Equals("Ended") && label_project_status.Text.Equals("Ongoing"))
            {
                p.EndDate = System.DateTime.Now.Date;
                textBox_endDate.Text = p.EndDate.ToString();
                status = ZAMSFactory.DataBase.SaveEditProject(p);
            }
            else
            {
                p.EndDate =null;
                status = ZAMSFactory.DataBase.SaveEditProject(p);
            }
            
           // int status = ZAMSFactory.DataBase.SaveEditProject(p);
            if (status > 0)
            {
                label_edit_status.Text= "Changes Saved Successfuly";
                label_edit_status.Visible = true;
                Projects_Load(new object(), new EventArgs());
                panel_searchProject.Visible = false;

            }
            else
            {
                label_edit_status.Text  = "Operation failed";
                label_edit_status.Visible = true;
            }
        }

        private void comboBox_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = comboBox_type.Text;
            //MessageBox.Show(val);
            //if (val.Equals("Credit"))
            //{
            //    comboBox_paymentType.Enabled = true;
            //}
            //else
            //    comboBox_paymentType.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_Client_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox_newVendor.Checked = false;
            List<Party> cp = ZAMSFactory.DataBase.getClient1();
            if (cp!=null&&cp.Count >0)
            {
                comboBox_party.DataSource = cp;
                comboBox_party.ValueMember = "Id";
                comboBox_party.DisplayMember = "Party_Name";
            }
            comboBox_party.Text = "Select Client";

        }

        private void radioButton_Vendor_CheckedChanged(object sender, EventArgs e)
        {
            List<Party> cp = ZAMSFactory.DataBase.getVendor();
            if (cp != null && cp.Count > 0)
            {
                comboBox_party.DataSource = cp;
                comboBox_party.ValueMember = "Id";
                comboBox_party.DisplayMember = "Party_Name";
            }
            comboBox_party.Text = "Select Vendor";

        }

        private void tb_projectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_initialAmount_TextChanged(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(tb_initialAmount.Text); }
            catch (Exception ex) { tb_initialAmount.Text = ""; }
        }

        private void richTextBox_BankDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Bank_CheckedChanged(object sender, EventArgs e)
        {
            panel_Bank.Visible = true;
            panel_pattyCash.Visible = false;
        }

        private void radioButton_pattyCash_CheckedChanged(object sender, EventArgs e)
        {
            panel_pattyCash.Visible = true;
            panel_Bank.Visible = false;
        }

        private void comboBox_Bank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank.SelectedValue.ToString();
            List<String> branchName = ZAMSFactory.DataBase.GetBranchNames(bankName);
            branchName.Add("Select Branch");
            comboBox_Branch.DataSource = branchName;
            comboBox_Branch.SelectedIndex = branchName.Count - 1;
            comboBox_Account.DataSource = null;
        }

        private void comboBox_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank.SelectedValue.ToString();
            String branchName = comboBox_Branch.SelectedValue.ToString();
            List<String> AccountNo = ZAMSFactory.DataBase.GetAccountNo(bankName, branchName);
            AccountNo.Add("Select AccountNo");
            comboBox_Account.DataSource = AccountNo;
            comboBox_Account.SelectedIndex = AccountNo.Count - 1;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void handler(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button_saveTransaction_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox_paymentType.Text).Equals("Bill"))
            {
                if(Convert.ToString(comboBox_paymentType.Text).Equals("") ||Convert.ToString(comboBox_type.Text).Equals("")
                    ||Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Client") || Convert.ToString(comboBox_party.Text).Equals("Select Vendor")
                    || textBox_amount.Text.Equals("") ||richTextBox_description.Text.Equals(""))
                {
                    label_Transaction_error.Text = "Please fill all the required fields Or Make Approperiate Selection";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                }
                else
                {
                    label_Transaction_error.Visible = false;
                    Transaction transaction = new Transaction();
                    transaction.Amount = int.Parse(textBox_amount.Text);
                    transaction.TransactionType = comboBox_type.Text;
                    //if (comboBox_type.Text.Equals("Credit"))
                    transaction.PaymentType = comboBox_paymentType.Text;
                    //else
                    //    transaction.PaymentType = "Cash";
                    //if (comboBox_type.Text.Equals("Deposit"))
                    //{
                    //    re
                    //    //transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                    //    //transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                    //    //transaction.PayerId = int.Parse(comboBox_party.SelectedValue.ToString());
                    //}
                    //else
                    //{
                    //    transaction.RecipientId = int.Parse(comboBox_party.SelectedValue.ToString());
                    //        //int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                    //    transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                    //}
                    transaction.PartyId = int.Parse(comboBox_party.SelectedValue.ToString());
                    transaction.ProjectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                    transaction.Description = richTextBox_description.Text;
                    transaction.OtherDetails = textBox_chequeNo.Text;
                    transaction.DateTime = System.DateTime.Now;
                
                    transaction.UserName = admin_name;

                    bool reverse = false;
                    if (checkBox_reverse.Checked)
                    {
                        reverse = true;
                    }

                    int status = ZAMSFactory.DataBase.SaveTransaction(transaction,reverse);
                    if (status > 0)
                    {
                        int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                        int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                        if (ZAMSFactory.DataBase.SaveContractParty(partyId, projectId) > 0)
                        {
                            //label_Transaction_error.Text = "Transaction Saved Successfully";
                          //  label_Transaction_error.Visible = true;
                            MessageBox.Show("Transaction Saved Successfully");
                            textBox_amount.Clear();
                            richTextBox_description.Clear();
                            //richTextBox_otherDetails.Clear();
                            textBox_chequeNo.Clear();
                        }
                        //label_error.Text = "Transaction Saved";
                        else
                        {
                            label_Transaction_error.Text = "Transaction can't be saved";
                            label_Transaction_error.Visible = true;
                        }


                        //panel2.Dispose();

                    }

                    else
                    {
                        label_Transaction_error.Text = "Transaction can't be saved";
                        label_Transaction_error.Visible = true;
                    }

                }
            }





            else
            {
                checkNo_Error_Label.Hide();
                label_Transaction_error.Hide();

                if (radioButton_Bank.Checked && (Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Client") || Convert.ToString(comboBox_party.Text).Equals("Select Vendor") || textBox_amount.Text.Equals("") || comboBox_type.Text.Equals("")
                    || Convert.ToString(comboBox_Bank.Text).Equals("") || Convert.ToString(comboBox_Bank.Text).Equals("Select Bank") || Convert.ToString(comboBox_Branch.Text).Equals("") || Convert.ToString(comboBox_Branch.Text).Equals("Select Branch")
                    || Convert.ToString(comboBox_Account.Text).Equals("") || Convert.ToString(comboBox_Account.Text).Equals("Select AccountNo") || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("") || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals(Convert.ToString(comboBox_type.Text))
                    || (!(textBox_BPAmount.Text.Equals(textBox_amount.Text))) || richTextBox_BankDescription.Text.Equals("") || richTextBox_description.Text.Equals("")
                    ||Convert.ToString(comboBox_paymentType.Text).Equals("") ||Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("") ||Convert.ToString(comboBox_type.Text).Equals("")))
                {
                    if (textBox_amount.Text.Equals("") || comboBox_type.Text.Equals("") || Convert.ToString(comboBox_Bank.Text).Equals("")
                        || Convert.ToString(comboBox_Bank.Text).Equals("Select Bank") || Convert.ToString(comboBox_Branch.Text).Equals("") || Convert.ToString(comboBox_Branch.Text).Equals("Select Branch")
                    || Convert.ToString(comboBox_Account.Text).Equals("") || Convert.ToString(comboBox_Account.Text).Equals("Select AccountNo") || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("")
                        || richTextBox_BankDescription.Text.Equals("") || richTextBox_description.Text.Equals("")
                        ||Convert.ToString(comboBox_paymentType.Text).Equals("") ||Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("") ||Convert.ToString(comboBox_type.Text).Equals(""))
                    {
                        label_Transaction_error.Text = "Please fill all the required fields Or Make Approperiate Selection";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if ((!(textBox_BPAmount.Text.Equals(textBox_amount.Text))))
                    {
                        label_Transaction_error.Text = "Both Amounts must be equal";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if (Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals(Convert.ToString(comboBox_type.Text)))
                    {
                        label_Transaction_error.Text = "Both Transactions Type must be opposite";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
   

                }







                //else if(!(comboBox_paymentType.Text).Equals("Bill"))
                //{
                //   if (textBox_chequeNo.Text != textBox_BankChequeNo.Text)
                //    {
                //      checkNo_Error_Label.Show();
                //     }
                //}














                else if (radioButton_pattyCash.Checked && (Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Client")
                    || Convert.ToString(comboBox_party.Text).Equals("Select Vendor") || textBox_amount.Text.Equals("") || comboBox_type.Text.Equals("")
                   || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("")
                    || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals(Convert.ToString(comboBox_type.Text))
                    || (!(textBox_BPAmount.Text.Equals(textBox_amount.Text))) || richTextBox_pattyCashDescription.Text.Equals("") || richTextBox_description.Text.Equals("")
                    ||Convert.ToString(comboBox_paymentType.Text).Equals("") ||Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("") ||Convert.ToString(comboBox_type.Text).Equals("")
                    || (Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("Debit") && !checkBox_reverse.Checked)||
                    (Convert.ToString(comboBox_type.Text).Equals("Debit")&&checkBox_reverse.Checked)))
                {
                    if (Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Client")
                    || Convert.ToString(comboBox_party.Text).Equals("Select Vendor") || textBox_amount.Text.Equals("") || comboBox_type.Text.Equals("")
                   || Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("")
                        || richTextBox_pattyCashDescription.Text.Equals("") || richTextBox_description.Text.Equals("")
                        ||Convert.ToString(comboBox_paymentType.Text).Equals("") ||Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("") ||Convert.ToString(comboBox_type.Text).Equals(""))
                    {
                        label_Transaction_error.Text = "Please fill all the required fields Or Make Approperiate Selection";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if ((!(textBox_BPAmount.Text.Equals(textBox_amount.Text))))
                    {
                        label_Transaction_error.Text = "Both Amounts must be equal";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if (Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals(Convert.ToString(comboBox_type.Text)))
                    {
                        label_Transaction_error.Text = "Both Transactions Type must be opposite";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if (Convert.ToString(comboBox_bankOrPattyTransactionType.Text).Equals("Debit")&& !checkBox_reverse.Checked)
                    {
                        label_Transaction_error.Text = "Patty cash only Debit from bank";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }
                    else if ((Convert.ToString(comboBox_type.Text).Equals("Debit") && checkBox_reverse.Checked))
                    {
                        label_Transaction_error.Text = "This Reverse is not Possible";
                        //label_Transaction_error.ForeColor=;
                        label_Transaction_error.Visible = true;
                        return;
                    }

                }
                else
                {
                    if (radioButton_pattyCash.Checked)
                    {
                        label_Transaction_error.Visible = false;
                        Transaction transaction = new Transaction();
                        transaction.Amount = int.Parse(textBox_amount.Text);
                        transaction.TransactionType = comboBox_type.Text;
                        bool reverse=false;

                        if (checkBox_reverse.Checked)
                        {
                            reverse = true;
                        }
                        
                    
                        //if (comboBox_type.Text.Equals("Credit"))
                        transaction.PaymentType = comboBox_paymentType.Text;
                        //else
                        //    transaction.PaymentType = "Cash";
                        //if (comboBox_type.Text.Equals("Deposit"))
                        //{
                        //    re
                        //    //transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                        //    //transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                        //    //transaction.PayerId = int.Parse(comboBox_party.SelectedValue.ToString());
                        //}
                        //else
                        //{
                        //    transaction.RecipientId = int.Parse(comboBox_party.SelectedValue.ToString());
                        //        //int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                        //    transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                        //}
                        transaction.PartyId = int.Parse(comboBox_party.SelectedValue.ToString());
                        transaction.ProjectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                        transaction.Description = richTextBox_description.Text;
                        transaction.OtherDetails = textBox_chequeNo.Text;
                        transaction.DateTime = System.DateTime.Now;
                      
                        transaction.UserName = admin_name;

                        //// Make Patty cash Transaction
                        PettyCash pt = new PettyCash();
                        //pt.
                        pt.Amount = int.Parse(textBox_BPAmount.Text);
                        pt.TransactionDate = System.DateTime.Now;
                        pt.Description = richTextBox_pattyCashDescription.Text;
                        pt.TransactionType = comboBox_bankOrPattyTransactionType.Text;


                        pt.UserName = admin_name;


                        ////
                        long currentBalance = 0;
                        if (pt.TransactionType.Equals("Credit"))
                        {
                            currentBalance = ZAMSFactory.DataBase.GetPattyBalance();
                            if (pt.Amount > currentBalance)
                            {
                                label_Transaction_error.Text = "You Have Not Enough Money in Patty Cash";
                                //label_Transaction_error.ForeColor=;
                                label_Transaction_error.Visible = true;
                                return;
                            }
                        }

                        int status = ZAMSFactory.DataBase.SaveTransaction(transaction, pt,reverse);
                        if (status > 0)
                        {
                            int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                            int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                            if (ZAMSFactory.DataBase.SaveContractParty(partyId, projectId) > 0)
                            {
                               // label_Transaction_error.Text = "Transaction Saved Successfully";
                               // label_Transaction_error.Visible = true;
                                MessageBox.Show("Transaction Saved Successfully");
                                textBox_amount.Clear();
                                richTextBox_description.Clear();
                                checkBox_reverse.Checked = false;
                                textBox_BPAmount.Clear();
                                richTextBox_pattyCashDescription.Clear();
                                //richTextBox_otherDetails.Clear();
                                textBox_chequeNo.Clear();
                            }
                            //label_error.Text = "Transaction Saved";
                            else
                            {
                                label_Transaction_error.Text = "Transaction can't be saved";
                                label_Transaction_error.Visible = true;
                            }


                            //panel2.Dispose();

                        }

                        else
                        {
                            label_Transaction_error.Text = "Transaction can't be saved";
                            label_Transaction_error.Visible = true;
                        }
                    }

                    else if (radioButton_Bank.Checked)
                    {
                        label_Transaction_error.Visible = false;
                        Transaction transaction = new Transaction();
                        transaction.Amount = int.Parse(textBox_amount.Text);
                        transaction.TransactionType = comboBox_type.Text;
                        //if (comboBox_type.Text.Equals("Credit"))
                        transaction.PaymentType = comboBox_paymentType.Text;
                        bool reverse2=false;

                        if (checkBox_reverse.Checked)
                        {
                            reverse2 = true;
                        }
                        //else
                        //    transaction.PaymentType = "Cash";
                        //if (comboBox_type.Text.Equals("Deposit"))
                        //{
                        //    re
                        //    //transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                        //    //transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                        //    //transaction.PayerId = int.Parse(comboBox_party.SelectedValue.ToString());
                        //}
                        //else
                        //{
                        //    transaction.RecipientId = int.Parse(comboBox_party.SelectedValue.ToString());
                        //        //int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                        //    transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                        //}
                        transaction.PartyId = int.Parse(comboBox_party.SelectedValue.ToString());
                        transaction.ProjectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                        transaction.Description = richTextBox_description.Text;
                        transaction.OtherDetails = textBox_chequeNo.Text;
                        transaction.DateTime = System.DateTime.Now;


                        transaction.UserName = admin_name;



                        //////////// Make Bank Transaction
                        BankTransaction bt = new BankTransaction();
                        bt.Amount = int.Parse(textBox_BPAmount.Text);
                        bt.Description = richTextBox_BankDescription.Text;
                        bt.TransactionDate = System.DateTime.Now;
                        bt.OtherDetail = textBox_BankChequeNo.Text;
                        bt.TransactionType = comboBox_bankOrPattyTransactionType.Text;


                        bt.UserName = admin_name;


                        Bank b = ZAMSFactory.DataBase.GetSpecificAccountInfo(comboBox_Bank.SelectedValue.ToString(), comboBox_Branch.SelectedValue.ToString(), comboBox_Account.SelectedValue.ToString());
                        bt.BankId = b.Id;
                        /////////////

                        if (bt.TransactionType.Equals("Credit"))
                        {
                            // currentBalance = b.Balance;
                            if (bt.Amount > b.Balance)
                            {
                                label_Transaction_error.Text = "You Have Not Enough Money in this Bank";
                                //label_Transaction_error.ForeColor=;
                                label_Transaction_error.Visible = true;
                                return;
                            }
                        }
                        int status = ZAMSFactory.DataBase.SaveTransaction(transaction, bt,reverse2);
                        if (status > 0)
                        {
                            int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                            int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                            if (ZAMSFactory.DataBase.SaveContractParty(partyId, projectId) > 0)
                            {
                               // label_Transaction_error.Text = "Transaction Saved Successfully";
                               // label_Transaction_error.Visible = true;
                                MessageBox.Show("Transaction Saved Successfully");
                                textBox_amount.Clear();
                                richTextBox_description.Clear();
                                checkBox_reverse.Checked = false;
                                textBox_BPAmount.Clear();
                                richTextBox_BankDescription.Clear();
                                textBox_BankChequeNo.Clear();
                                //richTextBox_otherDetails.Clear();
                                textBox_chequeNo.Clear();
                            }
                            //label_error.Text = "Transaction Saved";
                            else
                            {
                                label_Transaction_error.Text = "Transaction can't be saved";
                                label_Transaction_error.Visible = true;
                            }


                            //panel2.Dispose();

                        }

                        else
                        {
                            label_Transaction_error.Text = "Transaction can't be saved";
                            label_Transaction_error.Visible = true;
                        }
                    }
                }
            }
        }

        private void radioButton_Vendor_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!comboBox_project.Text.Equals(""))
            {
                List<Party> cp = ZAMSFactory.DataBase.getVendor(int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text)));

                //  List<Party> cp = ZAMSFactory.DataBase.getVendor();
                if (cp != null && cp.Count > 0)
                {
                    comboBox_party.DataSource = cp;
                    comboBox_party.ValueMember = "Id";
                    comboBox_party.DisplayMember = "Party_Name";
                }
            }
                comboBox_party.Text = "Select Vendor";
            
           
        }

        private void radioButton_Bank_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_Bank.Visible = true;
            panel_pattyCash.Visible = false;
        }

        private void radioButton_pattyCash_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_pattyCash.Visible = true;
            panel_Bank.Visible = false;
        }

        private void textBox_amount_TextChanged_1(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(textBox_amount.Text); }
            catch (Exception ex) { textBox_amount.Text = ""; }
        }

        private void textBox_BPAmount_TextChanged(object sender, EventArgs e)
        {
            try { long aamount = Convert.ToInt64(textBox_BPAmount.Text); }
            catch (Exception ex) { textBox_BPAmount.Text = ""; }
        }

        private void comboBox_Bank_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank.SelectedValue.ToString();
            List<String> branchName = ZAMSFactory.DataBase.GetBranchNames(bankName);
            branchName.Add("Select Branch");
            comboBox_Branch.DataSource = branchName;
            comboBox_Branch.SelectedIndex = branchName.Count - 1;
            comboBox_Account.DataSource = null;
        }

        private void comboBox_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank.SelectedValue.ToString();
            String branchName = comboBox_Branch.SelectedValue.ToString();
            List<String> AccountNo = ZAMSFactory.DataBase.GetAccountNo(bankName, branchName);
            AccountNo.Add("Select AccountNo");
            comboBox_Account.DataSource = AccountNo;
            comboBox_Account.SelectedIndex = AccountNo.Count - 1;
        }

        private void button_ChekOut2_Click(object sender, EventArgs e)
        {
            label_bankPattyError.Visible = false;
            if (checkBox_customDebit.Checked)
            {
                if (Convert.ToString(comboBox_Bank2.Text).Equals("") || Convert.ToString(comboBox_Bank2.Text).Equals("Select Bank") || Convert.ToString(comboBox_Branch2.Text).Equals("") || Convert.ToString(comboBox_Branch2.Text).Equals("Select Branch")
                 || Convert.ToString(comboBox_AccountNo2.Text).Equals("") || Convert.ToString(comboBox_AccountNo2.Text).Equals("Select AccountNo") || textBox_bankAmount2.Text.Equals("") || richTextBox_bankDescription2.Text.Equals(""))
                {

                    label_bankPattyError.Text = "Please fill all the required fields Or Make Aproperiate Selection";
                    //label_Transaction_error.ForeColor=;
                    label_bankPattyError.Visible = true;
                    return;
                }
                else
                {
                    BankTransaction bt = new BankTransaction();
                    bt.Amount = int.Parse(textBox_bankAmount2.Text);
                    bt.Description = richTextBox_bankDescription2.Text;
                    bt.TransactionDate = System.DateTime.Now;
                    bt.TransactionType = "Debit";
                    Bank b = ZAMSFactory.DataBase.GetSpecificAccountInfo(comboBox_Bank2.SelectedValue.ToString(), comboBox_Branch2.SelectedValue.ToString(), comboBox_AccountNo2.SelectedValue.ToString());
                    bt.BankId = b.Id;
                    bt.OtherDetail = textBox_bankChequeNo2.Text;


                    bt.UserName = admin_name;
 
                    //////////////////////////////////
                    int status = ZAMSFactory.DataBase.SaveTransactionBank(bt);
                    if (status > 0)
                    {
                        // label_bankPattyError.Text = "Transaction Saved Successfully";
                        //  label_bankPattyError.Visible = true;
                        MessageBox.Show("Transaction Saved Successfully");
                        textBox_bankAmount2.Text = "";
                       // textBox_pattyAmount.Clear();
                        richTextBox_bankDescription2.Clear();
                       // richTextBox_PattyDescription2.Clear();
                        textBox_bankChequeNo2.Clear();
                        checkBox1_reverse.Checked = false;
                    }
                    else
                    {
                        label_bankPattyError.Text = "Transaction can't be Saved";
                        label_bankPattyError.Visible = true;

                    }
                }

            }




            else
            {
                if (Convert.ToString(comboBox_Bank2.Text).Equals("") || Convert.ToString(comboBox_Bank2.Text).Equals("Select Bank") || Convert.ToString(comboBox_Branch2.Text).Equals("") || Convert.ToString(comboBox_Branch2.Text).Equals("Select Branch")
                    || Convert.ToString(comboBox_AccountNo2.Text).Equals("") || Convert.ToString(comboBox_AccountNo2.Text).Equals("Select AccountNo") || Convert.ToString(comboBox_pattyType.Text).Equals("") || Convert.ToString(comboBox_bankType.Text).Equals("") || Convert.ToString(comboBox_pattyType.Text).Equals(Convert.ToString(comboBox_bankType.Text))
                    || (!(textBox_pattyAmount.Text.Equals(textBox_bankAmount2.Text))) || richTextBox_bankDescription2.Text.Equals("") || richTextBox_PattyDescription2.Text.Equals("") || textBox_bankAmount2.Text.Equals("") || textBox_pattyAmount.Text.Equals("")
                    || ((Convert.ToString(comboBox_pattyType.Text).Equals("Credit")) && !(checkBox1_reverse.Checked) ||
                    (Convert.ToString(comboBox_bankType.Text).Equals("Credit") && checkBox1_reverse.Checked)))
                {
                    if (Convert.ToString(comboBox_Bank2.Text).Equals("") || Convert.ToString(comboBox_Bank2.Text).Equals("Select Bank") || Convert.ToString(comboBox_Branch2.Text).Equals("") || Convert.ToString(comboBox_Branch2.Text).Equals("Select Branch")
                     || Convert.ToString(comboBox_AccountNo2.Text).Equals("") || Convert.ToString(comboBox_AccountNo2.Text).Equals("Select AccountNo") || Convert.ToString(comboBox_pattyType.Text).Equals("") || Convert.ToString(comboBox_bankType.Text).Equals("")
                       || richTextBox_bankDescription2.Text.Equals("") || richTextBox_PattyDescription2.Text.Equals("") || textBox_bankAmount2.Text.Equals("") || textBox_pattyAmount.Text.Equals(""))
                    {

                        label_bankPattyError.Text = "Please fill all the required fields Or Make Aproperiate Selection";
                        //label_Transaction_error.ForeColor=;
                        label_bankPattyError.Visible = true;
                        return;
                    }
                    else if (Convert.ToString(comboBox_pattyType.Text).Equals(Convert.ToString(comboBox_bankType.Text)))
                    {
                        label_bankPattyError.Text = "Both Transactions Type must be opposite";
                        //label_Transaction_error.ForeColor=;
                        label_bankPattyError.Visible = true;
                        return;
                    }
                    else if ((!(textBox_pattyAmount.Text.Equals(textBox_bankAmount2.Text))))
                    {
                        label_bankPattyError.Text = "Both Amounts must be equal";
                        //label_Transaction_error.ForeColor=;
                        label_bankPattyError.Visible = true;
                        return;
                    }
                    else if (Convert.ToString(comboBox_pattyType.Text).Equals("Credit") && !(checkBox1_reverse.Checked))
                    {
                        label_bankPattyError.Text = "Credit from pettyCash only allowed with reverse";
                        //label_Transaction_error.ForeColor=;
                        label_bankPattyError.Visible = true;
                        return;
                    }
                    else if ((Convert.ToString(comboBox_bankType.Text).Equals("Credit") && checkBox1_reverse.Checked))
                    {
                        label_bankPattyError.Text = "This reverse is not possible";
                        //label_Transaction_error.ForeColor=;
                        label_bankPattyError.Visible = true;
                        return;
                    }
                }
                else
                {

                    //////////// Make Bank Transaction
                    BankTransaction bt = new BankTransaction();
                    bt.Amount = int.Parse(textBox_bankAmount2.Text);
                    bt.Description = richTextBox_bankDescription2.Text;
                    bt.TransactionDate = System.DateTime.Now;
                    bt.TransactionType = comboBox_bankType.Text;
                    Bank b = ZAMSFactory.DataBase.GetSpecificAccountInfo(comboBox_Bank2.SelectedValue.ToString(), comboBox_Branch2.SelectedValue.ToString(), comboBox_AccountNo2.SelectedValue.ToString());
                    bt.BankId = b.Id;
                    bt.OtherDetail = textBox_bankChequeNo2.Text;


                    bt.UserName = admin_name;


                    /////////////
                    bool reverse = false;
                    if (checkBox1_reverse.Checked)
                    {
                        reverse = true;
                    }
                    //// Make Patty cash Transaction
                    PettyCash pt = new PettyCash();
                    pt.Amount = int.Parse(textBox_pattyAmount.Text);
                    pt.TransactionDate = System.DateTime.Now;
                    pt.Description = richTextBox_PattyDescription2.Text;
                    pt.TransactionType = comboBox_pattyType.Text;
                    
                    
                    
                    pt.UserName = admin_name;
                    
                    
                    
                    ////
                    long currentBalance = 0;
                    if (pt.TransactionType.Equals("Credit"))
                    {
                        currentBalance = ZAMSFactory.DataBase.GetPattyBalance();
                    }
                    else
                    {
                        currentBalance = b.Balance;
                    }
                    if (pt.Amount > currentBalance)
                    {
                        label_bankPattyError.Text = "You Have not Enough Money";
                        label_bankPattyError.Visible = true;
                    }
                    else
                    {
                        int status = ZAMSFactory.DataBase.SaveTransactionPattyBank(bt, pt, reverse);
                        if (status > 0)
                        {
                            // label_bankPattyError.Text = "Transaction Saved Successfully";
                            //  label_bankPattyError.Visible = true;
                            MessageBox.Show("Transaction Saved Successfully");
                            textBox_bankAmount2.Text = "";
                            textBox_pattyAmount.Clear();
                            richTextBox_bankDescription2.Clear();
                            richTextBox_PattyDescription2.Clear();
                            textBox_bankChequeNo2.Clear();
                            checkBox1_reverse.Checked = false;
                        }
                        else
                        {
                            label_bankPattyError.Text = "Transaction can't be Saved";
                            label_bankPattyError.Visible = true;

                        }
                    }

                }
            }
        }

        private void comboBox_Bank2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank2.SelectedValue.ToString();
            List<String> branchName = ZAMSFactory.DataBase.GetBranchNames(bankName);
            branchName.Add("Select Branch");
            comboBox_Branch2.DataSource = branchName;
            comboBox_Branch2.SelectedIndex = branchName.Count - 1;
            comboBox_AccountNo2.DataSource = null;
        }

        private void comboBox_Branch2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank2.SelectedValue.ToString();
            String branchName = comboBox_Branch2.SelectedValue.ToString();
            List<String> AccountNo = ZAMSFactory.DataBase.GetAccountNo(bankName, branchName);
            AccountNo.Add("Select AccountNo");
            comboBox_AccountNo2.DataSource = AccountNo;
            comboBox_AccountNo2.SelectedIndex = AccountNo.Count - 1;
        }

        private void textBox_pattyAmount_TextChanged(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(textBox_pattyAmount.Text); }
            catch (Exception ex) { textBox_pattyAmount.Text = ""; }
        }

        private void textBox_bankAmount2_TextChanged(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(textBox_bankAmount2.Text); }
            catch (Exception ex) { textBox_bankAmount2.Text = ""; }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_paymentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String pt=comboBox_paymentType.Text;
            if (pt.Equals("Bill"))
            {
                panel_bankPatty.Visible = false;
            }
            else
            {
                panel_bankPatty.Visible = true;
            }
        }

        private void comboBox_project_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel_clientVendor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_newVendor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_newVendor.Checked)
            {
                radioButton_Vendor.Checked = true;
                checkBox_newVendor.Checked = true;
                List<Party> cp = ZAMSFactory.DataBase.getVendor();
                if (cp != null && cp.Count > 0)
                {
                    comboBox_party.DataSource = cp;
                    comboBox_party.ValueMember = "Id";
                    comboBox_party.DisplayMember = "Party_Name";
                }
                comboBox_party.Text = "Select Vendor";
            }
            else
            {
                if (!comboBox_project.Text.Equals(""))
                {
                    List<Party> cp = ZAMSFactory.DataBase.getVendor(int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text)));


                    //  List<Party> cp = ZAMSFactory.DataBase.getVendor();
                    if (cp != null && cp.Count > 0)
                    {
                        comboBox_party.DataSource = cp;
                        comboBox_party.ValueMember = "Id";
                        comboBox_party.DisplayMember = "Party_Name";
                    }
                }
                comboBox_party.Text = "Select Vendor";
            }
        }

        private void checkBox_customDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_customDebit.Checked)
            {
                panel_Patty.Visible = false;
                label27.Visible = false;
                comboBox_bankType.Visible = false;
            }
            else
            {
                panel_Patty.Visible = true;
                label27.Visible = true;
                comboBox_bankType.Visible = true;
            }
        }

        private void textBox_BankChequeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

 
        }

        private void comboBox_project_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EndedProjects_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_ownerParty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void radioButton_Client_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}

       
        }
    }

