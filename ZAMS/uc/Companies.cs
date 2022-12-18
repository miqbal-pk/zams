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
    public partial class Companies : BaseControl
    {
        List<PartyDummy> parties;
        public Companies()
        {
            InitializeComponent();
        }

        public Companies(string title):base(title, "Companies")
        {
            InitializeComponent();
        }

        private void link_AddCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ParentForm pf=(ParentForm)this.Parent.Parent.Parent;
            pf.LoadUserControl("NewCompany");
        }

        private void Companies_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Companies_Load(object sender, EventArgs e)
        {
            parties=ZAMSFactory.DataBase.GetCompanies();
            //gridView_companies.DataSource = parties;
            //gridView_companies.DataSource = parties;
            textBox_searchCompanies.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_searchCompanies.AutoCompleteSource = AutoCompleteSource.CustomSource;
            gridView_companies.Rows.Clear();
            foreach (PartyDummy p in parties)
            {
                textBox_searchCompanies.AutoCompleteCustomSource.Add(p.Party_Name);
                gridView_companies.Rows.Add(p.Id , p.CNIC_NTN , p.Party_Name, p.OwnerName, p.CompanyBalance,p.CompanyType, p.PhoneNumber, p.Location, p.Email, p.FaxNumber);
            }
            gridView_companies.Columns["Id"].ReadOnly = true;
            gridView_companies.Columns["Party_Name"].ReadOnly = true;
            gridView_companies.Columns["Location"].ReadOnly = true;
            gridView_companies.Columns["PhoneNumber"].ReadOnly = true;
            gridView_companies.Columns["FaxNumber"].ReadOnly = true;
            gridView_companies.Columns["OwnerName"].ReadOnly = true;
            gridView_companies.Columns["Email"].ReadOnly = true;
            gridView_companies.Columns["CompanyBalance"].ReadOnly = true;
            gridView_companies.Columns["CompanyType"].ReadOnly = true;
           
            
            
        }
        void AddSuggestionForCompanies(Party pd)
        {
            textBox_searchCompanies.AutoCompleteCustomSource.Add(pd.Party_Name);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_companyName.Text.Equals(""))
            {
                label_Vendor_Status.Text = "Please fill fields with *";
                return;
            }
            Party party = new Party();
            party.Party_Name = tb_companyName.Text;
            party.CNIC_NTN = Vender_CNIC.Text;
            party.OwnerName = tb_ownerName.Text;
            party.Location = tb_address.Text;
            party.PhoneNumber = tb_phoneNumber.Text;
            party.Email = tb_email.Text;
            party.FaxNumber = tb_faxNo.Text;
            party.CompanyType = "Vendor";
            int status=ZAMSFactory.DataBase.SaveCompany(party);
            if (status > 0)
            {
                label_Vendor_Status.Text = "Vendor's Detail Saved Successfully";
                Party p = party;
                //Companies_Load(sender,e);
                gridView_companies.Rows.Add(p.Id, p.Party_Name, p.OwnerName,p.CompanyBalance,p.CompanyType, p.PhoneNumber, p.Location, p.Email, p.FaxNumber);
                AddSuggestionForCompanies(p);
                tb_companyName.Text = "";
                tb_address.Text = "";
                tb_ownerName.Text = "";
                tb_phoneNumber.Text = "";
                tb_email.Text = "";
                tb_faxNo.Text = "";
          
            }
            else
            {
                label_Vendor_Status.Text = "Saving Failed!";
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_searchCompanies_Click(object sender, EventArgs e)
        {
            label_noCompany.Visible = false;
            label_edit_status.Visible = false;
            if (textBox_searchCompanies.Text.Equals(""))
                return;
            Party party=ZAMSFactory.DataBase.GetCompanyByName(textBox_searchCompanies.Text);
            if (party != null)
            {
                panel_searchCompanies.Visible = true;
                textBox_CompanyName.Text = party.Party_Name;
                textBox_ownerName.Text = party.OwnerName;
                textBox_phone.Text = party.PhoneNumber;
                textBox_fax.Text = party.FaxNumber;
                textBox_email.Text = party.Email;
                textBox_address.Text = party.Location;
                label_companyType.Text = party.CompanyType;
                label_company_id.Text = party.Id.ToString();
                label_CompanyBalance.Text = String.Format("{0:n}", party.CompanyBalance);
                label_CompanyBalance.Visible = true;
                //making fields readonly
                textBox_CompanyName.ReadOnly = true;
                textBox_ownerName.ReadOnly = true;
                textBox_phone.ReadOnly = true;
                textBox_fax.ReadOnly = true;
                textBox_email.ReadOnly = true;
                textBox_address.ReadOnly = true;
                //label_companyType.ReadOnly
                //label_companyType.Visible = true;

            }
            else
            {
                panel_searchCompanies.Visible = false;
                label_noCompany.Text = "Invalid Company Name";
                label_noCompany.Visible = true;
            }
        }

        private void button_editCompany_Click(object sender, EventArgs e)
        {
            button_saveCompanyEdit.Visible = true;
           // textBox_CompanyName.ReadOnly = false;
            textBox_ownerName.ReadOnly = false;
            textBox_phone.ReadOnly = false;
            textBox_fax.ReadOnly = false;
            textBox_email.ReadOnly = false;
            textBox_address.ReadOnly = false;
        }

        private void button_saveCompanyEdit_Click(object sender, EventArgs e)
        {
            Party party = new Party();
            party.Id = int.Parse(label_company_id.Text);
            party.Party_Name = textBox_CompanyName.Text;
            party.OwnerName = textBox_ownerName.Text;
            party.PhoneNumber = textBox_phone.Text;
            party.FaxNumber = textBox_fax.Text;
            party.Email = textBox_email.Text;
            party.Location = textBox_address.Text;
            int status = ZAMSFactory.DataBase.SaveEditCompany(party);
            if (status > 0)
            {
                label_edit_status.Text = "Changes saved successfully";
                label_edit_status.Visible = true;
                Companies_Load(new object(), new EventArgs());
                panel_searchCompanies.Visible = false;
                //InitializeComponent();
                //Party p = party;
                //gridView_companies.Rows.Add(p.Id, p.Party_Name, p.OwnerName, p.PhoneNumber, p.Location, p.Email, p.FaxNumber);
                //AddSuggestionForCompanies(p);
            }
            else
            {
                label_edit_status.Text = "Operation failed";
                label_edit_status.Visible = true;
            }
                    
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel_searchCompanies_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tb_clientCompany.Text.Equals(""))
            {
                label_client_status.Text = "Please fill fields with *";
                label_client_status.Visible = true;
                return;
            }
            Party party = new Party();
            party.Party_Name = tb_clientCompany.Text;
            party.CNIC_NTN = Client_CNIC_NTN.Text;
            party.OwnerName = tb_clientName.Text;
            party.Location = tb_clientAddress.Text;
            party.PhoneNumber = tb_clientPhoneNo.Text;
            party.Email = tb_clientEmail.Text;
            party.FaxNumber = tb_clientFax.Text;
            party.CompanyType = "Client";
            int status = ZAMSFactory.DataBase.SaveCompany(party);
            if (status > 0)
            {
                label_client_status.Text = "Client's Detail Saved Successfully";
                Party p = party;
                //Companies_Load(sender,e);
                gridView_companies.Rows.Add(p.Id, p.Party_Name, p.OwnerName, p.CompanyBalance,p.CompanyType, p.PhoneNumber, p.Location, p.Email, p.FaxNumber);
                AddSuggestionForCompanies(p);
                tb_clientCompany.Text = "";
                tb_clientAddress.Text = "";
                tb_clientName.Text = "";
                tb_clientPhoneNo.Text = "";
                tb_clientEmail.Text = "";
                tb_clientFax.Text = "";

            }
            else
            {
                label_client_status.Text = "Saving Failed!";
            }
            label_client_status.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_balance_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox_BankAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_BankAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
