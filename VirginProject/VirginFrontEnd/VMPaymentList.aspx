<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMPaymentList.aspx.cs" Inherits="VirginFrontEnd.VMPaymentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Customer List</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movies Payment List</h2>
        </header>
        <asp:Label ID="lblVMPaymentList" runat="server" Text="Virgin Movie Payment List" CssClass="lblVMPaymentListLabel"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btnAddVMPayment" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btnEditVMPayment" OnClick="btnEdit_Click"/>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btnDeleteVMPayment" OnClick="btnDelete_Click" />
        <asp:ListBox ID="lstVMPayment" runat="server" CssClass="lstVMPayment"></asp:ListBox>
        <asp:Label ID="lblFilterPaymentType" runat="server" Text="Filter By Payment Type:" CssClass="lblVMFilterPaymentType"></asp:Label>
        <asp:TextBox ID="txtFilterPaymentType" runat="server" CssClass="txtVMFilterPaymentType"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" CssClass="btnDisplayAllVMPayment" OnClick="btnDisplayAll_Click"/>
        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btnApplyPaymentFilter" OnClick="btnApplyFilter_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblVMPaymentError" Text=""></asp:Label>
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click" />
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click" />
            <asp:Button ID="btnVMStaffList" runat="server" CssClass="btnStaffVMList" Text="View Staff List" OnClick="btnVMStaffList_Click" />
            <asp:Button ID="btnVMPaymentList" runat="server" Text="View Payment List" CssClass="btnVMPaymentList" OnClick="btnVMPaymentList_Click"/>
            <asp:Button ID="btnLogOut" CssClass="btnVMStaffLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
