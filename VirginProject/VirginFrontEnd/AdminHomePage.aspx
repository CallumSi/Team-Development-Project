<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="VirginFrontEnd.AdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Home Page</title>
    <link href="AdminSecurity.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>ADMIN HOME SERVICES</h2>
        </header>
        <article>
            <asp:Button ID="btnCarHire" CssClass="btnCarHire" runat="server" Style="z-index: 1; height: 197px; width: 831px; margin-top: 0px;" Text="Admin Virgin Car Hire" OnClick="btnCarHire_Click" />

            <asp:Button ID="btnVirginForum" CssClass="btnVirginForum" runat="server" Style="z-index: 1; height: 183px; width: 862px; margin-top: 0px;" Text="Admin Virgin Forum " OnClick="btnVirginForum_Click" />

            <asp:Button ID="btnLogOut" CssClass="btnLogOut" runat="server" OnClick="btnLogOut_Click" Style="z-index: 1; left: 1145px; top: 103px; position: absolute" Text="Log Out" />

        </article>
        <nav>
            Navigation links here
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
