<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerList.aspx.cs" Inherits="VirginFrontEnd.VPCustomerList" %>

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
                    Virgin Phone Staff Customer List
                </h2>
        </header>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 610px; top: 501px; position: absolute" Text="Please enter the customer's first name" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 663px; top: 625px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Small"></asp:Label>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 1099px; top: 495px; position: absolute; width: 100px; height: 26px;" Text="Apply Filter" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 1005px; top: 557px; position: absolute; height: 26px; width: 100px;" Text="DisplayAll" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 764px; top: 556px; position: absolute; width: 100px; right: 664px; height: 26px;" Text="Edit" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 884px; top: 556px; position: absolute; width: 100px; height: 26px;" Text="Delete" Font-Bold="True" ForeColor="Black" />
        
        

        <nav>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" Text="Home" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="Customer List" Font-Bold= "True" ForeColor="Black" />
        <asp:Button ID="btnStaffList" runat="server" OnClick="btnStaffList_Click" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="Staff List" Font-Bold="True" ForeColor="Black"/>
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Phone List" Font-Bold="True" ForeColor="Black" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 58px; top: 519px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black"/>
        </nav>

         <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>
       
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 867px; top: 497px; position: absolute; width: 208px" Font-Bold="True" ForeColor="Black"></asp:TextBox>
        </p>
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 660px; top: 203px; position: absolute; height: 281px; width: 505px; margin-top: 0px" ></asp:ListBox>
        <p>
            <asp:Label ID="lblstaffcustomerlist" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" style="z-index: 1; left: 793px; top: 166px; position: absolute; width: 260px" Text="Virgin Phone Customer List"></asp:Label>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 650px; top: 556px; position: absolute; width: 100px; height: 26px;" Text="Add" Font-Bold="True" ForeColor="Black"/>
       
    </form>
</body>
</html>
