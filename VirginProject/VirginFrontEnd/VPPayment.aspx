<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPayment.aspx.cs" Inherits="VirginFrontEnd.VPPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Virgin Media Phone Payment</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

         <header> 
                <h2>
                    Virgin Phone Payment
                </h2>
             </header>
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 645px; top: 266px; position: absolute" Text="CardNo" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 776px; top: 268px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:Label ID="lblExpiryDate" runat="server" style="z-index: 1; left: 642px; top: 327px; position: absolute" Text="Expiry Date" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblSecurityNo" runat="server" style="z-index: 1; left: 643px; top: 386px; position: absolute" Text="SecurityNo" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtExpiryDate" runat="server" style="z-index: 1; left: 777px; top: 325px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtSecurityNo" runat="server" style="z-index: 1; left: 776px; top: 379px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:Button ID="btnPlaceOrder" runat="server" style="z-index: 1; left: 738px; top: 444px; position: absolute; right: 523px; height: 32px; width: 85px;" Text="Place Order" OnClick="btnPlaceOrder_Click" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 859px; top: 444px; position: absolute; width: 85px; height: 32px;" Text="Cancel " OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black"/>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 648px; top: 507px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
       
        <nav>

        <asp:Button ID="btnCustomerHome" runat="server" OnClick="btnCustomerHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Cart" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Edit Account" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />

        </nav>
     
         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
    </form>
</body>
</html>
