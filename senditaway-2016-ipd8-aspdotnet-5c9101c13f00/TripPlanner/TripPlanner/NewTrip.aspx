<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTrip.aspx.cs" Inherits="TripPlanner.NewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Full Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbFullName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvFullName"
             runat="server" 
            ErrorMessage="Name must be provided"
            ControlToValidate="tbFullName"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revFullName" runat="server"
     ControlToValidate="tbFullName" 
            ErrorMessage="The Name must contain between 2 and 100 characters " 
            ForeColor="Red" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        Gender:<asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Selected="True" Value="null">N/A</asp:ListItem>
            <asp:ListItem Value="M">Male</asp:ListItem>
            <asp:ListItem Value="F">Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Passport No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPassport" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rvfPassport"
             runat="server" 
            ErrorMessage="Passport must be provided"
            ControlToValidate="tbPassport"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revPassport" runat="server"
     ControlToValidate="tbPassport" 
            ErrorMessage="Passport must be in format AA012345 " 
            ForeColor="Red" ValidationExpression="^[A-Z]{2}[0-9]{6}$" ></asp:RegularExpressionValidator>
        <br />
        <br />
        Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbDate" TextMode="Date" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDate"
             runat="server" 
            ErrorMessage="Date must be selected"
            ControlToValidate="tbDate"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CustomValidator runat="server"
    ID="valDate" ControlToValidate="tbDate" onservervalidate="valDate_ServerValidate" 
            ErrorMessage="Date is in the past" ForeColor="Red" />
        <br />
        <br />
        Departure Airport:&nbsp;
        <asp:DropDownList ID="airportsFromList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode">
        </asp:DropDownList>
        <br />
        <br />
        Arrival Airport:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="airportsToList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode" >
        </asp:DropDownList>
        <asp:CompareValidator ID="CompareAirportsValidator" runat="server" 
            ErrorMessage="Departure and Arrival Airports cannot be the same" 
            ControlToCompare="airportsFromList" 
            Operator="NotEqual"
            ControlToValidate="airportsToList" ForeColor="Red"></asp:CompareValidator>

    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddTrip" runat="server" Text="Add Trip" OnClick="btnAddTrip_Click" />
        <br />
        <br />

    
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT code AS airportCode, (code + ' - ' + name) AS  airportName FROM [Airports]"></asp:SqlDataSource>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
