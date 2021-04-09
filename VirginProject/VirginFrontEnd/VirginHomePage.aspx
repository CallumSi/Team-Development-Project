<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginHomePage.aspx.cs" Inherits="VirginFrontEnd.VirginHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VirginHomePage</title>
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
                         
                          <asp:Button ID="btnVirginMovies" CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin Movies" Height="45px" Width="154px" />
                     </li>
                     <li>
                   
                     <asp:Button ID="btnCarHire"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin Car Hire" Height="47px" Width="173px" />
    
                    </li>
                     <li> 
                     <asp:Button ID="btnVirginPhone"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin Phones" Height="40px" Width="159px" />
                        </li>

                        <li>                
                        <asp:Button ID="btnMarketPlace"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin Market Place" Height="45px" Width="216px" />

                        </li>
                       <li>
                          <asp:Button ID="btnVirginGP"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Virgin GP" Height="48px" Width="132px" />
                      </li>
                           
                      <li> 
                        <asp:Button ID="btnVirginForum"   CssClass="navButton" runat="server" style="z-index: 1;" Text="Virgin Forum" Height="45px" Width="159px" />

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
