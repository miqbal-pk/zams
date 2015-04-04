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
            this.Party_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_searchCompanies = new System.Windows.Forms.Button();
            this.textBox_searchCompanies = new System.Windows.Forms.TextBox();
            this.label_SelectCompany = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
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
            this.panel_searchCompanies = new System.Windows.Forms.Panel();
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
            this.button_editCompany = new System.Windows.Forms.Button();
            this.NewCompany.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_companies)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_searchCompanies.SuspendLayout();
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
            this.NewCompany.Location = new System.Drawing.Point(8, 44);
            this.NewCompany.Name = "NewCompany";
            this.NewCompany.SelectedIndex = 0;
            this.NewCompany.Size = new System.Drawing.Size(704, 638);
            this.NewCompany.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridView_companies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridView_companies
            // 
            this.gridView_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_companies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Party_Name,
            this.OwnerName,
            this.PhoneNumber,
            this.Location,
            this.Email,
            this.FaxNumber});
            this.gridView_companies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_companies.Location = new System.Drawing.Point(3, 3);
            this.gridView_companies.Name = "gridView_companies";
            this.gridView_companies.Size = new System.Drawing.Size(690, 606);
            this.gridView_companies.TabIndex = 0;
            this.gridView_companies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Party_Name
            // 
            this.Party_Name.HeaderText = "Party_Name";
            this.Party_Name.Name = "Party_Name";
            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "OwnerName";
            this.OwnerName.Name = "OwnerName";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // FaxNumber
            // 
            this.FaxNumber.HeaderText = "FaxNumber";
            this.FaxNumber.Name = "FaxNumber";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_searchCompanies);
            this.tabPage2.Controls.Add(this.button_searchCompanies);
            this.tabPage2.Controls.Add(this.textBox_searchCompanies);
            this.tabPage2.Controls.Add(this.label_SelectCompany);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_searchCompanies
            // 
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
            this.textBox_searchCompanies.Location = new System.Drawing.Point(206, 77);
            this.textBox_searchCompanies.Name = "textBox_searchCompanies";
            this.textBox_searchCompanies.Size = new System.Drawing.Size(218, 20);
            this.textBox_searchCompanies.TabIndex = 1;
            this.textBox_searchCompanies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_SelectCompany
            // 
            this.label_SelectCompany.AutoSize = true;
            this.label_SelectCompany.Location = new System.Drawing.Point(73, 80);
            this.label_SelectCompany.Name = "label_SelectCompany";
            this.label_SelectCompany.Size = new System.Drawing.Size(110, 13);
            this.label_SelectCompany.TabIndex = 0;
            this.label_SelectCompany.Text = "Enter Company Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "New Company";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_status);
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
            this.panel2.Location = new System.Drawing.Point(4, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 599);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(174, 390);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 17);
            this.label_status.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(236, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Company Details";
            // 
            // button_saveCompany
            // 
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
            this.label7.Location = new System.Drawing.Point(384, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fax No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Owner\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Compnay Name";
            // 
            // panel_searchCompanies
            // 
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
            this.panel_searchCompanies.Size = new System.Drawing.Size(666, 366);
            this.panel_searchCompanies.TabIndex = 3;
            this.panel_searchCompanies.Visible = false;
            // 
            // button_saveCompanyEdit
            // 
            this.button_saveCompanyEdit.Location = new System.Drawing.Point(180, 261);
            this.button_saveCompanyEdit.Name = "button_saveCompanyEdit";
            this.button_saveCompanyEdit.Size = new System.Drawing.Size(440, 41);
            this.button_saveCompanyEdit.TabIndex = 39;
            this.button_saveCompanyEdit.Text = "SaveChanges";
            this.button_saveCompanyEdit.UseVisualStyleBackColor = true;
            this.button_saveCompanyEdit.Visible = false;
            // 
            // textBox_fax
            // 
            this.textBox_fax.Location = new System.Drawing.Point(468, 206);
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
            this.textBox_phone.Location = new System.Drawing.Point(468, 119);
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
            this.label1.Location = new System.Drawing.Point(387, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fax No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Owner\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Compnay Name";
            // 
            // button_editCompany
            // 
            this.button_editCompany.Location = new System.Drawing.Point(444, 22);
            this.button_editCompany.Name = "button_editCompany";
            this.button_editCompany.Size = new System.Drawing.Size(75, 23);
            this.button_editCompany.TabIndex = 40;
            this.button_editCompany.Text = "Edit";
            this.button_editCompany.UseVisualStyleBackColor = true;
            this.button_editCompany.Click += new System.EventHandler(this.button_editCompany_Click);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewCompany);
            this.Controls.Add(this.link_AddCompany);
            this.Name = "Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            this.Controls.SetChildIndex(this.link_AddCompany, 0);
            this.Controls.SetChildIndex(this.NewCompany, 0);
            this.NewCompany.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_companies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_searchCompanies.ResumeLayout(false);
            this.panel_searchCompanies.PerformLayout();
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
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxNumber;
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



    }
}
