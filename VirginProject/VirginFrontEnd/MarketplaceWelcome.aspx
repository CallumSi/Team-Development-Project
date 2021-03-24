<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceWelcome.aspx.cs" Inherits="VirginFrontEnd.MarketplaceWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link href="VirginProject.css" rel="stylesheet" type="text/css" />

</head>
<body>

        
    <form id="form1" runat="server">
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
               <h2> Welcome To The Online Marketplace </h2> 
                <asp:Button ID="btnFirstTime" CssClass="Button" runat="server" OnClick="btnFirstTime_Click" style="z-index: 1; left: 575px; top: 339px; position: fixed" Text="First Time?" />
                <asp:Button ID="btnContinue" CssClass="Button" runat="server" style="z-index: 1; left: 413px; top: 341px; position: fixed" Text="Continue " OnClick="btnContinue_Click" />
    
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
