<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebToDo.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:SqlDataSource ID="SqlDS" runat="server" ConnectionString="<%$ ConnectionStrings:ToDoItemsDBConnectionString %>" SelectCommand="SELECT * FROM [ToDoItems] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    <div>
    
        Description:&nbsp;&nbsp;
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvDescription"
             runat="server" 
            ErrorMessage="Description must be provided"
            ControlToValidate="txtDescription"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revDescription" runat="server"
     ControlToValidate="txtDescription" 
            ErrorMessage="Description is too long" ForeColor="Red" ValidationExpression="^.{1,100}$" ></asp:RegularExpressionValidator>

        <br />
        Due Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDueDate" TextMode="Date" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDueDate"
             runat="server" 
            ErrorMessage="Date must be selected"
            ControlToValidate="txtDueDate"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CustomValidator runat="server"
    ID="valDate" ControlToValidate="txtDueDate" onservervalidate="valDateRange_ServerValidate" 
            ErrorMessage="Due Date is in the past" ForeColor="Red" />
        
        <br />
        <br />
        Is Done&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
         <asp:CheckBox ID="cbIsDone" runat="server" /><br /><br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
    
    </div>
       
         
       
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Back to the list</asp:HyperLink>
    </form>
</body>
</html>