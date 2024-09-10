namespace Enterprises.Login
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReEnterNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnChnage = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.Panel();
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
            this.headPanel.Size = new System.Drawing.Size(657, 41);
            this.headPanel.TabIndex = 24;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(623, 8);
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
            this.label18.Size = new System.Drawing.Size(188, 27);
            this.label18.TabIndex = 1;
            this.label18.Text = "Change Password";
            // 
            // txtReEnterNewPassword
            // 
            this.txtReEnterNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReEnterNewPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterNewPassword.Location = new System.Drawing.Point(324, 144);
            this.txtReEnterNewPassword.MaxLength = 10;
            this.txtReEnterNewPassword.Name = "txtReEnterNewPassword";
            this.txtReEnterNewPassword.Size = new System.Drawing.Size(200, 27);
            this.txtReEnterNewPassword.TabIndex = 3;
            this.txtReEnterNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(131, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Re-Enter New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(324, 110);
            this.txtNewPassword.MaxLength = 10;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 27);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(201, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(324, 77);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(209, 80);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(108, 19);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Old Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(324, 43);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.ForeColor = System.Drawing.Color.Black;
            this.lblCatCode.Location = new System.Drawing.Point(228, 46);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(89, 19);
            this.lblCatCode.TabIndex = 0;
            this.lblCatCode.Text = "User Name";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 308);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(657, 5);
            this.lblFooter.TabIndex = 25;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChnage
            // 
            this.btnChnage.BackColor = System.Drawing.Color.DarkGreen;
            this.btnChnage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChnage.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChnage.ForeColor = System.Drawing.Color.White;
            this.btnChnage.Location = new System.Drawing.Point(324, 7);
            this.btnChnage.Name = "btnChnage";
            this.btnChnage.Size = new System.Drawing.Size(200, 36);
            this.btnChnage.TabIndex = 1;
            this.btnChnage.Text = "Change Password";
            this.btnChnage.UseVisualStyleBackColor = false;
            this.btnChnage.Click += new System.EventHandler(this.btnChnage_Click);
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.White;
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Controls.Add(this.txtReEnterNewPassword);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.lblCatCode);
            this.grpContent.Controls.Add(this.txtNewPassword);
            this.grpContent.Controls.Add(this.txtUserName);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.lblCatName);
            this.grpContent.Controls.Add(this.txtPassword);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(657, 214);
            this.grpContent.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Note : Password are in only letters and numbers.";
            // 
            // grpButtonStrip
            // 
            this.grpButtonStrip.BackColor = System.Drawing.Color.LightGreen;
            this.grpButtonStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpButtonStrip.Controls.Add(this.btnChnage);
            this.grpButtonStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpButtonStrip.Location = new System.Drawing.Point(0, 255);
            this.grpButtonStrip.Name = "grpButtonStrip";
            this.grpButtonStrip.Size = new System.Drawing.Size(657, 53);
            this.grpButtonStrip.TabIndex = 65;
            // 
            // Change_Password
            // 
            this.AcceptButton = this.btnChnage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 313);
            this.ControlBox = false;
            this.Controls.Add(this.grpButtonStrip);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.lblFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Label lblFooter;
        internal System.Windows.Forms.Button btnChnage;
        private System.Windows.Forms.TextBox txtReEnterNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CLOSE;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Panel grpButtonStrip;
        private System.Windows.Forms.Label label3;
    }
}