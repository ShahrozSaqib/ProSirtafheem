using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsVehicle
/// </summary>
public class ClsVehicle
{
    SqlCommand oCmd=new SqlCommand();
    Database objDB=new Database();
	public ClsVehicle()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #region Funtion

    public Boolean insertPropertyData()
    {
        oCmd.Parameters.Add("@VehicleName", SqlDbType.VarChar).Value = VehicleName;
        oCmd.Parameters.Add("@Manufacturer", SqlDbType.VarChar).Value = Manufecturer;
        oCmd.Parameters.Add("@Modelno", SqlDbType.VarChar).Value = ModelNo;
        oCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = OwnerName;
        oCmd.Parameters.Add("@OwnerPhoneno", SqlDbType.Char).Value = OwnerPhoneNo;
        oCmd.Parameters.Add("@Purpose", SqlDbType.VarChar).Value = Purpose;
        oCmd.Parameters.Add("@ListPrice", SqlDbType.Int).Value = ListPrice;

        if (objDB.InsertDeleteStoredProcedure(oCmd, "InsertVehicleData"))
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
        public string VehicleName { get; set; }
        public string Manufecturer { get; set; }
        public string ModelNo { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNo { get; set; }
        public string Purpose { get; set; }
        public int ListPrice { get; set; }
    #endregion
}