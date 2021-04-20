<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumUserList.aspx.cs" Inherits="VirginFrontEnd.ForumUserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User List page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>
            <h1>User Page</h1>
            <ul>
                <li>
                    <asp:ListBox ID="lstUserListBox" runat="server" Style="z-index: 1;" Height="265px" Width="456px"></asp:ListBox>
                </li>
                <li>
                    <asp:Label ID="lblUserFilter" runat="server" Style="z-index: 1;" Text="Please filter by first name."></asp:Label>
                    <asp:TextBox ID="txtFilterbyuserfirstname" runat="server" Style="z-index: 1;" Width="241px"></asp:TextBox>
                </li>
                <li>
                    <asp:Button ID="btnApply" runat="server" Style="z-index: 1;" Text="Apply" OnClick="btnApply_Click1" CssClass="navButton" />
                </li>
                <li>
                    <asp:Button ID="btnAdd" runat="server" Style="z-index: 1;" Text="Add Account" OnClick="btnAdd_Click1" Visible="False" CssClass="navButton" />
                    <asp:Button ID="btnEdit" runat="server" Style="z-index: 1;" Text="Edit Account" OnClick="btnEdit_Click1" CssClass="navButton" />
                    <asp:Button ID="btnDelete" runat="server" Style="z-index: 1;" Text="Delete Account" OnClick="btnDelete_Click1" CssClass="navButton" />
                </li>
                <li>
                    <asp:Label ID="lblError" runat="server" Style="z-index: 1;"></asp:Label>
                </li>

            </ul>
        </article>

        <nav>

            <ul>
                <li>
                </li>
                <li>
                    <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Style="z-index: 1;" Text="Sign Out" CssClass="Button" />
                    <asp:Button ID="btnForumPost" runat="server" OnClick="btnForumPost_Click" Style="z-index: 1;" Text="Forum" CssClass="Button" />
                </li>
            </ul>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
