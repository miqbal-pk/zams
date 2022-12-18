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

namespace ZAMS.uc
{
    public partial class Banks : BaseControl
    {
        public Banks()
        {
            InitializeComponent();
        }
        public Banks(string title):base(title, "Companies")
        {
            InitializeComponent();
        }
        private void Banks_Load(object sender, EventArgs e)
        {
            List<BankDummy> bd=ZAMSFactory.DataBase.GetBanks();
            if (bd.Count != 0)
            {
                dataGridView_viewBanks.DataSource = bd;
                
            }
        }

        private void button_SaveBank_Click(object sender, EventArgs e)
        {
            if (textBox_BankName.Text.Equals("") || textBox_Branch.Text.Equals("") || textBox_AccountNumber.Equals("") || textBox_AccountTitle.Text.Equals("") || textBox_BankBalance.Text.Equals(""))
            {
                label_BankStatus.Text="Please fill the required fields";
                label_BankStatus.Visible = true;
                return;
            }
            Bank bank = new Bank();
            bank.AccountNumber = textBox_AccountNumber.Text;
            bank.AccountTitle = textBox_AccountTitle.Text;
            bank.Balance = long.Parse(textBox_BankBalance.Text);
            bank.BankName = textBox_BankName.Text;
            bank.Branch = textBox_Branch.Text;
            bank.PhoneNumber = textBox_phoneNumber.Text;
            bank.Address = textBox_BankAddress.Text;
            int status=ZAMSFactory.DataBase.SaveBank(bank);
            if(status==-999)
                label_BankStatus.Text = "This account already exist";
            else if (status > 0)
            {
                label_BankStatus.Text = "Bank Details Saved Successfully";
            }
            else
                label_BankStatus.Text = "Error occured while saving the details please try again";
            label_BankStatus.Visible = true;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    List<BankDummy> bd=ZAMSFactory.DataBase.GetBanks();
                     if (bd.Count != 0)
                     {
                           dataGridView_viewBanks.DataSource = bd;
                
                     }
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 1:
                        List<String> bankName = ZAMSFactory.DataBase.GetBankNames();
                        bankName.Add("Select Bank");
                        panel_edit.Visible = false;
                        comboBox_Bank.DataSource = bankName;
                        comboBox_Bank.SelectedIndex = bankName.Count - 1;
                        comboBox_AccountNo.DataSource = null;
                        comboBox_Branch.DataSource = null;
                        comboBox_AccountNo.Visible = false;
                        comboBox_Branch.Visible = false;
                        label_AccountNo.Visible = false;
                        label2_branch.Visible = false;
                    break;
            }
        }

        private void tabPage_SearchBanks_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_branch_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Bank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            String bankName=comboBox_Bank.SelectedValue.ToString();
            List<String> branchName = ZAMSFactory.DataBase.GetBranchNames(bankName);
            branchName.Add("Select Branch");
            comboBox_Branch.DataSource = branchName;
            comboBox_Branch.SelectedIndex = branchName.Count - 1;
            comboBox_Branch.Visible = true;
            label2_branch.Visible = true;
            comboBox_AccountNo.DataSource = null;
            comboBox_AccountNo.Visible = false;
            label_AccountNo.Visible = false;
            //comboBox_AccountNo
        }

        private void comboBox_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            String bankName = comboBox_Bank.SelectedValue.ToString();
            String branchName = comboBox_Branch.SelectedValue.ToString();
            List<String> AccountNo = ZAMSFactory.DataBase.GetAccountNo(bankName,branchName);
            AccountNo.Add("Select AccountNo");
            comboBox_AccountNo.DataSource = AccountNo;
            comboBox_AccountNo.SelectedIndex = AccountNo.Count - 1;
            comboBox_AccountNo.Visible = true;
            label_AccountNo.Visible = true;
        }

        private void comboBox_AccountNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String bankName = comboBox_Bank.SelectedValue.ToString();
            String branchName = comboBox_Branch.SelectedValue.ToString();
            String AccountNo = comboBox_AccountNo.SelectedValue.ToString();
            Bank b = ZAMSFactory.DataBase.GetSpecificAccountInfo(bankName, branchName, AccountNo);
            if (b != null)
            {
                panel_edit.Visible = true;
                textBox_BankNameEdit.Text = b.BankName;
                textBox_branchEdit.Text = b.Branch;
                textBox_PhoneNumberEdit.Text = b.PhoneNumber;
                textBox_BalanceEdit.Text = String.Format("{0:n}", b.Balance);
                textBox_AccountTitleEdit.Text = b.AccountTitle;
                textBox_AccountNumberEdit.Text = b.AccountNumber;
                textBox_AddressEdit.Text = b.Address;
                //
                textBox_BankNameEdit.ReadOnly = true;
                textBox_branchEdit.ReadOnly = true;
                textBox_PhoneNumberEdit.ReadOnly = true;
                textBox_BalanceEdit.ReadOnly = true;
                textBox_AccountTitleEdit.ReadOnly = true;
                textBox_AccountNumberEdit.ReadOnly = true;
                textBox_AddressEdit.ReadOnly = true;
            }
        }
    }
}
