<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%-- Add content controls here --%>
<asp:Content ID="AdminContentBody12" ContentPlaceHolderID="AdminContentBody" runat="server">
<h2>Property Ad's</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="Id" DataSourceID="SqlDataSource1" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="PropertyAddress" HeaderText="PropertyAddress" 
                SortExpression="PropertyAddress" />
            <asp:BoundField DataField="PropertyType" HeaderText="PropertyType" 
                SortExpression="PropertyType" />
            <asp:BoundField DataField="OwnerName" HeaderText="OwnerName" 
                SortExpression="OwnerName" />
            <asp:BoundField DataField="OwnerPhone#" HeaderText="OwnerPhone#" 
                SortExpression="OwnerPhone#" />
            <asp:BoundField DataField="Purpose" HeaderText="Purpose" 
                SortExpression="Purpose" />
            <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" 
                SortExpression="ListPrice" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Button ID="btnapproved" runat="server" onclick="btnapproved_Click" 
                        Text="Approve" />
    <asp:Button ID="btnViewDetailsProperty" runat="server" Text="View Detail" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        SelectCommand="AdminSelectFORMP" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <hr />
<h2>Vehicle Ad's</h2>
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="id" DataSourceID="SqlDataSource2" BorderStyle="Solid" 
        BorderWidth="0px" CellPadding="4" ForeColor="#333333" GridLines="None" 
        Width="856px" style="margin-right: 0px">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
            ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="VehicleName" HeaderText="VehicleName" 
            SortExpression="VehicleName" />
        <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" 
            SortExpression="Manufacturer" />
        <asp:BoundField DataField="Model#" HeaderText="Model#" 
            SortExpression="Model#" />
        <asp:BoundField DataField="OwnerName" HeaderText="OwnerName" 
            SortExpression="OwnerName" />
        <asp:BoundField DataField="OwnerPhone#" HeaderText="OwnerPhone#" 
            SortExpression="OwnerPhone#" />
        <asp:BoundField DataField="Purpose" HeaderText="Purpose" 
            SortExpression="Purpose" />
        <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" 
            SortExpression="ListPrice" />
    </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Button ID="btnApprovedVehicle" runat="server" onclick="Button1_Click" 
                    Text="Approve" />
    <asp:Button ID="btnViewDetailVehicle" runat="server" Text="View Detial" />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        SelectCommand="AdminSelectFORMV" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
</asp:Content>