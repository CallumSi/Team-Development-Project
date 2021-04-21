<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPDeliveryList.aspx.cs" Inherits="VirginFrontEnd.VPDeliveryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Virgin Media Delivery</title>
     <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header> 
                <h2>
                    Virgin Phone Delivery
                </h2>
        </header>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 739px; top: 166px; position: absolute" Text="Title:" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 712px; top: 229px; position: absolute" Text="FirstName:" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 709px; top: 290px; position: absolute" Text="LastName:" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 711px; top: 352px; position: absolute" Text="House No:" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 713px; top: 418px; position: absolute" Text="Address:" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 710px; top: 487px; position: absolute" Text="Postcode" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 692px; top: 555px; position: absolute" Text="Delivery Date" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 825px; top: 167px; position: absolute; width: 145px; height: 16px;"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 825px; top: 228px; position: absolute; height: 16px; width: 145px;"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 825px; top: 290px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 824px; top: 350px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 824px; top: 417px; position: absolute; width: 145px;"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 822px; top: 486px; position: absolute; width: 145px; margin-bottom: 0px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 700px; top: 688px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="Black" Font-Size="Medium" ></asp:Label>
        <asp:DropDownList ID="ddlDeliveryDate" runat="server" style="z-index: 1; left: 824px; top: 554px; position: absolute; height: 19px; width: 172px">
            <asp:ListItem>Monday 1st June, 2021 </asp:ListItem>
            <asp:ListItem>Tuesday 2nd June, 2021 </asp:ListItem>
            <asp:ListItem>Wednesday 3rd June, 2021</asp:ListItem>
            <asp:ListItem>Thursday 4th June, 2021</asp:ListItem>
            <asp:ListItem>Friday 5th June, 2021</asp:ListItem>
            <asp:ListItem>Saturday 6th June, 2021</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnContinueToPayment" runat="server" OnClick="btnContinueToPayment_Click1" style="z-index: 1; left: 703px; top: 622px; position: absolute; width: 152px" Text="Continue To Payment" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 866px; top: 622px; position: absolute; width: 60px;" Text="Cancel" OnClick="btnCancel_Click" Font-Bold="True" ForeColor="Black"  />
        
        <nav>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px;" Text="Home" OnClick="btnHome_Click" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 58px; top: 396px; position: absolute; height: 77px; width: 172px" Text="Log Out" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewCart" runat="server" style="z-index: 1; left: 58px; top: 273px; position: absolute; height: 77px; width: 172px" Text="View Cart" OnClick="btnViewCart_Click" Font-Bold="True" ForeColor="Black"  />
        <asp:Button ID="btnViewCustomerPhone" runat="server" OnClick="btnViewCustomerPhone_Click" style="z-index: 1; left: 58px; top: 150px; position: absolute; height: 77px; width: 172px" Text="View Phones" Font-Bold="True" ForeColor="Black"  />

        </nav>
       
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
                </div>
    
        </footer>

    </form>
</body>
</html>
