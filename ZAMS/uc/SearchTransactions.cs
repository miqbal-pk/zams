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

namespace ZAMS
{
    public partial class SearchTransactions : BaseControl
    {
       
        public SearchTransactions()
        {
            InitializeComponent();
        }


        public SearchTransactions(string title)
            : base(title, "SearchTransactions")
        {
            InitializeComponent();
        }

        private void SearchTransactions_Load(object sender, EventArgs e)
        {
            List<Project> projects= ZAMSFactory.DataBase.GetProjects();
            Project p = new Project();
            p.ProjectName = "All";
            p.Id = -1;
            projects.Add(p);
            comboBox_project1.DataSource = projects;
            comboBox_project1.ValueMember = "Id";
            comboBox_project1.DisplayMember = "ProjectName";
            comboBox_project1.SelectedIndex = projects.Count - 1;
            List<Party> cp = ZAMSFactory.DataBase.getCompanies1();
            Party party = new Party();
            party.Party_Name = "All";
            party.Id = -1;
            cp.Add(party);
            comboBox_party1.DataSource = cp;
            comboBox_party1.ValueMember = "Id";
            comboBox_party1.DisplayMember = "Party_Name";
            comboBox_party1.SelectedIndex = cp.Count - 1;
        }

        private void comboBox_project_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void comboBox_project_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(comboBox_project1.SelectedValue);

                if (name.Equals("All"))
                {
                    List<Party> cp = ZAMSFactory.DataBase.getCompanies1();
                    Party p = new Party();
                    p.Party_Name = "All";
                    p.Id = -1;
                    cp.Add(p);
                    comboBox_party1.DataSource = cp;
                    comboBox_party1.ValueMember = "Id";
                    comboBox_party1.DisplayMember = "Party_Name";
                    comboBox_party1.SelectedIndex = cp.Count - 1;

                }
                else
                {

                    List<Party> cp = ZAMSFactory.DataBase.getContractParty(name);
                    Party p = new Party();
                    p.Party_Name = "All";
                    p.Id = -1;
                    cp.Add(p);
                    comboBox_party1.DataSource = cp;
                    comboBox_party1.ValueMember = "Id";
                    comboBox_party1.DisplayMember = "Party_Name";

                    comboBox_party1.SelectedIndex = cp.Count - 1;
                }
            }
            catch (Exception exception)
            {
                string message = exception.Message;
            }

        }

        private void button_getTransactions_Click(object sender, EventArgs e)
        {
            DateTime startDate = picker_startingDate.Value.Date;
            DateTime endDate = picker_endingDate.Value.Date;
            endDate=endDate.AddHours(23);
            endDate=endDate.AddMinutes(59);
            endDate=endDate.AddSeconds(59);
            //endDate.TimeOfDay = "11:59";
            //MessageBox.Show(endDate.TimeOfDay);
            string projectName = Convert.ToString(comboBox_project1.SelectedValue);
            string partyName = Convert.ToString(comboBox_party1.SelectedValue);
            int cid = Convert.ToInt32(comboBox_party1.SelectedValue);
            int pid = Convert.ToInt32(comboBox_project1.SelectedValue);

            if (projectName.Equals("-1") && partyName.Equals("-1"))
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.getTransactionByTime(startDate, endDate);
                dataGridView_transactions.DataSource = transactions;
            }
            else if((projectName.Equals("-1")))
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompany(cid);
                dataGridView_transactions.DataSource = transactions;
 
            }
            else if (partyName.Equals("-1"))
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByProject(pid);
                dataGridView_transactions.DataSource = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompanyAndProject(cid,pid);
                dataGridView_transactions.DataSource = transactions;
            }
            //int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(projectName));
            //int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(partyName));
            //List<Transaction> transactions = ZAMSFactory.DataBase.getTransactions(startDate,endDate,projectId,partyId);
        }
    }

    
}
