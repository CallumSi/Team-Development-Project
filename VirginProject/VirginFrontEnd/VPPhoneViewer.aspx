<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneViewer.aspx.cs" Inherits="VirginFrontEnd.VPPhoneViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Virgin Media Customer Phone Viewer</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Customer
                </h2>
        </header>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 714px; top: 179px; position: absolute" Text="Capacity:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 715px; top: 239px; position: absolute; right: 731px;" Text="Colour:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 695px; top: 294px; position: absolute" Text="Description:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 716px; top: 353px; position: absolute" Text="Make:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 715px; top: 414px; position: absolute" Text="Model:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 713px; top: 481px; position: absolute" Text="Price:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblStockStatus" runat="server" style="z-index: 1; left: 677px; top: 539px; position: absolute" Text="Stock Status:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 695px; top: 608px; position: absolute; right: 725px" Text="Quantity:" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhoneCapacity" runat="server" style="z-index: 1; left: 814px; top: 180px; position: absolute" Text="[lblCapacity]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhoneColour" runat="server" style="z-index: 1; left: 817px; top: 238px; position: absolute" Text="[lblColour]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhoneDescription" runat="server" style="z-index: 1; left: 817px; top: 296px; position: absolute" Text="[lblDescription]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 818px; top: 356px; position: absolute" Text="[lblMake]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhoneModel" runat="server" style="z-index: 1; left: 820px; top: 414px; position: absolute" Text="[lblModel]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPhonePrice" runat="server" style="z-index: 1; left: 820px; top: 483px; position: absolute" Text="[lblPrice]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:DropDownList ID="ddlQuantity" runat="server" style="z-index: 1; left: 813px; top: 608px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 813px; top: 540px; position: absolute" Checked="True" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"/>
        <asp:Button ID="btnAddToCart" runat="server" OnClick="btnAddToCart_Click" style="z-index: 1; left: 737px; top: 727px; position: absolute; height: 27px; right: 661px;" Text="Add To Cart" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 688px; top: 668px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>


        <nav> 
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" OnClick="btnHome_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button runat="server" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Cart" ID="btnViewCart" OnClick="btnViewCart_Click" Font-Bold="True" ForeColor="Black" CssClass="column"/>
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Edit Account" Font-Bold="True" ForeColor="Black" CssClass="column"/>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" CssClass="column" />

        </nav>

         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
       

        <asp:Button ID="btnBack" runat="server" Font-Bold="True" ForeColor="Black" OnClick="btnBack_Click" style="z-index: 1; left: 865px; top: 727px; position: absolute; width: 100px; height: 26px" Text="Back" />

        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 780px; top: 71px; position: absolute" Text="lblCustomerFirstName"></asp:Label>

    </form>
</body>
</html>
