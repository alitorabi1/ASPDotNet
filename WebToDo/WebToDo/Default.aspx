<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebToDo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink id="hyperlink1" NavigateUrl="~/Add.aspx" Text="Add ToDo" runat="server"/>
        <br /><br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebToDoConnectionString %>" SelectCommand="SELECT * FROM [ToDos]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:WebToDoHConnectionString %>" SelectCommand="SELECT * FROM [ToDos]"></asp:SqlDataSource>
        <br />
        <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" OitCommand="DataGrid1_EditCommand">
            <alternatingitemstyle backcolor="White" forecolor="#284775" />
            <edititemstyle backcolor="#999999" />
            <footerstyle backcolor="#5D7B9D" font-bold="True" forecolor="White" />
            <headerstyle backcolor="#5D7B9D" font-bold="True" forecolor="White" />
            <itemstyle backcolor="#F7F6F3" forecolor="#333333" />
            <pagerstyle backcolor="#284775" forecolor="White" horizontalalign="Center" />
            <selecteditemstyle backcolor="#E2DED6" font-bold="True" forecolor="#333333" />
        </asp:DataGrid>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" 
            AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" 
            OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                <asp:BoundField DataField="dueDate" HeaderText="dueDate" SortExpression="dueDate" />
                <asp:BoundField DataField="isDone" HeaderText="isDone" SortExpression="isDone" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
