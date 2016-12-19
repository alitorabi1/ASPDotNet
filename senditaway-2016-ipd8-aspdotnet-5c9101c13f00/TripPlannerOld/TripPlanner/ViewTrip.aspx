<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTrip.aspx.cs" Inherits="TripPlanner.ViewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource">
            <EditItemTemplate>
                Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                FullName:
                <asp:TextBox ID="FullNameTextBox" runat="server" Text='<%# Bind("FullName") %>' />
                <br />
                Gender:
                <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
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
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                FullName:
                <asp:TextBox ID="FullNameTextBox" runat="server" Text='<%# Bind("FullName") %>' />
                <br />
                Gender:
                <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
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
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                FullName:
                <asp:Label ID="FullNameLabel" runat="server" Text='<%# Bind("FullName") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Bind("Gender") %>' />
                <br />
                passportNo:
                <asp:Label ID="passportNoLabel" runat="server" Text='<%# Bind("passportNo") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Bind("date", "{0:d}") %>'  />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Trips] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    </div>
    </form>
</body>
</html>
