<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceListingType.aspx.cs" Inherits="VirginFrontEnd.MarketplaceListingType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="VirginProject.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
            <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
       
                      <li>
                          <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>
                       </li>
                       <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                           <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                           <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" />
                       </li>
                 </ul>    
                
                         <br />
                         <br /> 
                         <br /> 
                    
                           
                        <br /> 
                         <asp:Label ID="Label1" runat="server" style="z-index: 1;" Text="Choose a listing type: "></asp:Label>
                        <br /> 
                        <asp:Button ID="btnInstantSale"  CssClass="navButton" runat="server" style="z-index: 1; " Text="InstantSale" OnClick="btnInstantSale_Click" />
                        <asp:Button ID="btnAuction" CssClass="navButton" runat="server" style="z-index: 1; " Text="Auction" OnClick="btnAuction_Click" />
                        <asp:Button ID="btnBestOffer" CssClass="navButton" runat="server" style="z-index: 1; " Text="BestOffer" OnClick="btnBestOffer_Click" />
                    
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
