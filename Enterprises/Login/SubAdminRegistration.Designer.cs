namespace Enterprises.Login
{
    partial class SubAdminRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubAdminRegistration));
            this.MOBILE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.USER_NAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.TOTAL_COUNT = new System.Windows.Forms.Label();
            this.NEW = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.Panel();
            this.PER_DAY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IS_LOGIN = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.COMMISION = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.JOIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.ADHAR_CARD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PAN_CARD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SALARY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpButtonStrip = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.headPanel.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.grpButtonStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MOBILE
            // 
            this.MOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MOBILE.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.MOBILE.Location = new System.Drawing.Point(801, 24);
            this.MOBILE.MaxLength = 10;
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.Size = new System.Drawing.Size(263, 25);
            this.MOBILE.TabIndex = 1;
            this.MOBILE.TextChanged += new System.EventHandler(this.MOBILE_TextChanged);
            this.MOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MOBILE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(741, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mobile";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 288);
            this.panel1.TabIndex = 69;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 30;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1338, 288);
            this.grdData.TabIndex = 119;
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address";
            // 
            // ADDRESS
            // 
            this.ADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADDRESS.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.ADDRESS.Location = new System.Drawing.Point(364, 58);
            this.ADDRESS.MaxLength = 100;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(699, 25);
            this.ADDRESS.TabIndex = 2;
            // 
            // NAME
            // 
            this.NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NAME.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.NAME.Location = new System.Drawing.Point(364, 26);
            this.NAME.MaxLength = 40;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(329, 25);
            this.NAME.TabIndex = 0;
            this.NAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblCatCode.ForeColor = System.Drawing.Color.Red;
            this.lblCatCode.Location = new System.Drawing.Point(306, 30);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(48, 18);
            this.lblCatCode.TabIndex = 0;
            this.lblCatCode.Text = "Name";
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Calibri", 11F);
            this.ID.Location = new System.Drawing.Point(9, 3);
            this.ID.MaxLength = 10;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(63, 25);
            this.ID.TabIndex = 5;
            this.ID.Visible = false;
            // 
            // PASSWORD
            // 
            this.PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASSWORD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PASSWORD.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.PASSWORD.Location = new System.Drawing.Point(801, 92);
            this.PASSWORD.MaxLength = 10;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(263, 25);
            this.PASSWORD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(720, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // USER_NAME
            // 
            this.USER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER_NAME.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.USER_NAME.Location = new System.Drawing.Point(364, 92);
            this.USER_NAME.MaxLength = 10;
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.Size = new System.Drawing.Size(263, 25);
            this.USER_NAME.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(272, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "User Name";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 633);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 68;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1311, 8);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(25, 25);
            this.CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CLOSE.TabIndex = 4;
            this.CLOSE.TabStop = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(214, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sub Admin Registration";
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.headPanel.Controls.Add(this.CLOSE);
            this.headPanel.Controls.Add(this.label18);
            this.headPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.Color.White;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1338, 41);
            this.headPanel.TabIndex = 67;
            this.headPanel.TabStop = true;
            // 
            // TOTAL_COUNT
            // 
            this.TOTAL_COUNT.AutoSize = true;
            this.TOTAL_COUNT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_COUNT.Location = new System.Drawing.Point(6, 15);
            this.TOTAL_COUNT.Name = "TOTAL_COUNT";
            this.TOTAL_COUNT.Size = new System.Drawing.Size(55, 17);
            this.TOTAL_COUNT.TabIndex = 5;
            this.TOTAL_COUNT.Text = "Total : 0";
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.NEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEW.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.ForeColor = System.Drawing.Color.White;
            this.NEW.Location = new System.Drawing.Point(531, 7);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(90, 34);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "New";
            this.NEW.UseVisualStyleBackColor = false;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.EDIT.Enabled = false;
            this.EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EDIT.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.ForeColor = System.Drawing.Color.White;
            this.EDIT.Location = new System.Drawing.Point(715, 7);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(90, 34);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "Edit";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Crimson;
            this.DELETE.Enabled = false;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.Color.White;
            this.DELETE.Location = new System.Drawing.Point(1253, 9);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(80, 30);
            this.DELETE.TabIndex = 3;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Visible = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DarkGreen;
            this.SAVE.Enabled = false;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAVE.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(623, 7);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(90, 34);
            this.SAVE.TabIndex = 1;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.White;
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.PER_DAY);
            this.grpContent.Controls.Add(this.label11);
            this.grpContent.Controls.Add(this.IS_LOGIN);
            this.grpContent.Controls.Add(this.label10);
            this.grpContent.Controls.Add(this.COMMISION);
            this.grpContent.Controls.Add(this.label9);
            this.grpContent.Controls.Add(this.JOIN_DATE);
            this.grpContent.Controls.Add(this.ADHAR_CARD);
            this.grpContent.Controls.Add(this.label7);
            this.grpContent.Controls.Add(this.PAN_CARD);
            this.grpContent.Controls.Add(this.label8);
            this.grpContent.Controls.Add(this.SALARY);
            this.grpContent.Controls.Add(this.label5);
            this.grpContent.Controls.Add(this.label6);
            this.grpContent.Controls.Add(this.ID);
            this.grpContent.Controls.Add(this.MOBILE);
            this.grpContent.Controls.Add(this.PASSWORD);
            this.grpContent.Controls.Add(this.lblCatCode);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Controls.Add(this.NAME);
            this.grpContent.Controls.Add(this.USER_NAME);
            this.grpContent.Controls.Add(this.ADDRESS);
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Enabled = false;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 250);
            this.grpContent.TabIndex = 0;
            // 
            // PER_DAY
            // 
            this.PER_DAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PER_DAY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PER_DAY.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.PER_DAY.Location = new System.Drawing.Point(997, 204);
            this.PER_DAY.MaxLength = 4;
            this.PER_DAY.Name = "PER_DAY";
            this.PER_DAY.Size = new System.Drawing.Size(118, 25);
            this.PER_DAY.TabIndex = 11;
            this.PER_DAY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SALARY_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(933, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 34;
            this.label11.Text = "Per Day";
            // 
            // IS_LOGIN
            // 
            this.IS_LOGIN.AutoSize = true;
            this.IS_LOGIN.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.IS_LOGIN.Location = new System.Drawing.Point(364, 211);
            this.IS_LOGIN.Name = "IS_LOGIN";
            this.IS_LOGIN.Size = new System.Drawing.Size(15, 14);
            this.IS_LOGIN.TabIndex = 9;
            this.IS_LOGIN.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(295, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Is Login";
            // 
            // COMMISION
            // 
            this.COMMISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.COMMISION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.COMMISION.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.COMMISION.Location = new System.Drawing.Point(801, 204);
            this.COMMISION.MaxLength = 4;
            this.COMMISION.Name = "COMMISION";
            this.COMMISION.Size = new System.Drawing.Size(118, 25);
            this.COMMISION.TabIndex = 10;
            this.COMMISION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SALARY_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(711, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Commision";
            // 
            // JOIN_DATE
            // 
            this.JOIN_DATE.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.JOIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JOIN_DATE.Location = new System.Drawing.Point(364, 126);
            this.JOIN_DATE.Name = "JOIN_DATE";
            this.JOIN_DATE.Size = new System.Drawing.Size(263, 25);
            this.JOIN_DATE.TabIndex = 5;
            // 
            // ADHAR_CARD
            // 
            this.ADHAR_CARD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADHAR_CARD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ADHAR_CARD.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.ADHAR_CARD.Location = new System.Drawing.Point(801, 165);
            this.ADHAR_CARD.MaxLength = 12;
            this.ADHAR_CARD.Name = "ADHAR_CARD";
            this.ADHAR_CARD.Size = new System.Drawing.Size(263, 25);
            this.ADHAR_CARD.TabIndex = 8;
            this.ADHAR_CARD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MOBILE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(711, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Adhar Card";
            // 
            // PAN_CARD
            // 
            this.PAN_CARD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PAN_CARD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PAN_CARD.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.PAN_CARD.Location = new System.Drawing.Point(364, 165);
            this.PAN_CARD.MaxLength = 10;
            this.PAN_CARD.Name = "PAN_CARD";
            this.PAN_CARD.Size = new System.Drawing.Size(263, 25);
            this.PAN_CARD.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(287, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pan Card";
            // 
            // SALARY
            // 
            this.SALARY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SALARY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SALARY.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.SALARY.Location = new System.Drawing.Point(801, 129);
            this.SALARY.MaxLength = 10;
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(263, 25);
            this.SALARY.TabIndex = 6;
            this.SALARY.TextChanged += new System.EventHandler(this.SALARY_TextChanged);
            this.SALARY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SALARY_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(743, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(284, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Join Date";
            // 
            // grpButtonStrip
            // 
            this.grpButtonStrip.BackColor = System.Drawing.Color.LightGreen;
            this.grpButtonStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpButtonStrip.Controls.Add(this.TOTAL_COUNT);
            this.grpButtonStrip.Controls.Add(this.NEW);
            this.grpButtonStrip.Controls.Add(this.DELETE);
            this.grpButtonStrip.Controls.Add(this.EDIT);
            this.grpButtonStrip.Controls.Add(this.SAVE);
            this.grpButtonStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpButtonStrip.Location = new System.Drawing.Point(0, 291);
            this.grpButtonStrip.Name = "grpButtonStrip";
            this.grpButtonStrip.Size = new System.Drawing.Size(1338, 51);
            this.grpButtonStrip.TabIndex = 1;
            // 
            // SubAdminRegistration
            // 
            this.AcceptButton = this.SAVE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 638);
            this.ControlBox = false;
            this.Controls.Add(this.grpButtonStrip);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubAdminRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SubAdminRegistration_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.grpButtonStrip.ResumeLayout(false);
            this.grpButtonStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MOBILE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USER_NAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TOTAL_COUNT;
        internal System.Windows.Forms.Button NEW;
        internal System.Windows.Forms.Button EDIT;
        internal System.Windows.Forms.Button DELETE;
        internal System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Panel grpButtonStrip;
        private System.Windows.Forms.TextBox ADHAR_CARD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PAN_CARD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SALARY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker JOIN_DATE;
        private System.Windows.Forms.CheckBox IS_LOGIN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox COMMISION;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox PER_DAY;
        private System.Windows.Forms.Label label11;
    }
}