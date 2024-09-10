namespace Enterprises.Login
{
    partial class WriteQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TABLE_NAME = new System.Windows.Forms.TextBox();
            this.btnAllTables = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CONDITION = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QUERY = new System.Windows.Forms.TextBox();
            this.panelCredintial = new System.Windows.Forms.Panel();
            this.LOGIN = new System.Windows.Forms.Button();
            this.USER_NAME = new System.Windows.Forms.TextBox();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelCredintial.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.headPanel.Size = new System.Drawing.Size(1318, 41);
            this.headPanel.TabIndex = 61;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1286, 8);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(25, 25);
            this.CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CLOSE.TabIndex = 3;
            this.CLOSE.TabStop = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(558, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Write Query Here";
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TABLE_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TABLE_NAME.BackColor = System.Drawing.Color.White;
            this.TABLE_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TABLE_NAME.Enabled = false;
            this.TABLE_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABLE_NAME.Location = new System.Drawing.Point(48, 73);
            this.TABLE_NAME.MaxLength = 1000;
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.Size = new System.Drawing.Size(493, 27);
            this.TABLE_NAME.TabIndex = 0;
            // 
            // btnAllTables
            // 
            this.btnAllTables.BackColor = System.Drawing.Color.Crimson;
            this.btnAllTables.Enabled = false;
            this.btnAllTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllTables.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTables.ForeColor = System.Drawing.Color.White;
            this.btnAllTables.Location = new System.Drawing.Point(1165, 73);
            this.btnAllTables.Name = "btnAllTables";
            this.btnAllTables.Size = new System.Drawing.Size(110, 86);
            this.btnAllTables.TabIndex = 5;
            this.btnAllTables.Text = "All Tables";
            this.btnAllTables.UseVisualStyleBackColor = false;
            this.btnAllTables.Click += new System.EventHandler(this.btnAllTables_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1021, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Fetch Data";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.btnQuery.Enabled = false;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(1021, 132);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(138, 27);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Submit Query";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(8, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 19);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result : ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grdData);
            this.panel2.Location = new System.Drawing.Point(1, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 437);
            this.panel2.TabIndex = 64;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 26;
            this.grdData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1313, 435);
            this.grdData.TabIndex = 25;
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 643);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1318, 5);
            this.lblFooter.TabIndex = 65;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 35);
            this.panel3.TabIndex = 66;
            this.panel3.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Table Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Where Conditionn";
            // 
            // CONDITION
            // 
            this.CONDITION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CONDITION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CONDITION.BackColor = System.Drawing.Color.White;
            this.CONDITION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CONDITION.Enabled = false;
            this.CONDITION.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONDITION.Location = new System.Drawing.Point(544, 73);
            this.CONDITION.MaxLength = 1000;
            this.CONDITION.Name = "CONDITION";
            this.CONDITION.Size = new System.Drawing.Size(473, 27);
            this.CONDITION.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Query";
            // 
            // QUERY
            // 
            this.QUERY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.QUERY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.QUERY.BackColor = System.Drawing.Color.White;
            this.QUERY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QUERY.Enabled = false;
            this.QUERY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUERY.Location = new System.Drawing.Point(48, 132);
            this.QUERY.MaxLength = 1000;
            this.QUERY.Name = "QUERY";
            this.QUERY.Size = new System.Drawing.Size(969, 27);
            this.QUERY.TabIndex = 3;
            // 
            // panelCredintial
            // 
            this.panelCredintial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCredintial.Controls.Add(this.LOGIN);
            this.panelCredintial.Controls.Add(this.USER_NAME);
            this.panelCredintial.Controls.Add(this.lblCatCode);
            this.panelCredintial.Controls.Add(this.lblCatName);
            this.panelCredintial.Controls.Add(this.PASSWORD);
            this.panelCredintial.Controls.Add(this.panel4);
            this.panelCredintial.Controls.Add(this.label4);
            this.panelCredintial.Location = new System.Drawing.Point(359, 199);
            this.panelCredintial.Name = "panelCredintial";
            this.panelCredintial.Size = new System.Drawing.Size(600, 250);
            this.panelCredintial.TabIndex = 0;
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.DarkGreen;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOGIN.Font = new System.Drawing.Font("Calibri", 12F);
            this.LOGIN.ForeColor = System.Drawing.Color.White;
            this.LOGIN.Location = new System.Drawing.Point(219, 151);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(245, 37);
            this.LOGIN.TabIndex = 2;
            this.LOGIN.Text = "Validate User";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // USER_NAME
            // 
            this.USER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER_NAME.Font = new System.Drawing.Font("Calibri", 12F);
            this.USER_NAME.Location = new System.Drawing.Point(219, 80);
            this.USER_NAME.MaxLength = 10;
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.PasswordChar = '*';
            this.USER_NAME.Size = new System.Drawing.Size(245, 27);
            this.USER_NAME.TabIndex = 0;
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCatCode.ForeColor = System.Drawing.Color.Red;
            this.lblCatCode.Location = new System.Drawing.Point(134, 83);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(81, 19);
            this.lblCatCode.TabIndex = 69;
            this.lblCatCode.Text = "User Name";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(144, 121);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(71, 19);
            this.lblCatName.TabIndex = 71;
            this.lblCatName.Text = "Password";
            // 
            // PASSWORD
            // 
            this.PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASSWORD.Font = new System.Drawing.Font("Calibri", 12F);
            this.PASSWORD.Location = new System.Drawing.Point(219, 118);
            this.PASSWORD.MaxLength = 10;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(245, 27);
            this.PASSWORD.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 40);
            this.panel4.TabIndex = 67;
            this.panel4.TabStop = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "This Form Used Only Software Developer Team";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 5);
            this.label4.TabIndex = 66;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WriteQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panelCredintial);
            this.Controls.Add(this.btnAllTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.QUERY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CONDITION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TABLE_NAME);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WriteQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCredintial.ResumeLayout(false);
            this.panelCredintial.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TABLE_NAME;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CONDITION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QUERY;
        internal System.Windows.Forms.Button btnAllTables;
        private System.Windows.Forms.Panel panelCredintial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox USER_NAME;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox PASSWORD;
        internal System.Windows.Forms.Button LOGIN;
    }
}