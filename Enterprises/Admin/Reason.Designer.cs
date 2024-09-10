namespace Enterprises.Admin
{
    partial class Reason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reason));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpButtonStrip = new System.Windows.Forms.Panel();
            this.TOTAL_COUNT = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.NEW = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.grpContent = new System.Windows.Forms.Panel();
            this.CATEGORY = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.grpButtonStrip.SuspendLayout();
            this.grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpButtonStrip
            // 
            this.grpButtonStrip.BackColor = System.Drawing.Color.LightGreen;
            this.grpButtonStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpButtonStrip.Controls.Add(this.TOTAL_COUNT);
            this.grpButtonStrip.Controls.Add(this.SAVE);
            this.grpButtonStrip.Controls.Add(this.NEW);
            this.grpButtonStrip.Controls.Add(this.DELETE);
            this.grpButtonStrip.Controls.Add(this.EDIT);
            this.grpButtonStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpButtonStrip.Location = new System.Drawing.Point(0, 118);
            this.grpButtonStrip.Name = "grpButtonStrip";
            this.grpButtonStrip.Size = new System.Drawing.Size(618, 49);
            this.grpButtonStrip.TabIndex = 68;
            // 
            // TOTAL_COUNT
            // 
            this.TOTAL_COUNT.AutoSize = true;
            this.TOTAL_COUNT.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_COUNT.Location = new System.Drawing.Point(5, 16);
            this.TOTAL_COUNT.Name = "TOTAL_COUNT";
            this.TOTAL_COUNT.Size = new System.Drawing.Size(64, 19);
            this.TOTAL_COUNT.TabIndex = 5;
            this.TOTAL_COUNT.Text = "Total : 0";
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DarkGreen;
            this.SAVE.Enabled = false;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAVE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(266, 8);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(84, 30);
            this.SAVE.TabIndex = 1;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.NEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEW.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.ForeColor = System.Drawing.Color.White;
            this.NEW.Location = new System.Drawing.Point(184, 8);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(80, 30);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "New";
            this.NEW.UseVisualStyleBackColor = false;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Crimson;
            this.DELETE.Enabled = false;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.Color.White;
            this.DELETE.Location = new System.Drawing.Point(533, 8);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(80, 30);
            this.DELETE.TabIndex = 3;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Visible = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.EDIT.Enabled = false;
            this.EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EDIT.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.ForeColor = System.Drawing.Color.White;
            this.EDIT.Location = new System.Drawing.Point(352, 8);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(80, 30);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "Edit";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 633);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(618, 5);
            this.lblFooter.TabIndex = 65;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.White;
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.CATEGORY);
            this.grpContent.Controls.Add(this.ID);
            this.grpContent.Controls.Add(this.lblCatName);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Enabled = false;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(618, 77);
            this.grpContent.TabIndex = 67;
            // 
            // CATEGORY
            // 
            this.CATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CATEGORY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CATEGORY.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CATEGORY.Location = new System.Drawing.Point(211, 24);
            this.CATEGORY.MaxLength = 25;
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.Size = new System.Drawing.Size(263, 27);
            this.CATEGORY.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Calibri", 11F);
            this.ID.Location = new System.Drawing.Point(521, 5);
            this.ID.MaxLength = 2;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(92, 25);
            this.ID.TabIndex = 0;
            this.ID.Visible = false;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Red;
            this.lblCatName.Location = new System.Drawing.Point(143, 27);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(63, 19);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Reason";
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(589, 8);
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
            this.label18.Size = new System.Drawing.Size(156, 27);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cancel Reason";
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
            this.headPanel.Size = new System.Drawing.Size(618, 41);
            this.headPanel.TabIndex = 64;
            this.headPanel.TabStop = true;
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
            this.grdData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.Location = new System.Drawing.Point(0, 167);
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
            this.grdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.grdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grdData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(618, 467);
            this.grdData.TabIndex = 120;
            this.grdData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDoubleClick);
            // 
            // Reason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 638);
            this.ControlBox = false;
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.grpButtonStrip);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reason_Load);
            this.grpButtonStrip.ResumeLayout(false);
            this.grpButtonStrip.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grpButtonStrip;
        private System.Windows.Forms.Label TOTAL_COUNT;
        internal System.Windows.Forms.Button SAVE;
        internal System.Windows.Forms.Button NEW;
        internal System.Windows.Forms.Button DELETE;
        internal System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.TextBox CATEGORY;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.DataGridView grdData;
    }
}