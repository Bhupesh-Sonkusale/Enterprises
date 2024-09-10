using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Login
{
    public partial class CreditDebit : Form
    {
        string Message = ""; public string PASSWORD_;
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();

        public CreditDebit()
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

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                decimal AMOUNT_ = 0;
                if (string.IsNullOrEmpty(AMOUNT.Text)) { AMOUNT_ = 0; } else { AMOUNT_ = Convert.ToDecimal(AMOUNT.Text); }

                if (CMBtype.SelectedIndex <= 0)
                {
                    MessageBox.Show("Select Account Type.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CMBtype.Focus();
                }
                else if (AMOUNT_ <= 0)
                {
                    MessageBox.Show("Enter Amount.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AMOUNT.Focus();
                }
                else if (PASSWORD.Text == "")
                {
                    MessageBox.Show("Enter Password.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PASSWORD.Focus();
                }
                else if (PASSWORD.Text != PASSWORD_.ToString())
                {
                    MessageBox.Show("Invalid Password.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PASSWORD.Focus();
                }
                else
                {
                    string CMBtype_ = "";
                    if (CMBtype.SelectedIndex == 1)
                    {
                        CMBtype_ = "DEBIT";
                    }
                    else if (CMBtype.SelectedIndex == 2)
                    {
                        CMBtype_ = "CREDIT";
                    }

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "TODAYS_REPORT", "IN");
                    dal.AddParameter("@SUB_TYPE", "DEBIT_CREDIT", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@CREDIT", AMOUNT_.ToString(), "IN");
                    dal.AddParameter("@ACCOUNT_TYPE", CMBtype_.ToString(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_SALE", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CMBtype.SelectedIndex = 0;
                        AMOUNT.Text = PASSWORD.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        #region -- Code For Value Enter into TextBox

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For Value Enter into TextBox

        
    }
}
