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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_transactions
            // 
            this.dataGridView_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transactions.Location = new System.Drawing.Point(-1, 261);
            this.dataGridView_transactions.Name = "dataGridView_transactions";
            this.dataGridView_transactions.Size = new System.Drawing.Size(717, 425);
            this.dataGridView_transactions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Date  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project  :";
            // 
            // comboBox_project1
            // 
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
            this.comboBox_party1.FormattingEnabled = true;
            this.comboBox_party1.Location = new System.Drawing.Point(477, 146);
            this.comboBox_party1.Name = "comboBox_party1";
            this.comboBox_party1.Size = new System.Drawing.Size(200, 21);
            this.comboBox_party1.TabIndex = 11;
            // 
            // SearchTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.SearchTransactions_Load);
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
    }
}
