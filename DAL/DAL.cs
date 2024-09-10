using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DAL
{
    List<SqlParameter> ParameterList = new List<SqlParameter>();

    public string ReturnParameter = string.Empty;
    public bool HasRows = false;
    string Message = string.Empty;
    public String ReturnField = string.Empty;

    public void ClearParameters()
    {
        ParameterList.Clear();
        ReturnField = string.Empty;
        HasRows = false;
    }

    public void AddParameter(string ParameterName, string ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        parameter.DbType = DbType.String;

        parameter.Size = 500;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    public void AddParameter(string ParameterName, int ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        parameter.DbType = DbType.Int32;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    public void AddParameter(string ParameterName, double ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        parameter.DbType = DbType.Double;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    public void AddParameter(string ParameterName, DateTime ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        parameter.DbType = DbType.DateTime;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    public void AddParameter(string ParameterName, byte[] ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        //parameter.DbType = DbType.Byte;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    //----------------------for boolen parameter-------------------------//

    public void AddParameter(string ParameterName, bool ParameterValue, string Direction)
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = ParameterName;
        parameter.Value = ParameterValue;
        parameter.DbType = DbType.String;
        if (Direction == "OUT")
        {
            ReturnField = ParameterName;
            parameter.Direction = ParameterDirection.Output;
        }
        else
            parameter.Direction = ParameterDirection.Input;
        ParameterList.Add(parameter);
    }

    public int ExecuteNonQuery(string Query, ref string Message)
    {
        int ReturnValue = 0;
        SqlCommand cmd = new SqlCommand();
        Message = "EXEC " + Query + " ";
        if (ParameterList.Count > 0)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in ParameterList)
            {
                Message += " " + parameter.ParameterName + "='" + parameter.Value + "',";
                cmd.Parameters.Add(parameter);
            }
        }
        else
        {
            cmd.CommandType = CommandType.Text;
        }
        cmd.CommandText = Query;
        cmd.CommandTimeout = 600;
        cmd.Connection = GetConnection(ref Message);
        try
        {
            cmd.Connection.Open();
            ReturnValue = cmd.ExecuteNonQuery();
            if (!string.IsNullOrEmpty(ReturnField))
            {
                ReturnParameter = cmd.Parameters[ReturnField].Value.ToString();
            }
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        finally
        {
            cmd.Connection.Close();
        }
        return ReturnValue;

    }

    public SqlDataReader ExecuteReader(string Query, ref string Message)
    {
        SqlDataReader rdr = null;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = GetConnection(ref Message);
        cmd.CommandText = Query;
        Message = "EXEC " + Query + " ";
        if (ParameterList.Count > 0)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in ParameterList)
            {
                Message += " " + parameter.ParameterName + "=" + parameter.Value + ",";
                cmd.Parameters.Add(parameter);
            }
        }
        else
        {
            cmd.CommandType = CommandType.Text;
        }
        try
        {
            cmd.Connection.Open();
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        finally
        {
            //cmd.Connection.Close();
        }
        return rdr;
    }

    public object ExecuteScaler(string Query, ref string Message)
    {
        object ReturnValue = null;
        SqlCommand cmd = new SqlCommand();
        Message = "EXEC " + Query + " ";
        if (ParameterList.Count > 0)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in ParameterList)
            {
                Message += " " + parameter.ParameterName + "=" + parameter.Value + ",";
                cmd.Parameters.Add(parameter);
            }
        }
        else
        {
            cmd.CommandType = CommandType.Text;
        }
        cmd.CommandText = Query;
        cmd.Connection = GetConnection(ref Message);
        try
        {
            cmd.Connection.Open();
            ReturnValue = cmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        finally
        {
            cmd.Connection.Close();
        }
        return ReturnValue;

    }

    public DataTable GetTable(string Query, ref string Message)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = GetConnection(ref Message);
        cmd.CommandText = Query;
        cmd.CommandTimeout = 600;
        if (ParameterList.Count > 0)
        {
            Message = "EXEC " + Query + " ";
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in ParameterList)
            {
                cmd.Parameters.Add(parameter);
                Message += parameter + "='" + parameter.Value + "' ,";
            }
        }
        else
        {
            cmd.CommandType = CommandType.Text;
        }
        try
        {
            cmd.Connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
                dt.Load(rdr);
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        finally
        {
            cmd.Connection.Close();
        }
        return dt;
    }

    public DataTable GetTable(string TableName, string Condition, ref string Message)
    {
        DataTable dt = null;
        string Query = "select * from " + TableName;
        if (Condition.Trim().Length > 0)
        {
            Query += " where " + Condition;
        }
        try
        {
            dt = GetTable(Query, ref Message);
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        return dt;
    }

    public DataSet GetDataSet(string Query, ref string Message)
    {
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = GetConnection(ref Message);
        cmd.CommandText = Query;
        if (ParameterList.Count > 0)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in ParameterList)
            {
                cmd.Parameters.Add(parameter);
            }
        }
        else
        {
            cmd.CommandType = CommandType.Text;
        }
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        try
        {
            da.Fill(ds);
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        return ds;
    }

    SqlConnection Connection;

    public SqlConnection GetConnection(ref string Message)
    {
        try
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\ProjectDB\SarojFashion\Database.mdf;Integrated Security=True;Connect Timeout=30");
            
        }
        catch (Exception ex)
        {
            Message = ex.Message.ToString();
        }
        return Connection;
    }
}
