using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.HRModule
{
    public partial class SalaryPay : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        public string USER_ID;

        public SalaryPay()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void SalaryPay_Load(object sender, EventArgs e)
        {
            Bind_AdminEmployee();
        }

        public void Bind_AdminEmployee()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                NAME.DisplayMember = "NAME";
                NAME.ValueMember = "ID";
                NAME.DataSource = dt;

                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                dal.AddParameter("@SUB_TYPE", "MONTH", "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                MONTH.DisplayMember = "NAME";
                MONTH.ValueMember = "MONTH";
                MONTH.DataSource = dt;

                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                dal.AddParameter("@SUB_TYPE", "YEAR", "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                YEAR.DisplayMember = "NAME";
                YEAR.ValueMember = "YEAR";
                YEAR.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (NAME.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select Employee Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NAME.Focus();
                    }
                    else if (MONTH.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select Month", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MONTH.Focus();
                    }
                    else if (YEAR.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select Year", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YEAR.Focus();
                    }
                    else
                    {
                        dal.ClearParameters();
                        dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                        dal.AddParameter("@SUB_TYPE", "CALCULATE_SALARY", "IN");
                        dal.AddParameter("@EMPLOYEE_ID", NAME.SelectedValue.ToString().Trim(), "IN");
                        dal.AddParameter("@MONTH", MONTH.SelectedValue.ToString().Trim(), "IN");
                        dal.AddParameter("@YEAR", YEAR.SelectedValue.ToString().Trim(), "IN");
                        dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                        dt = dal.GetTable("SP_REGISTRATION", ref Message);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Search Successfully For Month : " + MONTH.Text.Trim(), _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbl_name.Text = dt.Rows[0]["NAME"].ToString().ToUpper().Trim();
                            SALARY.Text = dt.Rows[0]["SALARY"].ToString().ToUpper().Trim();
                            PRESENT_DAYS.Text = dt.Rows[0]["PRESENT_DAY"].ToString().ToUpper().Trim();
                            ABSENT_DAYS.Text = dt.Rows[0]["ABSENT_DAY"].ToString().ToUpper().Trim();
                            HALF_DAY.Text = dt.Rows[0]["HALF_DAY"].ToString().ToUpper().Trim();
                            NO_OF_DAYS.Text = dt.Rows[0]["MONTH_DAYS"].ToString().ToUpper().Trim();
                            TOTAL_.Text = TOTAL.Text = dt.Rows[0]["CALCULATE_SALARY"].ToString().ToUpper().Trim();
                            Holiday.Text = dt.Rows[0]["Holiday"].ToString().ToUpper().Trim();
                            EXTRA_RUPEES.Text = DEDUCTION_RUPEES.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Oops ! No records Founds", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SALARY.Text = PRESENT_DAYS.Text = ABSENT_DAYS.Text = NO_OF_DAYS.Text = TOTAL.Text = TOTAL_.Text = EXTRA_RUPEES.Text = DEDUCTION_RUPEES.Text = "";
                            Holiday.Text = HALF_DAY.Text = "";
                            lbl_name.Text = "";
                            NAME.Focus();
                        }
                    }
                }
                catch (Exception ex) { }
            }
            catch (Exception ex) { }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                if (NAME.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Employee Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NAME.Focus();
                }
                else if (MONTH.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Month", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MONTH.Focus();
                }
                else if (YEAR.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Year", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YEAR.Focus();
                }
                else if (Convert.ToDecimal(TOTAL.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Invalid Entry", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NAME.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                    dal.AddParameter("@SUB_TYPE", "INSERT_SALARY", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@EMPLOYEE_ID", NAME.SelectedValue.ToString(), "IN");
                    dal.AddParameter("@MONTH", MONTH.SelectedValue.ToString(), "IN");
                    dal.AddParameter("@YEAR", YEAR.SelectedValue.ToString(), "IN");
                    dal.AddParameter("@SALARY", SALARY.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@NO_OF_DAYS", NO_OF_DAYS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@PRESENT_DAYS", PRESENT_DAYS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@ABSENT_DAYS", ABSENT_DAYS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@HALF_DAY", HALF_DAY.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@Holiday", Holiday.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@EXTRA_RUPEES", EXTRA_RUPEES.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@DEDUCTION_RUPEES", DEDUCTION_RUPEES.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@TOTAL", TOTAL.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@RETURN_MSG", "RETURN_MSG", "OUT");
                    _result = dal.ExecuteNonQuery("SP_REGISTRATION", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            NAME.SelectedIndex = MONTH.SelectedIndex = YEAR.SelectedIndex = 0;
            lbl_name.Text = "Name : ";

            foreach(Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void EXTRA_RUPEES_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal EXTRA_RUPEES_;
            //    if (string.IsNullOrEmpty(EXTRA_RUPEES.Text)) { EXTRA_RUPEES_ = 0; } else { EXTRA_RUPEES_ = Convert.ToDecimal(EXTRA_RUPEES.Text); }
            //    decimal DEDUCTION_RUPEES_;
            //    if (string.IsNullOrEmpty(DEDUCTION_RUPEES.Text)) { DEDUCTION_RUPEES_ = 0; } else { DEDUCTION_RUPEES_ = Convert.ToDecimal(DEDUCTION_RUPEES.Text); }
            //    decimal TOTAL_;
            //    if (string.IsNullOrEmpty(TOTAL.Text)) { TOTAL_ = 0; } else { TOTAL_ = Convert.ToDecimal(TOTAL.Text); }
            //    decimal Calculate = 0;
            //    if (EXTRA_RUPEES_ >= 0)
            //    {
            //        Calculate = TOTAL_ + EXTRA_RUPEES_;
            //    }
            //    else
            //    {
            //        Calculate = TOTAL_ - EXTRA_RUPEES_;
            //    }

            //    if (DEDUCTION_RUPEES_ >= 0)
            //    {
            //        Calculate = TOTAL_ + EXTRA_RUPEES_ - DEDUCTION_RUPEES_;
            //    }
            //    else
            //    {
            //        Calculate = (TOTAL_ + EXTRA_RUPEES_) + DEDUCTION_RUPEES_;
            //    }

            //    // Calculate = (TOTAL_ + EXTRA_RUPEES_) - DEDUCTION_RUPEES_;
            //    TOTAL.Text = Calculate.ToString();
            //}
            //catch (Exception ex) { }
        }

        private void EXTRA_RUPEES_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal EXTRA_RUPEES_;
                if (string.IsNullOrEmpty(EXTRA_RUPEES.Text)) { EXTRA_RUPEES_ = 0; } else { EXTRA_RUPEES_ = Convert.ToDecimal(EXTRA_RUPEES.Text); }
                decimal DEDUCTION_RUPEES_;
                if (string.IsNullOrEmpty(DEDUCTION_RUPEES.Text)) { DEDUCTION_RUPEES_ = 0; } else { DEDUCTION_RUPEES_ = Convert.ToDecimal(DEDUCTION_RUPEES.Text); }
                decimal TOTAL__;
                if (string.IsNullOrEmpty(TOTAL_.Text)) { TOTAL__ = 0; } else { TOTAL__ = Convert.ToDecimal(TOTAL_.Text); }
                decimal Calculate = 0;
                if (EXTRA_RUPEES_ >= 0)
                {
                    Calculate = TOTAL__ + EXTRA_RUPEES_;
                }
                else
                {
                    Calculate = TOTAL__ - EXTRA_RUPEES_;
                }

                if (DEDUCTION_RUPEES_ >= 0)
                {
                    Calculate = TOTAL__ + EXTRA_RUPEES_ - DEDUCTION_RUPEES_;
                }
                else
                {
                    Calculate = (TOTAL__ + EXTRA_RUPEES_) + DEDUCTION_RUPEES_;
                }

                // Calculate = (TOTAL_ + EXTRA_RUPEES_) - DEDUCTION_RUPEES_;
                TOTAL.Text = Calculate.ToString();
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
