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

namespace Enterprises.Bill_Rdlcs
{
    public partial class CompanyOrderBill : Form
    {
        DAL dal = new DAL(); public string ORDER_ID; public string BRANCH_ID = "1001";
        Shop_Detail _variables = new Shop_Detail(); public bool FINANCIAL_STATUS;
        DataTable tableProduct = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public CompanyOrderBill()
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

        private void CompanyOrderBill_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM _VIEW_COMPANY_ORDER WHERE ORDER_ID = @ORDER_ID", con);
                cmd.Parameters.AddWithValue("@ORDER_ID", ORDER_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(this.enterprisesDS._VIEW_COMPANY_ORDER);
                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
