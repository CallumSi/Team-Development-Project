<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMMovieDelete.aspx.cs" Inherits="VirginFrontEnd.VMMovieDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie Staff Delete Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Media Staff Delete Movie </h2>
        </header>
        <article class="articleDeleteMovie">
            <asp:Label ID="lblStaffDeleteMovie" runat="server" Text="VIRGIN MOVIES DELETE MOVIE" CssClass="lblStaffDeleteMovie"></asp:Label>
        </article>
        <asp:Label ID="lblMovieDeleteConfirm" runat="server" Text="ARE YOU SURE YOU WANT TO DELETE THIS MOVE?" CssClass="lblMovieDeleteConfirm"></asp:Label>
        <asp:Button ID="btnYES" runat="server" Text="YES" CssClass="btnMovieDeleteYes" OnClick="btnYES_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnMovieDeleteCancel" OnClick="btnCancel_Click" />

        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click"/>
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click"/>
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click"/>
            <asp:Button ID="btnVMStaffList" runat="server" CssClass="btnStaffVMList" Text="View Staff List" OnClick="btnVMStaffList_Click" />
            <asp:Button ID="btnVMPaymentList" runat="server" Text="View Payment List" CssClass="btnVMPaymentList" OnClick="btnVMPaymentList_Click"/>
            <asp:Button ID="btnLogOut" CssClass="btnVMStaffLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            >
    </form>
</body>
</html>
