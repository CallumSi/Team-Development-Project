<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStafforCustomerSelection.aspx.cs" Inherits="VirginFrontEnd.VPStafforCustomerSelection" %>

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
        
        <asp:Label ID="lblSelectAccount" runat="server" style="z-index: 1; left: 730px; top: 229px; position: absolute; height: 21px; width: 371px" Text="Please select below which account you would like to access" Font-Bold="True" ForeColor="Black"></asp:Label>
        <asp:Button ID="btnVPAStaff" runat="server" Font-Bold="True" OnClick="btnVPAStaff_Click" style="z-index: 1; left: 719px; top: 307px; position: absolute; height: 58px; width: 149px" Text="Staff"  />
        <asp:Button ID="btnVPACustomer" runat="server" Font-Bold="True" OnClick="btnVPACustomer_Click" style="z-index: 1; left: 924px; top: 307px; position: absolute; height: 58px; width: 149px" Text="Customer" />

        
    <nav>
    <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" OnClick="btnHome_Click" />
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
