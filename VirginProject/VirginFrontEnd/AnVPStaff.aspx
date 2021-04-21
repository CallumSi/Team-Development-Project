<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPStaff.aspx.cs" Inherits="VirginFrontEnd.AnVPStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff Add Staff</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <div>

        </div>

        <header> 
                <h2>
                    Virgin Phone Staff Add Staff
                </h2>
        </header>
        <asp:Label ID="lblStaffFirstName" runat="server" style="z-index: 1; left: 706px; top: 215px; position: absolute" Text="First Name:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 705px; top: 286px; position: absolute" Text="LastName:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStaffStreet" runat="server" style="z-index: 1; left: 708px; top: 358px; position: absolute" Text="Street:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStaffAddres" runat="server" style="z-index: 1; left: 702px; top: 426px; position: absolute" Text="Address:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStaffPostcode" runat="server" style="z-index: 1; left: 701px; top: 494px; position: absolute" Text="Postcode:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStaffTelephone" runat="server" style="z-index: 1; left: 700px; top: 631px; position: absolute" Text="Telephone:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1036px; top: 707px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 791px; top: 705px; position: absolute; width: 66px;" Text="OK" OnClick="btnOK_Click" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 877px; top: 705px; position: absolute; width: 72px;" Text="Cancel" OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black" />
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 851px; top: 218px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 852px; top: 290px; position: absolute; width: 143px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffStreet" runat="server" style="z-index: 1; left: 851px; top: 357px; position: absolute; width: 146px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 851px; top: 426px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffPostcode" runat="server" style="z-index: 1; left: 853px; top: 491px; position: absolute; width: 145px; height: 18px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 854px; top: 562px; position: absolute; width: 145px; height: 18px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffTelephone" runat="server" style="z-index: 1; left: 857px; top: 632px; position: absolute; width: 146px; height: 17px;"></asp:TextBox>
        
        
        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px; bottom: 384px" Text="View Staff List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewCustomerList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="View Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="View Phone List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />

        </nav>
        
         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <p>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 705px; top: 562px; position: absolute; " Text="Email:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        </p>
        <asp:Label ID="lblAddStaff" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 787px; top: 145px; position: absolute; width: 258px" Text="Virgin Phone Add / Edit Staff"></asp:Label>
    </form>
</body>
</html>
