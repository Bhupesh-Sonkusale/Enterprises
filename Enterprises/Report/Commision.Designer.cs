﻿namespace Enterprises.Report
{
    partial class Commision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commision));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpContent = new System.Windows.Forms.Panel();
            this.Download = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TO_DATE = new System.Windows.Forms.DateTimePicker();
            this.FROM_DATE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.ORDER_BY = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).BeginInit();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.ORDER_BY);
            this.grpContent.Controls.Add(this.label6);
            this.grpContent.Controls.Add(this.Download);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.btnSearch);
            this.grpContent.Controls.Add(this.TO_DATE);
            this.grpContent.Controls.Add(this.FROM_DATE);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 50);
            this.grpContent.TabIndex = 122;
            // 
            // Download
            // 
            this.Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.Location = new System.Drawing.Point(1035, 11);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(41, 28);
            this.Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Download.TabIndex = 110;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(769, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "To Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(947, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TO_DATE
            // 
            this.TO_DATE.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.TO_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TO_DATE.Location = new System.Drawing.Point(837, 11);
            this.TO_DATE.Name = "TO_DATE";
            this.TO_DATE.Size = new System.Drawing.Size(108, 27);
            this.TO_DATE.TabIndex = 108;
            // 
            // FROM_DATE
            // 
            this.FROM_DATE.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.FROM_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FROM_DATE.Location = new System.Drawing.Point(647, 11);
            this.FROM_DATE.Name = "FROM_DATE";
            this.FROM_DATE.Size = new System.Drawing.Size(108, 27);
            this.FROM_DATE.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(557, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "From Date";
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
            this.headPanel.TabIndex = 121;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1303, 8);
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
            this.label18.Size = new System.Drawing.Size(172, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Commision Report";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 643);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 123;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.grdData.Location = new System.Drawing.Point(0, 91);
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
            this.grdData.Size = new System.Drawing.Size(1338, 552);
            this.grdData.TabIndex = 124;
            // 
            // ORDER_BY
            // 
            this.ORDER_BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ORDER_BY.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.ORDER_BY.FormattingEnabled = true;
            this.ORDER_BY.Location = new System.Drawing.Point(331, 11);
            this.ORDER_BY.Name = "ORDER_BY";
            this.ORDER_BY.Size = new System.Drawing.Size(211, 27);
            this.ORDER_BY.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(261, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 112;
            this.label6.Text = "Book By";
            // 
            // Commision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 648);
            this.ControlBox = false;
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Commision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Commision_Load);
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.PictureBox Download;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker TO_DATE;
        private System.Windows.Forms.DateTimePicker FROM_DATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.ComboBox ORDER_BY;
        private System.Windows.Forms.Label label6;
    }
}