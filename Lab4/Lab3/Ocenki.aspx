<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ocenki.aspx.cs" Inherits="Lab3.Ocenki" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="position:absolute; top:77px; left:196px; width: 1200px; height: 1200px;">

      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_o,Expr1,id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="400px" Width="776px">
          <AlternatingRowStyle BackColor="White" />
          <Columns>
              <asp:BoundField DataField="id_o" HeaderText="Код записи" InsertVisible="False" ReadOnly="True" SortExpression="id_o" />
              <asp:BoundField DataField="id_stud" HeaderText="Код студента" SortExpression="id_stud" Visible="False" />
              <asp:BoundField DataField="FIO" HeaderText="ФИО студента" SortExpression="FIO" />
              <asp:BoundField DataField="Group" HeaderText="Группа" SortExpression="Group" />
              <asp:BoundField DataField="N_zachetki" HeaderText="Номер зачетки" SortExpression="N_zachetki" />
              <asp:BoundField DataField="id_dis" HeaderText="Код дисциплины" SortExpression="id_dis" />
              <asp:BoundField DataField="name_dis" HeaderText="Дисциплина" SortExpression="name_dis" />
              <asp:BoundField DataField="ocenka" HeaderText="Оценка" SortExpression="ocenka" />
              <asp:BoundField DataField="date" HeaderText="Дата" SortExpression="date" DataFormatString="{0:d}" />
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
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentsConnectionString2 %>" SelectCommand="SELECT Ocenki.id_o, Ocenki.id_stud, Ocenki.id_dis, Ocenki.date, Ocenki.ocenka, Dis.id_dis AS Expr1, Dis.name_dis, Students.id, Students.FIO, Students.[Group], Students.N_zachetki FROM Ocenki INNER JOIN Dis ON Ocenki.id_dis = Dis.id_dis INNER JOIN Students ON Ocenki.id_stud = Students.id"></asp:SqlDataSource>

      </div>
</asp:Content>
