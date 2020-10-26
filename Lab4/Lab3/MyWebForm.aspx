<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWebForm.aspx.cs" Inherits="Lab3.MyWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 444px; width: 764px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_o" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id_o" HeaderText="id_o" InsertVisible="False" ReadOnly="True" SortExpression="id_o" />
                    <asp:BoundField DataField="id_stud" HeaderText="id_stud" SortExpression="id_stud" />
                    <asp:BoundField DataField="id_dis" HeaderText="id_dis" SortExpression="id_dis" />
                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudConnectionString2 %>" SelectCommand="SELECT * FROM [Ocenki]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
