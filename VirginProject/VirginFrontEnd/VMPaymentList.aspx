<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMPaymentList.aspx.cs" Inherits="VirginFrontEnd.VMPaymentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 172px; top: 373px; position: absolute; width: 98px; right: 1156px;" Text="Add" BorderStyle="Solid" Font-Bold="True" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 302px; top: 373px; position: absolute; width: 98px; " Text="Edit" BorderStyle="Solid" Font-Bold="True" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 439px; top: 373px; position: absolute; width: 98px;" Text="Delete" BorderStyle="Solid" Font-Bold="True" OnClick="btnDelete_Click" />
        <asp:Label ID="lblVMPayment" runat="server" style="z-index: 1; left: 172px; top: 58px; position: absolute; width: 515px; text-align: center;" Text="VIRGIN MOVIES PAYMENT LIST" BorderStyle="None" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:ListBox ID="lstVMPayment" runat="server" BackColor="#EAE9F3" Font-Bold="True" style="z-index: 1; left: 170px; top: 152px; position: absolute; height: 187px; width: 523px"></asp:ListBox>
        <asp:Label ID="lblFilterPaymentType" runat="server" BorderStyle="None" Font-Bold="True" style="z-index: 1; left: 172px; top: 103px; position: absolute" Text="Filter By Payment Type:"></asp:Label>
        <asp:TextBox ID="txtFilterPaymentType" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 347px; top: 102px; position: absolute; width: 218px"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 567px; top: 373px; position: absolute; width: 127px; margin-bottom: 0px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 585px; top: 99px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" style="z-index: 1; left: 171px; top: 429px; position: absolute; width: 522px"></asp:Label>
    </form>
</body>
</html>
