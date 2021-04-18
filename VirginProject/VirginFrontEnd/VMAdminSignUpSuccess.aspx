<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMAdminSignUpSuccess.aspx.cs" Inherits="VirginFrontEnd.VMAdminSignUpSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Admin Sign Up Success</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2> Virgin Movies Sign Up Success </h2>

        </header>
        <article>
            <asp:Label ID="lblSuccessSignUp" runat="server" Style="z-index: 1; left: 791px; top: 237px; position: absolute" Text="Congratulations! You have been successfully signed up."></asp:Label>
        </article>
        <nav>

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
            <asp:Button ID="btnHome" CssClass="navButton" runat="server" Style="z-index: 1; left: 942px; top: 289px; position: absolute; width: 95px;" Text="Home" OnClick="btnHome_Click" />

    </form>
</body>
</html>
