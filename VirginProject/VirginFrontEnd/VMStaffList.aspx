<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMStaffList.aspx.cs" Inherits="VirginFrontEnd.VMStaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie Staff List</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Media Staff List</h2>
        </header>
        <asp:Label ID="lblVMStaffListTitle" runat="server" Text="Virgin Movies Staff List" CssClass="lblVMStaffListTitle"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" CssClass="btnAddStaff" Text="Add" OnClick="btnAdd_Click"/>
        <asp:Button ID="btnEdit" runat="server" CssClass="btnEditStaff" Text="Edit" OnClick="btnEdit_Click"/>
        <asp:Button ID="btnDelete" runat="server" CssClass="btnDeleteStaff" Text="Delete" OnClick="btnDelete_Click"/>
        <asp:Label ID="lblFilterByStaffUsername" runat="server" CssClass="lblFilterByStaffUsername" Text="Filter By Staff First Name:"></asp:Label>
        <asp:TextBox ID="txtFilterStaffUsername" runat="server" CssClass="txtFilterStaffUsername"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="btnDisplayAllStaff" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" CssClass="btnApplyStaffFilter" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" CssClass="lblStaffError"></asp:Label>
        <asp:ListBox ID="lstVMStaff" runat="server" CssClass="lstVMStaff"></asp:ListBox>
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnStaffLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
            <asp:Button ID="btnVMPaymentList" runat="server" Text="View Payment List" CssClass="btnVMPaymentList" OnClick="btnVMPaymentList_Click" />
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
