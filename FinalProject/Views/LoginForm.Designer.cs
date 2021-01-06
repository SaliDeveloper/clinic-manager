namespace FinalProject.Views
{
    partial class LoginForm
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
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_username = new FinalProject.Views.CustomTextBox();
            this.txt_password = new FinalProject.Views.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.linklbl_forgot_password = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.cmb_login_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_type.Location = new System.Drawing.Point(12, 110);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(54, 22);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Type:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.HintColor = System.Drawing.Color.DarkGray;
            this.txt_username.HintText = "UserName";
            this.txt_username.Location = new System.Drawing.Point(16, 188);
            this.txt_username.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(221, 30);
            this.txt_username.TabIndex = 3;
            this.txt_username.Text = "UserName";
            this.txt_username.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.HintColor = System.Drawing.Color.DarkGray;
            this.txt_password.HintText = "Password";
            this.txt_password.Location = new System.Drawing.Point(16, 265);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(221, 30);
            this.txt_password.TabIndex = 4;
            this.txt_password.Text = "Password";
            this.txt_password.TextColor = System.Drawing.SystemColors.WindowText;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Tai Le", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_login.Location = new System.Drawing.Point(15, 12);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(222, 89);
            this.lbl_login.TabIndex = 7;
            this.lbl_login.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.dentist;
            this.pictureBox1.Location = new System.Drawing.Point(269, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(16, 367);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(221, 51);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // linklbl_forgot_password
            // 
            this.linklbl_forgot_password.AutoSize = true;
            this.linklbl_forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_forgot_password.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linklbl_forgot_password.Location = new System.Drawing.Point(62, 427);
            this.linklbl_forgot_password.Name = "linklbl_forgot_password";
            this.linklbl_forgot_password.Size = new System.Drawing.Size(122, 17);
            this.linklbl_forgot_password.TabIndex = 10;
            this.linklbl_forgot_password.TabStop = true;
            this.linklbl_forgot_password.Text = "Forgot Password?";
            this.linklbl_forgot_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.Location = new System.Drawing.Point(16, 334);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_signup
            // 
            this.btn_signup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signup.AutoSize = true;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_signup.Location = new System.Drawing.Point(624, 15);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(6);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Padding = new System.Windows.Forms.Padding(3);
            this.btn_signup.Size = new System.Drawing.Size(83, 38);
            this.btn_signup.TabIndex = 12;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // cmb_login_type
            // 
            this.cmb_login_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_login_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_login_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_login_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_login_type.FormattingEnabled = true;
            this.cmb_login_type.Items.AddRange(new object[] {
            "Patient",
            "Admin",
            "Receptionist"});
            this.cmb_login_type.Location = new System.Drawing.Point(75, 107);
            this.cmb_login_type.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmb_login_type.Name = "cmb_login_type";
            this.cmb_login_type.Size = new System.Drawing.Size(162, 28);
            this.cmb_login_type.TabIndex = 13;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 453);
            this.Controls.Add(this.cmb_login_type);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linklbl_forgot_password);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Clinic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_type;
        private CustomTextBox txt_username;
        private CustomTextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.LinkLabel linklbl_forgot_password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.ComboBox cmb_login_type;
    }
}

