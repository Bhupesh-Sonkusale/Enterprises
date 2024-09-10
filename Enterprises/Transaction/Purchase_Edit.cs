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

namespace Enterprises.Transaction
{
    public partial class Purchase_Edit : Form
    {
        DataTable dt;
        string Message = ""; decimal TOTAL_GST = 0;
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID; public string GST_IN, WITH_BATCH;
        Shop_Detail _variables = new Shop_Detail();
        DataTable tableProduct = new DataTable(); Validation _validation = new Validation();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public Purchase_Edit()
        {
            InitializeComponent();
        }

        #region -- Codes For Buttons

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F12)
            {
                panelPayment.Visible = true;
                BILL_ID.Focus();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Purchase_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                panelPayment.Enabled = panelParticulars.Enabled = false;
                BILL_DATE.MaxDate = DateTime.Now;
                PARTICULAR_LIST("");
                Add_Particular();
                NameBind();
                Particular_Bind();
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
                    dal.AddParameter("@SUB_TYPE", "PARTICULAR_LIST_P", "IN");
                }
                else
                {
                    dal.AddParameter("@SUB_TYPE", "PARTICULAR_LIST_BYNAME_P", "IN");
                }

                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@PRODUCT_NAME", PARTICULAR.Text, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                grdDataParticular.DataSource = dt;
                grdDataParticular.Columns["ID"].Visible = false;
                grdDataParticular.Columns["BARCODE"].Visible = false;
                grdDataParticular.Columns["MRP"].Visible = false;
                grdDataParticular.Columns["QTY"].Visible = false;
                grdDataParticular.Columns["GST"].Visible = false;
                grdDataParticular.Columns["PARTICULAR"].Width = 260;
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
                SqlCommand cmd_ = new SqlCommand("SELECT NAME FROM REGISTRATION WHERE MEMBER_TYPE = 'V' AND STATUS = 'TRUE' AND BRANCH_ID = @BRANCH_ID AND NAME LIKE '%" + PARTY_NAME.Text + "%'", con);
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
                tableProduct.Columns.Add("PARTICULAR", typeof(string));
                tableProduct.Columns.Add("QUANTITY", typeof(string));
                tableProduct.Columns.Add("RATE", typeof(string));
                tableProduct.Columns.Add("DISC.", typeof(string));
                tableProduct.Columns.Add("GST", typeof(string));
                tableProduct.Columns.Add("TOTAL", typeof(string));
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QUANTITY_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Discont_Gst();
        }

        private void GST_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Total_Discont_Gst();
        }

        public void Calculate_Total_Discont_Gst()
        {
            try
            {
                decimal QUANTITY_, MRP_, GST_, ITEM_DISCOUNT_, MRP_QUANTITY, AFTER_DISCOUNT;
                if (string.IsNullOrEmpty(QUANTITY.Text)) { QUANTITY_ = 1; } else { QUANTITY_ = Convert.ToDecimal(QUANTITY.Text); }
                if (string.IsNullOrEmpty(MRP.Text)) { MRP_ = 0; } else { MRP_ = Convert.ToDecimal(MRP.Text); }
                if (string.IsNullOrEmpty(GST.Text)) { GST_ = 0; } else { GST_ = Convert.ToDecimal(GST.Text); }
                if (string.IsNullOrEmpty(ITEM_DISCOUNT.Text)) { ITEM_DISCOUNT_ = 0; } else { ITEM_DISCOUNT_ = Convert.ToDecimal(ITEM_DISCOUNT.Text); }
                MRP_QUANTITY = QUANTITY_ * MRP_;
                TOTAL.Text = Math.Round(MRP_QUANTITY, 2).ToString();

                LBL_DISCOUNT.Text = Math.Round(((MRP_QUANTITY) * ITEM_DISCOUNT_) / (100 + ITEM_DISCOUNT_), 2).ToString();
                AFTER_DISCOUNT = MRP_QUANTITY - Convert.ToDecimal(LBL_DISCOUNT.Text);

                GST_AMT.Text = Math.Round(((AFTER_DISCOUNT * GST_) / (100)), 2).ToString();
            }
            catch (Exception ex) { }
        }

        private void CASH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal CASH_; decimal ONLINE_; decimal TOTAL_TO_PAY_;
                if (string.IsNullOrEmpty(TOTAL_TO_PAY.Text)) { TOTAL_TO_PAY_ = 0; } else { TOTAL_TO_PAY_ = Convert.ToDecimal(TOTAL_TO_PAY.Text); }
                if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
                decimal CALCULATE = TOTAL_TO_PAY_ - (CASH_ + ONLINE_);
                if (CALCULATE < 0)
                {
                    // MessageBox.Show("Paid Amount cant be greator than Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BALANCE.Text = TOTAL_TO_PAY_.ToString();
                    CASH.Text = ONLINE.Text = "";
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
                if (PARTICULAR.Text == "")
                {
                    MessageBox.Show("Enter Particular.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTICULAR.Focus();
                }
                else if (QUANTITY.Text == "" || QUANTITY.Text == "0")
                {
                    MessageBox.Show("Enter Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (Convert.ToDecimal(QUANTITY.Text) <= 0)
                {
                    MessageBox.Show("Enter Valid Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (MRP.Text == "" || MRP.Text == "0")
                {
                    MessageBox.Show("Enter Purchase Rate.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MRP.Focus();
                }
                else if (Convert.ToDecimal(MRP.Text) <= 0)
                {
                    MessageBox.Show("Enter Purchase Rate.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QUANTITY.Focus();
                }
                else if (GST.SelectedIndex == 0)
                {
                    MessageBox.Show("Select GST.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GST.Focus();
                }
                else
                {
                    tableProduct.Rows.Add(ID.Text, BARCODE.Text, PARTICULAR.Text, QUANTITY.Text, MRP.Text, Math.Round(Convert.ToDecimal(LBL_DISCOUNT.Text), 2), GST_AMT.Text.ToString(), Math.Round(Convert.ToDecimal(TOTAL.Text), 2));
                    grdData.DataSource = tableProduct;
                    grdData.Columns[0].Visible = grdData.Columns[1].Visible = false;
                    BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = QUANTITY.Text = ITEM_DISCOUNT.Text = "";
                    GST.SelectedIndex = 0;
                    PARTICULAR.Focus();
                    Calculate_Amount();
                }
            }
            catch (Exception ex) { }
        }

        public void Calculate_Amount()
        {
            try
            {
                decimal GROSS_ = 0, TOTAL_GST = 0, TOTAL_DISCOUNT_ = 0;
                for (int i = 0; i < grdData.Rows.Count; i++)
                {
                    TOTAL_DISCOUNT_ += Convert.ToDecimal(grdData.Rows[i].Cells[5].Value);
                    TOTAL_GST += Convert.ToDecimal(grdData.Rows[i].Cells[6].Value);
                    GROSS_ += Convert.ToDecimal(grdData.Rows[i].Cells[7].Value);
                }

                DISCOUNT.Text = Math.Round(TOTAL_DISCOUNT_, 2).ToString();
                GROSS.Text = BALANCE.Text = GROSS_.ToString();
                CGST.Text = SGST.Text = Math.Round((TOTAL_GST / 2), 2).ToString();

                TOTAL_TO_PAY.Text = ((GROSS_ - TOTAL_DISCOUNT_) + (TOTAL_GST)).ToString();

                grdData.Columns[0].Visible = grdData.Columns[1].Visible = false;
                grdData.Columns[2].Width = 400;
                grdData.Columns[3].Width = 100;
                grdData.Columns[4].Width = 120;
                grdData.Columns[5].Width = 120;
                grdData.Columns[6].Width = 120;
                grdData.Columns[7].Width = 150;
            }
            catch (Exception ex) { }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchBillID.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Purchase ID", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SearchBillID.Focus();
                }
                else if (grdData.Rows.Count == 0)
                {
                    MessageBox.Show("Enter Product Detail", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panelPayment.Visible = false;
                    BARCODE.Focus();
                }
                else if (BILL_ID.Text == "")
                {
                    MessageBox.Show("Enter Bill ID", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BILL_ID.Focus();
                }
                else if (PARTY_NAME.Text == "")
                {
                    MessageBox.Show("Enter Party Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTY_NAME.Focus();
                }
                else if (MOBILE.Text == "")
                {
                    MessageBox.Show("Enter Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MOBILE.Focus();
                }
                else if (MOBILE.Text.Length != 10)
                {
                    MessageBox.Show("Enter Valid Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MOBILE.Focus();
                }
                else if (ADDRESS.Text == "")
                {
                    MessageBox.Show("Enter Address", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ADDRESS.Focus();
                }
                else if (grdData.Rows.Count < 1)
                {
                    MessageBox.Show("Enter Product First", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BARCODE.Focus();
                }
                else
                {
                    string PURCHASE_ID = SearchBillID.Text.Trim();
                    decimal TOTAL_PAID_, CASH_, ONLINE_, GST_, TOTAL_GST = 0;
                    if (string.IsNullOrEmpty(CASH.Text)) { CASH_ = 0; } else { CASH_ = Convert.ToDecimal(CASH.Text); }
                    if (string.IsNullOrEmpty(ONLINE.Text)) { ONLINE_ = 0; } else { ONLINE_ = Convert.ToDecimal(ONLINE.Text); }
                    if (string.IsNullOrEmpty(CGST.Text)) { GST_ = 0; } else { GST_ = Convert.ToDecimal(CGST.Text); }
                    TOTAL_GST = GST_ * 2;
                    TOTAL_PAID_ = CASH_ + ONLINE_;

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "A2_PURCHASE_EDIT", "IN");
                    dal.AddParameter("@SUB_TYPE", "EDIT_PURCHASE_PERSO", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                    dal.AddParameter("@PURCHASE_ID", PURCHASE_ID, "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID.Text.Trim().ToUpper().ToString(), "IN");
                    dal.AddParameter("@BILL_DATE", Convert.ToDateTime(BILL_DATE.Text), "IN");
                    dal.AddParameter("@VENDOR_ID", VENDOR_ID.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@GROSS", GROSS.Text, "IN");
                    dal.AddParameter("@DISCOUNT", DISCOUNT.Text.Trim().ToString(), "IN");
                    dal.AddParameter("@GST_RS", TOTAL_GST.ToString(), "IN");
                    dal.AddParameter("@TOTAL_TO_PAY", TOTAL_TO_PAY.Text.Trim().ToString(), "IN");
                    dal.AddParameter("@CASH", CASH_.ToString(), "IN");
                    dal.AddParameter("@ONLINE", ONLINE_.ToString(), "IN");
                    dal.AddParameter("@TOTAL_PAID", TOTAL_PAID_.ToString(), "IN");
                    dal.AddParameter("@BALANCE", BALANCE.Text, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@WITH_BATCH", WITH_BATCH, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_PURCHASE", ref Message);
                    if (_result > 0)
                    {
                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            dal.ClearParameters();
                            dal.AddParameter("@TYPE", "PURCHASE_ITEM", "IN");
                            dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                            dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                            dal.AddParameter("@PURCHASE_ID", PURCHASE_ID, "IN");
                            dal.AddParameter("@PRODUCT_ID", grdData.Rows[i].Cells[0].Value.ToString(), "IN");
                            dal.AddParameter("@BARCODE", grdData.Rows[i].Cells[1].Value.ToString(), "IN");
                            dal.AddParameter("@QUANTITY", grdData.Rows[i].Cells[3].Value.ToString(), "IN");
                            dal.AddParameter("@GODOWN_QUANTITY", grdData.Rows[i].Cells[3].Value.ToString(), "IN");
                            dal.AddParameter("@MRP", grdData.Rows[i].Cells[4].Value.ToString(), "IN");
                            dal.AddParameter("@DISCOUNT", grdData.Rows[i].Cells[5].Value.ToString(), "IN");
                            dal.AddParameter("@GST_RS", grdData.Rows[i].Cells[6].Value.ToString(), "IN");
                            dal.AddParameter("@TOTAL", grdData.Rows[i].Cells[7].Value.ToString(), "IN");
                            dal.AddParameter("@GST_IN", GST_IN.ToString(), "IN");
                            dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                            dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                            _result = dal.ExecuteNonQuery("SP_PURCHASE", ref Message);
                        }
                        if (_result > 0)
                        {
                            MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ClearAll();
                        BALANCE.Text = "";
                        QUANTITY.Text = "";
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
            try
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PURCHASE", "IN");
                dal.AddParameter("@SUB_TYPE", "DETAIL_WITH_PARTYNAME", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@PARTY_NAME", PARTY_NAME.Text.Trim().ToUpper(), "IN");
                dal.AddParameter("@MEMBER_TYPE", "V", "IN");
                dt = dal.GetTable("SP_PURCHASE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    MOBILE.Text = dt.Rows[0]["MOBILE"].ToString();
                    ADDRESS.Text = dt.Rows[0]["ADDRESS"].ToString();
                    GST_NO.Text = dt.Rows[0]["GST"].ToString();
                    VENDOR_ID.Text = dt.Rows[0]["ID"].ToString();
                }
                else
                {
                    MOBILE.Text = ADDRESS.Text = GST_NO.Text = VENDOR_ID.Text = "";
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
                    ID.Text = dt.Rows[0]["ID"].ToString();
                    BARCODE.Text = dt.Rows[0]["BARCODE"].ToString();
                    PARTICULAR.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
                    MRP.Text = dt.Rows[0]["PURCHASE_RATE"].ToString();
                    GST.Text = dt.Rows[0]["GST"].ToString();
                }
                else
                {
                    ID.Text = BARCODE.Text = MRP.Text = "";
                    GST.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            try
            {
                panelPayment.Visible = false;
                BILL_ID.Text = PARTY_NAME.Text = ADDRESS.Text = MOBILE.Text = GST_NO.Text = "";
                BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = MRP.Text = TOTAL.Text = "";
                GROSS.Text = CASH.Text = ONLINE.Text = BALANCE.Text = "";
                for (int j = grdData.Rows.Count; j > 0; j--)
                {
                    grdData.Rows.RemoveAt(j - 1);
                }
                grdData.DataSource = null;
                BILL_DATE.Text = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString();
            }
            catch (Exception ex) { }
        }

        private void grdDataParticular_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID.Text = grdDataParticular.CurrentRow.Cells["ID"].Value.ToString();
                BARCODE.Text = grdDataParticular.CurrentRow.Cells["BARCODE"].Value.ToString();
                MRP.Text = grdDataParticular.CurrentRow.Cells["MRP"].Value.ToString();
                PARTICULAR.Text = grdDataParticular.CurrentRow.Cells[2].Value.ToString();
                GST.Text = grdDataParticular.CurrentRow.Cells["GST"].Value.ToString();
                QUANTITY.Focus();
            }
            catch (Exception ex) { }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rows = Convert.ToInt16(grdData.SelectedCells[0].RowIndex);

                if (MessageBox.Show("are you sure want to remove ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tableProduct.Rows.RemoveAt(rows);
                    grdData.DataSource = tableProduct;
                    Calculate_Amount();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            panelPayment.Visible = false;
        }

        private void DISCOUNT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal GROSS_ = 0, DISCOUNT_ = 0, CGST_ = 0, SGST_ = 0;
                if (string.IsNullOrEmpty(GROSS.Text)) { GROSS_ = 0; } else { GROSS_ = Convert.ToDecimal(GROSS.Text); }
                if (string.IsNullOrEmpty(DISCOUNT.Text)) { DISCOUNT_ = 0; } else { DISCOUNT_ = Convert.ToDecimal(DISCOUNT.Text); }
                if (string.IsNullOrEmpty(CGST.Text)) { CGST_ = 0; } else { CGST_ = Convert.ToDecimal(CGST.Text); }
                if (string.IsNullOrEmpty(SGST.Text)) { SGST_ = 0; } else { SGST_ = Convert.ToDecimal(SGST.Text); }
                TOTAL_TO_PAY.Text = BALANCE.Text = Math.Round(((GROSS_ + CGST_ + SGST_) - DISCOUNT_), 2).ToString();
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Code For change Text Box with Validation

        private void MOBILE_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }

        private void PARTY_NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
        }

        private void CASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchBillID.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Purchase Bill ID", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SearchBillID.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "A2_PURCHASE_EDIT", "IN");
                    dal.AddParameter("@SUB_TYPE", "SEARCH_WITH_ID", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@PURCHASE_ID", SearchBillID.Text.Trim(), "IN");
                    DataSet DS = dal.GetDataSet("SP_PURCHASE", ref Message);

                    DataTable PersonalDetail = DS.Tables[0];
                    DataTable ParticularDetail = DS.Tables[2];

                    VENDOR_ID.Text = PersonalDetail.Rows[0]["VENDOR_ID"].ToString();
                    PARTY_NAME.Text = PersonalDetail.Rows[0]["NAME"].ToString();
                    MOBILE.Text = PersonalDetail.Rows[0]["MOBILE"].ToString();
                    ADDRESS.Text = PersonalDetail.Rows[0]["ADDRESS"].ToString();
                    BILL_ID.Text = PersonalDetail.Rows[0]["BILL_ID"].ToString();
                    BILL_DATE.Text = PersonalDetail.Rows[0]["BILL_DATE"].ToString();
                    CASH.Text = PersonalDetail.Rows[0]["CASH"].ToString();
                    ONLINE.Text = PersonalDetail.Rows[0]["ONLINE"].ToString();
                    GROSS.Text = PersonalDetail.Rows[0]["GROSS"].ToString();
                    GST_NO.Text = PersonalDetail.Rows[0]["GST_NUMBER"].ToString();
                    DISCOUNT.Text = PersonalDetail.Rows[0]["DISCOUNT"].ToString();
                    TOTAL_TO_PAY.Text = BALANCE.Text = PersonalDetail.Rows[0]["GROSS"].ToString();
                    grdData.DataSource = ParticularDetail;
                    tableProduct = ParticularDetail;

                    grdData.Columns[0].Visible = grdData.Columns[1].Visible = false;
                    grdData.Columns[2].Width = 400;
                    grdData.Columns[3].Width = 100;
                    grdData.Columns[4].Width = 120;
                    grdData.Columns[5].Width = 120;
                    grdData.Columns[6].Width = 120;
                    grdData.Columns[7].Width = 150;
                    panelPayment.Enabled = panelParticulars.Enabled = true;
                    panelSearchWithBillID.Visible = false;
                }
            }
            catch (Exception ex) { }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            panelPayment.Visible = true;
            BILL_ID.Focus();
        }

    }
}
