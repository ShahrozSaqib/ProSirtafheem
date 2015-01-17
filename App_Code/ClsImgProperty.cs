using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for ClsImgProperty
/// </summary>
public class ClsImgProperty
{
    SqlCommand oCmd = new SqlCommand();
    Database objDB = new Database();

	public ClsImgProperty()
	{
		//
		// TODO: Add constructor logic here
		//
	}
#region Funtion
    public Boolean insertPropertyData()
    {
       
        oCmd.Parameters.Add("@img1", SqlDbType.Binary).Value = img1;
        oCmd.Parameters.Add("@img2", SqlDbType.Binary).Value = img2;
        oCmd.Parameters.Add("@img3", SqlDbType.Binary).Value = img3;
        oCmd.Parameters.Add("@img4", SqlDbType.Binary).Value = img4;
        oCmd.Parameters.Add("@img5", SqlDbType.Binary).Value = img5;
        if (objDB.InsertDeleteStoredProcedure(oCmd, "InsertPropertyImg"))
        {
            return true;
        }
        else
            return false;
    }



#endregion
    #region Property

    public byte[] img1 { get; set; }
    public byte[] img2 { get; set; }
    public byte[] img3 { get; set; }
    public byte[] img4 { get; set; }
    public byte[] img5 { get; set; }
#endregion

}