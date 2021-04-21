<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneDelete.aspx.cs" Inherits="VirginFrontEnd.VPPhoneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Virgin Media Staff Delete Phone</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Staff Delete Phone
                </h2>
        </header>
        <asp:Label ID="lblDeletePhone" runat="server" style="z-index: 1; left: 720px; top: 222px; position: absolute" Text="Are you sure you want to delete this phone?"  Font-Bold="True" ForeColor="Black" Font-Size="Medium"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 784px; top: 269px; position: absolute; height: 32px; width: 85px;" Text="Delete" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 923px; top: 269px; position: absolute; height: 32px; width: 85px;" Text="Cancel" Font-Bold="True" ForeColor="Black" />
        
        <nav>
        <asp:Button ID="btnPhoneHome" runat="server" OnClick="btnPhoneHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Staff List" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 72px; width: 172px" Text="View Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="View Phone List" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />

        </nav>
      
         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
       
    </form>
</body>
</html>
