using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Transaction
{
    public partial class Expense : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        Validation _validation = new Validation();

        public Expense()
        {
            InitializeComponent();
        }

        #region -- Codes For Buttons

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            try
            {
            grpContent.Enabled = true;
            SAVE.Enabled = true;
            NEW.Enabled = false;
            CASH.Text = REMARK.Text = "";
            CMBEXPENSE.SelectedIndex = 0;
            CMBEXPENSE.Focus();
            }
            catch (Exception ex) { }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Expense("INSERT");
        }

        public void Insert_Update_Delete_Expense(string BUTTON_TYPE)
        {
            try
            {
            decimal CASH_ = 0, ONLINE_ = 0,TOTAL_ =0;
            if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
            if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
            TOTAL_ = CASH_ + ONLINE_;

            if (CMBEXPENSE.SelectedIndex == 0)
            {
                MessageBox.Show("Select Expense.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBEXPENSE.Focus();
            }
            else if (Convert.ToDecimal(TOTAL_) < 0)
            {
                MessageBox.Show("Enter Expense Amount.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CASH.Focus();
            }
            else if (REMARK.Text == "")
            {
                MessageBox.Show("Enter Expense Remark.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                REMARK.Focus();
            }
            else
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "EXPENSE", "IN");
                dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                dal.AddParameter("@EXPENSE", CMBEXPENSE.Text, "IN");
                dal.AddParameter("@CASH", CASH.Text.Trim(), "IN");
                dal.AddParameter("@ONLINE", ONLINE.Text.Trim(), "IN");
                dal.AddParameter("@REMARK", REMARK.Text.Trim(), "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                _result = dal.ExecuteNonQuery("SP_EXPENSE", ref Message);
                if (_result > 0)
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            CASH.Text = REMARK.Text = string.Empty;
            CMBEXPENSE.SelectedIndex = 0;
            NEW.PerformClick();
            CMBEXPENSE.Focus();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            NEW.Focus();
            Bind_Category();
        }

        public void Bind_Category()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@PAGE_NAME", "EXPEN", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                CMBEXPENSE.DisplayMember = "EXPENSE";
                CMBEXPENSE.ValueMember = "EXPENSE";
                CMBEXPENSE.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void CMBEXPENSE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBEXPENSE.SelectedIndex != 0)
            {
                REMARK.Text = CMBEXPENSE.Text;
            }
            else
            {
                REMARK.Text = "";
            }
        }

        #endregion

        #region -- Code For Value Enter into TextBox

        private void AMOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For Value Enter into TextBox

        private void CMBEXPENSE_Leave(object sender, EventArgs e)
        {
            CASH.BackColor = ONLINE.BackColor = REMARK.BackColor = Color.White;
            CASH.ForeColor = ONLINE.ForeColor = REMARK.ForeColor = Color.Black;
        }

        private void CASH_Enter(object sender, EventArgs e)
        {
            CASH.BackColor = Color.MistyRose;
        }

        private void ONLINE_Enter(object sender, EventArgs e)
        {
            ONLINE.BackColor = Color.MistyRose;
        }

        private void REMARK_Enter(object sender, EventArgs e)
        {
            REMARK.BackColor = Color.MistyRose;
        }

        private void SAVE_Enter(object sender, EventArgs e)
        {
            SAVE.BackColor = Color.MistyRose;
            SAVE.ForeColor = Color.Black;
        }

        private void SAVE_Leave(object sender, EventArgs e)
        {
            SAVE.BackColor = Color.Green;
            SAVE.ForeColor = Color.White;
        }

        private void NEW_Enter(object sender, EventArgs e)
        {
            NEW.BackColor = Color.MistyRose;
            NEW.ForeColor = Color.Black;
        }

        private void NEW_Leave(object sender, EventArgs e)
        {
            NEW.BackColor = Color.Blue;
            NEW.ForeColor = Color.White;
        }

    }
}
