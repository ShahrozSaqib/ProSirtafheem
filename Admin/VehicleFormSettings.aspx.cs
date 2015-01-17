using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormControlSettings : System.Web.UI.Page
{
    ClsAdminInsertCarName insertcar = new ClsAdminInsertCarName();
    ClsAdminInsertManuName InsertManufacture = new ClsAdminInsertManuName();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
 
    protected void BtnInsertCarName_Click1(object sender, EventArgs e)
    {
           {
        insertcar.CarName = txtAdminInsertCarName.Text;
        insertcar.Manufacture = txtManufactureName.Text;
        if (insertcar.Insertcarname() == true)
        {
            LblConfirmationCar.Text = "Car Name has been added";
        }
        else
            LblConfirmationCar.Text = "Unable to CarName and Manufecture.";


    }
    }
    protected void btnAddManuname_Click1(object sender, EventArgs e)
    {
        InsertManufacture.ManufactureName = txtAdminInsertManuName.Text;
        if (InsertManufacture.InsertManuName() == true)
        {
            LblConfirmationManu.Text = "Manufacture Has Benn Added.";
        }
        else
        {
            LblConfirmationManu.Text = "Unable to Ad Manufecture.";
        }
    }
}