namespace FinalProject.Views
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_edit_profile = new System.Windows.Forms.Button();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.table_profile = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_4_1 = new System.Windows.Forms.Label();
            this.lbl_4_2 = new System.Windows.Forms.Label();
            this.lbl_3_1 = new System.Windows.Forms.Label();
            this.lbl_3_2 = new System.Windows.Forms.Label();
            this.lbl_2_2 = new System.Windows.Forms.Label();
            this.lbl_2_1 = new System.Windows.Forms.Label();
            this.lbl_1_2 = new System.Windows.Forms.Label();
            this.lbl_1_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add_appointment = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.table_search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.table_radiobtn = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.table_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.table_search.SuspendLayout();
            this.table_radiobtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_edit_profile);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_profile);
            this.splitContainer1.Panel1.Controls.Add(this.table_profile);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.btn_add_appointment);
            this.splitContainer1.Panel2.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel2.Controls.Add(this.table_search);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 553);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_edit_profile
            // 
            this.btn_edit_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_profile.AutoSize = true;
            this.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_profile.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit_profile.Image = global::FinalProject.Properties.Resources.edit_icon;
            this.btn_edit_profile.Location = new System.Drawing.Point(333, 276);
            this.btn_edit_profile.Name = "btn_edit_profile";
            this.btn_edit_profile.Padding = new System.Windows.Forms.Padding(3);
            this.btn_edit_profile.Size = new System.Drawing.Size(34, 34);
            this.btn_edit_profile.TabIndex = 13;
            this.btn_edit_profile.UseVisualStyleBackColor = true;
            this.btn_edit_profile.Click += new System.EventHandler(this.btn_edit_profile_Click);
            // 
            // lbl_profile
            // 
            this.lbl_profile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile.Location = new System.Drawing.Point(3, 276);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(304, 34);
            this.lbl_profile.TabIndex = 12;
            this.lbl_profile.Text = "PatientId Information";
            this.lbl_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // table_profile
            // 
            this.table_profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_profile.BackColor = System.Drawing.Color.AliceBlue;
            this.table_profile.ColumnCount = 2;
            this.table_profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.table_profile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.table_profile.Controls.Add(this.lbl_4_1, 0, 3);
            this.table_profile.Controls.Add(this.lbl_4_2, 0, 3);
            this.table_profile.Controls.Add(this.lbl_3_1, 0, 2);
            this.table_profile.Controls.Add(this.lbl_3_2, 0, 2);
            this.table_profile.Controls.Add(this.lbl_2_2, 1, 1);
            this.table_profile.Controls.Add(this.lbl_2_1, 0, 1);
            this.table_profile.Controls.Add(this.lbl_1_2, 1, 0);
            this.table_profile.Controls.Add(this.lbl_1_1, 0, 0);
            this.table_profile.Location = new System.Drawing.Point(7, 316);
            this.table_profile.Name = "table_profile";
            this.table_profile.RowCount = 4;
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.Size = new System.Drawing.Size(370, 174);
            this.table_profile.TabIndex = 11;
            // 
            // lbl_4_1
            // 
            this.lbl_4_1.AutoSize = true;
            this.lbl_4_1.BackColor = System.Drawing.Color.White;
            this.lbl_4_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_4_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4_1.Location = new System.Drawing.Point(0, 129);
            this.lbl_4_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_4_1.Name = "lbl_4_1";
            this.lbl_4_1.Size = new System.Drawing.Size(148, 45);
            this.lbl_4_1.TabIndex = 7;
            this.lbl_4_1.Text = "Insurance:";
            this.lbl_4_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_4_2
            // 
            this.lbl_4_2.AutoSize = true;
            this.lbl_4_2.BackColor = System.Drawing.Color.White;
            this.lbl_4_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_4_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4_2.Location = new System.Drawing.Point(148, 129);
            this.lbl_4_2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_4_2.Name = "lbl_4_2";
            this.lbl_4_2.Size = new System.Drawing.Size(222, 45);
            this.lbl_4_2.TabIndex = 6;
            this.lbl_4_2.Text = "2020/10/5";
            this.lbl_4_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_3_1
            // 
            this.lbl_3_1.AutoSize = true;
            this.lbl_3_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3_1.Location = new System.Drawing.Point(0, 86);
            this.lbl_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_3_1.Name = "lbl_3_1";
            this.lbl_3_1.Size = new System.Drawing.Size(148, 43);
            this.lbl_3_1.TabIndex = 5;
            this.lbl_3_1.Text = "Gender:";
            this.lbl_3_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_3_2
            // 
            this.lbl_3_2.AutoSize = true;
            this.lbl_3_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3_2.Location = new System.Drawing.Point(148, 86);
            this.lbl_3_2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_3_2.Name = "lbl_3_2";
            this.lbl_3_2.Size = new System.Drawing.Size(222, 43);
            this.lbl_3_2.TabIndex = 4;
            this.lbl_3_2.Text = "Man";
            this.lbl_3_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_2_2
            // 
            this.lbl_2_2.AutoSize = true;
            this.lbl_2_2.BackColor = System.Drawing.Color.White;
            this.lbl_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2_2.Location = new System.Drawing.Point(148, 43);
            this.lbl_2_2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_2_2.Name = "lbl_2_2";
            this.lbl_2_2.Size = new System.Drawing.Size(222, 43);
            this.lbl_2_2.TabIndex = 3;
            this.lbl_2_2.Text = "4420860278";
            this.lbl_2_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_2_1
            // 
            this.lbl_2_1.AutoSize = true;
            this.lbl_2_1.BackColor = System.Drawing.Color.White;
            this.lbl_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2_1.Location = new System.Drawing.Point(0, 43);
            this.lbl_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_2_1.Name = "lbl_2_1";
            this.lbl_2_1.Size = new System.Drawing.Size(148, 43);
            this.lbl_2_1.TabIndex = 2;
            this.lbl_2_1.Text = "NationalCode:";
            this.lbl_2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_1_2
            // 
            this.lbl_1_2.AutoSize = true;
            this.lbl_1_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1_2.Location = new System.Drawing.Point(148, 0);
            this.lbl_1_2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_1_2.Name = "lbl_1_2";
            this.lbl_1_2.Size = new System.Drawing.Size(222, 43);
            this.lbl_1_2.TabIndex = 1;
            this.lbl_1_2.Text = "Mohammad Mahdi Salmani";
            this.lbl_1_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_1_1
            // 
            this.lbl_1_1.AutoSize = true;
            this.lbl_1_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1_1.Location = new System.Drawing.Point(0, 0);
            this.lbl_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_1_1.Name = "lbl_1_1";
            this.lbl_1_1.Size = new System.Drawing.Size(148, 43);
            this.lbl_1_1.TabIndex = 0;
            this.lbl_1_1.Text = "Name:";
            this.lbl_1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.clinic;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add_appointment
            // 
            this.btn_add_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_appointment.AutoSize = true;
            this.btn_add_appointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_add_appointment.Location = new System.Drawing.Point(6, 499);
            this.btn_add_appointment.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_appointment.Name = "btn_add_appointment";
            this.btn_add_appointment.Size = new System.Drawing.Size(205, 39);
            this.btn_add_appointment.TabIndex = 5;
            this.btn_add_appointment.Text = "New Appointment";
            this.btn_add_appointment.UseVisualStyleBackColor = false;
            this.btn_add_appointment.Click += new System.EventHandler(this.btn_add_appointment_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_exit.Location = new System.Drawing.Point(595, 499);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // table_search
            // 
            this.table_search.ColumnCount = 3;
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.table_search.Controls.Add(this.btn_search, 0, 0);
            this.table_search.Controls.Add(this.txt_search, 1, 0);
            this.table_search.Controls.Add(this.table_radiobtn, 2, 0);
            this.table_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_search.Location = new System.Drawing.Point(0, 0);
            this.table_search.Margin = new System.Windows.Forms.Padding(0);
            this.table_search.Name = "table_search";
            this.table_search.RowCount = 1;
            this.table_search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_search.Size = new System.Drawing.Size(698, 50);
            this.table_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = true;
            this.btn_search.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(6, 8);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6, 8, 3, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(76, 34);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_search.Location = new System.Drawing.Point(91, 8);
            this.txt_search.Margin = new System.Windows.Forms.Padding(6);
            this.txt_search.MaxLength = 100;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(491, 34);
            this.txt_search.TabIndex = 0;
            // 
            // table_radiobtn
            // 
            this.table_radiobtn.ColumnCount = 1;
            this.table_radiobtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_radiobtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_radiobtn.Controls.Add(this.radioButton1, 0, 0);
            this.table_radiobtn.Controls.Add(this.radioButton2, 0, 1);
            this.table_radiobtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_radiobtn.Location = new System.Drawing.Point(588, 3);
            this.table_radiobtn.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.table_radiobtn.Name = "table_radiobtn";
            this.table_radiobtn.RowCount = 2;
            this.table_radiobtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_radiobtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_radiobtn.Size = new System.Drawing.Size(98, 44);
            this.table_radiobtn.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "doctor";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(0, 22);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "specialty";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.StartTime,
            this.Duration,
            this.Specialty,
            this.Doctor,
            this.Edit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 437);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 80;
            // 
            // Specialty
            // 
            this.Specialty.HeaderText = "Specialty";
            this.Specialty.MinimumWidth = 6;
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            this.Specialty.Width = 130;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Width = 130;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "";
            this.Edit.Width = 60;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.table_profile.ResumeLayout(false);
            this.table_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.table_search.ResumeLayout(false);
            this.table_search.PerformLayout();
            this.table_radiobtn.ResumeLayout(false);
            this.table_radiobtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_3_1;
        private System.Windows.Forms.Label lbl_3_2;
        private System.Windows.Forms.Label lbl_2_2;
        private System.Windows.Forms.Label lbl_2_1;
        private System.Windows.Forms.Label lbl_1_2;
        private System.Windows.Forms.Label lbl_1_1;
        private System.Windows.Forms.Button btn_edit_profile;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TableLayoutPanel table_radiobtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        protected System.Windows.Forms.Label lbl_profile;
        protected System.Windows.Forms.TableLayoutPanel table_search;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TableLayoutPanel table_profile;
        protected System.Windows.Forms.Label lbl_4_1;
        protected System.Windows.Forms.Label lbl_4_2;
        private System.Windows.Forms.Button btn_add_appointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}