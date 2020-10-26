<%@ Page Title="" Language="C#" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ListTable.aspx.vb" Inherits="Lab_4.Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div style="position:absolute; top:77px; left:196px; width: 1200px; height: 1200px;">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_Order" BorderColor="Black" BorderWidth="1px"  Width="700px" Height="500px" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
              <AlternatingRowStyle BackColor="White" />
              <Columns >
                  <asp:TemplateField HeaderText="X">
                      <ItemTemplate >
                          <asp:CheckBox ID="CheckBox1" runat="server" />
                      </ItemTemplate>
                      <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:TemplateField>
                  <asp:BoundField DataField="id_Order" HeaderText="id_Order" InsertVisible="False" ReadOnly="True" SortExpression="id_Order" >
                  <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:BoundField>
                  <asp:BoundField DataField="Name_car" HeaderText="Name_car" SortExpression="Name_car" >
                  <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:BoundField>
                  <asp:BoundField DataField="FIO" HeaderText="FIO" SortExpression="FIO" >
                  <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:BoundField>
                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" DataFormatString="{0:d}" >
                  <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:BoundField>
                  <asp:BoundField DataField="cost" HeaderText="cost" SortExpression="cost" >
                  <ItemStyle BorderColor="Black" BorderStyle="Double" />
                  </asp:BoundField>
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
          <asp:Button ID="Button1" runat="server" BackColor="#33CC33" Text="Удалить" />
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentBusConnectionString %>" SelectCommand="SELECT [Order].id_Order, Bus.Name_car, Client.FIO, [Order].date, [Order].cost FROM Bus INNER JOIN [Order] ON Bus.id_Bus = [Order].id_Bus_FK INNER JOIN Client ON [Order].id_Client_FK = Client.id_Client"></asp:SqlDataSource>
          </div>
</asp:Content>
