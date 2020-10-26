<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dis.aspx.cs" Inherits="Lab3.Dis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="position:absolute; top:77px; left:196px; width: 1200px; height: 1200px;">
        <asp:GridView ID="GridView1" runat="server" Height="400px" Width="776px" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_dis" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_dis" HeaderText="Код дисциплины" InsertVisible="False" ReadOnly="True" SortExpression="id_dis" />
                <asp:BoundField DataField="name_dis" HeaderText="Дисциплина" SortExpression="name_dis" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentsConnectionString2 %>" SelectCommand="SELECT * FROM [Dis]"></asp:SqlDataSource>
     </div>

</asp:Content>
