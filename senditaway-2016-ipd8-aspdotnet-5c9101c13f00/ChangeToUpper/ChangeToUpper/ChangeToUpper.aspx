<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeToUpper.aspx.cs" Inherits="ChangeToUpper.ChangeToUpper" %>


<!DOCTYPE html>
<script runat="server">

   private void convertoupper(object sender, EventArgs e)
   {
       string str = txtString.Text;
       lblResult.Text = str.ToUpper();
   }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change to Upper Case</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Convert to Upper Case"></asp:Label>
        <asp:TextBox ID="txtString" runat="server"></asp:TextBox>
        <asp:Button ID="btnEnter" runat="server" Text="Enter..." OnClick="convertoupper" />
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Results:"></asp:Label><br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
