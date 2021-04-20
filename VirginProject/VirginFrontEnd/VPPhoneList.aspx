<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneList.aspx.cs" Inherits="VirginFrontEnd.VPPhoneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhone" runat="server" style="z-index: 1; left: 527px; top: 105px; position: absolute; height: 281px; width: 505px"></asp:ListBox>
        <asp:Label ID="lblEnterAPhone" runat="server" style="z-index: 1; left: 532px; top: 399px; position: absolute" Text="Please enter a phone by make"></asp:Label>
        <asp:TextBox ID="txtSearchPhone" runat="server" style="z-index: 1; left: 762px; top: 399px; position: absolute; width: 212px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 533px; top: 459px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 640px; top: 459px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 536px; top: 493px; position: absolute; width: 55px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 600px; top: 494px; position: absolute; width: 56px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 666px; top: 494px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 535px; top: 433px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 43px; top: 115px; position: absolute; height: 64px; width: 147px" Text="Home" />
        <asp:Button ID="btnStaffList" runat="server" style="z-index: 1; left: 48px; top: 219px; position: absolute; height: 68px; width: 142px" Text="Staff List " OnClick="btnStaffList_Click" />
        <asp:Button ID="btnCustomerList" runat="server" style="z-index: 1; left: 49px; top: 326px; position: absolute; height: 66px; width: 142px" Text="Customer List" OnClick="btnCustomerList_Click" />
        <asp:Button ID="btnEditAccount" runat="server" style="z-index: 1; left: 49px; top: 422px; position: absolute; height: 67px; width: 142px" Text="Edit Account" OnClick="btnEditAccount_Click" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 52px; top: 579px; position: absolute; height: 64px; width: 137px" Text="Log Out" OnClick="btnLogOut_Click" />
    </form>
</body>
</html>
