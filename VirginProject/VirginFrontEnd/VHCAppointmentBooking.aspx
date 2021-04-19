<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCAppointmentBooking.aspx.cs" Inherits="VirginFrontEnd.VHCAppointmentBooking" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDate" runat="server" Text="Booking Date"></asp:Label>
&nbsp;<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTime" runat="server" Text="Booking Time"></asp:Label>
&nbsp;<asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblReason" runat="server" Text="Reason"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="txtReason" runat="server" Height="107px" Width="303px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
