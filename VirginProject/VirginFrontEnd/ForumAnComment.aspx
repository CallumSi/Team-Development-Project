<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnComment.aspx.cs" Inherits="VirginFrontEnd.ForumAnComment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>An Comment page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
             
                <li>
                    <asp:Label ID="lblThreadTitle" runat="server" style="z-index: 1;" Text="Post title :"></asp:Label>
                    <asp:Label ID="lblTitle" runat="server" style="z-index: 1;" Text="[lblTitle]"></asp:Label>
               </li>
               <li> 
                  <asp:Label ID="lblComment" runat="server" style="z-index: 1;" Text="Comment:"></asp:Label>
                  <asp:TextBox ID="txtComment" runat="server" style="z-index: 1;"></asp:TextBox>
               </li>
                <li>
                   <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1;" Text="OK" />
                   <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" OnClick="btnCancel_Click" />
                </li>
                 <li>
                   <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
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
