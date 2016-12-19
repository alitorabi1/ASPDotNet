<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convert.aspx.cs" Inherits="ChangeToUpper.Convert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convert temperature</title>
    <style>
        #lblError {
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Celsius"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="Label2" runat="server" Text="Fahrenheit"></asp:Label>
        <br />
        <asp:TextBox ID="txtCelcius" runat="server"></asp:TextBox>

        &nbsp;&nbsp;

        <asp:Button ID="btnConvertToFahr" runat="server" Text="->" OnClick="btnConvertToFahr_Click" />
        &nbsp;&nbsp;
        <asp:TextBox ID="txtFahrenheit" runat="server"></asp:TextBox>
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="<-" OnClick="btnConverToCel_Click" Width="27px" /><br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please provide a valid deimal point number or integer for Celcius" Operator="DataTypeCheck" Type="Double" ControlToValidate="txtCelcius"></asp:CompareValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Please provide a valid deimal point number or integer for Fahrenheit" Operator="DataTypeCheck" Type="Double" ControlToValidate="txtFahrenheit"></asp:CompareValidator>
    
    </form>
</body>
</html>
