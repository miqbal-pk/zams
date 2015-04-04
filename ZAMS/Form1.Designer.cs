namespace ZAMS
{
    partial class ParentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_SearchTransactions = new System.Windows.Forms.LinkLabel();
            this.link_Logout = new System.Windows.Forms.LinkLabel();
            this.link_Reports = new System.Windows.Forms.LinkLabel();
            this.link_Projects = new System.Windows.Forms.LinkLabel();
            this.link_Dealers = new System.Windows.Forms.LinkLabel();
            this.link_Companies = new System.Windows.Forms.LinkLabel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompanyToolStripMenuItem,
            this.newProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCompanyToolStripMenuItem
            // 
            this.newCompanyToolStripMenuItem.Name = "newCompanyToolStripMenuItem";
            this.newCompanyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newCompanyToolStripMenuItem.Text = "New Company";
            this.newCompanyToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.02325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.976744F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 695);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.link_SearchTransactions);
            this.panel1.Controls.Add(this.link_Logout);
            this.panel1.Controls.Add(this.link_Reports);
            this.panel1.Controls.Add(this.link_Projects);
            this.panel1.Controls.Add(this.link_Dealers);
            this.panel1.Controls.Add(this.link_Companies);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 689);
            this.panel1.TabIndex = 0;
            // 
            // link_SearchTransactions
            // 
            this.link_SearchTransactions.AutoSize = true;
            this.link_SearchTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_SearchTransactions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_SearchTransactions.LinkColor = System.Drawing.Color.Black;
            this.link_SearchTransactions.Location = new System.Drawing.Point(10, 171);
            this.link_SearchTransactions.Name = "link_SearchTransactions";
            this.link_SearchTransactions.Size = new System.Drawing.Size(132, 16);
            this.link_SearchTransactions.TabIndex = 5;
            this.link_SearchTransactions.TabStop = true;
            this.link_SearchTransactions.Text = "Search Transactions";
            this.link_SearchTransactions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SearchTransactions_LinkClicked);
            // 
            // link_Logout
            // 
            this.link_Logout.AutoSize = true;
            this.link_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Logout.LinkColor = System.Drawing.Color.Black;
            this.link_Logout.Location = new System.Drawing.Point(10, 635);
            this.link_Logout.Name = "link_Logout";
            this.link_Logout.Size = new System.Drawing.Size(49, 16);
            this.link_Logout.TabIndex = 4;
            this.link_Logout.TabStop = true;
            this.link_Logout.Text = "Logout";
            // 
            // link_Reports
            // 
            this.link_Reports.AutoSize = true;
            this.link_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Reports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Reports.LinkColor = System.Drawing.Color.Black;
            this.link_Reports.Location = new System.Drawing.Point(10, 133);
            this.link_Reports.Name = "link_Reports";
            this.link_Reports.Size = new System.Drawing.Size(56, 16);
            this.link_Reports.TabIndex = 3;
            this.link_Reports.TabStop = true;
            this.link_Reports.Text = "Reports";
            this.link_Reports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Reports_LinkClicked);
            // 
            // link_Projects
            // 
            this.link_Projects.AutoSize = true;
            this.link_Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Projects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Projects.LinkColor = System.Drawing.Color.Black;
            this.link_Projects.Location = new System.Drawing.Point(10, 97);
            this.link_Projects.Name = "link_Projects";
            this.link_Projects.Size = new System.Drawing.Size(57, 16);
            this.link_Projects.TabIndex = 2;
            this.link_Projects.TabStop = true;
            this.link_Projects.Text = "Projects";
            this.link_Projects.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Projects_LinkClicked);
            // 
            // link_Dealers
            // 
            this.link_Dealers.AutoSize = true;
            this.link_Dealers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Dealers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Dealers.LinkColor = System.Drawing.Color.Black;
            this.link_Dealers.Location = new System.Drawing.Point(10, 64);
            this.link_Dealers.Name = "link_Dealers";
            this.link_Dealers.Size = new System.Drawing.Size(56, 16);
            this.link_Dealers.TabIndex = 1;
            this.link_Dealers.TabStop = true;
            this.link_Dealers.Text = "Dealers";
            this.link_Dealers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Dealers_LinkClicked);
            // 
            // link_Companies
            // 
            this.link_Companies.AutoSize = true;
            this.link_Companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Companies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Companies.LinkColor = System.Drawing.Color.Black;
            this.link_Companies.Location = new System.Drawing.Point(10, 28);
            this.link_Companies.Name = "link_Companies";
            this.link_Companies.Size = new System.Drawing.Size(77, 16);
            this.link_Companies.TabIndex = 0;
            this.link_Companies.TabStop = true;
            this.link_Companies.Text = "Companies";
            this.link_Companies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Companies_LinkClicked);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(274, 3);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(719, 689);
            this.ContentPanel.TabIndex = 1;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakirya Accounts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_SearchTransactions;
        private System.Windows.Forms.LinkLabel link_Logout;
        private System.Windows.Forms.LinkLabel link_Reports;
        private System.Windows.Forms.LinkLabel link_Projects;
        private System.Windows.Forms.LinkLabel link_Dealers;
        private System.Windows.Forms.LinkLabel link_Companies;
        public System.Windows.Forms.Panel ContentPanel;
    }
}

