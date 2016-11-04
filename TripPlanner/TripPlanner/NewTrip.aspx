<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTrip.aspx.cs" Inherits="TripPlanner.NewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TripPlannerConnectionString %>" SelectCommand="SELECT * FROM [Trips]"></asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TripPlannerConnectionString %>" SelectCommand="SELECT * FROM [Airports]"></asp:SqlDataSource>
        <br />
        <br />
        Full name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        Gender:
        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="">N/A</asp:ListItem>
            <asp:ListItem Value="m">Male</asp:ListItem>
            <asp:ListItem Value="f">Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Passport No:
        <asp:TextBox ID="txtPassport" runat="server"></asp:TextBox>
        <br />
        <br />
        Date:
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <br />
        Departure airport:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlDeparture" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="code">
        </asp:DropDownList>
        <br />
        <br />
        Arrival airport:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlArrival" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="code">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnAddTrip" runat="server" Text="Add Trip" OnClick="btnAddTrip_Click"/>
    
    </div>
    </form>
</body>
</html>
