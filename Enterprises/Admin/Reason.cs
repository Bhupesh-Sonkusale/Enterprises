using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Admin
{
    public partial class Reason : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        string PAGE_NAME = "REASO";

        public Reason()
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
                CATEGORY.Text = ID.Text = "";
                CATEGORY.Focus();
                Show_All();
            }
            catch (Exception ex) { }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure want to delete ? [" + CATEGORY.Text.ToLower() + "]", "Expense Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Insert_Update_Delete_Expense("DELETE");
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Expense("INSERT");
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Expense("UPDATE");
        }

        private void Reason_Load(object sender, EventArgs e)
        {
            Show_All();
        }

        public void Show_All()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
                dal.AddParameter("@SUB_TYPE", "LIST_ALL", "IN");
                dal.AddParameter("@PAGE_NAME", PAGE_NAME, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                grdData.DataSource = dt;
                grdData.Columns["ID"].Visible = false;
                TOTAL_COUNT.Text = "Total : " + dt.Rows.Count;
            }
            catch (Exception ex) { }
        }

        public void Insert_Update_Delete_Expense(string BUTTON_TYPE)
        {
            try
            {
                if (CATEGORY.Text == "")
                {
                    MessageBox.Show("Enter Cancel Reason Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CATEGORY.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID.ToString(), "IN");
                    dal.AddParameter("@PAGE_NAME", PAGE_NAME, "IN");
                    dal.AddParameter("@ID", string.IsNullOrEmpty(ID.Text) ? "0" : ID.Text, "IN");
                    dal.AddParameter("@NAME_1", CATEGORY.Text.ToString().ToUpper().Trim(), "IN");
                    dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
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
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            ID.Text = CATEGORY.Text = string.Empty;
            Show_All();
            NEW.PerformClick();
            CATEGORY.Focus();
        }
        #endregion

        #region -- Codes For GridView

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID.Text = grdData.CurrentRow.Cells["ID"].Value.ToString().Trim();
                CATEGORY.Text = grdData.CurrentRow.Cells["REASON"].Value.ToString().Trim();
                grpContent.Enabled = EDIT.Enabled = DELETE.Enabled = NEW.Enabled = true;
                SAVE.Enabled = false;
                grpContent.Enabled = NEW.Enabled = true;
                CATEGORY.Focus();
            }
            catch (Exception ex) { }
        }
        #endregion

    }
}
