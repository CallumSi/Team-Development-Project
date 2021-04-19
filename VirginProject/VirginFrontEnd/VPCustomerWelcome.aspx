<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerWelcome.aspx.cs" Inherits="VirginFrontEnd.VPCustomerWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 401px; top: 274px; position: absolute" Text="Continue " OnClick="btnContinue_Click" />
        <asp:Button ID="btnFirstTime" runat="server" style="z-index: 1; left: 553px; top: 274px; position: absolute" Text="First Time?" />
    </form>
</body>
</html>
