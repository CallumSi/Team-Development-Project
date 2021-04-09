<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceCheckout.aspx.cs" Inherits="VirginFrontEnd.MarketplaceCheckout" %>

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
                 <ul class ="row">
                      <li>
                          <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                        <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>     
                       </li>
                       <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                           <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                           <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" Height="35px" />
                       </li>
                                      
                    
                 </ul>
                <ul>
                   <li>
                       Please enter your details
                   </li>
                    <li>
                      Credit card no <asp:TextBox ID="txtCardNo" runat="server" Width="257px"></asp:TextBox>
                   </li>
                    <li>
                        <asp:Button ID="btnCheckout" CssClass="navButton" runat="server" OnClick="btnCheckout_Click" Text="Check Out" />
                   </li>
                    <li>
                     <asp:Label ID="lblError" runat="server"></asp:Label>
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
