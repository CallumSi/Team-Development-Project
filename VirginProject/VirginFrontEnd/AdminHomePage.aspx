<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="VirginFrontEnd.AdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Home Page</title>
    <link href="VirginProject.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
         
 
            <article>
                <ul>
                     <li>
                   
                     <asp:Button ID="btnCarHire"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin Car Hire" Height="47px" Width="173px" OnClick="btnCarHire_Click" />
    
                    </li>
                           
                      <li> 
                        <asp:Button ID="btnVirginForum"   CssClass="navButton" runat="server" style="z-index: 1;" Text="Virgin Forum" Height="45px" Width="159px" OnClick="btnVirginForum_Click" />

                     </li>
                     <li>
                        <asp:Button ID="btnLogOut"  CssClass="navButton"  runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 199px; top: 254px; position: absolute" Text="Log Out" />
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
