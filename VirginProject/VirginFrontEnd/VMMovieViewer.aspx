<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMMovieViewer.aspx.cs" Inherits="VirginFrontEnd.VMMovieViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Listing</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>

            <asp:Label ID="lblUsername" runat="server" Style="z-index: 1;" Text="" CssClass="lblUsername"></asp:Label>
            <asp:Image ID="MovieImage" runat="server" CssClass="MovieImage" />
            <ul class="AnMovie">
                <li>
                    <asp:Label ID="lblMovieNameTitle" runat="server" Text="Movie Title: " CssClass="lblTitleViwer"></asp:Label>
                    <asp:Label ID="lblMovieTitle" runat="server" Style="z-index: 1;"></asp:Label>
                    <br />
                    <br />
                </li>
                <li>
                    <asp:Label ID="lblMovieGenreTitle" runat="server" Text="Movie Genre: " CssClass="lblGenreViwer"></asp:Label>
                    <asp:Label ID="lblMovieGenre" runat="server" Style="z-index: 1;"></asp:Label>
                    <br />
                    <br />
                </li>
                <li>
                    <asp:Label ID="lblMovieDurationTitle" runat="server" Text="Movie Duration: " CssClass="lblDurationViwer"></asp:Label>
                    <asp:Label ID="lblMovieDuration" runat="server" Style="z-index: 1;"></asp:Label>
                    <br />
                    <br />
                </li>
                <li>
                    <asp:Label ID="lblMovieRatingTitle" runat="server" Text="Movie Rating: " CssClass="lblRatingViwer"></asp:Label>
                    <asp:Label ID="lblMovieRating" runat="server" Style="z-index: 1;"></asp:Label>
                    <br />
                    <br />
                </li>
                <li>
                    <asp:Label ID="lblMovieReleaseDateTitle" runat="server" Text="Movie Release Date: " CssClass="lblReleaseDateViwer"></asp:Label>
                    <asp:Label ID="lblMovieReleaseDate" runat="server" Style="z-index: 1;"></asp:Label>
                    <br />
                    <br />
                </li>

                <li>
                    <asp:Label ID="lblMoviePriceTitle" runat="server" Text="Movie Price: " CssClass="lblPriceViewer"></asp:Label>
                    <asp:Label ID="lblMoviePrice" runat="server" Style="z-index: 1"></asp:Label>
                    <br />
                    <br />
                </li>

                <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" CssClass="btnAddToCart" OnClick="btnAddToCart_Click" />

                <li>
                    <br />
                    <br />
                    <asp:Label ID="lblError" runat="server" Style="z-index: 1;"></asp:Label>
                </li>

            </ul>
        </article>

        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnCustomerHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" OnClick="btnViewCart_Click" />
            <asp:Button ID="btnEditAccount" CssClass="btnEditAccount" runat="server" Text="Edit Account Details" OnClick="btnEditAccount_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnCustomerLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
