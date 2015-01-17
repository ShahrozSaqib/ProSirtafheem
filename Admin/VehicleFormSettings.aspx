<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="VehicleFormSettings.aspx.cs" Inherits="FormControlSettings" %>

<%-- Add content controls here --%>


<asp:Content ID="AdminContentBody13" ContentPlaceHolderID="AdminContentBody" runat="server">
<h3 id="abcs" runat="server">Listed Manufacturer</h3>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="CarManuId" DataSourceID="SqlDataSource1" AllowSorting="True" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CarManuId" HeaderText="CarManuId" 
                InsertVisible="False" ReadOnly="True" SortExpression="CarManuId" />
            <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" 
                SortExpression="Manufacturer" />
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
        
    </asp:GridView> <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        SelectCommand="AdminSelectManufacture" SelectCommandType="StoredProcedure" 
        DeleteCommand="DELETE FROM CarManufacturer WHERE (CarManuId = @CarManuId)" 
        UpdateCommand="UPDATE CarManufacturer SET CarManuId = @CarManuId, Manfacturer = @Manufacturer WHERE (CarManuId = @CarManuId)">
        <DeleteParameters>
            <asp:Parameter Name="CarManuId" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="CarManuId" />
            <asp:Parameter Name="Manufacturer" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:Label ID="lblAdminListListedManu" Text="Insert Manufacture Name" runat="server"></asp:Label> | 
    <asp:TextBox ID="txtAdminInsertManuName" runat="server" style="width: 128px" ></asp:TextBox>
    <asp:Button ID="btnAddManuname" runat="server" Width="40px" Text="Add" 
        onclick="btnAddManuname_Click1" /><asp:Label ID="LblConfirmationManu" runat="server" Text=""></asp:Label>
    
    <h3>Listed Vehcile Names</h3>
<asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CarNamesId" 
        DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="CarNamesId" HeaderText="CarNamesId" 
            InsertVisible="False" ReadOnly="True" SortExpression="CarNamesId" />
        <asp:BoundField DataField="CarName" HeaderText="CarName" 
            SortExpression="CarName" />
        <asp:BoundField DataField="Manufecturer" HeaderText="Manufecturer" 
            SortExpression="Manufecturer" />
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
<table>
    <tr>
        <td><asp:Label ID="lblAdminInsertCarname" runat="server" Text="Insert Car Name"> </asp:Label></td>
        <td><asp:TextBox ID="txtAdminInsertCarName"
        runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblinsertManufacture" runat="server" Text="Manufacture Name"></asp:Label></td>
        <td>
    <asp:TextBox ID="txtManufactureName" runat="server"></asp:TextBox></td>
    </tr>
</table>
    <asp:Button ID="BtnInsertCarName"
        runat="server" Text="Add" onclick="BtnInsertCarName_Click1" /><asp:Label ID="LblConfirmationCar" runat="server" Text=""></asp:Label>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        DeleteCommand="Delete From CarNames Where CarNamesId=@CarNamesId" 
        SelectCommand="AdminSelectCarNames" SelectCommandType="StoredProcedure" 
        
        UpdateCommand="UPDATE CarNames SET CarName = @CarName WHERE (CarNamesId = @CarNamesId)">
    <DeleteParameters>
        <asp:Parameter Name="CarNamesId" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="CarName" />
        <asp:Parameter Name="CarNamesId" />
    </UpdateParameters>
    </asp:SqlDataSource>
    <h3> Enable/Disable Fields</h3>
    <table>
      <tr>
        <td>
            <asp:Label ID="LabelManufectureName" runat="server" Text="ManufectureName"></asp:Label>       </td>
        <td>
            <asp:CheckBox ID="ChkDisbale" Text="Disable" runat="server" /></td>
      </tr>
    </table>

    </asp:Content>