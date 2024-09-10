namespace Enterprises.Transaction
{
    partial class Bill_Cancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Cancel));
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.DETAIL = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.O_RETURN_AMOUNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C_RETURN_AMOUNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME_MOBILE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.CANCEL_REASON = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BILL_ID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.headPanel.Controls.Add(this.btnRefresh);
            this.headPanel.Controls.Add(this.CLOSE);
            this.headPanel.Controls.Add(this.label18);
            this.headPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.Color.White;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1338, 41);
            this.headPanel.TabIndex = 25;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1310, 8);
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
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 27);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cancel Bill";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFooter.Location = new System.Drawing.Point(0, 633);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1338, 5);
            this.panelFooter.TabIndex = 26;
            this.panelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.DETAIL);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 41);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1338, 33);
            this.panelSearch.TabIndex = 0;
            // 
            // DETAIL
            // 
            this.DETAIL.AutoSize = true;
            this.DETAIL.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETAIL.ForeColor = System.Drawing.Color.Red;
            this.DETAIL.Location = new System.Drawing.Point(6, 7);
            this.DETAIL.Name = "DETAIL";
            this.DETAIL.Size = new System.Drawing.Size(25, 19);
            this.DETAIL.TabIndex = 6;
            this.DETAIL.Text = "--";
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.O_RETURN_AMOUNT);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.C_RETURN_AMOUNT);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.NAME_MOBILE);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.lblCatName);
            this.panelDetail.Controls.Add(this.CANCEL_REASON);
            this.panelDetail.Controls.Add(this.btnSubmit);
            this.panelDetail.Controls.Add(this.label21);
            this.panelDetail.Controls.Add(this.panel3);
            this.panelDetail.Controls.Add(this.BILL_ID);
            this.panelDetail.Controls.Add(this.label20);
            this.panelDetail.Location = new System.Drawing.Point(350, 180);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(639, 278);
            this.panelDetail.TabIndex = 118;
            this.panelDetail.Visible = false;
            // 
            // O_RETURN_AMOUNT
            // 
            this.O_RETURN_AMOUNT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.O_RETURN_AMOUNT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.O_RETURN_AMOUNT.BackColor = System.Drawing.Color.White;
            this.O_RETURN_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_RETURN_AMOUNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.O_RETURN_AMOUNT.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_RETURN_AMOUNT.Location = new System.Drawing.Point(435, 171);
            this.O_RETURN_AMOUNT.MaxLength = 10;
            this.O_RETURN_AMOUNT.Name = "O_RETURN_AMOUNT";
            this.O_RETURN_AMOUNT.Size = new System.Drawing.Size(158, 27);
            this.O_RETURN_AMOUNT.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(343, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Online Rs.";
            // 
            // C_RETURN_AMOUNT
            // 
            this.C_RETURN_AMOUNT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.C_RETURN_AMOUNT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.C_RETURN_AMOUNT.BackColor = System.Drawing.Color.White;
            this.C_RETURN_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C_RETURN_AMOUNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.C_RETURN_AMOUNT.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_RETURN_AMOUNT.Location = new System.Drawing.Point(165, 170);
            this.C_RETURN_AMOUNT.MaxLength = 10;
            this.C_RETURN_AMOUNT.Name = "C_RETURN_AMOUNT";
            this.C_RETURN_AMOUNT.Size = new System.Drawing.Size(174, 27);
            this.C_RETURN_AMOUNT.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(89, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Cash Rs.";
            // 
            // NAME_MOBILE
            // 
            this.NAME_MOBILE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NAME_MOBILE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NAME_MOBILE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NAME_MOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NAME_MOBILE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NAME_MOBILE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME_MOBILE.Location = new System.Drawing.Point(165, 102);
            this.NAME_MOBILE.MaxLength = 40;
            this.NAME_MOBILE.Name = "NAME_MOBILE";
            this.NAME_MOBILE.ReadOnly = true;
            this.NAME_MOBILE.Size = new System.Drawing.Size(429, 27);
            this.NAME_MOBILE.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "Name / Mobile";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(43, 140);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(116, 19);
            this.lblCatName.TabIndex = 90;
            this.lblCatName.Text = "Cancel Reason";
            // 
            // CANCEL_REASON
            // 
            this.CANCEL_REASON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CANCEL_REASON.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_REASON.FormattingEnabled = true;
            this.CANCEL_REASON.Location = new System.Drawing.Point(165, 136);
            this.CANCEL_REASON.Name = "CANCEL_REASON";
            this.CANCEL_REASON.Size = new System.Drawing.Size(427, 27);
            this.CANCEL_REASON.TabIndex = 89;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(165, 206);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(429, 33);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(637, 5);
            this.label21.TabIndex = 27;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.btnDetail);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 38);
            this.panel3.TabIndex = 25;
            this.panel3.TabStop = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.Image")));
            this.btnDetail.Location = new System.Drawing.Point(609, 5);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(25, 25);
            this.btnDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDetail.TabIndex = 4;
            this.btnDetail.TabStop = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 25);
            this.label22.TabIndex = 1;
            this.label22.Text = "Cancel Bill";
            // 
            // BILL_ID
            // 
            this.BILL_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BILL_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BILL_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BILL_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BILL_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BILL_ID.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BILL_ID.Location = new System.Drawing.Point(165, 68);
            this.BILL_ID.MaxLength = 40;
            this.BILL_ID.Name = "BILL_ID";
            this.BILL_ID.ReadOnly = true;
            this.BILL_ID.Size = new System.Drawing.Size(429, 27);
            this.BILL_ID.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(108, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 19);
            this.label20.TabIndex = 88;
            this.label20.Text = "Bill ID";
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
            this.grdData.Location = new System.Drawing.Point(0, 74);
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
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1338, 559);
            this.grdData.TabIndex = 120;
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1284, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Bill_Cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 638);
            this.ControlBox = false;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bill_Cancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Bill_Cancel_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label panelFooter;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label DETAIL;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox O_RETURN_AMOUNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C_RETURN_AMOUNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NAME_MOBILE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.ComboBox CANCEL_REASON;
        internal System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnDetail;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox BILL_ID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}