namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.group_functions = new System.Windows.Forms.GroupBox();
            this.button_list = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.group_list = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_studentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_scholarshipRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new Proje.ProjectDataSet();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_tc = new System.Windows.Forms.Label();
            this.label_studentNo = new System.Windows.Forms.Label();
            this.studentNo = new System.Windows.Forms.MaskedTextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.MaskedTextBox();
            this.label_faculty = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label_scholarshipRate = new System.Windows.Forms.Label();
            this.scholarshipRate = new System.Windows.Forms.ComboBox();
            this.label_fee = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.label_payment = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.payment = new System.Windows.Forms.TextBox();
            this.label_debt = new System.Windows.Forms.Label();
            this.debt = new System.Windows.Forms.TextBox();
            this.group_register = new System.Windows.Forms.GroupBox();
            this.tableMainTableAdapter = new Proje.ProjectDataSetTableAdapters.tableMainTableAdapter();
            this.button_clear = new System.Windows.Forms.Button();
            this.group_functions.SuspendLayout();
            this.group_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.group_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_functions
            // 
            this.group_functions.Controls.Add(this.button_list);
            this.group_functions.Controls.Add(this.button_update);
            this.group_functions.Controls.Add(this.button_delete);
            this.group_functions.Controls.Add(this.button_add);
            this.group_functions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_functions.ForeColor = System.Drawing.Color.White;
            this.group_functions.Location = new System.Drawing.Point(814, 342);
            this.group_functions.Name = "group_functions";
            this.group_functions.Size = new System.Drawing.Size(251, 271);
            this.group_functions.TabIndex = 1;
            this.group_functions.TabStop = false;
            // 
            // button_list
            // 
            this.button_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_list.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button_list.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_list.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_list.ForeColor = System.Drawing.Color.Black;
            this.button_list.Location = new System.Drawing.Point(13, 210);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(225, 45);
            this.button_list.TabIndex = 12;
            this.button_list.Text = "List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_update
            // 
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_update.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(13, 150);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(225, 45);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(13, 90);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(225, 45);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_add.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(13, 30);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(225, 45);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // group_list
            // 
            this.group_list.Controls.Add(this.button_clear);
            this.group_list.Controls.Add(this.data);
            this.group_list.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_list.ForeColor = System.Drawing.Color.White;
            this.group_list.Location = new System.Drawing.Point(12, 12);
            this.group_list.Name = "group_list";
            this.group_list.Size = new System.Drawing.Size(1053, 324);
            this.group_list.TabIndex = 2;
            this.group_list.TabStop = false;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoGenerateColumns = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeight = 35;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_name,
            this.data_surname,
            this.data_tc,
            this.data_studentNo,
            this.data_city,
            this.data_faculty,
            this.data_scholarshipRate,
            this.data_fee,
            this.data_payment,
            this.data_debt});
            this.data.DataSource = this.tableMainBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(3, 21);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(1047, 300);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // data_name
            // 
            this.data_name.DataPropertyName = "Name";
            this.data_name.HeaderText = "Name";
            this.data_name.Name = "data_name";
            this.data_name.ReadOnly = true;
            this.data_name.Width = 69;
            // 
            // data_surname
            // 
            this.data_surname.DataPropertyName = "Surname";
            this.data_surname.HeaderText = "Surname";
            this.data_surname.Name = "data_surname";
            this.data_surname.ReadOnly = true;
            this.data_surname.Width = 87;
            // 
            // data_tc
            // 
            this.data_tc.DataPropertyName = "TC";
            this.data_tc.HeaderText = "TC";
            this.data_tc.Name = "data_tc";
            this.data_tc.ReadOnly = true;
            this.data_tc.Width = 47;
            // 
            // data_studentNo
            // 
            this.data_studentNo.DataPropertyName = "Student No";
            this.data_studentNo.HeaderText = "Student No";
            this.data_studentNo.Name = "data_studentNo";
            this.data_studentNo.ReadOnly = true;
            this.data_studentNo.Width = 103;
            // 
            // data_city
            // 
            this.data_city.DataPropertyName = "City";
            this.data_city.HeaderText = "City";
            this.data_city.Name = "data_city";
            this.data_city.ReadOnly = true;
            this.data_city.Width = 56;
            // 
            // data_faculty
            // 
            this.data_faculty.DataPropertyName = "Faculty";
            this.data_faculty.HeaderText = "Faculty";
            this.data_faculty.Name = "data_faculty";
            this.data_faculty.ReadOnly = true;
            this.data_faculty.Width = 76;
            // 
            // data_scholarshipRate
            // 
            this.data_scholarshipRate.DataPropertyName = "Scholarship Rate";
            this.data_scholarshipRate.HeaderText = "Scholarship Rate";
            this.data_scholarshipRate.Name = "data_scholarshipRate";
            this.data_scholarshipRate.ReadOnly = true;
            this.data_scholarshipRate.Width = 133;
            // 
            // data_fee
            // 
            this.data_fee.DataPropertyName = "Fee";
            this.data_fee.HeaderText = "Fee";
            this.data_fee.Name = "data_fee";
            this.data_fee.ReadOnly = true;
            this.data_fee.Width = 54;
            // 
            // data_payment
            // 
            this.data_payment.DataPropertyName = "Payment";
            this.data_payment.HeaderText = "Payment";
            this.data_payment.Name = "data_payment";
            this.data_payment.ReadOnly = true;
            this.data_payment.Width = 87;
            // 
            // data_debt
            // 
            this.data_debt.DataPropertyName = "Debt";
            this.data_debt.HeaderText = "Debt";
            this.data_debt.Name = "data_debt";
            this.data_debt.ReadOnly = true;
            this.data_debt.Width = 62;
            // 
            // tableMainBindingSource
            // 
            this.tableMainBindingSource.DataMember = "tableMain";
            this.tableMainBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_surname.Location = new System.Drawing.Point(15, 110);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(86, 25);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname";
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tc.Location = new System.Drawing.Point(15, 185);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(32, 25);
            this.label_tc.TabIndex = 3;
            this.label_tc.Text = "TC";
            // 
            // label_studentNo
            // 
            this.label_studentNo.AutoSize = true;
            this.label_studentNo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_studentNo.Location = new System.Drawing.Point(229, 35);
            this.label_studentNo.Name = "label_studentNo";
            this.label_studentNo.Size = new System.Drawing.Size(108, 25);
            this.label_studentNo.TabIndex = 4;
            this.label_studentNo.Text = "Student No";
            // 
            // studentNo
            // 
            this.studentNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNo.ForeColor = System.Drawing.Color.Black;
            this.studentNo.Location = new System.Drawing.Point(234, 66);
            this.studentNo.Mask = "000000000";
            this.studentNo.Name = "studentNo";
            this.studentNo.Size = new System.Drawing.Size(150, 25);
            this.studentNo.TabIndex = 4;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_city.Location = new System.Drawing.Point(229, 110);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(44, 25);
            this.label_city.TabIndex = 5;
            this.label_city.Text = "City";
            // 
            // fee
            // 
            this.fee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fee.ForeColor = System.Drawing.Color.Black;
            this.fee.Location = new System.Drawing.Point(525, 141);
            this.fee.Mask = "0000000";
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(150, 25);
            this.fee.TabIndex = 8;
            this.fee.TextChanged += new System.EventHandler(this.fee_TextChanged);
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_faculty.Location = new System.Drawing.Point(229, 185);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(69, 25);
            this.label_faculty.TabIndex = 6;
            this.label_faculty.Text = "Faculty";
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.city.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "Izmir",
            "Bursa",
            "Antalya",
            "Konya",
            "Adana",
            "Gaziantep"});
            this.city.Location = new System.Drawing.Point(234, 144);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(150, 25);
            this.city.TabIndex = 5;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(20, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 25);
            this.name.TabIndex = 1;
            // 
            // label_scholarshipRate
            // 
            this.label_scholarshipRate.AutoSize = true;
            this.label_scholarshipRate.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_scholarshipRate.Location = new System.Drawing.Point(520, 35);
            this.label_scholarshipRate.Name = "label_scholarshipRate";
            this.label_scholarshipRate.Size = new System.Drawing.Size(148, 25);
            this.label_scholarshipRate.TabIndex = 7;
            this.label_scholarshipRate.Text = "Scholarship Rate";
            // 
            // scholarshipRate
            // 
            this.scholarshipRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scholarshipRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scholarshipRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scholarshipRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scholarshipRate.FormattingEnabled = true;
            this.scholarshipRate.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100"});
            this.scholarshipRate.Location = new System.Drawing.Point(525, 65);
            this.scholarshipRate.Name = "scholarshipRate";
            this.scholarshipRate.Size = new System.Drawing.Size(150, 25);
            this.scholarshipRate.TabIndex = 7;
            this.scholarshipRate.SelectionChangeCommitted += new System.EventHandler(this.scholarshipRate_SelectionChangeCommitted);
            // 
            // label_fee
            // 
            this.label_fee.AutoSize = true;
            this.label_fee.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_fee.Location = new System.Drawing.Point(520, 110);
            this.label_fee.Name = "label_fee";
            this.label_fee.Size = new System.Drawing.Size(41, 25);
            this.label_fee.TabIndex = 8;
            this.label_fee.Text = "Fee";
            // 
            // faculty
            // 
            this.faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faculty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.faculty.FormattingEnabled = true;
            this.faculty.Items.AddRange(new object[] {
            "Law",
            "Science",
            "Fine Arts",
            "Literature",
            "Engineering",
            "Health Sciences"});
            this.faculty.Location = new System.Drawing.Point(234, 219);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(183, 25);
            this.faculty.TabIndex = 6;
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_payment.Location = new System.Drawing.Point(449, 185);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(84, 25);
            this.label_payment.TabIndex = 9;
            this.label_payment.Text = "Payment";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname.Location = new System.Drawing.Point(20, 141);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(150, 25);
            this.surname.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(15, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 25);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.ForeColor = System.Drawing.Color.Black;
            this.tc.Location = new System.Drawing.Point(20, 219);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(150, 25);
            this.tc.TabIndex = 3;
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payment.ForeColor = System.Drawing.Color.Green;
            this.payment.Location = new System.Drawing.Point(454, 219);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(124, 25);
            this.payment.TabIndex = 11;
            this.payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.payment.TextChanged += new System.EventHandler(this.payment_TextChanged);
            // 
            // label_debt
            // 
            this.label_debt.AutoSize = true;
            this.label_debt.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_debt.Location = new System.Drawing.Point(617, 185);
            this.label_debt.Name = "label_debt";
            this.label_debt.Size = new System.Drawing.Size(53, 25);
            this.label_debt.TabIndex = 12;
            this.label_debt.Text = "Debt";
            // 
            // debt
            // 
            this.debt.BackColor = System.Drawing.Color.White;
            this.debt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debt.ForeColor = System.Drawing.Color.Red;
            this.debt.HideSelection = false;
            this.debt.Location = new System.Drawing.Point(622, 219);
            this.debt.Name = "debt";
            this.debt.ReadOnly = true;
            this.debt.Size = new System.Drawing.Size(124, 25);
            this.debt.TabIndex = 13;
            this.debt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // group_register
            // 
            this.group_register.Controls.Add(this.debt);
            this.group_register.Controls.Add(this.label_debt);
            this.group_register.Controls.Add(this.payment);
            this.group_register.Controls.Add(this.tc);
            this.group_register.Controls.Add(this.label_name);
            this.group_register.Controls.Add(this.surname);
            this.group_register.Controls.Add(this.label_payment);
            this.group_register.Controls.Add(this.faculty);
            this.group_register.Controls.Add(this.label_fee);
            this.group_register.Controls.Add(this.scholarshipRate);
            this.group_register.Controls.Add(this.label_scholarshipRate);
            this.group_register.Controls.Add(this.name);
            this.group_register.Controls.Add(this.city);
            this.group_register.Controls.Add(this.label_faculty);
            this.group_register.Controls.Add(this.fee);
            this.group_register.Controls.Add(this.label_city);
            this.group_register.Controls.Add(this.studentNo);
            this.group_register.Controls.Add(this.label_studentNo);
            this.group_register.Controls.Add(this.label_tc);
            this.group_register.Controls.Add(this.label_surname);
            this.group_register.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_register.ForeColor = System.Drawing.Color.White;
            this.group_register.Location = new System.Drawing.Point(12, 342);
            this.group_register.Name = "group_register";
            this.group_register.Size = new System.Drawing.Size(794, 271);
            this.group_register.TabIndex = 0;
            this.group_register.TabStop = false;
            // 
            // tableMainTableAdapter
            // 
            this.tableMainTableAdapter.ClearBeforeFill = true;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(713, 275);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(81, 32);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1077, 625);
            this.Controls.Add(this.group_list);
            this.Controls.Add(this.group_functions);
            this.Controls.Add(this.group_register);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1093, 664);
            this.MinimumSize = new System.Drawing.Size(1093, 664);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.group_functions.ResumeLayout(false);
            this.group_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.group_register.ResumeLayout(false);
            this.group_register.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_list;

        private System.Windows.Forms.Button button_add;


        private System.Windows.Forms.GroupBox group_functions;

        #endregion
        private System.Windows.Forms.GroupBox group_list;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.Label label_studentNo;
        private System.Windows.Forms.MaskedTextBox studentNo;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.MaskedTextBox fee;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label_scholarshipRate;
        private System.Windows.Forms.ComboBox scholarshipRate;
        private System.Windows.Forms.Label label_fee;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Label label_debt;
        private System.Windows.Forms.TextBox debt;
        private System.Windows.Forms.GroupBox group_register;
        private System.Windows.Forms.DataGridView data;
        private Proje.ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource tableMainBindingSource;
        private Proje.ProjectDataSetTableAdapters.tableMainTableAdapter tableMainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_studentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_scholarshipRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_debt;
        private System.Windows.Forms.Button button_clear;
    }
}