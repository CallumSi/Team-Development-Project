<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumHome.aspx.cs" Inherits="VirginFrontEnd.ForumHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>ForumUserHomePage</title>
   <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
              
        </header>

        <article>
          <h1>Welcome To The Virgin Forum</h1>
            <ul>

                <li>
                    <asp:Button ID="btnForum" runat="server" Style="z-index: 1;" Text="Go To Forum" CssClass="Button" OnClick="btnForum_Click" />

                </li>
                <li>
                    <asp:Button ID="btnNewComer" runat="server" Style="z-index: 1;" Text="Are you a newcomer?" CssClass="Button" OnClick="btnNewComer_Click" />
                </li>
            </ul>
        </article>

        <nav>
          
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>



    </form>
</body>
</html>
