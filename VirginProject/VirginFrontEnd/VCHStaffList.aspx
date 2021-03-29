﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHStaffList.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 14px; top: 23px; position: absolute" Text="Staff"></asp:Label>
        </div>
        <asp:Button ID="btnApplyStaff" runat="server" style="z-index: 1; left: 10px; top: 488px; position: absolute; right: 1081px;" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAllStaff" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 97px; top: 488px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAddStaff" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 7px; top: 539px; position: absolute" Text="Add" />
        <asp:Button ID="btnEditStaff" runat="server" style="z-index: 1; left: 77px; top: 540px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDeleteStaff" runat="server" style="z-index: 1; left: 142px; top: 539px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearchStaff" runat="server" style="z-index: 1; left: 13px; top: 441px; position: absolute"></asp:TextBox>
        <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 10px; top: 61px; position: absolute"></asp:ListBox>
        <asp:Label ID="lblUsernameStaff" runat="server" style="z-index: 1; left: 11px; top: 375px; position: absolute" Text="Please Enter a Staff Username"></asp:Label>
        </p>
        <asp:Label ID="lblErrorStaff" runat="server" style="z-index: 1; left: 10px; top: 407px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
