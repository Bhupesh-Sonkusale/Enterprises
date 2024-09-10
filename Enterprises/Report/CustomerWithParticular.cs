using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprises.Report
{
    public partial class CustomerWithParticular : Form
    {
        DataTable dt;
        string Message = "";
        string DATE = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Day.ToString().PadLeft(2, '0');
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_, TO_DATE_; SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public CustomerWithParticular()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (PARTICULAR.Text == "")
                {
                    MessageBox.Show("Select Particular First.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PARTICULAR.Focus();
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
                    dal.AddParameter("@TYPE", "REGISTRATION", "IN");
                    dal.AddParameter("@SUB_TYPE", "CUSTOMER_LIST_W_PARTICULAR", "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
                    dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
                    dal.AddParameter("@PRODUCT_ID", PRODUCT_ID.Text, "IN");
                    dal.AddParameter("@BARCODE", BARCODE.Text, "IN");
                    dt = dal.GetTable("SP_REGISTRATION", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        grdData.DataSource = dt;
                    }
                    else
                    {
                        grdData.DataSource = null;
                        MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FROM_DATE.Focus();
                    }

                    grdData.Columns[0].Width = 100;
                    grdData.Columns[1].Width = 100;
                    grdData.Columns[2].Width = 400;
                    grdData.Columns[3].Width = 100;
                    grdData.Columns[4].Width = 100;
                    grdData.Columns[5].Width = 100;
                }
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerWithParticular_Load(object sender, EventArgs e)
        {
            Particular_Bind();
        }

        public void Particular_Bind()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd_ = new SqlCommand("SELECT PRODUCT_NAME FROM PRODUCT_MASTER WHERE BRANCH_ID = @BRANCH_ID AND PRODUCT_NAME LIKE '%" + PARTICULAR.Text + "%'", con);
                cmd_.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                SqlDataReader dr_ = cmd_.ExecuteReader();
                AutoCompleteStringCollection scoll_ = new AutoCompleteStringCollection();

                while (dr_.Read())
                {
                    scoll_.Add(dr_.GetString(0));
                }
                PARTICULAR.AutoCompleteCustomSource = scoll_;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void PARTICULAR_TextChanged(object sender, EventArgs e)
        {
            dal.ClearParameters();
            dal.AddParameter("@TYPE", "PRODUCT_MASTER", "IN");
            dal.AddParameter("@SUB_TYPE", "PARTICULAR_BY_NAME", "IN");
            dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
            dal.AddParameter("@PRODUCT_NAME", PARTICULAR.Text.Trim().ToUpper(), "IN");
            dt = dal.GetTable("SP_MASTER_TABLE", ref Message);
            if (dt.Rows.Count > 0)
            {
                PRODUCT_ID.Text = dt.Rows[0]["ID"].ToString();
                BARCODE.Text = dt.Rows[0]["BARCODE"].ToString();
            }
            else
            {
                PRODUCT_ID.Text = BARCODE.Text = "";
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
