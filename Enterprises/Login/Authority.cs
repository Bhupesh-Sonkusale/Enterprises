using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Login
{
    public partial class Authority : Form
    {
        #region -- Code For Variable Declaration
        DataTable dt;
        string Message = ""; public string USER_ID, VIEW_;
        int _result = 0;
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        #endregion -- Code For Variable Declaration

        string[] PAGE_NAME = { "EXPENSE_MASTER", "CATEGORY_MASTER", "SUB_CATEGORY_MASTER", "PRODUCT_MASTER", "BACK_UP_DATA", "SHOP_DETAIL", "SUB_ADMIN", "CUSTOMER_REG", "SALE", "PURCHASE", "STOCK_UPDATE", "BILL_CANCEL", "BALANCE_PAID", "EXPENSE", "LOAN_MASTER", "REPORT_PRODUCT", "REPORT_PURCHASE", "REPORT_SALE", "REPORT_SALE_GST", "REPORT_STOCK", "REPORT_MOST_SELLING", "REPORT_CASH_CARD_ONLINE", "REPORT_AUDIT", "REPORT_EXPENSE", "REPORT_DAILY_REPORT", "REPORT_LOAN", "REPORT_PROFIT_LOSS", "REPORT_CUSTO_HISTORY", "SALE_RETURN", "SALE_RETURN", "BILL_EDIT", "COU_TO_GOD", "QUOTATION", "COMPANY_ORDER" };

        public Authority()
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

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (EMPLOYEE_NAME.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Employee Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EMPLOYEE_NAME.Focus();
                }
                else
                {
                    for (int i = 0; i < PAGE_NAME.Length; i++)
                    {
                        VIEW_ = CheckOrNot(i.ToString());
                        dal.ClearParameters();
                        dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                        dal.AddParameter("@SUB_TYPE", "INSERT_UPDATE", "IN");
                        dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                        dal.AddParameter("@VIEW_", VIEW_, "IN");
                        dal.AddParameter("@PAGE_NAME", PAGE_NAME[i].ToString(), "IN");
                        dal.AddParameter("@EMPLOYEE_NAME", EMPLOYEE_NAME.Text.Trim(), "IN");
                        _result = dal.ExecuteNonQuery("SP_AUTHORITY", ref Message);
                    }
                    if (_result > 0)
                    {
                        MessageBox.Show("Authontication set successfully.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong, Try again!.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        public string CheckOrNot(string id)
        {
            try
            {
                if (id == "0") { if (EXPENSE_MASTER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "1") { if (CATEGORY_MASTER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "2") { if (SUB_CATEGORY_MASTER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "3") { if (PRODUCT_MASTER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "4") { if (BACK_UP_DATA.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "5") { if (SHOP_DETAIL.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "6") { if (SUB_ADMIN.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "7") { if (CUSTOMER_REG.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "8") { if (SALE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "9") { if (PURCHASE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "10") { if (STOCK_UPDATE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "11") { if (BILL_CANCEL.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "12") { if (BALANCE_PAID.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "13") { if (EXPENSE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "14") { if (LOAN_MASTER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "15") { if (REPORT_PRODUCT.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "16") { if (REPORT_PURCHASE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "17") { if (REPORT_SALE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "18") { if (REPORT_SALE_GST.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "19") { if (REPORT_STOCK.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "20") { if (REPORT_MOST_SELLING.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "21") { if (REPORT_CASH_CARD_ONLINE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "22") { if (REPORT_AUDIT.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "23") { if (REPORT_EXPENSE.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "24") { if (REPORT_DAILY_REPORT.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "25") { if (REPORT_LOAN.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "26") { if (REPORT_PROFIT_LOSS.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "27") { if (REPORT_CUSTO_HISTORY.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "28") { if (SALE_RETURN.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "29") { if (REPORT_SALE_RETURN.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "30") { if (BILL_EDIT.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "31") { if (COU_TO_GOD.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "32") { if (QUOTATION.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
                if (id == "33") { if (COMPANY_ORDER.Checked == true) { VIEW_ = "True"; } else { VIEW_ = "False"; } }
            }
            catch (Exception ex) { }
            return VIEW_;
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            try
            {
                if (EMPLOYEE_NAME.Text == " Select Customer")
                {
                    MessageBox.Show("Select Customer", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EMPLOYEE_NAME.Focus();

                    foreach (var c in this.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                    dal.AddParameter("@SUB_TYPE", "LIST_BY_NAME", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@EMPLOYEE_NAME", EMPLOYEE_NAME.Text.Trim(), "IN");
                    dt = dal.GetTable("SP_AUTHORITY", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        #region -- Code For Master's
                        string PAGE_NAME = dt.Rows[0][0].ToString();
                        string VIEW_ = dt.Rows[0][1].ToString();
                        if (PAGE_NAME == "EXPENSE_MASTER")
                        {
                            if (VIEW_ == "True") { EXPENSE_MASTER.Checked = true; } else { EXPENSE_MASTER.Checked = false; }
                        }

                        string PAGE_NAME_1 = dt.Rows[1][0].ToString();
                        string VIEW_1 = dt.Rows[1][1].ToString();
                        if (PAGE_NAME_1 == "CATEGORY_MASTER")
                        {
                            if (VIEW_1 == "True") { CATEGORY_MASTER.Checked = true; } else { CATEGORY_MASTER.Checked = false; }
                        }

                        string PAGE_NAME_2 = dt.Rows[2][0].ToString();
                        string VIEW_2 = dt.Rows[2][1].ToString();
                        if (PAGE_NAME_2 == "SUB_CATEGORY_MASTER")
                        {
                            if (VIEW_2 == "True") { SUB_CATEGORY_MASTER.Checked = true; } else { SUB_CATEGORY_MASTER.Checked = false; }
                        }

                        string PAGE_NAME_3 = dt.Rows[3][0].ToString();
                        string VIEW_3 = dt.Rows[3][1].ToString();
                        if (PAGE_NAME_3 == "PRODUCT_MASTER")
                        {
                            if (VIEW_3 == "True") { PRODUCT_MASTER.Checked = true; } else { PRODUCT_MASTER.Checked = false; }
                        }
                        #endregion -- Code For Master's

                        #region -- Code For Setting's
                        string BACK_UP_DATA_ = dt.Rows[4][0].ToString();
                        string BACK_UP_DATA_VIEW_ = dt.Rows[4][1].ToString();
                        if (BACK_UP_DATA_ == "BACK_UP_DATA")
                        {
                            if (BACK_UP_DATA_VIEW_ == "True") { BACK_UP_DATA.Checked = true; } else { BACK_UP_DATA.Checked = false; }
                        }

                        string SHOP_DETAIL_ = dt.Rows[5][0].ToString();
                        string SHOP_DETAIL_VIEW_ = dt.Rows[5][1].ToString();
                        if (SHOP_DETAIL_ == "SHOP_DETAIL")
                        {
                            if (SHOP_DETAIL_VIEW_ == "True") { SHOP_DETAIL.Checked = true; } else { SHOP_DETAIL.Checked = false; }
                        }

                        string SUB_ADMIN_ = dt.Rows[6][0].ToString();
                        string SUB_ADMIN_VIEW_ = dt.Rows[6][1].ToString();
                        if (SUB_ADMIN_ == "SUB_ADMIN")
                        {
                            if (SUB_ADMIN_VIEW_ == "True") { SUB_ADMIN.Checked = true; } else { SUB_ADMIN.Checked = false; }
                        }

                        string CUSTOMER_REG_ = dt.Rows[7][0].ToString();
                        string CUSTOMER_REG_VIEW_ = dt.Rows[7][1].ToString();
                        if (CUSTOMER_REG_ == "CUSTOMER_REG")
                        {
                            if (CUSTOMER_REG_VIEW_ == "True") { CUSTOMER_REG.Checked = true; } else { CUSTOMER_REG.Checked = false; }
                        }
                        #endregion -- Code For Master's

                        #region -- Code For Transaction's
                        string SALE_ = dt.Rows[8][0].ToString();
                        string SALE_VIEW_ = dt.Rows[8][1].ToString();
                        if (SALE_ == "SALE")
                        {
                            if (SALE_VIEW_ == "True") { SALE.Checked = true; } else { SALE.Checked = false; }
                        }

                        string PURCHASE_ = dt.Rows[9][0].ToString();
                        string PURCHASE_VIEW_ = dt.Rows[9][1].ToString();
                        if (PURCHASE_ == "PURCHASE")
                        {
                            if (PURCHASE_VIEW_ == "True") { PURCHASE.Checked = true; } else { PURCHASE.Checked = false; }
                        }

                        string STOCK_UPDATE_ = dt.Rows[10][0].ToString();
                        string STOCK_UPDATE_VIEW_ = dt.Rows[10][1].ToString();
                        if (STOCK_UPDATE_ == "STOCK_UPDATE")
                        {
                            if (STOCK_UPDATE_VIEW_ == "True") { STOCK_UPDATE.Checked = true; } else { STOCK_UPDATE.Checked = false; }
                        }

                        string BILL_CANCEL_ = dt.Rows[11][0].ToString();
                        string BILL_CANCEL_VIEW_ = dt.Rows[11][1].ToString();
                        if (BILL_CANCEL_ == "BILL_CANCEL")
                        {
                            if (BILL_CANCEL_VIEW_ == "True") { BILL_CANCEL.Checked = true; } else { BILL_CANCEL.Checked = false; }
                        }

                        string BALANCE_PAID_ = dt.Rows[12][0].ToString();
                        string BALANCE_PAID_VIEW_ = dt.Rows[12][1].ToString();
                        if (BALANCE_PAID_ == "BALANCE_PAID")
                        {
                            if (BALANCE_PAID_VIEW_ == "True") { BALANCE_PAID.Checked = true; } else { BALANCE_PAID.Checked = false; }
                        }

                        string EXPENSE_ = dt.Rows[13][0].ToString();
                        string EXPENSE_VIEW_ = dt.Rows[13][1].ToString();
                        if (EXPENSE_ == "EXPENSE")
                        {
                            if (EXPENSE_VIEW_ == "True") { EXPENSE.Checked = true; } else { EXPENSE.Checked = false; }
                        }

                        string LOAN_MASTER_ = dt.Rows[14][0].ToString();
                        string LOAN_MASTER_VIEW_ = dt.Rows[14][1].ToString();
                        if (LOAN_MASTER_ == "LOAN_MASTER")
                        {
                            if (LOAN_MASTER_VIEW_ == "True") { LOAN_MASTER.Checked = true; } else { LOAN_MASTER.Checked = false; }
                        }
                        #endregion -- Code For Master's

                        #region -- Code For Report's
                        string REPORT_PRODUCT_ = dt.Rows[15][0].ToString();
                        string REPORT_PRODUCT_VIEW_ = dt.Rows[15][1].ToString();
                        if (REPORT_PRODUCT_ == "REPORT_PRODUCT")
                        {
                            if (REPORT_PRODUCT_VIEW_ == "True") { REPORT_PRODUCT.Checked = true; } else { REPORT_PRODUCT.Checked = false; }
                        }

                        string REPORT_PURCHASE_ = dt.Rows[16][0].ToString();
                        string REPORT_PURCHASE_VIEW_ = dt.Rows[16][1].ToString();
                        if (REPORT_PURCHASE_ == "REPORT_PURCHASE")
                        {
                            if (REPORT_PURCHASE_VIEW_ == "True") { REPORT_PURCHASE.Checked = true; } else { REPORT_PURCHASE.Checked = false; }
                        }

                        string REPORT_SALE_ = dt.Rows[17][0].ToString();
                        string REPORT_SALE_VIEW_ = dt.Rows[17][1].ToString();
                        if (REPORT_SALE_ == "REPORT_SALE")
                        {
                            if (REPORT_SALE_VIEW_ == "True") { REPORT_SALE.Checked = true; } else { REPORT_SALE.Checked = false; }
                        }

                        string REPORT_SALE_GST_ = dt.Rows[18][0].ToString();
                        string REPORT_SALE_GST_VIEW_ = dt.Rows[18][1].ToString();
                        if (REPORT_SALE_GST_ == "REPORT_SALE_GST")
                        {
                            if (REPORT_SALE_GST_VIEW_ == "True") { REPORT_SALE_GST.Checked = true; } else { REPORT_SALE_GST.Checked = false; }
                        }

                        string REPORT_STOCK_ = dt.Rows[19][0].ToString();
                        string REPORT_STOCK_VIEW_ = dt.Rows[19][1].ToString();
                        if (REPORT_STOCK_ == "REPORT_STOCK")
                        {
                            if (REPORT_STOCK_VIEW_ == "True") { REPORT_STOCK.Checked = true; } else { REPORT_STOCK.Checked = false; }
                        }

                        string REPORT_MOST_SELLING_ = dt.Rows[20][0].ToString();
                        string REPORT_MOST_SELLING_VIEW_ = dt.Rows[20][1].ToString();
                        if (REPORT_MOST_SELLING_ == "REPORT_MOST_SELLING")
                        {
                            if (REPORT_MOST_SELLING_VIEW_ == "True") { REPORT_MOST_SELLING.Checked = true; } else { REPORT_MOST_SELLING.Checked = false; }
                        }

                        string REPORT_CASH_CARD_ONLINE_ = dt.Rows[21][0].ToString();
                        string REPORT_CASH_CARD_ONLINE_VIEW_ = dt.Rows[21][1].ToString();
                        if (REPORT_CASH_CARD_ONLINE_ == "REPORT_CASH_CARD_ONLINE")
                        {
                            if (REPORT_CASH_CARD_ONLINE_VIEW_ == "True") { REPORT_CASH_CARD_ONLINE.Checked = true; } else { REPORT_CASH_CARD_ONLINE.Checked = false; }
                        }
                        string REPORT_AUDIT_ = dt.Rows[22][0].ToString();
                        string REPORT_AUDIT_VIEW_ = dt.Rows[22][1].ToString();
                        if (REPORT_AUDIT_ == "REPORT_AUDIT")
                        {
                            if (REPORT_AUDIT_VIEW_ == "True") { REPORT_AUDIT.Checked = true; } else { REPORT_AUDIT.Checked = false; }
                        }

                        string REPORT_EXPENSE_ = dt.Rows[23][0].ToString();
                        string REPORT_EXPENSE_VIEW_ = dt.Rows[23][1].ToString();
                        if (REPORT_EXPENSE_ == "REPORT_EXPENSE")
                        {
                            if (REPORT_EXPENSE_VIEW_ == "True") { REPORT_EXPENSE.Checked = true; } else { REPORT_EXPENSE.Checked = false; }
                        }


                        string REPORT_DAILY_REPORT_ = dt.Rows[24][0].ToString();
                        string REPORT_DAILY_REPORT_VIEW_ = dt.Rows[24][1].ToString();
                        if (REPORT_DAILY_REPORT_ == "REPORT_DAILY_REPORT")
                        {
                            if (REPORT_DAILY_REPORT_VIEW_ == "True") { REPORT_DAILY_REPORT.Checked = true; } else { REPORT_DAILY_REPORT.Checked = false; }
                        }
                        string REPORT_LOAN_ = dt.Rows[25][0].ToString();
                        string REPORT_LOAN_VIEW_ = dt.Rows[25][1].ToString();
                        if (REPORT_LOAN_ == "REPORT_LOAN")
                        {
                            if (REPORT_LOAN_VIEW_ == "True") { REPORT_LOAN.Checked = true; } else { REPORT_LOAN.Checked = false; }
                        }
                        string REPORT_PROFIT_LOSS_ = dt.Rows[26][0].ToString();
                        string REPORT_PROFIT_LOSS_VIEW_ = dt.Rows[26][1].ToString();
                        if (REPORT_PROFIT_LOSS_ == "REPORT_PROFIT_LOSS")
                        {
                            if (REPORT_PROFIT_LOSS_VIEW_ == "True") { REPORT_PROFIT_LOSS.Checked = true; } else { REPORT_PROFIT_LOSS.Checked = false; }
                        }
                        string REPORT_CUSTO_HISTORY_ = dt.Rows[27][0].ToString();
                        string REPORT_CUSTO_HISTORY_VIEW_ = dt.Rows[27][1].ToString();
                        if (REPORT_CUSTO_HISTORY_ == "REPORT_CUSTO_HISTORY")
                        {
                            if (REPORT_CUSTO_HISTORY_VIEW_ == "True") { REPORT_CUSTO_HISTORY.Checked = true; } else { REPORT_CUSTO_HISTORY.Checked = false; }
                        }

                        string SALE_RETURN_ = dt.Rows[28][0].ToString();
                        string SALE_RETURN_VIEW_ = dt.Rows[28][1].ToString();
                        if (SALE_RETURN_ == "SALE_RETURN")
                        {
                            if (SALE_RETURN_VIEW_ == "True") { SALE_RETURN.Checked = true; } else { SALE_RETURN.Checked = false; }
                        }

                        string BILL_EDIT_ = dt.Rows[29][0].ToString();
                        string BILL_EDIT_VIEW_ = dt.Rows[29][1].ToString();
                        if (BILL_EDIT_ == "BILL_EDIT")
                        {
                            if (BILL_EDIT_VIEW_ == "True") { BILL_EDIT.Checked = true; } else { BILL_EDIT.Checked = false; }
                        }

                        string COU_TO_GOD_ = dt.Rows[30][0].ToString();
                        string COU_TO_GOD_VIEW_ = dt.Rows[30][1].ToString();
                        if (COU_TO_GOD_ == "COU_TO_GOD")
                        {
                            if (COU_TO_GOD_VIEW_ == "True") { COU_TO_GOD.Checked = true; } else { COU_TO_GOD.Checked = false; }
                        }

                        string COMPANY_ORDER_ = dt.Rows[31][0].ToString();
                        string COMPANY_ORDER_VIEW_ = dt.Rows[31][1].ToString();
                        if (COMPANY_ORDER_ == "COMPANY_ORDER")
                        {
                            if (COMPANY_ORDER_VIEW_ == "True") { COMPANY_ORDER.Checked = true; } else { COMPANY_ORDER.Checked = false; }
                        }

                        string QUOTATION_ = dt.Rows[32][0].ToString();
                        string QUOTATION_VIEW_ = dt.Rows[32][1].ToString();
                        if (QUOTATION_ == "QUOTATION")
                        {
                            if (QUOTATION_VIEW_ == "True") { QUOTATION.Checked = true; } else { QUOTATION.Checked = false; }
                        }
                        #endregion -- Code For Master's
                    }
                    else
                    {
                        foreach (var c in this.Controls)
                        {
                            if (c is CheckBox)
                            {
                                ((CheckBox)c).Checked = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Authority_Load(object sender, EventArgs e)
        {
            Bind_Employee();
        }

        public void Bind_Employee()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "LIST_ALL_EMPLOYEE", "IN");
                dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                EMPLOYEE_NAME.DisplayMember = "NAME";
                EMPLOYEE_NAME.ValueMember = "NAME";
                EMPLOYEE_NAME.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SELECT_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (SELECT_ALL.Checked == true)
            {
                foreach (var c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = true;
                    }
                }
            }
            else
            {
                foreach (var c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
            }
        }
    }
}
