using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Login
{
    public partial class Customer : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();

        public Customer()
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
            grpContent.Enabled = true;
            SAVE.Enabled = true;
            NEW.Enabled = EDIT.Enabled = DELETE.Enabled = false;
            ID.Text = NAME.Text = MOBILE.Text = EMAIL.Text = SEARCH_NAME_MOBILE.Text = GST_NUMBER.Text = "";
            ADDRESS.Text = "Nagpur";
            NAME.Focus();
            Show_All();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure want to delete ? [" + NAME.Text.ToLower() + "]", "Customer Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Insert_Update_Delete_Registration("DELETE");
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Registration("INSERT");
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            Insert_Update_Delete_Registration("UPDATE");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            NEW.Focus();
            Show_All();
        }

        public void Show_All()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "LIST_ALL", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@MEMBER_TYPE", "C", "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                GridDesign();
            }
            catch (Exception ex) { }
        }

        public void GridDesign()
        {
            if (dt.Rows.Count > 0)
            {
                grdData.DataSource = dt;
                TOTAL_COUNT.Text = "Total : " + dt.Rows.Count;
            }
            else
            {
                dt = null;
                grdData.DataSource = dt;
                TOTAL_COUNT.Text = "Total : 0";
            }
            grdData.Columns[0].Visible = grdData.Columns[3].Visible = grdData.Columns[4].Visible = grdData.Columns[5].Visible = false;
            grdData.Columns[6].Visible = grdData.Columns[7].Visible = grdData.Columns[8].Visible = grdData.Columns[9].Visible = false;
            grdData.Columns[10].Visible = grdData.Columns[11].Visible = grdData.Columns[12].Visible = false;
            grdData.Columns[13].Visible = grdData.Columns[14].Visible = grdData.Columns[15].Visible = grdData.Columns[16].Visible = grdData.Columns[17].Visible = false;
            grdData.Columns[1].Width = 400;
            grdData.Columns[2].Width = 250;
        }

        public void Insert_Update_Delete_Registration(string BUTTON_TYPE)
        {
            if (NAME.Text == "")
            {
                MessageBox.Show("Enter Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                NAME.Focus();
            }
            else if (MOBILE.Text == "")
            {
                MessageBox.Show("Enter Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MOBILE.Focus();
            }
            else if (MOBILE.Text.Length != 10)
            {
                MessageBox.Show("Invalid Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MOBILE.Focus();
            }
            //else if (ADDRESS.Text == "")
            //{
            //    MessageBox.Show("Enter Addrss", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    ADDRESS.Focus();
            //}
            else
            {
                dal.ClearParameters();
                dal.AddParameter("@ID", ID.Text, "IN");
                dal.AddParameter("@SUB_TYPE", BUTTON_TYPE, "IN");
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@MEMBER_TYPE", "C", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@USER_ID", USER_ID, "IN");
                dal.AddParameter("@USER_NAME", MOBILE.Text, "IN");
                dal.AddParameter("@PASSWORD", MOBILE.Text, "IN");
                dal.AddParameter("@NAME", NAME.Text, "IN");
                dal.AddParameter("@MOBILE", MOBILE.Text, "IN");
                dal.AddParameter("@ADDRESS", ADDRESS.Text, "IN");
                dal.AddParameter("@EMAIL", EMAIL.Text, "IN");
                dal.AddParameter("@JOIN_DATE", "", "IN");
                dal.AddParameter("@SALARY", "0", "IN");
                dal.AddParameter("@PAN_CARD", "", "IN");
                dal.AddParameter("@ADHAR_CARD", "", "IN");
                dal.AddParameter("@GST_NUMBER", GST_NUMBER.Text.ToUpper().Trim(), "IN");
                dal.AddParameter("@DL_NUMBER", DL_NUMBER.Text.ToUpper().Trim(), "IN");
                dal.AddParameter("@RETURN_MSG", "RETURN_MSG", "OUT");
                _result = dal.ExecuteNonQuery("SP_REGISTRATION", ref Message);
                if (_result > 0)
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Show_All();
            }
        }

        public void ClearAll()
        {
            ID.Text = NAME.Text = MOBILE.Text = SEARCH_NAME_MOBILE.Text = GST_NUMBER.Text = DL_NUMBER.Text = EMAIL.Text = "";
            Show_All();
            NEW.PerformClick();
            NAME.Focus();
        }

        private void SEARCH_NAME_MOBILE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "SEARCH_NAME_MOBILE", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@NAME", SEARCH_NAME_MOBILE.Text.Trim(), "IN");
                dal.AddParameter("@MEMBER_TYPE", "C", "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                GridDesign();
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Codes For GridView

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ID.Text = grdData.CurrentRow.Cells["ID"].Value.ToString().Trim();
            NAME.Text = grdData.CurrentRow.Cells["NAME"].Value.ToString().Trim();
            MOBILE.Text = grdData.CurrentRow.Cells["MOBILE"].Value.ToString().Trim();
            ADDRESS.Text = grdData.CurrentRow.Cells["ADDRESS"].Value.ToString().Trim();
            GST_NUMBER.Text = grdData.CurrentRow.Cells["GST_NUMBER"].Value.ToString().Trim();
            DL_NUMBER.Text = grdData.CurrentRow.Cells["DL_NUMBER"].Value.ToString().Trim();
            EMAIL.Text = grdData.CurrentRow.Cells["EMAIL"].Value.ToString().Trim();

            grpContent.Enabled = EDIT.Enabled = DELETE.Enabled = NEW.Enabled = true;
            SAVE.Enabled = false;
            grpContent.Enabled = NEW.Enabled = true;
            NAME.Focus();
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

        private void NO_Space_Validate(object sender, KeyPressEventArgs e)
        {
            _validation.NoSpaceValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Show_All();
            foreach (Control ctrl in grpContent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            SEARCH_NAME_MOBILE.Text = "";
            ADDRESS.Text = "Nagpur";
        }

    }
}
