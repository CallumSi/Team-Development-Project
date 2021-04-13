<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VCHStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteStaff" runat="server" Text="Confirm deleting the selected Staff"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" OnClick="btnDelete_Click" style="z-index: 1; left: 10px; top: 90px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" Height="40px" Width="75px" OnClick="btnCancel_Click" style="z-index: 1; left: 115px; top: 90px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
