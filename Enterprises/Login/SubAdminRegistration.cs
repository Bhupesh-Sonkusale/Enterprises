using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Login
{
    public partial class SubAdminRegistration : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL(); public string USER_ID;
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();
        string JOIN_DATE_ = "";

        public SubAdminRegistration()
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
                ID.Text = NAME.Text = MOBILE.Text = ADDRESS.Text = USER_NAME.Text = PASSWORD.Text = "";
                SALARY.Text = ADHAR_CARD.Text = PAN_CARD.Text = "";
                JOIN_DATE.Text = DateTime.Now.ToShortDateString();
                NAME.Focus();
                Show_All();
            }
            catch (Exception ex) { }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure want to delete ? [" + NAME.Text.ToLower() + "]", "Sub Admin Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void SubAdminRegistration_Load(object sender, EventArgs e)
        {
            JOIN_DATE.MaxDate = DateTime.Now;
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
                dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
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
                grdData.Columns["ID"].Visible = grdData.Columns["ADDRESS"].Visible = grdData.Columns["PASSWORD"].Visible = grdData.Columns["USER_NAME"].Visible = false;
                grdData.Columns["SALARY"].Visible = grdData.Columns["JOIN_DATE"].Visible = false;
                grdData.Columns["IS_LOGIN"].Visible = grdData.Columns["COMMISION"].Visible = grdData.Columns["SHOPPEE_NAME"].Visible = grdData.Columns["GST"].Visible = false;
                grdData.Columns["GST_NUMBER"].Visible = grdData.Columns["DL_NUMBER"].Visible = grdData.Columns["EMAIL"].Visible = grdData.Columns["PER_DAY"].Visible = false;

            }
            catch (Exception ex) { }
        }

        public void Insert_Update_Delete_Registration(string BUTTON_TYPE)
        {
            try
            {
                DateFormats _dates = new DateFormats();
                string JOIN_DATE_ = "";
                DateTime d;
                bool chValidity_1 = DateTime.TryParseExact(JOIN_DATE.Text.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                bool chValidity_2 = DateTime.TryParseExact(JOIN_DATE.Text.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                if (chValidity_1 == true)
                {
                    JOIN_DATE_ = _dates.DateCvtoyymmdd(JOIN_DATE.Text.ToString());
                }
                else if (chValidity_2 == true)
                {
                    JOIN_DATE_ = JOIN_DATE.Text.ToString();
                }

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
                else if (ADDRESS.Text == "")
                {
                    MessageBox.Show("Enter Addrss", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADDRESS.Focus();
                }
                else if (USER_NAME.Text == "")
                {
                    MessageBox.Show("Enter User-Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    USER_NAME.Focus();
                }
                else if (PASSWORD.Text == "")
                {
                    MessageBox.Show("Enter Password", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PASSWORD.Focus();
                }
                else if (SALARY.Text == "" || SALARY.Text == "0")
                {
                    MessageBox.Show("Enter Salary", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SALARY.Focus();
                }
                //else if (PAN_CARD.Text == "")
                //{
                //    MessageBox.Show("Enter Pan Card", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    PAN_CARD.Focus();
                //}
                //else if (PAN_CARD.Text.Trim().Length != 10)
                //{
                //    MessageBox.Show("In valid Pan Card", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    PAN_CARD.Focus();
                //}
                //else if (ADHAR_CARD.Text == "")
                //{
                //    MessageBox.Show("Enter Adhar Card", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ADHAR_CARD.Focus();
                //}
                //else if (ADHAR_CARD.Text.Trim().Length != 12)
                //{
                //    MessageBox.Show("In valid Adhar Card", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ADHAR_CARD.Focus();
                //}
                else if (PER_DAY.Text == "")
                {
                    MessageBox.Show("Enter Per Day Rs", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PER_DAY.Focus();
                }
                else if (Convert.ToDecimal(PER_DAY.Text) <= 0)
                {
                    MessageBox.Show("Enter Per Day Rs", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PER_DAY.Focus();
                }

                else
                {
                    string IS_LOGIN_ = "0";
                    if (IS_LOGIN.Checked == true)
                    {
                        IS_LOGIN_ = "1";
                    }
                    else
                    {
                        IS_LOGIN_ = "0";
                    }
                    dal.ClearParameters();
                    dal.AddParameter("@ID", ID.Text, "IN");
                    dal.AddParameter("@SUB_TYPE", BUTTON_TYPE, "IN");
                    dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                    dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@USER_ID", USER_ID, "IN");
                    dal.AddParameter("@USER_NAME", USER_NAME.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@PASSWORD", PASSWORD.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@NAME", NAME.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@ADDRESS", ADDRESS.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@JOIN_DATE", JOIN_DATE_, "IN");
                    dal.AddParameter("@SALARY", SALARY.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@PER_DAY", PER_DAY.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@PAN_CARD", PAN_CARD.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@ADHAR_CARD", ADHAR_CARD.Text.ToString().Trim(), "IN");
                    dal.AddParameter("@IS_LOGIN", IS_LOGIN_, "IN");
                    dal.AddParameter("@COMMISION", COMMISION.Text.Trim(), "IN");
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
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            ID.Text = NAME.Text = MOBILE.Text = ADDRESS.Text = USER_NAME.Text = PASSWORD.Text = COMMISION.Text = "";
            SALARY.Text = ADHAR_CARD.Text = PAN_CARD.Text = "";
            IS_LOGIN.Checked = false;
            Show_All();
            NEW.PerformClick();
            NAME.Focus();
        }

        #endregion

        #region -- Codes For GridView

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID.Text = grdData.CurrentRow.Cells["ID"].Value.ToString();
                NAME.Text = grdData.CurrentRow.Cells["NAME"].Value.ToString();
                MOBILE.Text = grdData.CurrentRow.Cells["MOBILE"].Value.ToString();
                ADDRESS.Text = grdData.CurrentRow.Cells["ADDRESS"].Value.ToString();
                USER_NAME.Text = grdData.CurrentRow.Cells["USER_NAME"].Value.ToString();
                PASSWORD.Text = grdData.CurrentRow.Cells["PASSWORD"].Value.ToString();
                JOIN_DATE.Text = grdData.CurrentRow.Cells["JOIN_DATE"].Value.ToString();
                SALARY.Text = grdData.CurrentRow.Cells["SALARY"].Value.ToString();
                PAN_CARD.Text = grdData.CurrentRow.Cells[7].Value.ToString();
                ADHAR_CARD.Text = grdData.CurrentRow.Cells[8].Value.ToString();
                PER_DAY.Text = grdData.CurrentRow.Cells["PER_DAY"].Value.ToString();
                string IS_LOGIN_ = grdData.CurrentRow.Cells["IS_LOGIN"].Value.ToString();
                if (IS_LOGIN_ == "1")
                {
                    IS_LOGIN.Checked = true;
                }
                else
                {
                    IS_LOGIN.Checked = false;
                }
                COMMISION.Text = grdData.CurrentRow.Cells["COMMISION"].Value.ToString();
                grpContent.Enabled = EDIT.Enabled = DELETE.Enabled = NEW.Enabled = true;
                SAVE.Enabled = false;
                grpContent.Enabled = NEW.Enabled = true;
            }
            catch (Exception ex) { }
        }

        #endregion

        #region -- Code For change Text Box with Validation

        private void MOBILE_TextChanged(object sender, EventArgs e)
        {
            USER_NAME.Text = PASSWORD.Text = MOBILE.Text.ToString();
        }

        private void MOBILE_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);

        }

        private void NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
        }

        private void SALARY_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation

        private void SALARY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SALARY.Text.Trim() != "")
                {
                    decimal SALARY_ = Convert.ToDecimal(SALARY.Text.Trim());
                    if (SALARY_ > 0)
                    {
                        PER_DAY.Text = Math.Round(SALARY_ / 30).ToString();
                    }
                    else
                    {
                        PER_DAY.Text = "";
                    }
                }
                else
                {
                    PER_DAY.Text = "";
                }
            }
            catch (Exception ex) { }
        }

    }
}
