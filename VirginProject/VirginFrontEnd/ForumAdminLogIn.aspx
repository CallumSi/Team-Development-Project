<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminLogIn.aspx.cs" Inherits="VirginFrontEnd.ForumAdminLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminLogIn</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
              
        </header>

        <article>
          <h1> Admin Log In</h1>
            <ul>

                <li>
                    <asp:Label ID="lblUserName" runat="server" Style="z-index: 1;" Text="User Name"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" Style="z-index: 1;"></asp:TextBox>
                </li>

                <li>
                    <asp:Label ID="lblPassword" runat="server" Style="z-index: 1;" Text="Password"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>
                </li>

                <li>
                    <asp:Button ID="btnLogIn" runat="server" Style="z-index: 1;" Text="Log In" OnClick="btnLogIn_Click" />
                </li>

                <li>
                    <asp:Button ID="btnSignUp" runat="server" Style="z-index: 1;" Text="Sign Up" OnClick="btnSignUp_Click1" />
                </li>
                <li>

                    <asp:Button ID="btnForgotPassword" runat="server" Style="z-index: 1;" Text="Forgot Password" OnClick="btnForgotPassword_Click" />

                </li>
                <li>

                    <asp:Label ID="lblError" runat="server" Style="z-index: 1;"></asp:Label>

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
