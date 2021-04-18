<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneView.aspx.cs" Inherits="VirginFrontEnd.VPPhoneView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
        <title>Listing</title>
        <link href="VirginProject.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
        <div>
        </div>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 86px; top: 167px; position: absolute" Text="Capacity " ForeColor="White"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 91px; top: 237px; position: absolute; bottom: 572px;" Text="Colour" ForeColor="White"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 89px; top: 304px; position: absolute" Text="Description " ForeColor="White"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 99px; top: 365px; position: absolute" Text="Make" ForeColor="White"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 103px; top: 430px; position: absolute; height: 21px;" Text="Model" ForeColor="White"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 98px; top: 488px; position: absolute" Text="Price" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="ddlPhoneQuantity" runat="server" style="z-index: 1; top: 559px; position: absolute; left: 176px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 98px; top: 560px; position: absolute" Text="Quantity" ForeColor="White"></asp:Label>
             <asp:Label ID="lblPhoneCapacity" runat="server" style="z-index: 1; left: 166px; top: 167px; position: absolute" Text="[lblCapacity]"></asp:Label>
             <asp:Label ID="lblPhoneColour" runat="server" style="z-index: 1; left: 161px; top: 239px; position: absolute" Text="[lblColour]"></asp:Label>
             <asp:Label ID="lblPhoneDescription" runat="server" style="z-index: 1; left: 196px; top: 304px; position: absolute" Text="[lblDescription]"></asp:Label>
             <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 167px; top: 367px; position: absolute" Text="[lblMake]"></asp:Label>
             <asp:Label ID="lblPhoneModel" runat="server" style="z-index: 1; left: 171px; top: 431px; position: absolute" Text="[lblModel]"></asp:Label>
             <asp:Label ID="lblPhonePrice" runat="server" style="z-index: 1; left: 158px; top: 489px; position: absolute" Text="lblPhonePrice"></asp:Label>
             <p>
                 <asp:Button ID="btnAddCart" runat="server" style="z-index: 1; left: 105px; top: 653px; position: absolute; width: 112px" Text="Add To Cart" />
             </p>
             <p>
                 &nbsp;</p>
    </form>
</body>
</html>
