<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMMovieDelete.aspx.cs" Inherits="VirginFrontEnd.VMMovieDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie Staff Delete Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body>
    <form id="form2" runat="server">
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
        <asp:Button ID="btnDeleteHome" CssClass="btnDeleteHome" runat="server" Text="Home" OnClick="btnDeleteHome_Click" />
    </nav>

    <footer>
        <div id="FooterText">
            © 2021 Virgin Media | All Rights Reserved
        </div>
    </footer>
</form>
</body>
</html>
