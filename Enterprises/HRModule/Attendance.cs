using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.HRModule
{
    public partial class Attendance : Form
    {
        DataTable dt;
        string Message = "";
        int _result = 0;
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        public string USER_ID;

        public Attendance()
        {
            InitializeComponent();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Insert_Attendance("INSERT");
        }

        public void Insert_Attendance(string BUTTON_TYPE)
        {
            try
            {
                if (NAME.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Employee Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NAME.Focus();
                }
                else if (ATTENDANCE_STATUS.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Status", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ATTENDANCE_STATUS.Focus();
                }
                else
                {
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                    dal.AddParameter("@SUB_TYPE", "INSERT_ATTENDANCE", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@EMPLOYEE_ID", NAME.SelectedValue.ToString().Trim(), "IN");
                    dal.AddParameter("@ATTENDANCE_STATUS", ATTENDANCE_STATUS.Text.ToString().Trim(), "IN");
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
                        NAME.Focus();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            Bind_AdminEmployee();
            ATTENDANCE_STATUS.SelectedIndex = NAME.SelectedIndex = 0;
            Show_All();
        }

        public void Bind_AdminEmployee()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@MEMBER_TYPE", "E", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                NAME.DisplayMember = "NAME";
                NAME.ValueMember = "ID";
                NAME.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        public void ClearAll()
        {
            ATTENDANCE_STATUS.SelectedIndex = NAME.SelectedIndex = 0;
            Show_All();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Show_All()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                dal.AddParameter("@SUB_TYPE", "TODAYS_REPORT_ALL", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                grdData.DataSource = dt;
            }
            catch (Exception ex) { }
        }

    }
}
