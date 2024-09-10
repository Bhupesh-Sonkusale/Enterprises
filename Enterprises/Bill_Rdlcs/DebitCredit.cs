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

namespace Enterprises.Bill_Rdlcs
{
    public partial class DebitCredit : Form
    {
        DAL dal = new DAL(); public string BILL_ID, BILL_TYPE;
        Shop_Detail _variables = new Shop_Detail(); public bool FINANCIAL_STATUS;
        DataTable tableProduct = new DataTable();
        DateFormats _dates = new DateFormats();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        string FROM_DATE_, TO_DATE_;

        public DebitCredit()
        {
            InitializeComponent();
        }

        #region -- Code For Booking_Load

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
                reportViewer1.Clear();
                enterprisesDS._VIEW_DEBIT_CREDIT.Clear();

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

                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd__ = new SqlCommand("DELETE FROM SEARCH_DATE", con);
                cmd__.ExecuteNonQuery();
                con.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SEARCH_DATE (FROM_DATE,TO_DATE,BRANCH_ID) VALUES (@FROM_DATE,@TO_DATE,@BRANCH_ID)", con);
                cmd.Parameters.AddWithValue("@FROM_DATE", FROM_DATE_);
                cmd.Parameters.AddWithValue("@TO_DATE", TO_DATE_);
                cmd.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                cmd.ExecuteNonQuery();
                con.Close();

                // reportViewer1.LocalReport.EnableExternalImages = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                SqlCommand cmd_ = new SqlCommand("SELECT * FROM _VIEW_DEBIT_CREDIT WHERE BRANCH_ID = @BRANCH_ID ORDER BY TRANSACTION_ID", con);
                cmd_.Parameters.AddWithValue("@BRANCH_ID", _variables.BRANCH_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_);
                da.Fill(this.enterprisesDS._VIEW_DEBIT_CREDIT);
                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch (Exception ex) { }
        }

        #endregion -- Code Booking_Load

    }
}
