﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumUserDelete.aspx.cs" Inherits="VirginFrontEnd.ForumUserDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserDeletePage</title>
     <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form2" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                    <li><asp:Label ID="lblUserDelete" runat="server" style="z-index: 1;" Text="Are you sure you want to delete this user"></asp:Label></li>
                    <li>
                      <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1;" Text="Yes" />
                         <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1;" Text="No" />
                     
                    </li>
                </ul>
                    </article>
 
            <nav>
                Navigation links here
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
        </form>
    </body>
</html>
