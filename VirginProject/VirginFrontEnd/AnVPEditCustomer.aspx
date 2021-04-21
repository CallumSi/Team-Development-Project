<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPEditCustomer.aspx.cs" Inherits="VirginFrontEnd.AnVPEditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Customer Edit</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Customer Edit
                </h2>
        </header>
       
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 696px; top: 210px; position: absolute; height: 25px; width: 98px" Text="First Name:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 847px; top: 211px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 696px; top: 274px; position: absolute" Text="Last Name:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblCustomerStreet" runat="server" style="z-index: 1; left: 697px; top: 343px; position: absolute; bottom: 468px;" Text="Street:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerStreet" runat="server" style="z-index: 1; left: 849px; top: 345px; position: absolute; width: 143px; height: 18px;"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 695px; top: 415px; position: absolute" Text="Address:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 848px; top: 416px; position: absolute; width: 145px; height: 18px;"></asp:TextBox>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 694px; top: 489px; position: absolute" Text="Postcode:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 848px; top: 492px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 697px; top: 566px; position: absolute" Text="Email:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 850px; top: 565px; position: absolute; width: 145px; height: 17px;" Width="22px"></asp:TextBox>
        <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 687px; top: 638px; position: absolute" Text="Telephone:" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 850px; top: 633px; position: absolute; right: 525px; height: 17px; width: 145px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1016px; top: 681px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 808px; top: 703px; position: absolute; width: 61px;" Text="OK" Font-Bold= "True" ForeColor="Black" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 892px; top: 703px; position: absolute" Text="Cancel" Font-Bold="True" ForeColor="Black" />


        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black"/>
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Cart" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Edit Account" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <asp:Label ID="lblCustomerEdit" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 768px; top: 141px; position: absolute" Text="Virgin Phone Customer Edit"></asp:Label>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 848px; top: 276px; position: absolute; width: 145px"></asp:TextBox>
    </form>
</body>
</html>
