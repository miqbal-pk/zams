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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.View_User = new System.Windows.Forms.LinkLabel();
            this.Change_Password_Button = new System.Windows.Forms.Button();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkBank = new System.Windows.Forms.LinkLabel();
            this.link_SearchTransactions = new System.Windows.Forms.LinkLabel();
            this.link_Reports = new System.Windows.Forms.LinkLabel();
            this.link_Projects = new System.Windows.Forms.LinkLabel();
            this.link_Companies = new System.Windows.Forms.LinkLabel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 695);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.View_User);
            this.panel1.Controls.Add(this.Change_Password_Button);
            this.panel1.Controls.Add(this.SignUp_Button);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.linkBank);
            this.panel1.Controls.Add(this.link_SearchTransactions);
            this.panel1.Controls.Add(this.link_Reports);
            this.panel1.Controls.Add(this.link_Projects);
            this.panel1.Controls.Add(this.link_Companies);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 689);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // View_User
            // 
            this.View_User.AutoSize = true;
            this.View_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_User.LinkColor = System.Drawing.Color.Black;
            this.View_User.Location = new System.Drawing.Point(5, 273);
            this.View_User.Name = "View_User";
            this.View_User.Size = new System.Drawing.Size(76, 16);
            this.View_User.TabIndex = 11;
            this.View_User.TabStop = true;
            this.View_User.Text = "View Users";
            this.View_User.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.View_User_LinkClicked);
            // 
            // Change_Password_Button
            // 
            this.Change_Password_Button.FlatAppearance.BorderSize = 3;
            this.Change_Password_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Change_Password_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Change_Password_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Change_Password_Button.Location = new System.Drawing.Point(6, 513);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(97, 52);
            this.Change_Password_Button.TabIndex = 10;
            this.Change_Password_Button.Text = "Change Password";
            this.Change_Password_Button.UseVisualStyleBackColor = true;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.FlatAppearance.BorderSize = 3;
            this.SignUp_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SignUp_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SignUp_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Button.ForeColor = System.Drawing.Color.Maroon;
            this.SignUp_Button.Location = new System.Drawing.Point(6, 629);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(97, 52);
            this.SignUp_Button.TabIndex = 9;
            this.SignUp_Button.Text = "Sign Up";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // SignOut
            // 
            this.SignOut.FlatAppearance.BorderSize = 3;
            this.SignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut.ForeColor = System.Drawing.Color.Maroon;
            this.SignOut.Location = new System.Drawing.Point(6, 571);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(97, 52);
            this.SignOut.TabIndex = 8;
            this.SignOut.Text = "Sign Out";
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(3, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bank & Petty Cash Reports";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkBank
            // 
            this.linkBank.AutoSize = true;
            this.linkBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline);
            this.linkBank.LinkColor = System.Drawing.Color.Black;
            this.linkBank.Location = new System.Drawing.Point(3, 41);
            this.linkBank.Name = "linkBank";
            this.linkBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkBank.Size = new System.Drawing.Size(46, 16);
            this.linkBank.TabIndex = 6;
            this.linkBank.TabStop = true;
            this.linkBank.Text = "Banks";
            this.linkBank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBank_LinkClicked);
            // 
            // link_SearchTransactions
            // 
            this.link_SearchTransactions.AutoSize = true;
            this.link_SearchTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_SearchTransactions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_SearchTransactions.LinkColor = System.Drawing.Color.Black;
            this.link_SearchTransactions.Location = new System.Drawing.Point(3, 188);
            this.link_SearchTransactions.Name = "link_SearchTransactions";
            this.link_SearchTransactions.Size = new System.Drawing.Size(132, 16);
            this.link_SearchTransactions.TabIndex = 5;
            this.link_SearchTransactions.TabStop = true;
            this.link_SearchTransactions.Text = "Search Transactions";
            this.link_SearchTransactions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SearchTransactions_LinkClicked);
            // 
            // link_Reports
            // 
            this.link_Reports.AutoSize = true;
            this.link_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Reports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Reports.LinkColor = System.Drawing.Color.Black;
            this.link_Reports.Location = new System.Drawing.Point(3, 152);
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
            this.link_Projects.Location = new System.Drawing.Point(3, 119);
            this.link_Projects.Name = "link_Projects";
            this.link_Projects.Size = new System.Drawing.Size(57, 16);
            this.link_Projects.TabIndex = 2;
            this.link_Projects.TabStop = true;
            this.link_Projects.Text = "Projects";
            this.link_Projects.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Projects_LinkClicked);
            // 
            // link_Companies
            // 
            this.link_Companies.AutoSize = true;
            this.link_Companies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.link_Companies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Companies.LinkColor = System.Drawing.Color.Black;
            this.link_Companies.Location = new System.Drawing.Point(3, 80);
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
            this.ContentPanel.Location = new System.Drawing.Point(168, 3);
            this.ContentPanel.MaximumSize = new System.Drawing.Size(1300, 689);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(668, 689);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1167, 689);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zikria Accounts";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_SearchTransactions;
        private System.Windows.Forms.LinkLabel link_Reports;
        private System.Windows.Forms.LinkLabel link_Projects;
        private System.Windows.Forms.LinkLabel link_Companies;
        public System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.LinkLabel linkBank;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Button Change_Password_Button;
        private System.Windows.Forms.LinkLabel View_User;
    }
}

