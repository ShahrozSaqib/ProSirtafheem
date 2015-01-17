<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CatProperty.aspx.cs" Inherits="CatProperty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h2>Insert Property Information</h2>
<hr />
<div>
<table>
    <tr>
        <td><asp:Label ID="lblPropertyaddress" Text="Property Address" runat="server"></asp:Label></td>
        <td><asp:TextBox ID="txtPropertyaddress" runat="server" ></asp:TextBox></td> 
    </tr>
    <tr>
        <td><asp:Label ID="lblPropertyType" Text="Property Type" runat="server"></asp:Label></td>
        <td><asp:DropDownList ID="DropdownPropertytype" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource1" DataTextField="PropertyType" 
                DataValueField="PropertyType">
            <asp:ListItem Selected="True">Select Type</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
                SelectCommand="DropDownListSelectPropertyType" 
                SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
         <td>
             <asp:Label ID="lblUploadImgP" runat="server" Text="Upload Picture"></asp:Label></td>
         <td>
             <asp:ImageButton ID="ImageButton1" runat="server" 
                 ImageUrl="~/Image/Upload Img.png" onclick="ImageButton1_Click" /></td>       
    </tr>
    <div id="UploadImgP" runat="server" > 
    <tr>
        <td></td>
         <td>
             <asp:FileUpload ID="FileUpload1" runat="server" /><br />
             <asp:FileUpload ID="FileUpload2" runat="server" /><br />
             <asp:FileUpload ID="FileUpload3" runat="server" /><br />
             <asp:FileUpload ID="FileUpload4" runat="server" /><br />
             <asp:FileUpload ID="FileUpload5" runat="server" /></td>   
    </tr>
    </div>
    <tr>
        <td><asp:Label ID="lblOwnerName" Text="Name of Owner" runat="server"></asp:Label></td>
        <td><asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox></td>
    </tr>  
    <tr>
        <td><asp:Label ID="lblOwnerPhoneNo" Text="Owner Phone#" runat="server"></asp:Label></td>
        <td><asp:TextBox ID="txtOwnerPhoneNo" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblPurpose" runat="server" Text="Purpose of Post"></asp:Label></td>
        <td><asp:RadioButton ID="RadiobtnPurposeRent" runat="server" Text="Rent" GroupName="Purpose" />   <asp:RadioButton ID="RadiobtnPurposeSale" runat="server" Text="Sale" GroupName="Purpose" /></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblListPrice" runat="server" Text="List Price"></asp:Label></td>
        <td><asp:TextBox ID="txtListPriceProperty" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Button ID="btnPostAd" Text="Post" runat="server" 
                onclick="btnPostAd_Click" /></td>
        <td><asp:Label Text="" ID="lblConfirmationPropertyPost" runat="server"></asp:Label></td>
    </tr>
</table>
</div>

</asp:Content>

