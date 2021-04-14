<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMStaffAddMovie.aspx.cs" Inherits="VirginFrontEnd.VMStaffAddMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie Staff Add Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Media Staff Add Movie </h2>
        </header>

        <article class="articleAddMovie">
            <asp:Label ID="lblStaffMovie" runat="server" Text="VIRGIN MOVIES ADD MOVIE" CssClass="lblStaffAddMovie"></asp:Label>
        </article>

        <asp:Label ID="lblMovieTitle" runat="server" Text="Movie Title: " CssClass="lblMovieTitle"></asp:Label>
        <asp:Label ID="lblMovieGenre" runat="server" Text="Movie Genre: " CssClass="lblGenre"></asp:Label>
        <asp:Label ID="lblMovieDuration" runat="server" Text="Movie Duration (minutes): " CssClass="lblMovieDuration"></asp:Label>
        <asp:Label ID="lblMovieRating" runat="server" Text="Movie Rating (score out of 10): " CssClass="lblMovieRating"></asp:Label>
        <asp:Label ID="lblMovieReleaseDate" runat="server" Text="Movie Release Date: " CssClass="lblMovieReleaseDate"></asp:Label>
        <asp:Label ID="lblMovieImage" runat="server" Text="Movie Image URL: " CssClass="lblMovieImage"></asp:Label>
        <asp:Label ID="lblMoviePrice" runat="server" Text="Movie Price: " CssClass="lblMoviePrice"></asp:Label>
        <asp:TextBox ID="txtMovieTitle" runat="server" CssClass="txtMovieTitle"></asp:TextBox>
        <asp:TextBox ID="txtMovieGenre" runat="server" CssClass="txtMovieGenre"></asp:TextBox>
        <asp:TextBox ID="txtMovieDuration" runat="server" CssClass="txtMovieDuration"></asp:TextBox>
        <asp:TextBox ID="txtMovieRating" runat="server" CssClass="txtMovieRating"></asp:TextBox>
        <asp:TextBox ID="txtMovieReleaseDate" runat="server" CssClass="txtMovieReleaseDate"></asp:TextBox>
        <asp:TextBox ID="txtMovieImage" runat="server" CssClass="txtMovieImage"></asp:TextBox>
        <asp:TextBox ID="txtMoviePrice" runat="server" CssClass="txtMoviePrice"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Text="OKAY" CssClass="btnStaffMovieOK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnStaffMovieCancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" Text="" CssClass="lblStaffAddMovieError"></asp:Label>

        <nav>
            <asp:Button ID="btnStaffHome" runat="server" CssClass="btnStaffHome" Text="Home" OnClick="btnStaffHome_Click" />

        </nav>

          <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>

    </form>
</body>
</html>
