namespace Enterprises.Transaction
{
    partial class GodownCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GodownCounter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpContent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GODOWN_QUANTITY_ = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BARCODE = new System.Windows.Forms.TextBox();
            this.PRODUCT_ID = new System.Windows.Forms.TextBox();
            this.GODOWN_QUANTITY = new System.Windows.Forms.TextBox();
            this.PARTICULAR = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelItem = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.PRODUCT_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.grpContent.SuspendLayout();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
            this.headPanel.Size = new System.Drawing.Size(1338, 41);
            this.headPanel.TabIndex = 106;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1309, 8);
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
            this.label18.Location = new System.Drawing.Point(4, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Godown To Shoppy";
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Controls.Add(this.GODOWN_QUANTITY_);
            this.grpContent.Controls.Add(this.btnClear);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.BARCODE);
            this.grpContent.Controls.Add(this.PRODUCT_ID);
            this.grpContent.Controls.Add(this.GODOWN_QUANTITY);
            this.grpContent.Controls.Add(this.PARTICULAR);
            this.grpContent.Controls.Add(this.btnAdd);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Font = new System.Drawing.Font("Calibri", 11F);
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(1338, 68);
            this.grpContent.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 115;
            this.label4.Text = "Godown Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 22);
            this.label3.TabIndex = 114;
            this.label3.Text = "Particular / Description";
            // 
            // GODOWN_QUANTITY_
            // 
            this.GODOWN_QUANTITY_.BackColor = System.Drawing.Color.White;
            this.GODOWN_QUANTITY_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GODOWN_QUANTITY_.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GODOWN_QUANTITY_.Location = new System.Drawing.Point(654, 32);
            this.GODOWN_QUANTITY_.MaxLength = 100;
            this.GODOWN_QUANTITY_.Name = "GODOWN_QUANTITY_";
            this.GODOWN_QUANTITY_.ReadOnly = true;
            this.GODOWN_QUANTITY_.Size = new System.Drawing.Size(149, 27);
            this.GODOWN_QUANTITY_.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1121, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 28);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(800, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transfer To Shoppy";
            // 
            // BARCODE
            // 
            this.BARCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BARCODE.Font = new System.Drawing.Font("Calibri", 11F);
            this.BARCODE.Location = new System.Drawing.Point(37, 12);
            this.BARCODE.MaxLength = 100;
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.ReadOnly = true;
            this.BARCODE.Size = new System.Drawing.Size(26, 25);
            this.BARCODE.TabIndex = 1;
            this.BARCODE.Visible = false;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PRODUCT_ID.Font = new System.Drawing.Font("Calibri", 11F);
            this.PRODUCT_ID.Location = new System.Drawing.Point(3, 12);
            this.PRODUCT_ID.MaxLength = 100;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.ReadOnly = true;
            this.PRODUCT_ID.Size = new System.Drawing.Size(32, 25);
            this.PRODUCT_ID.TabIndex = 0;
            this.PRODUCT_ID.Visible = false;
            // 
            // GODOWN_QUANTITY
            // 
            this.GODOWN_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GODOWN_QUANTITY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GODOWN_QUANTITY.Location = new System.Drawing.Point(806, 32);
            this.GODOWN_QUANTITY.MaxLength = 6;
            this.GODOWN_QUANTITY.Name = "GODOWN_QUANTITY";
            this.GODOWN_QUANTITY.Size = new System.Drawing.Size(149, 27);
            this.GODOWN_QUANTITY.TabIndex = 0;
            this.GODOWN_QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MOBILE_KeyPress);
            // 
            // PARTICULAR
            // 
            this.PARTICULAR.BackColor = System.Drawing.Color.White;
            this.PARTICULAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PARTICULAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PARTICULAR.Location = new System.Drawing.Point(150, 32);
            this.PARTICULAR.MaxLength = 100;
            this.PARTICULAR.Name = "PARTICULAR";
            this.PARTICULAR.ReadOnly = true;
            this.PARTICULAR.Size = new System.Drawing.Size(504, 27);
            this.PARTICULAR.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(957, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Transfer Quantity";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 633);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 109;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelItem
            // 
            this.panelItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItem.Controls.Add(this.grdData);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelItem.Location = new System.Drawing.Point(0, 139);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(1338, 494);
            this.panelItem.TabIndex = 110;
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
            this.grdData.Size = new System.Drawing.Size(1336, 492);
            this.grdData.TabIndex = 117;
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PRODUCT_NAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PRODUCT_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCT_NAME.Location = new System.Drawing.Point(151, 110);
            this.PRODUCT_NAME.MaxLength = 30;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Size = new System.Drawing.Size(1185, 27);
            this.PRODUCT_NAME.TabIndex = 112;
            this.PRODUCT_NAME.TextChanged += new System.EventHandler(this.PRODUCT_NAME_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "Search Product Name";
            // 
            // GodownCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1338, 638);
            this.ControlBox = false;
            this.Controls.Add(this.PRODUCT_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GodownCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GodownCounter_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BARCODE;
        private System.Windows.Forms.TextBox PRODUCT_ID;
        private System.Windows.Forms.TextBox GODOWN_QUANTITY;
        private System.Windows.Forms.TextBox PARTICULAR;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox PRODUCT_NAME;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox GODOWN_QUANTITY_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}