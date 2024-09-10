namespace Enterprises.HRModule
{
    partial class SalaryPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryPay));
            this.grpContent = new System.Windows.Forms.Panel();
            this.YEAR = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MONTH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.NAME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SALARY = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.NO_OF_DAYS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PRESENT_DAYS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ABSENT_DAYS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EXTRA_RUPEES = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DEDUCTION_RUPEES = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.HALF_DAY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Holiday = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TOTAL_ = new System.Windows.Forms.TextBox();
            this.grpContent.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContent
            // 
            this.grpContent.BackColor = System.Drawing.Color.White;
            this.grpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpContent.Controls.Add(this.YEAR);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Controls.Add(this.MONTH);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.SAVE);
            this.grpContent.Controls.Add(this.NAME);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContent.Location = new System.Drawing.Point(0, 41);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(848, 135);
            this.grpContent.TabIndex = 0;
            // 
            // YEAR
            // 
            this.YEAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YEAR.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.YEAR.FormattingEnabled = true;
            this.YEAR.Location = new System.Drawing.Point(678, 33);
            this.YEAR.Name = "YEAR";
            this.YEAR.Size = new System.Drawing.Size(162, 27);
            this.YEAR.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(632, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // MONTH
            // 
            this.MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MONTH.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.MONTH.FormattingEnabled = true;
            this.MONTH.Location = new System.Drawing.Point(439, 33);
            this.MONTH.Name = "MONTH";
            this.MONTH.Size = new System.Drawing.Size(162, 27);
            this.MONTH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(382, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Month";
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DarkGreen;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SAVE.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(439, 66);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(401, 33);
            this.SAVE.TabIndex = 3;
            this.SAVE.Tag = "";
            this.SAVE.Text = "Search";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // NAME
            // 
            this.NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NAME.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.NAME.FormattingEnabled = true;
            this.NAME.Location = new System.Drawing.Point(108, 33);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(266, 27);
            this.NAME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee";
            // 
            // SALARY
            // 
            this.SALARY.BackColor = System.Drawing.Color.White;
            this.SALARY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SALARY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SALARY.Enabled = false;
            this.SALARY.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALARY.Location = new System.Drawing.Point(145, 260);
            this.SALARY.MaxLength = 25;
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(263, 27);
            this.SALARY.TabIndex = 2;
            this.SALARY.Tag = "";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.ForeColor = System.Drawing.Color.Black;
            this.lblCatName.Location = new System.Drawing.Point(48, 263);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(93, 19);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Your Salary";
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
            this.headPanel.Size = new System.Drawing.Size(848, 41);
            this.headPanel.TabIndex = 64;
            this.headPanel.TabStop = true;
            // 
            // CLOSE
            // 
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(812, 8);
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
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "Salary";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(156)))));
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(0, 524);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(848, 5);
            this.lblFooter.TabIndex = 66;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NO_OF_DAYS
            // 
            this.NO_OF_DAYS.BackColor = System.Drawing.Color.White;
            this.NO_OF_DAYS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NO_OF_DAYS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NO_OF_DAYS.Enabled = false;
            this.NO_OF_DAYS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO_OF_DAYS.Location = new System.Drawing.Point(595, 260);
            this.NO_OF_DAYS.MaxLength = 25;
            this.NO_OF_DAYS.Name = "NO_OF_DAYS";
            this.NO_OF_DAYS.Size = new System.Drawing.Size(153, 27);
            this.NO_OF_DAYS.TabIndex = 67;
            this.NO_OF_DAYS.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(502, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "No Of Day\'s";
            // 
            // PRESENT_DAYS
            // 
            this.PRESENT_DAYS.BackColor = System.Drawing.Color.White;
            this.PRESENT_DAYS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PRESENT_DAYS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PRESENT_DAYS.Enabled = false;
            this.PRESENT_DAYS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRESENT_DAYS.Location = new System.Drawing.Point(145, 305);
            this.PRESENT_DAYS.MaxLength = 25;
            this.PRESENT_DAYS.Name = "PRESENT_DAYS";
            this.PRESENT_DAYS.Size = new System.Drawing.Size(153, 27);
            this.PRESENT_DAYS.TabIndex = 69;
            this.PRESENT_DAYS.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Present Day\'s";
            // 
            // ABSENT_DAYS
            // 
            this.ABSENT_DAYS.BackColor = System.Drawing.Color.White;
            this.ABSENT_DAYS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ABSENT_DAYS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ABSENT_DAYS.Enabled = false;
            this.ABSENT_DAYS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABSENT_DAYS.Location = new System.Drawing.Point(595, 305);
            this.ABSENT_DAYS.MaxLength = 25;
            this.ABSENT_DAYS.Name = "ABSENT_DAYS";
            this.ABSENT_DAYS.Size = new System.Drawing.Size(153, 27);
            this.ABSENT_DAYS.TabIndex = 71;
            this.ABSENT_DAYS.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(490, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 72;
            this.label6.Text = "Absent Day\'s";
            // 
            // EXTRA_RUPEES
            // 
            this.EXTRA_RUPEES.BackColor = System.Drawing.Color.White;
            this.EXTRA_RUPEES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EXTRA_RUPEES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EXTRA_RUPEES.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXTRA_RUPEES.Location = new System.Drawing.Point(145, 391);
            this.EXTRA_RUPEES.MaxLength = 25;
            this.EXTRA_RUPEES.Name = "EXTRA_RUPEES";
            this.EXTRA_RUPEES.Size = new System.Drawing.Size(153, 27);
            this.EXTRA_RUPEES.TabIndex = 1;
            this.EXTRA_RUPEES.Tag = "";
            this.EXTRA_RUPEES.TextChanged += new System.EventHandler(this.EXTRA_RUPEES_TextChanged);
            this.EXTRA_RUPEES.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EXTRA_RUPEES_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 38);
            this.label7.TabIndex = 74;
            this.label7.Text = "Extra / Mudy / \r\nCommision Rs.";
            // 
            // DEDUCTION_RUPEES
            // 
            this.DEDUCTION_RUPEES.BackColor = System.Drawing.Color.White;
            this.DEDUCTION_RUPEES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DEDUCTION_RUPEES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DEDUCTION_RUPEES.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEDUCTION_RUPEES.Location = new System.Drawing.Point(595, 391);
            this.DEDUCTION_RUPEES.MaxLength = 25;
            this.DEDUCTION_RUPEES.Name = "DEDUCTION_RUPEES";
            this.DEDUCTION_RUPEES.Size = new System.Drawing.Size(153, 27);
            this.DEDUCTION_RUPEES.TabIndex = 2;
            this.DEDUCTION_RUPEES.Tag = "";
            this.DEDUCTION_RUPEES.TextChanged += new System.EventHandler(this.EXTRA_RUPEES_TextChanged);
            this.DEDUCTION_RUPEES.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EXTRA_RUPEES_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(410, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Deduction / Advance Rs.";
            // 
            // TOTAL
            // 
            this.TOTAL.BackColor = System.Drawing.Color.White;
            this.TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TOTAL.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(145, 442);
            this.TOTAL.MaxLength = 25;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(263, 38);
            this.TOTAL.TabIndex = 77;
            this.TOTAL.Tag = "";
            this.TOTAL.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 78;
            this.label9.Text = "Total";
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayNow.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(471, 432);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(294, 45);
            this.btnPayNow.TabIndex = 3;
            this.btnPayNow.Tag = "";
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(253, 191);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(342, 33);
            this.lbl_name.TabIndex = 80;
            this.lbl_name.Text = "Bhupesh Jaydeo Sonkusale";
            // 
            // HALF_DAY
            // 
            this.HALF_DAY.BackColor = System.Drawing.Color.White;
            this.HALF_DAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HALF_DAY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HALF_DAY.Enabled = false;
            this.HALF_DAY.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HALF_DAY.Location = new System.Drawing.Point(145, 348);
            this.HALF_DAY.MaxLength = 25;
            this.HALF_DAY.Name = "HALF_DAY";
            this.HALF_DAY.Size = new System.Drawing.Size(153, 27);
            this.HALF_DAY.TabIndex = 81;
            this.HALF_DAY.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(60, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 82;
            this.label10.Text = "Half Day\'s";
            // 
            // Holiday
            // 
            this.Holiday.BackColor = System.Drawing.Color.White;
            this.Holiday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Holiday.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Holiday.Enabled = false;
            this.Holiday.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holiday.Location = new System.Drawing.Point(595, 349);
            this.Holiday.MaxLength = 25;
            this.Holiday.Name = "Holiday";
            this.Holiday.Size = new System.Drawing.Size(153, 27);
            this.Holiday.TabIndex = 83;
            this.Holiday.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(456, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 19);
            this.label11.TabIndex = 84;
            this.label11.Text = "Holiday\'s / Others";
            // 
            // TOTAL_
            // 
            this.TOTAL_.BackColor = System.Drawing.Color.White;
            this.TOTAL_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTAL_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TOTAL_.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_.Location = new System.Drawing.Point(145, 483);
            this.TOTAL_.MaxLength = 25;
            this.TOTAL_.Name = "TOTAL_";
            this.TOTAL_.Size = new System.Drawing.Size(263, 38);
            this.TOTAL_.TabIndex = 85;
            this.TOTAL_.Tag = "";
            this.TOTAL_.Text = "0.00";
            this.TOTAL_.Visible = false;
            // 
            // SalaryPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 529);
            this.ControlBox = false;
            this.Controls.Add(this.TOTAL_);
            this.Controls.Add(this.Holiday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HALF_DAY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DEDUCTION_RUPEES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EXTRA_RUPEES);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ABSENT_DAYS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PRESENT_DAYS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NO_OF_DAYS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.SALARY);
            this.Controls.Add(this.lblCatName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalaryPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SalaryPay_Load);
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.TextBox SALARY;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox NAME;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.ComboBox MONTH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.ComboBox YEAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NO_OF_DAYS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PRESENT_DAYS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ABSENT_DAYS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EXTRA_RUPEES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DEDUCTION_RUPEES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TOTAL;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox HALF_DAY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Holiday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TOTAL_;
    }
}