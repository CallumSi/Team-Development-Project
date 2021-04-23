<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPThankYouConfirmation.aspx.cs" Inherits="VirginFrontEnd.VPThankYouConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Confirmation</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Media Confirmation
                </h2>
        </header>
        <asp:Label ID="lblThankYou" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 773px; top: 336px; position: absolute; height: 39px; width: 296px" Text="Thank you for your order" ForeColor="Black"></asp:Label>


        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />
        </nav>
   
    </form>

    <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
</body>
</html>
