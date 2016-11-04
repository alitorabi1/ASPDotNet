<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TripPlanner.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat="server">
        int counter()
        {
            int cnt = 0;
            return cnt++;
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink id="hyperlink1" NavigateUrl="~/NewTrip.aspx" Text="Plan new trip" runat="server"/>
        <br />
        <br />
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TripPlannerConnectionString %>" SelectCommand="select rank() OVER (ORDER BY a.fullName, a.gender, a.date) as rank,  a.ID, a.fullName, a.gender, a.date
   from [Trips] a
   order by rank 
"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" DataKeyNames="ID" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="rank" HeaderText=" # " SortExpression="rank" ReadOnly="True" />
                <asp:BoundField DataField="fullName" HeaderText="fullName" SortExpression="fullName" />
                <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" NullDisplayText="N/A" />
                <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    
        <br />
        <br />
        You have a total  
        <asp:Label ID="lblCounter" runat="server"></asp:Label>
&nbsp;of trips planned.</div>
    </form>
</body>
</html>
