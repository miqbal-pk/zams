namespace ZAMS.uc
{
    partial class Banks
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
            this.tabPage_viewBanks = new System.Windows.Forms.TabPage();
            this.dataGridView_viewBanks = new System.Windows.Forms.DataGridView();
            this.tabPage_SearchBanks = new System.Windows.Forms.TabPage();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.label_bankDetailEdit = new System.Windows.Forms.Label();
            this.textBox_AccountTitleEdit = new System.Windows.Forms.TextBox();
            this.label_AccountTitleEdit = new System.Windows.Forms.Label();
            this.label_AddressEdit = new System.Windows.Forms.Label();
            this.textBox_BalanceEdit = new System.Windows.Forms.TextBox();
            this.textBox_AccountNumberEdit = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.textBox_branchEdit = new System.Windows.Forms.TextBox();
            this.textBox_AddressEdit = new System.Windows.Forms.TextBox();
            this.textBox_BankNameEdit = new System.Windows.Forms.TextBox();
            this.label_BalanceEdit = new System.Windows.Forms.Label();
            this.label_AccountNumberEdit = new System.Windows.Forms.Label();
            this.label_PhoneNumberEdit = new System.Windows.Forms.Label();
            this.label_branchEdit = new System.Windows.Forms.Label();
            this.label_BankNameEdit = new System.Windows.Forms.Label();
            this.label_AccountNo = new System.Windows.Forms.Label();
            this.comboBox_AccountNo = new System.Windows.Forms.ComboBox();
            this.label2_branch = new System.Windows.Forms.Label();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.comboBox_Bank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_AddBank = new System.Windows.Forms.TabPage();
            this.textBox_AccountTitle = new System.Windows.Forms.TextBox();
            this.label_AccountTitle = new System.Windows.Forms.Label();
            this.label_BankAddress = new System.Windows.Forms.Label();
            this.label_BankStatus = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label_BankDetail = new System.Windows.Forms.Label();
            this.button_SaveBank = new System.Windows.Forms.Button();
            this.textBox_BankBalance = new System.Windows.Forms.TextBox();
            this.textBox_AccountNumber = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_Branch = new System.Windows.Forms.TextBox();
            this.textBox_BankAddress = new System.Windows.Forms.TextBox();
            this.textBox_BankName = new System.Windows.Forms.TextBox();
            this.label_BankBalance = new System.Windows.Forms.Label();
            this.label_AccountNumber = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_Branch = new System.Windows.Forms.Label();
            this.label_BankName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_viewBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewBanks)).BeginInit();
            this.tabPage_SearchBanks.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.tabPage_AddBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_viewBanks);
            this.tabControl1.Controls.Add(this.tabPage_SearchBanks);
            this.tabControl1.Controls.Add(this.tabPage_AddBank);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 689);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage_viewBanks
            // 
            this.tabPage_viewBanks.Controls.Add(this.dataGridView_viewBanks);
            this.tabPage_viewBanks.Location = new System.Drawing.Point(4, 22);
            this.tabPage_viewBanks.Name = "tabPage_viewBanks";
            this.tabPage_viewBanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_viewBanks.Size = new System.Drawing.Size(1014, 663);
            this.tabPage_viewBanks.TabIndex = 0;
            this.tabPage_viewBanks.Text = "View";
            this.tabPage_viewBanks.UseVisualStyleBackColor = true;
            // 
            // dataGridView_viewBanks
            // 
            this.dataGridView_viewBanks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_viewBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viewBanks.Location = new System.Drawing.Point(7, 3);
            this.dataGridView_viewBanks.Name = "dataGridView_viewBanks";
            this.dataGridView_viewBanks.Size = new System.Drawing.Size(1002, 658);
            this.dataGridView_viewBanks.TabIndex = 0;
            // 
            // tabPage_SearchBanks
            // 
            this.tabPage_SearchBanks.Controls.Add(this.panel_edit);
            this.tabPage_SearchBanks.Controls.Add(this.label_AccountNo);
            this.tabPage_SearchBanks.Controls.Add(this.comboBox_AccountNo);
            this.tabPage_SearchBanks.Controls.Add(this.label2_branch);
            this.tabPage_SearchBanks.Controls.Add(this.comboBox_Branch);
            this.tabPage_SearchBanks.Controls.Add(this.comboBox_Bank);
            this.tabPage_SearchBanks.Controls.Add(this.label1);
            this.tabPage_SearchBanks.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SearchBanks.Name = "tabPage_SearchBanks";
            this.tabPage_SearchBanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SearchBanks.Size = new System.Drawing.Size(1014, 663);
            this.tabPage_SearchBanks.TabIndex = 1;
            this.tabPage_SearchBanks.Text = "Search";
            this.tabPage_SearchBanks.UseVisualStyleBackColor = true;
            this.tabPage_SearchBanks.Click += new System.EventHandler(this.tabPage_SearchBanks_Click);
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.label_bankDetailEdit);
            this.panel_edit.Controls.Add(this.textBox_AccountTitleEdit);
            this.panel_edit.Controls.Add(this.label_AccountTitleEdit);
            this.panel_edit.Controls.Add(this.label_AddressEdit);
            this.panel_edit.Controls.Add(this.textBox_BalanceEdit);
            this.panel_edit.Controls.Add(this.textBox_AccountNumberEdit);
            this.panel_edit.Controls.Add(this.textBox_PhoneNumberEdit);
            this.panel_edit.Controls.Add(this.textBox_branchEdit);
            this.panel_edit.Controls.Add(this.textBox_AddressEdit);
            this.panel_edit.Controls.Add(this.textBox_BankNameEdit);
            this.panel_edit.Controls.Add(this.label_BalanceEdit);
            this.panel_edit.Controls.Add(this.label_AccountNumberEdit);
            this.panel_edit.Controls.Add(this.label_PhoneNumberEdit);
            this.panel_edit.Controls.Add(this.label_branchEdit);
            this.panel_edit.Controls.Add(this.label_BankNameEdit);
            this.panel_edit.Location = new System.Drawing.Point(27, 153);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(661, 431);
            this.panel_edit.TabIndex = 8;
            this.panel_edit.Visible = false;
            // 
            // label_bankDetailEdit
            // 
            this.label_bankDetailEdit.AutoSize = true;
            this.label_bankDetailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bankDetailEdit.Location = new System.Drawing.Point(233, 30);
            this.label_bankDetailEdit.Name = "label_bankDetailEdit";
            this.label_bankDetailEdit.Size = new System.Drawing.Size(159, 29);
            this.label_bankDetailEdit.TabIndex = 81;
            this.label_bankDetailEdit.Text = "Bank Details";
            // 
            // textBox_AccountTitleEdit
            // 
            this.textBox_AccountTitleEdit.Location = new System.Drawing.Point(457, 185);
            this.textBox_AccountTitleEdit.Name = "textBox_AccountTitleEdit";
            this.textBox_AccountTitleEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_AccountTitleEdit.TabIndex = 80;
            // 
            // label_AccountTitleEdit
            // 
            this.label_AccountTitleEdit.AutoSize = true;
            this.label_AccountTitleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountTitleEdit.Location = new System.Drawing.Point(330, 188);
            this.label_AccountTitleEdit.Name = "label_AccountTitleEdit";
            this.label_AccountTitleEdit.Size = new System.Drawing.Size(83, 13);
            this.label_AccountTitleEdit.TabIndex = 79;
            this.label_AccountTitleEdit.Text = "Account Title";
            // 
            // label_AddressEdit
            // 
            this.label_AddressEdit.AutoSize = true;
            this.label_AddressEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddressEdit.Location = new System.Drawing.Point(3, 302);
            this.label_AddressEdit.Name = "label_AddressEdit";
            this.label_AddressEdit.Size = new System.Drawing.Size(52, 13);
            this.label_AddressEdit.TabIndex = 78;
            this.label_AddressEdit.Text = "Address";
            // 
            // textBox_BalanceEdit
            // 
            this.textBox_BalanceEdit.Location = new System.Drawing.Point(457, 241);
            this.textBox_BalanceEdit.Name = "textBox_BalanceEdit";
            this.textBox_BalanceEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_BalanceEdit.TabIndex = 77;
            // 
            // textBox_AccountNumberEdit
            // 
            this.textBox_AccountNumberEdit.Location = new System.Drawing.Point(457, 129);
            this.textBox_AccountNumberEdit.Name = "textBox_AccountNumberEdit";
            this.textBox_AccountNumberEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_AccountNumberEdit.TabIndex = 76;
            // 
            // textBox_PhoneNumberEdit
            // 
            this.textBox_PhoneNumberEdit.Location = new System.Drawing.Point(136, 241);
            this.textBox_PhoneNumberEdit.Name = "textBox_PhoneNumberEdit";
            this.textBox_PhoneNumberEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_PhoneNumberEdit.TabIndex = 75;
            // 
            // textBox_branchEdit
            // 
            this.textBox_branchEdit.Location = new System.Drawing.Point(136, 188);
            this.textBox_branchEdit.Name = "textBox_branchEdit";
            this.textBox_branchEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_branchEdit.TabIndex = 74;
            // 
            // textBox_AddressEdit
            // 
            this.textBox_AddressEdit.Location = new System.Drawing.Point(136, 302);
            this.textBox_AddressEdit.Multiline = true;
            this.textBox_AddressEdit.Name = "textBox_AddressEdit";
            this.textBox_AddressEdit.Size = new System.Drawing.Size(477, 20);
            this.textBox_AddressEdit.TabIndex = 73;
            // 
            // textBox_BankNameEdit
            // 
            this.textBox_BankNameEdit.Location = new System.Drawing.Point(136, 133);
            this.textBox_BankNameEdit.Name = "textBox_BankNameEdit";
            this.textBox_BankNameEdit.Size = new System.Drawing.Size(167, 20);
            this.textBox_BankNameEdit.TabIndex = 72;
            // 
            // label_BalanceEdit
            // 
            this.label_BalanceEdit.AutoSize = true;
            this.label_BalanceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BalanceEdit.Location = new System.Drawing.Point(330, 248);
            this.label_BalanceEdit.Name = "label_BalanceEdit";
            this.label_BalanceEdit.Size = new System.Drawing.Size(53, 13);
            this.label_BalanceEdit.TabIndex = 71;
            this.label_BalanceEdit.Text = "Balance";
            // 
            // label_AccountNumberEdit
            // 
            this.label_AccountNumberEdit.AutoSize = true;
            this.label_AccountNumberEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountNumberEdit.Location = new System.Drawing.Point(330, 133);
            this.label_AccountNumberEdit.Name = "label_AccountNumberEdit";
            this.label_AccountNumberEdit.Size = new System.Drawing.Size(101, 13);
            this.label_AccountNumberEdit.TabIndex = 70;
            this.label_AccountNumberEdit.Text = "Account Number";
            // 
            // label_PhoneNumberEdit
            // 
            this.label_PhoneNumberEdit.AutoSize = true;
            this.label_PhoneNumberEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNumberEdit.Location = new System.Drawing.Point(3, 241);
            this.label_PhoneNumberEdit.Name = "label_PhoneNumberEdit";
            this.label_PhoneNumberEdit.Size = new System.Drawing.Size(63, 13);
            this.label_PhoneNumberEdit.TabIndex = 69;
            this.label_PhoneNumberEdit.Text = "Phone No";
            // 
            // label_branchEdit
            // 
            this.label_branchEdit.AutoSize = true;
            this.label_branchEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_branchEdit.Location = new System.Drawing.Point(3, 188);
            this.label_branchEdit.Name = "label_branchEdit";
            this.label_branchEdit.Size = new System.Drawing.Size(47, 13);
            this.label_branchEdit.TabIndex = 68;
            this.label_branchEdit.Text = "Branch";
            // 
            // label_BankNameEdit
            // 
            this.label_BankNameEdit.AutoSize = true;
            this.label_BankNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankNameEdit.Location = new System.Drawing.Point(3, 136);
            this.label_BankNameEdit.Name = "label_BankNameEdit";
            this.label_BankNameEdit.Size = new System.Drawing.Size(76, 13);
            this.label_BankNameEdit.TabIndex = 67;
            this.label_BankNameEdit.Text = "Bank Name ";
            // 
            // label_AccountNo
            // 
            this.label_AccountNo.AutoSize = true;
            this.label_AccountNo.Location = new System.Drawing.Point(24, 125);
            this.label_AccountNo.Name = "label_AccountNo";
            this.label_AccountNo.Size = new System.Drawing.Size(94, 13);
            this.label_AccountNo.TabIndex = 7;
            this.label_AccountNo.Text = "Select AccountNo";
            this.label_AccountNo.Visible = false;
            // 
            // comboBox_AccountNo
            // 
            this.comboBox_AccountNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccountNo.FormattingEnabled = true;
            this.comboBox_AccountNo.Location = new System.Drawing.Point(124, 117);
            this.comboBox_AccountNo.Name = "comboBox_AccountNo";
            this.comboBox_AccountNo.Size = new System.Drawing.Size(338, 21);
            this.comboBox_AccountNo.TabIndex = 6;
            this.comboBox_AccountNo.Visible = false;
            this.comboBox_AccountNo.SelectionChangeCommitted += new System.EventHandler(this.comboBox_AccountNo_SelectionChangeCommitted);
            // 
            // label2_branch
            // 
            this.label2_branch.AutoSize = true;
            this.label2_branch.Location = new System.Drawing.Point(342, 69);
            this.label2_branch.Name = "label2_branch";
            this.label2_branch.Size = new System.Drawing.Size(74, 13);
            this.label2_branch.TabIndex = 5;
            this.label2_branch.Text = "Select Branch";
            this.label2_branch.Visible = false;
            this.label2_branch.Click += new System.EventHandler(this.label2_branch_Click);
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(448, 69);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(220, 21);
            this.comboBox_Branch.TabIndex = 4;
            this.comboBox_Branch.Visible = false;
            this.comboBox_Branch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_Branch.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Branch_SelectionChangeCommitted);
            // 
            // comboBox_Bank
            // 
            this.comboBox_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bank.FormattingEnabled = true;
            this.comboBox_Bank.Location = new System.Drawing.Point(108, 69);
            this.comboBox_Bank.Name = "comboBox_Bank";
            this.comboBox_Bank.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Bank.TabIndex = 3;
            this.comboBox_Bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bank_SelectedIndexChanged);
            this.comboBox_Bank.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Bank_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage_AddBank
            // 
            this.tabPage_AddBank.Controls.Add(this.textBox_AccountTitle);
            this.tabPage_AddBank.Controls.Add(this.label_AccountTitle);
            this.tabPage_AddBank.Controls.Add(this.label_BankAddress);
            this.tabPage_AddBank.Controls.Add(this.label_BankStatus);
            this.tabPage_AddBank.Controls.Add(this.label24);
            this.tabPage_AddBank.Controls.Add(this.label_BankDetail);
            this.tabPage_AddBank.Controls.Add(this.button_SaveBank);
            this.tabPage_AddBank.Controls.Add(this.textBox_BankBalance);
            this.tabPage_AddBank.Controls.Add(this.textBox_AccountNumber);
            this.tabPage_AddBank.Controls.Add(this.textBox_phoneNumber);
            this.tabPage_AddBank.Controls.Add(this.textBox_Branch);
            this.tabPage_AddBank.Controls.Add(this.textBox_BankAddress);
            this.tabPage_AddBank.Controls.Add(this.textBox_BankName);
            this.tabPage_AddBank.Controls.Add(this.label_BankBalance);
            this.tabPage_AddBank.Controls.Add(this.label_AccountNumber);
            this.tabPage_AddBank.Controls.Add(this.label_phoneNumber);
            this.tabPage_AddBank.Controls.Add(this.label_Branch);
            this.tabPage_AddBank.Controls.Add(this.label_BankName);
            this.tabPage_AddBank.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AddBank.Name = "tabPage_AddBank";
            this.tabPage_AddBank.Size = new System.Drawing.Size(1014, 663);
            this.tabPage_AddBank.TabIndex = 2;
            this.tabPage_AddBank.Text = "Add New Bank";
            this.tabPage_AddBank.UseVisualStyleBackColor = true;
            // 
            // textBox_AccountTitle
            // 
            this.textBox_AccountTitle.Location = new System.Drawing.Point(491, 194);
            this.textBox_AccountTitle.Name = "textBox_AccountTitle";
            this.textBox_AccountTitle.Size = new System.Drawing.Size(167, 20);
            this.textBox_AccountTitle.TabIndex = 66;
            // 
            // label_AccountTitle
            // 
            this.label_AccountTitle.AutoSize = true;
            this.label_AccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountTitle.Location = new System.Drawing.Point(364, 197);
            this.label_AccountTitle.Name = "label_AccountTitle";
            this.label_AccountTitle.Size = new System.Drawing.Size(92, 13);
            this.label_AccountTitle.TabIndex = 65;
            this.label_AccountTitle.Text = "Account Title *";
            // 
            // label_BankAddress
            // 
            this.label_BankAddress.AutoSize = true;
            this.label_BankAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankAddress.Location = new System.Drawing.Point(37, 311);
            this.label_BankAddress.Name = "label_BankAddress";
            this.label_BankAddress.Size = new System.Drawing.Size(52, 13);
            this.label_BankAddress.TabIndex = 64;
            this.label_BankAddress.Text = "Address";
            // 
            // label_BankStatus
            // 
            this.label_BankStatus.AutoSize = true;
            this.label_BankStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankStatus.ForeColor = System.Drawing.Color.Red;
            this.label_BankStatus.Location = new System.Drawing.Point(167, 439);
            this.label_BankStatus.Name = "label_BankStatus";
            this.label_BankStatus.Size = new System.Drawing.Size(72, 13);
            this.label_BankStatus.TabIndex = 63;
            this.label_BankStatus.Text = "BankStatus";
            this.label_BankStatus.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(84, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 13);
            this.label24.TabIndex = 62;
            this.label24.Text = "All fields with * are required";
            // 
            // label_BankDetail
            // 
            this.label_BankDetail.AutoSize = true;
            this.label_BankDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankDetail.Location = new System.Drawing.Point(249, 47);
            this.label_BankDetail.Name = "label_BankDetail";
            this.label_BankDetail.Size = new System.Drawing.Size(159, 29);
            this.label_BankDetail.TabIndex = 61;
            this.label_BankDetail.Text = "Bank Details";
            // 
            // button_SaveBank
            // 
            this.button_SaveBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveBank.Location = new System.Drawing.Point(191, 367);
            this.button_SaveBank.Name = "button_SaveBank";
            this.button_SaveBank.Size = new System.Drawing.Size(410, 41);
            this.button_SaveBank.TabIndex = 60;
            this.button_SaveBank.Text = "Save";
            this.button_SaveBank.UseVisualStyleBackColor = true;
            this.button_SaveBank.Click += new System.EventHandler(this.button_SaveBank_Click);
            // 
            // textBox_BankBalance
            // 
            this.textBox_BankBalance.Location = new System.Drawing.Point(491, 250);
            this.textBox_BankBalance.Name = "textBox_BankBalance";
            this.textBox_BankBalance.Size = new System.Drawing.Size(167, 20);
            this.textBox_BankBalance.TabIndex = 59;
            // 
            // textBox_AccountNumber
            // 
            this.textBox_AccountNumber.Location = new System.Drawing.Point(491, 138);
            this.textBox_AccountNumber.Name = "textBox_AccountNumber";
            this.textBox_AccountNumber.Size = new System.Drawing.Size(167, 20);
            this.textBox_AccountNumber.TabIndex = 58;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(170, 250);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(167, 20);
            this.textBox_phoneNumber.TabIndex = 57;
            // 
            // textBox_Branch
            // 
            this.textBox_Branch.Location = new System.Drawing.Point(170, 197);
            this.textBox_Branch.Name = "textBox_Branch";
            this.textBox_Branch.Size = new System.Drawing.Size(167, 20);
            this.textBox_Branch.TabIndex = 56;
            // 
            // textBox_BankAddress
            // 
            this.textBox_BankAddress.Location = new System.Drawing.Point(170, 311);
            this.textBox_BankAddress.Multiline = true;
            this.textBox_BankAddress.Name = "textBox_BankAddress";
            this.textBox_BankAddress.Size = new System.Drawing.Size(477, 20);
            this.textBox_BankAddress.TabIndex = 55;
            // 
            // textBox_BankName
            // 
            this.textBox_BankName.Location = new System.Drawing.Point(170, 142);
            this.textBox_BankName.Name = "textBox_BankName";
            this.textBox_BankName.Size = new System.Drawing.Size(167, 20);
            this.textBox_BankName.TabIndex = 54;
            // 
            // label_BankBalance
            // 
            this.label_BankBalance.AutoSize = true;
            this.label_BankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankBalance.Location = new System.Drawing.Point(364, 257);
            this.label_BankBalance.Name = "label_BankBalance";
            this.label_BankBalance.Size = new System.Drawing.Size(62, 13);
            this.label_BankBalance.TabIndex = 53;
            this.label_BankBalance.Text = "Balance *";
            // 
            // label_AccountNumber
            // 
            this.label_AccountNumber.AutoSize = true;
            this.label_AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountNumber.Location = new System.Drawing.Point(364, 142);
            this.label_AccountNumber.Name = "label_AccountNumber";
            this.label_AccountNumber.Size = new System.Drawing.Size(110, 13);
            this.label_AccountNumber.TabIndex = 52;
            this.label_AccountNumber.Text = "Account Number *";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNumber.Location = new System.Drawing.Point(37, 250);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(63, 13);
            this.label_phoneNumber.TabIndex = 51;
            this.label_phoneNumber.Text = "Phone No";
            // 
            // label_Branch
            // 
            this.label_Branch.AutoSize = true;
            this.label_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Branch.Location = new System.Drawing.Point(37, 197);
            this.label_Branch.Name = "label_Branch";
            this.label_Branch.Size = new System.Drawing.Size(56, 13);
            this.label_Branch.TabIndex = 50;
            this.label_Branch.Text = "Branch *";
            // 
            // label_BankName
            // 
            this.label_BankName.AutoSize = true;
            this.label_BankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BankName.Location = new System.Drawing.Point(37, 145);
            this.label_BankName.Name = "label_BankName";
            this.label_BankName.Size = new System.Drawing.Size(81, 13);
            this.label_BankName.TabIndex = 49;
            this.label_BankName.Text = "Bank Name *";
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Banks";
            this.Size = new System.Drawing.Size(1026, 668);
            this.Load += new System.EventHandler(this.Banks_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_viewBanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewBanks)).EndInit();
            this.tabPage_SearchBanks.ResumeLayout(false);
            this.tabPage_SearchBanks.PerformLayout();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.tabPage_AddBank.ResumeLayout(false);
            this.tabPage_AddBank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_viewBanks;
        private System.Windows.Forms.TabPage tabPage_SearchBanks;
        private System.Windows.Forms.TabPage tabPage_AddBank;
        private System.Windows.Forms.TextBox textBox_AccountTitle;
        private System.Windows.Forms.Label label_AccountTitle;
        private System.Windows.Forms.Label label_BankAddress;
        private System.Windows.Forms.Label label_BankStatus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label_BankDetail;
        private System.Windows.Forms.Button button_SaveBank;
        private System.Windows.Forms.TextBox textBox_BankBalance;
        private System.Windows.Forms.TextBox textBox_AccountNumber;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_Branch;
        private System.Windows.Forms.TextBox textBox_BankAddress;
        private System.Windows.Forms.TextBox textBox_BankName;
        private System.Windows.Forms.Label label_BankBalance;
        private System.Windows.Forms.Label label_AccountNumber;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_Branch;
        private System.Windows.Forms.Label label_BankName;
        private System.Windows.Forms.DataGridView dataGridView_viewBanks;
        private System.Windows.Forms.ComboBox comboBox_Bank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private System.Windows.Forms.Label label2_branch;
        private System.Windows.Forms.Label label_AccountNo;
        private System.Windows.Forms.ComboBox comboBox_AccountNo;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Label label_bankDetailEdit;
        private System.Windows.Forms.TextBox textBox_AccountTitleEdit;
        private System.Windows.Forms.Label label_AccountTitleEdit;
        private System.Windows.Forms.Label label_AddressEdit;
        private System.Windows.Forms.TextBox textBox_BalanceEdit;
        private System.Windows.Forms.TextBox textBox_AccountNumberEdit;
        private System.Windows.Forms.TextBox textBox_PhoneNumberEdit;
        private System.Windows.Forms.TextBox textBox_branchEdit;
        private System.Windows.Forms.TextBox textBox_AddressEdit;
        private System.Windows.Forms.TextBox textBox_BankNameEdit;
        private System.Windows.Forms.Label label_BalanceEdit;
        private System.Windows.Forms.Label label_AccountNumberEdit;
        private System.Windows.Forms.Label label_PhoneNumberEdit;
        private System.Windows.Forms.Label label_branchEdit;
        private System.Windows.Forms.Label label_BankNameEdit;
    }
}
