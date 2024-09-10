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
    public partial class Sale : Form
    {
        DataTable dt; string CHKISEDITABLE = "0";
        string Message = ""; public string GST_IN;
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID, NO_OF_PRINT_;
        DataTable table = new DataTable();
        Shop_Detail _variables = new Shop_Detail();
        DataTable tableProduct = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        Validation _validation = new Validation();
        ConvertNumberToWords _convertnumbertowords = new ConvertNumberToWords();
        public string BILL_LABLE;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public Sale()
        {
            InitializeComponent();
        }

        #region -- Codes For Buttons

        private void Sale_Load(object sender, EventArgs e)
        {
            try
            {
                PARTICULAR_LIST("");
                Add_Particular();
                NameBind();
                Particular_Bind();
                Bind_AdminEmployee();
                ORDER_BY.SelectedIndex = 1;
            }
            catch (Exception ex) { }
        }

        public void Bind_AdminEmployee()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@MEMBER_TYPE", "EA", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                ORDER_BY.DisplayMember = "NAME";
                ORDER_BY.ValueMember = "ID";
                ORDER_BY.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        public void PARTICULAR_LIST(string PARTICULAR_)
        {
            try
            {
                dal.ClearParameters();

                if (PARTICULAR_ == "")
                {
                    dal.AddParameter("@SUB_TYPE", "PARTICULAR_LIST", "IN");
                }
                else
                {
                    dal.AddParameter("@SUB_TYPE", "PARTICULAR_LIST_BYNAME", "IN");
                }

                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@PRODUCT_NAME", PARTICULAR.Text, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                grdDataParticular.DataSource = dt;
                grdDataParticular.Columns["ID"].Visible = false;
                grdDataParticular.Columns["BARCODE"].Visible = false;
                grdDataParticular.Columns["MRP"].Visible = false;
                grdDataParticular.Columns["PARTICULAR"].Width = 260;
                grdDataParticular.Columns["QUANTITY"].Width = 100;

                grdDataParticular.Columns["PARTICULAR"].HeaderText = "Particular";
                grdDataParticular.Columns["QUANTITY"].HeaderText = "Quantity";
            }
            catch (Exception ex)
            {
            }
        }

        public void NameBind()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd_ = new SqlCommand("SELECT NAME FROM REGISTRATION WHERE MEMBER_TYPE = 'C' AND BRANCH_ID = @BRANCH_ID AND NAME LIKE '%" + PARTY_NAME.Text + "%'", con);
                cmd_.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                SqlDataReader dr_ = cmd_.ExecuteReader();
                AutoCompleteStringCollection scoll_ = new AutoCompleteStringCollection();

                while (dr_.Read())
                {
                    scoll_.Add(dr_.GetString(0));
                }
                PARTY_NAME.AutoCompleteCustomSource = scoll_;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void Particular_Bind()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd_ = new SqlCommand("SELECT PRODUCT_NAME FROM PRODUCT_MASTER WHERE BRANCH_ID = @BRANCH_ID AND PRODUCT_NAME LIKE '%" + PARTICULAR.Text + "%'", con);
                cmd_.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                SqlDataReader dr_ = cmd_.ExecuteReader();
                AutoCompleteStringCollection scoll_ = new AutoCompleteStringCollection();

                while (dr_.Read())
                {
                    scoll_.Add(dr_.GetString(0));
                }
                PARTICULAR.AutoCompleteCustomSource = scoll_;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void Add_Particular()
        {
            try
            {
                tableProduct.Columns.Add("ID", typeof(string));
                tableProduct.Columns.Add("BARCODE", typeof(string));
                tableProduct.Columns.Add("Particular", typeof(string));
                tableProduct.Columns.Add("Quantity", typeof(string));
                tableProduct.Columns.Add("Rate", typeof(string));
                tableProduct.Columns.Add("Disc", typeof(string));
                tableProduct.Columns.Add("Total", typeof(string));
            }
            catch (Exception ex) { }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F1)
            {
                panelPayment.Visible = true;
                PARTICULAR.Focus();
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F2)
            {
                panelPayment.Visible = true;
                QUANTITY.Focus();
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F3)
            {
                panelPayment.Visible = true;
                MRP.Focus();
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F4)
            {
                panelPayment.Visible = true;
                ITEM_DISCOUNT.Focus();
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F5)
            {
                panelPayment.Visible = true;
                btnAdd.Focus();
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F5)
            {
                btnSubmit.PerformClick();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                MessageBox.Show("Please Remove all item.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }

        private void QUANTITY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal QUANTITY_; decimal MRP_; decimal AVAILABLE_QTY, ITEM_DISCOUNT_ = 0, ITEM_DISCOUNT_AMOUNT = 0;
                if (string.IsNullOrEmpty(QTY.Text)) { AVAILABLE_QTY = 0; } else { AVAILABLE_QTY = Convert.ToDecimal(QTY.Text); }
                if (string.IsNullOrEmpty(QUANTITY.Text)) { QUANTITY_ = 1; } else { QUANTITY_ = Convert.ToDecimal(QUANTITY.Text); }
                if (string.IsNullOrEmpty(MRP.Text)) { MRP_ = 0; } else { MRP_ = Convert.ToDecimal(MRP.Text); }
                if (string.IsNullOrEmpty(ITEM_DISCOUNT.Text)) { ITEM_DISCOUNT_ = 0; } else { ITEM_DISCOUNT_ = Convert.ToDecimal(ITEM_DISCOUNT.Text); }

                if (AVAILABLE_QTY < Convert.ToDecimal(QUANTITY_))
                {
                    // MessageBox.Show("Available Quantity is : " + AVAILABLE_QTY,_variables.SHOP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    QUANTITY.Text = "1";
                    TOTAL.Text = MRP.Text.ToString();
                }
                else
                {
                    TOTAL.Text = Math.Round((Convert.ToDecimal(QUANTITY_) * Convert.ToDecimal(MRP_)), 2).ToString();
                }

                if (ITEM_DISCOUNT_ > 0)
                {
                    ITEM_DISCOUNT_AMOUNT = Math.Round((Convert.ToDecimal(QUANTITY_) * Convert.ToDecimal(MRP_) * Convert.ToDecimal(ITEM_DISCOUNT_) / 100), 2);

                    TOTAL.Text = Math.Round(Convert.ToDecimal(TOTAL.Text) - Convert.ToDecimal(ITEM_DISCOUNT_AMOUNT)).ToString();
                }
                else
                {
                    TOTAL.Text = Math.Round((Convert.ToDecimal(QUANTITY_) * Convert.ToDecimal(MRP_)), 2).ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void CASH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal CARD_, CASH_, ONLINE_, TOTAL_TO_PAY_;
                if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                if (string.IsNullOrEmpty(CARD.Text)) { CARD_ = 0; } else { CARD_ = Convert.ToDecimal(CARD.Text); }
                if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
                if (string.IsNullOrEmpty(TOTAL_TO_PAY.Text)) { TOTAL_TO_PAY_ = 0; } else { TOTAL_TO_PAY_ = Convert.ToDecimal(TOTAL_TO_PAY.Text); }
                decimal CALCULATE = TOTAL_TO_PAY_ - (CASH_ + CARD_ + ONLINE_);
                if (CALCULATE < 0)
                {
                    MessageBox.Show("Paid Amount cant be greator than Total.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BALANCE.Text = GROSS.Text;
                    CASH.Text = CARD.Text = ONLINE.Text = ""; CASH.Focus();
                }
                else
                {
                    BALANCE.Text = CALCULATE.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (BARCODE.Text == "")
                {
                    MessageBox.Show("Enter Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTICULAR.Focus();
                }
                else if (PARTICULAR.Text == "")
                {
                    MessageBox.Show("Enter Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTICULAR.Focus();
                }
                else if (QUANTITY.Text == "")
                {
                    MessageBox.Show("Enter Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (Convert.ToDecimal(QUANTITY.Text) < 0)
                {
                    MessageBox.Show("Enter Valid Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (Convert.ToDecimal(TOTAL.Text) < 0)
                {
                    MessageBox.Show("Enter Valid Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BARCODE.Focus();
                }
                else
                {
                    int FREE_QUANTITY_;
                    if (string.IsNullOrEmpty(FREE_QUANTITY.Text)) { FREE_QUANTITY_ = 0; } else { FREE_QUANTITY_ = Convert.ToInt16(FREE_QUANTITY.Text); }
                    int QUANTITY_;
                    if (string.IsNullOrEmpty(QUANTITY.Text)) { QUANTITY_ = 1; } else { QUANTITY_ = Convert.ToInt16(QUANTITY.Text); }
                    int ITEM_DISCOUNT_;
                    if (string.IsNullOrEmpty(ITEM_DISCOUNT.Text)) { ITEM_DISCOUNT_ = 0; } else { ITEM_DISCOUNT_ = Convert.ToInt16(ITEM_DISCOUNT.Text); }

                    tableProduct.Rows.Add(ID.Text, BARCODE.Text, PARTICULAR.Text, QUANTITY.Text, MRP.Text, ITEM_DISCOUNT_.ToString(), Math.Round(Convert.ToDecimal(TOTAL.Text), 0));
                    grdData.DataSource = tableProduct;

                    RemoveAddQuantity(ID.Text, BARCODE.Text, (QUANTITY_ + FREE_QUANTITY_).ToString(), "M");
                    grdData.Columns["ID"].Visible = grdData.Columns["BARCODE"].Visible = false;
                    BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = QTY.Text = FREE_QUANTITY.Text = ITEM_DISCOUNT.Text = "";
                    BARCODE.Focus(); QUANTITY.Text = "1";
                    Calculate_Amount(); MRP.Enabled = false;

                    //grdData.Columns[1].Width = 100;
                    grdData.Columns[2].Width = 400;
                    grdData.Columns[3].Width = 130;
                    grdData.Columns[4].Width = 130;
                    grdData.Columns[5].Width = 130;
                    grdData.Columns[6].Width = 130;
                    PARTICULAR.Focus();
                }
            }
            catch (Exception ex) { }
        }

        public void RemoveAddQuantity(string ID, string BARCODE, string QUANTITY, string OPERATION)
        {
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SALE_ITEM", "IN");
                dal.AddParameter("@SUB_TYPE", "ADD_MINUS_QTY", "IN");
                dal.AddParameter("@QUANTITY", QUANTITY, "IN");
                dal.AddParameter("@BARCODE", BARCODE, "IN");
                dal.AddParameter("@ID", ID, "IN");
                dal.AddParameter("@OPERATION", OPERATION, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                _result = dal.ExecuteNonQuery("SP_SALE", ref Message);
                PARTICULAR_LIST("");
            }
            catch (Exception ex) { }
        }

        public void Calculate_Amount()
        {
            try
            {
                decimal GROSS_ = 0;
                for (int i = 0; i < grdData.Rows.Count; i++)
                {
                    GROSS_ += Convert.ToDecimal(grdData.Rows[i].Cells[6].Value);
                }

                GROSS.Text = CASH.Text = TOTAL_TO_PAY.Text = GROSS_.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdData.Rows.Count < 1)
                {
                    MessageBox.Show("Enter Product First", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BARCODE.Focus();
                }
                else if (PARTY_NAME.Text == "")
                {
                    MessageBox.Show("Enter Customer Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PARTY_NAME.Focus();
                }
                else if (MOBILE.Text == "")
                {
                    MessageBox.Show("Enter Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MOBILE.Focus();
                }
                else if (ORDER_BY.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Booked By", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ORDER_BY.Focus();
                }
                else
                {
                    decimal TOTAL_TO_PAY_ = Math.Round(Convert.ToDecimal(TOTAL_TO_PAY.Text), 0);
                    string IN_WORDS = _convertnumbertowords.ConvertNumbertoWords(Convert.ToInt32(TOTAL_TO_PAY_));

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE", "IN");
                    dal.AddParameter("@SUB_TYPE", "MAX_ID", "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    string ID = dal.ExecuteScaler("SP_SALE", ref Message).ToString();

                    string BILL_ID = BILL_LABLE + ID;
                    decimal TOTAL_PAID_, CASH_, ONLINE_, CARD_;
                    if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                    if (string.IsNullOrEmpty(CARD.Text)) { CARD_ = 0; } else { CARD_ = Convert.ToDecimal(CARD.Text); }
                    if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
                    TOTAL_PAID_ = CASH_ + ONLINE_ + CARD_;

                    decimal TOTAL_QUANTITY = 0; string TOTAL_ITEM = "0";
                    for (int i = 0; i < grdData.Rows.Count; i++)
                    {
                        TOTAL_QUANTITY += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                    }
                    TOTAL_ITEM = grdData.Rows.Count.ToString();

                     dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE", "IN");
                    dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID, "IN");
                    dal.AddParameter("@ID", ID, "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID, "IN");
                    dal.AddParameter("@IN_WORDS", IN_WORDS.ToString(), "IN");
                    dal.AddParameter("@CUSTOMER_ID", CUSTOMER_ID.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@PARTY_NAME", PARTY_NAME.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@EMAIL", "", "IN");
                    dal.AddParameter("@ADDRESS", ADDRESS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@GST_NUMBER", "", "IN");
                    dal.AddParameter("@DL_NUMBER", "", "IN");
                    dal.AddParameter("@GROSS", GROSS.Text, "IN");
                    dal.AddParameter("@TOTAL_QUANTITY", TOTAL_QUANTITY.ToString(), "IN");
                    dal.AddParameter("@TOTAL_ITEM", TOTAL_ITEM.ToString(), "IN");
                    // dal.AddParameter("@DISCOUNT", DISCOUNT.Text, "IN");
                    dal.AddParameter("@DISCOUNT", DISCOUNT_TOTAL.Text, "IN");
                    dal.AddParameter("@CASH", CASH_.ToString(), "IN");
                    dal.AddParameter("@CARD", CARD_.ToString(), "IN");
                    dal.AddParameter("@ONLINE", ONLINE_.ToString(), "IN");
                    dal.AddParameter("@TOTAL_PAID", TOTAL_PAID_.ToString(), "IN");
                    dal.AddParameter("@BALANCE", BALANCE.Text, "IN");
                    dal.AddParameter("@MD_AMOUNT", MD_AMOUNT.Text, "IN");
                    dal.AddParameter("@ORDER_BY", ORDER_BY.SelectedValue.ToString(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_SALE", ref Message);
                    if (_result > 0)
                    {
                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            dal.ClearParameters();
                            dal.AddParameter("@TYPE", "SALE_ITEM", "IN");
                            dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                            dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                            dal.AddParameter("@BILL_ID", BILL_ID, "IN");
                            dal.AddParameter("@PRODUCT_ID", grdData.Rows[i].Cells[0].Value.ToString(), "IN");
                            dal.AddParameter("@BARCODE", grdData.Rows[i].Cells[1].Value.ToString(), "IN");
                            dal.AddParameter("@QUANTITY", grdData.Rows[i].Cells[3].Value.ToString(), "IN");
                            dal.AddParameter("@MRP", grdData.Rows[i].Cells[4].Value.ToString(), "IN");
                            dal.AddParameter("@ITEM_DISC", grdData.Rows[i].Cells[5].Value.ToString(), "IN");
                            dal.AddParameter("@TOTAL", grdData.Rows[i].Cells[6].Value.ToString(), "IN");
                            dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                            dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                            _result = dal.ExecuteNonQuery("SP_SALE", ref Message);
                        }

                        if (_result > 0)
                        {
                            dal.ClearParameters();
                            dal.AddParameter("@TYPE", "SALE", "IN");
                            dal.AddParameter("@SUB_TYPE", "PRINT_BILL", "IN");
                            dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS.ToString(), "IN");
                            dal.AddParameter("@BILL_ID", BILL_ID.ToString(), "IN");
                            dt = dal.GetTable("SP_SALE", ref Message);

                            for (int i = 0; i < Convert.ToInt16(NO_OF_PRINT_); i++)
                            {
                                LocalReport report_ = new LocalReport();
                                string path = Path.GetDirectoryName(Application.ExecutablePath);
                                string fullPath = _variables.BILL_PATH + "JE_Invoice.rdlc";
                                report_.ReportPath = fullPath;
                                report_.DataSources.Add(new ReportDataSource("JE_ds", dt));
                                PrintToPrinter(report_);
                            }
                        }

                        ClearAll();
                        BALANCE.Text = "";
                        QUANTITY.Text = "1";
                        NameBind();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check all Inputs properly entered or not.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PARTY_NAME_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PARTY_NAME.Text.Trim() == "")
                {
                    MOBILE.Text = "";
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE", "IN");
                    dal.AddParameter("@SUB_TYPE", "DETAIL_WITH_PARTYNAME", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@PARTY_NAME", PARTY_NAME.Text.Trim().ToUpper(), "IN");
                    dt = dal.GetTable("SP_SALE", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        CUSTOMER_ID.Text = dt.Rows[0]["ID"].ToString();
                        MOBILE.Text = dt.Rows[0]["MOBILE"].ToString();
                        ADDRESS.Text = dt.Rows[0]["ADDRESS"].ToString();

                        MOBILE.Enabled = ADDRESS.Enabled = false;
                    }
                    else
                    {
                        MOBILE.Enabled = ADDRESS.Enabled = true;
                        CUSTOMER_ID.Text = MOBILE.Text = ADDRESS.Text = "";
                        ADDRESS.Text = "Nagpur";
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void PARTICULAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PARTICULAR_LIST(PARTICULAR.Text);
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "PARTICULAR_BY_NAME", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@PRODUCT_NAME", PARTICULAR.Text.Trim().ToUpper(), "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    QTY.Text = dt.Rows[0]["AVAILABLE"].ToString();
                    ID.Text = dt.Rows[0]["ID"].ToString();
                    BARCODE.Text = dt.Rows[0]["BARCODE"].ToString();
                    PARTICULAR.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
                    MRP.Text = dt.Rows[0]["MRP"].ToString();
                    CHKISEDITABLE = dt.Rows[0]["CHKISEDITABLE"].ToString();

                    if (CHKISEDITABLE == "1")
                    {
                        MRP.Enabled = true;
                    }
                    else MRP.Enabled = false;
                    QUANTITY.Text = "1";
                }
                else
                {
                    ID.Text = BARCODE.Text = MRP.Text = QTY.Text = "";
                }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            try
            {
                CUSTOMER_ID.Text = "";
                PARTY_NAME.Text = ADDRESS.Text = MOBILE.Text = TOTAL_TO_PAY.Text = CASH.Text = CARD.Text = ONLINE.Text = QTY.Text = "";
                BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = DISCOUNT.Text = "";
                GROSS.Text = CASH.Text = ONLINE.Text = BALANCE.Text = MD_AMOUNT.Text = "";
                ADDRESS.Text = "Nagpur";
                panelPayment.Visible = false;
                for (int j = grdData.Rows.Count; j > 0; j--)
                {
                    grdData.Rows.RemoveAt(j - 1);
                }
                grdData.DataSource = null;
            }
            catch (Exception ex) { }
        }

        private void grdDataParticular_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID.Text = grdDataParticular.CurrentRow.Cells["ID"].Value.ToString();
                BARCODE.Text = grdDataParticular.CurrentRow.Cells[1].Value.ToString();
                QTY.Text = grdDataParticular.CurrentRow.Cells["QTY"].Value.ToString();
                PARTICULAR.Text = grdDataParticular.CurrentRow.Cells[2].Value.ToString();
                QUANTITY.Text = "1";
                MRP.Text = TOTAL.Text = grdDataParticular.CurrentRow.Cells["MRP"].Value.ToString();
                QUANTITY.Focus();
            }
            catch (Exception ex) { }
        }

        private void DISCOUNT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal DISCOUNT_ = 0, CASH_ = 0, CARD_ = 0, ONLINE_ = 0, GROSS_ = 0;
                if (string.IsNullOrEmpty(GROSS.Text)) { GROSS_ = 0; } else { GROSS_ = Convert.ToDecimal(GROSS.Text); }
                if (string.IsNullOrEmpty(DISCOUNT.Text)) { DISCOUNT_ = 0; } else { DISCOUNT_ = Convert.ToDecimal(DISCOUNT.Text); }
                decimal DISCOUNT_TOTAL_ = 0;

                if (DISCOUNT_ > GROSS_)
                {
                    MessageBox.Show("Discount amount cant be greator than Gross", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DISCOUNT.Text = "";
                }
                else
                {
                    if (DISCOUNT_ > 0)
                    {
                        CASH.Text = ONLINE.Text = CARD.Text = "";
                        DISCOUNT_TOTAL_ = GROSS_ * DISCOUNT_ / 100;
                        TOTAL_TO_PAY.Text = BALANCE.Text = Math.Round((GROSS_ - DISCOUNT_TOTAL_)).ToString();
                        DISCOUNT_TOTAL.Text = DISCOUNT_TOTAL_.ToString();
                    }
                    else
                    {
                        TOTAL_TO_PAY.Text = BALANCE.Text = (GROSS_).ToString();
                        DISCOUNT.Text = "";
                        DISCOUNT_TOTAL.Text = "";
                        DISCOUNT_TOTAL_ = 0;
                    }
                }

            }
            catch (Exception ex) { }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rows = Convert.ToInt16(grdData.SelectedCells[0].RowIndex);
                string ID = grdData.CurrentRow.Cells[0].Value.ToString();
                string BARCODE = grdData.CurrentRow.Cells[1].Value.ToString();
                int QUANTITY = Convert.ToInt16(grdData.CurrentRow.Cells[3].Value.ToString());
                int FREE_QUANTITY_ = 0;

                if (MessageBox.Show("are you sure want to remove ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveAddQuantity(ID, BARCODE, (QUANTITY + FREE_QUANTITY_).ToString(), "A");
                    tableProduct.Rows.RemoveAt(rows);
                    Calculate_Amount();
                    grdData.DataSource = tableProduct;
                    grdData.Columns[2].Width = 400;
                    grdData.Columns[3].Width = 130;
                    grdData.Columns[4].Width = 130;
                    grdData.Columns[5].Width = 130;
                    grdData.Columns[6].Width = 130;
                    PARTICULAR.Focus();
                }
            }
            catch (Exception ex) { }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            panelPayment.Visible = false;
            PARTICULAR.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ID.Text = BARCODE.Text = PARTICULAR.Text = MRP.Text = TOTAL.Text = QTY.Text = "";
            QUANTITY.Text = "1";
            BARCODE.Focus();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Particular / item", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PARTICULAR.Focus();
            }
            else
            {
                panelPayment.Visible = true;
                PARTY_NAME.Focus();
            }
        }

        private void MOBILE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MOBILE.Text.Trim() == "")
                {
                    PARTY_NAME.Text = "";
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE", "IN");
                    dal.AddParameter("@SUB_TYPE", "DETAIL_WITH_PARTYMOBILE", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text.Trim().ToUpper(), "IN");
                    dt = dal.GetTable("SP_SALE", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        CUSTOMER_ID.Text = dt.Rows[0]["ID"].ToString();
                        PARTY_NAME.Text = dt.Rows[0]["NAME"].ToString();
                        ADDRESS.Text = dt.Rows[0]["ADDRESS"].ToString();
                        // MOBILE.Enabled = ADDRESS.Enabled = false;
                    }
                    else
                    {
                        // MOBILE.Enabled = ADDRESS.Enabled = true;
                        CUSTOMER_ID.Text = ADDRESS.Text = PARTY_NAME.Text = "";
                        ADDRESS.Text = "Nagpur";
                    }
                }
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Code For change Text Box with Validation

        private void MOBILE_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }

        private void NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
        }

        private void CASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation

        #region -- Code for Printing Bill

        public static void PrintToPrinter(LocalReport report)
        {
            try
            {
                Export(report);
            }
            catch (Exception ex) { }
        }

        public static void Export(LocalReport report, bool print = true)
        {
            try
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
            catch (Exception ex) { }
        }

        public static void Print()
        {
            try
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
            catch (Exception ex) { }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
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

                ev.PageSettings.PrinterSettings.Copies = 2;
                // report_.PrinterSettings.Copies = 3;

                // Prepare for the next page. Make sure we haven't hit the end.
                m_currentPageIndex++;
                ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
            }
            catch (Exception ex) { }
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

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion -- Code for Printing Bill

        #region -- Code For Back Color of Change

        private void MD_AMOUNT_Enter(object sender, EventArgs e)
        {
            MD_AMOUNT.BackColor = Color.MistyRose;
        }

        private void MD_AMOUNT_Leave(object sender, EventArgs e)
        {
            MD_AMOUNT.BackColor = Color.White;
        }

        private void PARTICULAR_Enter(object sender, EventArgs e)
        {
            PARTICULAR.BackColor = Color.MistyRose;
        }

        private void PARTICULAR_Leave(object sender, EventArgs e)
        {
            PARTICULAR.BackColor = Color.White;
        }

        private void QUANTITY_Enter(object sender, EventArgs e)
        {
            QUANTITY.BackColor = Color.MistyRose;
        }

        private void QUANTITY_Leave(object sender, EventArgs e)
        {
            QUANTITY.BackColor = Color.White;
        }

        private void MRP_Enter(object sender, EventArgs e)
        {
            MRP.BackColor = Color.MistyRose;
        }

        private void MRP_Leave(object sender, EventArgs e)
        {
            MRP.BackColor = Color.White;
        }

        private void ITEM_DISCOUNT_Enter(object sender, EventArgs e)
        {
            ITEM_DISCOUNT.BackColor = Color.MistyRose;
        }

        private void ITEM_DISCOUNT_Leave(object sender, EventArgs e)
        {
            ITEM_DISCOUNT.BackColor = Color.White;
        }

        private void btnAdd_Enter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.ForeColor = Color.Black;
        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = Color.White;
        }

        private void btnPay_Enter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.MistyRose;
            btnPay.ForeColor = Color.Black;
        }

        private void btnPay_Leave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.Green;
            btnPay.ForeColor = Color.White;
        }

        private void PARTY_NAME_Enter(object sender, EventArgs e)
        {
            PARTY_NAME.BackColor = Color.MistyRose;
        }

        private void PARTY_NAME_Leave(object sender, EventArgs e)
        {
            PARTY_NAME.BackColor = Color.White;
        }

        private void MOBILE_Enter(object sender, EventArgs e)
        {
            MOBILE.BackColor = Color.MistyRose;
        }

        private void MOBILE_Leave(object sender, EventArgs e)
        {
            MOBILE.BackColor = Color.White;
        }

        private void ADDRESS_Enter(object sender, EventArgs e)
        {
            ADDRESS.BackColor = Color.MistyRose;
        }

        private void ADDRESS_Leave(object sender, EventArgs e)
        {
            ADDRESS.BackColor = Color.White;
        }

        private void DISCOUNT_Enter(object sender, EventArgs e)
        {
            DISCOUNT.BackColor = Color.MistyRose;
        }

        private void DISCOUNT_Leave(object sender, EventArgs e)
        {
            DISCOUNT.BackColor = Color.White;
        }

        private void CASH_Enter(object sender, EventArgs e)
        {
            CASH.BackColor = Color.MistyRose;
        }

        private void CASH_Leave(object sender, EventArgs e)
        {
            CASH.BackColor = Color.White;
        }

        private void CARD_Enter(object sender, EventArgs e)
        {
            CARD.BackColor = Color.MistyRose;
        }

        private void CARD_Leave(object sender, EventArgs e)
        {
            CARD.BackColor = Color.White;
        }

        private void ONLINE_Enter(object sender, EventArgs e)
        {
            ONLINE.BackColor = Color.MistyRose;
        }

        private void ONLINE_Leave(object sender, EventArgs e)
        {
            ONLINE.BackColor = Color.White;
        }

        private void btnSubmit_Enter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.MistyRose;
            btnSubmit.ForeColor = Color.Black;
        }

        private void btnSubmit_Leave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Green;
            btnSubmit.ForeColor = Color.White;
        }

        #endregion -- Code For Back Color of Change

    }
}
