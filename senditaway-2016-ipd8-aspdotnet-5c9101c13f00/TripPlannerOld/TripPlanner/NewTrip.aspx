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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        Gender:<asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="NULL">N/A</asp:ListItem>
            <asp:ListItem Value="M">M</asp:ListItem>
            <asp:ListItem Value="F">F</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Passport No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPassport" runat="server"></asp:TextBox>
    
        <br />
        Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbDate" TextMode="Date" runat="server"></asp:TextBox>
    
        <br />
        Departure Airport:&nbsp;
        <asp:DropDownList ID="airportsFromList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode">
        </asp:DropDownList><br />
        Arrival Airport:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="airportsToList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode" >
        </asp:DropDownList>

    
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT code AS airportCode, (code + ' - ' + name) AS  airportName FROM [Airports]"></asp:SqlDataSource>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddTrip" runat="server" Text="Add Trip" OnClick="btnAddTrip_Click" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
