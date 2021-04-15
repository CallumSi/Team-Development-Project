<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminSignUpSuccess.aspx.cs" Inherits="VirginFrontEnd.ForumAdminSignUpSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Admin Success sign up page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
               <h2> Virgin Media </h2>
            
              </header>
        <article>
        <asp:Label ID="lblSuccessSignUp" runat="server" style="z-index: 1; left: 791px; top: 237px; position: absolute" Text="Congratulations! you have been successfully signed up."></asp:Label>
        </article>
          <nav>
                Navigation links here
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
       
        <p>
             <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1; left: 942px; top: 289px; position: absolute; width: 95px;" Text="Home" OnClick="btnHome_Click" />
        </p>
       
    </form>
</body>
</html>
