<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMPayment.aspx.cs" Inherits="VirginFrontEnd.AnVMPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblAnVMPayment" runat="server" Font-Bold="True" ForeColor="#CC0000" style="z-index: 1; left: 371px; top: 60px; position: absolute" Text="VIRGIN MOVIES PAYMENT"></asp:Label>
        <asp:Label ID="lblPaymentStatus" runat="server" BorderStyle="None" Font-Bold="True" style="z-index: 1; left: 215px; top: 153px; position: absolute" Text="PAYMENT STATUS: "></asp:Label>
        <asp:Label ID="lblPaymentType" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 203px; position: absolute" Text="PAYMENT TYPE: "></asp:Label>
        <asp:TextBox ID="txtPaymentType" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 208px; position: absolute; width: 274px"></asp:TextBox>
        <asp:CheckBox ID="chkPaymentStatus" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 153px; position: absolute; width: 274px" OnCheckedChanged="chkPaymentStatus_CheckedChanged" />
        <asp:Button ID="btnOkay" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 450px; top: 251px; position: absolute; width: 136px; right: 1253px" Text="OKAY" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 598px; top: 251px; position: absolute; width: 136px" Text="CANCEL" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" style="z-index: 1; left: 214px; top: 319px; position: absolute; width: 517px"></asp:Label>
    </form>
</body>
</html>
