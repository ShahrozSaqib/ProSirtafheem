<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<h2>Property Advertisment</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" CellPadding="9" ForeColor="#333333" 
        GridLines="None" BorderStyle="Solid" CellSpacing="2" Height="245px" 
        RowHeaderColumn="PropertyAddress" Width="850px" style="margin-right: 0px" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="PropertyAddress" HeaderText="PropertyAddress" 
                SortExpression="PropertyAddress" />
            <asp:BoundField DataField="PropertyType" HeaderText="PropertyType" 
                SortExpression="PropertyType" />
            <asp:BoundField DataField="Purpose" HeaderText="Purpose" 
                SortExpression="Purpose" />
            <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" 
                SortExpression="ListPrice" />
            <asp:TemplateField ShowHeader="False" HeaderText="Details">
                <ItemTemplate>
                    <asp:Button ID="BtnDetailView1" runat="server" Text="View Detail" 
                        onclick="BtnDetailView_Click" PostBackUrl="~/MainSite/ViewDetails.aspx" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BorderColor="BlueViolet" BackColor="#E2DED6" Font-Bold="True" 
            ForeColor="#333333" />
        
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        SelectCommand="ApprovedAdds" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
<hr />
<h2>Vehicle Advertisment</h2>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource2" BorderStyle="Solid" CellPadding="9" 
        CellSpacing="2" ForeColor="#333333" GridLines="None" Width="850px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" 
                SortExpression="Manufacturer" />
            <asp:BoundField DataField="VehicleName" HeaderText="VehicleName" 
                SortExpression="VehicleName" />
            <asp:BoundField DataField="Model#" HeaderText="Model#" 
                SortExpression="Model#" />
            <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" 
                SortExpression="ListPrice" />
            <asp:TemplateField ShowHeader="False" HeaderText="Details">
                <ItemTemplate>
                    <asp:Button ID="btnDetailViewVehcile" runat="server" Text="View Detials" 
                        onclick="btnDetailViewVehcile_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
        
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        SelectCommand="ApprovedVehicle" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
        
    </asp:Content>
