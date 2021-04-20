<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffCheckPin.aspx.cs" Inherits="VirginFrontEnd.VPStaffCheckPin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmStaff" runat="server" style="z-index: 1; left: 296px; top: 183px; position: absolute" Text="Confirm Staff"></asp:Label>
        <asp:Label ID="lblConfirmPin" runat="server" style="z-index: 1; left: 173px; top: 231px; position: absolute" Text="Confirm Pin"></asp:Label>
        <asp:TextBox ID="txtStaffPin" runat="server" style="z-index: 1; left: 253px; top: 229px; position: absolute; width: 164px"></asp:TextBox>
        <asp:Button ID="btnConfirm" runat="server" style="z-index: 1; left: 266px; top: 287px; position: absolute; height: 26px" Text="Confirm" OnClick="btnConfirm_Click" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; top: 287px; position: absolute; left: 368px; width: 57px" Text="Back" OnClick="btnBack_Click" />
        <asp:Label ID="lblPinError" runat="server" style="z-index: 1; left: 203px; top: 353px; position: absolute" Text="[lblPinError]"></asp:Label>
    </form>
</body>
</html>
