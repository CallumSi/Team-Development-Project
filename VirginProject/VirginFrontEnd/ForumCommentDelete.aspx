<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumCommentDelete.aspx.cs" Inherits="VirginFrontEnd.ForumCommentDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Comment Page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>
            <ul>

                <li>
                    <asp:Label ID="Label1" runat="server" Style="z-index: 1;" Text="Are you sure you want to delete this Comment?" Font-Bold="True" Font-Size="Large"></asp:Label>
                </li>
                <li>
                    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Style="z-index: 1;" Text="Yes" CssClass="navButton" />
                    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Style="z-index: 1;" Text="No" CssClass="navButton" />
                </li>
            </ul>
        </article>

        <nav>
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Style="z-index: 1;" Text="Sign Out" CssClass="Button" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
