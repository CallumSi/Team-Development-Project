<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCStaffList.aspx.cs" Inherits="VirginFrontEnd.VHCStaffList" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - List </title>
    <link href="VHCStaff.css" rel="stylesheet" type="text/css" />
</head>

<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare System</h2>
        </header>

        <%--ARTICLE SECTION--%>
        <article>
            <h4>LIST & FILTER STAFF SECTION </h4>

            <%--LIST BOX: STAFF--%>
            <asp:ListBox ID="lstStaff" runat="server" CssClass="lstStaff"></asp:ListBox>

            <%--LABEL: ERROR--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>

            <%--TEXTBOX: STAFF SEARCH--%>
            <asp:TextBox ID="txtStaffSearch" runat="server" CssClass="txtStaffSearch"></asp:TextBox>

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnListClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnListClose_Click" />

            <%--BUTTON: DISPLAY ALL STAFF--%>
            <asp:Button ID="btnDisplayAllStaffs" runat="server" CssClass="btnDisplayAllStaffs" Text="Display Full Details" OnClick="btnDisplayAllStaffs_Click" />

            <%--BUTTON: APPLY STAFF FILTER--%>
            <asp:Button ID="btnStaffApplyFilter" runat="server" CssClass="btnStaffApplyFilter" Text="Apply Filter" OnClick="btnStaffApplyFilter_Click" />

            <%--LABEL: FILTER STAFF--%>
            <asp:Label ID="lblFilterStaff" runat="server" CssClass="lblFilterStaff" Text="Filter By Staff : "></asp:Label>

            <%--BUTTON: EDIT STAFF--%>
            <asp:Button ID="btnEditStaff" runat="server" CssClass="EditStaff" Text="Edit Record" OnClick="btnEditStaff_Click" />

            <%--BUTTON: DELETE STAFF--%>
            <asp:Button ID="btnDeleteStaff" runat="server" CssClass="DeleteStaff" Text="Delete Record" OnClick="btnDeleteStaff_Click" />
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
