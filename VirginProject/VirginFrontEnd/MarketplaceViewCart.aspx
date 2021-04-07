<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceViewCart.aspx.cs" Inherits="VirginFrontEnd.MarketplaceViewCart" %>

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
                          <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                            </li>
                          <li>
                              <asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button6" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                              <asp:Button ID="btnhome" CssClass="navButton" runat="server" style="z-index: 1;" Text="home" OnClick="btnhome_Click" />                              
                              
                          </li>
                    
                     
                 </ul>  
                 <br />
                    <asp:ListBox ID="lstShoppingCart" runat="server" Height="205px" Width="259px"></asp:ListBox>
                 <ul >
                <asp:Button ID="btnContinueShopping" CssClass="navButton" runat="server" style="z-index: 1;" Text="Continue Shopping" OnClick="btnContinueShopping_Click" />
                <asp:Button ID="btnMarketplaceCheckout" CssClass="navButton" runat="server" style="z-index: 1;" Text="Go to Checkout" OnClick="btnMarketplaceCheckout_Click" />
                      <asp:Label ID="lblError" runat="server" style="z-index: 1;" Text=""></asp:Label>
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
