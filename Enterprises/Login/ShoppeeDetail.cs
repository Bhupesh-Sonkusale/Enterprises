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
    public partial class ShoppeeDetail : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0; bool FINANCIAL_STATUS_;
        DAL dal = new DAL(); Validation _validation = new Validation();
        Shop_Detail _variables = new Shop_Detail();

        public ShoppeeDetail()
        {
            InitializeComponent();
        }

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

        private void ShoppeeDetail_Load(object sender, EventArgs e)
        {
            Show_Detail();
        }

        public void Show_Detail()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SHOP_REGISTER", "IN");
                dal.AddParameter("@SUB_TYPE", "SHOP_DETAIL", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@SHOP_ID", _variables.SHOP_ID, "IN");
                dt = dal.GetTable("SP_SHOP_REGISTER", ref Message);
                if (dt.Rows.Count > 0)
                {
                    BRANCH_ID.Text = dt.Rows[0]["BRANCH_ID"].ToString().Trim();
                    SHOP_ID.Text = dt.Rows[0]["SHOP_ID"].ToString().ToUpper();
                    SHOP_NAME.Text = dt.Rows[0]["SHOP_NAME"].ToString().Trim();
                    GST_IN.Text = dt.Rows[0]["GST_IN"].ToString().ToUpper().Trim();
                    BANKNAME.Text = dt.Rows[0]["BANKNAME"].ToString().ToUpper().Trim();
                    ACCOUNTNUMBER.Text = dt.Rows[0]["ACCOUNTNUMBER"].ToString().ToUpper().Trim();
                    IFSC.Text = dt.Rows[0]["IFSC"].ToString().ToUpper().Trim();
                    MOBILE.Text = dt.Rows[0]["MOBILE"].ToString().Trim();
                    LANDLINE.Text = dt.Rows[0]["LANDLINE"].ToString().Trim();
                    ADDRESS.Text = dt.Rows[0]["ADDRESS"].ToString().Trim();
                    ADDRESS_2.Text = dt.Rows[0]["ADDRESS_2"].ToString().Trim();
                    GSTPER.Text = dt.Rows[0]["GSTPER"].ToString().Trim();
                    OWNER_NAME.Text = dt.Rows[0]["OWNER_NAME"].ToString().Trim();
                    EMAIL.Text = dt.Rows[0]["EMAIL"].ToString().Trim();
                    PASSWORD.Text = dt.Rows[0]["PASSWORD"].ToString().Trim();
                    CREATE_DATE.Text = dt.Rows[0]["CREATE_DATE"].ToString();
                    EXPIRED_DATE.Text = dt.Rows[0]["EXPIRED_DATE"].ToString();
                    CANCEL_BILL_IN_DAYS.Text = dt.Rows[0]["CANCEL_BILL_IN_DAYS"].ToString();
                    BILL_LABLE.Text = dt.Rows[0]["BILL_LABLE"].ToString();
                    SIGN_NAME.Text = dt.Rows[0]["SIGN_NAME"].ToString();
                    BILL_TITLE.Text = dt.Rows[0]["BILL_TITLE"].ToString();
                    NOTE_1.Text = dt.Rows[0]["NOTE_1"].ToString();
                    NOTE_2.Text = dt.Rows[0]["NOTE_2"].ToString();
                    NOTE_3.Text = dt.Rows[0]["NOTE_3"].ToString();
                    NOTE_4.Text = dt.Rows[0]["NOTE_4"].ToString();
                    NO_OF_PRINT.Text = dt.Rows[0]["NO_OF_PRINT"].ToString();
                    FINANCIAL_STATUS_ = Convert.ToBoolean(dt.Rows[0]["FINANCIAL_STATUS"]);
                    if (FINANCIAL_STATUS_ == true)
                    {
                        FINANCIAL_STATUS.Checked = false;
                    }
                    else
                    {
                        FINANCIAL_STATUS.Checked = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (SHOP_NAME.Text == "")
                {
                    MessageBox.Show("Enter Shoppee Name",_variables.SHOP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    SHOP_NAME.Focus();
                }
                else if (MOBILE.Text == "")
                {
                    MessageBox.Show("Enter Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MOBILE.Focus();
                }
                else if (MOBILE.Text.Length != 10)
                {
                    MessageBox.Show("Enter Valid Mobile", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MOBILE.Focus();
                }
                else if (GST_IN.Text == "")
                {
                    MessageBox.Show("Enter Shoppee GST-IN", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GST_IN.Focus();
                }
                else if (ADDRESS.Text == "")
                {
                    MessageBox.Show("Enter Address Line 1", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADDRESS.Focus();
                }
                else if (ADDRESS_2.Text == "")
                {
                    MessageBox.Show("Enter Address Line 2", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADDRESS_2.Focus();
                }
                else if (OWNER_NAME.Text == "")
                {
                    MessageBox.Show("Enter Owner Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OWNER_NAME.Focus();
                }
                else if (BILL_LABLE.Text == "")
                {
                    MessageBox.Show("Enter Bill Label", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OWNER_NAME.Focus();
                }
                else if (SIGN_NAME.Text == "")
                {
                    MessageBox.Show("Enter Sign Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SIGN_NAME.Focus();
                }
                else if (BILL_TITLE.Text == "")
                {
                    MessageBox.Show("Enter Bill Title", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BILL_TITLE.Focus();
                }
                else if (NO_OF_PRINT.Text == "")
                {
                    MessageBox.Show("Enter No. of Print bill", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NO_OF_PRINT.Focus();
                }
                else
                {
                    if (FINANCIAL_STATUS.Checked == true)
                    {
                        FINANCIAL_STATUS_ = false;
                    }
                    else
                    {
                        FINANCIAL_STATUS_ = true;
                    }
                    dt = new DataTable();
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SHOP_REGISTER", "IN");
                    dal.AddParameter("@SUB_TYPE", "UPDATE", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@SHOP_ID", _variables.SHOP_ID, "IN");
                    dal.AddParameter("@SHOP_NAME", SHOP_NAME.Text, "IN");
                    dal.AddParameter("@GST_IN", GST_IN.Text, "IN");
                    dal.AddParameter("@FOOD_LIC_NO", "0", "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text, "IN");
                    dal.AddParameter("@LANDLINE", LANDLINE.Text, "IN");
                    dal.AddParameter("@ADDRESS", ADDRESS.Text, "IN");
                    dal.AddParameter("@ADDRESS_2", ADDRESS_2.Text, "IN");
                    dal.AddParameter("@GSTPER", GSTPER.Text, "IN");
                    dal.AddParameter("@OWNER_NAME", OWNER_NAME.Text, "IN");
                    dal.AddParameter("@EMAIL", EMAIL.Text, "IN");
                    dal.AddParameter("@PASSWORD", PASSWORD.Text, "IN");
                    dal.AddParameter("@SIGN_NAME", SIGN_NAME.Text.Trim(), "IN");
                    dal.AddParameter("@AMOUNT", AMOUNT.Text.Trim(), "IN");
                    dal.AddParameter("@CANCEL_BILL_IN_DAYS", CANCEL_BILL_IN_DAYS.Text.Trim(), "IN");
                    dal.AddParameter("@BANKNAME", BANKNAME.Text.Trim(), "IN");
                    dal.AddParameter("@ACCOUNTNUMBER", ACCOUNTNUMBER.Text.Trim(), "IN");
                    dal.AddParameter("@IFSC", IFSC.Text.Trim(), "IN");
                    dal.AddParameter("@BILL_LABLE", BILL_LABLE.Text.Trim(), "IN");
                    dal.AddParameter("@BILL_TITLE", BILL_TITLE.Text.Trim(), "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS_, "IN");
                    dal.AddParameter("@NOTE_1", NOTE_1.Text.Trim(), "IN");
                    dal.AddParameter("@NOTE_2", NOTE_2.Text.Trim(), "IN");
                    dal.AddParameter("@NOTE_3", NOTE_3.Text.Trim(), "IN");
                    dal.AddParameter("@NOTE_4", NOTE_4.Text.Trim(), "IN");
                    dal.AddParameter("@NO_OF_PRINT", NO_OF_PRINT.Text.Trim(), "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_SHOP_REGISTER", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter + ", Please restart the software." , _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        #region -- Code For change Text Box with Validation

        private void Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.NoSpaceValidation(sender, e);
        }

        private void NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
        }

        private void CASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyAmountValidation(sender, e);
        }

        private void NO_Space_Validate(object sender, KeyPressEventArgs e)
        {
            _validation.NoSpaceValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation
    }
}
