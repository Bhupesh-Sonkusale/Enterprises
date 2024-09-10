namespace Enterprises.Report
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.panelItem = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TO_DATE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FROM_DATE = new System.Windows.Forms.DateTimePicker();
            this.lblFooter = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.grpContent = new System.Windows.Forms.Panel();
            this.Download = new System.Windows.Forms.PictureBox();
            this.btnSearchNameWise = new System.Windows.Forms.Button();
            this.CUSTOMER_NAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.BILL_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.headPanel.SuspendLayout();
            this.grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItem.Controls.Add(this.grdData);
            this.panelItem.Location = new System.Drawing.Point(0, 92);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(1337, 550);
            this.panelItem.TabIndex = 111;
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
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1335, 548);
            this.grdData.TabIndex = 117;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1171, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1304, 8);
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
            this.label18.Location = new System.Drawing.Point(4, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sale Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1000, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "To Date";
            // 
            // TO_DATE
            // 
            this.TO_DATE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TO_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TO_DATE.Location = new System.Drawing.Point(1063, 11);
            this.TO_DATE.Name = "TO_DATE";
            this.TO_DATE.Size = new System.Drawing.Size(108, 27);
            this.TO_DATE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(812, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "From Date";
            // 
            // FROM_DATE
            // 
            this.FROM_DATE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FROM_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FROM_DATE.Location = new System.Drawing.Point(893, 11);
            this.FROM_DATE.Name = "FROM_DATE";
            this.FROM_DATE.Size = new System.Drawing.Size(108, 27);
            this.FROM_DATE.TabIndex = 4;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 643);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 112;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.headPanel.TabIndex = 109;
            this.headPanel.TabStop = true;
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.Download);
            this.grpContent.Controls.Add(this.btnSearchNameWise);
            this.grpContent.Controls.Add(this.CUSTOMER_NAME);
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Controls.Add(this.btnBillSearch);
            this.grpContent.Controls.Add(this.BILL_ID);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.btnSearch);
            this.grpContent.Controls.Add(this.TO_DATE);
            this.grpContent.Controls.Add(this.FROM_DATE);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 50);
            this.grpContent.TabIndex = 0;
            // 
            // Download
            // 
            this.Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.Location = new System.Drawing.Point(1260, 12);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(41, 27);
            this.Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Download.TabIndex = 113;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // btnSearchNameWise
            // 
            this.btnSearchNameWise.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearchNameWise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchNameWise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNameWise.ForeColor = System.Drawing.Color.White;
            this.btnSearchNameWise.Location = new System.Drawing.Point(726, 12);
            this.btnSearchNameWise.Name = "btnSearchNameWise";
            this.btnSearchNameWise.Size = new System.Drawing.Size(80, 27);
            this.btnSearchNameWise.TabIndex = 3;
            this.btnSearchNameWise.Text = "Search";
            this.btnSearchNameWise.UseVisualStyleBackColor = false;
            this.btnSearchNameWise.Click += new System.EventHandler(this.btnSearchNameWise_Click);
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CUSTOMER_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CUSTOMER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUSTOMER_NAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CUSTOMER_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_NAME.Location = new System.Drawing.Point(398, 11);
            this.CUSTOMER_NAME.MaxLength = 10;
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.Size = new System.Drawing.Size(328, 27);
            this.CUSTOMER_NAME.TabIndex = 2;
            this.CUSTOMER_NAME.TextChanged += new System.EventHandler(this.CUSTOMER_NAME_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(346, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 114;
            this.label4.Text = "Name";
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBillSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillSearch.ForeColor = System.Drawing.Color.White;
            this.btnBillSearch.Location = new System.Drawing.Point(224, 11);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(87, 27);
            this.btnBillSearch.TabIndex = 1;
            this.btnBillSearch.Text = "Search";
            this.btnBillSearch.UseVisualStyleBackColor = false;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // BILL_ID
            // 
            this.BILL_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BILL_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BILL_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BILL_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BILL_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BILL_ID.Location = new System.Drawing.Point(131, 11);
            this.BILL_ID.MaxLength = 10;
            this.BILL_ID.Name = "BILL_ID";
            this.BILL_ID.Size = new System.Drawing.Size(93, 27);
            this.BILL_ID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Bill ID";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 648);
            this.ControlBox = false;
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sale_Load);
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TO_DATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FROM_DATE;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel grpContent;
        internal System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.TextBox BILL_ID;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSearchNameWise;
        private System.Windows.Forms.TextBox CUSTOMER_NAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.PictureBox Download;
    }
}