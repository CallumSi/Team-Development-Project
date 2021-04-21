<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneList.aspx.cs" Inherits="VirginFrontEnd.VPPhoneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Media Staff Customer List</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Staff Phone List
                </h2>
        </header>
        <asp:ListBox ID="lstPhone" runat="server" style="z-index: 1; left: 677px; top: 213px; position: absolute; height: 281px; width: 505px"></asp:ListBox>
        <asp:Label ID="lblEnterAPhone" runat="server" style="z-index: 1; left: 682px; top: 505px; position: absolute" Text="Please enter a phone by make" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Small" ></asp:Label>
        <asp:TextBox ID="txtSearchPhone" runat="server" style="z-index: 1; left: 888px; top: 503px; position: absolute; width: 212px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 1118px; top: 502px; position: absolute; width: 100px;" Text="Apply Filter" Font-Bold="True" ForeColor="Black" CssClass="row"  />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 1037px; top: 564px; position: absolute; width: 100px;" Text="DisplayAll" Font-Bold="True" ForeColor="Black" CssClass="row"  />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 694px; top: 563px; position: absolute; width: 100px" Text="Add" Font-Bold="True" ForeColor="Black" CssClass="row"  />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 806px; top: 564px; position: absolute; width: 100px" Text="Edit" Font-Bold="True" ForeColor="Black" CssClass="row"  />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 921px; top: 564px; position: absolute; width: 100px; right: 490px;" Text="Delete" Font-Bold="True" ForeColor="Black" CssClass="row"  />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 694px; top: 621px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" CssClass="row" Font-Size="Small" ></asp:Label>
        
        
        <nav>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnStaffList" runat="server" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="Staff List " OnClick="btnStaffList_Click" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnCustomerList" runat="server" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Customer List" OnClick="btnCustomerList_Click" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnEditAccount" runat="server" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Edit Account" OnClick="btnEditAccount_Click" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" OnClick="btnLogOut_Click" Font-Bold="True" ForeColor="Black" />

        </nav>
        
        
   

          <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
        
        <asp:Label ID="lblstafflist" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 828px; top: 171px; position: absolute; width: 215px" Text="Virgin Phone List"></asp:Label>
        
    </form>

</body>
</html>
