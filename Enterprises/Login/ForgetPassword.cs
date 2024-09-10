using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Login
{
    public partial class ForgetPassword : Form
    {
        Validation _validation = new Validation();
        string Message = "";
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();

        public ForgetPassword()
        {
            InitializeComponent();
        }

        #region -- Code For Button

        private void backtoLogin_Click(object sender, EventArgs e)
        {
            Login.Log_in da = new Login.Log_in();
            this.Hide();
            da.ShowDialog();
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string MEMBER_TYPE = "";
                if (NAME.Text == "")
                {
                    MessageBox.Show("Error : Name field cant be empty.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NAME.Focus();
                }
                else if (MOBILE.Text == "")
                {
                    MessageBox.Show("Error : Mobile field cant be empty.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MOBILE.Focus();
                }
                else if (MOBILE.Text.Trim().Length != 10)
                {
                    MessageBox.Show("Error : Invalid Mobile Number.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MOBILE.Focus();
                }
                else if (USER_NAME.Text == "")
                {
                    MessageBox.Show("Error : Username field cant be empty.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    USER_NAME.Focus();
                }
                else
                {
                    if (rdoAdmin.Checked == true)
                    {
                        MEMBER_TYPE = "A";
                    }
                    else if (rdoEmployee.Checked == true)
                    {
                        MEMBER_TYPE = "E";
                    }

                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                    dal.AddParameter("@SUB_TYPE", "FORGET_PASSWORD", "IN");
                    dal.AddParameter("@NAME", NAME.Text, "IN");
                    dal.AddParameter("@MOBILE", MOBILE.Text, "IN");
                    dal.AddParameter("@USER_NAME", USER_NAME.Text, "IN");
                    dal.AddParameter("@MEMBER_TYPE", MEMBER_TYPE, "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    string Result = dal.ExecuteScaler("SP_REGISTRATION", ref Message).ToString();
                    if (Result == "Invalid Credintials ! Try again.")
                    {
                        MessageBox.Show(Result, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Result, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { }
        }

        #endregion -- Code For Button

        #region -- Code For change Text Box with Validation

        private void NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
        }

        private void MOBILE_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }

        #endregion -- Code For change Text Box with Validation
    }
}
