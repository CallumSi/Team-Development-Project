<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnPhone.aspx.cs" Inherits="VirginFrontEnd.AnPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff Add Phone</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Staff Add Phone
                </h2>
        </header>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 665px; top: 206px; position: absolute" Text="Capacity:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 665px; top: 270px; position: absolute" Text="Colour:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 666px; top: 345px; position: absolute" Text="Description:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 667px; top: 413px; position: absolute" Text="Make:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 669px; top: 483px; position: absolute" Text="Model:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 668px; top: 554px; position: absolute" Text="Price:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 667px; top: 698px; position: absolute" Text="Quantity:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 808px; top: 206px; position: absolute; width: 145px" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 808px; top: 269px; position: absolute; width: 145px" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 809px; top: 343px; position: absolute; width: 145px" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 809px; top: 413px; position: absolute; width: 145px; height: 17px;" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 810px; top: 481px; position: absolute; width: 145px; height: 17px;" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 808px; top: 556px; position: absolute; width: 145px;" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        <asp:DropDownList ID="ddlQuantity" runat="server" style="z-index: 1; left: 816px; top: 699px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1091px; top: 692px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 737px; position: absolute; left: 947px; width: 85px; height: 32px;" Text="Cancel" OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 856px; top: 737px; position: absolute; width: 85px; height: 32px;" Text="OK" OnClick="btnOK_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Label ID="lblStockStatus" runat="server" style="z-index: 1; left: 667px; top: 622px; position: absolute" Text="StockStatus:" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Medium"></asp:Label>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 813px; top: 613px; position: absolute; width: 120px" Font-Bold="True" ForeColor="Black" Font-Size="Medium" />

        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Staff List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewCustomer" runat="server" OnClick="btnViewCustomer_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="View Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="View Phone List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />
        </nav>
       
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <asp:Label ID="lblAddPhone" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 808px; top: 142px; position: absolute" Text="Virgin Phone Add Phone"></asp:Label>
</form>
</body>
</html>
