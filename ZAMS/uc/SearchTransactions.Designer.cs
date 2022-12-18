namespace ZAMS
{
    partial class SearchTransactions
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
            this.dataGridView_transactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picker_startingDate = new System.Windows.Forms.DateTimePicker();
            this.picker_endingDate = new System.Windows.Forms.DateTimePicker();
            this.button_getTransactions = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_project1 = new System.Windows.Forms.ComboBox();
            this.comboBox_party1 = new System.Windows.Forms.ComboBox();
            this.button_print_transaction = new System.Windows.Forms.Button();
            this.radioButton_client = new System.Windows.Forms.RadioButton();
            this.radioButton_vendor = new System.Windows.Forms.RadioButton();
            this.label_company_type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_transactions
            // 
            this.dataGridView_transactions.AllowUserToAddRows = false;
            this.dataGridView_transactions.AllowUserToDeleteRows = false;
            this.dataGridView_transactions.AllowUserToResizeColumns = false;
            this.dataGridView_transactions.AllowUserToResizeRows = false;
            this.dataGridView_transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_transactions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_transactions.Location = new System.Drawing.Point(-1, 275);
            this.dataGridView_transactions.Name = "dataGridView_transactions";
            this.dataGridView_transactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_transactions.Size = new System.Drawing.Size(1023, 411);
            this.dataGridView_transactions.TabIndex = 1;
            this.dataGridView_transactions.Visible = false;
            this.dataGridView_transactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transactions_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Date  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ending Date  :";
            // 
            // picker_startingDate
            // 
            this.picker_startingDate.Location = new System.Drawing.Point(111, 74);
            this.picker_startingDate.Name = "picker_startingDate";
            this.picker_startingDate.Size = new System.Drawing.Size(200, 20);
            this.picker_startingDate.TabIndex = 4;
            // 
            // picker_endingDate
            // 
            this.picker_endingDate.Location = new System.Drawing.Point(477, 75);
            this.picker_endingDate.Name = "picker_endingDate";
            this.picker_endingDate.Size = new System.Drawing.Size(200, 20);
            this.picker_endingDate.TabIndex = 5;
            // 
            // button_getTransactions
            // 
            this.button_getTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_getTransactions.Location = new System.Drawing.Point(241, 197);
            this.button_getTransactions.Name = "button_getTransactions";
            this.button_getTransactions.Size = new System.Drawing.Size(258, 23);
            this.button_getTransactions.TabIndex = 6;
            this.button_getTransactions.Text = "Search";
            this.button_getTransactions.UseVisualStyleBackColor = true;
            this.button_getTransactions.Click += new System.EventHandler(this.button_getTransactions_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(-4, 241);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(126, 17);
            this.label_error.TabIndex = 7;
            this.label_error.Text = "This is an Error ";
            this.label_error.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project  :";
            // 
            // comboBox_project1
            // 
            this.comboBox_project1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_project1.FormattingEnabled = true;
            this.comboBox_project1.Location = new System.Drawing.Point(111, 146);
            this.comboBox_project1.Name = "comboBox_project1";
            this.comboBox_project1.Size = new System.Drawing.Size(200, 21);
            this.comboBox_project1.TabIndex = 10;
            this.comboBox_project1.SelectedIndexChanged += new System.EventHandler(this.comboBox_project_SelectedIndexChanged);
            this.comboBox_project1.SelectionChangeCommitted += new System.EventHandler(this.comboBox_project_SelectionChangeCommitted);
            // 
            // comboBox_party1
            // 
            this.comboBox_party1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_party1.FormattingEnabled = true;
            this.comboBox_party1.Location = new System.Drawing.Point(477, 146);
            this.comboBox_party1.Name = "comboBox_party1";
            this.comboBox_party1.Size = new System.Drawing.Size(200, 21);
            this.comboBox_party1.TabIndex = 11;
            this.comboBox_party1.SelectedIndexChanged += new System.EventHandler(this.comboBox_party1_SelectedIndexChanged);
            // 
            // button_print_transaction
            // 
            this.button_print_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print_transaction.Location = new System.Drawing.Point(602, 219);
            this.button_print_transaction.Name = "button_print_transaction";
            this.button_print_transaction.Size = new System.Drawing.Size(75, 23);
            this.button_print_transaction.TabIndex = 12;
            this.button_print_transaction.Text = "Print";
            this.button_print_transaction.UseVisualStyleBackColor = true;
            this.button_print_transaction.Visible = false;
            this.button_print_transaction.Click += new System.EventHandler(this.button_print_transaction_Click);
            // 
            // radioButton_client
            // 
            this.radioButton_client.AutoSize = true;
            this.radioButton_client.Checked = true;
            this.radioButton_client.Location = new System.Drawing.Point(477, 114);
            this.radioButton_client.Name = "radioButton_client";
            this.radioButton_client.Size = new System.Drawing.Size(51, 17);
            this.radioButton_client.TabIndex = 13;
            this.radioButton_client.TabStop = true;
            this.radioButton_client.Text = "Client";
            this.radioButton_client.UseVisualStyleBackColor = true;
            this.radioButton_client.CheckedChanged += new System.EventHandler(this.radioButton_client_CheckedChanged);
            // 
            // radioButton_vendor
            // 
            this.radioButton_vendor.AutoSize = true;
            this.radioButton_vendor.Location = new System.Drawing.Point(549, 114);
            this.radioButton_vendor.Name = "radioButton_vendor";
            this.radioButton_vendor.Size = new System.Drawing.Size(59, 17);
            this.radioButton_vendor.TabIndex = 14;
            this.radioButton_vendor.Text = "Vendor";
            this.radioButton_vendor.UseVisualStyleBackColor = true;
            this.radioButton_vendor.CheckedChanged += new System.EventHandler(this.radioButton_vendor_CheckedChanged);
            // 
            // label_company_type
            // 
            this.label_company_type.AutoSize = true;
            this.label_company_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company_type.Location = new System.Drawing.Point(370, 118);
            this.label_company_type.Name = "label_company_type";
            this.label_company_type.Size = new System.Drawing.Size(68, 13);
            this.label_company_type.TabIndex = 15;
            this.label_company_type.Text = "Select one";
            // 
            // SearchTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_company_type);
            this.Controls.Add(this.radioButton_vendor);
            this.Controls.Add(this.radioButton_client);
            this.Controls.Add(this.button_print_transaction);
            this.Controls.Add(this.comboBox_party1);
            this.Controls.Add(this.comboBox_project1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_getTransactions);
            this.Controls.Add(this.picker_endingDate);
            this.Controls.Add(this.picker_startingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_transactions);
            this.Name = "SearchTransactions";
            this.Size = new System.Drawing.Size(1025, 668);
            this.Load += new System.EventHandler(this.SearchTransactions_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SearchTransactions_DragEnter);
            this.Enter += new System.EventHandler(this.SearchTransactions_Enter);
            this.Controls.SetChildIndex(this.dataGridView_transactions, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.picker_startingDate, 0);
            this.Controls.SetChildIndex(this.picker_endingDate, 0);
            this.Controls.SetChildIndex(this.button_getTransactions, 0);
            this.Controls.SetChildIndex(this.label_error, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox_project1, 0);
            this.Controls.SetChildIndex(this.comboBox_party1, 0);
            this.Controls.SetChildIndex(this.button_print_transaction, 0);
            this.Controls.SetChildIndex(this.radioButton_client, 0);
            this.Controls.SetChildIndex(this.radioButton_vendor, 0);
            this.Controls.SetChildIndex(this.label_company_type, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_transactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker picker_startingDate;
        private System.Windows.Forms.DateTimePicker picker_endingDate;
        private System.Windows.Forms.Button button_getTransactions;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_project1;
        private System.Windows.Forms.ComboBox comboBox_party1;
        private System.Windows.Forms.Button button_print_transaction;
        private System.Windows.Forms.RadioButton radioButton_client;
        private System.Windows.Forms.RadioButton radioButton_vendor;
        private System.Windows.Forms.Label label_company_type;
    }
}
