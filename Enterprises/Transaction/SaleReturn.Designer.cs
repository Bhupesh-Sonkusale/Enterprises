namespace Enterprises.Transaction
{
    partial class SaleReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headPanel = new System.Windows.Forms.Panel();
            this.lbl_billId = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.BTN_SERACH = new System.Windows.Forms.Button();
            this.SEARCH_ID = new System.Windows.Forms.TextBox();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BARCODE = new System.Windows.Forms.TextBox();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PARTICULAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdSaleReturnData = new System.Windows.Forms.DataGridView();
            this.grdSaleData = new System.Windows.Forms.DataGridView();
            this.PARTY_NAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ONLINE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CASH = new System.Windows.Forms.TextBox();
            this.CUSTOMER_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.STOCK = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleReturnData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleData)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.headPanel.Controls.Add(this.lbl_billId);
            this.headPanel.Controls.Add(this.label31);
            this.headPanel.Controls.Add(this.BTN_SERACH);
            this.headPanel.Controls.Add(this.SEARCH_ID);
            this.headPanel.Controls.Add(this.CLOSE);
            this.headPanel.Controls.Add(this.label18);
            this.headPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.Color.White;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1338, 41);
            this.headPanel.TabIndex = 62;
            this.headPanel.TabStop = true;
            // 
            // lbl_billId
            // 
            this.lbl_billId.AutoSize = true;
            this.lbl_billId.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billId.ForeColor = System.Drawing.Color.White;
            this.lbl_billId.Location = new System.Drawing.Point(881, 11);
            this.lbl_billId.Name = "lbl_billId";
            this.lbl_billId.Size = new System.Drawing.Size(15, 17);
            this.lbl_billId.TabIndex = 121;
            this.lbl_billId.Text = "0";
            this.lbl_billId.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(476, 11);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 19);
            this.label31.TabIndex = 120;
            this.label31.Text = "Search Bill ID";
            // 
            // BTN_SERACH
            // 
            this.BTN_SERACH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.BTN_SERACH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SERACH.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SERACH.ForeColor = System.Drawing.Color.White;
            this.BTN_SERACH.Location = new System.Drawing.Point(744, 5);
            this.BTN_SERACH.Name = "BTN_SERACH";
            this.BTN_SERACH.Size = new System.Drawing.Size(99, 31);
            this.BTN_SERACH.TabIndex = 119;
            this.BTN_SERACH.Text = "Search";
            this.BTN_SERACH.UseVisualStyleBackColor = false;
            this.BTN_SERACH.Click += new System.EventHandler(this.BTN_SERACH_Click);
            // 
            // SEARCH_ID
            // 
            this.SEARCH_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SEARCH_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SEARCH_ID.BackColor = System.Drawing.Color.White;
            this.SEARCH_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SEARCH_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SEARCH_ID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_ID.ForeColor = System.Drawing.Color.Black;
            this.SEARCH_ID.Location = new System.Drawing.Point(574, 5);
            this.SEARCH_ID.MaxLength = 40;
            this.SEARCH_ID.Name = "SEARCH_ID";
            this.SEARCH_ID.Size = new System.Drawing.Size(169, 31);
            this.SEARCH_ID.TabIndex = 114;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1307, 8);
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
            this.label18.Size = new System.Drawing.Size(109, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sale Return";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 633);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1338, 5);
            this.lblFooter.TabIndex = 131;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(947, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(41, 29);
            this.btnClear.TabIndex = 143;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ID.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.ID.Location = new System.Drawing.Point(195, 78);
            this.ID.MaxLength = 100;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(96, 29);
            this.ID.TabIndex = 133;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(887, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 29);
            this.btnAdd.TabIndex = 136;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BARCODE
            // 
            this.BARCODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BARCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BARCODE.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.BARCODE.Location = new System.Drawing.Point(-1, 40);
            this.BARCODE.MaxLength = 100;
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Size = new System.Drawing.Size(17, 29);
            this.BARCODE.TabIndex = 132;
            this.BARCODE.Visible = false;
            // 
            // QUANTITY
            // 
            this.QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QUANTITY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.QUANTITY.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.QUANTITY.Location = new System.Drawing.Point(785, 78);
            this.QUANTITY.MaxLength = 3;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(100, 29);
            this.QUANTITY.TabIndex = 135;
            this.QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(785, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 140;
            this.label4.Text = "Retrun Qty";
            // 
            // PARTICULAR
            // 
            this.PARTICULAR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PARTICULAR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PARTICULAR.BackColor = System.Drawing.Color.White;
            this.PARTICULAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PARTICULAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PARTICULAR.Enabled = false;
            this.PARTICULAR.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.PARTICULAR.Location = new System.Drawing.Point(292, 78);
            this.PARTICULAR.MaxLength = 100;
            this.PARTICULAR.Name = "PARTICULAR";
            this.PARTICULAR.ReadOnly = true;
            this.PARTICULAR.Size = new System.Drawing.Size(491, 29);
            this.PARTICULAR.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(289, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 139;
            this.label5.Text = "Particular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(195, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 146;
            this.label1.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grdSaleReturnData);
            this.panel1.Controls.Add(this.grdSaleData);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(5, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 427);
            this.panel1.TabIndex = 147;
            // 
            // grdSaleReturnData
            // 
            this.grdSaleReturnData.AllowUserToAddRows = false;
            this.grdSaleReturnData.AllowUserToDeleteRows = false;
            this.grdSaleReturnData.AllowUserToResizeColumns = false;
            this.grdSaleReturnData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSaleReturnData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSaleReturnData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSaleReturnData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleReturnData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdSaleReturnData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleReturnData.EnableHeadersVisualStyles = false;
            this.grdSaleReturnData.Location = new System.Drawing.Point(668, 2);
            this.grdSaleReturnData.Name = "grdSaleReturnData";
            this.grdSaleReturnData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleReturnData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSaleReturnData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdSaleReturnData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdSaleReturnData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdSaleReturnData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F);
            this.grdSaleReturnData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdSaleReturnData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdSaleReturnData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdSaleReturnData.RowTemplate.Height = 28;
            this.grdSaleReturnData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleReturnData.Size = new System.Drawing.Size(659, 421);
            this.grdSaleReturnData.TabIndex = 119;
            this.grdSaleReturnData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdSaleReturnData_MouseDoubleClick);
            // 
            // grdSaleData
            // 
            this.grdSaleData.AllowUserToAddRows = false;
            this.grdSaleData.AllowUserToDeleteRows = false;
            this.grdSaleData.AllowUserToResizeColumns = false;
            this.grdSaleData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSaleData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdSaleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSaleData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdSaleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleData.EnableHeadersVisualStyles = false;
            this.grdSaleData.Location = new System.Drawing.Point(2, 2);
            this.grdSaleData.Name = "grdSaleData";
            this.grdSaleData.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleData.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdSaleData.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.grdSaleData.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdSaleData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdSaleData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F);
            this.grdSaleData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdSaleData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdSaleData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdSaleData.RowTemplate.Height = 28;
            this.grdSaleData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleData.Size = new System.Drawing.Size(664, 421);
            this.grdSaleData.TabIndex = 118;
            this.grdSaleData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdSaleData_MouseDoubleClick);
            // 
            // PARTY_NAME
            // 
            this.PARTY_NAME.AutoSize = true;
            this.PARTY_NAME.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.PARTY_NAME.ForeColor = System.Drawing.Color.Black;
            this.PARTY_NAME.Location = new System.Drawing.Point(8, 543);
            this.PARTY_NAME.Name = "PARTY_NAME";
            this.PARTY_NAME.Size = new System.Drawing.Size(129, 22);
            this.PARTY_NAME.TabIndex = 148;
            this.PARTY_NAME.Text = "Name && Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 149;
            this.label2.Text = "Total :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(69, 574);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(19, 22);
            this.lblTotalAmount.TabIndex = 150;
            this.lblTotalAmount.Text = "0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1077, 573);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(249, 39);
            this.btnSubmit.TabIndex = 151;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ONLINE
            // 
            this.ONLINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.ONLINE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ONLINE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ONLINE.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.ONLINE.Location = new System.Drawing.Point(858, 596);
            this.ONLINE.MaxLength = 100;
            this.ONLINE.Name = "ONLINE";
            this.ONLINE.Size = new System.Drawing.Size(201, 30);
            this.ONLINE.TabIndex = 153;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(769, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 22);
            this.label12.TabIndex = 155;
            this.label12.Text = "Online Rs.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(781, 565);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 154;
            this.label11.Text = "Cash Rs.";
            // 
            // CASH
            // 
            this.CASH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.CASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CASH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CASH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.CASH.Location = new System.Drawing.Point(858, 561);
            this.CASH.MaxLength = 100;
            this.CASH.Name = "CASH";
            this.CASH.Size = new System.Drawing.Size(201, 30);
            this.CASH.TabIndex = 152;
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.AutoSize = true;
            this.CUSTOMER_ID.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.CUSTOMER_ID.ForeColor = System.Drawing.Color.Black;
            this.CUSTOMER_ID.Location = new System.Drawing.Point(578, 574);
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            this.CUSTOMER_ID.Size = new System.Drawing.Size(19, 22);
            this.CUSTOMER_ID.TabIndex = 156;
            this.CUSTOMER_ID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(461, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 157;
            this.label3.Text = "Customer ID : ";
            // 
            // STOCK
            // 
            this.STOCK.AutoSize = true;
            this.STOCK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOCK.Location = new System.Drawing.Point(993, 87);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(15, 14);
            this.STOCK.TabIndex = 158;
            this.STOCK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1014, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 159;
            this.label6.Text = "Add To Godown";
            // 
            // SaleReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1338, 638);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.STOCK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CUSTOMER_ID);
            this.Controls.Add(this.ONLINE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CASH);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PARTY_NAME);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BARCODE);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PARTICULAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SaleReturn_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleReturnData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label lbl_billId;
        private System.Windows.Forms.Label label31;
        internal System.Windows.Forms.Button BTN_SERACH;
        private System.Windows.Forms.TextBox SEARCH_ID;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFooter;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox ID;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox BARCODE;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PARTICULAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdSaleReturnData;
        private System.Windows.Forms.DataGridView grdSaleData;
        private System.Windows.Forms.Label PARTY_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmount;
        internal System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox ONLINE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CASH;
        private System.Windows.Forms.Label CUSTOMER_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox STOCK;
        private System.Windows.Forms.Label label6;
    }
}