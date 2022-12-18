namespace ZAMS.uc
{
    partial class Bank_an_PettyCash_Reports
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
            this.label_company_type = new System.Windows.Forms.Label();
            this.radioButton_pattyCash = new System.Windows.Forms.RadioButton();
            this.radioButton_bank = new System.Windows.Forms.RadioButton();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picker_endingDate = new System.Windows.Forms.DateTimePicker();
            this.picker_startingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_viewTransactions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_AccountNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_searchTransactions = new System.Windows.Forms.Button();
            this.button_viewAll = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewTransactions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_company_type
            // 
            this.label_company_type.AutoSize = true;
            this.label_company_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company_type.Location = new System.Drawing.Point(11, 126);
            this.label_company_type.Name = "label_company_type";
            this.label_company_type.Size = new System.Drawing.Size(68, 13);
            this.label_company_type.TabIndex = 24;
            this.label_company_type.Text = "Select one";
            // 
            // radioButton_pattyCash
            // 
            this.radioButton_pattyCash.AutoSize = true;
            this.radioButton_pattyCash.Checked = true;
            this.radioButton_pattyCash.Location = new System.Drawing.Point(97, 126);
            this.radioButton_pattyCash.Name = "radioButton_pattyCash";
            this.radioButton_pattyCash.Size = new System.Drawing.Size(76, 17);
            this.radioButton_pattyCash.TabIndex = 23;
            this.radioButton_pattyCash.TabStop = true;
            this.radioButton_pattyCash.Text = "Patty Cash";
            this.radioButton_pattyCash.UseVisualStyleBackColor = true;
            this.radioButton_pattyCash.CheckedChanged += new System.EventHandler(this.radioButton_pattyCash_CheckedChanged);
            // 
            // radioButton_bank
            // 
            this.radioButton_bank.AutoSize = true;
            this.radioButton_bank.Location = new System.Drawing.Point(97, 149);
            this.radioButton_bank.Name = "radioButton_bank";
            this.radioButton_bank.Size = new System.Drawing.Size(50, 17);
            this.radioButton_bank.TabIndex = 22;
            this.radioButton_bank.Text = "Bank";
            this.radioButton_bank.UseVisualStyleBackColor = true;
            this.radioButton_bank.CheckedChanged += new System.EventHandler(this.radioButton_bank_CheckedChanged);
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Location = new System.Drawing.Point(63, 18);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(164, 21);
            this.comboBox_bank.TabIndex = 21;
            this.comboBox_bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_bank_SelectedIndexChanged);
            this.comboBox_bank.SelectionChangeCommitted += new System.EventHandler(this.comboBox_bank_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bank :";
            // 
            // picker_endingDate
            // 
            this.picker_endingDate.Location = new System.Drawing.Point(483, 53);
            this.picker_endingDate.Name = "picker_endingDate";
            this.picker_endingDate.Size = new System.Drawing.Size(200, 20);
            this.picker_endingDate.TabIndex = 19;
            // 
            // picker_startingDate
            // 
            this.picker_startingDate.Location = new System.Drawing.Point(117, 52);
            this.picker_startingDate.Name = "picker_startingDate";
            this.picker_startingDate.Size = new System.Drawing.Size(200, 20);
            this.picker_startingDate.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ending Date  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Starting Date  :";
            // 
            // dataGridView_viewTransactions
            // 
            this.dataGridView_viewTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_viewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viewTransactions.Location = new System.Drawing.Point(-1, 236);
            this.dataGridView_viewTransactions.Name = "dataGridView_viewTransactions";
            this.dataGridView_viewTransactions.Size = new System.Drawing.Size(815, 427);
            this.dataGridView_viewTransactions.TabIndex = 25;
            this.dataGridView_viewTransactions.Visible = false;
            this.dataGridView_viewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_viewTransactions_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_AccountNumber);
            this.panel1.Controls.Add(this.comboBox_Branch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_bank);
            this.panel1.Location = new System.Drawing.Point(257, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 101);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Account Number :";
            // 
            // comboBox_AccountNumber
            // 
            this.comboBox_AccountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccountNumber.FormattingEnabled = true;
            this.comboBox_AccountNumber.Location = new System.Drawing.Point(153, 62);
            this.comboBox_AccountNumber.Name = "comboBox_AccountNumber";
            this.comboBox_AccountNumber.Size = new System.Drawing.Size(285, 21);
            this.comboBox_AccountNumber.TabIndex = 25;
            this.comboBox_AccountNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox_AccountNumber_SelectedIndexChanged);
            this.comboBox_AccountNumber.SelectionChangeCommitted += new System.EventHandler(this.comboBox_AccountNumber_SelectionChangeCommitted);
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(323, 19);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Branch.TabIndex = 23;
            this.comboBox_Branch.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Branch_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Branch :";
            // 
            // button_searchTransactions
            // 
            this.button_searchTransactions.Location = new System.Drawing.Point(236, 207);
            this.button_searchTransactions.Name = "button_searchTransactions";
            this.button_searchTransactions.Size = new System.Drawing.Size(177, 23);
            this.button_searchTransactions.TabIndex = 27;
            this.button_searchTransactions.Text = "Search Transactions";
            this.button_searchTransactions.UseVisualStyleBackColor = true;
            this.button_searchTransactions.Click += new System.EventHandler(this.button_searchTransactions_Click);
            // 
            // button_viewAll
            // 
            this.button_viewAll.Location = new System.Drawing.Point(580, 207);
            this.button_viewAll.Name = "button_viewAll";
            this.button_viewAll.Size = new System.Drawing.Size(75, 23);
            this.button_viewAll.TabIndex = 28;
            this.button_viewAll.Text = "View All";
            this.button_viewAll.UseVisualStyleBackColor = true;
            this.button_viewAll.Click += new System.EventHandler(this.button_viewAll_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(14, 258);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(51, 16);
            this.label_Status.TabIndex = 29;
            this.label_Status.Text = "Status";
            this.label_Status.Visible = false;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(718, 207);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 30;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Bank_an_PettyCash_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Print);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_viewAll);
            this.Controls.Add(this.button_searchTransactions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_viewTransactions);
            this.Controls.Add(this.label_company_type);
            this.Controls.Add(this.radioButton_pattyCash);
            this.Controls.Add(this.radioButton_bank);
            this.Controls.Add(this.picker_endingDate);
            this.Controls.Add(this.picker_startingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bank_an_PettyCash_Reports";
            this.Size = new System.Drawing.Size(1027, 668);
            this.Load += new System.EventHandler(this.Bank_an_PettyCash_Reports_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.picker_startingDate, 0);
            this.Controls.SetChildIndex(this.picker_endingDate, 0);
            this.Controls.SetChildIndex(this.radioButton_bank, 0);
            this.Controls.SetChildIndex(this.radioButton_pattyCash, 0);
            this.Controls.SetChildIndex(this.label_company_type, 0);
            this.Controls.SetChildIndex(this.dataGridView_viewTransactions, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button_searchTransactions, 0);
            this.Controls.SetChildIndex(this.button_viewAll, 0);
            this.Controls.SetChildIndex(this.label_Status, 0);
            this.Controls.SetChildIndex(this.Print, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewTransactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_company_type;
        private System.Windows.Forms.RadioButton radioButton_pattyCash;
        private System.Windows.Forms.RadioButton radioButton_bank;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker picker_endingDate;
        private System.Windows.Forms.DateTimePicker picker_startingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_viewTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_AccountNumber;
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_searchTransactions;
        private System.Windows.Forms.Button button_viewAll;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button Print;
    }
}
