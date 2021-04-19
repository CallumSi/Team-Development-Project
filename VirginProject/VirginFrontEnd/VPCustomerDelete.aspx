<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerDelete.aspx.cs" Inherits="VirginFrontEnd.VPCustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 480px; top: 182px; position: absolute" Text="Are you sure you want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 484px; top: 234px; position: absolute; width: 60px" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 633px; top: 235px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 89px; top: 98px; position: absolute; height: 51px; width: 131px" Text="Home" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 91px; top: 218px; position: absolute; height: 59px; width: 129px" Text="Customer List" />
        <asp:Button ID="btnStaffList" runat="server" OnClick="btnStaffList_Click" style="z-index: 1; left: 94px; top: 340px; position: absolute; height: 59px; width: 128px" Text="Staff List" />
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 91px; top: 460px; position: absolute; height: 62px; width: 130px" Text="Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 90px; top: 612px; position: absolute; height: 63px; width: 126px; right: 1018px" Text="Log Out " />
    </form>
</body>
</html>
