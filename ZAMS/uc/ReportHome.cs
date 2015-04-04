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
    public partial class ReportHome : BaseControl
    {
        public ReportHome()
        {
            InitializeComponent();
        }


        public ReportHome(string title)
            : base(title, "ReportHome")
        {
            InitializeComponent();
        }

        private void ReportHome_Load(object sender, EventArgs e)
        {
            PartyDummy p1 = new PartyDummy();
            p1.Party_Name = "All";
            p1.Id = -1;
            PartyDummy p2 = new PartyDummy();
            p2.Party_Name = "Select Project";
            List<PartyDummy> lp = ZAMSFactory.DataBase.GetCompanies1();
            lp.Add(p1);

            reportcombo_party.DataSource = lp;
            reportcombo_party.ValueMember = "Id";
            reportcombo_party.DisplayMember = "Party_Name";
            reportcombo_party.Text = "Select Party";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportcombo_party_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = Convert.ToString(reportcombo_party.SelectedValue);
            int id = Convert.ToInt32(reportcombo_party.SelectedValue);
            bool a = true;
            label_AmountPaid.Visible = a;
            label_AmountReceived.Visible = a;
            button_viewAll.Visible = a;
            dataGridView1.Visible = false;
            if (id == -1)
            {
                int id1 = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmountAll(id1);
                label_showAmountreceived.Text = Convert.ToString(Amount[1]);
                label_showAmountPaid.Text = Convert.ToString(Amount[0]);
                label_showAmountPaid.Visible = true;
                label_showAmountreceived.Visible = true;
                List<ProjectReprt> pr = ZAMSFactory.DataBase.GetAllProjects(id);
                dataGridView3.DataSource = pr;
                dataGridView3.Visible = true;
            }
            else
            {
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmountAll(id);
                label_showAmountreceived.Text = Convert.ToString(Amount[0]);
                label_showAmountPaid.Text = Convert.ToString(Amount[1]);
                label_showAmountPaid.Visible = true;
                label_showAmountreceived.Visible = true;
                List<ProjectReprt> pr = ZAMSFactory.DataBase.GetAllProjects(id);
                dataGridView3.DataSource = pr;
                dataGridView3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(reportcombo_party.SelectedValue);
            int id = Convert.ToInt32(reportcombo_party.SelectedValue);
            bool a = true;
            dataGridView1.Visible = a;
            // label_AmountPaid.Visible = a;
            //label_AmountReceived.Visible = a;
            if (id == -1)
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionDummy();
                dataGridView1.DataSource = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompany(id);
                dataGridView1.DataSource = transactions;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 1:
                    // Let's suppose TabPage index 1 is the one for the transactions.
                    // Assuming you have put a DataGridView control so that the transactions can be listed.
                    // currentCustomer.Id can be obtained through the CurrencyManager of your BindingSource object used to data bind your data to your Windows form controls.
                    // dataGridview1.DataSource = GetTransactions(currentCustomer.Id);
                    List<Project> lp = ZAMSFactory.DataBase.GetProjects();
                    Project p = new Project();
                    p.ProjectName = "All";
                    p.Id = -1;
                    lp.Add(p);
                    comboBox2.DataSource = lp;
                    comboBox2.ValueMember = "Id";
                    comboBox2.DisplayMember = "ProjectName";
                    //comboBox2.SelectedIndex = lp.Count-1;

                    comboBox2.Text = "Select Project";
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBox2.SelectedValue);
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            bool a = true;
            dataGridView2.Visible = a;
            // label_AmountPaid.Visible = a;
            //label_AmountReceived.Visible = a;
            if (id == -1)
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionDummy();
                dataGridView2.DataSource = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByProject(id);
                dataGridView2.DataSource = transactions;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBox2.SelectedValue);
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            bool a = true;
            label3.Visible = a;
            label5.Visible = a;
            label_profit.Visible = a;
            button1.Visible = a;
            dataGridView2.Visible = false;
            if (id == -1)
            {
                int id1 = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmountAllproject();
                label4.Text = Convert.ToString(Amount[0]);
                label6.Text = Convert.ToString(Amount[1]);
                label7.Text = Convert.ToString(Amount[1]-Amount[0]);
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                List<PartyReport> pr=ZAMSFactory.DataBase.getPartyReport(id);
                dataGridView4.DataSource = pr;
                dataGridView4.Visible = true;
            }
            else
            {
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmount(id);
                label4.Text = Convert.ToString(Amount[0]);
                label6.Text = Convert.ToString(Amount[1]);
                label7.Text = Convert.ToString(Amount[1] - Amount[0]);
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                List<PartyReport> pr = ZAMSFactory.DataBase.getPartyReport(id);
                dataGridView4.DataSource = pr;
                dataGridView4.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
