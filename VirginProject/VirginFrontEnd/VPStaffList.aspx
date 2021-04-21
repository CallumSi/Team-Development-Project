<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffList.aspx.cs" Inherits="VirginFrontEnd.VPStaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff List</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Staff List
                </h2>
        </header>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 666px; top: 487px; position: absolute; right: 652px;" Text="Please enter the staff's first name" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 883px; top: 485px; position: absolute; width: 206px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 702px; top: 596px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 1108px; top: 485px; position: absolute; width: 99px" Text="Apply Filter" OnClick="btnApply_Click" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 722px; top: 539px; position: absolute; width: 100px" Text="Add" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 829px; top: 539px; position: absolute; width: 100px" Text="Edit" Font-Bold="True" ForeColor="Black" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 939px; top: 538px; position: absolute; width: 100px" Text="Delete" Font-Bold="True" ForeColor="Black" />
        </p>


        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="Customer List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnStaffList" runat="server" OnClick="btnStaffList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Staff List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Phone List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black" />
        
        </nav>
       

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 686px; top: 191px; position: absolute; height: 280px; width: 502px"></asp:ListBox>
        <asp:Label ID="lblStaffList" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 844px; top: 159px; position: absolute; width: 208px" Text="Virgin Phone Staff List"></asp:Label>
    </form>
</body>
</html>
