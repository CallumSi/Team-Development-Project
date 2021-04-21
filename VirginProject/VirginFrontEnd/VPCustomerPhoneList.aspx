<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerPhoneList.aspx.cs" Inherits="VirginFrontEnd.VPCustomerPhoneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Virgin Media Customer Phone List</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Customer Phone List
                </h2>
        </header>


       
       
        <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 583px; top: 180px; position: absolute; height: 330px; width: 616px"></asp:ListBox>
        <asp:Button ID="btnViewPhone" runat="server" OnClick="btnViewPhone_Click" style="z-index: 1; left: 758px; top: 577px; position: absolute; height: 31px; width: 85px;" Text="View Phone" Font-Bold="True" ForeColor="Black"/>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 956px; top: 521px; position: absolute; height: 25px; width: 92px;" Text="Apply Filter"  Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 851px; top: 577px; position: absolute; width: 85px; height: 32px;" Text="Display All"  Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 594px; top: 643px; position: absolute" Text="[lblError]"  Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <asp:Label ID="lblCartCount" runat="server" style="z-index: 1; left: 233px; top: 295px; position: absolute" Text="[lblCartCount]" Font-Bold="True" ForeColor="Black"></asp:Label>
        
        <nav> 
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Cart" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px; margin-bottom: 5px" Text="Edit Account" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" CssClass="column" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>

        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblFilterByMake" runat="server" style="z-index: 1; left: 612px; top: 522px; position: absolute; right: 775px; height: 17px;" Text="Filter By Make"  Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <p>
        <asp:TextBox ID="txtFilterPhoneMake" runat="server" style="z-index: 1; left: 720px; top: 520px; position: absolute; width: 221px"></asp:TextBox>
        
        </p>

    </form>
</body>
</html>
