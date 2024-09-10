using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.Common;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace Enterprises.Admin
{
    public partial class Dashboard : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL(); public string USER_NAME_, PASSWORD_, DB_BACKUP_;
        Shop_Detail _variables = new Shop_Detail();
        string USER_ID, BRANCH_ID; public string MEMBER_TYPE_, NO_OF_PRINT_;
        public string USER_TYPE, BILL_LABLE, GST_IN, EMAIL_PASSWORD, EMAIL, WITH_BATCH;
        public bool FINANCIAL_STATUS;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelBooking.Visible = false;
            USER_ID = lblUserID.Text;
            BRANCH_ID = _variables.BRANCH_ID;
            lblVERSION.Text = _variables.VERSION;
            BackgroundImage = new Bitmap(_variables.IMAGE_PATH + "Dashboard.png");

            if (MEMBER_TYPE_.ToString() == "E")
            {
                ToolSettingBackUpData.Visible = ToolSettingShopDetail.Visible = ToolSettingAuthontication.Visible = ToolRegistrationVendor_.Visible = false;
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thank For using application", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dal.ClearParameters();
            dal.AddParameter("@TYPE", "REGISTRATION", "IN");
            dal.AddParameter("@SUB_TYPE", "LOGOUT", "IN");
            dal.AddParameter("@USER_NAME", USER_NAME_, "IN");
            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
            _result = dal.ExecuteNonQuery("SP_REGISTRATION", ref Message);
        }

        private void ToolMasterSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure want to sign out ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "LOGOUT", "IN");
                dal.AddParameter("@USER_NAME", USER_NAME_, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                _result = dal.ExecuteNonQuery("SP_REGISTRATION", ref Message);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string TodayDate = DateTime.Now.Day.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year;
            string TodayTime = DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0');
            DateTime _time = Convert.ToDateTime(DateTime.Now);
            _time = _time.AddSeconds(1);
            lblDate.Text = "Date : " + TodayDate + " [ " + TodayTime + " ]";
        }

        #region -- Code For Transaction

        private void ToolSale_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "SALE", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Sale obj = new Transaction.Sale();
                    obj.USER_ID = USER_ID;
                    obj.NO_OF_PRINT_ = NO_OF_PRINT_;
                    obj.BILL_LABLE = BILL_LABLE;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.GST_IN = GST_IN;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void billEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "BILL_EDIT", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.EditBill obj = new Transaction.EditBill();
                    obj.USER_ID = USER_ID;
                    obj.GST_IN = GST_IN;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "PURCHASE", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Purchase obj = new Transaction.Purchase();
                    obj.GST_IN = GST_IN;
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.WITH_BATCH = WITH_BATCH;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void purchaseEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "PURCHASE", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Purchase_Edit obj = new Transaction.Purchase_Edit();
                    obj.GST_IN = GST_IN;
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.WITH_BATCH = WITH_BATCH;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "SALE", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.SaleReturn obj = new Transaction.SaleReturn();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.GST_IN = GST_IN;
                    obj.WITH_BATCH = WITH_BATCH;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolTransactionBillCancel_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "BILL_CANCEL", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Bill_Cancel obj = new Transaction.Bill_Cancel();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "BALANCE_PAID", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Balance_Paid obj = new Transaction.Balance_Paid();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "BALANCE_PAID", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Vendor_Balance_Paid obj = new Transaction.Vendor_Balance_Paid();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolTransactionExpense_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "EXPENSE", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.Expense obj = new Transaction.Expense();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void counterToGodownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "COU_TO_GOD", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.GodownCounter obj = new Transaction.GodownCounter();
                    // obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Transaction

        #region -- Code For Registration

        private void ToolRegistrationCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "CUSTOMER_REG", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Login.Customer obj = new Login.Customer();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolRegistrationVendor__Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "CUSTOMER_REG", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Login.Vendor obj = new Login.Vendor();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolRegistrationEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "SUB_ADMIN", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Login.SubAdminRegistration obj = new Login.SubAdminRegistration();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }


        #endregion -- Code For Registration

        #region -- Code For Master

        private void ToolCategory_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "CATEGORY_MASTER", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Admin.frmCategory obj = new frmCategory();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolProductMaster_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Admin.ProductMaster obj = new ProductMaster();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }


        private void ToolMasterExpense_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "EXPENSE_MASTER", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Admin.Expense obj = new Expense();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void cancelReasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "EXPENSE_MASTER", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Admin.Reason obj = new Reason();
                    obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Master

        #region -- Code For Report

        private void ToolReportSale_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Sale obj = new Report.Sale();
                obj.GST_IN = GST_IN;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.WITH_BATCH = WITH_BATCH;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void ToolReportGST_Click(object sender, EventArgs e)
        {
            try
            {
                Report.gst_Report obj = new Report.gst_Report();
                obj.BILL_LABLE = BILL_LABLE;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void ToolReportCashOnline_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CashBankReport obj = new Report.CashBankReport();
                // obj.USER_ID = USER_ID;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void saleRetrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.SaleReturn obj = new Report.SaleReturn();
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void ToolReportPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Purchase obj = new Report.Purchase();
                // obj.USER_ID = USER_ID;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void purchaseConcelation_Click(object sender, EventArgs e)
        {
            try
            {
                Report.PurchaseConcelation obj = new Report.PurchaseConcelation();
                // obj.USER_ID = USER_ID;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void ToolReportProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Product obj = new Report.Product();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void availableStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Stock obj = new Report.Stock();
                // obj.USER_ID = USER_ID;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void mostSalingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.MostSalingItem obj = new Report.MostSalingItem();
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void minStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.MinStock obj = new Report.MinStock();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ToolReturnCustomerListWithParticular_Click(object sender, EventArgs e)
        {
            Report.CustomerWithParticular obj = new Report.CustomerWithParticular();
            obj.MdiParent = this;
            obj.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.CustomerReport obj = new Report.CustomerReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ToolReportExpense_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Expense obj = new Report.Expense();
                // obj.USER_ID = USER_ID;
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void dailyCreditDebitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.DailyCollection obj = new Report.DailyCollection();
            obj.MdiParent = this;
            obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
            obj.Show();
        }

        private void ToolReportAudit_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Audit obj = new Report.Audit();
                // obj.USER_ID = USER_ID;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void creditDebitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bill_Rdlcs.DebitCredit obj = new Bill_Rdlcs.DebitCredit();
                // obj.USER_ID = USER_ID;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ToolStockReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Stock obj = new Report.Stock();
                // obj.USER_ID = USER_ID;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void particularSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bill_Rdlcs.ParticularSale obj = new Bill_Rdlcs.ParticularSale();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void commisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Commision obj = new Report.Commision();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void customerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CustomerSale obj = new Report.CustomerSale();
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Report

        #region -- Code For Setting

        private void ToolSettingChangePassword_Click(object sender, EventArgs e)
        {
            Login.Change_Password obj = new Login.Change_Password();
            obj.txtUserName.Text = USER_NAME_.ToString();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ToolSettingBackUpData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "SQL Server database backup files|*.bak";
                sd.Title = "Create Database Backup";
                

                if (sd.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                    {
                        // string sqlStmt = string.Format("backup database [C:\\ProjectDB\\WowPads\\WowPadsDB.mdf] to disk='{0}'", sd.FileName);
                        string sqlStmt = string.Format("backup database [" + DB_BACKUP_ + "] to disk='{0}'", sd.FileName);
                        using (SqlCommand bu2 = new SqlCommand(sqlStmt, conn))
                        {
                            conn.Open();
                            bu2.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Wow, Backup Created Sucessfully", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops ! Backup Not Created", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolSettingShopDetail_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "SHOP_DETAIL", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Login.ShoppeeDetail obj = new Login.ShoppeeDetail();
                    // obj.USER_ID = USER_ID;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void ToolSettingAuthontication_Click(object sender, EventArgs e)
        {
            Login.Authority obj = new Login.Authority();
            obj.USER_ID = lblUserID.Text;
            obj.MdiParent = this;
            obj.Show();
        }

        private void transactionGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Graph obj = new Login.Graph();
            obj.MdiParent = this;
            obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
            obj.Show();
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.WriteQuery obj = new Login.WriteQuery();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCreditDebitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.CreditDebit obj = new Login.CreditDebit();
            obj.PASSWORD_ = PASSWORD_;
            obj.MdiParent = this;
            obj.Show();
        }

        #endregion -- Code For Setting

        #region -- Code For Today Booking

        private void ToolTodayBooking_Click(object sender, EventArgs e)
        {
            UpdateDashboardData();
            panelBooking.Visible = true;
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            panelBooking.Visible = false;
        }

        public void UpdateDashboardData()
        {
            try
            {
                DataTable dt_Booking = new DataTable();
                DataTable dt_collection = new DataTable();

                dal.ClearParameters();
                dal.AddParameter("@TYPE", "TODAYS_REPORT", "IN");
                dal.AddParameter("@SUB_TYPE", "DASHBOARD_DATA", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                DataSet DS = dal.GetDataSet("SP_SALE", ref Message);
                dt_Booking = DS.Tables[0];
                dt_collection = DS.Tables[1];
                lblBooking.Text = "Todays Sale Bill";
                if (dt_Booking.Rows.Count > 0)
                {
                    grdTodaysBooking.DataSource = dt_Booking;
                    grdTodaysBooking.Columns[0].Width = 110;
                    grdTodaysBooking.Columns[1].Width = 110;
                    grdTodaysBooking.Columns[2].Width = 350;
                    grdTodaysBooking.Columns[3].Width = 150;
                }

                if (dt_collection.Rows.Count > 0)
                {
                    dt_DaillyCollection.DataSource = dt_collection;
                    dt_DaillyCollection.Columns[0].Width = 300;
                    dt_DaillyCollection.Columns[1].Width = 300;
                    dt_DaillyCollection.Columns[2].Width = 300;
                }
            }
            catch (Exception ex) { }
        }

        private void grdTodaysBooking_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdTodaysBooking.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you Sure Want to Print Bill ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string BILL_ID = grdTodaysBooking.CurrentRow.Cells[0].Value.ToString();
                        dal.ClearParameters();
                        dal.AddParameter("@TYPE", "SALE", "IN");
                        dal.AddParameter("@SUB_TYPE", "PRINT_BILL", "IN");
                        dal.AddParameter("@BILL_ID", BILL_ID.ToString(), "IN");
                        dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS.ToString(), "IN");
                        dt = dal.GetTable("SP_SALE", ref Message);

                        LocalReport report_ = new LocalReport();
                        string fullPath = _variables.BILL_PATH + "JE_Invoice.rdlc";
                        report_.ReportPath = fullPath;
                        report_.DataSources.Add(new ReportDataSource("JE_ds", dt));
                        PrintToPrinter(report_);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        #endregion -- Code For Today Booking

        #region --  Code for Printing Bill

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
           @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>7in</PageWidth>
                <PageHeight>0in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }

        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                -3,
                0,
                800,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        #endregion --  Code for Printing Bill

        #region -- Code For Attendance Module

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "SHOP_DETAIL", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    HRModule.Attendance obj = new HRModule.Attendance();
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Attendance obj = new Report.Attendance();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HRModule.SalaryPay obj = new HRModule.SalaryPay();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Salary obj = new Report.Salary();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Attendance Module

        private void companyOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "AUTHORITY_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "CHECK_AUTHORITY", "IN");
                dal.AddParameter("@PAGE_NAME", "BILL_CANCEL", "IN");
                dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE_, "IN");
                dal.AddParameter("@BRANCH_ID", BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                dt = dal.GetTable("SP_AUTHORITY", ref Message);
                if (dt.Rows[0]["RESULT"].ToString() == "YES")
                {
                    Transaction.CompanyOrder obj = new Transaction.CompanyOrder();
                    obj.USER_ID = USER_ID;
                    obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                    obj.MdiParent = this;
                    obj.Show();
                }
                else
                {
                    Login.ErrorPage obj = new Login.ErrorPage();
                    obj.MdiParent = this;
                    obj.Show();
                }
            }
            catch (Exception ex) { }
        }

        private void companyOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Report.CompanyOrder obj = new Report.CompanyOrder();
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

        private void mostSalingItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Report.MostSalingItem obj = new Report.MostSalingItem();
                obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                obj.MdiParent = this;
                obj.Show();
            }
            catch (Exception ex) { }
        }

    }
}
