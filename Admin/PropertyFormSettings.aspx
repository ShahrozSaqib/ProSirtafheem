<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="PropertyFormSettings.aspx.cs" Inherits="PropertyFormSettings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AdminContentBody" Runat="Server">
<h2>Listed Property Types</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="PTypeId" DataSourceID="SqlDataSource1" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="PTypeId" HeaderText="PTypeId" InsertVisible="False" 
                ReadOnly="True" SortExpression="PTypeId" />
            <asp:BoundField DataField="PropertyType" HeaderText="PropertyType" 
                SortExpression="PropertyType" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SirTafheemConnectionString %>" 
        DeleteCommand="DELETE FROM PropertyType WHERE (PTypeId = @PTypeId)" 
        SelectCommand="AdminSelectProperty" SelectCommandType="StoredProcedure" 
        
        UpdateCommand="UPDATE PropertyType SET PropertyType = @PropertyType WHERE (PTypeId = @PTypeId)">
        <DeleteParameters>
            <asp:Parameter Name="PTypeId" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="PropertyType" />
            <asp:Parameter Name="PTypeId" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblAdminPropertytype" runat="server" Text="Insert Property"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtInsertProperty" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnAdd" runat="server" Text="Add" onclick="BtnAdd_Click" />
               </td>
            <td> <asp:Label ID="lblConfirmationAddedProperty" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
</asp:Content>

