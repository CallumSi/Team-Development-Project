<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VPStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Virgin Media Staff Delete</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Staff Delete
                </h2>
        </header>
        <asp:Label ID="lblDeleteStaff" runat="server" style="z-index: 1; left: 765px; top: 199px; position: absolute" Text="Are you sure you want to delete this Staff?" Font-Bold="True" ForeColor="Black" ></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 843px; top: 256px; position: absolute; width: 100px;" Text="Delete" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 975px; top: 256px; position: absolute; width: 100px;" Text="Cancel" OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black"  />
 

        <nav>
    <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewCustomer" runat="server" OnClick="btnViewCustomer_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Customer List" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="View Staff List" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="View Phone List" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black"  />

        </nav>
       
    </form>

    <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
    </body>
</html>
