using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Report
{
    public partial class CustomerReport : Form
    {
        DataTable dt;
        string Message = "";
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        Validation _validation = new Validation();
        DateFormats _dates = new DateFormats();

        public CustomerReport()
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

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            CUSTOMER_NAME.Clear(); CUSTOMER_MOBILE.Clear();
            Show_List("", "");
        }

        public void Show_List(string customer_name_, string customer_mobile_)
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                dal.AddParameter("@SUB_TYPE", "CUSTOMER_LIST", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@NAME", customer_name_, "IN");
                dal.AddParameter("@MOBILE", customer_mobile_, "IN");
                dt = dal.GetTable("SP_REGISTRATION", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    grdData.Columns[0].Width = 100;
                    grdData.Columns[1].Width = 300;
                    grdData.Columns[2].Width = 500;
                    grdData.Columns[3].Width = 150;

                    grdData.Columns[0].Width = 60;
                    grdData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    grdData.DataSource = null;
                    MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { }
        }

        private void CUSTOMER_NAME_TextChanged(object sender, EventArgs e)
        {
            CUSTOMER_MOBILE.Clear();
            Show_List(CUSTOMER_NAME.Text.Trim(), "");
        }

        private void CUSTOMER_MOBILE_TextChanged(object sender, EventArgs e)
        {
            CUSTOMER_NAME.Clear();
            Show_List("", CUSTOMER_MOBILE.Text.Trim());
        }

        #region -- Code For Validation

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyNumberValidation(sender, e);
        }

        private void Only_Character(object sender, KeyPressEventArgs e)
        {
            _validation.EnterOnlyCharacterValidation(sender, e);
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
        #endregion -- Code For Validation

    }
}
