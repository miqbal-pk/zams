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
            this.tabControl1.SuspendLayout();
            this.tabPage_Parties.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_Projects.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Parties);
            this.tabControl1.Controls.Add(this.tabPage_Projects);
            this.tabControl1.Location = new System.Drawing.Point(-1, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 629);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_Parties
            // 
            this.tabPage_Parties.Controls.Add(this.panel1);
            this.tabPage_Parties.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Parties.Name = "tabPage_Parties";
            this.tabPage_Parties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Parties.Size = new System.Drawing.Size(709, 603);
            this.tabPage_Parties.TabIndex = 0;
            this.tabPage_Parties.Text = "Parties";
            this.tabPage_Parties.UseVisualStyleBackColor = true;
            this.tabPage_Parties.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(703, 597);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(52, 168);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(584, 150);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 597);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // button_viewAll
            // 
            this.button_viewAll.Location = new System.Drawing.Point(190, 337);
            this.button_viewAll.Name = "button_viewAll";
            this.button_viewAll.Size = new System.Drawing.Size(336, 23);
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
            this.label_AmountReceived.Location = new System.Drawing.Point(173, 136);
            this.label_AmountReceived.Name = "label_AmountReceived";
            this.label_AmountReceived.Size = new System.Drawing.Size(92, 13);
            this.label_AmountReceived.TabIndex = 6;
            this.label_AmountReceived.Text = "Amount Received";
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
            this.label_AmountPaid.Location = new System.Drawing.Point(198, 108);
            this.label_AmountPaid.Name = "label_AmountPaid";
            this.label_AmountPaid.Size = new System.Drawing.Size(67, 13);
            this.label_AmountPaid.TabIndex = 4;
            this.label_AmountPaid.Text = "Amount Paid";
            this.label_AmountPaid.Visible = false;
            // 
            // reportcombo_party
            // 
            this.reportcombo_party.FormattingEnabled = true;
            this.reportcombo_party.Location = new System.Drawing.Point(308, 49);
            this.reportcombo_party.Name = "reportcombo_party";
            this.reportcombo_party.Size = new System.Drawing.Size(208, 21);
            this.reportcombo_party.TabIndex = 1;
            this.reportcombo_party.SelectionChangeCommitted += new System.EventHandler(this.reportcombo_party_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Company/Party";
            // 
            // tabPage_Projects
            // 
            this.tabPage_Projects.Controls.Add(this.panel2);
            this.tabPage_Projects.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Projects.Name = "tabPage_Projects";
            this.tabPage_Projects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Projects.Size = new System.Drawing.Size(709, 603);
            this.tabPage_Projects.TabIndex = 1;
            this.tabPage_Projects.Text = "Projects";
            this.tabPage_Projects.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
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
            this.panel2.Size = new System.Drawing.Size(703, 597);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "profit";
            this.label7.Visible = false;
            // 
            // label_profit
            // 
            this.label_profit.AutoSize = true;
            this.label_profit.Location = new System.Drawing.Point(230, 173);
            this.label_profit.Name = "label_profit";
            this.label_profit.Size = new System.Drawing.Size(31, 13);
            this.label_profit.TabIndex = 11;
            this.label_profit.Text = "Profit";
            this.label_profit.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(80, 198);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(541, 150);
            this.dataGridView4.TabIndex = 10;
            this.dataGridView4.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 407);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(703, 517);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.Visible = false;
            // 
            // button1
            // 
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
            this.label5.Location = new System.Drawing.Point(169, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount Received";
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
            this.label3.Location = new System.Drawing.Point(194, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Project";
            // 
            // ReportHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportHome";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Parties;
        private System.Windows.Forms.TabPage tabPage_Projects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox reportcombo_party;
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
    }
}
