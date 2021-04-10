<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceBidOfferViewer.aspx.cs" Inherits="VirginFrontEnd.MarketplaceOfferViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head id="Head1" runat="server">
        <title>Sample Master Page</title>
        <link href="VirginProject.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article class="row">
               <ul>
       
                      <li>
                          <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                        <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>     
                       </li>
                       <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                           <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                           <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" Height="35px" />
                       </li>
                                      
                    
                 </ul>
                         <asp:Label ID="lblTitle" runat="server" style="z-index: 1;" Text=""></asp:Label>
                         <br />
                       <asp:ListBox ID="lstBidOffers" runat="server" style="z-index: 1; height: 184px; width: 440px; margin-top: 0px"></asp:ListBox>

                        <br />
                       <asp:Button ID="btnAccept" runat="server" CssClass="navButton" OnClick="btnAccept_Click" style="z-index: 1;" Text="Accept Offer" Visible="False" />                     
                        <asp:Button ID="btnDeclineOffer" runat="server" CssClass="navButton" style="z-index: 1;" Text="DeclineOffer" OnClick="btnDeclineOffer_Click" Visible="False" />
                  <asp:Button ID="btnBack" CssClass="navButton" runat="server" style="z-index: 1;" Text="Back" OnClick="btnBack_Click" />
                         <br />
                       <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
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
        <p>
&nbsp;&nbsp;&nbsp;
        </p>
    </body>
        
</html>
