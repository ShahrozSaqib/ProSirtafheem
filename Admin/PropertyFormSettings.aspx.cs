using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PropertyFormSettings : System.Web.UI.Page
{
    ClsAdminInsertProperty InsertPro = new ClsAdminInsertProperty();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        InsertPro.PropertyType = txtInsertProperty.Text;
        if (InsertPro.insertPrpopertyType() == true)
        {
            lblConfirmationAddedProperty.Text = "Property Type Has been added.";

        }
        else
            lblConfirmationAddedProperty.Text = "UUnable to Add Property Type.";
    }
}