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
    public partial class Change_Password : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL();
        DateTime End_Date; Validation _validation = new Validation();
        Shop_Detail _variables = new Shop_Detail();

        public Change_Password()
        {
            InitializeComponent();
        }

        private void btnChnage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter Password", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                //else if (txtPassword.Text.Length != 10)
                //{
                //    MessageBox.Show("Enter Password ( Length is 10 )", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtPassword.Focus();
                //}
                else if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Enter New Password", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewPassword.Focus();
                }
                //else if (txtNewPassword.Text.Length != 10)
                //{
                //    MessageBox.Show("Enter New Password ( Length is 10 )", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtNewPassword.Focus();
                //}
                else if (txtReEnterNewPassword.Text == "")
                {
                    MessageBox.Show("Enter Re-Enter New Password", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReEnterNewPassword.Focus();
                }
                //else if (txtReEnterNewPassword.Text.Length != 10)
                //{
                //    MessageBox.Show("Enter Re-Enter New Password ( Length is 10 )", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtReEnterNewPassword.Focus();
                //}
                else if (txtReEnterNewPassword.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("Confirm Password cant Match With Password.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReEnterNewPassword.Clear();
                    txtReEnterNewPassword.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                    dal.AddParameter("@SUB_TYPE", "CHANGE_PASSWORD", "IN");
                    dal.AddParameter("@USER_NAME", txtUserName.Text.Trim(), "IN");
                    dal.AddParameter("@PASSWORD", txtPassword.Text.Trim(), "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@NEW_PASSWORD", txtNewPassword.Text.Trim(), "IN");
                    dal.AddParameter("@RETURN_MSG", "RETURN_MSG", "OUT");
                    _result = dal.ExecuteNonQuery("SP_REGISTRATION", ref Message);

                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPassword.Text = txtPassword.Text = txtReEnterNewPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtReEnterNewPassword.Focus();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #region -- Code For change Text Box with Validation

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion -- Code For change Text Box with Validation

    }
}
