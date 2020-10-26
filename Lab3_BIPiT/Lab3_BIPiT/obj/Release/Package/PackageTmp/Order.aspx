<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Lab3_BIPiT.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentBusConnectionString %>" SelectCommand="SELECT [Order].id_Order, [Order].id_Client_FK, [Order].id_Bus_FK, [Order].date, [Order].cost, Client.id_Client, Client.FIO, Client.TEL, Bus.id_Bus, Bus.Name_car, Bus.VIN FROM [Order] INNER JOIN Client ON Client.id_Client = [Order].id_Client_FK INNER JOIN Bus ON Bus.id_Bus = [Order].id_Bus_FK"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" style="margin-left:200px;" runat="server" AutoGenerateColumns="False" DataKeyNames="id_Order,id_Client,id_Bus" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="500px" Width="1000px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_Client" HeaderText="id_Client" InsertVisible="False" ReadOnly="True" SortExpression="id_Client" Visible="False" />
            <asp:BoundField DataField="TEL" HeaderText="TEL" SortExpression="TEL" Visible="False" />
            <asp:BoundField DataField="id_Bus" HeaderText="id_Bus" InsertVisible="False" ReadOnly="True" SortExpression="id_Bus" Visible="False" />
            <asp:BoundField DataField="VIN" HeaderText="VIN" SortExpression="VIN" Visible="False" />
            <asp:BoundField DataField="id_Client_FK" HeaderText="id_Client_FK" SortExpression="id_Client_FK" Visible="False" />
            <asp:BoundField DataField="id_Bus_FK" HeaderText="id_Bus_FK" SortExpression="id_Bus_FK" Visible="False" />
            <asp:BoundField DataField="id_Order" HeaderText="№Заказа" InsertVisible="False" ReadOnly="True" SortExpression="id_Order" />
            <asp:BoundField DataField="FIO" HeaderText="ФИО" SortExpression="FIO" />
            <asp:BoundField DataField="Name_car" HeaderText="Название машины" SortExpression="Name_car" />
            <asp:BoundField DataField="cost" HeaderText="Цена" SortExpression="cost" />
            <asp:BoundField DataField="date" HeaderText="Дата" SortExpression="date" DataFormatString="{0:d}" />
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
</asp:Content>
