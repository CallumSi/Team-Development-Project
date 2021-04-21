<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerWelcome.aspx.cs" Inherits="VirginFrontEnd.VPCustomerWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Virgin Media Welcome</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Welcome
                </h2>
        </header>
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 852px; top: 317px; position: absolute" Text="Continue " OnClick="btnContinue_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />


        <nav>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        </nav>
     <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
       
        <p>
            &nbsp;</p>
        <asp:Label ID="lblWelcome" runat="server" CssClass="row" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" style="z-index: 1; left: 826px; top: 192px; position: absolute; height: 28px" Text="Welcome to Virgin Phones"></asp:Label>
        <p>
        <asp:Button ID="btnFirstTime" runat="server" style="z-index: 1; left: 1025px; top: 318px; position: absolute" Text="First Time?" Font-Bold="True" ForeColor="Black" CssClass="column" />


        </p>
        <asp:Label ID="lblSelect" runat="server" CssClass="row" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 790px; top: 244px; position: absolute" Text="Please select from one of the options below"></asp:Label>
       
    </form>

     </body>
</html>
