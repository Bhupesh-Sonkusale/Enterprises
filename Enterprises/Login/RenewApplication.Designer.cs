namespace Enterprises.Login
{
    partial class RenewApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewApplication));
            this.headPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panelRenew = new System.Windows.Forms.Panel();
            this.btnyearChange = new System.Windows.Forms.Button();
            this.Validate = new System.Windows.Forms.Button();
            this.ExtendDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.securityKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.TextBox();
            this.lblCatCode = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.DEVELOPED_BY = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRenew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendDays)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.headPanel.Controls.Add(this.pictureBox2);
            this.headPanel.Controls.Add(this.label18);
            this.headPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.Color.White;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(657, 41);
            this.headPanel.TabIndex = 20;
            this.headPanel.TabStop = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(626, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "Renew Application ";
            // 
            // panelRenew
            // 
            this.panelRenew.BackColor = System.Drawing.Color.White;
            this.panelRenew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRenew.Controls.Add(this.btnyearChange);
            this.panelRenew.Controls.Add(this.Validate);
            this.panelRenew.Controls.Add(this.ExtendDays);
            this.panelRenew.Controls.Add(this.label2);
            this.panelRenew.Controls.Add(this.lblFooter);
            this.panelRenew.Controls.Add(this.securityKey);
            this.panelRenew.Controls.Add(this.label1);
            this.panelRenew.Controls.Add(this.submit);
            this.panelRenew.Controls.Add(this.startDate);
            this.panelRenew.Controls.Add(this.lblCatCode);
            this.panelRenew.Controls.Add(this.lblCatName);
            this.panelRenew.Controls.Add(this.endDate);
            this.panelRenew.Controls.Add(this.shapeContainer1);
            this.panelRenew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRenew.Location = new System.Drawing.Point(0, 41);
            this.panelRenew.Name = "panelRenew";
            this.panelRenew.Size = new System.Drawing.Size(657, 257);
            this.panelRenew.TabIndex = 19;
            // 
            // btnyearChange
            // 
            this.btnyearChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.btnyearChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyearChange.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyearChange.ForeColor = System.Drawing.Color.Black;
            this.btnyearChange.Location = new System.Drawing.Point(503, 217);
            this.btnyearChange.Name = "btnyearChange";
            this.btnyearChange.Size = new System.Drawing.Size(148, 30);
            this.btnyearChange.TabIndex = 32;
            this.btnyearChange.Text = "Set Change Year";
            this.btnyearChange.UseVisualStyleBackColor = false;
            this.btnyearChange.Click += new System.EventHandler(this.btnyearChange_Click);
            // 
            // Validate
            // 
            this.Validate.BackColor = System.Drawing.Color.Crimson;
            this.Validate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Validate.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.ForeColor = System.Drawing.Color.White;
            this.Validate.Location = new System.Drawing.Point(472, 22);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(103, 26);
            this.Validate.TabIndex = 31;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = false;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // ExtendDays
            // 
            this.ExtendDays.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendDays.Location = new System.Drawing.Point(265, 151);
            this.ExtendDays.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ExtendDays.Name = "ExtendDays";
            this.ExtendDays.Size = new System.Drawing.Size(200, 25);
            this.ExtendDays.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(189, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enter Day";
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
            // securityKey
            // 
            this.securityKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.securityKey.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityKey.Location = new System.Drawing.Point(208, 22);
            this.securityKey.MaxLength = 20;
            this.securityKey.Name = "securityKey";
            this.securityKey.PasswordChar = '*';
            this.securityKey.Size = new System.Drawing.Size(263, 25);
            this.securityKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Security Key :";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DarkGreen;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(265, 189);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 34);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // startDate
            // 
            this.startDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDate.Enabled = false;
            this.startDate.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(265, 84);
            this.startDate.MaxLength = 10;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 25);
            this.startDate.TabIndex = 1;
            // 
            // lblCatCode
            // 
            this.lblCatCode.AutoSize = true;
            this.lblCatCode.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCode.ForeColor = System.Drawing.Color.Black;
            this.lblCatCode.Location = new System.Drawing.Point(194, 121);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(67, 18);
            this.lblCatCode.TabIndex = 0;
            this.lblCatCode.Text = "End Date";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Black;
            this.lblCatName.Location = new System.Drawing.Point(186, 87);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(75, 18);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Start Date";
            // 
            // endDate
            // 
            this.endDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDate.Enabled = false;
            this.endDate.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(265, 118);
            this.endDate.MaxLength = 10;
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 25);
            this.endDate.TabIndex = 2;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(655, 255);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 53;
            this.lineShape1.X2 = 603;
            this.lineShape1.Y1 = 55;
            this.lineShape1.Y2 = 55;
            // 
            // DEVELOPED_BY
            // 
            this.DEVELOPED_BY.AutoSize = true;
            this.DEVELOPED_BY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.DEVELOPED_BY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEVELOPED_BY.ForeColor = System.Drawing.Color.White;
            this.DEVELOPED_BY.Location = new System.Drawing.Point(6, 291);
            this.DEVELOPED_BY.Name = "DEVELOPED_BY";
            this.DEVELOPED_BY.Size = new System.Drawing.Size(12, 15);
            this.DEVELOPED_BY.TabIndex = 21;
            this.DEVELOPED_BY.Text = "-";
            // 
            // RenewApplication
            // 
            this.AcceptButton = this.Validate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.ControlBox = false;
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.panelRenew);
            this.Controls.Add(this.DEVELOPED_BY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenewApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRenew.ResumeLayout(false);
            this.panelRenew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelRenew;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TextBox securityKey;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Label lblCatCode;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.Label DEVELOPED_BY;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.NumericUpDown ExtendDays;
        internal System.Windows.Forms.Button Validate;
        internal System.Windows.Forms.Button btnyearChange;
    }
}