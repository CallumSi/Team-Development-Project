<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginCustomerMovieList.aspx.cs" Inherits="VirginFrontEnd.VirginCustomerMovieList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <style type="text/css">
        .auto-style1 {
            position: fixed;
            top: 275px;
            left: 200px;
            bottom: 534px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media Movie List</h2>
        </header>
        
        <asp:ListBox ID="lstMovies" runat="server" CssClass="lstCustomerFilms"></asp:ListBox>


        <asp:Label ID="lblFilterGenre" runat="server" Text="Filter By Genre:" CssClass="lblFilterFilmGenre"></asp:Label>
        <asp:TextBox ID="txtFilterGenre" runat="server" CssClass="txtFilterFilmGenre"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btnApplyFilmFilter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All Movies" CssClass="btnDisplayAllFilm" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblError" runat="server" Text="" CssClass="lblFilmError"></asp:Label>
        <asp:Button ID="btnViewMovie" runat="server" CssClass="btnViewMovie" Text="View Movie" OnClick="btnViewMovie_Click" />

        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnCustomerHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" OnClick="btnViewCart_Click" />
            <asp:Label ID="lblCartCount" runat="server" CssClass="auto-style1" Text=""></asp:Label>
            <asp:Button ID="btnEditAccount" CssClass="btnEditAccount" runat="server" Text="Edit Account Details" OnClick="btnEditAccount_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnCustomerLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
        <asp:Label ID="lblMVUsername" runat="server" CssClass="lblUsername"></asp:Label>
    </form>
</body>
</html>
