<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="HWorld.start" %>

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
        Prefered Company Size<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Family Size</asp:ListItem>
            <asp:ListItem>Medium</asp:ListItem>
            <asp:ListItem>Large</asp:ListItem>
            <asp:ListItem>Multi National</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Enter Favorite Programming Language<br />
        <asp:RadioButtonList ID="rdlLanguage" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>ASP.NET</asp:ListItem>
            <asp:ListItem>PHP</asp:ListItem>
            <asp:ListItem>JAVA</asp:ListItem>
            <asp:ListItem>Other</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        Enter your name<br />
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
