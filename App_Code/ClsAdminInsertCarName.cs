using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ClsAdminInsertCarName
/// </summary>
public class ClsAdminInsertCarName
{
    SqlCommand oCmd = new SqlCommand();
    Database objDB = new Database();
	public ClsAdminInsertCarName()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Boolean Insertcarname()
    {
        oCmd.Parameters.Add("@CarName", SqlDbType.VarChar).Value = CarName;
        oCmd.Parameters.Add("@Manufacture", SqlDbType.VarChar).Value = Manufacture;
        if (objDB.InsertDeleteStoredProcedure(oCmd, "AdminInsertCarName"))
        {
            return true;
        }
        else
            return false;
    }
    public string CarName { get; set; }
    public string Manufacture { get; set; }
}