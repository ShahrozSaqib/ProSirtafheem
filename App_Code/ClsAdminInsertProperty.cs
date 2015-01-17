using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ClsAdminInsertProperty
/// </summary>
public class ClsAdminInsertProperty
{
    SqlCommand oCmd = new SqlCommand();
    Database objDB = new Database();
	public ClsAdminInsertProperty()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Boolean insertPrpopertyType()
    {
        oCmd.Parameters.Add("@PropertyType", SqlDbType.VarChar).Value = PropertyType;
        if (objDB.InsertDeleteStoredProcedure(oCmd, "AdminInsertPropertyType"))
        {
            return true;
        }
        else
            return false; 
    }
   
    public string PropertyType { get; set; }
}