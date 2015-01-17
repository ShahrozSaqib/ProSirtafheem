<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ViewDetails.aspx.cs" Inherits="MainSite_ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<h2 id="H2heading" runat="server">Vehicles</h2>

<div id="MainImage" runat="server">
    <asp:Image ID="image1" runat="server" ImageUrl="~/Image/Jellyfish.jpg" Width="500" Height="350" />
</div>
 <div>    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" 
         onselectedindexchanged="ListView1_SelectedIndexChanged">
     <AlternatingItemTemplate>
         <span style="">PropertyAddress:
         <asp:Label ID="PropertyAddressLabel" runat="server" 
             Text='<%# Eval("PropertyAddress") %>' />
         <br />
         PropertyType:
         <asp:Label ID="PropertyTypeLabel" runat="server" 
             Text='<%# Eval("PropertyType") %>' />
         <br />
         OwnerName:
         <asp:Label ID="OwnerNameLabel" runat="server" Text='<%# Eval("OwnerName") %>' />
         <br />
         Phone # :
         <asp:Label ID="column1Label" runat="server" Text='<%# Eval("column1") %>' Font-Bold="True" />
         <br />
         Purpose:
         <asp:Label ID="PurposeLabel" runat="server" Text='<%# Eval("Purpose") %>' />
         <br />
<br /></span>
     </AlternatingItemTemplate>
     <EditItemTemplate>
         <span style="">PropertyAddress:
         <asp:TextBox ID="PropertyAddressTextBox" runat="server" 
             Text='<%# Bind("PropertyAddress") %>' />
         <br />
         PropertyType:
         <asp:TextBox ID="PropertyTypeTextBox" runat="server" 
             Text='<%# Bind("PropertyType") %>' />
         <br />
         OwnerName:
         <asp:TextBox ID="OwnerNameTextBox" runat="server" 
             Text='<%# Bind("OwnerName") %>' />
         <br />
         column1:
         <asp:TextBox ID="column1TextBox" runat="server" Text='<%# Bind("column1") %>' Font-Bold="True" />
         <br />
         Purpose:
         <asp:TextBox ID="PurposeTextBox" runat="server" Text='<%# Bind("Purpose") %>' />
         <br />
         <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
             Text="Update" />
         <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
             Text="Cancel" />
         <br /><br /></span>
     </EditItemTemplate>
     <EmptyDataTemplate>
         <span>No data was returned.</span>
     </EmptyDataTemplate>
     <InsertItemTemplate>
         <span style="">PropertyAddress:
         <asp:TextBox ID="PropertyAddressTextBox" runat="server" 
             Text='<%# Bind("PropertyAddress") %>' />
         <br />PropertyType:
         <asp:TextBox ID="PropertyTypeTextBox" runat="server" 
             Text='<%# Bind("PropertyType") %>' />
         <br />OwnerName:
         <asp:TextBox ID="OwnerNameTextBox" runat="server" 
             Text='<%# Bind("OwnerName") %>' />
         <br />column1:
         <asp:TextBox ID="column1TextBox" runat="server" Text='<%# Bind("column1") %>' />
         <br />Purpose:
         <asp:TextBox ID="PurposeTextBox" runat="server" Text='<%# Bind("Purpose") %>' />
         <br />
         <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
             Text="Insert" />
         <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
             Text="Clear" />
         <br /><br /></span>
     </InsertItemTemplate>
     <ItemTemplate>
         <span style="">PropertyAddress:
         <asp:Label ID="PropertyAddressLabel" runat="server" 
             Text='<%# Eval("PropertyAddress") %>' />
         <br />
         PropertyType:
         <asp:Label ID="PropertyTypeLabel" runat="server" 
             Text='<%# Eval("PropertyType") %>' />
         <br />
         OwnerName:
         <asp:Label ID="OwnerNameLabel" runat="server" Text='<%# Eval("OwnerName") %>' />
         <br />
         column1:
         <asp:Label ID="column1Label" runat="server" Text='<%# Eval("column1") %>' Font-Strikeout="False" Font-Bold="True" />
         <br />
         Purpose:
         <asp:Label ID="PurposeLabel" runat="server" Text='<%# Eval("Purpose") %>' />
         <br />
<br /></span>
     </ItemTemplate>
     <LayoutTemplate>
         <div ID="itemPlaceholderContainer" runat="server" style="">
             <span runat="server" id="itemPlaceholder" />
         </div>
         <div style="">
         </div>
     </LayoutTemplate>
     <SelectedItemTemplate>
         <span style="">PropertyAddress:
         <asp:Label ID="PropertyAddressLabel" runat="server" 
             Text='<%# Eval("PropertyAddress") %>' />
         <br />
         PropertyType:
         <asp:Label ID="PropertyTypeLabel" runat="server" 
             Text='<%# Eval("PropertyType") %>' />
         <br />
         OwnerName:
         <asp:Label ID="OwnerNameLabel" runat="server" Text='<%# Eval("OwnerName") %>' />
         <br />
         column1:
         <asp:Label ID="column1Label" runat="server" Text='<%# Eval("column1") %>' />
         <br />
         Purpose:
         <asp:Label ID="PurposeLabel" runat="server" Text='<%# Eval("Purpose") %>' />
         <br />
<br /></span>
     </SelectedItemTemplate>
            
    </asp:ListView>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
         ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
         SelectCommand="SELECT [PropertyAddress], [PropertyType], [OwnerName], [OwnerPhone#] AS column1, [Purpose] FROM [FORMP] WHERE Id=1">
     </asp:SqlDataSource>
    </div>   

</asp:Content>


