<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPThankYouConfirmation.aspx.cs" Inherits="VirginFrontEnd.VPThankYouConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblThankYou" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 456px; top: 298px; position: absolute; height: 84px; width: 373px" Text="Thank you for your order"></asp:Label>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 99px; top: 112px; position: absolute; height: 69px; width: 158px" Text="Home" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 99px; top: 252px; position: absolute; height: 76px; width: 153px" Text="Log Out" />
    </form>
</body>
</html>
