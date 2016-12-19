<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonList.aspx.cs" Inherits="ChangeToUpper.PersonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ErrorMessage="Name must not be empty" ForeColor="Red"
                ControlToValidate="txtName">
            </asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1" runat="server"
                ControlToValidate="txtName"
                ErrorMessage="Name must be at least 2 characters long"
                ForeColor="Red" ValidationExpression="^[a-zA-Z]{2,}$">
            </asp:RegularExpressionValidator>
            <br />
            <br />
            Age:&nbsp;&nbsp;
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2"
                runat="server" ErrorMessage="Age must not be empty"
                ControlToValidate="txtAge">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ForeColor="Red" ErrorMessage="Age must be between 0 and 150"
                ControlToValidate="txtAge" MaximumValue="150" MinimumValue="0"
                Type="Integer"></asp:RangeValidator>

        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add"
                OnClick="btnAdd_Click" Style="height: 26px" />
        </p>
        <asp:BulletedList ID="personList" runat="server"></asp:BulletedList>
    </form>

</body>
</html>
