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
            textBox_searchCompanies .AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_searchCompanies.AutoCompleteSource = AutoCompleteSource.CustomSource;        
            foreach (PartyDummy p in parties)
            {
                textBox_searchCompanies.AutoCompleteCustomSource.Add(p.Party_Name);
                gridView_companies.Rows.Add(p.Id,p.Party_Name,p.OwnerName,p.PhoneNumber,p.Location,p.Email,p.FaxNumber);
            }
            gridView_companies.Columns["Id"].ReadOnly = true;
            gridView_companies.Columns["Party_Name"].ReadOnly = true;
            gridView_companies.Columns["Location"].ReadOnly = true;
            gridView_companies.Columns["PhoneNumber"].ReadOnly = true;
            gridView_companies.Columns["FaxNumber"].ReadOnly = true;
            gridView_companies.Columns["OwnerName"].ReadOnly = true;
            gridView_companies.Columns["Email"].ReadOnly = true;
            
           
            
            
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
            Party party = new Party();
            party.Party_Name = tb_companyName.Text;
            party.OwnerName = tb_ownerName.Text;
            party.Location = tb_address.Text;
            party.PhoneNumber = tb_phoneNumber.Text;
            party.Email = tb_email.Text;
            party.FaxNumber = tb_faxNo.Text;
            int status=ZAMSFactory.DataBase.SaveCompany(party);
            if (status > 0)
            {
                label_status.Text = "Company Saved Successfully";
                Party p = party;
                gridView_companies.Rows.Add(p.Id, p.Party_Name, p.OwnerName, p.PhoneNumber, p.Location, p.Email, p.FaxNumber);
                AddSuggestionForCompanies(p);
                
          
            }
            else
            {
                label_status.Text = "Saving Failed!";
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_searchCompanies_Click(object sender, EventArgs e)
        {
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
                //making fields readonly
                textBox_CompanyName.ReadOnly = true;
                textBox_ownerName.ReadOnly = true;
                textBox_phone.ReadOnly = true;
                textBox_fax.ReadOnly = true;
                textBox_email.ReadOnly = true;
                textBox_address.ReadOnly = true;

            }
        }

        private void button_editCompany_Click(object sender, EventArgs e)
        {
            button_saveCompanyEdit.Visible = true;
            textBox_CompanyName.ReadOnly = false;
            textBox_ownerName.ReadOnly = false;
            textBox_phone.ReadOnly = false;
            textBox_fax.ReadOnly = false;
            textBox_email.ReadOnly = false;
            textBox_address.ReadOnly = false;
        }
    }
}
