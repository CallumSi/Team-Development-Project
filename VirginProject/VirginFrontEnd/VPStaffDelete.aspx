<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VPStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteStaff" runat="server" style="z-index: 1; left: 30px; top: 76px; position: absolute" Text="Are you sure you want to delete this Staff?"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 22px; top: 113px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 98px; top: 113px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
