using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsCheckingValueVehicle
/// </summary>
public class ClsCheckingValueVehicle
{
    Database objDB2 = new Database();
    SqlCommand oCmd2 = new SqlCommand();
    
	public ClsCheckingValueVehicle()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Boolean insertvalue2()
    {
        oCmd2.Parameters.Add("@Formid", SqlDbType.Int).Value = FORMVId;
        oCmd2.Parameters.Add("@ImgVid", SqlDbType.Int).Value = ImgVid;
        if (objDB2.InsertDeleteStoredProcedure(oCmd2, "InsertApproved"))
        {
            return true;
        }
        else
            return false;
    }





    public int FORMVId { get; set; }
    public int ImgVid { get; set; }
}