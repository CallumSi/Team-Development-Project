<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminForgotPassword.aspx.cs" Inherits="VirginFrontEnd.ForumAdminForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminForgotPassword</title>
   <link href="AdminSecurity.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
         
            <article>
                   <h1>Admin Forgot Password</h1>

                <asp:Label ID="lblUsername"  CssClass="lblUserName" runat="server" Style="z-index: 1;" Text="UserName"></asp:Label>
                <asp:TextBox ID="txtUsername"  CssClass="txtUsername" runat="server" Style="z-index: 1;"></asp:TextBox>

                <asp:Label ID="lblPassword" CssClass="lblPassword" runat="server" Style="z-index: 1; top: 290px;" Text="New Password"></asp:Label>
                <asp:TextBox ID="txtPassword" CssClass="txtPassword" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>

                <asp:Label ID="lblPasswordConfirm" CssClass="lblPasswordConfirm" runat="server" Style="z-index: 1;" Text="New Password Confirm"></asp:Label>
                <asp:TextBox ID="txtPasswordConfirm"  CssClass="txtPasswordConfirm" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>

                <asp:Label ID="lblSecret" CssClass="lblSecret" runat="server" Style="z-index: 1;" Text="Secret"></asp:Label>
                <asp:TextBox ID="txtSecret"  CssClass="txtSecret" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>

                <asp:Label ID="lblError" CssClass="lblErrorMessage" runat="server" Style="z-index: 1;"></asp:Label>

                <asp:Button ID="BtnSubmit"  CssClass="btnSubmit" runat="server" OnClick="BtnSubmit_Click" Style="z-index: 1;" Text="Submit" />
                <asp:Button ID="btnCancel" CssClass="btnClose" runat="server" Style="z-index: 1;" Text="X" OnClick="btnCancel_Click" Font-Bold="True" Font-Size="Large" ForeColor="Black" />

            </article>

        </header>

        <nav>
            Navigation links here
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
