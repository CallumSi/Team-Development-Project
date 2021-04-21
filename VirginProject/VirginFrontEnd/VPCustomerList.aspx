<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerList.aspx.cs" Inherits="VirginFrontEnd.VPCustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 385px; top: 85px; position: absolute; height: 280px; width: 448px; margin-top: 0px"></asp:ListBox>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 384px; top: 378px; position: absolute" Text="Please enter the customer's first name"></asp:Label>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 632px; top: 377px; position: absolute; width: 208px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 384px; top: 407px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 382px; top: 439px; position: absolute; width: 86px" Text="Apply Filter" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 478px; top: 439px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 383px; top: 476px; position: absolute; width: 65px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 462px; top: 476px; position: absolute; width: 65px; right: 707px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 538px; top: 476px; position: absolute; width: 70px" Text="Delete" />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 76px; top: 102px; position: absolute; height: 60px; width: 146px" Text="Home" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 77px; top: 294px; position: absolute; height: 63px; width: 134px" Text="Customer List" />
        <asp:Button ID="btnStaffList" runat="server" OnClick="btnStaffList_Click" style="z-index: 1; left: 81px; top: 197px; position: absolute; height: 61px; width: 135px" Text="Staff List" />
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 80px; top: 411px; position: absolute; height: 62px; width: 135px" Text="Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 79px; top: 601px; position: absolute; height: 67px; width: 141px" Text="Log Out" />
    </form>
</body>
</html>
