<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gear.aspx.cs" Inherits="project1.gear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color:#FFF8DC;">
                <asp:HyperLink ID="HyperLink1" runat="server"
                Text='<%# Eval("ProductCategoryName") %>' NavigateUrl='<%# 
                String.Concat("~/products.aspx?categoryID=",Eval("ProductCategoryID")) %>'>
                </asp:HyperLink>

                <br /></td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">ProductCategoryName:
                <asp:TextBox ID="ProductCategoryNameTextBox" runat="server" Text='<%# Bind("ProductCategoryName") %>' />
                <br />ProductCategoryID:
                <asp:TextBox ID="ProductCategoryIDTextBox" runat="server" Text='<%# Bind("ProductCategoryID") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">ProductCategoryName:
                <asp:TextBox ID="ProductCategoryNameTextBox" runat="server" Text='<%# Bind("ProductCategoryName") %>' />
                <br />ProductCategoryID:
                <asp:TextBox ID="ProductCategoryIDTextBox" runat="server" Text='<%# Bind("ProductCategoryID") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color:#DCDCDC;color: #000000;">
                <asp:HyperLink ID="HyperLink2" runat="server"
                Text='<%# Eval("ProductCategoryName") %>' NavigateUrl='<%# 
                String.Concat("~/products.aspx?categoryID=",Eval("ProductCategoryID")) %>'>
                </asp:HyperLink>

                <br /></td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">ProductCategoryName:
                <asp:Label ID="ProductCategoryNameLabel" runat="server" Text='<%# Eval("ProductCategoryName") %>' />
                <br />ProductCategoryID:
                <asp:Label ID="ProductCategoryIDLabel" runat="server" Text='<%# Eval("ProductCategoryID") %>' />
                <br /></td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ProductCategoryName, ProductCategoryID 
FROM 
dbo.ufnGetAllCategories()
WHERE 
(ParentProductCategoryName = 
@cat
)">
        <SelectParameters>
            <asp:QueryStringParameter Name="cat" QueryStringField="category" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
