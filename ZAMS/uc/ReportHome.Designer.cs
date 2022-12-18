namespace ZAMS
{
    partial class ReportHome
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Parties = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_company_type = new System.Windows.Forms.Label();
            this.radioButton_vendor = new System.Windows.Forms.RadioButton();
            this.radioButton_client = new System.Windows.Forms.RadioButton();
            this.label_selectProject = new System.Windows.Forms.Label();
            this.comboBox_selectProject = new System.Windows.Forms.ComboBox();
            this.Button_Print_party = new System.Windows.Forms.Button();
            this.label_balanceshow = new System.Windows.Forms.Label();
            this.label_Balance = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_viewAll = new System.Windows.Forms.Button();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.label_showAmountreceived = new System.Windows.Forms.Label();
            this.label_AmountReceived = new System.Windows.Forms.Label();
            this.label_showAmountPaid = new System.Windows.Forms.Label();
            this.label_AmountPaid = new System.Windows.Forms.Label();
            this.reportcombo_party = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Projects = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_print_project = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_profit = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Profit = new System.Windows.Forms.Label();
            this.Expenditure = new System.Windows.Forms.Label();
            this.RecivedAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_clientProject = new System.Windows.Forms.ComboBox();
            this.comboBox_clientReport = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Parties.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_Projects.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Parties);
            this.tabControl1.Controls.Add(this.tabPage_Projects);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 706);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_Parties
            // 
            this.tabPage_Parties.Controls.Add(this.panel1);
            this.tabPage_Parties.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Parties.Name = "tabPage_Parties";
            this.tabPage_Parties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Parties.Size = new System.Drawing.Size(1015, 680);
            this.tabPage_Parties.TabIndex = 0;
            this.tabPage_Parties.Text = "Parties";
            this.tabPage_Parties.UseVisualStyleBackColor = true;
            this.tabPage_Parties.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_company_type);
            this.panel1.Controls.Add(this.radioButton_vendor);
            this.panel1.Controls.Add(this.radioButton_client);
            this.panel1.Controls.Add(this.label_selectProject);
            this.panel1.Controls.Add(this.comboBox_selectProject);
            this.panel1.Controls.Add(this.Button_Print_party);
            this.panel1.Controls.Add(this.label_balanceshow);
            this.panel1.Controls.Add(this.label_Balance);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_viewAll);
            this.panel1.Controls.Add(this.label_CompanyName);
            this.panel1.Controls.Add(this.label_showAmountreceived);
            this.panel1.Controls.Add(this.label_AmountReceived);
            this.panel1.Controls.Add(this.label_showAmountPaid);
            this.panel1.Controls.Add(this.label_AmountPaid);
            this.panel1.Controls.Add(this.reportcombo_party);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 674);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_company_type
            // 
            this.label_company_type.AutoSize = true;
            this.label_company_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company_type.Location = new System.Drawing.Point(205, 27);
            this.label_company_type.Name = "label_company_type";
            this.label_company_type.Size = new System.Drawing.Size(70, 13);
            this.label_company_type.TabIndex = 19;
            this.label_company_type.Text = "Select One";
            // 
            // radioButton_vendor
            // 
            this.radioButton_vendor.AutoSize = true;
            this.radioButton_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_vendor.Location = new System.Drawing.Point(403, 23);
            this.radioButton_vendor.Name = "radioButton_vendor";
            this.radioButton_vendor.Size = new System.Drawing.Size(65, 17);
            this.radioButton_vendor.TabIndex = 18;
            this.radioButton_vendor.Text = "Vendor";
            this.radioButton_vendor.UseVisualStyleBackColor = true;
            this.radioButton_vendor.CheckedChanged += new System.EventHandler(this.radioButton_vendor_CheckedChanged);
            // 
            // radioButton_client
            // 
            this.radioButton_client.AutoSize = true;
            this.radioButton_client.Checked = true;
            this.radioButton_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_client.Location = new System.Drawing.Point(308, 23);
            this.radioButton_client.Name = "radioButton_client";
            this.radioButton_client.Size = new System.Drawing.Size(57, 17);
            this.radioButton_client.TabIndex = 17;
            this.radioButton_client.TabStop = true;
            this.radioButton_client.Text = "Client";
            this.radioButton_client.UseVisualStyleBackColor = true;
            this.radioButton_client.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label_selectProject
            // 
            this.label_selectProject.AutoSize = true;
            this.label_selectProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectProject.Location = new System.Drawing.Point(155, 354);
            this.label_selectProject.Name = "label_selectProject";
            this.label_selectProject.Size = new System.Drawing.Size(87, 13);
            this.label_selectProject.TabIndex = 16;
            this.label_selectProject.Text = "Select Project";
            this.label_selectProject.Visible = false;
            // 
            // comboBox_selectProject
            // 
            this.comboBox_selectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectProject.FormattingEnabled = true;
            this.comboBox_selectProject.Location = new System.Drawing.Point(306, 354);
            this.comboBox_selectProject.Name = "comboBox_selectProject";
            this.comboBox_selectProject.Size = new System.Drawing.Size(210, 21);
            this.comboBox_selectProject.TabIndex = 15;
            this.comboBox_selectProject.Visible = false;
            this.comboBox_selectProject.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectProject_SelectedIndexChanged);
            // 
            // Button_Print_party
            // 
            this.Button_Print_party.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print_party.Location = new System.Drawing.Point(596, 414);
            this.Button_Print_party.Name = "Button_Print_party";
            this.Button_Print_party.Size = new System.Drawing.Size(75, 23);
            this.Button_Print_party.TabIndex = 14;
            this.Button_Print_party.Text = "Print";
            this.Button_Print_party.UseVisualStyleBackColor = true;
            this.Button_Print_party.Visible = false;
            this.Button_Print_party.Click += new System.EventHandler(this.Button_Print_party_Click);
            // 
            // label_balanceshow
            // 
            this.label_balanceshow.AutoSize = true;
            this.label_balanceshow.Location = new System.Drawing.Point(326, 168);
            this.label_balanceshow.Name = "label_balanceshow";
            this.label_balanceshow.Size = new System.Drawing.Size(33, 13);
            this.label_balanceshow.TabIndex = 13;
            this.label_balanceshow.Text = "alpha";
            this.label_balanceshow.Visible = false;
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Balance.Location = new System.Drawing.Point(222, 168);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(53, 13);
            this.label_Balance.TabIndex = 12;
            this.label_Balance.Text = "Balance";
            this.label_Balance.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(-5, 187);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(972, 150);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(964, 165);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_viewAll
            // 
            this.button_viewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewAll.Location = new System.Drawing.Point(329, 392);
            this.button_viewAll.Name = "button_viewAll";
            this.button_viewAll.Size = new System.Drawing.Size(159, 23);
            this.button_viewAll.TabIndex = 9;
            this.button_viewAll.Text = "View All Transactions";
            this.button_viewAll.UseVisualStyleBackColor = true;
            this.button_viewAll.Visible = false;
            this.button_viewAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Location = new System.Drawing.Point(305, 108);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(0, 13);
            this.label_CompanyName.TabIndex = 8;
            // 
            // label_showAmountreceived
            // 
            this.label_showAmountreceived.AutoSize = true;
            this.label_showAmountreceived.Location = new System.Drawing.Point(326, 136);
            this.label_showAmountreceived.Name = "label_showAmountreceived";
            this.label_showAmountreceived.Size = new System.Drawing.Size(33, 13);
            this.label_showAmountreceived.TabIndex = 7;
            this.label_showAmountreceived.Text = "alpha";
            this.label_showAmountreceived.Visible = false;
            // 
            // label_AmountReceived
            // 
            this.label_AmountReceived.AutoSize = true;
            this.label_AmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AmountReceived.Location = new System.Drawing.Point(195, 136);
            this.label_AmountReceived.Name = "label_AmountReceived";
            this.label_AmountReceived.Size = new System.Drawing.Size(86, 13);
            this.label_AmountReceived.TabIndex = 6;
            this.label_AmountReceived.Text = "Credit Amount";
            this.label_AmountReceived.Visible = false;
            // 
            // label_showAmountPaid
            // 
            this.label_showAmountPaid.AutoSize = true;
            this.label_showAmountPaid.Location = new System.Drawing.Point(326, 108);
            this.label_showAmountPaid.Name = "label_showAmountPaid";
            this.label_showAmountPaid.Size = new System.Drawing.Size(33, 13);
            this.label_showAmountPaid.TabIndex = 5;
            this.label_showAmountPaid.Text = "alpha";
            this.label_showAmountPaid.Visible = false;
            // 
            // label_AmountPaid
            // 
            this.label_AmountPaid.AutoSize = true;
            this.label_AmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AmountPaid.Location = new System.Drawing.Point(192, 108);
            this.label_AmountPaid.Name = "label_AmountPaid";
            this.label_AmountPaid.Size = new System.Drawing.Size(83, 13);
            this.label_AmountPaid.TabIndex = 4;
            this.label_AmountPaid.Text = "Debit Amount";
            this.label_AmountPaid.Visible = false;
            // 
            // reportcombo_party
            // 
            this.reportcombo_party.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.reportcombo_party.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportcombo_party.FormattingEnabled = true;
            this.reportcombo_party.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reportcombo_party.Location = new System.Drawing.Point(306, 57);
            this.reportcombo_party.Name = "reportcombo_party";
            this.reportcombo_party.Size = new System.Drawing.Size(208, 21);
            this.reportcombo_party.TabIndex = 1;
            this.reportcombo_party.SelectedIndexChanged += new System.EventHandler(this.reportcombo_party_SelectedIndexChanged);
            this.reportcombo_party.SelectionChangeCommitted += new System.EventHandler(this.reportcombo_party_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Company/Party";
            // 
            // tabPage_Projects
            // 
            this.tabPage_Projects.Controls.Add(this.panel2);
            this.tabPage_Projects.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Projects.Name = "tabPage_Projects";
            this.tabPage_Projects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Projects.Size = new System.Drawing.Size(1015, 680);
            this.tabPage_Projects.TabIndex = 1;
            this.tabPage_Projects.Text = "Projects";
            this.tabPage_Projects.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_print_project);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label_profit);
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 674);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_print_project
            // 
            this.button_print_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print_project.Location = new System.Drawing.Point(610, 397);
            this.button_print_project.Name = "button_print_project";
            this.button_print_project.Size = new System.Drawing.Size(75, 23);
            this.button_print_project.TabIndex = 13;
            this.button_print_project.Text = "Print";
            this.button_print_project.UseVisualStyleBackColor = true;
            this.button_print_project.Visible = false;
            this.button_print_project.Click += new System.EventHandler(this.button_print_project_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "profit";
            this.label7.Visible = false;
            // 
            // label_profit
            // 
            this.label_profit.AutoSize = true;
            this.label_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profit.Location = new System.Drawing.Point(243, 161);
            this.label_profit.Name = "label_profit";
            this.label_profit.Size = new System.Drawing.Size(37, 13);
            this.label_profit.TabIndex = 11;
            this.label_profit.Text = "Profit";
            this.label_profit.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView4.Location = new System.Drawing.Point(4, 189);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(974, 150);
            this.dataGridView4.TabIndex = 10;
            this.dataGridView4.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(4, 447);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(974, 161);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "View All Transactions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "amount rec";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Credit Amount";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "amount paid";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Debit Amount";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Project";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Profit);
            this.tabPage1.Controls.Add(this.Expenditure);
            this.tabPage1.Controls.Add(this.RecivedAmount);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox_clientProject);
            this.tabPage1.Controls.Add(this.comboBox_clientReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 680);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Final Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Location = new System.Drawing.Point(227, 343);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(0, 13);
            this.Profit.TabIndex = 9;
            // 
            // Expenditure
            // 
            this.Expenditure.AutoSize = true;
            this.Expenditure.Location = new System.Drawing.Point(227, 287);
            this.Expenditure.Name = "Expenditure";
            this.Expenditure.Size = new System.Drawing.Size(0, 13);
            this.Expenditure.TabIndex = 8;
            // 
            // RecivedAmount
            // 
            this.RecivedAmount.AutoSize = true;
            this.RecivedAmount.Location = new System.Drawing.Point(227, 235);
            this.RecivedAmount.Name = "RecivedAmount";
            this.RecivedAmount.Size = new System.Drawing.Size(0, 13);
            this.RecivedAmount.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Profit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Expenditure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Recieved Amout";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select Project";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select Client";
            // 
            // comboBox_clientProject
            // 
            this.comboBox_clientProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientProject.FormattingEnabled = true;
            this.comboBox_clientProject.Location = new System.Drawing.Point(230, 111);
            this.comboBox_clientProject.Name = "comboBox_clientProject";
            this.comboBox_clientProject.Size = new System.Drawing.Size(188, 21);
            this.comboBox_clientProject.TabIndex = 1;
            this.comboBox_clientProject.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientProject_SelectedIndexChanged);
            this.comboBox_clientProject.SelectionChangeCommitted += new System.EventHandler(this.comboBox_clientProject_SelectionChangeCommitted);
            // 
            // comboBox_clientReport
            // 
            this.comboBox_clientReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientReport.FormattingEnabled = true;
            this.comboBox_clientReport.Location = new System.Drawing.Point(230, 51);
            this.comboBox_clientReport.Name = "comboBox_clientReport";
            this.comboBox_clientReport.Size = new System.Drawing.Size(188, 21);
            this.comboBox_clientReport.TabIndex = 0;
            this.comboBox_clientReport.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientReport_SelectedIndexChanged);
            this.comboBox_clientReport.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // ReportHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportHome";
            this.Size = new System.Drawing.Size(1025, 668);
            this.Load += new System.EventHandler(this.ReportHome_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Parties.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_Projects.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Parties;
        private System.Windows.Forms.TabPage tabPage_Projects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.Label label_showAmountreceived;
        private System.Windows.Forms.Label label_AmountReceived;
        private System.Windows.Forms.Label label_showAmountPaid;
        private System.Windows.Forms.Label label_AmountPaid;
        private System.Windows.Forms.Button button_viewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label_profit;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_balanceshow;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Button Button_Print_party;
        private System.Windows.Forms.Button button_print_project;
        private System.Windows.Forms.Label label_selectProject;
        private System.Windows.Forms.ComboBox comboBox_selectProject;
        private System.Windows.Forms.RadioButton radioButton_client;
        private System.Windows.Forms.RadioButton radioButton_vendor;
        private System.Windows.Forms.Label label_company_type;
        private System.Windows.Forms.ComboBox reportcombo_party;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_clientProject;
        private System.Windows.Forms.ComboBox comboBox_clientReport;
        private System.Windows.Forms.Label Profit;
        private System.Windows.Forms.Label Expenditure;
        private System.Windows.Forms.Label RecivedAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
