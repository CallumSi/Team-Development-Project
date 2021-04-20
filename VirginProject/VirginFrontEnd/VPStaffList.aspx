<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffList.aspx.cs" Inherits="VirginFrontEnd.VPStaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 408px; top: 105px; position: absolute; height: 276px; width: 484px"></asp:ListBox>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 414px; top: 390px; position: absolute" Text="Please enter the staff's first name "></asp:Label>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 632px; top: 390px; position: absolute; width: 206px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 414px; top: 416px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 863px; top: 388px; position: absolute; width: 85px" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 412px; top: 447px; position: absolute; width: 60px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 482px; top: 447px; position: absolute; width: 62px" Text="Edit" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 554px; top: 447px; position: absolute; width: 70px" Text="Delete" />
        </p>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 42px; top: 127px; position: absolute; height: 66px; width: 151px" Text="Home" />
        <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" style="z-index: 1; left: 46px; top: 225px; position: absolute; height: 63px; width: 143px" Text="Customer List" />
        <asp:Button ID="btnPhoneList" runat="server" OnClick="btnPhoneList_Click" style="z-index: 1; left: 45px; top: 326px; position: absolute; height: 65px; width: 146px" Text="Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 46px; top: 525px; position: absolute; height: 59px; width: 143px" Text="Log Out" />
    </form>
</body>
</html>
