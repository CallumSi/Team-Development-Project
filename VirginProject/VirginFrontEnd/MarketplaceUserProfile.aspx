<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceUserProfile.aspx.cs" Inherits="VirginFrontEnd.MarketplaceUserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
                <ul>
       
                      <li>
                          <asp:Label ID="Label4" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>
                       </li>
                          <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                          </li>
                                      
                     
                 </ul>
                       <asp:Label ID="Label1" runat="server" style="z-index: 1; " Text="Marketplace User Profile"></asp:Label>                
                      <asp:Label ID="Label8" runat="server" style="z-index: 1; " Text="Where would you like to go?"></asp:Label>
                         <br />
                      <asp:Button ID="btnFavoritedListings" runat="server" CssClass="navButton" OnClick="btnFavoritedListings_Click" style="z-index: 1;" Text="Favorited Listings" />
                      <asp:Button ID="btnYourListings" runat="server" CssClass="navButton" OnClick="btnYourListings_Click" style="z-index: 1;" Text="Your Listings" />
        
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
