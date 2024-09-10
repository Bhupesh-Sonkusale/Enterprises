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
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace Enterprises.Transaction
{
    public partial class SaleReturn : Form
    {
        DataTable dt; public string BATCH_NO, WITH_BATCH;
        int SALE_QUANTITY = 0;

        string Message = ""; public string GST_IN;
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID;
        DataTable table = new DataTable();
        Shop_Detail _variables = new Shop_Detail();
        DataTable tableProduct = new DataTable();
        Validation _validation = new Validation();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        ConvertNumberToWords _convertnumbertowords = new ConvertNumberToWords();

        public SaleReturn()
        {
            InitializeComponent();
        }

        #region -- Code For Buttons

        private void BTN_SERACH_Click(object sender, EventArgs e)
        {
            try
            {
                if (SEARCH_ID.Text == "")
                {
                    MessageBox.Show("Enter Sale Bill ID", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SEARCH_ID.Focus();
                }
                else
                {

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE_FOR_EDIT", "IN");
                    dal.AddParameter("@SUB_TYPE", "SEARCH_FOR_EDIT", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@BILL_ID", SEARCH_ID.Text.Trim().ToUpper(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", "true", "IN");
                    DataSet ds = dal.GetDataSet("SP_SALE", ref Message);

                    DataTable Table1 = ds.Tables[0];

                    if (Table1.Rows.Count > 0)
                    {
                        var Result = Table1.Rows[0][0].ToString();
                        string[] Result_ = Result.Split('~');
                        if (Result_[0].ToString() == "False")
                        {
                            MessageBox.Show(Result_[1].ToString(), _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            panel1.Enabled = false;
                            dt = null;
                            grdSaleData.DataSource = grdSaleReturnData.DataSource = dt;
                            SEARCH_ID.Focus();
                        }
                        else
                        {
                            DataTable Table2 = ds.Tables[1];
                            MessageBox.Show("Search Successfully.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel1.Enabled = true;
                            lbl_billId.Text = SEARCH_ID.Text.ToString();
                            PARTY_NAME.Text = "Name : " + Table1.Rows[0]["PARTY_1_NAME"].ToString() + " , Mobile : " + Table1.Rows[0]["PARTY_1_MOBILE"].ToString();
                            lblTotalAmount.Text = Table1.Rows[0]["GROSS"].ToString();
                            CUSTOMER_ID.Text = Table1.Rows[0]["PARTY_1_ID"].ToString();

                            grdSaleData.DataSource = Table2;
                            grdSaleData.Columns[0].Visible = grdSaleData.Columns[1].Visible = false;
                            grdSaleData.Columns[5].Visible = grdSaleData.Columns[8].Visible = false;
                            grdSaleData.Columns[7].Visible = false;
                            grdSaleData.Columns[2].Width = 400;
                            grdSaleData.Columns[3].Width = 100;
                            grdSaleData.Columns[4].Width = 100;
                            grdSaleData.Columns[6].Width = 100;
                        }
                    }
                    else
                    {
                        dt = null;
                        grdSaleData.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (PARTICULAR.Text == "")
                {
                    MessageBox.Show("Enter Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTICULAR.Focus();
                }
                else if (QUANTITY.Text == "")
                {
                    MessageBox.Show("Enter Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (Convert.ToDecimal(QUANTITY.Text) <= 0)
                {
                    MessageBox.Show("Enter Valid Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (Convert.ToDecimal(QUANTITY.Text) > SALE_QUANTITY)
                {
                    MessageBox.Show("Enter Valid Quantity, Sale Quantity is : " + SALE_QUANTITY.ToString(), _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else
                {
                    string STOCK_ = "0";
                    int QUANTITY_;
                    if (string.IsNullOrEmpty(QUANTITY.Text)) { QUANTITY_ = 0; } else { QUANTITY_ = Convert.ToInt16(QUANTITY.Text); }

                    if (STOCK.Checked == true)
                    {
                        STOCK_ = "1";
                    }
                    else
                    {
                        STOCK_ = "0";
                    }

                    tableProduct.Rows.Add(ID.Text, BARCODE.Text, PARTICULAR.Text, QUANTITY_, "0", "0", "0", "0", BATCH_NO, STOCK_);
                    grdSaleReturnData.DataSource = tableProduct;

                    BARCODE.Text = ID.Text = PARTICULAR.Text = QUANTITY.Text = "";
                    BARCODE.Focus();
                    grdSaleReturnData.Columns["ID"].Visible = grdSaleReturnData.Columns["BARCODE"].Visible = false;
                    grdSaleReturnData.Columns[4].Visible = grdSaleReturnData.Columns[5].Visible = false;
                    grdSaleReturnData.Columns[6].Visible = grdSaleReturnData.Columns[7].Visible = grdSaleReturnData.Columns[8].Visible = grdSaleReturnData.Columns[9].Visible = false;

                    grdSaleReturnData.Columns[2].Width = 400;
                    grdSaleReturnData.Columns[3].Width = 130;
                }
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ID.Text = BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = "";
            SALE_QUANTITY = 0;
        }

        #endregion -- Code For Buttons

        #region -- Code For Methods and Grid Data

        public void Add_Particular()
        {
            tableProduct.Columns.Add("ID", typeof(string));
            tableProduct.Columns.Add("BARCODE", typeof(string));
            tableProduct.Columns.Add("PARTICULAR", typeof(string));
            tableProduct.Columns.Add("QUANTITY", typeof(string));
            tableProduct.Columns.Add("FREE", typeof(string));
            tableProduct.Columns.Add("MRP", typeof(string));
            tableProduct.Columns.Add("RATE", typeof(string));
            tableProduct.Columns.Add("TOTAL", typeof(string));
            tableProduct.Columns.Add("BATCH_NO", typeof(string));
            tableProduct.Columns.Add("IS_STOCK", typeof(string));
        }

        private void grdSaleData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int QUANTITY_ = Convert.ToInt16(grdSaleData.CurrentRow.Cells[3].Value.ToString());
                int FREE_QUANTITY_ = Convert.ToInt16(grdSaleData.CurrentRow.Cells[4].Value.ToString());
                ID.Text = grdSaleData.CurrentRow.Cells[0].Value.ToString();
                BARCODE.Text = grdSaleData.CurrentRow.Cells[1].Value.ToString();
                PARTICULAR.Text = grdSaleData.CurrentRow.Cells[2].Value.ToString();
                QUANTITY.Text = (QUANTITY_ + FREE_QUANTITY_).ToString();
                SALE_QUANTITY = Convert.ToInt16(QUANTITY.Text);
                BATCH_NO = grdSaleData.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void SaleReturn_Load(object sender, EventArgs e)
        {
            Add_Particular();
        }

        #endregion -- Code For Methods and Grid Data

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSaleReturnData.Rows.Count <= 0)
                {
                    MessageBox.Show("Enter Sale Bill Detail.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SEARCH_ID.Focus();
                }
                else if (grdSaleReturnData.Rows.Count == 0)
                {
                    MessageBox.Show("Enter Return Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SEARCH_ID.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE_RETURN", "IN");
                    dal.AddParameter("@SUB_TYPE", "MAX_ID", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    string RETURN_ID = dal.ExecuteScaler("SP_SALE_RETURN", ref Message).ToString();

                    for (int i = 0; i < grdSaleReturnData.Rows.Count; i++)
                    {
                        dal.ClearParameters();
                        dal.AddParameter("@TYPE", "SALE_RETURN", "IN");
                        dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                        dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                        dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                        dal.AddParameter("@RETURN_ID", RETURN_ID, "IN");
                        dal.AddParameter("@BILL_ID", lbl_billId.Text.Trim(), "IN");
                        dal.AddParameter("@CUSTOMER_ID", CUSTOMER_ID.Text, "IN");
                        dal.AddParameter("@PRODUCT_ID", grdSaleReturnData.Rows[i].Cells[0].Value.ToString(), "IN");
                        dal.AddParameter("@BARCODE", grdSaleReturnData.Rows[i].Cells[1].Value.ToString(), "IN");
                        dal.AddParameter("@QUANTITY", grdSaleReturnData.Rows[i].Cells[3].Value.ToString(), "IN");
                        dal.AddParameter("@BATCH_ID", grdSaleReturnData.Rows[i].Cells[8].Value.ToString(), "IN");
                        dal.AddParameter("@STOCK_GO", grdSaleReturnData.Rows[i].Cells[9].Value.ToString(), "IN");
                        if (i == 0)
                        {
                            dal.AddParameter("@CASH", CASH.Text.Trim(), "IN");
                            dal.AddParameter("@ONLINE", ONLINE.Text.Trim(), "IN");
                        }
                        else
                        {
                            dal.AddParameter("@CASH", "0", "IN");
                            dal.AddParameter("@ONLINE", "0", "IN");
                        }
                        dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                        _result = dal.ExecuteNonQuery("SP_SALE_RETURN", ref Message);
                    }

                    if (_result > 0)
                    {
                        MessageBox.Show("Sale Return Successfully with Return ID : " + RETURN_ID,_variables.SHOP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void grdSaleReturnData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rows = Convert.ToInt16(grdSaleReturnData.SelectedCells[0].RowIndex);
                tableProduct.Rows.RemoveAt(rows);
            }
            catch (Exception ex) { }
        }

    }
}
