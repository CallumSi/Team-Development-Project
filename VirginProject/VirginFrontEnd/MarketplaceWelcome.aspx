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
                   <asp:Button ID="btnContinue" CssClass="Button" runat="server" style="z-index: 1; " Text="Continue " OnClick="btnContinue_Click" />
                <asp:Button ID="btnFirstTime" CssClass="Button" runat="server" OnClick="btnFirstTime_Click" style="z-index: 1;" Text="First Time?" />
             
    
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
