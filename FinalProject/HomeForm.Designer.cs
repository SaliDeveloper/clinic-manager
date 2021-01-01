namespace FinalProject
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_edit_profile = new System.Windows.Forms.Button();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.table_profile = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_4_0 = new System.Windows.Forms.Label();
            this.lbl_4_1 = new System.Windows.Forms.Label();
            this.lbl_3_0 = new System.Windows.Forms.Label();
            this.lbl_3_1 = new System.Windows.Forms.Label();
            this.lbl_2_1 = new System.Windows.Forms.Label();
            this.lbl_2_0 = new System.Windows.Forms.Label();
            this.lbl_1_1 = new System.Windows.Forms.Label();
            this.lbl_1_0 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.table_search = new System.Windows.Forms.TableLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.table_radiobtn = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.table_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.table_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.table_radiobtn.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.table_search);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(982, 553);
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
            this.btn_edit_profile.Location = new System.Drawing.Point(343, 276);
            this.btn_edit_profile.Name = "btn_edit_profile";
            this.btn_edit_profile.Padding = new System.Windows.Forms.Padding(3);
            this.btn_edit_profile.Size = new System.Drawing.Size(34, 34);
            this.btn_edit_profile.TabIndex = 13;
            this.btn_edit_profile.UseVisualStyleBackColor = true;
            // 
            // lbl_profile
            // 
            this.lbl_profile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile.Location = new System.Drawing.Point(3, 276);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(304, 34);
            this.lbl_profile.TabIndex = 12;
            this.lbl_profile.Text = "Patient Information";
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
            this.table_profile.Controls.Add(this.lbl_4_0, 0, 3);
            this.table_profile.Controls.Add(this.lbl_4_1, 0, 3);
            this.table_profile.Controls.Add(this.lbl_3_0, 0, 2);
            this.table_profile.Controls.Add(this.lbl_3_1, 0, 2);
            this.table_profile.Controls.Add(this.lbl_2_1, 1, 1);
            this.table_profile.Controls.Add(this.lbl_2_0, 0, 1);
            this.table_profile.Controls.Add(this.lbl_1_1, 1, 0);
            this.table_profile.Controls.Add(this.lbl_1_0, 0, 0);
            this.table_profile.Location = new System.Drawing.Point(7, 316);
            this.table_profile.Name = "table_profile";
            this.table_profile.RowCount = 4;
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_profile.Size = new System.Drawing.Size(370, 156);
            this.table_profile.TabIndex = 11;
            // 
            // lbl_4_0
            // 
            this.lbl_4_0.AutoSize = true;
            this.lbl_4_0.BackColor = System.Drawing.Color.White;
            this.lbl_4_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_4_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4_0.Location = new System.Drawing.Point(0, 117);
            this.lbl_4_0.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_4_0.Name = "lbl_4_0";
            this.lbl_4_0.Size = new System.Drawing.Size(148, 39);
            this.lbl_4_0.TabIndex = 7;
            this.lbl_4_0.Text = "Insurance:";
            this.lbl_4_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_4_1
            // 
            this.lbl_4_1.AutoSize = true;
            this.lbl_4_1.BackColor = System.Drawing.Color.White;
            this.lbl_4_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_4_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4_1.Location = new System.Drawing.Point(148, 117);
            this.lbl_4_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_4_1.Name = "lbl_4_1";
            this.lbl_4_1.Size = new System.Drawing.Size(222, 39);
            this.lbl_4_1.TabIndex = 6;
            this.lbl_4_1.Text = "2020/10/5";
            this.lbl_4_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_3_0
            // 
            this.lbl_3_0.AutoSize = true;
            this.lbl_3_0.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3_0.Location = new System.Drawing.Point(0, 78);
            this.lbl_3_0.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_3_0.Name = "lbl_3_0";
            this.lbl_3_0.Size = new System.Drawing.Size(148, 39);
            this.lbl_3_0.TabIndex = 5;
            this.lbl_3_0.Text = "Gender:";
            this.lbl_3_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_3_1
            // 
            this.lbl_3_1.AutoSize = true;
            this.lbl_3_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3_1.Location = new System.Drawing.Point(148, 78);
            this.lbl_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_3_1.Name = "lbl_3_1";
            this.lbl_3_1.Size = new System.Drawing.Size(222, 39);
            this.lbl_3_1.TabIndex = 4;
            this.lbl_3_1.Text = "Man";
            this.lbl_3_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_2_1
            // 
            this.lbl_2_1.AutoSize = true;
            this.lbl_2_1.BackColor = System.Drawing.Color.White;
            this.lbl_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2_1.Location = new System.Drawing.Point(148, 39);
            this.lbl_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_2_1.Name = "lbl_2_1";
            this.lbl_2_1.Size = new System.Drawing.Size(222, 39);
            this.lbl_2_1.TabIndex = 3;
            this.lbl_2_1.Text = "4420860278";
            this.lbl_2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_2_0
            // 
            this.lbl_2_0.AutoSize = true;
            this.lbl_2_0.BackColor = System.Drawing.Color.White;
            this.lbl_2_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2_0.Location = new System.Drawing.Point(0, 39);
            this.lbl_2_0.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_2_0.Name = "lbl_2_0";
            this.lbl_2_0.Size = new System.Drawing.Size(148, 39);
            this.lbl_2_0.TabIndex = 2;
            this.lbl_2_0.Text = "NationalCode:";
            this.lbl_2_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_1_1
            // 
            this.lbl_1_1.AutoSize = true;
            this.lbl_1_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1_1.Location = new System.Drawing.Point(148, 0);
            this.lbl_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_1_1.Name = "lbl_1_1";
            this.lbl_1_1.Size = new System.Drawing.Size(222, 39);
            this.lbl_1_1.TabIndex = 1;
            this.lbl_1_1.Text = "Mohammad Mahdi Salmani";
            this.lbl_1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_1_0
            // 
            this.lbl_1_0.AutoSize = true;
            this.lbl_1_0.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1_0.Location = new System.Drawing.Point(0, 0);
            this.lbl_1_0.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_1_0.Name = "lbl_1_0";
            this.lbl_1_0.Size = new System.Drawing.Size(148, 39);
            this.lbl_1_0.TabIndex = 0;
            this.lbl_1_0.Text = "Name:";
            this.lbl_1_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.clinic;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(495, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_search
            // 
            this.table_search.ColumnCount = 3;
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table_search.Controls.Add(this.btn_search, 0, 0);
            this.table_search.Controls.Add(this.txt_search, 1, 0);
            this.table_search.Controls.Add(this.table_radiobtn, 2, 0);
            this.table_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_search.Location = new System.Drawing.Point(0, 0);
            this.table_search.Margin = new System.Windows.Forms.Padding(0);
            this.table_search.Name = "table_search";
            this.table_search.RowCount = 1;
            this.table_search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_search.Size = new System.Drawing.Size(598, 50);
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
            this.txt_search.Size = new System.Drawing.Size(401, 34);
            this.txt_search.TabIndex = 0;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.Duration,
            this.Specialty,
            this.Doctor,
            this.Edit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 437);
            this.dataGridView1.TabIndex = 2;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Specialty
            // 
            this.Specialty.HeaderText = "Specialty";
            this.Specialty.MinimumWidth = 6;
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            this.Specialty.Width = 140;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Width = 140;
            // 
            // Edit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle7;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "";
            this.Edit.Width = 60;
            // 
            // table_radiobtn
            // 
            this.table_radiobtn.ColumnCount = 1;
            this.table_radiobtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_radiobtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_radiobtn.Controls.Add(this.radioButton1, 0, 0);
            this.table_radiobtn.Controls.Add(this.radioButton2, 0, 1);
            this.table_radiobtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_radiobtn.Location = new System.Drawing.Point(501, 3);
            this.table_radiobtn.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.table_radiobtn.Name = "table_radiobtn";
            this.table_radiobtn.RowCount = 2;
            this.table_radiobtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_radiobtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_radiobtn.Size = new System.Drawing.Size(85, 44);
            this.table_radiobtn.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(85, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "doctor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(0, 22);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(85, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "specialty";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.table_radiobtn.ResumeLayout(false);
            this.table_radiobtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel table_profile;
        private System.Windows.Forms.Label lbl_4_0;
        private System.Windows.Forms.Label lbl_4_1;
        private System.Windows.Forms.Label lbl_3_0;
        private System.Windows.Forms.Label lbl_3_1;
        private System.Windows.Forms.Label lbl_2_1;
        private System.Windows.Forms.Label lbl_2_0;
        private System.Windows.Forms.Label lbl_1_1;
        private System.Windows.Forms.Label lbl_1_0;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.Button btn_edit_profile;
        private System.Windows.Forms.TableLayoutPanel table_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TableLayoutPanel table_radiobtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}