namespace ZAMS
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignupPanel = new System.Windows.Forms.Panel();
            this.Role_comboBox = new System.Windows.Forms.ComboBox();
            this.pass_conpassCodition_label = new System.Windows.Forms.Label();
            this.UserRole_TextBox = new System.Windows.Forms.TextBox();
            this.UserRole_Label = new System.Windows.Forms.Label();
            this.UserAddress_Label = new System.Windows.Forms.Label();
            this.UserAddress_TextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_Label = new System.Windows.Forms.Label();
            this.PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Conform_UserPassword_Label = new System.Windows.Forms.Label();
            this.Conform_UserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.UserPassword_Label = new System.Windows.Forms.Label();
            this.UserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.All_FieldsCondition_Label = new System.Windows.Forms.Label();
            this.WellCome_Label = new System.Windows.Forms.Label();
            this.create_Accoutn_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUp_label = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SignupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignupPanel
            // 
            this.SignupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignupPanel.Controls.Add(this.Role_comboBox);
            this.SignupPanel.Controls.Add(this.pass_conpassCodition_label);
            this.SignupPanel.Controls.Add(this.UserRole_TextBox);
            this.SignupPanel.Controls.Add(this.UserRole_Label);
            this.SignupPanel.Controls.Add(this.UserAddress_Label);
            this.SignupPanel.Controls.Add(this.UserAddress_TextBox);
            this.SignupPanel.Controls.Add(this.PhoneNumber_Label);
            this.SignupPanel.Controls.Add(this.PhoneNumber_TextBox);
            this.SignupPanel.Controls.Add(this.Conform_UserPassword_Label);
            this.SignupPanel.Controls.Add(this.Conform_UserPassword_TextBox);
            this.SignupPanel.Controls.Add(this.UserPassword_Label);
            this.SignupPanel.Controls.Add(this.UserPassword_TextBox);
            this.SignupPanel.Controls.Add(this.UserName_Label);
            this.SignupPanel.Controls.Add(this.UserName_TextBox);
            this.SignupPanel.Location = new System.Drawing.Point(738, 74);
            this.SignupPanel.Name = "SignupPanel";
            this.SignupPanel.Size = new System.Drawing.Size(480, 543);
            this.SignupPanel.TabIndex = 2;
            // 
            // Role_comboBox
            // 
            this.Role_comboBox.FormattingEnabled = true;
            this.Role_comboBox.Items.AddRange(new object[] {
            "AccountManager",
            "Admin",
            "BankUser",
            "PattyCashUser"});
            this.Role_comboBox.Location = new System.Drawing.Point(226, 442);
            this.Role_comboBox.Name = "Role_comboBox";
            this.Role_comboBox.Size = new System.Drawing.Size(237, 21);
            this.Role_comboBox.Sorted = true;
            this.Role_comboBox.TabIndex = 13;
            this.Role_comboBox.SelectedIndexChanged += new System.EventHandler(this.Role_comboBox_SelectedIndexChanged);
            // 
            // pass_conpassCodition_label
            // 
            this.pass_conpassCodition_label.AutoSize = true;
            this.pass_conpassCodition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_conpassCodition_label.ForeColor = System.Drawing.Color.Red;
            this.pass_conpassCodition_label.Location = new System.Drawing.Point(136, 503);
            this.pass_conpassCodition_label.Name = "pass_conpassCodition_label";
            this.pass_conpassCodition_label.Size = new System.Drawing.Size(315, 15);
            this.pass_conpassCodition_label.TabIndex = 12;
            this.pass_conpassCodition_label.Text = "Password and Conform Password must be same";
            this.pass_conpassCodition_label.Visible = false;
            // 
            // UserRole_TextBox
            // 
            this.UserRole_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRole_TextBox.Location = new System.Drawing.Point(236, 451);
            this.UserRole_TextBox.Name = "UserRole_TextBox";
            this.UserRole_TextBox.Size = new System.Drawing.Size(192, 22);
            this.UserRole_TextBox.TabIndex = 11;
            this.UserRole_TextBox.Visible = false;
            // 
            // UserRole_Label
            // 
            this.UserRole_Label.AutoSize = true;
            this.UserRole_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRole_Label.Location = new System.Drawing.Point(37, 458);
            this.UserRole_Label.Name = "UserRole_Label";
            this.UserRole_Label.Size = new System.Drawing.Size(41, 16);
            this.UserRole_Label.TabIndex = 10;
            this.UserRole_Label.Text = "Role";
            // 
            // UserAddress_Label
            // 
            this.UserAddress_Label.AutoSize = true;
            this.UserAddress_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAddress_Label.Location = new System.Drawing.Point(37, 343);
            this.UserAddress_Label.Name = "UserAddress_Label";
            this.UserAddress_Label.Size = new System.Drawing.Size(99, 16);
            this.UserAddress_Label.TabIndex = 9;
            this.UserAddress_Label.Text = "UserAddress";
            // 
            // UserAddress_TextBox
            // 
            this.UserAddress_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAddress_TextBox.Location = new System.Drawing.Point(236, 292);
            this.UserAddress_TextBox.Multiline = true;
            this.UserAddress_TextBox.Name = "UserAddress_TextBox";
            this.UserAddress_TextBox.Size = new System.Drawing.Size(192, 124);
            this.UserAddress_TextBox.TabIndex = 8;
            // 
            // PhoneNumber_Label
            // 
            this.PhoneNumber_Label.AutoSize = true;
            this.PhoneNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_Label.Location = new System.Drawing.Point(35, 234);
            this.PhoneNumber_Label.Name = "PhoneNumber_Label";
            this.PhoneNumber_Label.Size = new System.Drawing.Size(116, 16);
            this.PhoneNumber_Label.TabIndex = 7;
            this.PhoneNumber_Label.Text = "* PhoneNumber";
            this.PhoneNumber_Label.Click += new System.EventHandler(this.PhoneNumber_Label_Click);
            // 
            // PhoneNumber_TextBox
            // 
            this.PhoneNumber_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_TextBox.Location = new System.Drawing.Point(236, 222);
            this.PhoneNumber_TextBox.Multiline = true;
            this.PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            this.PhoneNumber_TextBox.Size = new System.Drawing.Size(192, 34);
            this.PhoneNumber_TextBox.TabIndex = 6;
            // 
            // Conform_UserPassword_Label
            // 
            this.Conform_UserPassword_Label.AutoSize = true;
            this.Conform_UserPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conform_UserPassword_Label.Location = new System.Drawing.Point(34, 169);
            this.Conform_UserPassword_Label.Name = "Conform_UserPassword_Label";
            this.Conform_UserPassword_Label.Size = new System.Drawing.Size(147, 16);
            this.Conform_UserPassword_Label.TabIndex = 5;
            this.Conform_UserPassword_Label.Text = "* Conform Password";
            this.Conform_UserPassword_Label.Click += new System.EventHandler(this.Conform_UserPassword_Label_Click);
            // 
            // Conform_UserPassword_TextBox
            // 
            this.Conform_UserPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conform_UserPassword_TextBox.Location = new System.Drawing.Point(236, 157);
            this.Conform_UserPassword_TextBox.MaxLength = 12;
            this.Conform_UserPassword_TextBox.Multiline = true;
            this.Conform_UserPassword_TextBox.Name = "Conform_UserPassword_TextBox";
            this.Conform_UserPassword_TextBox.PasswordChar = '*';
            this.Conform_UserPassword_TextBox.Size = new System.Drawing.Size(192, 35);
            this.Conform_UserPassword_TextBox.TabIndex = 4;
            // 
            // UserPassword_Label
            // 
            this.UserPassword_Label.AutoSize = true;
            this.UserPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword_Label.Location = new System.Drawing.Point(35, 105);
            this.UserPassword_Label.Name = "UserPassword_Label";
            this.UserPassword_Label.Size = new System.Drawing.Size(123, 16);
            this.UserPassword_Label.TabIndex = 3;
            this.UserPassword_Label.Text = "* User Password";
            this.UserPassword_Label.Click += new System.EventHandler(this.UserPassword_Label_Click);
            // 
            // UserPassword_TextBox
            // 
            this.UserPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword_TextBox.Location = new System.Drawing.Point(236, 93);
            this.UserPassword_TextBox.MaxLength = 12;
            this.UserPassword_TextBox.Multiline = true;
            this.UserPassword_TextBox.Name = "UserPassword_TextBox";
            this.UserPassword_TextBox.PasswordChar = '*';
            this.UserPassword_TextBox.Size = new System.Drawing.Size(192, 35);
            this.UserPassword_TextBox.TabIndex = 2;
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(37, 42);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(67, 16);
            this.UserName_Label.TabIndex = 1;
            this.UserName_Label.Text = "* Name :";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_TextBox.Location = new System.Drawing.Point(236, 30);
            this.UserName_TextBox.Multiline = true;
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(192, 36);
            this.UserName_TextBox.TabIndex = 0;
            // 
            // All_FieldsCondition_Label
            // 
            this.All_FieldsCondition_Label.AutoSize = true;
            this.All_FieldsCondition_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_FieldsCondition_Label.ForeColor = System.Drawing.Color.Red;
            this.All_FieldsCondition_Label.Location = new System.Drawing.Point(750, 661);
            this.All_FieldsCondition_Label.Name = "All_FieldsCondition_Label";
            this.All_FieldsCondition_Label.Size = new System.Drawing.Size(267, 24);
            this.All_FieldsCondition_Label.TabIndex = 8;
            this.All_FieldsCondition_Label.Text = "Fields With * are Mandatory";
            this.All_FieldsCondition_Label.Visible = false;
            // 
            // WellCome_Label
            // 
            this.WellCome_Label.AutoSize = true;
            this.WellCome_Label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.WellCome_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WellCome_Label.Location = new System.Drawing.Point(103, 74);
            this.WellCome_Label.Name = "WellCome_Label";
            this.WellCome_Label.Size = new System.Drawing.Size(582, 31);
            this.WellCome_Label.TabIndex = 3;
            this.WellCome_Label.Text = "WellCome ! In Zikria Construction Company";
            // 
            // create_Accoutn_Button
            // 
            this.create_Accoutn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Accoutn_Button.Location = new System.Drawing.Point(1050, 642);
            this.create_Accoutn_Button.Name = "create_Accoutn_Button";
            this.create_Accoutn_Button.Size = new System.Drawing.Size(168, 65);
            this.create_Accoutn_Button.TabIndex = 4;
            this.create_Accoutn_Button.Text = "CREATE ACCOUNT";
            this.create_Accoutn_Button.UseVisualStyleBackColor = true;
            this.create_Accoutn_Button.Click += new System.EventHandler(this.create_Accoutn_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 465);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUp_label
            // 
            this.SignUp_label.AutoSize = true;
            this.SignUp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_label.Location = new System.Drawing.Point(928, 33);
            this.SignUp_label.Name = "SignUp_label";
            this.SignUp_label.Size = new System.Drawing.Size(99, 29);
            this.SignUp_label.TabIndex = 6;
            this.SignUp_label.Text = "SignUp";
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(89, 642);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(168, 65);
            this.Back_Button.TabIndex = 7;
            this.Back_Button.Text = "< Back >";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.All_FieldsCondition_Label);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.SignUp_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_Accoutn_Button);
            this.Controls.Add(this.WellCome_Label);
            this.Controls.Add(this.SignupPanel);
            this.Name = "SignUpForm";
            this.Text = "                                                           ";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.SignupPanel.ResumeLayout(false);
            this.SignupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SignupPanel;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.Label WellCome_Label;
        private System.Windows.Forms.Label UserPassword_Label;
        private System.Windows.Forms.TextBox UserPassword_TextBox;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.TextBox Conform_UserPassword_TextBox;
        private System.Windows.Forms.Label Conform_UserPassword_Label;
        private System.Windows.Forms.TextBox PhoneNumber_TextBox;
        private System.Windows.Forms.Label PhoneNumber_Label;
        private System.Windows.Forms.Label UserAddress_Label;
        private System.Windows.Forms.TextBox UserAddress_TextBox;
        private System.Windows.Forms.Label UserRole_Label;
        private System.Windows.Forms.TextBox UserRole_TextBox;
        private System.Windows.Forms.Button create_Accoutn_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SignUp_label;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label All_FieldsCondition_Label;
        private System.Windows.Forms.Label pass_conpassCodition_label;
        private System.Windows.Forms.ComboBox Role_comboBox;
    }
}