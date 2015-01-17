using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml;
using System.Linq;
using System.Text;
using System.IO;

    public class Database
    {

        #region "Public Variables"
        public string mConnStr;
        //stores the latest date
        public static string newsdate;
        #endregion

        #region "Private Variables"
        private DataSet mDataSet;
        private System.Data.SqlClient.SqlDataAdapter mSqlAdapter;
        private DataTable mdataTable;
        private FileStream mobjFileStream;
        private StreamReader mobjReader;
        private SqlConnection msqlConnection;
        #endregion
        private System.Data.SqlClient.SqlCommand oCmd;

        #region "Load"
        public Database()
        {
            //Dim ConnStr As String
            //Dim m_xmlr As XmlTextReader
            //m_xmlr = New XmlTextReader("D:\Projects\ERPHMB\Model\Test.xml")
            //'Disable whitespace so that you don't have to read over whitespaces
            //m_xmlr.WhitespaceHandling = WhitespaceHandling.None
            //'read the xml declaration and advance to family tag



            //m_xmlr.Read()
            //'Load the Loop
            //While Not m_xmlr.EOF
            //    'Go to the name tag

            //    m_xmlr.Read()
            //    'if not start element exit while loop

            //    If Not m_xmlr.IsStartElement() Then
            //        Exit While
            //    End If
            //    'Get the Gender Attribute Value

            //    Dim genderAttribute = m_xmlr.GetAttribute("name")
            //    'Read elements firstname and lastname

            //    m_xmlr.Read()
            //    'Get the firstName Element Value

            //    mConnStr = m_xmlr.ReadElementString("value")
            //    'Get the lastName Element Value
            //End While
            //'close the reader

            //m_xmlr.Close()
            //mConnStr = ConfigurationManager.ConnectionStrings["XSERPConnectionString"].ConnectionString;
            //mConnStr = @"Data Source=TFD-B8984DE6FB6\TFDSERVERR2;Initial Catalog=XSERP;Persist Security Info=True;User ID=sa;Password=sqlserver2008";
            //mConnStr=System.Configuration.ConfigurationSettings.AppSettings["XSERPConnectionString"].ToString();

            //mConnStr = ConfigurationSettings.AppSettings["XSERPConnectionString"];
            //mConnStr = "Data Source=TFD-B8984DE6FB6\\TFDSERVERR2;Initial Catalog=XSERP;Persist Security Info=True;User ID=sa;Password=sqlserver2008";
            //connectionString="User ID=sa; data source=BACKUP-SERVER; pwd=sqlserver2008; Initial Catalog=PSMS; Enlist=false; Connect Timeout=120;Min Pool Size=10; Max Pool Size=300;" providerName="System.Data.SqlClient"/>

            mConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["SirTafheemConnectionString"].ToString();
            msqlConnection = new SqlConnection(mConnStr);
        }

        #endregion

        #region "Functions"
        public void DisposeConnection()
        {
            try
            {
                msqlConnection.Close();
                msqlConnection.Dispose();
                oCmd = null;

            }
            catch (Exception)
            {

            }
        }

        public Boolean InsertDeleteStoredProcedure(SqlCommand objCommand1, string cmdText, int CommandTimeOut = 300)
        {
            DataTable TempTable = new DataTable();
            oCmd = new SqlCommand();
            oCmd = objCommand1;
            oCmd.CommandTimeout = CommandTimeOut;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }
                oCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                msqlConnection.Close();
            }
            return true;
        }
        public Boolean InsertDeleteStoredProcedure(SqlCommand objCommand1, string cmdText, SqlConnection sqlConn, SqlTransaction sqlTrans)
        {

            DataTable TempTable = new DataTable();
            oCmd = new SqlCommand();
            oCmd = objCommand1;
            oCmd.Transaction = sqlTrans;
            oCmd.CommandTimeout = 300;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = sqlConn;

            try
            {
                //if (msqlConnection.State == ConnectionState.Closed)
                //{
                //    msqlConnection.Open();
                //}
                oCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                //sqlConnection.Close();
            }
            return true;
        }
        public Boolean InsertDeleteStoredProcedure(string cmdText)
        {

            DataTable TempTable = new DataTable();
            oCmd = new SqlCommand();
            oCmd.CommandTimeout = 300;
            //oCmd = objCommand1
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }
                oCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                msqlConnection.Close();
            }
            return true;
        }

        public DataTable GetExcelData(string query, string FileName)
        {

            string strConn = "";
            strConn = "Provider=Microsoft.Jet.OleDb.4.0; data source=" + FileName + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";

            OleDbConnection objConn = new OleDbConnection(strConn);
            OleDbDataAdapter mOleDBAdapter = null;


            try
            {
                mdataTable = new DataTable();

                objConn = new OleDbConnection(strConn);
                OleDbCommand objCmd = new OleDbCommand(query, objConn);

                objConn.Open();

                mOleDBAdapter = new OleDbDataAdapter(query, strConn);
                mOleDBAdapter.Fill(mdataTable);
                return mdataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //This function is used to check whether a particular user has access to the particular page or not.
        public bool CheckAccess(string sucid, string pagename)
        {
            string query = "select sucid from siteaccess where sucid=" + sucid + " and pagename='" + pagename + "'";
            if ((GetSingleData(query) != null))
            {
                return true;
            }
            return false;
        }
        //this function returns the count of rows updated/affected by query
        public int InsertDeleteCount(string query)
        {
            int count = 300;
            try
            {
                // Dim sqlCmd As New SqlClient.SqlCommand
                msqlConnection = new SqlConnection(mConnStr);
                oCmd = new SqlCommand();
                oCmd.Connection = msqlConnection;
                oCmd.CommandText = query;
                oCmd.Connection.Open();
                count += oCmd.ExecuteNonQuery();
                oCmd.Connection.Close();
                return count;

            }
            catch (Exception ex)
            {
            }
            return 0;

        }

        //Public Function ToHexColor(ByVal c As System.Drawing.Color) As String

        //    Return "#" + c.ToArgb().ToString("x").Substring(2)

        //End Function



        public string PrepareStr(string strValue)
        {

            if (string.IsNullOrEmpty(strValue.Trim()) | strValue.Trim() == "Nothing")
            {
                return "''";
            }
            else
            {
                return "'" + strValue.Trim() + "'";
            }

        }

        public DataTable GetTablebySimpleStoredProcedure(string cmdText)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }
                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                msqlConnection.Close();
            }

        }
        public DataSet GetDataSetbySimpleStoredProcedure(SqlCommand command, string cmdText)
        {
            DataSet ds;          
            oCmd = new SqlCommand();
            oCmd = command;
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(oCmd);
                ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                msqlConnection.Close();
            }

        }

        public DataTable GetTableByStoredProcedure(string CommandText)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = CommandText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;
            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                msqlConnection.Close();
            }

        }
        public DataTable GetTableByStoredProcedure(string CommandText, SqlConnection sqlConn, SqlTransaction sqlTrans)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd.Transaction = sqlTrans;
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = CommandText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = sqlConn;
            try
            {
                //if (msqlConnection.State == ConnectionState.Closed)
                //{
                //    msqlConnection.Open();
                //}

                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //msqlConnection.Close();
            }

        }
        public DataTable GetTablebyStoredProcedure(SqlCommand objCommand1, string cmdText, SqlConnection sqlConn, SqlTransaction sqlTrans)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd = objCommand1;
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = sqlConn;
            oCmd.Transaction = sqlTrans;

            try
            {
                //if (msqlConnection.State == ConnectionState.Closed)
                //{
                //    msqlConnection.Open();
                //}

                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // msqlConnection.Close();
            }
        }

        public String GetSingleValuebyStoredProcedure(string cmdText)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;


            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                msqlConnection.Close();
            }
        }

        public String GetSingleValuebyStoredProcedure(SqlCommand command, string cmdText)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd = command;
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;


            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                msqlConnection.Close();
            }
        }
        public DataTable GetTablebyStoredProcedure(SqlCommand objCommand1, string cmdText)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd = objCommand1;
            oCmd.CommandTimeout = 30000;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;


            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                msqlConnection.Close();
            }
        }

        public DataTable GetData(string query)
        {
            try
            {
                mdataTable = new DataTable();
                if (!(msqlConnection.State == ConnectionState.Open))
                {
                    msqlConnection.Open();
                }
                mSqlAdapter = new SqlDataAdapter(query, msqlConnection);
                oCmd = new SqlCommand();
                oCmd.CommandTimeout = 300;

                mSqlAdapter.Fill(mdataTable);
                return mdataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetSearchData(string query)
        {

            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd.CommandText = query;
            oCmd.Connection = msqlConnection;
            oCmd.CommandTimeout = 300;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;

            }

        }

        public int RowCount(string query)
        {
            try
            {
                if (!(msqlConnection.State == ConnectionState.Open))
                {
                    msqlConnection.Open();
                }
                mdataTable = new DataTable();
                mSqlAdapter = new SqlDataAdapter(query, msqlConnection);
                mSqlAdapter.Fill(mdataTable);
                return mdataTable.Rows.Count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool InsertDelete(string query)
        {
            try
            {
                msqlConnection = new SqlConnection(mConnStr);
                oCmd = new SqlCommand();
                oCmd.Connection = msqlConnection;
                oCmd.CommandText = query;
                oCmd.Connection.Open();
                oCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataSet GetDataSet(string sqlqry)
        {

            string query = sqlqry;
            try
            {
                mDataSet = new DataSet();
                msqlConnection = new SqlConnection(mConnStr);
                mdataTable = new DataTable();
                msqlConnection.Open();
                mSqlAdapter = new SqlDataAdapter(query, msqlConnection);
                mSqlAdapter.Fill(mDataSet);

                return mDataSet;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public string GetSingleData(string sqlqry)
        {
            string query = sqlqry;
            msqlConnection = new SqlConnection(mConnStr);
            try
            {
                mdataTable = new DataTable();
                if (!(msqlConnection.State == ConnectionState.Open))
                {
                    msqlConnection.Open();
                }
                mSqlAdapter = new SqlDataAdapter(query, msqlConnection);
                mSqlAdapter.Fill(mdataTable);
                return mdataTable.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string GetSingleDataSP(SqlCommand objCommand1, string cmdText)
        {
            DataTable dt = new DataTable();
            oCmd = new SqlCommand();
            oCmd = objCommand1;
            oCmd.CommandTimeout = 300;
            oCmd.CommandText = cmdText;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = msqlConnection;

            try
            {
                if (msqlConnection.State == ConnectionState.Closed)
                {
                    msqlConnection.Open();
                }

                dt.Load(oCmd.ExecuteReader());
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool TestCnn()
        {
            msqlConnection = new SqlConnection(mConnStr);
            try
            {
                if (!(msqlConnection.State == ConnectionState.Open))
                {
                    msqlConnection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// This mehtod retrieves the excel sheet names from an excel workbook.
        /// The excel file
        /// </summary>
        /// <param name="excelFile"></param>
        /// <returns>String</returns>
        /// <remarks></remarks>

        public DataTable GetExcelSheetNames(string excelFile)
        {
            try
            {
                OleDbConnection objConn = null;
                System.Data.DataTable dtExcelName = null;
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=\"" + excelFile + "\";" + "Extended Properties=\"Excel 8.0;IMEX=1;\"";

                //Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & excelFile & ";Extended Properties=Excel 8.0;"
                objConn = new OleDbConnection(connString);
                objConn.Open();
                dtExcelName = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dtExcelName.Rows.Count > 0)
                {
                    return dtExcelName;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        public int GetExcelSheetCounts(string excelFile)
        {
            OleDbConnection objConn = null;
            try
            {
                System.Data.DataTable dtExcelName = null;
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=\"" + excelFile + "\";" + "Extended Properties=\"Excel 8.0;IMEX=1;\"";

                //Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & excelFile & ";Extended Properties=Excel 8.0;"
                objConn = new OleDbConnection(connString);
                objConn.Open();
                dtExcelName = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                return dtExcelName.Rows.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                objConn.Close();
            }
            return 0;
        }

        #endregion


    }


