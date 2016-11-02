<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTrip.aspx.cs" Inherits="TripPlanner.ViewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TripPlannerConnectionString %>" SelectCommand="SELECT * FROM [Trips] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="TripID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <span style="background-color: #FAFAD2;color: #284775;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:Label ID="fullNameLabel" runat="server" Text='<%# Eval("fullName") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                passportNo:
                <asp:Label ID="passportNoLabel" runat="server" Text='<%# Eval("passportNo") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Eval("date") %>' />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Eval("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Eval("arrivalAirport") %>' />
                <br />
<br /></span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="background-color: #FFCC66;color: #000080;">Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:TextBox ID="fullNameTextBox" runat="server" Text='<%# Bind("fullName") %>' />
                <br />
                gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                passportNo:
                <asp:TextBox ID="passportNoTextBox" runat="server" Text='<%# Bind("passportNo") %>' />
                <br />
                date:
                <asp:TextBox ID="dateTextBox" runat="server" Text='<%# Bind("date") %>' />
                <br />
                departureAirport:
                <asp:TextBox ID="departureAirportTextBox" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:TextBox ID="arrivalAirportTextBox" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /><br /></span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">fullName:
                <asp:TextBox ID="fullNameTextBox" runat="server" Text='<%# Bind("fullName") %>' />
                <br />gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />passportNo:
                <asp:TextBox ID="passportNoTextBox" runat="server" Text='<%# Bind("passportNo") %>' />
                <br />date:
                <asp:TextBox ID="dateTextBox" runat="server" Text='<%# Bind("date") %>' />
                <br />departureAirport:
                <asp:TextBox ID="departureAirportTextBox" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />arrivalAirport:
                <asp:TextBox ID="arrivalAirportTextBox" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /><br /></span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="background-color: #FFFBD6;color: #333333;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:Label ID="fullNameLabel" runat="server" Text='<%# Eval("fullName") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                passportNo:
                <asp:Label ID="passportNoLabel" runat="server" Text='<%# Eval("passportNo") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Eval("date") %>' />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Eval("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Eval("arrivalAirport") %>' />
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
                fullName:
                <asp:Label ID="fullNameLabel" runat="server" Text='<%# Eval("fullName") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                passportNo:
                <asp:Label ID="passportNoLabel" runat="server" Text='<%# Eval("passportNo") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Eval("date") %>' />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Eval("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Eval("arrivalAirport") %>' />
                <br />
<br /></span>
            </SelectedItemTemplate>
        </asp:ListView>
        <br />
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
