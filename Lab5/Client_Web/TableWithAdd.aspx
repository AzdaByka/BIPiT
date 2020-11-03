<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableWithAdd.aspx.cs" Inherits="Client_Web.TableWithAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="700px" Height="500px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">

             

            <AlternatingRowStyle BackColor="#cbe8ba" />
            <Columns>
                <asp:TemplateField HeaderText="X" ItemStyle-Width="10">                    
                   <ItemTemplate>                       
                       <asp:CheckBox ID="CheckBox1" runat="server" data-Value='<%# Eval("id_Order") %>'  />
                   </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />

<ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
               </asp:TemplateField>               
                <asp:TemplateField HeaderText="Код записи" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_o" runat="server" Text='<%# Eval("id_Order") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>                    

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Код клиента" Visible="false" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_stud" runat="server" Text='<%# Eval("id_Client_FK") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="ФИО клиента" ItemStyle-Width="150">
                    <ItemTemplate>
                        <asp:Label ID="FIO" runat="server" Text='<%# Eval("FIO") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Код Автобуса" Visible="false" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="id_dis" runat="server" Text='<%# Eval("id_Bus_FK") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Название автобуса" ItemStyle-Width="150">
                    <ItemTemplate>
                        <asp:Label ID="name_dis" runat="server" Text='<%# Eval("Name_car") %>'></asp:Label>
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
                 <asp:TemplateField HeaderText="Стоимость" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:Label ID="ocenkaEx" runat="server" Text='<%# Eval("cost") %>'></asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="Black" BorderWidth="1px" ForeColor="Black" />
                    <ItemStyle Width="50px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                </asp:TemplateField>
            </Columns>
              <AlternatingRowStyle BackColor="PaleGoldenrod" />
              <FooterStyle BackColor="Tan" />
              <HeaderStyle BackColor="Tan" Font-Bold="True" />
              <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
              <SortedAscendingCellStyle BackColor="#FAFAE7" />
              <SortedAscendingHeaderStyle BackColor="#DAC09E" />
              <SortedDescendingCellStyle BackColor="#E1DB9C" />
              <SortedDescendingHeaderStyle BackColor="#C2A47B" />
          </asp:GridView>
        </div>
        <div style=" width: 992px; height: 1057px;">
       <p>
           
        ФИО клиента: <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
       </p>
        <p>
            Автобус: <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        </p>
        
            Дата заказа: <asp:TextBox runat="server" ID="dateXEP"   type="date" ></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ValidationGroup ="Group1" ID="RequiredFieldValidator1" ControlToValidate="dateXEP" 
                ErrorMessage="Вы не выбрали дату!" Display="dynamic">Вы не выбрали дату!
            </asp:RequiredFieldValidator>
        
         <p>
            Стоимость: <asp:TextBox runat="server" ID="cost" type="number" min="1" value="1000" />
        </p>
        <p>
            <asp:Button ValidationGroup ="Group1" ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
            <asp:Label ID="Label2" runat="server" Text="Такая запись уже существует!" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>

       
       
    </div>
    </form>
</body>
</html>
