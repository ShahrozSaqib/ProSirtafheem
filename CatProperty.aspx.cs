using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class CatProperty : System.Web.UI.Page
{
  
    ClsImgProperty insertPropertyImg = new ClsImgProperty();
    ClsProperty InsertPropertyData = new ClsProperty();
    protected void Page_Load(object sender, EventArgs e)
    {
        UploadImgP.Visible = false;
    }
    protected void btnPostAd_Click(object sender, EventArgs e)
    {
        InsertPropertyData.PropertyAddress = txtPropertyaddress.Text;
        InsertPropertyData.PropertyType = DropdownPropertytype.SelectedValue;
        InsertPropertyData.Ownername = txtOwnerName.Text;
        InsertPropertyData.OwnerPhoneNo = txtOwnerPhoneNo.Text;
        Stream File1 = FileUpload1.PostedFile.InputStream;
        BinaryReader Unicode1 = new BinaryReader(File1);
        byte[] File_1 = Unicode1.ReadBytes((Int32)File1.Length);

        Stream File2 = FileUpload2.PostedFile.InputStream;
        BinaryReader Unicode2 = new BinaryReader(File2);
        byte[] File_2 = Unicode2.ReadBytes((Int32)File2.Length);
        
        Stream File3 = FileUpload3.PostedFile.InputStream;
        BinaryReader Unicode3 = new BinaryReader(File3);
        byte[] File_3 = Unicode3.ReadBytes((Int32)File3.Length);

        Stream File4 = FileUpload4.PostedFile.InputStream;
        BinaryReader Unicode4 = new BinaryReader(File4);
        byte[] File_4 = Unicode4.ReadBytes((Int32)File4.Length);
       
        Stream File5 = FileUpload5.PostedFile.InputStream;
        BinaryReader Unicode5 = new BinaryReader(File5);
        byte[] File_5 = Unicode5.ReadBytes((Int32)File5.Length);
        insertPropertyImg.img1 = File_1;
        insertPropertyImg.img2 = File_2;
        insertPropertyImg.img3 = File_3;
        insertPropertyImg.img4 = File_4;
        insertPropertyImg.img5 = File_5;

        
        
        
        if (RadiobtnPurposeRent.Checked)
        {
            InsertPropertyData.Purpose = RadiobtnPurposeRent.Text;
        }
        if (RadiobtnPurposeSale.Checked)
        {
            InsertPropertyData.Purpose = RadiobtnPurposeSale.Text;
        }
        else
        {
            lblConfirmationPropertyPost.Text = "Choose Purpose to Complete form";
        }
        InsertPropertyData.ListPrice =Convert.ToInt32(txtListPriceProperty.Text);
        
        if ((InsertPropertyData.insertPropertyData() == true) && (insertPropertyImg.insertPropertyData() == true))
        {
            lblConfirmationPropertyPost.ForeColor = System.Drawing.Color.Green;
            lblConfirmationPropertyPost.Text = "Data has been Submited and Can be view after Approval From Admin";
        }
        else
        {
            lblConfirmationPropertyPost.ForeColor = System.Drawing.Color.Red;
            lblConfirmationPropertyPost.Text = "Unable to Submit Data.";
        }

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        UploadImgP.Visible = true;
    }
}