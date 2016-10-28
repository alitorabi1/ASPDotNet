<%@ Page Title="" Language="C#" MasterPageFile="~/Bicycle.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Bicycle.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber" SortExpression="ProductNumber" />
        <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" NullDisplayText="N/A" />
        <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" SortExpression="ListPrice" />
        <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" NullDisplayText="N/A" />
        <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" NullDisplayText="N/A" />
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ProductID, Name, ProductNumber, Color, ListPrice, Size, Weight FROM SalesLT.Product WHERE (ProductCategoryID = @param)">
    <SelectParameters>
        <asp:QueryStringParameter Name="param" QueryStringField="categoryid" />
    </SelectParameters>
</asp:SqlDataSource>
    </asp:Content>
