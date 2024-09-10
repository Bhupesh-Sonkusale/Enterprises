using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Enterprises.Bill_Rdlcs
{
    public partial class JE_Invoice : Form
    {
        DAL dal = new DAL(); public string BILL_ID; public string BRANCH_ID = "1001";
        Shop_Detail _variables = new Shop_Detail(); public bool FINANCIAL_STATUS;
        DataTable tableProduct = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public JE_Invoice()
        {
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JE_Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.EnableExternalImages = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM _VIEW_INVOICE_BILL WHERE BILL_ID = @BILL_ID AND FINANCIAL_STATUS = @FINANCIAL_STATUS ORDER BY SR_NO ASC", con);
                cmd.Parameters.AddWithValue("@BILL_ID", BILL_ID);
                cmd.Parameters.AddWithValue("@FINANCIAL_STATUS", FINANCIAL_STATUS);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(this.enterprisesDS._VIEW_INVOICE_BILL);
                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch (Exception ex) { }
        }
    }
}
