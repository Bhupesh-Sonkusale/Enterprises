using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Admin
{
    public partial class ProductMaster : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();
        public string _fileName; string chkIsEditable_ = "";

        public ProductMaster()
        {
            InitializeComponent();
        }

        #region -- Codes For Buttons

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            try
            {
                grpContent.Enabled = true;
                SAVE.Enabled = true;
                NEW.Enabled = EDIT.Enabled = DELETE.Enabled = false;
                PRODUCT_NAME.Text = SIZE.Text = PURCHASE_RATE.Text = ID.Text = MRP.Text = OTHER.Text = BARCODE.Text = HSN.Text = SEARCH_PARTICULAR.Text = MIN_QUANTITY.Text = "";
                chkIsEditable.Checked = false;
                CATEGORY.SelectedIndex = 0;
                GST.SelectedIndex = 1;
                CATEGORY.Focus();
                Show_All();
            }
            catch (Exception ex) { }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure want to delete ? [" + PRODUCT_NAME.Text.ToLower() + "]", "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Insert_Update_Delete_Product("DELETE");
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Product("INSERT");
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Product("UPDATE");
        }

        private void ProductMaster_Load(object sender, EventArgs e)
        {
            GST.SelectedIndex = 1;
            Show_All();
            Bind_Category();
        }

        public void Bind_Category()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@PAGE_NAME", "CATEG", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                CATEGORY.DisplayMember = "CATEGORY";
                CATEGORY.ValueMember = "ID";
                CATEGORY.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        public void Show_All()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "LIST_ALL", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                grdData.DataSource = dt;
                grdData.Columns[0].Visible = grdData.Columns[1].Visible = grdData.Columns[3].Visible = grdData.Columns[7].Visible = false;
                grdData.Columns[8].Visible = grdData.Columns[9].Visible = grdData.Columns[10].Visible = grdData.Columns[11].Visible = grdData.Columns[12].Visible = false;
                TOTAL_COUNT.Text = "Total : " + dt.Rows.Count;

                grdData.Columns[2].Width = 400;
                grdData.Columns[4].Width = 150;
                grdData.Columns[5].Width = 150;
                grdData.Columns[6].Width = 150;
            }
            catch (Exception ex) { }
        }

        public void Insert_Update_Delete_Product(string BUTTON_TYPE)
        {
            try
            {
                if (chkIsEditable.Checked == true)
                {
                    chkIsEditable_ = "1";
                }
                else
                {
                    chkIsEditable_ = "0";
                }

                if (CATEGORY.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Category Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CATEGORY.Focus();
                }
                else if (SIZE.Text == "")
                {
                    MessageBox.Show("Enter Size", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SIZE.Focus();
                }
                else if (MRP.Text == "")
                {
                    MessageBox.Show("Enter MRP", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MRP.Focus();
                }
                else if (SALE_RATE.Text == "")
                {
                    MessageBox.Show("Enter Sale Rate", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SALE_RATE.Focus();
                }
                else if (PURCHASE_RATE.Text == "")
                {
                    MessageBox.Show("Enter Purchase Rate", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PURCHASE_RATE.Focus();
                }
                else if (PRODUCT_NAME.Text == "")
                {
                    MessageBox.Show("Enter Product Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PRODUCT_NAME.Focus();
                }
                //else if (HSN.Text == "")
                //{
                //    MessageBox.Show("Enter Product HSN Code", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    HSN.Focus();
                //}
                else if (GST.SelectedIndex == 0)
                {
                    MessageBox.Show("Enter GST", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GST.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                    dal.AddParameter("@ID", string.IsNullOrEmpty(ID.Text) ? "0" : ID.Text, "IN");
                    dal.AddParameter("@BARCODE", string.IsNullOrEmpty(BARCODE.Text) ? "" : BARCODE.Text, "IN");
                    dal.AddParameter("@NAME_1", CATEGORY.SelectedValue.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@NAME_2", "".Trim(), "IN");
                    dal.AddParameter("@PRODUCT_NAME", PRODUCT_NAME.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@OTHER", OTHER.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@SIZE", SIZE.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@HSN", HSN.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@GST", GST.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@MRP", MRP.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@SALE_RATE", SALE_RATE.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@PURCHASE_RATE", PURCHASE_RATE.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@MIN_QUANTITY", MIN_QUANTITY.Text.Trim(), "IN");
                    dal.AddParameter("@CHKISEDITABLE", chkIsEditable_, "IN");
                    dal.AddParameter("@IMAGE_URL", "", "IN");
                    dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                    dal.AddParameter("@SUB_TYPE", BUTTON_TYPE, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_MASTER_TABLE", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            PRODUCT_NAME.Text = SIZE.Text = PURCHASE_RATE.Text = ID.Text = MRP.Text = OTHER.Text = BARCODE.Text = HSN.Text = SEARCH_PARTICULAR.Text = MIN_QUANTITY.Text = "";
            chkIsEditable.Checked = false;
            CATEGORY.SelectedValue = 0;
            CATEGORY.Focus();
            Show_All();
            NEW.PerformClick(); GST.SelectedIndex = 1;
        }

        private void SIZE_TextChanged(object sender, EventArgs e)
        {
            string CATEGORY_ = CATEGORY.Text;
            string SIZE_ = SIZE.Text;
            string OTHER_ = OTHER.Text;
            PRODUCT_NAME.Text = CATEGORY_ + " " + OTHER_ + " " + SIZE_;
        }

        private void MRP_TextChanged(object sender, EventArgs e)
        {
            PURCHASE_RATE.Text = SALE_RATE.Text = MRP.Text.ToString();
        }

        private void SEARCH_PARTICULAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "LIST_ALL_BY_PRODUCT", "IN");
                dal.AddParameter("@PRODUCT_NAME", SEARCH_PARTICULAR.Text.Trim(), "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                grdData.DataSource = dt;
                grdData.Columns[0].Visible = grdData.Columns[1].Visible = grdData.Columns[3].Visible = grdData.Columns[7].Visible = false;
                grdData.Columns[8].Visible = grdData.Columns[9].Visible = grdData.Columns[10].Visible = grdData.Columns[11].Visible = grdData.Columns[12].Visible = false;
                TOTAL_COUNT.Text = "Total : " + dt.Rows.Count;

                grdData.Columns[2].Width = 400;
                grdData.Columns[4].Width = 150;
                grdData.Columns[5].Width = 150;
                grdData.Columns[6].Width = 150;
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Codes For GridView

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID.Text = grdData.CurrentRow.Cells[0].Value.ToString().Trim();
                CATEGORY.Text = grdData.CurrentRow.Cells[1].Value.ToString().Trim();
                PRODUCT_NAME.Text = grdData.CurrentRow.Cells[2].Value.ToString().Trim();
                SIZE.Text = grdData.CurrentRow.Cells[3].Value.ToString().Trim();
                MRP.Text = grdData.CurrentRow.Cells[4].Value.ToString().Trim();
                SALE_RATE.Text = grdData.CurrentRow.Cells[5].Value.ToString().Trim();
                PURCHASE_RATE.Text = grdData.CurrentRow.Cells[6].Value.ToString().Trim();
                OTHER.Text = grdData.CurrentRow.Cells[7].Value.ToString().Trim();
                BARCODE.Text = grdData.CurrentRow.Cells[8].Value.ToString().Trim();
                HSN.Text = grdData.CurrentRow.Cells[11].Value.ToString().Trim();
                GST.Text = grdData.CurrentRow.Cells[10].Value.ToString().Trim();
                PRODUCT_NAME.Text = grdData.CurrentRow.Cells[2].Value.ToString().Trim();
                chkIsEditable_ = grdData.CurrentRow.Cells[9].Value.ToString().Trim();
                MIN_QUANTITY.Text = grdData.CurrentRow.Cells[12].Value.ToString().Trim();

                if (chkIsEditable_ == "1")
                {
                    chkIsEditable.Checked = true;
                }
                else if (chkIsEditable_ == "0")
                {
                    chkIsEditable.Checked = false;
                }
                grpContent.Enabled = EDIT.Enabled = DELETE.Enabled = NEW.Enabled = true;
                SAVE.Enabled = false;
                grpContent.Enabled = NEW.Enabled = true;
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Code For Value Enter into TextBox

        private void MRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For Value Enter into TextBox

    }
}
