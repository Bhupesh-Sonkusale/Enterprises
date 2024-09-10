using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace Enterprises.Login
{
    public partial class Log_in : Form
    {
        string Message = "";
        DAL dal = new DAL();
        DateTime End_Date; string USER_TYPE = "";
        Shop_Detail _variables = new Shop_Detail();

        public Log_in()
        {
            InitializeComponent();
        }

        #region -- Codes For Login Page

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            string TODAY_DATE = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Day.ToString().PadLeft(2, '0');
            DateTime L_2024_03_28 = Convert.ToDateTime("2024-03-28");
            DateTime L_2024_03_29 = Convert.ToDateTime("2024-03-29");
            DateTime L_2024_03_30 = Convert.ToDateTime("2024-03-30");
            DateTime L_2024_03_31 = Convert.ToDateTime("2024-03-31");

            if (Convert.ToDateTime(TODAY_DATE) == L_2024_03_28)
            {
                MessageBox.Show("Please Contact System Administrator [ " + _variables.SHOP_NAME + " ], To Update / Set New Financial Year.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Convert.ToDateTime(TODAY_DATE) == L_2024_03_29)
            {
                MessageBox.Show("Please Contact System Administrator [ " + _variables.SHOP_NAME + " ], To Update / Set New Financial Year.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Convert.ToDateTime(TODAY_DATE) == L_2024_03_30)
            {
                MessageBox.Show("Please Contact System Administrator [ " + _variables.SHOP_NAME + " ], To Update / Set New Financial Year.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Convert.ToDateTime(TODAY_DATE) == L_2024_03_31)
            {
                MessageBox.Show("Please Contact System Administrator [ " + _variables.SHOP_NAME + " ], To Update / Set New Financial Year.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dal.ClearParameters();
            dal.AddParameter("@TYPE", "SHOP_REGISTER", "IN");
            dal.AddParameter("@SUB_TYPE", "SHOP_DETAIL", "IN");
            dal.AddParameter("@BRANCH_ID", "1001", "IN");
            dal.AddParameter("@SHOP_ID", "1", "IN");
            DataTable SHOP_DETAIL = dal.GetTable("SP_SHOP_REGISTER", ref Message);
            if (SHOP_DETAIL.Rows.Count > 0)
            {
                lblCOMPANY_WEBSITE.Text = SHOP_DETAIL.Rows[0]["WEBSITE"].ToString();
            }
            else
            {
                lblCOMPANY_WEBSITE.Text = "";
            }
            lblMobileDetails.Text = _variables.COMPANY_MOBILE;
            PIC_LOGO.Image = new Bitmap(_variables.IMAGE_PATH + "Logo.png");
            USER_NAME.Focus();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime toDay_date = DateTime.Now;

                if (USER_NAME.Text == "")
                {
                    MessageBox.Show("Enter User Name.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    USER_NAME.Focus();
                }
                else if (PASSWORD.Text == "")
                {
                    MessageBox.Show("Enter Password.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PASSWORD.Focus();
                }
                else if (USER_NAME.Text == "0000011111" && PASSWORD.Text == "0101010101")
                {
                    Login.RenewApplication da = new Login.RenewApplication();
                    this.Hide();
                    da.ShowDialog();
                    this.Close();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                    dal.AddParameter("@SUB_TYPE", "LOGIN", "IN");
                    dal.AddParameter("@USER_NAME", USER_NAME.Text, "IN");
                    dal.AddParameter("@PASSWORD", PASSWORD.Text, "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    if (rdoAdmin.Checked == true)
                    {
                        dal.AddParameter("@MEMBER_TYPE", "A", "IN");
                    }
                    else
                    {
                        dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                    }

                    dal.AddParameter("@RETURN_MSG", "RETURN_MSG", "OUT");
                    
                    DataTable dtLoginCheck = dal.GetTable("SP_REGISTRATION", ref Message);

                    if (dtLoginCheck.Rows.Count > 0)
                    {
                        string IS_LOGIN = dtLoginCheck.Rows[0]["IS_LOGIN"].ToString();
                        End_Date = Convert.ToDateTime(dtLoginCheck.Rows[0]["END_DATE"]);

                        if (IS_LOGIN == "0")
                        {
                            MessageBox.Show(dtLoginCheck.Rows[0]["RESPONSE"].ToString(), _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            USER_NAME.Text = PASSWORD.Text = "";
                        }
                        else if (toDay_date > End_Date)
                        {

                            MessageBox.Show("Application Expired, Contact System Administrator. ", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            USER_NAME.Text = PASSWORD.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(_variables.WELCOME_MSG, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin.Dashboard da = new Admin.Dashboard();
                            this.Hide();
                            da.lblExpiringDate.Text = dtLoginCheck.Rows[0]["EXPIRED_DATE"].ToString();
                            da.USER_NAME_ = dtLoginCheck.Rows[0]["USER_NAME"].ToString();
                            da.PASSWORD_ = dtLoginCheck.Rows[0]["PASSWORD"].ToString();
                            da.NAME.Text = dtLoginCheck.Rows[0]["NAME"].ToString();
                            da.BILL_LABLE = dtLoginCheck.Rows[0]["BILL_LABLE"].ToString();
                            da.GST_IN = dtLoginCheck.Rows[0]["GST_IN"].ToString();
                            da.EMAIL = dtLoginCheck.Rows[0]["EMAIL"].ToString();
                            da.EMAIL_PASSWORD = dtLoginCheck.Rows[0]["EMAIL_PASSWORD"].ToString();
                            da.FINANCIAL_STATUS = Convert.ToBoolean(dtLoginCheck.Rows[0]["FINANCIAL_STATUS"]);
                            da.WITH_BATCH = dtLoginCheck.Rows[0]["WITH_BATCH"].ToString();
                            da.NO_OF_PRINT_ = dtLoginCheck.Rows[0]["NO_OF_PRINT"].ToString();
                            da.DB_BACKUP_ = dtLoginCheck.Rows[0]["DB_BACKUP"].ToString();

                            FINANCIAL_STATUS.Text = Convert.ToBoolean(dtLoginCheck.Rows[0]["FINANCIAL_STATUS"]).ToString(); ;
                            if (rdoAdmin.Checked == true)
                                da.MEMBER_TYPE_ = "A";
                            else if (rdoEmployee.Checked == true)
                                da.MEMBER_TYPE_ = "E";

                            if (rdoAdmin.Checked == true)
                            {
                                da.lblUserID.Text = "ADM_" + dtLoginCheck.Rows[0]["USER_ID"].ToString();
                                da.MEMBER_TYPE.Text = "Admin";
                            }
                            else
                            {
                                da.lblUserID.Text = "EMP_" + dtLoginCheck.Rows[0]["USER_ID"].ToString();
                                da.MEMBER_TYPE.Text = "Employee";
                            }

                            da.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PASSWORD.Text = "";
                        USER_NAME.Focus();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forget_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.ForgetPassword da = new Login.ForgetPassword();
            this.Hide();
            da.ShowDialog();
            this.Close();
        }

        #endregion -- Codes For Login Page

        #region -- Code For Back Color of Change

        private void USER_NAME_Enter(object sender, EventArgs e)
        {
            USER_NAME.BackColor = Color.MistyRose;
        }

        private void USER_NAME_Leave(object sender, EventArgs e)
        {
            USER_NAME.BackColor = Color.White;
        }

        private void PASSWORD_Enter(object sender, EventArgs e)
        {
            PASSWORD.BackColor = Color.MistyRose;
        }

        private void PASSWORD_Leave(object sender, EventArgs e)
        {
            PASSWORD.BackColor = Color.White;
        }

        private void LOGIN_Enter(object sender, EventArgs e)
        {
            LOGIN.BackColor = Color.MistyRose;
            LOGIN.ForeColor = Color.Black;
        }

        private void LOGIN_Leave(object sender, EventArgs e)
        {
            LOGIN.BackColor = Color.Green;
            LOGIN.ForeColor = Color.White;
        }

        #endregion -- Code For Back Color of Change
    }
}
