<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnPhone.aspx.cs" Inherits="VirginFrontEnd.AnPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 479px; top: 106px; position: absolute" Text="Capacity"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 479px; top: 170px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 481px; top: 235px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 480px; top: 300px; position: absolute" Text="Make"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 481px; top: 361px; position: absolute" Text="Model"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 482px; top: 424px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 480px; top: 549px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 582px; top: 109px; position: absolute; width: 139px"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 583px; top: 170px; position: absolute; width: 140px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 580px; top: 234px; position: absolute; width: 150px"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 580px; top: 298px; position: absolute; width: 156px;"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 580px; top: 358px; position: absolute; width: 160px;"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 577px; top: 420px; position: absolute; width: 157px;"></asp:TextBox>
        <asp:DropDownList ID="ddlQuantity" runat="server" style="z-index: 1; left: 575px; top: 549px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 479px; top: 602px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 599px; position: absolute; left: 648px; width: 56px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 569px; top: 600px; position: absolute; width: 51px" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="lblStockStatus" runat="server" style="z-index: 1; left: 480px; top: 482px; position: absolute" Text="StockStatus"></asp:Label>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 575px; top: 483px; position: absolute; width: 120px" />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 69px; top: 106px; position: absolute; height: 68px; width: 162px" Text="Home" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 68px; top: 206px; position: absolute; height: 65px; width: 162px" Text="View Staff List" />
        <asp:Button ID="btnViewCustomer" runat="server" OnClick="btnViewCustomer_Click" style="z-index: 1; left: 74px; top: 306px; position: absolute; height: 66px; width: 156px" Text="View Customer List" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 74px; top: 408px; position: absolute; height: 64px; width: 156px" Text="View Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 76px; top: 570px; position: absolute; height: 57px; width: 153px" Text="Log Out" />
    </form>
</body>
</html>
