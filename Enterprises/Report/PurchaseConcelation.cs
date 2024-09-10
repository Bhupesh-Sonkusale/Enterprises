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
    public partial class PurchaseConcelation : Form
    {
        DataTable dt;
        string Message = ""; public bool FINANCIAL_STATUS;
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_;
        string TO_DATE_;

        public PurchaseConcelation()
        {
            InitializeComponent();
        }

        #region -- Code For Coding

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
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

                if (RDOPurchase.Checked == true)
                {
                    Show_Purchase_Details();
                }
                else if (RDORECEIPT.Checked == true)
                {
                    Show_Purchase_Receipt_Details();
                }
            }
            catch (Exception ex) { }
        }

        public void Show_Purchase_Details()
        {
            dt = new DataTable();
            dal.ClearParameters();
            dal.AddParameter("@TYPE", "PURCHASE", "IN");
            dal.AddParameter("@SUB_TYPE", "PURCHASE_CONCELATION_REPORT", "IN");
            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
            dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
            dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
            dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
            dt = dal.GetTable("SP_PURCHASE", ref Message);
            if (dt.Rows.Count > 0)
            {
                grdData.DataSource = dt;
                decimal TOTAL = 0, CASH = 0, ONLINE = 0;
                try
                {
                    for (int i = 0; i < grdData.Rows.Count; i++)
                    {
                        TOTAL += Convert.ToDecimal(grdData.Rows[i].Cells[2].Value);
                        CASH += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                        ONLINE += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                    }
                }
                catch (Exception ex) { }

                DataRow drToAdd = dt.NewRow();
                drToAdd[1] = "Total";
                drToAdd[2] = TOTAL.ToString();
                drToAdd[3] = CASH.ToString();
                drToAdd[4] = ONLINE.ToString();

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
        }

        public void Show_Purchase_Receipt_Details()
        {
            dt = new DataTable();
            dal.ClearParameters();
            dal.AddParameter("@TYPE", "PURCHASE", "IN");
            dal.AddParameter("@SUB_TYPE", "RECEIPT_CONCELATION_REPORT", "IN");
            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
            dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
            dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
            dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
            dt = dal.GetTable("SP_PURCHASE", ref Message);
            if (dt.Rows.Count > 0)
            {
                grdData.DataSource = dt;
                decimal CASH = 0, CARD = 0, ONLINE = 0;
                try
                {
                    for (int i = 0; i < grdData.Rows.Count; i++)
                    {
                        CASH += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                        ONLINE += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                    }
                }
                catch (Exception ex) { }

                DataRow drToAdd = dt.NewRow();
                drToAdd[2] = "Total";
                drToAdd[3] = CASH.ToString();
                drToAdd[4] = ONLINE.ToString();

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

        #endregion

    }
}
