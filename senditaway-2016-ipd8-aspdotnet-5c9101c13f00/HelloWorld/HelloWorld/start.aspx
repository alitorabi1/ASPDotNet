<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="HelloWorld.start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Hello First Page</div>

        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    &nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
        <br />
        </form>
</body>
</html>
