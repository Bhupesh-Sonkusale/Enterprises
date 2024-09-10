namespace Enterprises.Login
{
    partial class ForgetPassword
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DEVELOPED_BY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.MOBILE = new System.Windows.Forms.TextBox();
            this.rdoEmployee = new System.Windows.Forms.RadioButton();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.backtoLogin = new System.Windows.Forms.Button();
            this.lblCatName = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.USER_NAME = new System.Windows.Forms.TextBox();
            this.headPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.headPanel.Controls.Add(this.label18);
            this.headPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.Color.White;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(657, 41);
            this.headPanel.TabIndex = 14;
            this.headPanel.TabStop = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(239, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 27);
            this.label18.TabIndex = 1;
            this.label18.Text = "Forget Password";
            // 
            // DEVELOPED_BY
            // 
            this.DEVELOPED_BY.AutoSize = true;
            this.DEVELOPED_BY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.DEVELOPED_BY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEVELOPED_BY.ForeColor = System.Drawing.Color.White;
            this.DEVELOPED_BY.Location = new System.Drawing.Point(6, 298);
            this.DEVELOPED_BY.Name = "DEVELOPED_BY";
            this.DEVELOPED_BY.Size = new System.Drawing.Size(12, 15);
            this.DEVELOPED_BY.TabIndex = 18;
            this.DEVELOPED_BY.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFooter);
            this.panel1.Controls.Add(this.NAME);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.MOBILE);
            this.panel1.Controls.Add(this.rdoEmployee);
            this.panel1.Controls.Add(this.lblCatCode);
            this.panel1.Controls.Add(this.backtoLogin);
            this.panel1.Controls.Add(this.lblCatName);
            this.panel1.Controls.Add(this.rdoAdmin);
            this.panel1.Controls.Add(this.USER_NAME);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 257);
            this.panel1.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 250);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(655, 5);
            this.lblFooter.TabIndex = 26;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAME
            // 
            this.NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NAME.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(251, 32);
            this.NAME.MaxLength = 40;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(235, 27);
            this.NAME.TabIndex = 0;
            this.NAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAME_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(194, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DarkGreen;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(251, 176);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(235, 34);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // MOBILE
            // 
            this.MOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MOBILE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBILE.Location = new System.Drawing.Point(251, 66);
            this.MOBILE.MaxLength = 10;
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.Size = new System.Drawing.Size(235, 27);
            this.MOBILE.TabIndex = 1;
            this.MOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MOBILE_KeyPress);
            // 
            // rdoEmployee
            // 
            this.rdoEmployee.AutoSize = true;
            this.rdoEmployee.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmployee.Location = new System.Drawing.Point(377, 142);
            this.rdoEmployee.Name = "rdoEmployee";
            this.rdoEmployee.Size = new System.Drawing.Size(100, 23);
            this.rdoEmployee.TabIndex = 4;
            this.rdoEmployee.Text = "Employee";
            this.rdoEmployee.UseVisualStyleBackColor = true;
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.ForeColor = System.Drawing.Color.Red;
            this.lblCatCode.Location = new System.Drawing.Point(157, 103);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(89, 19);
            this.lblCatCode.TabIndex = 0;
            this.lblCatCode.Text = "User Name";
            // 
            // backtoLogin
            // 
            this.backtoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.backtoLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backtoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backtoLogin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoLogin.ForeColor = System.Drawing.Color.White;
            this.backtoLogin.Location = new System.Drawing.Point(3, 213);
            this.backtoLogin.Name = "backtoLogin";
            this.backtoLogin.Size = new System.Drawing.Size(126, 34);
            this.backtoLogin.TabIndex = 6;
            this.backtoLogin.Text = "<< Back To Login";
            this.backtoLogin.UseVisualStyleBackColor = false;
            this.backtoLogin.Click += new System.EventHandler(this.backtoLogin_Click);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(189, 69);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(57, 19);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Mobile";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Checked = true;
            this.rdoAdmin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmin.Location = new System.Drawing.Point(273, 142);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(73, 23);
            this.rdoAdmin.TabIndex = 3;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // USER_NAME
            // 
            this.USER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER_NAME.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER_NAME.Location = new System.Drawing.Point(251, 100);
            this.USER_NAME.MaxLength = 10;
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.PasswordChar = '*';
            this.USER_NAME.Size = new System.Drawing.Size(235, 27);
            this.USER_NAME.TabIndex = 2;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DEVELOPED_BY);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label DEVELOPED_BY;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox MOBILE;
        private System.Windows.Forms.Label lblCatCode;
        internal System.Windows.Forms.Button backtoLogin;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox USER_NAME;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoEmployee;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.Label lblFooter;
    }
}