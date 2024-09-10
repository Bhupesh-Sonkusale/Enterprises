using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Transaction
{
    public partial class Vendor_Balance_Paid : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL();
        public string USER_ID; string VENDOR_ID = "";
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();

        public Vendor_Balance_Paid()
        {
            InitializeComponent();
        }

        #region -- Code For Button and Methods

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Vendor_Balance_Paid_Load(object sender, EventArgs e)
        {
            Show_All();
        }

        public void Show_All()
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PURCHASE", "IN");
                dal.AddParameter("@SUB_TYPE", "VENDOR_BALANCE_LIST", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dt = dal.GetTable("SP_PURCHASE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    grdData.Columns["VENDOR_ID"].Visible = false;
                    grdData.Columns[0].Width = 150;
                    grdData.Columns[2].Width = 450;
                    grdData.Columns[3].Width = 160;
                    grdData.Columns[4].Width = 160;
                    grdData.Columns[5].Width = 160;
                }
                else
                {
                    dt = null;
                    grdData.DataSource = dt;
                }
            }
            catch (Exception ex) { }
        }

        private void CASH_TextChanged(object sender, EventArgs e)
        {
            try
            {
            decimal CASH_, ONLINE_, CARD_, TOTAL_;
            if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
            if (string.IsNullOrEmpty(CARD.Text)) { CARD_ = 0; } else { CARD_ = Convert.ToDecimal(CARD.Text); }
            if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
            if (string.IsNullOrEmpty(TOTAL.Text)) { TOTAL_ = 0; } else { TOTAL_ = Convert.ToDecimal(TOTAL.Text); }

            if ((CASH_ + ONLINE_ + CARD_) > TOTAL_)
            {
                CASH.Text = ONLINE.Text = CARD.Text = BALANCE.Text = "";
            }
            else
            {
                BALANCE.Text = (TOTAL_ - (CASH_ + ONLINE_ + CARD_)).ToString();
            }
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Button and Methods

        #region -- Code For Value Enter into TextBox

        private void CASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For Value Enter into TextBox

        private void btnDetail_Click(object sender, EventArgs e)
        {
            BILL_ID.Text = NAME_MOBILE.Text = TOTAL.Text = CASH.Text = CARD.Text = ONLINE.Text = BALANCE.Text = "";
            panelDetail.Visible = false;
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                BILL_ID.Text = grdData.CurrentRow.Cells[0].Value.ToString();
                VENDOR_ID = grdData.CurrentRow.Cells[1].Value.ToString();
                NAME_MOBILE.Text = grdData.CurrentRow.Cells[2].Value.ToString();
                TOTAL.Text = BALANCE.Text = grdData.CurrentRow.Cells[5].Value.ToString();
                panelDetail.Visible = true;
            }
            catch (Exception ex) { }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal CASH_, ONLINE_, BALANCE_, CARD_;
                if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                if (string.IsNullOrEmpty(CARD.Text)) { CARD_ = 0; } else { CARD_ = Convert.ToDecimal(CARD.Text); }
                if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
                if (string.IsNullOrEmpty(BALANCE.Text)) { BALANCE_ = 0; } else { BALANCE_ = Convert.ToDecimal(BALANCE.Text); }

                if ((CASH_ + ONLINE_ + CARD_) <= 0)
                {
                    MessageBox.Show("Enter Cash / Online / Card amount.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CASH.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "PURCHASE", "IN");
                    dal.AddParameter("@SUB_TYPE", "BALANCE_PAID", "IN");
                    dal.AddParameter("@PAGE_NAME", "PURCHASE", "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID.Text, "IN");
                    dal.AddParameter("@NAME", NAME_MOBILE.Text, "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                    dal.AddParameter("@CASH", CASH_.ToString(), "IN");
                    dal.AddParameter("@ONLINE", ONLINE_.ToString(), "IN");
                    dal.AddParameter("@BALANCE", BALANCE_.ToString(), "IN");
                    dal.AddParameter("@VENDOR_ID", VENDOR_ID.ToString(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_PURCHASE", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Show_All();
                        btnDetail_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Show_All();
            foreach (Control ctrl in panelDetail.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            panelDetail.Visible = false;
        }

        private void SEARCH_BY_NAME_MOBILE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PURCHASE", "IN");
                dal.AddParameter("@SUB_TYPE", "VENDOR_BALANCE_FILTER", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@PARTY_NAME", SEARCH_BY_NAME_MOBILE.Text.Trim(), "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dt = dal.GetTable("SP_PURCHASE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    grdData.Columns["VENDOR_ID"].Visible = false;
                    grdData.Columns[0].Width = 150;
                    grdData.Columns[2].Width = 450;
                    grdData.Columns[3].Width = 160;
                    grdData.Columns[4].Width = 160;
                    grdData.Columns[5].Width = 160;
                }
                else
                {
                    dt = null;
                    grdData.DataSource = dt;
                }

                if (SEARCH_BY_NAME_MOBILE.Text.Trim() == "")
                {
                    Show_All();
                }
            }
            catch (Exception ex) { }
        }
    }
}
