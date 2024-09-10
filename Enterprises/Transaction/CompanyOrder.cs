using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Transaction
{
    public partial class CompanyOrder : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0; public bool FINANCIAL_STATUS;
        DAL dal = new DAL(); public string USER_ID;
        DataTable tableProduct = new DataTable();
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation(); decimal AVAILABLE = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public CompanyOrder()
        {
            InitializeComponent();
        }

        public void Add_Particular()
        {
            tableProduct.Columns.Add("ID", typeof(string));
            tableProduct.Columns.Add("Particular", typeof(string));
            tableProduct.Columns.Add("Quantity", typeof(string));
        }

        private void CompanyOrder_Load(object sender, EventArgs e)
        {
            Add_Particular();
            NameBind();
            PARTICULAR_LIST("");
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

        public void PARTICULAR_LIST(string PARTICULAR_)
        {
            try
            {
                dal.ClearParameters();
                if (PARTICULAR_ == "")
                {
                    dal.AddParameter("@SUB_TYPE", "CO_PARTICULAR_LIST", "IN");
                }
                else
                {
                    dal.AddParameter("@SUB_TYPE", "CO_PARTICULAR_LIST_BYNAME", "IN");
                }

                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@PRODUCT_NAME", PARTICULAR_.Trim(), "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);

                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    grdData.Columns["ID"].Visible = grdData.Columns["BARCODE"].Visible = false;
                    grdData.DataSource = dt;
                }
                else
                {
                    dt = null;
                    grdData.DataSource = dt; 
                }

                grdData.Columns["QTY"].HeaderText = "QUANTITY";
                grdData.Columns["PARTICULAR"].Width = 260;
                grdData.Columns["MRP"].Width = 100;
                grdData.Columns["QTY"].Width = 100;
            }
            catch (Exception ex)
            {
            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SEARCH_PARTICULAR_TextChanged(object sender, EventArgs e)
        {
            PARTICULAR_LIST(SEARCH_PARTICULAR.Text.Trim());
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PRODUCT_ID.Text = grdData.CurrentRow.Cells["ID"].Value.ToString();
            BARCODE.Text = grdData.CurrentRow.Cells["BARCODE"].Value.ToString();
            PARTICULAR.Text = grdData.CurrentRow.Cells["PARTICULAR"].Value.ToString();
            AVAILABLE = Convert.ToDecimal(grdData.CurrentRow.Cells["QTY"].Value.ToString());
            QUANTITY.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PRODUCT_ID.Text == "")
            {
                MessageBox.Show("Select Product.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SEARCH_PARTICULAR.Focus();
            }
            else if (QUANTITY.Text == "")
            {
                MessageBox.Show("Enter Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QUANTITY.Focus();
            }
            else if (Convert.ToDecimal(QUANTITY.Text) <= 0)
            {
                MessageBox.Show("Enter valid Quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QUANTITY.Focus();
            }
            else
            {
                tableProduct.Rows.Add(PRODUCT_ID.Text, PARTICULAR.Text, QUANTITY.Text);
                grdOrderData.DataSource = tableProduct;
                grdOrderData.Columns["ID"].Visible = false;
                BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = PRODUCT_ID.Text = ""; AVAILABLE = 0;
                SEARCH_PARTICULAR.Focus();
                grdOrderData.Columns["PARTICULAR"].Width = 150;
                grdOrderData.Columns["QUANTITY"].Width = 100;
            }
        }

        private void QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }

        private void grdOrderData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rows = Convert.ToInt16(grdOrderData.SelectedCells[0].RowIndex);
                if (MessageBox.Show("are you sure want to remove ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    tableProduct.Rows.RemoveAt(rows);
                    grdOrderData.DataSource = tableProduct;
                    grdOrderData.Columns["PARTICULAR"].Width = 150;
                    grdOrderData.Columns["QUANTITY"].Width = 100;
                }
            }
            catch (Exception ex) { }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (grdOrderData.Rows.Count > 0)
            {
                if (Form.ModifierKeys == Keys.None && keyData == Keys.F12)
                {
                    panelPayment.Visible = true;
                    btnSubmit.Focus();
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void PARTY_NAME_TextChanged(object sender, EventArgs e)
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
                GST.Text = dt.Rows[0]["GST"].ToString();
                VENDOR_ID.Text = dt.Rows[0]["ID"].ToString();
            }
            else
            {
                MOBILE.Text = ADDRESS.Text = GST.Text = VENDOR_ID.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (grdOrderData.Rows.Count <= 0)
            {
                MessageBox.Show("Enter Product List First.",_variables.SHOP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                SEARCH_PARTICULAR.Focus();
            }
            else if (VENDOR_ID.Text == "")
            {
                MessageBox.Show("Select Vendor first.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PARTY_NAME.Focus();
            }
            else
            {
                string ORDER_ID = "";
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "COMPANY_ORDER", "IN");
                dal.AddParameter("@SUB_TYPE", "MAX_ID", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                ORDER_ID = dal.ExecuteScaler("SP_COMPANY_ORDER", ref Message).ToString();

                for (int i = 0; i < grdOrderData.Rows.Count; i++)
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "COMPANY_ORDER", "IN");
                    dal.AddParameter("@SUB_TYPE", "INSERT", "IN");
                    dal.AddParameter("@ORDER_ID", ORDER_ID, "IN");
                    dal.AddParameter("@VENDOR_ID", VENDOR_ID.Text.Trim(), "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", _variables.USER_ID.ToString(), "IN");
                    dal.AddParameter("@PRODUCT_ID", grdOrderData.Rows[i].Cells[0].Value.ToString(), "IN");
                    dal.AddParameter("@QUANTITY", grdOrderData.Rows[i].Cells[2].Value.ToString(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_COMPANY_ORDER", ref Message);
                }
                if (_result > 0)
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PARTY_NAME.Text = ADDRESS.Text = MOBILE.Text = VENDOR_ID.Text = "";
                    BARCODE.Text = PARTICULAR.Text = QUANTITY.Text = PRODUCT_ID.Text = "";
                    panelPayment.Visible = false;
                    for (int j = grdOrderData.Rows.Count; j > 0; j--)
                    {
                        grdOrderData.Rows.RemoveAt(j - 1);
                    }
                    grdOrderData.DataSource = null;

                    Bill_Rdlcs.CompanyOrderBill obj = new Bill_Rdlcs.CompanyOrderBill();
                    obj.ORDER_ID = ORDER_ID.ToString();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            VENDOR_ID.Text = ADDRESS.Text = MOBILE.Text = PARTY_NAME.Text = GST.Text = "";
            panelPayment.Visible = false;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            int rowsCount = grdData.Rows.Count;
            if (rowsCount > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "D:\\";
                saveFileDialog1.Title = "Save As Excel file";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";

                try
                {
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                        ExcelApp.Application.Workbooks.Add(Type.Missing);
                        ExcelApp.Columns.ColumnWidth = 15;
                        for (int i = 1; i < grdData.Columns.Count + 1; i++)
                        {
                            ExcelApp.Cells[1, i] = grdData.Columns[i - 1].HeaderText;
                            ExcelApp.Cells.Font.Bold = false;

                        }
                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            for (int j = 0; j < grdData.Columns.Count; j++)
                            {
                                ExcelApp.Cells[i + 2, j + 1] = grdData.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName);
                        ExcelApp.ActiveWorkbook.Saved = true;
                        ExcelApp.Quit();
                        MessageBox.Show("Excel file created,sucessfully...", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("There is no data to Download.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
