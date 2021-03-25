<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceListingViewer.aspx.cs" Inherits="VirginFrontEnd.MarketplaceListingViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
        <title>Listing</title>
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
                          <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                       </li>
                          <li> 
                              <asp:Button ID="btnClickHere" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button6" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                              <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" Height="35px" />
                          </li>
                     
                    
                     
                 </ul>

                   
                    
                    <asp:Image ID="imgListing" runat="server" style="z-index: 1;position:absolute;right:10px; top:100px; height: 200px; width: 303px" />
                    <asp:Label ID="lblBidTitle" runat="server" style="z-index: 1;position:absolute;right:8px; top:302px; height: 27px; width: 92px; margin-top: 0px" Visible="False"> </asp:Label>
                    <asp:Label ID="Label7" runat="server" style="z-index: 1;position:absolute;right:132px; top:303px; height: 27px; width: 181px; margin-top: 0px">Current Highest Bid : </asp:Label>
                    <asp:Label ID="lblListingName" runat="server" style="z-index: 1;" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <asp:Label ID="lblListingType" runat="server" style="z-index: 1; "></asp:Label>
     
                <ul class="AnListing">
                    <li>
                        <asp:Label ID="Label18" runat="server" style="z-index: 1; " Text="Seller:"></asp:Label>
                    <asp:Label ID="lblSellerEmail" runat="server" style="z-index: 1; "></asp:Label>
                    </li>
                     
                    <li>
                        <asp:Label ID="Label5" runat="server" style="z-index: 1; " Text="Category:"></asp:Label>
                        <asp:Label ID="lblCategory" runat="server" style="z-index: 1; "></asp:Label>
                    </li>
                    <li>
                        <asp:Label ID="Label6" runat="server" style="z-index: 1;" Text="Delivery Type:"></asp:Label>
                        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; "></asp:Label>
                        
                    </li>
           
                    <li>
                        <asp:Label ID="label23" runat="server" style="z-index: 1; " Text="Quantity:"></asp:Label>
                        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1;"> </asp:Label>
                        
                    </li>
                    <li>    <asp:Label ID="Label4" runat="server" style="z-index: 1; " Text="Description:"></asp:Label>
                          <asp:Label ID="lblDescription" runat="server" style="z-index: 1; "></asp:Label>
                    </li>
                    <li>      <asp:Label ID="Label10" runat="server" style="z-index: 1; " Text="Condition:"></asp:Label>
                          <asp:Label ID="lblCondition" runat="server" style="z-index: 1; "></asp:Label>

                    </li>
                 
                    <li>  
                        <asp:Label ID="Label2" runat="server" style="z-index: 1; " Text="Start Price:"></asp:Label>
                        <asp:Label ID="lblPrice" runat="server" style="z-index: 1;"></asp:Label>
                        
                    
                        
                    </li>                     
                   
                    <li><asp:Label ID="label1" runat="server" style="z-index: 1; " Text="Time Left:"></asp:Label>
                        <asp:Label ID="lblTimeLeft" runat="server" style="z-index: 1; "></asp:Label>
                    </li>
                   
                    
                    <li> 
                    <asp:Button ID="btnAddToCart" CssClass="navButton" runat="server" style="z-index: 1; " Text="Add to Cart" Visible="False" OnClick="btnAddToCart_Click" />
                    <asp:Button ID="btnBuyNow" CssClass="navButton" runat="server" style="z-index: 1; " Text="Buy Now" OnClick="btnBuyNow_Click" Visible="False" />
                            <asp:Label ID="lblBidText" runat="server" style="z-index: 1; " Visible="False">Bid : </asp:Label>
                         <asp:TextBox ID="txtBid" runat="server" Visible="False"></asp:TextBox>
                          <asp:Button ID="btnBid" CssClass="navButton" runat="server" style="z-index: 1; " Text="Place Bid" OnClick="btnBid_Click" Visible="False"  />
                        <asp:Button ID="btnOffer" CssClass="navButton" runat="server" style="z-index: 1; " Text="Offer" OnClick="btnOffer_Click" Visible="False"  />
                     <asp:Button ID="btnFavorite" CssClass="navButton" runat="server" style="z-index: 1; " Text="Favorite" OnClick="btnFavorite_Click" />
                   <asp:Button ID="btnUnFavorite" CssClass="navButton" runat="server" style="z-index: 1; " Text="UnFavorite" OnClick="btnUnFavorite_Click"  />
                    
                    <asp:Label ID="lblFavorite"  runat="server" style="z-index: 1;"></asp:Label>
                   <asp:Label ID="lblError"  runat="server" style="z-index: 1;"></asp:Label></li>
                  
                    
                    

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
