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
    public partial class GodownCounter : Form
    {
        DataTable dt; int _result;
        string Message = "";
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();

        public GodownCounter()
        {
            InitializeComponent();
        }

        #region -- Code For Godown to Counter

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void GodownCounter_Load(object sender, EventArgs e)
        {
            Show_List();
        }

        public void Show_List()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "STOCK_REPORT", "IN");
                dal.AddParameter("@NAME_1", "0", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                }
                else
                {
                    grdData.DataSource = dt;
                }
                GridWidth();
            }
            catch (Exception ex) { }
        }

        private void PRODUCT_NAME_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "PRODUCT_NAME_STOCK", "IN");
                dal.AddParameter("@PRODUCT_NAME", PRODUCT_NAME.Text, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                }
                else
                {
                    grdData.DataSource = dt;
                }
                GridWidth();
            }
            catch (Exception ex) { }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                PRODUCT_ID.Text = grdData.CurrentRow.Cells[0].Value.ToString();
                BARCODE.Text = grdData.CurrentRow.Cells[1].Value.ToString();
                PARTICULAR.Text = grdData.CurrentRow.Cells["PARTICULAR"].Value.ToString();
                GODOWN_QUANTITY.Text = GODOWN_QUANTITY_.Text = grdData.CurrentRow.Cells["GODOWN_QUANTITY"].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PRODUCT_ID.Text = PRODUCT_NAME.Text = BARCODE.Text = GODOWN_QUANTITY.Text = PARTICULAR.Text = GODOWN_QUANTITY_.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string _GODOWN_QUANTITY, _GODOWN_QUANTITY_;
                if (string.IsNullOrEmpty(GODOWN_QUANTITY.Text)) { _GODOWN_QUANTITY = "0"; } else { _GODOWN_QUANTITY = GODOWN_QUANTITY.Text; }
                if (string.IsNullOrEmpty(GODOWN_QUANTITY_.Text)) { _GODOWN_QUANTITY_ = "0"; } else { _GODOWN_QUANTITY_ = GODOWN_QUANTITY_.Text; }

                if (PRODUCT_ID.Text == "")
                {
                    MessageBox.Show("Select Product first.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GODOWN_QUANTITY.Focus();
                }
                else if (GODOWN_QUANTITY.Text == "")
                {
                    MessageBox.Show("Enter Transfer quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GODOWN_QUANTITY.Focus();
                }
                else if (Convert.ToInt16(GODOWN_QUANTITY.Text) <= 0)
                {
                    MessageBox.Show("Enter Transfer quantity.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GODOWN_QUANTITY.Focus();
                }
                else if (Convert.ToInt16(_GODOWN_QUANTITY) > Convert.ToInt16(_GODOWN_QUANTITY_))
                {
                    MessageBox.Show("Check Quantity first", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GODOWN_QUANTITY.Focus();
                }
                //else if (Convert.ToInt16(GODOWN_QUANTITY.Text) > Convert.ToInt16(GODOWN_QUANTITY_.Text))
                //{
                //    MessageBox.Show("Check Quantity first", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    GODOWN_QUANTITY.Focus();
                //}
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "PURCHASE", "IN");
                    dal.AddParameter("@SUB_TYPE", "TRANSFER_QTY", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@ID", PRODUCT_ID.Text, "IN");
                    dal.AddParameter("@BARCODE", BARCODE.Text, "IN");
                    dal.AddParameter("@PRODUCT_NAME", PARTICULAR.Text, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    dal.AddParameter("@GODOWN_QUANTITY", GODOWN_QUANTITY.Text, "IN");
                    if (MessageBox.Show("are you sure want to transfer quantity ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _result = dal.ExecuteNonQuery("SP_PURCHASE", ref Message);
                        if (_result > 0)
                        {
                            MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Show_List();
                            PRODUCT_ID.Text = PRODUCT_NAME.Text = GODOWN_QUANTITY_.Text = BARCODE.Text = GODOWN_QUANTITY.Text = PARTICULAR.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void GridWidth()
        {
            try
            {
                grdData.Columns[2].Width = 500;
                grdData.Columns[3].Width = 150;
                grdData.Columns[4].Width = 150;
                grdData.Columns[5].Width = 200;
                grdData.Columns[0].Visible = grdData.Columns[1].Visible = false;
                grdData.Columns["QUANTITY"].HeaderText = "COUNTER QUANTITY";
                grdData.Columns["GODOWN_QUANTITY"].HeaderText = "GODOWN QUANTITY";
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion -- Code For Godown to Counter

        private void MOBILE_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }
    }
}
