using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Enterprises.Report
{
    public partial class Sale : Form
    {
        DataTable dt;
        string Message = "";
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_; string CUSTOMER_ID = "";
        string TO_DATE_; SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public string GST_IN,WITH_BATCH; public bool FINANCIAL_STATUS;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public Sale()
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
                BILL_ID.Text = CUSTOMER_NAME.Text = CUSTOMER_ID = "";
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
                dal.AddParameter("@TYPE", "REPORT", "IN");
                dal.AddParameter("@SUB_TYPE", "SALE_DATEWISE", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
                dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dt = dal.GetTable("SP_SALE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    decimal TOTAL_ = 0, PAID_ = 0, BALANCE_ = 0;
                    try
                    {

                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            TOTAL_ += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                            PAID_ += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                            BALANCE_ += Convert.ToDecimal(grdData.Rows[i].Cells[5].Value);
                        }
                    }
                    catch (Exception ex) { }

                    DataRow drToAdd = dt.NewRow();
                    drToAdd[1] = "Total";
                    drToAdd[3] = TOTAL_.ToString();
                    drToAdd[4] = PAID_.ToString();
                    drToAdd[5] = BALANCE_.ToString();

                    dt.Rows.Add(drToAdd);
                    dt.AcceptChanges();
                    grdData.DataSource = dt;
                    int rows = grdData.Rows.Count - 1;
                    grdData.Rows[rows].DefaultCellStyle.BackColor = Color.SteelBlue;
                    grdData.Rows[rows].DefaultCellStyle.ForeColor = Color.White;
                    grdData.Columns[2].Visible = false;
                }
                else
                {
                    grdData.DataSource = null;
                    MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FROM_DATE.Focus();
                }
            }
            catch (Exception ex) { }
        }

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CUSTOMER_NAME.Clear();
                if (BILL_ID.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Bill ID.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BILL_ID.Focus();
                }
                else
                {
                    dt = new DataTable();
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "REPORT", "IN");
                    dal.AddParameter("@SUB_TYPE", "SALE_WITH_BILL_ID", "IN");
                    dal.AddParameter("@BILL_ID", BILL_ID.Text.Trim(), "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dt = dal.GetTable("SP_SALE", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        grdData.DataSource = dt;
                        decimal TOTAL_ = 0, PAID_ = 0, BALANCE_ = 0;
                        try
                        {

                            for (int i = 0; i < grdData.Rows.Count; i++)
                            {
                                TOTAL_ += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                                PAID_ += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                                BALANCE_ += Convert.ToDecimal(grdData.Rows[i].Cells[5].Value);
                            }
                        }
                        catch (Exception ex) { }

                        DataRow drToAdd = dt.NewRow();
                        drToAdd[1] = "Total";
                        drToAdd[3] = TOTAL_.ToString();
                        drToAdd[4] = PAID_.ToString();
                        drToAdd[5] = BALANCE_.ToString();

                        dt.Rows.Add(drToAdd);
                        dt.AcceptChanges();
                        grdData.DataSource = dt;
                        int rows = grdData.Rows.Count - 1;
                        grdData.Rows[rows].DefaultCellStyle.BackColor = Color.SteelBlue;
                        grdData.Rows[rows].DefaultCellStyle.ForeColor = Color.White;
                        grdData.Columns[2].Visible = false;
                    }
                    else
                    {
                        grdData.DataSource = null;
                        MessageBox.Show("There is no bill to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BILL_ID.Focus();
                    }
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

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                string BILL_ID = grdData.CurrentRow.Cells[0].Value.ToString().Trim();

                //Bill_Rdlcs.JE_Invoice obj = new Bill_Rdlcs.JE_Invoice();
                //obj.BILL_ID = BILL_ID.ToString();
                //obj.FINANCIAL_STATUS = FINANCIAL_STATUS;
                //obj.Show();

                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SALE", "IN");
                dal.AddParameter("@SUB_TYPE", "PRINT_BILL", "IN");
                dal.AddParameter("@BILL_ID", BILL_ID.ToString(), "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS.ToString(), "IN");
                dt = dal.GetTable("SP_SALE", ref Message);

                LocalReport report_ = new LocalReport();
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                string fullPath = _variables.BILL_PATH + "JE_Invoice.rdlc";
                report_.ReportPath = fullPath;
                report_.DataSources.Add(new ReportDataSource("JE_ds", dt));
                PrintToPrinter(report_);
            }
        }


        private void btnSearchNameWise_Click(object sender, EventArgs e)
        {
            try
            {
                BILL_ID.Clear();
                if (CUSTOMER_ID == "")
                {
                    MessageBox.Show("Enter Customer Name.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CUSTOMER_NAME.Focus();
                }
                else
                {
                    dt = new DataTable();
                    dal.ClearParameters();
                    dal.AddParameter("@TYPE", "REPORT", "IN");
                    dal.AddParameter("@SUB_TYPE", "SALE_WITH_NAME", "IN");
                    dal.AddParameter("@CUSTOMER_ID", CUSTOMER_ID, "IN");
                    dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                    dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                    dt = dal.GetTable("SP_SALE", ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        grdData.DataSource = dt;
                        decimal TOTAL_ = 0, PAID_ = 0, BALANCE_ = 0;
                        try
                        {

                            for (int i = 0; i < grdData.Rows.Count; i++)
                            {
                                TOTAL_ += Convert.ToDecimal(grdData.Rows[i].Cells[3].Value);
                                PAID_ += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                                BALANCE_ += Convert.ToDecimal(grdData.Rows[i].Cells[5].Value);
                            }
                        }
                        catch (Exception ex) { }

                        DataRow drToAdd = dt.NewRow();
                        drToAdd[1] = "Total";
                        drToAdd[3] = TOTAL_.ToString();
                        drToAdd[4] = PAID_.ToString();
                        drToAdd[5] = BALANCE_.ToString();

                        dt.Rows.Add(drToAdd);
                        dt.AcceptChanges();
                        grdData.DataSource = dt;
                        int rows = grdData.Rows.Count - 1;
                        grdData.Rows[rows].DefaultCellStyle.BackColor = Color.SteelBlue;
                        grdData.Rows[rows].DefaultCellStyle.ForeColor = Color.White;
                        grdData.Columns[2].Visible = false;
                    }
                    else
                    {
                        grdData.DataSource = null;
                        MessageBox.Show("There is no bill to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CUSTOMER_NAME.Focus();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void NameBind()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd_ = new SqlCommand("SELECT NAME FROM REGISTRATION WHERE MEMBER_TYPE = 'C' AND BRANCH_ID = @BRANCH_ID AND NAME LIKE '%" + CUSTOMER_NAME.Text + "%'", con);
                cmd_.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                SqlDataReader dr_ = cmd_.ExecuteReader();
                AutoCompleteStringCollection scoll_ = new AutoCompleteStringCollection();

                while (dr_.Read())
                {
                    scoll_.Add(dr_.GetString(0));
                }
                CUSTOMER_NAME.AutoCompleteCustomSource = scoll_;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            NameBind();
        }

        private void CUSTOMER_NAME_TextChanged(object sender, EventArgs e)
        {
            if (CUSTOMER_NAME.Text.Trim() == "")
            {
                CUSTOMER_ID = "";
            }
            else
            {
                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SALE", "IN");
                dal.AddParameter("@SUB_TYPE", "DETAIL_WITH_PARTYNAME", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@PARTY_NAME", CUSTOMER_NAME.Text.Trim().ToUpper(), "IN");
                dt = dal.GetTable("SP_SALE", ref Message);
                if (dt.Rows.Count > 0)
                {
                    CUSTOMER_ID = dt.Rows[0]["ID"].ToString();
                }
                else
                {
                    CUSTOMER_ID = "";
                }
            }
        }

        #endregion

        #region -- Code for Printing Bill

        public static void PrintToPrinter(LocalReport report)
        {
            try
            {
                Export(report);
            }
            catch (Exception ex) { }
        }

        public static void Export(LocalReport report, bool print = true)
        {
            try
            {
                string deviceInfo =
               @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>7in</PageWidth>
                <PageHeight>0in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
                Warning[] warnings;
                m_streams = new List<Stream>();
                report.Render("Image", deviceInfo, CreateStream, out warnings);
                foreach (Stream stream in m_streams)
                    stream.Position = 0;

                if (print)
                {
                    Print();
                }
            }
            catch (Exception ex) { }
        }

        public static void Print()
        {
            try
            {
                if (m_streams == null || m_streams.Count == 0)
                    throw new Exception("Error: no stream to print.");
                PrintDocument printDoc = new PrintDocument();
                if (!printDoc.PrinterSettings.IsValid)
                {
                    throw new Exception("Error: cannot find the default printer.");
                }
                else
                {

                    printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                    m_currentPageIndex = 0;
                    printDoc.Print();
                }
            }
            catch (Exception ex) { }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            try
            {
                Metafile pageImage = new
                   Metafile(m_streams[m_currentPageIndex]);

                // Adjust rectangular area with printer margins.
                Rectangle adjustedRect = new Rectangle(
                    -3,
                    0,
                    800,
                    ev.PageBounds.Height);

                // Draw a white background for the report
                ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

                // Draw the report content
                ev.Graphics.DrawImage(pageImage, adjustedRect);

                ev.PageSettings.PrinterSettings.Copies = 2;
                // report_.PrinterSettings.Copies = 3;

                // Prepare for the next page. Make sure we haven't hit the end.
                m_currentPageIndex++;
                ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
            }
            catch (Exception ex) { }
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion -- Code for Printing Bill

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
