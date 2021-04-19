<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminHome.aspx.cs" Inherits="VirginFrontEnd.ForumAdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>ForumAdminHomePage</title>
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
                    <asp:Button ID="btnAdminPage" runat="server" Style="z-index: 1;" Text="Go To Admin Home Page" CssClass="Button" OnClick="btnAdminPage_Click" />

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
