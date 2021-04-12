<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMStaffMovie.aspx.cs" Inherits="VirginFrontEnd.VMMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media Staff Movie </h2>
        </header>
        <article class="articleMovie">
            <p class="lblStaffMovie"><strong>VIRGIN MOVIES STAFF MOVIE LIST</strong></p>

            <asp:ListBox ID="lstMovies" runat="server" CssClass="lstMovies" Height="293px" Width="553px"></asp:ListBox>


        </article>
        <asp:Label ID="lblFilterGenre" runat="server" Text="Filter By Genre:" CssClass="lblFilterGenre"></asp:Label>
        <asp:TextBox ID="txtFilterGenre" runat="server" CssClass="txtFilterGenre"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btnApplyFilter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All Movies" CssClass="btnDisplayAll" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblError" runat="server" Text="" CssClass="lblError"></asp:Label>

        <nav>
            <ul>
                <li>

                    <asp:Button ID="btnAddMovie" CssClass="navButton" runat="server" Text="Add Movie" Width="159px" left="100px" OnClick="btnAddMovie_Click" />

                    <asp:Button ID="btnUpdateMovie" CssClass="navButton" runat="server" Text="Update Movie" Width="159px" OnClick="btnUpdateMovie_Click" />

                    <asp:Button ID="btnDeleteMovie" CssClass="navButton" runat="server" Text="Delete Movie" Width="159px" OnClick="btnDeleteMovie_Click" />

                    <asp:Button ID="btnViewCart" CssClass="navButton" runat="server" Text="View Cart" Width="159px" />

                </li>
            </ul>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
