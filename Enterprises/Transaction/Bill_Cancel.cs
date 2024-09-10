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
    public partial class Bill_Cancel : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL();
        public string USER_ID; public bool FINANCIAL_STATUS;
        Shop_Detail _variables = new Shop_Detail();
        decimal C_RETURN_AMOUNT_ = 0, O_RETURN_AMOUNT_ = 0;

        public Bill_Cancel()
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

        private void Bill_Cancel_Load(object sender, EventArgs e)
        {
            Bind_CancelReason();
            Show_All();
        }

        public void Show_All()
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SALE", "IN");
                dal.AddParameter("@SUB_TYPE", "CANCEL_BILL_LIST", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dt = dal.GetTable("SP_SALE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    DETAIL.Text = "Search Sale bill with last " + dt.Rows[0]["CANCEL_BILL_IN_DAYS"].ToString() + " days only";
                    grdData.Columns["CUSTOMER_ID"].Visible = grdData.Columns["CANCEL_BILL_IN_DAYS"].Visible = false;
                    grdData.Columns[0].Width = 100;
                    grdData.Columns[2].Width = 500;
                    grdData.Columns[3].Width = 150;
                    grdData.Columns[4].Width = 150;
                    grdData.Columns[5].Width = 150;
                }
                else
                {
                    DETAIL.Text = "";
                    dt = null;
                    grdData.DataSource = dt;
                }
            }
            catch (Exception ex) { }
        }

        public void Bind_CancelReason()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@PAGE_NAME", "REASO", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                CANCEL_REASON.DisplayMember = "REASON";
                CANCEL_REASON.ValueMember = "ID";
                CANCEL_REASON.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        #region -- Code For Buttons

        private void btnDetail_Click(object sender, EventArgs e)
        {
            BILL_ID.Text = NAME_MOBILE.Text = "";
            CANCEL_REASON.SelectedIndex = 0;
            panelDetail.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (BILL_ID.Text == "")
                {
                    MessageBox.Show("Select Bill Detail First", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CANCEL_REASON.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Cancel Reason", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CANCEL_REASON.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(C_RETURN_AMOUNT.Text)) { C_RETURN_AMOUNT_ = 0; } else { C_RETURN_AMOUNT_ = Convert.ToDecimal(C_RETURN_AMOUNT.Text); }
                    if (string.IsNullOrEmpty(O_RETURN_AMOUNT.Text)) { O_RETURN_AMOUNT_ = 0; } else { O_RETURN_AMOUNT_ = Convert.ToDecimal(O_RETURN_AMOUNT.Text); }

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE", "IN");
                    dal.AddParameter("@SUB_TYPE", "CANCEL_BILL", "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID.Text.Trim(), "IN");
                    dal.AddParameter("@PARTY_NAME", NAME_MOBILE.Text.Trim(), "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@REASON", CANCEL_REASON.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@CASH", C_RETURN_AMOUNT_.ToString(), "IN");
                    dal.AddParameter("@ONLINE", O_RETURN_AMOUNT_.ToString(), "IN");
                    dal.AddParameter("@USER_ID", USER_ID, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");

                    if (MessageBox.Show("Are you sure want to cancel bill ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _result = dal.ExecuteNonQuery("SP_SALE", ref Message);
                        if (_result > 0)
                        {
                            MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BILL_ID.Text = C_RETURN_AMOUNT.Text = O_RETURN_AMOUNT.Text = "";
                            CANCEL_REASON.SelectedIndex = 0;
                            panelDetail.Visible = false;
                            Show_All();
                        }
                        else
                        {
                            MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                BILL_ID.Text = grdData.CurrentRow.Cells[0].Value.ToString().Trim();
                NAME_MOBILE.Text = grdData.CurrentRow.Cells[2].Value.ToString().Trim();
                panelDetail.Visible = true;
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion -- Code For Buttons

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
            CANCEL_REASON.SelectedIndex = 0;
        }
    }
}
