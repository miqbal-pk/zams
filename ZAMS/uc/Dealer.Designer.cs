namespace ZAMS
{
    partial class Dealer
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
            this.Companies_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Companies_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // link_AddCompany
            // 
            this.link_AddCompany.AutoSize = true;
            this.link_AddCompany.Location = new System.Drawing.Point(5, 48);
            this.link_AddCompany.Name = "link_AddCompany";
            this.link_AddCompany.Size = new System.Drawing.Size(47, 13);
            this.link_AddCompany.TabIndex = 4;
            this.link_AddCompany.TabStop = true;
            this.link_AddCompany.Text = "+ Dealer";
            this.link_AddCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_AddCompany_LinkClicked);
            // 
            // Companies_dataGridView
            // 
            this.Companies_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Companies_dataGridView.Location = new System.Drawing.Point(5, 97);
            this.Companies_dataGridView.Name = "Companies_dataGridView";
            this.Companies_dataGridView.Size = new System.Drawing.Size(708, 589);
            this.Companies_dataGridView.TabIndex = 3;
            // 
            // Dealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.link_AddCompany);
            this.Controls.Add(this.Companies_dataGridView);
            this.Name = "Dealer";
            this.Controls.SetChildIndex(this.Companies_dataGridView, 0);
            this.Controls.SetChildIndex(this.link_AddCompany, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Companies_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_AddCompany;
        private System.Windows.Forms.DataGridView Companies_dataGridView;
    }
}
