<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginHomePage.aspx.cs" Inherits="VirginFrontEnd.VirginHomePage" %>

<!DOCTYPE html>
<%-- HEAD --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VirginHomePage</title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>

<%-- BODY --%>
<body>

    <form id="form1" runat="server">
        <%-- HEADER --%>
        <header>
            <h2>VIRGIN SERVICES </h2>
        </header>

        <%-- ARTICLE --%>
        <article>
            <%-- BUTTON VIRGIN MOVIES --%>
            <asp:Button ID="btnVirginMovies" CssClass="btnVirginMovies" runat="server" Text="MOVIES 🎥 " OnClick="btnVirginMovies_Click" />
            <%-- BUTTON VIRGIN CAR HIRE --%>
            <asp:Button ID="btnCarHire" CssClass="btnCarHire" runat="server" Text="CAR HIRE 🚘 " OnClick="btnCarHire_Click" />
            <%-- BUTTON VIRGIN PHONE --%>
            <asp:Button ID="btnVirginPhone" CssClass="btnVirginPhone" runat="server" Text="PHONES 📱 " OnClick="btnVirginPhone_Click" />
            <%-- BUTTON VIRGIN MARKET PLACE --%>
            <asp:Button ID="btnMarketPlace" CssClass="btnMarketPlace" runat="server" Text=" MARKETPLACE 📈 " OnClick="btnMarketPlace_Click" />
            <%-- BUTTON VIRGIN HEALTHCARE --%>
            <asp:Button ID="btnVirginGP" CssClass="btnVirginGP" runat="server" Text="HEALTHCARE 💊 " OnClick="btnVirginGP_Click" />
            <%-- BUTTON VIRGIN FORUM --%>
            <asp:Button ID="btnVirginForum" CssClass="btnVirginForum" runat="server" Text="FORUM 💬 " OnClick="btnVirginForum_Click" />
            <%-- BUTTON LOG OUT --%>
            <asp:Button ID="btnLogOut" CssClass="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" />
        </article>

        <%-- FOOTER --%>
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
