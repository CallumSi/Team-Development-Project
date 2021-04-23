<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnPost.aspx.cs" Inherits="VirginFrontEnd.ForumAnPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForumAnPost</title>
     <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <h1>Post page</h1>
                <ul>
             
                <li>
                     <asp:Label ID="lblTitle" runat="server" style="z-index: 1;" Text="Title"></asp:Label>
                     <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; " Height="36px" Width="338px"></asp:TextBox>
               </li>
               <li> 
                     <asp:Label ID="lblMessage" runat="server" style="z-index: 1; " Text="Message"></asp:Label>

                     <asp:TextBox ID="txtMessage" runat="server" style="z-index: 1; " Height="172px" Width="356px" ></asp:TextBox>
               </li>
                <li>
                     <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1;" Text="OK" CssClass="navButton" />
                     <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" OnClick="btnCancel_Click" CssClass="navButton" />
                </li>
                 <li>
                      <asp:Label ID="lblPostError" runat="server" style="z-index: 1;"></asp:Label>
                 </li>
   
                </ul>
            </article>
 
            <nav>
            
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
        </form>
    </body>
</html>
