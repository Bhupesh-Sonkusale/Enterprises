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

namespace Enterprises.Report
{
    public partial class Attendance : Form
    {
        DataTable dt;
        string Message = "";
        string DATE = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Day.ToString().PadLeft(2, '0');
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_, TO_DATE_;

        public Attendance()
        {
            InitializeComponent();
        }

        #region -- Code For Product

        private void Attendance_Load(object sender, EventArgs e)
        {
            Bind_AdminEmployee();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (NAME.SelectedIndex == 0)
                {
                    MessageBox.Show("Select Employee Name", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NAME.Focus();
                }
                else if (FROM_DATE.Text == "")
                {
                    MessageBox.Show("Select From Date", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FROM_DATE.Focus();
                }
                else if (TO_DATE.Text == "")
                {
                    MessageBox.Show("Select To Date", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TO_DATE.Focus();
                }
                else
                {
                    DateTime d;
                    bool chValidity_1 = DateTime.TryParseExact(FROM_DATE.Text.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                    bool chValidity_2 = DateTime.TryParseExact(FROM_DATE.Text.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                    if (chValidity_1 == true)
                    {
                        FROM_DATE_ = _dates.DateCvtoyymmdd(FROM_DATE.Text.ToString());
                        TO_DATE_ = _dates.DateCvtoyymmdd(TO_DATE.Text.ToString());
                    }
                    else if (chValidity_2 == true)
                    {
                        FROM_DATE_ = FROM_DATE.Text.ToString();
                        TO_DATE_ = TO_DATE.Text.ToString();
                    }

                    dt = new DataTable();
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "ATTENDANCE", "IN");
                    dal.AddParameter("@SUB_TYPE", "REPORT_BY_DATE", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@EMPLOYEE_ID", NAME.SelectedValue.ToString().Trim(), "IN");
                    dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
                    dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
                    GridDesign();
                }
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            int rowsCount = grdData.Rows.Count;
            if (rowsCount > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "D:\\";
                saveFileDialog1.Title = "Save As Excel file";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";

                try
                {
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                        ExcelApp.Application.Workbooks.Add(Type.Missing);
                        ExcelApp.Columns.ColumnWidth = 15;
                        for (int i = 1; i < grdData.Columns.Count + 1; i++)
                        {
                            ExcelApp.Cells[1, i] = grdData.Columns[i - 1].HeaderText;
                            ExcelApp.Cells.Font.Bold = false;

                        }
                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            for (int j = 0; j < grdData.Columns.Count; j++)
                            {
                                ExcelApp.Cells[i + 2, j + 1] = grdData.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName);
                        ExcelApp.ActiveWorkbook.Saved = true;
                        ExcelApp.Quit();
                        MessageBox.Show("Excel file created,sucessfully...", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("There is no data to Download.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GridDesign()
        {
            dt = dal.GetTable("SP_REGISTRATION", ref Message);
            if (dt.Rows.Count > 0)
            {
                grdData.DataSource = dt;

                decimal TOTAL_SALARY_ = 0;
                try
                {

                    for (int i = 0; i < grdData.Rows.Count; i++)
                    {
                        TOTAL_SALARY_ += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value.ToString().Trim());
                    }
                }
                catch (Exception ex) { }

                DataRow drToAdd = dt.NewRow();
                drToAdd[2] = "  Salary ";
                drToAdd[3] = "  " + TOTAL_SALARY_.ToString();

                dt.Rows.Add(drToAdd);
                dt.AcceptChanges();
                grdData.DataSource = dt;
                int rows = grdData.Rows.Count - 1;
                grdData.Rows[rows].DefaultCellStyle.BackColor = Color.SteelBlue;
                grdData.Rows[rows].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                grdData.DataSource = null;
                MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FROM_DATE.Focus();
            }

            grdData.Columns[0].Width = 100;
            grdData.Columns[1].Width = 250;
            grdData.Columns[2].Width = 150;
            grdData.Columns[3].Width = 250;
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

        #endregion

    }
}
