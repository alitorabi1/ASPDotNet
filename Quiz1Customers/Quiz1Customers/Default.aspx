<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Quiz1Customers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="hyperlink1" runat="server" NavigateUrl="~/Add.aspx" Text="Add Customer" />
    
        <br />
        <br />
        You have&nbsp;&nbsp;
        <asp:Label ID="lbMales" runat="server"></asp:Label>
        &nbsp;males and
        <asp:Label ID="lbFemales" runat="server"></asp:Label>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="select rank() OVER (ORDER BY a.Name, a.Gender) as rank,  a.ID, a.Name, a.Gender
   from [Customers] a
   order by rank 
"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="gvCustomers" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDataBound="gvCustomers_RowDataBound">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="rank" HeaderText=" # " ReadOnly="True" SortExpression="rank" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" NullDisplayText="N/A" SortExpression="Gender" />
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
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="select count(*) from customers where gender='m'"></asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="select count(*) from customers where gender='f'"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
