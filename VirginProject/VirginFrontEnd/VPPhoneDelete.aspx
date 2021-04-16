<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneDelete.aspx.cs" Inherits="VirginFrontEnd.VPPhoneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeletePhone" runat="server" style="z-index: 1; left: 22px; top: 62px; position: absolute" Text="Are you sure you want to delete this phone?"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 17px; top: 97px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 98px; top: 97px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
