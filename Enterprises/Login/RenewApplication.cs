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
    public partial class RenewApplication : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();

        public RenewApplication()
        {
            InitializeComponent();
        }

        #region -- Codes For Renew Application

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Log_in da = new Login.Log_in();
            this.Hide();
            da.ShowDialog();
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal DAYS = ExtendDays.Value;
                if (DAYS <= 0)
                {
                    MessageBox.Show("Error : Select proper days.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SHOP_REGISTER", "IN");
                    dal.AddParameter("@SUB_TYPE", "EXTEND_DAY", "IN");
                    dal.AddParameter("@DAYS", Convert.ToInt16(DAYS), "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@SHOP_ID", _variables.SHOP_ID, "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_SHOP_REGISTER", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login.Log_in da = new Login.Log_in();
                        this.Hide();
                        da.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (securityKey.Text == "01010101010101010101")
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SHOP_REGISTER", "IN");
                dal.AddParameter("@SUB_TYPE", "SHOP_DETAIL", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@SHOP_ID", _variables.SHOP_ID, "IN");
                DataTable dtLoginCheck = dal.GetTable("SP_SHOP_REGISTER", ref Message);
                if (dtLoginCheck.Rows.Count > 0)
                {
                    startDate.Text = dtLoginCheck.Rows[0]["CREATE_DATE"].ToString();
                    endDate.Text = dtLoginCheck.Rows[0]["EXPIRED_DATE"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Error : In-correct Security keys.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                startDate.Text = endDate.Text = "";
                ExtendDays.Value = 0;
            }
        }

        private void btnyearChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to Change Year ?", _variables.SHOP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "SETTING", "IN");
                    dal.AddParameter("@SUB_TYPE", "YEAR_CHANGE", "IN");
                    dal.AddParameter("@RETURN_MESSAGE", "RETURN_MESSAGE", "OUT");
                    _result = dal.ExecuteNonQuery("SP_SETTING", ref Message);
                    if (_result > 0)
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(dal.ReturnParameter, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { }
        }

        #endregion -- Codes For Renew Application

    }
}
