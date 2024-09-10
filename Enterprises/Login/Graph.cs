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

namespace Enterprises.Login
{
    public partial class Graph : Form
    {
        string Message = "";
        DAL dal = new DAL();
        string FROM_DATE_, TO_DATE_;
        DataTable dt, dt_; public bool FINANCIAL_STATUS;
        DateFormats _dates = new DateFormats();
        Shop_Detail _variables = new Shop_Detail();

        public Graph()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dt = new DataTable();
                dt_ = new DataTable();
                
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
                dal.AddParameter("@TYPE", "REPORT", "IN");
                dal.AddParameter("@SUB_TYPE", "CHART_DESIGN", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
                DataSet DS = dal.GetDataSet("SP_MASTER_TABLE", ref Message);

                dt = DS.Tables[0];
                chart1.Series[0].YValueMembers = "SALE";
                chart1.Series[1].YValueMembers = "SALE_RETURN";
                chart1.Series[2].YValueMembers = "PURCHASE";
                chart1.Series[3].YValueMembers = "EXPENSE";
                chart1.DataSource = dt;
                chart1.DataBind();

                chart2.Series["Series1"].Points.Clear();
                chart2.Series["Series1"].Points.Clear();
                chart2.Series["Series1"].Points.Clear();

                dt_ = DS.Tables[1];
                chart2.Series["Series1"].Points.AddXY("SALE : " + dt_.Rows[0]["SALE_AMT"].ToString(), dt_.Rows[0]["SALE"].ToString());
                chart2.Series["Series1"].Points.AddXY("SALE RETURN : " + dt_.Rows[0]["SALE_RETURN_AMT"].ToString(), dt_.Rows[0]["SALE_RETURN"].ToString());
                chart2.Series["Series1"].Points.AddXY("PURCHASE : " + dt_.Rows[0]["PURCHASE_AMT"].ToString(), dt_.Rows[0]["PURCHASE"].ToString());
                chart2.Series["Series1"].Points.AddXY("EXPENSE : " + dt_.Rows[0]["EXPENSE_AMT"].ToString(), dt_.Rows[0]["EXPENSE"].ToString());
                chart2.DataSource = dt_;
                chart2.DataBind();
            }
            catch (Exception ex) { }
        }
    }
}
