<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebToDo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:HyperLink ID="HyperLink1" NavigateUrl="Add.aspx" runat="server">Add ToDo Item</asp:HyperLink>
        <br />
        <br />
        <asp:GridView ID="gvToDoItems" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowDataBound="gvToDoItems_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                <asp:BoundField DataField="dueDate" HeaderText="dueDate" SortExpression="dueDate" DataFormatString="{0:M-dd-yyyy}">
                </asp:BoundField>
                <asp:CheckBoxField DataField="isDone" HeaderText="isDone" SortExpression="isDone" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ToDoItemsDBConnectionString %>" SelectCommand="SELECT * FROM [ToDoItems]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
