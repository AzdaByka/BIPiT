<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="Lab3_BIPiT.MyForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" style="margin-left:200px;" runat="server" AutoGenerateColumns="False" DataKeyNames="id_Bus" DataSourceID="SqlDataSource1" CellPadding="4"  Height="500px" Width="1000px" ForeColor="#333333" GridLines="None" >
        <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="id_Bus" HeaderText="№ строки" InsertVisible="False" ReadOnly="True" SortExpression="id_Bus" />
        <asp:BoundField DataField="Name_car" HeaderText="Название машины" SortExpression="Name_car" />
        <asp:BoundField DataField="VIN" HeaderText="VIN" SortExpression="VIN" />
    </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentBusConnectionString %>" SelectCommand="SELECT * FROM [Bus]"></asp:SqlDataSource>
</asp:Content>
