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
    public partial class EditBill : Form
    {
        DataTable dt; string CHKISEDITABLE = "0";
        string Message = ""; public string GST_IN;
        int _result = 0; public bool FINANCIAL_STATUS, WITH_BATCH;
        DAL dal = new DAL(); public string USER_ID;
        DataTable table = new DataTable();
        Shop_Detail _variables = new Shop_Detail();
        DataTable tableProduct = new DataTable();
        Validation _validation = new Validation();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        ConvertNumberToWords _convertnumbertowords = new ConvertNumberToWords();
        public string BILL_LABLE;

        public EditBill()
        {
            InitializeComponent();
        }

        #region -- Codes For Buttons

        private void EditBill_Load(object sender, EventArgs e)
        {
            PARTICULAR_LIST("");
            Add_Particular();
            NameBind();
            Particular_Bind();
            Bind_AdminEmployee();
            ORDER_BY.SelectedIndex = 1;
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
                tableProduct.Columns.Add("MRP", typeof(string));
                tableProduct.Columns.Add("Rate", typeof(string));
                tableProduct.Columns.Add("Total", typeof(string));
                tableProduct.Columns.Add("BATCH_NO", typeof(string));
            }
            catch (Exception ex) { }

            
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F12)
            {
                panelPayment.Visible = true;
                btnSubmit.Focus();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    // MessageBox.Show("Paid Amount cant be greator than Total.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                tableProduct = grdData.DataSource as DataTable;

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
                    Calculate_Amount();

                    BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = QTY.Text = FREE_QUANTITY.Text = ITEM_DISCOUNT.Text = "";
                    BARCODE.Focus(); QUANTITY.Text = "1";
                    MRP.Enabled = false;
                    grdData.Columns["ID"].Visible = grdData.Columns["BARCODE"].Visible = false;

                    grdData.Columns[2].Width = 400;
                    grdData.Columns[3].Width = 130;
                    grdData.Columns[4].Width = 130;
                    grdData.Columns[5].Width = 130;
                    grdData.Columns[6].Width = 130;
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

                    string BILL_ID = lbl_billId.Text;
                    decimal TOTAL_PAID_, CASH_, ONLINE_, CARD_, CREDIT_C_, CREDIT_O_, DEBIT_;
                    if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                    if (string.IsNullOrEmpty(CARD.Text)) { CARD_ = 0; } else { CARD_ = Convert.ToDecimal(CARD.Text); }
                    if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }

                    if (string.IsNullOrEmpty(CREDIT_C.Text)) { CREDIT_C_ = 0; } else { CREDIT_C_ = Convert.ToDecimal(CREDIT_C.Text); }
                    if (string.IsNullOrEmpty(CREDIT_O.Text)) { CREDIT_O_ = 0; } else { CREDIT_O_ = Convert.ToDecimal(CREDIT_O.Text); }
                    if (string.IsNullOrEmpty(DEBIT.Text)) { DEBIT_ = 0; } else { DEBIT_ = Convert.ToDecimal(DEBIT.Text); }

                    TOTAL_PAID_ = CASH_ + ONLINE_ + CARD_;

                    decimal TOTAL_QUANTITY = 0; string TOTAL_ITEM = "0";
                    for (int i = 0; i < grdData.Rows.Count; i++)
                    {
                        TOTAL_QUANTITY += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                    }
                    TOTAL_ITEM = grdData.Rows.Count.ToString();

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SALE_FOR_EDIT", "IN");
                    dal.AddParameter("@SUB_TYPE", "UPDATE_SALE", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID, "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID, "IN");
                    dal.AddParameter("@IN_WORDS", IN_WORDS.ToString(), "IN");
                    dal.AddParameter("@CUSTOMER_ID", CUSTOMER_ID.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@PARTY_NAME", PARTY_NAME.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@ADDRESS", ADDRESS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@GST_NUMBER", "", "IN");
                    dal.AddParameter("@DL_NUMBER", "", "IN");
                    dal.AddParameter("@GROSS", GROSS.Text, "IN");
                    dal.AddParameter("@TOTAL_QUANTITY", TOTAL_QUANTITY.ToString(), "IN");
                    dal.AddParameter("@TOTAL_ITEM", TOTAL_ITEM.ToString(), "IN");
                    dal.AddParameter("@DISCOUNT", DISCOUNT.Text, "IN");
                    dal.AddParameter("@CASH", CASH_.ToString(), "IN");
                    dal.AddParameter("@CARD", CARD_.ToString(), "IN");
                    dal.AddParameter("@ONLINE", ONLINE_.ToString(), "IN");
                    dal.AddParameter("@TOTAL_PAID", TOTAL_PAID_.ToString(), "IN");
                    dal.AddParameter("@BALANCE", BALANCE.Text, "IN");
                    dal.AddParameter("@CREDIT", CREDIT_C_.ToString(), "IN");
                    dal.AddParameter("@CREDIT_O", CREDIT_O_.ToString(), "IN");
                    dal.AddParameter("@DEBIT", DEBIT_.ToString(), "IN");
                    dal.AddParameter("@MD_AMOUNT", MD_AMOUNT.Text, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@ORDER_BY", ORDER_BY.SelectedValue.ToString(), "IN");
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
                            if (MessageBox.Show("Successfully Modify, Want to Print Bill ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Bill_Rdlcs.JE_Invoice ob = new Bill_Rdlcs.JE_Invoice();
                                ob.BILL_ID = BILL_ID.ToString();
                                ob.FINANCIAL_STATUS = FINANCIAL_STATUS;
                                ob.Show();
                            }
                        }

                        ClearAll();
                        BALANCE.Text = "";
                        QUANTITY.Text = "1";
                        NameBind();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void PARTY_NAME_TextChanged(object sender, EventArgs e)
        {
            if (PARTY_NAME.Text.Trim() == "")
            {
                MOBILE.Text = ADDRESS.Text = "";
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
                    CUSTOMER_ID.Text = MOBILE.Text = "";
                    ADDRESS.Text = "Nagpur";
                }
            }
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
            PARTY_NAME.Text = MOBILE.Text = TOTAL_TO_PAY.Text = CASH.Text = CARD.Text = ONLINE.Text = QTY.Text = "";
            BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = DISCOUNT.Text = "";
            GROSS.Text = CASH.Text = ONLINE.Text = BALANCE.Text = CREDIT_C.Text = CREDIT_O.Text = DEBIT.Text = MD_AMOUNT.Text = "";
            panelPayment.Visible = false;
            for (int j = grdData.Rows.Count; j > 0; j--)
            {
                grdData.Rows.RemoveAt(j - 1);
            }
            grdData.DataSource = null;
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
                BARCODE.Focus();
            }
            catch (Exception ex) { }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                tableProduct = grdData.DataSource as DataTable;

                int rows = Convert.ToInt16(grdData.SelectedCells[0].RowIndex);
                string ID = grdData.CurrentRow.Cells[0].Value.ToString();
                string BARCODE = grdData.CurrentRow.Cells[1].Value.ToString();
                int QUANTITY = Convert.ToInt16(grdData.CurrentRow.Cells[3].Value.ToString());
                // int FREE_QUANTITY_ = Convert.ToInt16(grdData.CurrentRow.Cells[4].Value.ToString());

                if (MessageBox.Show("are you sure want to remove ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveAddQuantity(ID, BARCODE, (QUANTITY).ToString(), "A");

                    tableProduct.Rows.RemoveAt(rows);
                    Calculate_Amount();
                    grdData.DataSource = tableProduct;

                    // grdData.Columns[1].Width = 100;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ID.Text = BARCODE.Text = PARTICULAR.Text = MRP.Text = TOTAL.Text = QTY.Text = "";
            QUANTITY.Text = "1";
            BARCODE.Focus();
        }

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
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    DataSet ds = dal.GetDataSet("SP_SALE", ref Message);

                    DataTable Table1 = ds.Tables[0];

                    if (Table1.Rows.Count > 0)
                    {
                        var Result = Table1.Rows[0][0].ToString();
                        string[] Result_ = Result.Split('~');
                        if (Result_[0].ToString() == "False")
                        {
                            MessageBox.Show(Result_[1].ToString(), _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dt = null;
                            grdData.DataSource = dt;
                            SEARCH_ID.Focus();
                        }
                        else
                        {
                            DataTable Table2 = ds.Tables[1];
                            MessageBox.Show("Search Successfully.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panelSearch.Visible = false;
                            PARTICULAR.Enabled = grdDataParticular.Enabled = true;
                            lbl_billId.Text = SEARCH_ID.Text.ToString();
                            PARTY_NAME.Text = Table1.Rows[0]["PARTY_1_NAME"].ToString();
                            CUSTOMER_ID.Text = Table1.Rows[0]["PARTY_1_ID"].ToString();
                            MOBILE.Text = Table1.Rows[0]["PARTY_1_MOBILE"].ToString();
                            ADDRESS.Text = Table1.Rows[0]["PARTY_1_ADDRESS"].ToString();
                            GROSS.Text = LAST_BILL_AMOUNT.Text = Table1.Rows[0]["GROSS"].ToString();
                            DISCOUNT.Text = Table1.Rows[0]["DISCOUNT_PERCENTAGE"].ToString();
                            DISCOUNT_TOTAL.Text = Table1.Rows[0]["DISCOUNT"].ToString();
                            TOTAL_TO_PAY.Text = Table1.Rows[0]["TOTAL"].ToString();
                            BALANCE.Text = Table1.Rows[0]["BALANCE"].ToString();
                            CASH.Text = Table1.Rows[0]["CASH"].ToString();
                            CARD.Text = Table1.Rows[0]["CARD"].ToString();
                            ONLINE.Text = Table1.Rows[0]["ONLINE"].ToString();
                            PARTY_NAME.Text = Table1.Rows[0]["PARTY_1_NAME"].ToString();
                            ORDER_BY.SelectedValue = Table1.Rows[0]["ORDER_BY"].ToString();
                            MD_AMOUNT.Text = Table1.Rows[0]["MD_AMOUNT"].ToString();
                            grdData.DataSource = Table2;
                            grdData.Columns[0].Visible = grdData.Columns[1].Visible = false;
                            grdData.Columns[2].Width = 400;
                            grdData.Columns[3].Width = 130;
                            grdData.Columns[4].Width = 130;
                            grdData.Columns[5].Width = 130;
                            grdData.Columns[6].Width = 130;
                            PARTICULAR.Focus();
                        }
                    }
                    else
                    {
                        dt = null;
                        grdData.DataSource = dt;
                    }
                }
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
                btnSubmit.Focus();
                PARTY_NAME.Focus();
            }
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

        private void SEARCH_ID_Enter(object sender, EventArgs e)
        {
            SEARCH_ID.BackColor = Color.MistyRose;
        }

        private void SEARCH_ID_Leave(object sender, EventArgs e)
        {
            SEARCH_ID.BackColor = Color.White;
        }

        private void CREDIT_C_Enter(object sender, EventArgs e)
        {
            CREDIT_C.BackColor = Color.MistyRose;
        }

        private void CREDIT_C_Leave(object sender, EventArgs e)
        {
            CREDIT_C.BackColor = Color.White;
        }

        private void CREDIT_O_Enter(object sender, EventArgs e)
        {
            CREDIT_O.BackColor = Color.MistyRose;
        }

        private void CREDIT_O_Leave(object sender, EventArgs e)
        {
            CREDIT_O.BackColor = Color.White;
        }

        private void DEBIT_Enter(object sender, EventArgs e)
        {
            DEBIT.BackColor = Color.MistyRose;
        }

        private void DEBIT_Leave(object sender, EventArgs e)
        {
            DEBIT.BackColor = Color.White;
        }

        private void BTN_SERACH_Enter(object sender, EventArgs e)
        {
            BTN_SERACH.BackColor = Color.Green;
            BTN_SERACH.ForeColor = Color.White;
        }

        private void BTN_SERACH_Leave(object sender, EventArgs e)
        {
            BTN_SERACH.BackColor = Color.MistyRose;
            BTN_SERACH.ForeColor = Color.Black;
        }

        #endregion -- Code For Back Color of Change

    }
}
