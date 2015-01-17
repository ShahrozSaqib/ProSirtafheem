using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ClsAdminInsertManuName
/// </summary>
public class ClsAdminInsertManuName
{
    SqlCommand oCmd = new SqlCommand();
    Database objDB = new Database();
	public ClsAdminInsertManuName()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Boolean InsertManuName()
    {
        oCmd.Parameters.Add("@Manufacture", SqlDbType.VarChar).Value = ManufactureName;
        if (objDB.InsertDeleteStoredProcedure(oCmd,"AdminInsertManufactureName"))
        { 
            return true;
        }
        else
            return false;

    }

    public string ManufactureName { get; set; }

}