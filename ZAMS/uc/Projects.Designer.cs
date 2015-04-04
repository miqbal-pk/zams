using System.Windows.Forms;
namespace ZAMS
{
    partial class Projects
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridView_projects = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerPartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_searchProject = new System.Windows.Forms.Panel();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_ownerParty = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_initialBalance = new System.Windows.Forms.TextBox();
            this.textBox_currentBalance = new System.Windows.Forms.TextBox();
            this.textBox_credit = new System.Windows.Forms.TextBox();
            this.textBox_startingDate = new System.Windows.Forms.TextBox();
            this.textBox_estEndingDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_projectName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_searchProjects = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.cb_ownerParty = new System.Windows.Forms.ComboBox();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EstimatedEndingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_saveProject = new System.Windows.Forms.Button();
            this.tb_initialAmount = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tb_projectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Transaction_error = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.button_saveTransaction = new System.Windows.Forms.Button();
            this.richTextBox_otherDetails = new System.Windows.Forms.RichTextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.comboBox_party = new System.Windows.Forms.ComboBox();
            this.comboBox_project = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.projectsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new ZAMS.Database1DataSet1();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ZAMS.Database1DataSet();
            this.projectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new ZAMS.Database1DataSetTableAdapters.ProjectsTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter1 = new ZAMS.Database1DataSet1TableAdapters.ProjectsTableAdapter();
            this.projectsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_projects)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_searchProject.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 635);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.handler);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridView_projects);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridView_projects
            // 
            this.gridView_projects.AllowUserToAddRows = false;
            this.gridView_projects.AllowUserToDeleteRows = false;
            this.gridView_projects.AllowUserToOrderColumns = true;
            this.gridView_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OwnerPartyId,
            this.EstimatedStartDate,
            this.StartDate,
            this.ProjectName,
            this.EstimatedEndDate,
            this.EndDate,
            this.Status,
            this.InitialBalance,
            this.CurrentBalance,
            this.Credit});
            this.gridView_projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_projects.Location = new System.Drawing.Point(3, 3);
            this.gridView_projects.Name = "gridView_projects";
            this.gridView_projects.ReadOnly = true;
            this.gridView_projects.Size = new System.Drawing.Size(703, 603);
            this.gridView_projects.TabIndex = 0;
            this.gridView_projects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_projects_CellContentClick);
            this.gridView_projects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.handler);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // OwnerPartyId
            // 
            this.OwnerPartyId.HeaderText = "OwnerPartyId";
            this.OwnerPartyId.Name = "OwnerPartyId";
            this.OwnerPartyId.ReadOnly = true;
            // 
            // EstimatedStartDate
            // 
            this.EstimatedStartDate.HeaderText = "EstimatedStartDate";
            this.EstimatedStartDate.Name = "EstimatedStartDate";
            this.EstimatedStartDate.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // EstimatedEndDate
            // 
            this.EstimatedEndDate.HeaderText = "EstimatedEndDate";
            this.EstimatedEndDate.Name = "EstimatedEndDate";
            this.EstimatedEndDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // InitialBalance
            // 
            this.InitialBalance.HeaderText = "InitialBalance";
            this.InitialBalance.Name = "InitialBalance";
            this.InitialBalance.ReadOnly = true;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.HeaderText = "CurrentBalance";
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_searchProject);
            this.tabPage2.Controls.Add(this.button_search);
            this.tabPage2.Controls.Add(this.textBox_searchProjects);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_searchProject
            // 
            this.panel_searchProject.Controls.Add(this.button_saveChanges);
            this.panel_searchProject.Controls.Add(this.button_edit);
            this.panel_searchProject.Controls.Add(this.textBox_endDate);
            this.panel_searchProject.Controls.Add(this.label23);
            this.panel_searchProject.Controls.Add(this.textBox_ownerParty);
            this.panel_searchProject.Controls.Add(this.label22);
            this.panel_searchProject.Controls.Add(this.label21);
            this.panel_searchProject.Controls.Add(this.label20);
            this.panel_searchProject.Controls.Add(this.textBox_initialBalance);
            this.panel_searchProject.Controls.Add(this.textBox_currentBalance);
            this.panel_searchProject.Controls.Add(this.textBox_credit);
            this.panel_searchProject.Controls.Add(this.textBox_startingDate);
            this.panel_searchProject.Controls.Add(this.textBox_estEndingDate);
            this.panel_searchProject.Controls.Add(this.label14);
            this.panel_searchProject.Controls.Add(this.label15);
            this.panel_searchProject.Controls.Add(this.textBox_status);
            this.panel_searchProject.Controls.Add(this.textBox_projectName);
            this.panel_searchProject.Controls.Add(this.label16);
            this.panel_searchProject.Controls.Add(this.label18);
            this.panel_searchProject.Controls.Add(this.label19);
            this.panel_searchProject.Location = new System.Drawing.Point(40, 116);
            this.panel_searchProject.Name = "panel_searchProject";
            this.panel_searchProject.Size = new System.Drawing.Size(637, 487);
            this.panel_searchProject.TabIndex = 3;
            this.panel_searchProject.Visible = false;
            this.panel_searchProject.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_searchProject_Paint);
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.Location = new System.Drawing.Point(170, 451);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(200, 23);
            this.button_saveChanges.TabIndex = 63;
            this.button_saveChanges.Text = "Save Changes";
            this.button_saveChanges.UseVisualStyleBackColor = true;
            this.button_saveChanges.Visible = false;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(367, 26);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(86, 23);
            this.button_edit.TabIndex = 62;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(170, 366);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.Size = new System.Drawing.Size(200, 20);
            this.textBox_endDate.TabIndex = 61;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 375);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 60;
            this.label23.Text = "End Date";
            // 
            // textBox_ownerParty
            // 
            this.textBox_ownerParty.Location = new System.Drawing.Point(170, 173);
            this.textBox_ownerParty.Name = "textBox_ownerParty";
            this.textBox_ownerParty.Size = new System.Drawing.Size(144, 20);
            this.textBox_ownerParty.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 227);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 58;
            this.label22.Text = "Initial Balance";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 275);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "Current Balance";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Credit";
            // 
            // textBox_initialBalance
            // 
            this.textBox_initialBalance.Location = new System.Drawing.Point(170, 224);
            this.textBox_initialBalance.Name = "textBox_initialBalance";
            this.textBox_initialBalance.Size = new System.Drawing.Size(200, 20);
            this.textBox_initialBalance.TabIndex = 55;
            // 
            // textBox_currentBalance
            // 
            this.textBox_currentBalance.Location = new System.Drawing.Point(170, 272);
            this.textBox_currentBalance.Name = "textBox_currentBalance";
            this.textBox_currentBalance.Size = new System.Drawing.Size(200, 20);
            this.textBox_currentBalance.TabIndex = 54;
            // 
            // textBox_credit
            // 
            this.textBox_credit.Location = new System.Drawing.Point(170, 316);
            this.textBox_credit.Name = "textBox_credit";
            this.textBox_credit.Size = new System.Drawing.Size(200, 20);
            this.textBox_credit.TabIndex = 53;
            // 
            // textBox_startingDate
            // 
            this.textBox_startingDate.Location = new System.Drawing.Point(170, 76);
            this.textBox_startingDate.Name = "textBox_startingDate";
            this.textBox_startingDate.Size = new System.Drawing.Size(144, 20);
            this.textBox_startingDate.TabIndex = 52;
            // 
            // textBox_estEndingDate
            // 
            this.textBox_estEndingDate.Location = new System.Drawing.Point(170, 124);
            this.textBox_estEndingDate.Name = "textBox_estEndingDate";
            this.textBox_estEndingDate.Size = new System.Drawing.Size(144, 20);
            this.textBox_estEndingDate.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Owner Party";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Estimated End Date";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(170, 415);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(200, 20);
            this.textBox_status.TabIndex = 44;
            // 
            // textBox_projectName
            // 
            this.textBox_projectName.Location = new System.Drawing.Point(170, 29);
            this.textBox_projectName.Name = "textBox_projectName";
            this.textBox_projectName.Size = new System.Drawing.Size(144, 20);
            this.textBox_projectName.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Project Starting Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Project Name";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(407, 65);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(86, 27);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_searchProjects
            // 
            this.textBox_searchProjects.Location = new System.Drawing.Point(210, 69);
            this.textBox_searchProjects.Name = "textBox_searchProjects";
            this.textBox_searchProjects.Size = new System.Drawing.Size(179, 20);
            this.textBox_searchProjects.TabIndex = 1;
            this.textBox_searchProjects.TextChanged += new System.EventHandler(this.textBox_searchProjects_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Enter Project Name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(709, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "New Project";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.cb_ownerParty);
            this.panel1.Controls.Add(this.dtp_startDate);
            this.panel1.Controls.Add(this.dtp_EstimatedEndingDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_saveProject);
            this.panel1.Controls.Add(this.tb_initialAmount);
            this.panel1.Controls.Add(this.tb_location);
            this.panel1.Controls.Add(this.tb_projectName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.handler);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Black;
            this.label_status.Location = new System.Drawing.Point(178, 388);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(34, 17);
            this.label_status.TabIndex = 27;
            this.label_status.Text = "abc";
            this.label_status.Visible = false;
            // 
            // cb_ownerParty
            // 
            this.cb_ownerParty.FormattingEnabled = true;
            this.cb_ownerParty.Location = new System.Drawing.Point(181, 204);
            this.cb_ownerParty.Name = "cb_ownerParty";
            this.cb_ownerParty.Size = new System.Drawing.Size(200, 21);
            this.cb_ownerParty.TabIndex = 26;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(181, 111);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_startDate.TabIndex = 25;
            // 
            // dtp_EstimatedEndingDate
            // 
            this.dtp_EstimatedEndingDate.Location = new System.Drawing.Point(181, 159);
            this.dtp_EstimatedEndingDate.Name = "dtp_EstimatedEndingDate";
            this.dtp_EstimatedEndingDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EstimatedEndingDate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select Owner Party";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estimated End Date";
            // 
            // button_saveProject
            // 
            this.button_saveProject.Location = new System.Drawing.Point(181, 328);
            this.button_saveProject.Name = "button_saveProject";
            this.button_saveProject.Size = new System.Drawing.Size(458, 37);
            this.button_saveProject.TabIndex = 18;
            this.button_saveProject.Text = "Save";
            this.button_saveProject.UseVisualStyleBackColor = true;
            this.button_saveProject.Click += new System.EventHandler(this.button_saveProject_Click);
            // 
            // tb_initialAmount
            // 
            this.tb_initialAmount.Location = new System.Drawing.Point(499, 160);
            this.tb_initialAmount.Name = "tb_initialAmount";
            this.tb_initialAmount.Size = new System.Drawing.Size(140, 20);
            this.tb_initialAmount.TabIndex = 16;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(181, 269);
            this.tb_location.Multiline = true;
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(458, 20);
            this.tb_location.TabIndex = 15;
            // 
            // tb_projectName
            // 
            this.tb_projectName.Location = new System.Drawing.Point(181, 61);
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.Size = new System.Drawing.Size(144, 20);
            this.tb_projectName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Project Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Initial Budget *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project Name *";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(709, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Make Transaction";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Transaction_error);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label_error);
            this.panel2.Controls.Add(this.button_saveTransaction);
            this.panel2.Controls.Add(this.richTextBox_otherDetails);
            this.panel2.Controls.Add(this.richTextBox_description);
            this.panel2.Controls.Add(this.comboBox_party);
            this.panel2.Controls.Add(this.comboBox_project);
            this.panel2.Controls.Add(this.comboBox_type);
            this.panel2.Controls.Add(this.textBox_amount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 609);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.MakeTransaction);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MakeTransaction1);
            // 
            // label_Transaction_error
            // 
            this.label_Transaction_error.AutoSize = true;
            this.label_Transaction_error.Location = new System.Drawing.Point(100, 511);
            this.label_Transaction_error.Name = "label_Transaction_error";
            this.label_Transaction_error.Size = new System.Drawing.Size(118, 13);
            this.label_Transaction_error.TabIndex = 15;
            this.label_Transaction_error.Text = "label_Transaction_error";
            this.label_Transaction_error.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(135, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "The fields with * are required";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(97, 372);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 13;
            // 
            // button_saveTransaction
            // 
            this.button_saveTransaction.Location = new System.Drawing.Point(172, 446);
            this.button_saveTransaction.Name = "button_saveTransaction";
            this.button_saveTransaction.Size = new System.Drawing.Size(477, 48);
            this.button_saveTransaction.TabIndex = 12;
            this.button_saveTransaction.Text = "Check Out";
            this.button_saveTransaction.UseVisualStyleBackColor = true;
            this.button_saveTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_otherDetails
            // 
            this.richTextBox_otherDetails.Location = new System.Drawing.Point(172, 348);
            this.richTextBox_otherDetails.Name = "richTextBox_otherDetails";
            this.richTextBox_otherDetails.Size = new System.Drawing.Size(477, 69);
            this.richTextBox_otherDetails.TabIndex = 11;
            this.richTextBox_otherDetails.Text = "";
            this.richTextBox_otherDetails.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(172, 254);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(477, 63);
            this.richTextBox_description.TabIndex = 10;
            this.richTextBox_description.Text = "";
            // 
            // comboBox_party
            // 
            this.comboBox_party.FormattingEnabled = true;
            this.comboBox_party.Location = new System.Drawing.Point(172, 210);
            this.comboBox_party.Name = "comboBox_party";
            this.comboBox_party.Size = new System.Drawing.Size(156, 21);
            this.comboBox_party.TabIndex = 9;
            this.comboBox_party.SelectedIndexChanged += new System.EventHandler(this.comboBox_party_SelectedIndexChanged);
            // 
            // comboBox_project
            // 
            this.comboBox_project.FormattingEnabled = true;
            this.comboBox_project.Location = new System.Drawing.Point(172, 166);
            this.comboBox_project.Name = "comboBox_project";
            this.comboBox_project.Size = new System.Drawing.Size(156, 21);
            this.comboBox_project.TabIndex = 8;
            this.comboBox_project.SelectedIndexChanged += new System.EventHandler(this.comboBox_project_SelectedIndexChanged);
            this.comboBox_project.SelectionChangeCommitted += new System.EventHandler(this.comboBox_project_SelectionChangeCommitted);
            this.comboBox_project.DisplayMemberChanged += new System.EventHandler(this.comboBox_project_DisplayMemberChanged);
            this.comboBox_project.SelectedValueChanged += new System.EventHandler(this.comboBox_project_SelectedValueChanged);
            this.comboBox_project.EnabledChanged += new System.EventHandler(this.comboBox_project_EnabledChanged);
            this.comboBox_project.TextChanged += new System.EventHandler(this.comboBox_project_TextChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Withdraw"});
            this.comboBox_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboBox_type.Location = new System.Drawing.Point(172, 115);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(156, 21);
            this.comboBox_type.TabIndex = 7;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(172, 74);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(156, 20);
            this.textBox_amount.TabIndex = 6;
            this.textBox_amount.TextChanged += new System.EventHandler(this.textBox_amount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Other Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Project *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Party *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Type *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount *";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // projectsBindingSource6
            // 
            this.projectsBindingSource6.DataMember = "Projects";
            this.projectsBindingSource6.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(ZAMS.Model.Project);
            // 
            // projectsBindingSource5
            // 
            this.projectsBindingSource5.DataMember = "Projects";
            this.projectsBindingSource5.DataSource = this.database1DataSetBindingSource1;
            // 
            // database1DataSetBindingSource1
            // 
            this.database1DataSetBindingSource1.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource1.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource2
            // 
            this.projectsBindingSource2.DataMember = "Projects";
            this.projectsBindingSource2.DataSource = this.database1DataSet1;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.database1DataSet;
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "Parties";
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // projectsBindingSource1
            // 
            this.projectsBindingSource1.DataMember = "Projects";
            this.projectsBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsBindingSource3
            // 
            this.projectsBindingSource3.DataMember = "Projects";
            this.projectsBindingSource3.DataSource = this.database1DataSetBindingSource;
            // 
            // projectsBindingSource4
            // 
            this.projectsBindingSource4.DataMember = "Projects";
            this.projectsBindingSource4.DataSource = this.database1DataSetBindingSource1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(88, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(163, 13);
            this.label24.TabIndex = 28;
            this.label24.Text = "All fields with * are required";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_projects)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_searchProject.ResumeLayout(false);
            this.panel_searchProject.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_saveProject;
        private System.Windows.Forms.TextBox tb_initialAmount;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.TextBox tb_projectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_EstimatedEndingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.ComboBox cb_ownerParty;
        private System.Windows.Forms.DataGridView gridView_projects;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private BindingSource partiesBindingSource;
       
        private BindingSource database1DataSetBindingSource;
        private BindingSource projectsBindingSource1;
        private BindingSource database1DataSetBindingSource1;
        private Label label_status;
        private BindingSource projectsBindingSource2;
        private Database1DataSet1 database1DataSet1;
        private Database1DataSet1TableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private BindingSource projectsBindingSource5;
        private BindingSource projectsBindingSource3;
        private BindingSource projectsBindingSource4;
        private BindingSource projectBindingSource;
        private BindingSource projectsBindingSource6;
        private TabPage tabPage4;
        private Panel panel2;
        private TextBox textBox_amount;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox comboBox_type;
        private ComboBox comboBox_party;
        private ComboBox comboBox_project;
        private Button button_saveTransaction;
        private RichTextBox richTextBox_otherDetails;
        private RichTextBox richTextBox_description;
        private Label label_error;
        private TextBox textBox_searchProjects;
        private Label label13;
        private Button button_search;
        private Panel panel_searchProject;
        private Label label14;
        private Label label15;
        private TextBox textBox_status;
        private TextBox textBox_projectName;
        private Label label18;
        private Label label19;
        private Label label16;
        private TextBox textBox_startingDate;
        private TextBox textBox_estEndingDate;
        private TextBox textBox_ownerParty;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox textBox_initialBalance;
        private TextBox textBox_currentBalance;
        private TextBox textBox_credit;
        private TextBox textBox_endDate;
        private Label label23;
        private Button button_edit;
        private Button button_saveChanges;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OwnerPartyId;
        private DataGridViewTextBoxColumn EstimatedStartDate;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn EstimatedEndDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn InitialBalance;
        private DataGridViewTextBoxColumn CurrentBalance;
        private DataGridViewTextBoxColumn Credit;
        private Label label_Transaction_error;
        private Label label17;
        private Label label24;
    }
}
