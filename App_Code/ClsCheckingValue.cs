using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsCheckingValue
/// </summary>
public class ClsCheckingValue
{
    Database objDB = new Database();
    SqlCommand oCmd = new SqlCommand();
	public ClsCheckingValue()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Boolean insertvalue()
    {
        oCmd.Parameters.Add("@Formpid", SqlDbType.Int).Value = FORMPId;
        oCmd.Parameters.Add("@ImgId", SqlDbType.Int).Value = ImgPid;
        if (objDB.InsertDeleteStoredProcedure(oCmd, "checkingvalues"))
        {
            return true;
        }
        else 
            return false;
    }
   




    public int FORMPId { get; set; }
    public int ImgPid { get; set; }
}