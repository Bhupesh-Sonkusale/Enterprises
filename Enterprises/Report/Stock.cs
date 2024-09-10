using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprises.Report
{
    public partial class Stock : Form
    {
        DataTable dt;
        string Message = "";
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();

        public Stock()
        {
            InitializeComponent();
        }

        #region -- Code For Product

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Bind_Category();
        }

        public void Bind_Category()
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "MASTER_TABLE", "IN");
                dal.AddParameter("@SUB_TYPE", "BIND_DROPDOWN", "IN");
                dal.AddParameter("@PAGE_NAME", "CATEG", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
                CATEGORY.DisplayMember = "CATEGORY";
                CATEGORY.ValueMember = "ID";
                CATEGORY.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCT_NAME.Text = "";
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "STOCK_REPORT", "IN");
                dal.AddParameter("@NAME_1", CATEGORY.SelectedValue.ToString(), "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                GridDesign();
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

        private void PRODUCT_NAME_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
                dal.AddParameter("@SUB_TYPE", "PRODUCT_NAME_STOCK", "IN");
                dal.AddParameter("@PRODUCT_NAME", PRODUCT_NAME.Text, "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                GridDesign();
            }
            catch (Exception ex) { }
        }

        public void GridDesign()
        {
            dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
            if (dt.Rows.Count > 0)
            {
                grdData.DataSource = dt;
                TOTAL_COUNT.Text = "Total : " + dt.Rows.Count;
            }
            else
            {
                grdData.DataSource = dt;
                TOTAL_COUNT.Text = "Total : 0";
            }

            grdData.Columns[0].Width = 500;
            grdData.Columns[1].Width = 150;
            grdData.Columns[2].Width = 150;
            grdData.Columns[3].Width = 150;
        }

        #endregion

    }
}
