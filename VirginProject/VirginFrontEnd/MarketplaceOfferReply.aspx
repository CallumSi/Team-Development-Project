<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceOfferReply.aspx.cs" Inherits="VirginFrontEnd.MarketplaceOfferReply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
</body>
  <head id="Head1" runat="server">
        <title>Sample Master Page</title>
        <link href="VirginProject.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form2" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>

                <ul class ="row">
       
                            <li>
                            </li>
                          <li>
                              <asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button6" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                              <asp:Button ID="btnhome" CssClass="navButton" runat="server" style="z-index: 1;" Text="home" OnClick="btnhome_Click" />                              
                              
                          </li>
                 
                 </ul>  
                <br />
                       <asp:Label ID="lblAccepted" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
               
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
