namespace Enterprises.Transaction
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.NEW = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.REMARK = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBEXPENSE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.CASH = new System.Windows.Forms.TextBox();
            this.grpContent = new System.Windows.Forms.Panel();
            this.ONLINE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpButtonStrip = new System.Windows.Forms.Panel();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.grpContent.SuspendLayout();
            this.grpButtonStrip.SuspendLayout();
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
            this.headPanel.Size = new System.Drawing.Size(648, 41);
            this.headPanel.TabIndex = 57;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(618, 8);
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
            this.label18.Location = new System.Drawing.Point(5, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 27);
            this.label18.TabIndex = 1;
            this.label18.Text = "Expense";
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.Blue;
            this.NEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEW.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.ForeColor = System.Drawing.Color.White;
            this.NEW.Location = new System.Drawing.Point(245, 5);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(134, 37);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "New";
            this.NEW.UseVisualStyleBackColor = false;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            this.NEW.Enter += new System.EventHandler(this.NEW_Enter);
            this.NEW.Leave += new System.EventHandler(this.NEW_Leave);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.Green;
            this.SAVE.Enabled = false;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAVE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(381, 5);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(127, 37);
            this.SAVE.TabIndex = 1;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            this.SAVE.Enter += new System.EventHandler(this.SAVE_Enter);
            this.SAVE.Leave += new System.EventHandler(this.SAVE_Leave);
            // 
            // REMARK
            // 
            this.REMARK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.REMARK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.REMARK.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMARK.Location = new System.Drawing.Point(255, 165);
            this.REMARK.MaxLength = 50;
            this.REMARK.Multiline = true;
            this.REMARK.Name = "REMARK";
            this.REMARK.Size = new System.Drawing.Size(263, 99);
            this.REMARK.TabIndex = 4;
            this.REMARK.Enter += new System.EventHandler(this.REMARK_Enter);
            this.REMARK.Leave += new System.EventHandler(this.CMBEXPENSE_Leave);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(183, 168);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(66, 19);
            this.lblCatName.TabIndex = 12;
            this.lblCatName.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(179, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cash Rs.";
            // 
            // CMBEXPENSE
            // 
            this.CMBEXPENSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBEXPENSE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBEXPENSE.FormattingEnabled = true;
            this.CMBEXPENSE.Location = new System.Drawing.Point(255, 57);
            this.CMBEXPENSE.Name = "CMBEXPENSE";
            this.CMBEXPENSE.Size = new System.Drawing.Size(263, 27);
            this.CMBEXPENSE.TabIndex = 1;
            this.CMBEXPENSE.SelectedIndexChanged += new System.EventHandler(this.CMBEXPENSE_SelectedIndexChanged);
            this.CMBEXPENSE.Leave += new System.EventHandler(this.CMBEXPENSE_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(129, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Expense";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 413);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(648, 5);
            this.lblFooter.TabIndex = 62;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CASH
            // 
            this.CASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CASH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CASH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASH.Location = new System.Drawing.Point(255, 93);
            this.CASH.MaxLength = 10;
            this.CASH.Name = "CASH";
            this.CASH.Size = new System.Drawing.Size(263, 27);
            this.CASH.TabIndex = 2;
            this.CASH.Enter += new System.EventHandler(this.CASH_Enter);
            this.CASH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AMOUNT_KeyPress);
            this.CASH.Leave += new System.EventHandler(this.CMBEXPENSE_Leave);
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.White;
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.ONLINE);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Controls.Add(this.CASH);
            this.grpContent.Controls.Add(this.REMARK);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.CMBEXPENSE);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.lblCatName);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Enabled = false;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(648, 322);
            this.grpContent.TabIndex = 0;
            // 
            // ONLINE
            // 
            this.ONLINE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ONLINE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ONLINE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONLINE.Location = new System.Drawing.Point(255, 129);
            this.ONLINE.MaxLength = 10;
            this.ONLINE.Name = "ONLINE";
            this.ONLINE.Size = new System.Drawing.Size(263, 27);
            this.ONLINE.TabIndex = 3;
            this.ONLINE.Enter += new System.EventHandler(this.ONLINE_Enter);
            this.ONLINE.Leave += new System.EventHandler(this.CMBEXPENSE_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(169, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Online Rs.";
            // 
            // grpButtonStrip
            // 
            this.grpButtonStrip.BackColor = System.Drawing.Color.LightGreen;
            this.grpButtonStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpButtonStrip.Controls.Add(this.NEW);
            this.grpButtonStrip.Controls.Add(this.SAVE);
            this.grpButtonStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpButtonStrip.Location = new System.Drawing.Point(0, 364);
            this.grpButtonStrip.Name = "grpButtonStrip";
            this.grpButtonStrip.Size = new System.Drawing.Size(648, 49);
            this.grpButtonStrip.TabIndex = 1;
            // 
            // Expense
            // 
            this.AcceptButton = this.SAVE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 418);
            this.ControlBox = false;
            this.Controls.Add(this.grpButtonStrip);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Expense_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.grpButtonStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Button NEW;
        internal System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.ComboBox CMBEXPENSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox REMARK;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox CASH;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Panel grpButtonStrip;
        private System.Windows.Forms.TextBox ONLINE;
        private System.Windows.Forms.Label label3;
    }
}