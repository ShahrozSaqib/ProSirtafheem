using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class CatVehicle : System.Web.UI.Page
{
    ClsImgVehicle InsertVehicleImg = new ClsImgVehicle();
    ClsVehicle InsertVehicleData = new ClsVehicle();
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
      
        UploadImgV.Visible = false;
    }
    protected void btnPostV_Click(object sender, EventArgs e)
    {
        InsertVehicleData.Manufecturer = DropDownManufecturer.SelectedValue;
        InsertVehicleData.VehicleName = DropDownVehicleName.SelectedValue;
        InsertVehicleData.ModelNo = txtModelNumer.Text;
        InsertVehicleData.OwnerName = txtOwnerName.Text;
        InsertVehicleData.OwnerPhoneNo = txtOwnerPhoneNumberV.Text;
      
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
        InsertVehicleImg.img1 = File_1;
        InsertVehicleImg.img2 = File_2;
        InsertVehicleImg.img3 = File_3;
        InsertVehicleImg.img4 = File_4;
        InsertVehicleImg.img5 = File_5;



        if (RadiobtnRent.Checked)
        {
            InsertVehicleData.Purpose = RadiobtnRent.Text;
        }
        if (RadiobtnSale.Checked)
        {
            InsertVehicleData.Purpose =RadiobtnSale.Text;
        }
       InsertVehicleData.ListPrice =Convert.ToInt32(txtListPriceV.Text);
        #region Submition Confirmation
        if ((InsertVehicleData.insertPropertyData() == true) && (InsertVehicleImg.insertvehicleimg()==true))
        {
            lblConfirmationVehiclePost.ForeColor = System.Drawing.Color.Green;
            lblConfirmationVehiclePost.Text = "Data Has been submited it will be viewed after Admin Approval.";
        }
        else
        {
            lblConfirmationVehiclePost.ForeColor = System.Drawing.Color.Red;
            lblConfirmationVehiclePost.Text = "Unable to Submit Data.";
        }
        #endregion
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        UploadImgV.Visible = true;
    }
}