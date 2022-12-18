namespace ZAMS
{
    partial class Companies
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.link_AddCompany = new System.Windows.Forms.LinkLabel();
            this.NewCompany = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridView_companies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC_NTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Party_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_noCompany = new System.Windows.Forms.Label();
            this.label_edit_status = new System.Windows.Forms.Label();
            this.panel_searchCompanies = new System.Windows.Forms.Panel();
            this.label_companyType = new System.Windows.Forms.Label();
            this.label_CompanyBalance = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_company_id = new System.Windows.Forms.Label();
            this.button_editCompany = new System.Windows.Forms.Button();
            this.button_saveCompanyEdit = new System.Windows.Forms.Button();
            this.textBox_fax = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_ownerName = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_CompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_searchCompanies = new System.Windows.Forms.Button();
            this.textBox_searchCompanies = new System.Windows.Forms.TextBox();
            this.label_SelectCompany = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Vender_Cnic_label = new System.Windows.Forms.Label();
            this.Vender_CNIC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_Vendor_Status = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_saveCompany = new System.Windows.Forms.Button();
            this.tb_faxNo = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phoneNumber = new System.Windows.Forms.TextBox();
            this.tb_ownerName = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_companyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CnicNtnLabel = new System.Windows.Forms.Label();
            this.Client_CNIC_NTN = new System.Windows.Forms.TextBox();
            this.label_client_status = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button_saveClient = new System.Windows.Forms.Button();
            this.tb_clientFax = new System.Windows.Forms.TextBox();
            this.tb_clientEmail = new System.Windows.Forms.TextBox();
            this.tb_clientPhoneNo = new System.Windows.Forms.TextBox();
            this.tb_clientName = new System.Windows.Forms.TextBox();
            this.tb_clientAddress = new System.Windows.Forms.TextBox();
            this.tb_clientCompany = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.NewCompany.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_companies)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_searchCompanies.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_AddCompany
            // 
            this.link_AddCompany.AutoSize = true;
            this.link_AddCompany.Location = new System.Drawing.Point(423, 26);
            this.link_AddCompany.Name = "link_AddCompany";
            this.link_AddCompany.Size = new System.Drawing.Size(60, 13);
            this.link_AddCompany.TabIndex = 2;
            this.link_AddCompany.TabStop = true;
            this.link_AddCompany.Text = "+ Company";
            this.link_AddCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_AddCompany_LinkClicked);
            // 
            // NewCompany
            // 
            this.NewCompany.Controls.Add(this.tabPage1);
            this.NewCompany.Controls.Add(this.tabPage2);
            this.NewCompany.Controls.Add(this.tabPage3);
            this.NewCompany.Controls.Add(this.tabPage4);
            this.NewCompany.Location = new System.Drawing.Point(-1, 26);
            this.NewCompany.Name = "NewCompany";
            this.NewCompany.SelectedIndex = 0;
            this.NewCompany.Size = new System.Drawing.Size(1024, 690);
            this.NewCompany.TabIndex = 3;
            this.NewCompany.Enter += new System.EventHandler(this.Companies_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridView_companies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Client & Vendor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridView_companies
            // 
            this.gridView_companies.AllowUserToAddRows = false;
            this.gridView_companies.AllowUserToDeleteRows = false;
            this.gridView_companies.AllowUserToResizeColumns = false;
            this.gridView_companies.AllowUserToResizeRows = false;
            this.gridView_companies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView_companies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridView_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_companies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CNIC_NTN,
            this.Party_Name,
            this.OwnerName,
            this.CompanyBalance,
            this.CompanyType,
            this.PhoneNumber,
            this.Location,
            this.Email,
            this.FaxNumber});
            this.gridView_companies.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridView_companies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_companies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView_companies.Location = new System.Drawing.Point(3, 3);
            this.gridView_companies.Name = "gridView_companies";
            this.gridView_companies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridView_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView_companies.Size = new System.Drawing.Size(1010, 658);
            this.gridView_companies.TabIndex = 0;
            this.gridView_companies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 41;
            // 
            // CNIC_NTN
            // 
            this.CNIC_NTN.HeaderText = "CNIC/NTN";
            this.CNIC_NTN.MaxInputLength = 15;
            this.CNIC_NTN.Name = "CNIC_NTN";
            this.CNIC_NTN.Width = 85;
            // 
            // Party_Name
            // 
            this.Party_Name.HeaderText = "Party Name";
            this.Party_Name.Name = "Party_Name";
            this.Party_Name.Width = 80;
            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "Owner Name";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Width = 87;
            // 
            // CompanyBalance
            // 
            this.CompanyBalance.HeaderText = "Company Balance";
            this.CompanyBalance.Name = "CompanyBalance";
            this.CompanyBalance.Width = 108;
            // 
            // CompanyType
            // 
            this.CompanyType.HeaderText = "Company Type";
            this.CompanyType.Name = "CompanyType";
            this.CompanyType.ReadOnly = true;
            this.CompanyType.Width = 95;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 95;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 73;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // FaxNumber
            // 
            this.FaxNumber.HeaderText = "Fax Number";
            this.FaxNumber.Name = "FaxNumber";
            this.FaxNumber.Width = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_noCompany);
            this.tabPage2.Controls.Add(this.label_edit_status);
            this.tabPage2.Controls.Add(this.panel_searchCompanies);
            this.tabPage2.Controls.Add(this.button_searchCompanies);
            this.tabPage2.Controls.Add(this.textBox_searchCompanies);
            this.tabPage2.Controls.Add(this.label_SelectCompany);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_noCompany
            // 
            this.label_noCompany.AutoSize = true;
            this.label_noCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noCompany.ForeColor = System.Drawing.Color.Red;
            this.label_noCompany.Location = new System.Drawing.Point(357, 128);
            this.label_noCompany.Name = "label_noCompany";
            this.label_noCompany.Size = new System.Drawing.Size(0, 13);
            this.label_noCompany.TabIndex = 43;
            this.label_noCompany.Visible = false;
            // 
            // label_edit_status
            // 
            this.label_edit_status.AutoSize = true;
            this.label_edit_status.BackColor = System.Drawing.Color.White;
            this.label_edit_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edit_status.Location = new System.Drawing.Point(163, 124);
            this.label_edit_status.Name = "label_edit_status";
            this.label_edit_status.Size = new System.Drawing.Size(132, 17);
            this.label_edit_status.TabIndex = 42;
            this.label_edit_status.Text = "label_edit_status";
            this.label_edit_status.Visible = false;
            // 
            // panel_searchCompanies
            // 
            this.panel_searchCompanies.Controls.Add(this.label_companyType);
            this.panel_searchCompanies.Controls.Add(this.label_CompanyBalance);
            this.panel_searchCompanies.Controls.Add(this.label_balance);
            this.panel_searchCompanies.Controls.Add(this.label_company_id);
            this.panel_searchCompanies.Controls.Add(this.button_editCompany);
            this.panel_searchCompanies.Controls.Add(this.button_saveCompanyEdit);
            this.panel_searchCompanies.Controls.Add(this.textBox_fax);
            this.panel_searchCompanies.Controls.Add(this.textBox_email);
            this.panel_searchCompanies.Controls.Add(this.textBox_phone);
            this.panel_searchCompanies.Controls.Add(this.textBox_ownerName);
            this.panel_searchCompanies.Controls.Add(this.textBox_address);
            this.panel_searchCompanies.Controls.Add(this.textBox_CompanyName);
            this.panel_searchCompanies.Controls.Add(this.label1);
            this.panel_searchCompanies.Controls.Add(this.label2);
            this.panel_searchCompanies.Controls.Add(this.label3);
            this.panel_searchCompanies.Controls.Add(this.label4);
            this.panel_searchCompanies.Controls.Add(this.label5);
            this.panel_searchCompanies.Controls.Add(this.label6);
            this.panel_searchCompanies.Location = new System.Drawing.Point(6, 154);
            this.panel_searchCompanies.Name = "panel_searchCompanies";
            this.panel_searchCompanies.Size = new System.Drawing.Size(666, 313);
            this.panel_searchCompanies.TabIndex = 3;
            this.panel_searchCompanies.Visible = false;
            this.panel_searchCompanies.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_searchCompanies_Paint);
            // 
            // label_companyType
            // 
            this.label_companyType.AutoSize = true;
            this.label_companyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_companyType.Location = new System.Drawing.Point(177, 32);
            this.label_companyType.Name = "label_companyType";
            this.label_companyType.Size = new System.Drawing.Size(35, 13);
            this.label_companyType.TabIndex = 44;
            this.label_companyType.Text = "Type";
            // 
            // label_CompanyBalance
            // 
            this.label_CompanyBalance.AutoSize = true;
            this.label_CompanyBalance.Location = new System.Drawing.Point(487, 71);
            this.label_CompanyBalance.Name = "label_CompanyBalance";
            this.label_CompanyBalance.Size = new System.Drawing.Size(45, 13);
            this.label_CompanyBalance.TabIndex = 43;
            this.label_CompanyBalance.Text = "balance";
            this.label_CompanyBalance.Visible = false;
            this.label_CompanyBalance.Click += new System.EventHandler(this.label15_Click);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_balance.Location = new System.Drawing.Point(373, 71);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(108, 13);
            this.label_balance.TabIndex = 42;
            this.label_balance.Text = "Company Balance";
            this.label_balance.Click += new System.EventHandler(this.label_balance_Click);
            // 
            // label_company_id
            // 
            this.label_company_id.AutoSize = true;
            this.label_company_id.Location = new System.Drawing.Point(3, 9);
            this.label_company_id.Name = "label_company_id";
            this.label_company_id.Size = new System.Drawing.Size(92, 13);
            this.label_company_id.TabIndex = 41;
            this.label_company_id.Text = "label_company_id";
            this.label_company_id.Visible = false;
            // 
            // button_editCompany
            // 
            this.button_editCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editCompany.Location = new System.Drawing.Point(444, 22);
            this.button_editCompany.Name = "button_editCompany";
            this.button_editCompany.Size = new System.Drawing.Size(75, 23);
            this.button_editCompany.TabIndex = 40;
            this.button_editCompany.Text = "Edit";
            this.button_editCompany.UseVisualStyleBackColor = true;
            this.button_editCompany.Click += new System.EventHandler(this.button_editCompany_Click);
            // 
            // button_saveCompanyEdit
            // 
            this.button_saveCompanyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveCompanyEdit.Location = new System.Drawing.Point(180, 261);
            this.button_saveCompanyEdit.Name = "button_saveCompanyEdit";
            this.button_saveCompanyEdit.Size = new System.Drawing.Size(440, 41);
            this.button_saveCompanyEdit.TabIndex = 39;
            this.button_saveCompanyEdit.Text = "Save Changes";
            this.button_saveCompanyEdit.UseVisualStyleBackColor = true;
            this.button_saveCompanyEdit.Visible = false;
            this.button_saveCompanyEdit.Click += new System.EventHandler(this.button_saveCompanyEdit_Click);
            // 
            // textBox_fax
            // 
            this.textBox_fax.Location = new System.Drawing.Point(480, 206);
            this.textBox_fax.Name = "textBox_fax";
            this.textBox_fax.Size = new System.Drawing.Size(152, 20);
            this.textBox_fax.TabIndex = 38;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(180, 206);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(167, 20);
            this.textBox_email.TabIndex = 37;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(480, 112);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(152, 20);
            this.textBox_phone.TabIndex = 36;
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.Location = new System.Drawing.Point(180, 119);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.Size = new System.Drawing.Size(167, 20);
            this.textBox_ownerName.TabIndex = 35;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(180, 169);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(440, 20);
            this.textBox_address.TabIndex = 34;
            // 
            // textBox_CompanyName
            // 
            this.textBox_CompanyName.Location = new System.Drawing.Point(180, 64);
            this.textBox_CompanyName.Name = "textBox_CompanyName";
            this.textBox_CompanyName.Size = new System.Drawing.Size(167, 20);
            this.textBox_CompanyName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fax No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Owner\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Compnay Name";
            // 
            // button_searchCompanies
            // 
            this.button_searchCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchCompanies.Location = new System.Drawing.Point(450, 77);
            this.button_searchCompanies.Name = "button_searchCompanies";
            this.button_searchCompanies.Size = new System.Drawing.Size(75, 20);
            this.button_searchCompanies.TabIndex = 2;
            this.button_searchCompanies.Text = "Search";
            this.button_searchCompanies.UseVisualStyleBackColor = true;
            this.button_searchCompanies.Click += new System.EventHandler(this.button_searchCompanies_Click);
            // 
            // textBox_searchCompanies
            // 
            this.textBox_searchCompanies.Location = new System.Drawing.Point(189, 77);
            this.textBox_searchCompanies.Name = "textBox_searchCompanies";
            this.textBox_searchCompanies.Size = new System.Drawing.Size(218, 20);
            this.textBox_searchCompanies.TabIndex = 1;
            this.textBox_searchCompanies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_SelectCompany
            // 
            this.label_SelectCompany.AutoSize = true;
            this.label_SelectCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectCompany.Location = new System.Drawing.Point(53, 77);
            this.label_SelectCompany.Name = "label_SelectCompany";
            this.label_SelectCompany.Size = new System.Drawing.Size(128, 13);
            this.label_SelectCompany.TabIndex = 0;
            this.label_SelectCompany.Text = "Enter Company Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 664);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Vendor";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Vender_Cnic_label);
            this.panel2.Controls.Add(this.Vender_CNIC);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label_Vendor_Status);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button_saveCompany);
            this.panel2.Controls.Add(this.tb_faxNo);
            this.panel2.Controls.Add(this.tb_email);
            this.panel2.Controls.Add(this.tb_phoneNumber);
            this.panel2.Controls.Add(this.tb_ownerName);
            this.panel2.Controls.Add(this.tb_address);
            this.panel2.Controls.Add(this.tb_companyName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 600);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Vender_Cnic_label
            // 
            this.Vender_Cnic_label.AutoSize = true;
            this.Vender_Cnic_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vender_Cnic_label.Location = new System.Drawing.Point(370, 118);
            this.Vender_Cnic_label.Name = "Vender_Cnic_label";
            this.Vender_Cnic_label.Size = new System.Drawing.Size(68, 13);
            this.Vender_Cnic_label.TabIndex = 49;
            this.Vender_Cnic_label.Text = "CNIC/NTN";
            // 
            // Vender_CNIC
            // 
            this.Vender_CNIC.Location = new System.Drawing.Point(465, 114);
            this.Vender_CNIC.MaxLength = 15;
            this.Vender_CNIC.Name = "Vender_CNIC";
            this.Vender_CNIC.Size = new System.Drawing.Size(152, 20);
            this.Vender_CNIC.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(91, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "All fields with * are required";
            // 
            // label_Vendor_Status
            // 
            this.label_Vendor_Status.AutoSize = true;
            this.label_Vendor_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vendor_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Vendor_Status.Location = new System.Drawing.Point(174, 390);
            this.label_Vendor_Status.Name = "label_Vendor_Status";
            this.label_Vendor_Status.Size = new System.Drawing.Size(0, 17);
            this.label_Vendor_Status.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(229, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Vendor\'s Details";
            // 
            // button_saveCompany
            // 
            this.button_saveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveCompany.Location = new System.Drawing.Point(177, 308);
            this.button_saveCompany.Name = "button_saveCompany";
            this.button_saveCompany.Size = new System.Drawing.Size(440, 41);
            this.button_saveCompany.TabIndex = 26;
            this.button_saveCompany.Text = "Save";
            this.button_saveCompany.UseVisualStyleBackColor = true;
            this.button_saveCompany.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_faxNo
            // 
            this.tb_faxNo.Location = new System.Drawing.Point(465, 253);
            this.tb_faxNo.Name = "tb_faxNo";
            this.tb_faxNo.Size = new System.Drawing.Size(152, 20);
            this.tb_faxNo.TabIndex = 25;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(177, 253);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(167, 20);
            this.tb_email.TabIndex = 24;
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Location = new System.Drawing.Point(465, 166);
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(152, 20);
            this.tb_phoneNumber.TabIndex = 23;
            // 
            // tb_ownerName
            // 
            this.tb_ownerName.Location = new System.Drawing.Point(177, 166);
            this.tb_ownerName.Name = "tb_ownerName";
            this.tb_ownerName.Size = new System.Drawing.Size(167, 20);
            this.tb_ownerName.TabIndex = 22;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(177, 216);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(440, 20);
            this.tb_address.TabIndex = 21;
            // 
            // tb_companyName
            // 
            this.tb_companyName.Location = new System.Drawing.Point(177, 111);
            this.tb_companyName.Name = "tb_companyName";
            this.tb_companyName.Size = new System.Drawing.Size(167, 20);
            this.tb_companyName.TabIndex = 20;
            this.tb_companyName.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fax No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Owner\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Compnay Name *";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1016, 664);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Client";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CnicNtnLabel);
            this.panel1.Controls.Add(this.Client_CNIC_NTN);
            this.panel1.Controls.Add(this.label_client_status);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button_saveClient);
            this.panel1.Controls.Add(this.tb_clientFax);
            this.panel1.Controls.Add(this.tb_clientEmail);
            this.panel1.Controls.Add(this.tb_clientPhoneNo);
            this.panel1.Controls.Add(this.tb_clientName);
            this.panel1.Controls.Add(this.tb_clientAddress);
            this.panel1.Controls.Add(this.tb_clientCompany);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CnicNtnLabel
            // 
            this.CnicNtnLabel.AutoSize = true;
            this.CnicNtnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnicNtnLabel.Location = new System.Drawing.Point(334, 134);
            this.CnicNtnLabel.Name = "CnicNtnLabel";
            this.CnicNtnLabel.Size = new System.Drawing.Size(68, 13);
            this.CnicNtnLabel.TabIndex = 47;
            this.CnicNtnLabel.Text = "CNIC/NTN";
            // 
            // Client_CNIC_NTN
            // 
            this.Client_CNIC_NTN.Location = new System.Drawing.Point(408, 127);
            this.Client_CNIC_NTN.Name = "Client_CNIC_NTN";
            this.Client_CNIC_NTN.Size = new System.Drawing.Size(175, 20);
            this.Client_CNIC_NTN.TabIndex = 46;
            // 
            // label_client_status
            // 
            this.label_client_status.AutoSize = true;
            this.label_client_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client_status.ForeColor = System.Drawing.Color.Red;
            this.label_client_status.Location = new System.Drawing.Point(140, 390);
            this.label_client_status.Name = "label_client_status";
            this.label_client_status.Size = new System.Drawing.Size(0, 13);
            this.label_client_status.TabIndex = 45;
            this.label_client_status.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(57, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "All fields with * are required";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(195, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 29);
            this.label16.TabIndex = 43;
            this.label16.Text = "Client Details";
            // 
            // button_saveClient
            // 
            this.button_saveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveClient.Location = new System.Drawing.Point(143, 321);
            this.button_saveClient.Name = "button_saveClient";
            this.button_saveClient.Size = new System.Drawing.Size(440, 41);
            this.button_saveClient.TabIndex = 42;
            this.button_saveClient.Text = "Save";
            this.button_saveClient.UseVisualStyleBackColor = true;
            this.button_saveClient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_clientFax
            // 
            this.tb_clientFax.Location = new System.Drawing.Point(408, 266);
            this.tb_clientFax.Name = "tb_clientFax";
            this.tb_clientFax.Size = new System.Drawing.Size(175, 20);
            this.tb_clientFax.TabIndex = 41;
            // 
            // tb_clientEmail
            // 
            this.tb_clientEmail.Location = new System.Drawing.Point(143, 266);
            this.tb_clientEmail.Name = "tb_clientEmail";
            this.tb_clientEmail.Size = new System.Drawing.Size(167, 20);
            this.tb_clientEmail.TabIndex = 40;
            // 
            // tb_clientPhoneNo
            // 
            this.tb_clientPhoneNo.Location = new System.Drawing.Point(408, 179);
            this.tb_clientPhoneNo.Name = "tb_clientPhoneNo";
            this.tb_clientPhoneNo.Size = new System.Drawing.Size(175, 20);
            this.tb_clientPhoneNo.TabIndex = 39;
            // 
            // tb_clientName
            // 
            this.tb_clientName.Location = new System.Drawing.Point(143, 179);
            this.tb_clientName.Name = "tb_clientName";
            this.tb_clientName.Size = new System.Drawing.Size(167, 20);
            this.tb_clientName.TabIndex = 38;
            // 
            // tb_clientAddress
            // 
            this.tb_clientAddress.Location = new System.Drawing.Point(143, 229);
            this.tb_clientAddress.Multiline = true;
            this.tb_clientAddress.Name = "tb_clientAddress";
            this.tb_clientAddress.Size = new System.Drawing.Size(440, 20);
            this.tb_clientAddress.TabIndex = 37;
            // 
            // tb_clientCompany
            // 
            this.tb_clientCompany.Location = new System.Drawing.Point(143, 124);
            this.tb_clientCompany.Name = "tb_clientCompany";
            this.tb_clientCompany.Size = new System.Drawing.Size(167, 20);
            this.tb_clientCompany.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(334, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Fax No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(334, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Phone No";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Owner\'s Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 229);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Address";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Compnay Name *";
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewCompany);
            this.Controls.Add(this.link_AddCompany);
            this.Name = "Companies";
            this.Size = new System.Drawing.Size(1026, 668);
            this.Load += new System.EventHandler(this.Companies_Load);
            this.Controls.SetChildIndex(this.link_AddCompany, 0);
            this.Controls.SetChildIndex(this.NewCompany, 0);
            this.NewCompany.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_companies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_searchCompanies.ResumeLayout(false);
            this.panel_searchCompanies.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_AddCompany;
        private System.Windows.Forms.TabControl NewCompany;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_saveCompany;
        private System.Windows.Forms.TextBox tb_faxNo;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phoneNumber;
        private System.Windows.Forms.TextBox tb_ownerName;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_companyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_SelectCompany;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView gridView_companies;
        private System.Windows.Forms.Label label_Vendor_Status;
        private System.Windows.Forms.Button button_searchCompanies;
        private System.Windows.Forms.TextBox textBox_searchCompanies;
        private System.Windows.Forms.Panel panel_searchCompanies;
        private System.Windows.Forms.Button button_editCompany;
        private System.Windows.Forms.Button button_saveCompanyEdit;
        private System.Windows.Forms.TextBox textBox_fax;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_ownerName;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_company_id;
        private System.Windows.Forms.Label label_edit_status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_CompanyBalance;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_saveClient;
        private System.Windows.Forms.TextBox tb_clientFax;
        private System.Windows.Forms.TextBox tb_clientEmail;
        private System.Windows.Forms.TextBox tb_clientPhoneNo;
        private System.Windows.Forms.TextBox tb_clientName;
        private System.Windows.Forms.TextBox tb_clientAddress;
        private System.Windows.Forms.TextBox tb_clientCompany;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label_client_status;
        private System.Windows.Forms.Label label_noCompany;
        private System.Windows.Forms.Label label_companyType;
        private System.Windows.Forms.Label CnicNtnLabel;
        private System.Windows.Forms.TextBox Client_CNIC_NTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC_NTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxNumber;
        private System.Windows.Forms.Label Vender_Cnic_label;
        private System.Windows.Forms.TextBox Vender_CNIC;



    }
}
