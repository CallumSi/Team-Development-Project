<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffCheckPin.aspx.cs" Inherits="VirginFrontEnd.VPStaffCheckPin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

         <header> 
                <h2>
                    Virgin Phones
                </h2>
        </header>
        <asp:Label ID="lblConfirmStaff" runat="server" style="z-index: 1; left: 850px; top: 192px; position: absolute" Text="Confirm Staff Pin" Font-Bold="True" ForeColor="Black" CssClass="column"></asp:Label>
        <asp:Label ID="lblConfirmPin" runat="server" style="z-index: 1; left: 748px; top: 266px; position: absolute" Text="Confirm Pin" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtStaffPin" runat="server" style="z-index: 1; left: 848px; top: 266px; position: absolute; width: 164px" Font-Bold="True" ForeColor="Black" CssClass="column" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnConfirm" runat="server" style="z-index: 1; left: 798px; top: 315px; position: absolute; height: 24px; width: 100px;" Text="Confirm" OnClick="btnConfirm_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; top: 315px; position: absolute; left: 925px; width: 101px; height: 25px;" Text="Back" OnClick="btnBack_Click" Font-Bold="True" ForeColor="Black" CssClass="column" />
        <asp:Label ID="lblPinError" runat="server" style="z-index: 1; left: 737px; top: 371px; position: absolute" Text="[lblPinError]" Font-Bold="True" ForeColor="Black" CssClass="column" Font-Size="Medium"></asp:Label>
        
        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" CssClass="column" OnClick="btnHome_Click1" />
        </nav>
       
         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
    </form>
</body>
</html>
