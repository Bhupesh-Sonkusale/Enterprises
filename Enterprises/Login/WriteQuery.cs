using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Enterprises.Login
{
    public partial class WriteQuery : Form
    {

        DAL dal = new DAL(); string Message = "", query = "";
        DataTable dt; DataSet ds;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        
        public WriteQuery()
        {
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                TABLE_NAME.Text = CONDITION.Text = "";
                if (QUERY.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QUERY.Focus();
                }
                else
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand(QUERY.Text, con);
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Result : Query Executed Successfully";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (TABLE_NAME.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Table Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TABLE_NAME.Focus();
                }
                else
                {
                    QUERY.Text = "";
                    dt = new DataTable();
                    dt = dal.GetTable(TABLE_NAME.Text.Trim(), CONDITION.Text.Trim(), ref Message);
                    if (dt.Rows.Count > 0)
                    {
                        grdData.DataSource = dt;
                        lblResult.Text = "Result : Record Search Successfully with Table Name : " + TABLE_NAME.Text.Trim();
                    }
                    else
                    {
                        lblResult.Text = "Error : Table Name not Match with Database Tables or Empty Table.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllTables_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                query = "";
                query = "SELECT NAME,CONVERT(NVARCHAR(10),CREATE_DATE,103) +' : ' + CONVERT(NVARCHAR(5),CREATE_DATE,108) 'DATE' FROM SYS.TABLES ORDER BY NAME ASC";
                ds = dal.GetDataSet(query, ref Message);

                DataTable AllTable = ds.Tables[0];
                if (AllTable.Rows.Count > 0)
                {
                    grdData.DataSource = AllTable;
                    lblResult.Text = "Result : Query Submitted Successfully.";
                    TABLE_NAME.Text = CONDITION.Text = QUERY.Text = "";
                }
                else
                {
                    lblResult.Text = "Error : Try Again.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                TABLE_NAME.Text = grdData.CurrentRow.Cells["NAME"].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (USER_NAME.Text == "0000000000" && PASSWORD.Text == "##1234@@ZW")
                {
                    TABLE_NAME.Enabled = QUERY.Enabled = CONDITION.Enabled = btnAllTables.Enabled = btnQuery.Enabled = btnSearch.Enabled = true;
                    panelCredintial.Visible = false;
                }
                else
                {
                    TABLE_NAME.Enabled = QUERY.Enabled = CONDITION.Enabled = btnAllTables.Enabled = btnQuery.Enabled = btnSearch.Enabled = false;
                    panelCredintial.Visible = true;
                    MessageBox.Show("Enter Valid Credintials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { }
        }

    }
}
