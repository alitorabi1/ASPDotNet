<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Quiz1Customers.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Name:
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvFullName"
             runat="server" 
            ErrorMessage="Name must be provided"
            ControlToValidate="tbName"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revFullName" runat="server"
            ControlToValidate="tbName" 
            ErrorMessage="The Name must contain between 2 and 100 characters " 
            ForeColor="Red" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        Postal code:
        <asp:TextBox ID="tbPostalCode" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
             runat="server" 
            ErrorMessage="Postal code must be provided"
            ControlToValidate="tbPostalCode"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
            ControlToValidate="tbPostalCode" 
            ErrorMessage="The postal code must be in Canadian format" 
            ForeColor="Red" ValidationExpression="^(?!.*[DFIOQU])[A-VXY][0-9][A-Z] ?[0-9][A-Z][0-9]$"></asp:RegularExpressionValidator>
        <br />
        <br />
        Province:
        <asp:DropDownList ID="ddlProvince" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Code">
        </asp:DropDownList>
        <br />
        <br />
        Email:
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
             runat="server" 
            ErrorMessage="Email must be provided"
            ControlToValidate="tbEmail"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
            ControlToValidate="tbEmail" 
            ErrorMessage="The Email must be correct"
            ForeColor="Red" ValidationExpression="^.+\@.+\..+$"></asp:RegularExpressionValidator>
        <br />
        <br />
        Gender:
        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="m" Selected="True">Male</asp:ListItem>
            <asp:ListItem Value="f">Female</asp:ListItem>
            <asp:ListItem Value="">N/A</asp:ListItem>
        </asp:RadioButtonList>
    
        <br />
        <br />
        <asp:Button ID="btAddCustomer" runat="server" Text="Add Customer" OnClick="btAddCustomer_Click" />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="SELECT [Name], [Code] FROM [Provinces]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
