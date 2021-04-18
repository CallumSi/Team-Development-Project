<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginPhoneWelcome.aspx.cs" Inherits="VirginFrontEnd.VirginPhoneWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 99px; top: 192px; position: absolute" Text="Continue" OnClick="btnContinue_Click" />
        <asp:Button runat="server" style="z-index: 1; top: 192px; position: absolute; left: 219px" Text="First Time?" ID="btnFirstTime" OnClick="Unnamed1_Click" />
    </form>
</body>
</html>
