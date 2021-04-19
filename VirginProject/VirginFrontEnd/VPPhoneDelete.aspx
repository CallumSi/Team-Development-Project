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
        <asp:Label ID="lblDeletePhone" runat="server" style="z-index: 1; left: 456px; top: 159px; position: absolute" Text="Are you sure you want to delete this phone?"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 496px; top: 208px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 625px; top: 209px; position: absolute; height: 26px;" Text="Cancel" />
        <asp:Button ID="btnPhoneHome" runat="server" OnClick="btnPhoneHome_Click" style="z-index: 1; left: 66px; top: 105px; position: absolute; height: 58px; width: 141px" Text="Home" />
    </form>
</body>
</html>
