<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VMStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie Staff Delete</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>Virgin Movies Staff Delete</h1>
        </header>
        <asp:Label ID="lblDeleteConfirmation" runat="server" Text="Are you sure you want to delete this staff?" CssClass="lblDeleteStafflabel"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Text="YES" CssClass="btnYesDeleteStaff" OnClick="btnYes_Click"/>
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnCancelDeleteStaff" OnClick="btnNo_Click" />
        <nav>
            <asp:Button ID="btnAddMovie" CssClass="btnStaffAddMovie" runat="server" Text="Staff List Movie" OnClick="btnAddMovie_Click" />
            <asp:Button ID="btnUpdateMovie" CssClass="btnStaffUpdateMovie" runat="server" Text="Customer List" OnClick="btnUpdateMovie_Click"  />
            <asp:Button ID="btnDeleteMovie" CssClass="btnVMStaffDeleteMovie" runat="server" Text="Movie List" OnClick="btnDeleteMovie_Click" />
            <asp:Button ID="btnCustomerList" CssClass="btnStaffMovieCustomerList" runat="server" Text="Log Out" OnClick="btnCustomerList_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
