<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnUser.aspx.cs" Inherits="VirginFrontEnd.ForumAnUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forum AnUser</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form2" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                    <li>
                        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1;" Text="First Name"></asp:Label>
                        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; " Text="Last Name"></asp:Label>
                        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                         <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1;" Text="Phone Number"></asp:Label>
                        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; "></asp:TextBox>
                    </li>
                    <li>      
                         <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1;" Text="Email Address"></asp:Label>
                         <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                         <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1;" Text="OK" />
                         <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" OnClick="btnCancel_Click" />
                    </li>
                    <li>
                         <asp:Label ID="lblUserError" runat="server" style="z-index: 1;"></asp:Label>
                    </li>
                </ul>
                    </article>
 
            <nav>
                Navigation links here
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
        </form>
    </body>
</html>
