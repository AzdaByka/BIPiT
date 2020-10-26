<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddForm.aspx.cs" Inherits="WebApplication.AddForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="position:absolute; top:45px; left:196px; width: 992px; height: 1057px;">
       
        
       <p>
           
        ФИО студента: <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
       </p>
        <p>
            Дисциплина: <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        </p>
        <p>
            Дата экзамена: <asp:TextBox runat="server" ID="dateEx" type="date" />            
            <asp:RequiredFieldValidator runat="server" ValidationGroup ="Group1" ID="RequiredFieldValidator1" ControlToValidate="dateEx" 
                ErrorMessage="Вы не выбрали дату!" Display="dynamic">Вы не выбрали дату!
            </asp:RequiredFieldValidator>
        </p>
         <p>
            Оценка: <asp:TextBox runat="server" ID="markEx" type="number" max="5" min="1" value="5"/>
             <asp:RequiredFieldValidator runat="server" ValidationGroup ="Group1" ID="RequiredFieldValidator2" ControlToValidate="markEx" 
                ErrorMessage="Вы не ввели оценку!" Display="dynamic">Вы не ввели оценку!
            </asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ValidationGroup ="Group1" ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
            <asp:Label ID="Label2" runat="server" Text="Такая запись уже существует!" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>

       
       
    </div>
</asp:Content>
