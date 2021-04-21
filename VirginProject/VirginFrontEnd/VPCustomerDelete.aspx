<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerDelete.aspx.cs" Inherits="VirginFrontEnd.VPCustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff Delete Customer</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

         <header> 
                <h2>
                    Virgin Phone Staff Delete Customer
                </h2>
        </header>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 688px; top: 223px; position: absolute" Text="Are you sure you want to delete this Customer?"  Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 761px; top: 272px; position: absolute; width: 85px; height: 32px;" Text="Delete"  Font-Bold="True" ForeColor="Black" />

        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home"  Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnStaffList" runat="server" OnClick="btnStaffList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Staff List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Phone List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px; right: 1018px" Text="Log Out " Font-Bold="True" ForeColor="Black" />
        </nav>
        

         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 901px; top: 272px; position: absolute; height: 32px; width: 85px;" Text="Cancel"  Font-Bold="True" ForeColor="Black" />

        </p>
    </form>
</body>
</html>
