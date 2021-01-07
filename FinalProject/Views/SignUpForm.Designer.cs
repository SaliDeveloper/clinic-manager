namespace FinalProject.Views
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.table_profile = new System.Windows.Forms.TableLayoutPanel();
            this.table_gender = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtn_Man = new System.Windows.Forms.RadioButton();
            this.radioBtn_Woman = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ctxt_national_code = new FinalProject.Views.CustomTextBox();
            this.ctxt_last_name = new FinalProject.Views.CustomTextBox();
            this.ctxt_name = new FinalProject.Views.CustomTextBox();
            this.table_account = new System.Windows.Forms.TableLayoutPanel();
            this.ctxt_pre_password = new FinalProject.Views.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctxt_confirm_password = new FinalProject.Views.CustomTextBox();
            this.ctxt_password = new FinalProject.Views.CustomTextBox();
            this.ctxt_username = new FinalProject.Views.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.table_profile.SuspendLayout();
            this.table_gender.SuspendLayout();
            this.table_account.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(312, 6);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 48);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(159, 6);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(6);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(141, 48);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // table_profile
            // 
            this.table_profile.BackColor = System.Drawing.Color.RoyalBlue;
            this.table_profile.ColumnCount = 1;
            this.table_profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_profile.Controls.Add(this.table_gender, 0, 4);
            this.table_profile.Controls.Add(this.label2, 0, 0);
            this.table_profile.Controls.Add(this.ctxt_national_code, 0, 3);
            this.table_profile.Controls.Add(this.ctxt_last_name, 0, 2);
            this.table_profile.Controls.Add(this.ctxt_name, 0, 1);
            this.table_profile.ForeColor = System.Drawing.Color.White;
            this.table_profile.Location = new System.Drawing.Point(21, 21);
            this.table_profile.Margin = new System.Windows.Forms.Padding(12);
            this.table_profile.Name = "table_profile";
            this.table_profile.Padding = new System.Windows.Forms.Padding(12);
            this.table_profile.RowCount = 5;
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.Size = new System.Drawing.Size(270, 300);
            this.table_profile.TabIndex = 3;
            // 
            // table_gender
            // 
            this.table_gender.ColumnCount = 2;
            this.table_gender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_gender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_gender.Controls.Add(this.radioBtn_Man, 0, 0);
            this.table_gender.Controls.Add(this.radioBtn_Woman, 1, 0);
            this.table_gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_gender.Location = new System.Drawing.Point(21, 238);
            this.table_gender.Margin = new System.Windows.Forms.Padding(9);
            this.table_gender.Name = "table_gender";
            this.table_gender.RowCount = 1;
            this.table_gender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_gender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.table_gender.Size = new System.Drawing.Size(228, 41);
            this.table_gender.TabIndex = 20;
            // 
            // radioBtn_Man
            // 
            this.radioBtn_Man.AutoSize = true;
            this.radioBtn_Man.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtn_Man.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_Man.Name = "radioBtn_Man";
            this.radioBtn_Man.Size = new System.Drawing.Size(108, 35);
            this.radioBtn_Man.TabIndex = 0;
            this.radioBtn_Man.TabStop = true;
            this.radioBtn_Man.Text = "Man";
            this.radioBtn_Man.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Woman
            // 
            this.radioBtn_Woman.AutoSize = true;
            this.radioBtn_Woman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtn_Woman.Location = new System.Drawing.Point(117, 3);
            this.radioBtn_Woman.Name = "radioBtn_Woman";
            this.radioBtn_Woman.Size = new System.Drawing.Size(108, 35);
            this.radioBtn_Woman.TabIndex = 1;
            this.radioBtn_Woman.TabStop = true;
            this.radioBtn_Woman.Text = "Woman";
            this.radioBtn_Woman.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Personal Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxt_national_code
            // 
            this.ctxt_national_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_national_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_national_code.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_national_code.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_national_code.HintText = "National Code*";
            this.ctxt_national_code.Location = new System.Drawing.Point(15, 184);
            this.ctxt_national_code.Name = "ctxt_national_code";
            this.ctxt_national_code.Size = new System.Drawing.Size(240, 30);
            this.ctxt_national_code.TabIndex = 17;
            this.ctxt_national_code.Text = "National Code*";
            this.ctxt_national_code.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // ctxt_last_name
            // 
            this.ctxt_last_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_last_name.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_last_name.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_last_name.HintText = "Last Name*";
            this.ctxt_last_name.Location = new System.Drawing.Point(15, 125);
            this.ctxt_last_name.Name = "ctxt_last_name";
            this.ctxt_last_name.Size = new System.Drawing.Size(240, 30);
            this.ctxt_last_name.TabIndex = 16;
            this.ctxt_last_name.Text = "Last Name*";
            this.ctxt_last_name.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // ctxt_name
            // 
            this.ctxt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_name.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_name.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_name.HintText = "First Name";
            this.ctxt_name.Location = new System.Drawing.Point(15, 66);
            this.ctxt_name.Name = "ctxt_name";
            this.ctxt_name.Size = new System.Drawing.Size(240, 30);
            this.ctxt_name.TabIndex = 15;
            this.ctxt_name.Text = "First Name*";
            this.ctxt_name.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // table_account
            // 
            this.table_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.table_account.BackColor = System.Drawing.Color.RoyalBlue;
            this.table_account.ColumnCount = 1;
            this.table_account.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_account.Controls.Add(this.ctxt_pre_password, 0, 2);
            this.table_account.Controls.Add(this.label3, 0, 0);
            this.table_account.Controls.Add(this.ctxt_confirm_password, 0, 4);
            this.table_account.Controls.Add(this.ctxt_password, 0, 3);
            this.table_account.Controls.Add(this.ctxt_username, 0, 1);
            this.table_account.ForeColor = System.Drawing.Color.White;
            this.table_account.Location = new System.Drawing.Point(321, 21);
            this.table_account.Margin = new System.Windows.Forms.Padding(12);
            this.table_account.Name = "table_account";
            this.table_account.Padding = new System.Windows.Forms.Padding(12);
            this.table_account.RowCount = 5;
            this.table_account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_account.Size = new System.Drawing.Size(270, 300);
            this.table_account.TabIndex = 4;
            // 
            // ctxt_pre_password
            // 
            this.ctxt_pre_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_pre_password.Enabled = false;
            this.ctxt_pre_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_pre_password.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_pre_password.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_pre_password.HintText = "Previous Password*";
            this.ctxt_pre_password.Location = new System.Drawing.Point(15, 125);
            this.ctxt_pre_password.Name = "ctxt_pre_password";
            this.ctxt_pre_password.Size = new System.Drawing.Size(240, 30);
            this.ctxt_pre_password.TabIndex = 20;
            this.ctxt_pre_password.Text = "Enter Password:";
            this.ctxt_pre_password.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "UserAccount Info";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxt_confirm_password
            // 
            this.ctxt_confirm_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_confirm_password.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_confirm_password.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_confirm_password.HintText = "Conform Password*";
            this.ctxt_confirm_password.Location = new System.Drawing.Point(15, 243);
            this.ctxt_confirm_password.Name = "ctxt_confirm_password";
            this.ctxt_confirm_password.Size = new System.Drawing.Size(240, 30);
            this.ctxt_confirm_password.TabIndex = 17;
            this.ctxt_confirm_password.Text = "Conform Password*";
            this.ctxt_confirm_password.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // ctxt_password
            // 
            this.ctxt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_password.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_password.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_password.HintText = "Password*";
            this.ctxt_password.Location = new System.Drawing.Point(15, 184);
            this.ctxt_password.Name = "ctxt_password";
            this.ctxt_password.Size = new System.Drawing.Size(240, 30);
            this.ctxt_password.TabIndex = 16;
            this.ctxt_password.Text = "Password*";
            this.ctxt_password.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // ctxt_username
            // 
            this.ctxt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctxt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.ctxt_username.HintColor = System.Drawing.Color.DarkGray;
            this.ctxt_username.HintText = "UserName (optional)";
            this.ctxt_username.Location = new System.Drawing.Point(15, 66);
            this.ctxt_username.Name = "ctxt_username";
            this.ctxt_username.Size = new System.Drawing.Size(240, 30);
            this.ctxt_username.TabIndex = 15;
            this.ctxt_username.Text = "UserName (optional)";
            this.ctxt_username.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_confirm, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 373);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.table_account);
            this.Controls.Add(this.table_profile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            this.table_profile.ResumeLayout(false);
            this.table_profile.PerformLayout();
            this.table_gender.ResumeLayout(false);
            this.table_gender.PerformLayout();
            this.table_account.ResumeLayout(false);
            this.table_account.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TableLayoutPanel table_profile;
        private System.Windows.Forms.TableLayoutPanel table_gender;
        private System.Windows.Forms.RadioButton radioBtn_Man;
        private System.Windows.Forms.RadioButton radioBtn_Woman;
        private System.Windows.Forms.Label label2;
        private CustomTextBox ctxt_national_code;
        private CustomTextBox ctxt_last_name;
        private CustomTextBox ctxt_name;
        private System.Windows.Forms.TableLayoutPanel table_account;
        private System.Windows.Forms.Label label3;
        private CustomTextBox ctxt_confirm_password;
        private CustomTextBox ctxt_password;
        private CustomTextBox ctxt_username;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomTextBox ctxt_pre_password;
    }
}