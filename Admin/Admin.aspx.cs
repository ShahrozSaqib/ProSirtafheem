using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    ClsCheckingValue check = new ClsCheckingValue();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnapproved_Click(object sender, EventArgs e)
    {
       
    
        int getid =Convert.ToInt32(GridView1.SelectedValue);
        check.FORMPId = getid;
        check.ImgPid = getid;
        if (check.insertvalue() == true)
        {
            Response.Write("Your File has been Approved");
        }
        else
            Response.Write("Unable to Approved");
       
        

    }
    ClsCheckingValueVehicle insert = new ClsCheckingValueVehicle();
    protected void Button1_Click(object sender, EventArgs e)
    {
        insert.FORMVId = Convert.ToInt32(GridView2.SelectedValue);
        insert.ImgVid = Convert.ToInt32(GridView2.SelectedValue);
        if (insert.insertvalue2() == true)
        {
            Response.Write("Approved");
        }
        else
        {
            Response.Write("Unable to submit");
        }
    }
    protected void btnDenyVehicle_Click(object sender, EventArgs e)
    {

    }
}