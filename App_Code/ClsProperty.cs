using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsProperty
/// </summary>
public class ClsProperty
{
    SqlCommand oCmd = new SqlCommand();
    Database objDB = new Database();
	public ClsProperty()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #region Funtion
    public Boolean insertPropertyData()
    {
        oCmd.Parameters.Add("@PropertyAddress", SqlDbType.VarChar).Value = PropertyAddress;
        oCmd.Parameters.Add("@PropertyType", SqlDbType.VarChar).Value = PropertyType;
        oCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = Ownername;
        oCmd.Parameters.Add("@OwnerPhoneNo", SqlDbType.Char).Value = OwnerPhoneNo;
        oCmd.Parameters.Add("@Purpose", SqlDbType.VarChar).Value = Purpose;

        oCmd.Parameters.Add("@ListPrice", SqlDbType.Int).Value = ListPrice;
        if (objDB.InsertDeleteStoredProcedure(oCmd, "InsertPropertyData"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }





    #endregion
    #region Property
    public string PropertyAddress{ get; set; }
    public string PropertyType { get; set; }
    public string Ownername { get; set; }
    public string OwnerPhoneNo { get; set; }
    public string Purpose { get; set; }
   public int ListPrice { get; set; }
    #endregion
}