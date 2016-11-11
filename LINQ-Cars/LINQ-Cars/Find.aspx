<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Find.aspx.cs" Inherits="LINQ_Cars.Find" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvCars" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="LinqDataSource2">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="DriverLicense" HeaderText="DriverLicense" SortExpression="DriverLicense" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
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
        <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="LINQ_Cars.CarsDataContext" EntityTypeName="" TableName="Owners">
        </asp:LinqDataSource>
        <br /><br />
        <asp:GridView ID="gvOwners" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Plates" HeaderText="Plates" SortExpression="Plates" />
                <asp:BoundField DataField="Yop" HeaderText="Yop" SortExpression="Yop" />
                <asp:BoundField DataField="OwnerId" HeaderText="OwnerId" SortExpression="OwnerId" />
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
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="LINQ_Cars.CarsDataContext" EntityTypeName="" TableName="Cars">
        </asp:LinqDataSource>
        <br /><br />
        <asp:Button ID="btCarsNoOwner" runat="server" Text="All Cars without owner" OnClick="btCarsNoOwner_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btOwnersMoreThanOneCar" runat="server" Text="All owners withmore than one car" OnClick="btOwnersMoreThanOneCar_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btCarsMadeBetweenMinAndMax" runat="server" Text="All cars made in year between min and Max" OnClick="btCarsMadeBetweenMinAndMax_Click" />
        <br /><br />
        <asp:Button ID="btOwnersAgeBetweenMinAndMax" runat="server" Text="All owners whose age is between min and max" OnClick="btOwnersAgeBetweenMinAndMax_Click" />
        <br /><br />
        All cars and their owners where car&#39;s make or model contains :
        <asp:TextBox ID="tbFind" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btFind" runat="server" Text="Find" OnClick="btFind_Click" />
        <br /><br />
        <asp:GridView ID="gvResult" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </div>
    </form>
</body>
</html>
