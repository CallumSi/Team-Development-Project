<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCustomerList.aspx.cs" Inherits="VirginFrontEnd.VMAnCustomer" %>

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
            <h2>Virgin Movie Customer List </h2>
        </header>

        <article class="articleVMSCustomerList">
            <asp:Label ID="lblVMSCustomerList" runat="server" Text="VIRIGN MOVIES CUSTOMER LIST" CssClass="lblVMSCustomerList"></asp:Label>
        </article>

        <asp:Button ID="btnAdd" runat="server" CssClass="btnAddVMCCustomer" Text="ADD" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" CssClass="btnEditVMCCustomer" Text="EDIT" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass-="btnDeleteVMCCustomer" Text="DELETE" OnClick="btnDelete_Click" />
        <asp:ListBox ID="lstVMCustomers" runat="server" CssClass="lstVMCCustomers"></asp:ListBox>
        <asp:Label ID="lblFilterUsername" runat="server" Text="Filter By Username:" CssClass="lblVMCFilterUsername"></asp:Label>
        <asp:TextBox ID="txtFilterUsername" runat="server" CssClass="txtVMCFilterUsername"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" CssClass="btnDisplayAllVMCCustomer" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btnVMCApplyFilter" OnClick="btnApplyFilter_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblErrorVMCList"></asp:Label>

        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click" />
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click" />
            <asp:Button ID="btnVMStaffList" runat="server" CssClass="btnStaffVMList" Text="View Staff List" OnClick="btnVMStaffList_Click" />
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
