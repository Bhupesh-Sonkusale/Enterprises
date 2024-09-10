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
    public partial class DailyCollection : Form
    {
        DataTable dt;
        string Message = ""; public bool FINANCIAL_STATUS;
        string DATE = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Day.ToString().PadLeft(2, '0');
        DAL dal = new DAL();
        Shop_Detail _variables = new Shop_Detail();
        DateFormats _dates = new DateFormats();
        string FROM_DATE_,TO_DATE_;

        public DailyCollection()
        {
            InitializeComponent();
        }

        #region -- Code For Daily Collection

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
                dal.AddParameter("@SUB_TYPE", "DAILY_COLLECTION", "IN");
                dal.AddParameter("@BRANCH_ID", _variables.BRANCH_ID, "IN");
                dal.AddParameter("@FROM_DATE", FROM_DATE_, "IN");
                dal.AddParameter("@TO_DATE", TO_DATE_, "IN");
                dal.AddParameter("@FINANCIAL_STATUS", FINANCIAL_STATUS, "IN");
                DataSet DS = dal.GetDataSet("SP_MASTER_TABLE", ref Message);

                dt = DS.Tables[0];
                DataTable dt1 = DS.Tables[1];

                if (dt.Rows.Count > 0)
                {
                    grdData.DataSource = dt;
                    decimal CASH_ = 0, CARD_ = 0, ONLINE_ = 0;
                    try
                    {
                        for (int i = 0; i < grdData.Rows.Count; i++)
                        {
                            CASH_ += Convert.ToDecimal(grdData.Rows[i].Cells[4].Value);
                            CARD_ += Convert.ToDecimal(grdData.Rows[i].Cells[5].Value);
                            ONLINE_ += Convert.ToDecimal(grdData.Rows[i].Cells[6].Value);
                        }
                    }
                    catch (Exception ex) { }

                    lblTotalCollection.Text = "Total Collection : " + (CASH_ + CARD_ + ONLINE_).ToString();
                    DataRow drToAdd = dt.NewRow();
                    drToAdd[0] = "";
                    drToAdd[3] = "Total";
                    drToAdd[4] = CASH_.ToString();
                    drToAdd[5] = CARD_.ToString();
                    drToAdd[6] = ONLINE_.ToString();

                    dt.Rows.Add(drToAdd);
                    dt.AcceptChanges();
                    grdData.DataSource = dt;
                    int rows = grdData.Rows.Count - 1;
                    grdData.Rows[rows].DefaultCellStyle.BackColor = Color.Black;
                    grdData.Rows[rows].DefaultCellStyle.ForeColor = Color.White;

                    grdData.Columns[0].HeaderText = "Page Name";
                    grdData.Columns[1].HeaderText = "Bill ID";
                    grdData.Columns[2].HeaderText = "Receipt ID";
                    grdData.Columns[3].HeaderText = "Date";
                    grdData.Columns[4].HeaderText = "Cash";
                    grdData.Columns[5].HeaderText = "Card";
                    grdData.Columns[6].HeaderText = "Online";

                    grdData.Columns[0].Width = 90;
                    grdData.Columns[1].Width = 90;
                    grdData.Columns[2].Width = 90;
                    grdData.Columns[3].Width = 150;
                    grdData.Columns[4].Width = 100;
                    grdData.Columns[5].Width = 100;
                    grdData.Columns[6].Width = 180;
                }
                else
                {
                    dt = null;
                    grdData.DataSource = dt;
                    MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FROM_DATE.Focus();
                }

                if (dt1.Rows.Count > 0)
                {
                    grdData_.DataSource = dt1;

                    grdData_.Columns[0].Width = 200;
                    grdData_.Columns[1].Width = 200;
                    grdData_.Columns[2].Width = 200;
                    grdData_.Columns[3].Width = 200;
                }
                else
                {
                    dt1 = null;
                    grdData_.DataSource = dt1;
                    MessageBox.Show("There is no data to show.", _variables.SHOP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FROM_DATE.Focus();
                }
            }
            catch (Exception ex) { }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion -- Code For Daily Collection

        private void grpContent_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
