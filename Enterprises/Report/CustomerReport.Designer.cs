﻿namespace Enterprises.Report
{
    partial class CustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            this.grpContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CUSTOMER_MOBILE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CUSTOMER_NAME = new System.Windows.Forms.TextBox();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelItem = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.Download = new System.Windows.Forms.PictureBox();
            this.grpContent.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.Download);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.CUSTOMER_MOBILE);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.CUSTOMER_NAME);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 50);
            this.grpContent.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(784, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 115;
            this.label1.Text = "Mobile";
            // 
            // CUSTOMER_MOBILE
            // 
            this.CUSTOMER_MOBILE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CUSTOMER_MOBILE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CUSTOMER_MOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUSTOMER_MOBILE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CUSTOMER_MOBILE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_MOBILE.Location = new System.Drawing.Point(842, 11);
            this.CUSTOMER_MOBILE.MaxLength = 10;
            this.CUSTOMER_MOBILE.Name = "CUSTOMER_MOBILE";
            this.CUSTOMER_MOBILE.Size = new System.Drawing.Size(194, 27);
            this.CUSTOMER_MOBILE.TabIndex = 114;
            this.CUSTOMER_MOBILE.TextChanged += new System.EventHandler(this.CUSTOMER_MOBILE_TextChanged);
            this.CUSTOMER_MOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(300, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "Customer Name";
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CUSTOMER_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CUSTOMER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUSTOMER_NAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CUSTOMER_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_NAME.Location = new System.Drawing.Point(416, 11);
            this.CUSTOMER_NAME.MaxLength = 100;
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.Size = new System.Drawing.Size(346, 27);
            this.CUSTOMER_NAME.TabIndex = 112;
            this.CUSTOMER_NAME.TextChanged += new System.EventHandler(this.CUSTOMER_NAME_TextChanged);
            this.CUSTOMER_NAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Character);
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
            this.CLOSE.Location = new System.Drawing.Point(1306, 8);
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
            this.label18.Size = new System.Drawing.Size(158, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Customer Report";
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
            // panelItem
            // 
            this.panelItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItem.Controls.Add(this.grdData);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelItem.Location = new System.Drawing.Point(0, 93);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(1338, 550);
            this.panelItem.TabIndex = 124;
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
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.1F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1336, 548);
            this.grdData.TabIndex = 117;
            // 
            // Download
            // 
            this.Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.Location = new System.Drawing.Point(1038, 11);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(45, 27);
            this.Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Download.TabIndex = 116;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CUSTOMER_MOBILE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CUSTOMER_NAME;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.PictureBox Download;
    }
}