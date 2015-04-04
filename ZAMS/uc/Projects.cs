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
        public Projects()
        {
            InitializeComponent();
        }

        public Projects(string title)
            : base(title, "ReportHome")
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            list = ZAMSFactory.DataBase.GetProjects();
            List<ProjectDummy> list_pd=ZAMSFactory.DataBase.GetProjectsDummy();
            foreach (ProjectDummy pd in list_pd)
            {
                gridView_projects.Rows.Add(pd.Id,pd.OwnerPartyId,pd.EstimatedStartDate,pd.StartDate,pd.ProjectName,pd.EstimatedEndDate,pd,EndDate,pd.Status,pd,InitialBalance,pd.CurrentBalance,pd,Credit);
            }
           
            //autocomplete for search projects
            textBox_searchProjects.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_searchProjects.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AddSuggestions();
            

            
            
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
            List<PartyDummy> lp=ZAMSFactory.DataBase.GetCompanies();
            cb_ownerParty.DataSource = lp;
            cb_ownerParty.ValueMember = "Id";
            cb_ownerParty.DisplayMember = "Party_Name";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button_saveProject_Click(object sender, EventArgs e)
        {
            if(tb_projectName.Text.Equals("")||tb_location.Text.Equals("")||tb_initialAmount.Text.Equals(""))
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
            proj.Status = "Ongoing";
            int status=ZAMSFactory.DataBase.SaveProject(proj);
            if (status > 0)
            {
                label_status.Text = "Project Added Successfully";
                list.Add(proj);
                AddSuggestions();
                Project p = proj;
                gridView_projects.Rows.Add(new ProjectDummy { Id = p.Id, ProjectName = p.ProjectName, OwnerPartyId = p.OwnerPartyId, Credit = p.Credit, EstimatedStartDate = p.EstimatedStartDate, StartDate = p.StartDate, Status = p.Status, EstimatedEndDate = p.EstimatedEndDate, EndDate = p.EndDate, InitialBalance = p.InitialBalance, CurrentBalance = p.CurrentBalance });
                
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
            if (Convert.ToString(comboBox_project.Text).Equals("Select Project") || Convert.ToString(comboBox_party.Text).Equals("Select Party") || textBox_amount.Text.Equals("") || comboBox_type.Text.Equals(""))
            {
                label_Transaction_error.Text = "Please fill all the required fields";
                //label_Transaction_error.ForeColor=;
                label_Transaction_error.Visible = true;
                return;
            }
            label_Transaction_error.Visible = false;
            Transaction transaction = new Transaction();
            transaction.Amount = int.Parse(textBox_amount.Text);
            transaction.TransactionType = comboBox_type.Text;
            if (comboBox_type.Text.Equals("Deposit"))
            {
                transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
            }
            else
            {
                transaction.RecipientId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                transaction.PayerId = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
            }
            transaction.ProjectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
            transaction.Description = richTextBox_description.Text;
            transaction.OtherDetails = richTextBox_otherDetails.Text;
            transaction.DateTime = System.DateTime.Now;
            int status=ZAMSFactory.DataBase.SaveTransaction(transaction);
            if (status > 0)
            {
                int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(comboBox_party.Text));
                int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(comboBox_project.Text));
                if(ZAMSFactory.DataBase.SaveContractParty(partyId,projectId)>0)
                {
                    label_Transaction_error.Text = "Transaction Saved Successfully";
                    label_Transaction_error.Visible = true;
                    textBox_amount.Clear();
                    richTextBox_description.Clear();
                    richTextBox_otherDetails.Clear();
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
            //MessageBox.Show("Hello");
        }

        private void MakeTransaction1(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Hello1");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((sender as TabControl).SelectedIndex) {
            case 0:
                // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                break;
            case 3:
                // Let's suppose TabPage index 1 is the one for the transactions.
                // Assuming you have put a DataGridView control so that the transactions can be listed.
                // currentCustomer.Id can be obtained through the CurrencyManager of your BindingSource object used to data bind your data to your Windows form controls.
               // dataGridview1.DataSource = GetTransactions(currentCustomer.Id);
                   List<Project> lp=ZAMSFactory.DataBase.GetProjects();
                   Project p = new Project();
                   //p.ProjectName = "Select Project";
                   //lp.Add(p);
                    comboBox_project.DataSource = lp;
                    comboBox_project.ValueMember = "ProjectName";
                    comboBox_project.DisplayMember = "ProjectName";
                    comboBox_project.Text = "Select Project";
                    //comboBox_project.SelectedIndex = lp.Count-1;
                   // comboBox_party.Text = "Select Project First";
                List<Party> cp = ZAMSFactory.DataBase.getCompanies1();
                comboBox_party.DataSource = cp;
                comboBox_party.ValueMember = "Id";
                comboBox_party.DisplayMember = "Party_Name";
                comboBox_party.Text = "Select Party";
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
            Project proj=ZAMSFactory.DataBase.GetProjectByName(textBox_searchProjects.Text);
            if (proj != null)
            {
                panel_searchProject.Visible = true;
                textBox_projectName.Text = proj.ProjectName;
                textBox_credit.Text = proj.Credit.ToString();
                textBox_currentBalance.Text = proj.CurrentBalance.ToString();
                textBox_endDate.Text = proj.EndDate.ToString();
                textBox_estEndingDate.Text = proj.EstimatedEndDate.ToString();
                textBox_initialBalance.Text = proj.InitialBalance.ToString();
                textBox_ownerParty.Text = proj.Party.Party_Name;
                textBox_startingDate.Text = proj.StartDate.ToString();
                textBox_status.Text = proj.Status;
                //making fields readonly
                textBox_projectName.ReadOnly = true;
                textBox_credit.ReadOnly = true;
                textBox_currentBalance.ReadOnly = true;
                textBox_endDate.ReadOnly = true;
                textBox_estEndingDate.ReadOnly = true;
                textBox_initialBalance.ReadOnly = true;
                textBox_ownerParty.ReadOnly = true;
                textBox_startingDate.ReadOnly = true;
                textBox_status.ReadOnly = true;


                

                
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            textBox_projectName.ReadOnly = false;
            textBox_credit.ReadOnly = false;
            textBox_currentBalance.ReadOnly = false;
            textBox_endDate.ReadOnly = false;
            textBox_estEndingDate.ReadOnly = false;
            textBox_initialBalance.ReadOnly = false;
            textBox_ownerParty.ReadOnly = false;
            textBox_startingDate.ReadOnly = false;
            textBox_status.ReadOnly = false;
            button_saveChanges.Visible = true;
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            try { long amount = Convert.ToInt64(textBox_amount.Text); }
            catch (Exception ex) { textBox_amount.Text = ""; }
        }

       
        }
    }

