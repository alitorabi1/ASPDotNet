<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="HelloWorld.start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        Stage preference form<br />
        <br />
        Prefered company size:<br />
        <asp:DropDownList ID="ddlCompanySize" runat="server">
            <asp:ListItem Value="fs">Family size</asp:ListItem>
            <asp:ListItem Value="ms">Medium size</asp:ListItem>
            <asp:ListItem Value="ls">Large size</asp:ListItem>
            <asp:ListItem Value="es">Enterprise</asp:ListItem>
        </asp:DropDownList>
        <br />
&nbsp;<br />
        Enter favorite programming language:<br />
        <br />
        <asp:RadioButtonList ID="rblLanguage" runat="server">
            <asp:ListItem Selected="True">ASP.NET</asp:ListItem>
            <asp:ListItem>PHP</asp:ListItem>
            <asp:ListItem>JAVA</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Other Programming Languages</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Enter your name:<br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
        <br />

        <br />
        <br />

    </div>
    </form>
</body>
</html>
