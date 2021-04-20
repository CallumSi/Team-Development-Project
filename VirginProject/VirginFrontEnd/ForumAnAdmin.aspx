<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnAdmin.aspx.cs" Inherits="VirginFrontEnd.ForumAnAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forum AnAdmin page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>
            <h1>Admin Details</h1>
            <ul>
                <li>
                    <asp:Label ID="lblFirstName" runat="server" Style="z-index: 1;" Text="FirstName"></asp:Label>
                    <asp:TextBox ID="txtFirstName" runat="server" Style="z-index: 1;"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="lblLastName" runat="server" Style="z-index: 1;" Text="Last Name"></asp:Label>
                    <asp:TextBox ID="txtLastName" runat="server" Style="z-index: 1;"></asp:TextBox>
                </li>
                <li>
                    <asp:Label ID="lblEmailAddress" runat="server" Style="z-index: 1;" Text="Email Address"></asp:Label>
                    <asp:TextBox ID="txtEmailAddress" runat="server" Style="z-index: 1;"></asp:TextBox>
                </li>

                <li>
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Style="z-index: 1;" Text="OK" CssClass="navButton" />
                    <asp:Button ID="btnCancel" runat="server" Style="z-index: 1;" Text="Cancel" OnClick="btnCancel_Click1" CssClass="navButton" />
                </li>
                <li>
                    <asp:Label ID="lblError" runat="server" Style="z-index: 1;"></asp:Label>
                </li>
            </ul>
        </article>

        <nav>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
