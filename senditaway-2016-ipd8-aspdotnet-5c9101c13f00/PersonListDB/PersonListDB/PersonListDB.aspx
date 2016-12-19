<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonListDB.aspx.cs" Inherits="PersonListDB.PersonListDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
            ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ControlToValidate="txtName" ErrorMessage="Name must be at least 2 characters long"
                ForeColor="Red" ValidationExpression="^[A-Za-z]{2,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Age:&nbsp;&nbsp;
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2" runat="server"
                ErrorMessage="RequiredFieldValidator" ControlToValidate="txtName"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeValidator1" runat="server" ForeColor="Red" ErrorMessage="Age must be between 0 and 150" ControlToValidate="txtAge" MaximumValue="150" MinimumValue="0" Type="Integer"></asp:RangeValidator>

        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"
                Style="height: 26px" />
        </p>
        <asp:BulletedList ID="personList" runat="server"></asp:BulletedList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PersonDBConnectionString2 %>" SelectCommand="SELECT * FROM [Persons]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
            </Columns>
        </asp:GridView>

        <p>
            &nbsp;
        </p>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PersonDBConnectionString3 %>" SelectCommand="SELECT * FROM [Persons]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    </form>

</body>
</html>
