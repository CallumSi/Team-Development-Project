<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMStaff.aspx.cs" Inherits="VirginFrontEnd.AnVMStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movie Add Staff</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movie Staff Add Staff </h2>
        </header>

        <article class="articleAddStaff">
            <asp:Label ID="lblAnVMStaffAdd" runat="server" Text="VIRIGN MOVIES ADD STAFF" CssClass="lblVMStaffAddStaff"></asp:Label>
        </article>

        <asp:Label ID="lblVMStaffFirstname" runat="server" Text="STAFF FIRSTNAME: " CssClass="lblStaffFirstName"></asp:Label>
        <asp:Label ID="lblVMStaffLastname" runat="server" Text="STAFF LASTNAME: " CssClass="lblStaffLastName"></asp:Label>
        <asp:Label ID="lblVMStaffEmail" runat="server" Text="STAFF EMAIL: " CssClass="lblStaffEmail"></asp:Label>
        <asp:Label ID="lblVMStaffPassword" runat="server" Text="STAFF PASSWORD: " CssClass="lblStaffPassword"></asp:Label>
        <asp:Label ID="lblVMStaffPosition" runat="server" Text="STAFF POSITION: " CssClass="lblStaffPosition"></asp:Label>
        <asp:TextBox ID="txtVMStaffFirstname" runat="server" CssClass="txtStaffFirstName"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffLastname" runat="server" CssClass="txtStaffLastName"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffEmail" runat="server" CssClass="txtStaffEmail"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffPassword" runat="server" CssClass="txtStaffPassword"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffPosition" runat="server" CssClass="txtStaffPosition"></asp:TextBox>
        <asp:Button ID="btnOkay" runat="server" Text="OKAY" CssClass="btnStaffAddOkay" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnStaffAddCancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblStaffAddError"></asp:Label>

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
