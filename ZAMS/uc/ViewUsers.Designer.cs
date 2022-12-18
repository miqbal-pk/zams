namespace ZAMS.uc
{
    partial class ViewUsers
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
            this.ViewUser_tabControl = new System.Windows.Forms.TabControl();
            this.View_Users_tabPage = new System.Windows.Forms.TabPage();
            this.Users_gridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessSpecifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Users_tabPage = new System.Windows.Forms.TabPage();
            this.Delete_User_button = new System.Windows.Forms.Button();
            this.DeleteUser_Password_textBox = new System.Windows.Forms.TextBox();
            this.DeleteUser_Name_textBox = new System.Windows.Forms.TextBox();
            this.Delete_User_Label = new System.Windows.Forms.Label();
            this.DeleteUser_Password_label = new System.Windows.Forms.Label();
            this.DeleteUser_Name_label = new System.Windows.Forms.Label();
            this.ViewUser_tabControl.SuspendLayout();
            this.View_Users_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_gridView)).BeginInit();
            this.Delete_Users_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewUser_tabControl
            // 
            this.ViewUser_tabControl.Controls.Add(this.View_Users_tabPage);
            this.ViewUser_tabControl.Controls.Add(this.Delete_Users_tabPage);
            this.ViewUser_tabControl.Location = new System.Drawing.Point(3, 26);
            this.ViewUser_tabControl.Name = "ViewUser_tabControl";
            this.ViewUser_tabControl.SelectedIndex = 0;
            this.ViewUser_tabControl.Size = new System.Drawing.Size(1076, 738);
            this.ViewUser_tabControl.TabIndex = 0;
            // 
            // View_Users_tabPage
            // 
            this.View_Users_tabPage.Controls.Add(this.Users_gridView);
            this.View_Users_tabPage.Location = new System.Drawing.Point(4, 22);
            this.View_Users_tabPage.Name = "View_Users_tabPage";
            this.View_Users_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.View_Users_tabPage.Size = new System.Drawing.Size(1068, 712);
            this.View_Users_tabPage.TabIndex = 0;
            this.View_Users_tabPage.Text = "Users ";
            this.View_Users_tabPage.UseVisualStyleBackColor = true;
            // 
            // Users_gridView
            // 
            this.Users_gridView.AllowUserToAddRows = false;
            this.Users_gridView.AllowUserToDeleteRows = false;
            this.Users_gridView.AllowUserToResizeColumns = false;
            this.Users_gridView.AllowUserToResizeRows = false;
            this.Users_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Users_gridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Users_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.Name,
            this.PhoneNumber,
            this.Address,
            this.AccessSpecifier});
            this.Users_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Users_gridView.Location = new System.Drawing.Point(3, 3);
            this.Users_gridView.Name = "Users_gridView";
            this.Users_gridView.ReadOnly = true;
            this.Users_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Users_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_gridView.Size = new System.Drawing.Size(1062, 706);
            this.Users_gridView.TabIndex = 1;
            this.Users_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_gridView_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 82;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 78;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 60;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 70;
            // 
            // AccessSpecifier
            // 
            this.AccessSpecifier.HeaderText = "AccessSpecifier";
            this.AccessSpecifier.Name = "AccessSpecifier";
            this.AccessSpecifier.ReadOnly = true;
            this.AccessSpecifier.Width = 108;
            // 
            // Delete_Users_tabPage
            // 
            this.Delete_Users_tabPage.Controls.Add(this.Delete_User_button);
            this.Delete_Users_tabPage.Controls.Add(this.DeleteUser_Password_textBox);
            this.Delete_Users_tabPage.Controls.Add(this.DeleteUser_Name_textBox);
            this.Delete_Users_tabPage.Controls.Add(this.Delete_User_Label);
            this.Delete_Users_tabPage.Controls.Add(this.DeleteUser_Password_label);
            this.Delete_Users_tabPage.Controls.Add(this.DeleteUser_Name_label);
            this.Delete_Users_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Delete_Users_tabPage.Name = "Delete_Users_tabPage";
            this.Delete_Users_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Delete_Users_tabPage.Size = new System.Drawing.Size(1068, 712);
            this.Delete_Users_tabPage.TabIndex = 1;
            this.Delete_Users_tabPage.Text = "Delete User";
            this.Delete_Users_tabPage.UseVisualStyleBackColor = true;
            // 
            // Delete_User_button
            // 
            this.Delete_User_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_User_button.Location = new System.Drawing.Point(312, 324);
            this.Delete_User_button.Name = "Delete_User_button";
            this.Delete_User_button.Size = new System.Drawing.Size(85, 33);
            this.Delete_User_button.TabIndex = 5;
            this.Delete_User_button.Text = "Delete User";
            this.Delete_User_button.UseVisualStyleBackColor = true;
            this.Delete_User_button.Click += new System.EventHandler(this.Delete_User_button_Click);
            // 
            // DeleteUser_Password_textBox
            // 
            this.DeleteUser_Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser_Password_textBox.Location = new System.Drawing.Point(384, 252);
            this.DeleteUser_Password_textBox.MaxLength = 12;
            this.DeleteUser_Password_textBox.Name = "DeleteUser_Password_textBox";
            this.DeleteUser_Password_textBox.PasswordChar = '*';
            this.DeleteUser_Password_textBox.Size = new System.Drawing.Size(155, 21);
            this.DeleteUser_Password_textBox.TabIndex = 4;
            // 
            // DeleteUser_Name_textBox
            // 
            this.DeleteUser_Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser_Name_textBox.Location = new System.Drawing.Point(384, 200);
            this.DeleteUser_Name_textBox.Name = "DeleteUser_Name_textBox";
            this.DeleteUser_Name_textBox.Size = new System.Drawing.Size(155, 21);
            this.DeleteUser_Name_textBox.TabIndex = 3;
            // 
            // Delete_User_Label
            // 
            this.Delete_User_Label.AutoSize = true;
            this.Delete_User_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_User_Label.Location = new System.Drawing.Point(272, 112);
            this.Delete_User_Label.Name = "Delete_User_Label";
            this.Delete_User_Label.Size = new System.Drawing.Size(159, 24);
            this.Delete_User_Label.TabIndex = 2;
            this.Delete_User_Label.Text = "Delete  Account";
            // 
            // DeleteUser_Password_label
            // 
            this.DeleteUser_Password_label.AutoSize = true;
            this.DeleteUser_Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser_Password_label.Location = new System.Drawing.Point(189, 259);
            this.DeleteUser_Password_label.Name = "DeleteUser_Password_label";
            this.DeleteUser_Password_label.Size = new System.Drawing.Size(113, 16);
            this.DeleteUser_Password_label.TabIndex = 1;
            this.DeleteUser_Password_label.Text = "User Password";
            // 
            // DeleteUser_Name_label
            // 
            this.DeleteUser_Name_label.AutoSize = true;
            this.DeleteUser_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser_Name_label.Location = new System.Drawing.Point(189, 203);
            this.DeleteUser_Name_label.Name = "DeleteUser_Name_label";
            this.DeleteUser_Name_label.Size = new System.Drawing.Size(86, 16);
            this.DeleteUser_Name_label.TabIndex = 0;
            this.DeleteUser_Name_label.Text = "User Name";
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewUser_tabControl);
            this.View_Users_tabPage.Name = "ViewUsers";   //View_Users_tabPage.Nam
            this.Size = new System.Drawing.Size(1020, 646);
            this.Controls.SetChildIndex(this.ViewUser_tabControl, 0);
            this.ViewUser_tabControl.ResumeLayout(false);
            this.View_Users_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Users_gridView)).EndInit();
            this.Delete_Users_tabPage.ResumeLayout(false);
            this.Delete_Users_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ViewUser_tabControl;
        private System.Windows.Forms.TabPage View_Users_tabPage;
        private System.Windows.Forms.TabPage Delete_Users_tabPage;
        private System.Windows.Forms.TextBox DeleteUser_Password_textBox;
        private System.Windows.Forms.TextBox DeleteUser_Name_textBox;
        private System.Windows.Forms.Label Delete_User_Label;
        private System.Windows.Forms.Label DeleteUser_Password_label;
        private System.Windows.Forms.Label DeleteUser_Name_label;
        private System.Windows.Forms.Button Delete_User_button;
        private System.Windows.Forms.DataGridView Users_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessSpecifier;
    }
}
