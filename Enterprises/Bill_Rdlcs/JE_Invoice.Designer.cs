namespace Enterprises.Bill_Rdlcs
{
    partial class JE_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JE_Invoice));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vIEWINVOICEBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterprisesDS = new Enterprises.EnterprisesDS();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._VIEW_INVOICE_BILLTableAdapter = new Enterprises.EnterprisesDSTableAdapters._VIEW_INVOICE_BILLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWINVOICEBILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprisesDS)).BeginInit();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // vIEWINVOICEBILLBindingSource
            // 
            this.vIEWINVOICEBILLBindingSource.DataMember = "_VIEW_INVOICE_BILL";
            this.vIEWINVOICEBILLBindingSource.DataSource = this.enterprisesDS;
            // 
            // enterprisesDS
            // 
            this.enterprisesDS.DataSetName = "EnterprisesDS";
            this.enterprisesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.headPanel.Size = new System.Drawing.Size(598, 41);
            this.headPanel.TabIndex = 29;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(562, 10);
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
            this.label18.Location = new System.Drawing.Point(4, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sale Invoice";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 613);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(598, 5);
            this.lblFooter.TabIndex = 30;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "JE_ds";
            reportDataSource1.Value = this.vIEWINVOICEBILLBindingSource;
            reportDataSource2.Name = "gstDs";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Enterprises.Bill_Rdlcs.JE_Invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(598, 572);
            this.reportViewer1.TabIndex = 33;
            // 
            // _VIEW_INVOICE_BILLTableAdapter
            // 
            this._VIEW_INVOICE_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // JE_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 618);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JE_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.JE_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vIEWINVOICEBILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprisesDS)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFooter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EnterprisesDS enterprisesDS;
        private System.Windows.Forms.BindingSource vIEWINVOICEBILLBindingSource;
        private EnterprisesDSTableAdapters._VIEW_INVOICE_BILLTableAdapter _VIEW_INVOICE_BILLTableAdapter;
    }
}