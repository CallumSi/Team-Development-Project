<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceListingDelete.aspx.cs" Inherits="VirginFrontEnd.MarketplaceListingDelete" %>

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
                <ul class ="row">
       
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
                        <asp:Label ID="Label2" runat="server" style="z-index: 1;" Text="Marketplace Listing Delete"></asp:Label>
                         <br /> 
                         <br /> 
                    
                           
                        <asp:Label ID="lblLoad"  CssClass="navButton" runat="server" style="z-index: 1; " Text="Are you sure you want to delete the selected Listing?"></asp:Label>
                        <br /> 
                        <br /> 
                        <asp:Button ID="btnNo"  CssClass="navButton" runat="server" style="z-index: 1; " Text="No" OnClick="btnNo_Click" />
                        <asp:Button ID="btnYes" CssClass="navButton" runat="server" style="z-index: 1; " Text="Yes" OnClick="btnYes_Click" />
                    
                    
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
