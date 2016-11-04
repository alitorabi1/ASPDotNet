<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Quiz1Customers.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <span style="background-color: #FAFAD2;color: #284775;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                <br />
                Province:
                <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
<br /></span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="background-color: #FFCC66;color: #000080;">Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                PostalCode:
                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                <br />
                Province:
                <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                <br />
                Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                Gender:
                <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /><br /></span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />PostalCode:
                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                <br />Province:
                <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                <br />Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />Gender:
                <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /><br /></span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="background-color: #FFFBD6;color: #333333;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                <br />
                Province:
                <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
<br /></span>
            </ItemTemplate>
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="background-color: #FFCC66;font-weight: bold;color: #000080;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                <br />
                Province:
                <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
<br /></span>
            </SelectedItemTemplate>
        </asp:ListView>
        <br />
        <asp:Button ID="btBack" runat="server" Text="Back" OnClick="btBack_Click" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Quiz1CustomersConnectionString %>" SelectCommand="SELECT * FROM [Customers] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="CustomerId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
