namespace ZAMS
{
    partial class ChangePasswordForm
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
            this.Current_Password_Label = new System.Windows.Forms.Label();
            this.Current_Password_TextBox = new System.Windows.Forms.TextBox();
            this.NewPassword_Label = new System.Windows.Forms.Label();
            this.NewPassword_TextBox = new System.Windows.Forms.TextBox();
            this.Conform_New_Password_Label = new System.Windows.Forms.Label();
            this.Conform_New_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Change_Password_NewForm_Button = new System.Windows.Forms.Button();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.pass_and_confPass_Label_Condition = new System.Windows.Forms.Label();
            this.CurrentPassword_invalid_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Current_Password_Label
            // 
            this.Current_Password_Label.AutoSize = true;
            this.Current_Password_Label.Location = new System.Drawing.Point(128, 91);
            this.Current_Password_Label.Name = "Current_Password_Label";
            this.Current_Password_Label.Size = new System.Drawing.Size(90, 13);
            this.Current_Password_Label.TabIndex = 0;
            this.Current_Password_Label.Text = "Current Password";
            // 
            // Current_Password_TextBox
            // 
            this.Current_Password_TextBox.Location = new System.Drawing.Point(318, 88);
            this.Current_Password_TextBox.Name = "Current_Password_TextBox";
            this.Current_Password_TextBox.Size = new System.Drawing.Size(158, 20);
            this.Current_Password_TextBox.TabIndex = 1;
            // 
            // NewPassword_Label
            // 
            this.NewPassword_Label.AutoSize = true;
            this.NewPassword_Label.Location = new System.Drawing.Point(128, 142);
            this.NewPassword_Label.Name = "NewPassword_Label";
            this.NewPassword_Label.Size = new System.Drawing.Size(78, 13);
            this.NewPassword_Label.TabIndex = 2;
            this.NewPassword_Label.Text = "New Password";
            // 
            // NewPassword_TextBox
            // 
            this.NewPassword_TextBox.Location = new System.Drawing.Point(318, 139);
            this.NewPassword_TextBox.MaxLength = 12;
            this.NewPassword_TextBox.Name = "NewPassword_TextBox";
            this.NewPassword_TextBox.PasswordChar = '*';
            this.NewPassword_TextBox.Size = new System.Drawing.Size(158, 20);
            this.NewPassword_TextBox.TabIndex = 3;
            // 
            // Conform_New_Password_Label
            // 
            this.Conform_New_Password_Label.AutoSize = true;
            this.Conform_New_Password_Label.Location = new System.Drawing.Point(128, 188);
            this.Conform_New_Password_Label.Name = "Conform_New_Password_Label";
            this.Conform_New_Password_Label.Size = new System.Drawing.Size(120, 13);
            this.Conform_New_Password_Label.TabIndex = 4;
            this.Conform_New_Password_Label.Text = "Conform New Password";
            // 
            // Conform_New_Password_TextBox
            // 
            this.Conform_New_Password_TextBox.Location = new System.Drawing.Point(318, 185);
            this.Conform_New_Password_TextBox.MaxLength = 12;
            this.Conform_New_Password_TextBox.Name = "Conform_New_Password_TextBox";
            this.Conform_New_Password_TextBox.PasswordChar = '*';
            this.Conform_New_Password_TextBox.Size = new System.Drawing.Size(158, 20);
            this.Conform_New_Password_TextBox.TabIndex = 5;
            // 
            // Change_Password_NewForm_Button
            // 
            this.Change_Password_NewForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password_NewForm_Button.ForeColor = System.Drawing.Color.Fuchsia;
            this.Change_Password_NewForm_Button.Location = new System.Drawing.Point(204, 251);
            this.Change_Password_NewForm_Button.Name = "Change_Password_NewForm_Button";
            this.Change_Password_NewForm_Button.Size = new System.Drawing.Size(208, 48);
            this.Change_Password_NewForm_Button.TabIndex = 6;
            this.Change_Password_NewForm_Button.Text = "Change Password";
            this.Change_Password_NewForm_Button.UseVisualStyleBackColor = true;
            this.Change_Password_NewForm_Button.Click += new System.EventHandler(this.Change_Password_NewForm_Button_Click);
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordLabel.Location = new System.Drawing.Point(28, 38);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(252, 24);
            this.ChangePasswordLabel.TabIndex = 7;
            this.ChangePasswordLabel.Text = "Change The Password";
            // 
            // pass_and_confPass_Label_Condition
            // 
            this.pass_and_confPass_Label_Condition.AutoSize = true;
            this.pass_and_confPass_Label_Condition.ForeColor = System.Drawing.Color.Red;
            this.pass_and_confPass_Label_Condition.Location = new System.Drawing.Point(315, 224);
            this.pass_and_confPass_Label_Condition.Name = "pass_and_confPass_Label_Condition";
            this.pass_and_confPass_Label_Condition.Size = new System.Drawing.Size(233, 13);
            this.pass_and_confPass_Label_Condition.TabIndex = 8;
            this.pass_and_confPass_Label_Condition.Text = "Password and Conform Password must be same\r\n";
            this.pass_and_confPass_Label_Condition.Visible = false;
            // 
            // CurrentPassword_invalid_label
            // 
            this.CurrentPassword_invalid_label.AutoSize = true;
            this.CurrentPassword_invalid_label.ForeColor = System.Drawing.Color.Red;
            this.CurrentPassword_invalid_label.Location = new System.Drawing.Point(502, 95);
            this.CurrentPassword_invalid_label.Name = "CurrentPassword_invalid_label";
            this.CurrentPassword_invalid_label.Size = new System.Drawing.Size(39, 13);
            this.CurrentPassword_invalid_label.TabIndex = 9;
            this.CurrentPassword_invalid_label.Text = "InValid";
            this.CurrentPassword_invalid_label.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.CurrentPassword_invalid_label);
            this.Controls.Add(this.pass_and_confPass_Label_Condition);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.Change_Password_NewForm_Button);
            this.Controls.Add(this.Conform_New_Password_TextBox);
            this.Controls.Add(this.Conform_New_Password_Label);
            this.Controls.Add(this.NewPassword_TextBox);
            this.Controls.Add(this.NewPassword_Label);
            this.Controls.Add(this.Current_Password_TextBox);
            this.Controls.Add(this.Current_Password_Label);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Current_Password_Label;
        private System.Windows.Forms.TextBox Current_Password_TextBox;
        private System.Windows.Forms.Label NewPassword_Label;
        private System.Windows.Forms.TextBox NewPassword_TextBox;
        private System.Windows.Forms.Label Conform_New_Password_Label;
        private System.Windows.Forms.TextBox Conform_New_Password_TextBox;
        private System.Windows.Forms.Button Change_Password_NewForm_Button;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label pass_and_confPass_Label_Condition;
        private System.Windows.Forms.Label CurrentPassword_invalid_label;
    }
}