﻿namespace Enterprises.Report
{
    partial class CashBankReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashBankReport));
            this.panelItem = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.grpContent = new System.Windows.Forms.Panel();
            this.RDORECEIPT = new System.Windows.Forms.RadioButton();
            this.RDOSALE = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TO_DATE = new System.Windows.Forms.DateTimePicker();
            this.FROM_DATE = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.PictureBox();
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
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelItem.Location = new System.Drawing.Point(0, 93);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(1338, 550);
            this.panelItem.TabIndex = 118;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdData.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1336, 548);
            this.grdData.TabIndex = 117;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(869, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1302, 8);
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
            this.label18.Location = new System.Drawing.Point(4, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sale Concelation Report";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 643);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 119;
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
            this.headPanel.TabIndex = 116;
            this.headPanel.TabStop = true;
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.Download);
            this.grpContent.Controls.Add(this.RDORECEIPT);
            this.grpContent.Controls.Add(this.RDOSALE);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.btnSearch);
            this.grpContent.Controls.Add(this.TO_DATE);
            this.grpContent.Controls.Add(this.FROM_DATE);
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 50);
            this.grpContent.TabIndex = 121;
            // 
            // RDORECEIPT
            // 
            this.RDORECEIPT.AutoSize = true;
            this.RDORECEIPT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDORECEIPT.Location = new System.Drawing.Point(396, 10);
            this.RDORECEIPT.Name = "RDORECEIPT";
            this.RDORECEIPT.Size = new System.Drawing.Size(76, 23);
            this.RDORECEIPT.TabIndex = 111;
            this.RDORECEIPT.Text = "Receipt";
            this.RDORECEIPT.UseVisualStyleBackColor = true;
            // 
            // RDOSALE
            // 
            this.RDOSALE.AutoSize = true;
            this.RDOSALE.Checked = true;
            this.RDOSALE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDOSALE.Location = new System.Drawing.Point(322, 10);
            this.RDOSALE.Name = "RDOSALE";
            this.RDOSALE.Size = new System.Drawing.Size(54, 23);
            this.RDOSALE.TabIndex = 110;
            this.RDOSALE.TabStop = true;
            this.RDOSALE.Text = "Sale";
            this.RDOSALE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(699, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 109;
            this.label2.Text = "To Date";
            // 
            // TO_DATE
            // 
            this.TO_DATE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TO_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TO_DATE.Location = new System.Drawing.Point(760, 11);
            this.TO_DATE.Name = "TO_DATE";
            this.TO_DATE.Size = new System.Drawing.Size(108, 27);
            this.TO_DATE.TabIndex = 108;
            // 
            // FROM_DATE
            // 
            this.FROM_DATE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FROM_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FROM_DATE.Location = new System.Drawing.Point(570, 11);
            this.FROM_DATE.Name = "FROM_DATE";
            this.FROM_DATE.Size = new System.Drawing.Size(108, 27);
            this.FROM_DATE.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(491, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "From Date";
            // 
            // Download
            // 
            this.Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.Location = new System.Drawing.Point(973, 11);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(41, 28);
            this.Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Download.TabIndex = 112;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // CashBankReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 648);
            this.ControlBox = false;
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashBankReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TO_DATE;
        private System.Windows.Forms.DateTimePicker FROM_DATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.RadioButton RDOSALE;
        private System.Windows.Forms.RadioButton RDORECEIPT;
        private System.Windows.Forms.PictureBox Download;
    }
}