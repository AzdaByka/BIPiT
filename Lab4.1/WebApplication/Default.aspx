<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="position:absolute; top:77px; left:196px; width: 1200px; height: 1200px;">
        <asp:TextBox ID="TextBox1" runat="server" type="date"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" type="date"></asp:TextBox>

        <asp:Button ID="Button2" runat="server" Text="Отобразить" OnClick="Button2_Click" />

       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentsConnectionString %>" SelectCommand="SELECT Ocenki.id_o, Ocenki.id_stud, Ocenki.id_dis, Ocenki.date, Ocenki.ocenka, Dis.id_dis AS Expr1, Dis.name_dis, Students.id, Students.FIO, Students.[Group], Students.N_zachetki FROM Ocenki INNER JOIN Dis ON Dis.id_dis = Ocenki.id_dis INNER JOIN Students ON Students.id = Ocenki.id_stud"></asp:SqlDataSource>

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="#cbe8ba" />
            <Columns>
                <asp:TemplateField HeaderText="X" ItemStyle-Width="10">                    
                   <ItemTemplate>                       
                       <asp:CheckBox ID="CheckBox2" runat="server" data-Value='<%# Eval("id_o") %>'  />
                   </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />

<ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
               </asp:TemplateField>               
                <asp:TemplateField HeaderText="Код записи" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_o" runat="server" Text='<%# Eval("id_o") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>                    

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Код студента" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_stud" runat="server" Text='<%# Eval("id_stud") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="ФИО студента" ItemStyle-Width="150">
                    <ItemTemplate>
                        <asp:Label ID="FIO" runat="server" Text='<%# Eval("FIO") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Код дисциплины" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_dis" runat="server" Text='<%# Eval("id_dis") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Дисциплина" ItemStyle-Width="150">
                    <ItemTemplate>
                        <asp:Label ID="name_dis" runat="server" Text='<%# Eval("name_dis") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Дата" ItemStyle-Width="150" >
                    <ItemTemplate>
                        <asp:Label ID="dateEx" runat="server" Text='<%# Eval("date","{0:dd.MM.yyyy}") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Оценка" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="ocenkaEx" runat="server" Text='<%# Eval("ocenka") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#cbe8ba" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#619c41" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#fefb64" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#fefb64" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Удалить" OnClick="Button1_Click" />
   </div>
   
</asp:Content>
