<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPCustomer.aspx.cs" Inherits="VirginFrontEnd.AVPCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff Add Customer</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">

         <header> 
                <h2>
                    Virgin Media Staff Add Customer
                </h2>
        </header>
        <div>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 698px; top: 240px; position: absolute"  Text="First Name:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 701px; top: 311px; position: absolute; height: 19px; bottom: 500px;" Text="Last Name:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerStreet" runat="server" style="z-index: 1; left: 702px; top: 385px; position: absolute" Text="Street:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 699px; top: 445px; position: absolute" Text="Address:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 701px; top: 507px; position: absolute; bottom: 295px;" Text="Postcode:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 701px; top: 564px; position: absolute" Text="Email:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 699px; top: 624px; position: absolute" Text="Telephone:" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1061px; top: 626px; position: absolute" Text="[lblError]" CssClass="row" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 848px; top: 711px; position: absolute; width: 84px; height: 32px;" Text="OK" OnClick="btnOK_Click" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 952px; top: 711px; position: absolute; width: 85px; height: 32px;" Text="Cancel" OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black" />
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 850px; top: 238px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 852px; top: 308px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerStreet" runat="server" style="z-index: 1; left: 852px; top: 382px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 853px; top: 449px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 851px; top: 510px; position: absolute; width: 145px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 853px; top: 570px; position: absolute; width: 144px; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 853px; top: 625px; position: absolute; width: 145px; height: 17px; margin-bottom: 0px;"></asp:TextBox>
        
        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Staff List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewCustomerList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="View Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="View Phone List" Font-Bold="True" ForeColor="Black"/>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>

         <asp:Label ID="lblStaffAddCustomer" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 783px; top: 164px; position: absolute" Text="Virgin Phone Add / Edit Customer"></asp:Label>

    </form>
      
</body>
</html>
