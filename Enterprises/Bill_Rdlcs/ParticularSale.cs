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
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.Common;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace Enterprises.Bill_Rdlcs
{
    public partial class ParticularSale : Form
    {
        DataTable dt;
        string Message = "";
        string DATE = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Day.ToString().PadLeft(2, '0');
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_,TO_DATE_;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        DataTable tableProduct = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public ParticularSale()
        {
            InitializeComponent();
        }

        private void ParticularSale_Load(object sender, EventArgs e)
        {
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

                dal.ClearParameters();
                dal.AddParameter("@TYPE", "SETTING", "IN");
                dal.AddParameter("@SUB_TYPE", "DATE_INSERT", "IN");
                dal.AddParameter("@FROM_DATE", FROM_DATE_.ToString(), "IN");
                dal.AddParameter("@TO_DATE", TO_DATE_.ToString(), "IN");
                int _result = dal.ExecuteNonQuery("SP_SETTING", ref Message);

                enterprisesDS._VIEW_PARTICULAR_SALE.Clear();

                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM _VIEW_PARTICULAR_SALE ORDER BY PRODUCT_NAME ASC", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(this.enterprisesDS._VIEW_PARTICULAR_SALE);
                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                dal.ClearParameters();
                dal.AddParameter("@TYPE", "REPORT", "IN");
                dal.AddParameter("@SUB_TYPE", "PARTICULAR_SALE", "IN");
                DataTable dt = dal.GetTable("SP_SALE", ref Message);

                LocalReport report_ = new LocalReport();
                string fullPath = _variables.BILL_PATH + "ParticularSale.rdlc";
                report_.ReportPath = fullPath;
                report_.DataSources.Add(new ReportDataSource("JE_ds", dt));
                PrintToPrinter(report_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region --  Code for Printing Bill

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        public static void Export(LocalReport report, bool print = true)
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

        public static void Print()
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

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
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

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
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

        #endregion --  Code for Printing Bill
    }
}
