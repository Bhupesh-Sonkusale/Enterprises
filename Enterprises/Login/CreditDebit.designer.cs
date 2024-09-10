namespace Enterprises.Login
{
    partial class CreditDebit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditDebit));
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBtype = new System.Windows.Forms.ComboBox();
            this.AMOUNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpButtonStrip = new System.Windows.Forms.Panel();
            this.SAVE = new System.Windows.Forms.Button();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
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
            this.headPanel.Size = new System.Drawing.Size(598, 41);
            this.headPanel.TabIndex = 58;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(566, 8);
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
            this.label18.Location = new System.Drawing.Point(5, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(244, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Add Credit / Debit Amount";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 393);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(598, 5);
            this.lblFooter.TabIndex = 63;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select Type";
            // 
            // CMBtype
            // 
            this.CMBtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBtype.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBtype.FormattingEnabled = true;
            this.CMBtype.Items.AddRange(new object[] {
            "Select",
            "Debit / Withdraw",
            "Credit / Deposite"});
            this.CMBtype.Location = new System.Drawing.Point(210, 141);
            this.CMBtype.Name = "CMBtype";
            this.CMBtype.Size = new System.Drawing.Size(263, 26);
            this.CMBtype.TabIndex = 0;
            // 
            // AMOUNT
            // 
            this.AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMOUNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.AMOUNT.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMOUNT.Location = new System.Drawing.Point(210, 186);
            this.AMOUNT.MaxLength = 10;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(263, 25);
            this.AMOUNT.TabIndex = 1;
            this.AMOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(145, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Amount";
            // 
            // grpButtonStrip
            // 
            this.grpButtonStrip.BackColor = System.Drawing.Color.LightGreen;
            this.grpButtonStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpButtonStrip.Controls.Add(this.SAVE);
            this.grpButtonStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpButtonStrip.Location = new System.Drawing.Point(0, 344);
            this.grpButtonStrip.Name = "grpButtonStrip";
            this.grpButtonStrip.Size = new System.Drawing.Size(598, 49);
            this.grpButtonStrip.TabIndex = 3;
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DarkGreen;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAVE.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(210, 8);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(263, 33);
            this.SAVE.TabIndex = 0;
            this.SAVE.Text = "Submit";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // PASSWORD
            // 
            this.PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASSWORD.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(211, 232);
            this.PASSWORD.MaxLength = 10;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(263, 25);
            this.PASSWORD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(136, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Password";
            // 
            // CreditDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.ControlBox = false;
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpButtonStrip);
            this.Controls.Add(this.AMOUNT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBtype);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreditDebit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.grpButtonStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBtype;
        private System.Windows.Forms.TextBox AMOUNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel grpButtonStrip;
        internal System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label3;
    }
}