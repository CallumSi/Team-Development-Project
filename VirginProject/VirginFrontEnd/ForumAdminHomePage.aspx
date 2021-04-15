<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminHomePage.aspx.cs" Inherits="VirginFrontEnd.ForumAdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>AdminHomePage</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
              
        </header>

        <article>
          <h1> Admin Home page
            </h1>
            <ul>

                <li>
                   <asp:Button ID="btnUser" runat="server" style="z-index: 1;" Text="Users" CssClass="navButton" OnClick="btnUser_Click" Width="162px" />
                </li>

                <li>
                      <asp:Button ID="btnAdminAccount" runat="server" CssClass="navButton" style="z-index: 1;" Text="Admin Account" OnClick="btnAdminAccount_Click" />
                </li>

                <li>
                       <asp:Button ID="btnPosts" runat="server" CssClass="navButton" style="z-index: 1; " Text="Posts" OnClick="btnPosts_Click" Width="164px" />
                </li>

                <li>
                   
                    <asp:Button ID="btnComments" runat="server" CssClass="navButton" style="z-index: 1;" Text="Comments" OnClick="btnComments_Click" Width="166px" />
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
