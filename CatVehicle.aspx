<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CatVehicle.aspx.cs" Inherits="CatVehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Insert Vehicle Information</h2>
    <hr />
<table>
    <tr>
        <td>
            <asp:Label ID="lblManufecturer" runat="server" Text="Manufecturer Name"></asp:Label></td>
        <td>
            <asp:DropDownList ID="DropDownManufecturer" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource1" DataTextField="Manufacturer" 
                DataValueField="Manufacturer">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
                SelectCommand="DropDownListSelectCarManufecturer" 
                SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </td>
    </tr>
    <tr>
        <td><asp:Label ID="LblVehicleName" runat="server" Text="VehicleName"></asp:Label></td>
        <td>
            <asp:DropDownList ID="DropDownVehicleName" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource2" DataTextField="CarName" DataValueField="CarName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
                SelectCommand="SELECT [CarName] FROM [CarNames] WHERE ([Manufecturer] = @Manufecturer) ORDER BY [CarName]">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownManufecturer" Name="Manufecturer" 
                        PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="lblModel" runat="server" Text="Model Number"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtModelNumer" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Vehicle Picture</td>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Image/Upload Img.png" onclick="ImageButton1_Click" />
        </td>
    </tr>
    <div id="UploadImgV" runat="server">
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
        <td><asp:Label ID="lblOwnerName" runat="server" Text="Owner Name"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblOwnerPhoneNumber" runat="server" Text="Owner Phone No"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtOwnerPhoneNumberV" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="PurposeOfPost" runat="server" Text="Purpose of Post"></asp:Label></td>
        <td>
            <asp:RadioButton ID="RadiobtnRent" runat="server" Text="Rent" GroupName="Vehiclegroup" />
            <asp:RadioButton ID="RadiobtnSale" runat="server" Text="Sale" GroupName="Vehiclegroup" /></td>
    </tr> 
    <tr>
        <td><asp:Label ID="lblListPriceV" runat="server" Text="List Price"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtListPriceV" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnPostV" runat="server" Text="Post" onclick="btnPostV_Click" /></td>
        <td>
            <asp:Label ID="lblConfirmationVehiclePost" runat="server" Text=""></asp:Label></td>
    </tr>
</table>
</asp:Content>

