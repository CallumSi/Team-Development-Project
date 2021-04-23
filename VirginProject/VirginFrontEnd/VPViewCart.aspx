<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPViewCart.aspx.cs" Inherits="VirginFrontEnd.VPViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media View Phone Cart</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Media Cart
                </h2>
        </header>
        <asp:ListBox ID="lstShoppingCart" runat="server" style="z-index: 1; left: 625px; top: 203px; position: absolute; height: 279px; width: 505px"></asp:ListBox>
        
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 631px; top: 535px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        
        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px;" Text="Home" OnClick="btnHome_Click" Font-Bold="True" ForeColor="Black" />
            <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px;" Text="View Cart" Font-Bold="True" ForeColor="Black" />
            <asp:Button ID="btnEditAccount" runat="server" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Edit Account" Font-Bold="True" ForeColor="Black" OnClick="btnEditAccount_Click" />
            <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />
            <asp:Button ID="btnContinueShopping" runat="server" OnClick="btnContinueShopping_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Continue Shopping" Font-Bold="True" ForeColor="Black" />
        </nav>

           <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <p>
            &nbsp;</p>
        
        <asp:Button ID="btnDelivery" runat="server" style="z-index: 1; left: 629px; top: 494px; position: absolute; height: 25px; width: 195px;" Text="Continue to Delivery" OnClick="btnPayment_Click" Font-Bold="True" ForeColor="Black" />
        <p>
        
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 837px; top: 493px; position: absolute; height: 27px;" Text="Back" Font-Bold="True" ForeColor="Black" />

        </p>
        <asp:Label ID="lblShoppingCart" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 821px; top: 162px; position: absolute; width: 138px" Text="Shopping Cart"></asp:Label>
    </form>
</body>
</html>
