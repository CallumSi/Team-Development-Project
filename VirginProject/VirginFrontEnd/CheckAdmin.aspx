<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckAdmin.aspx.cs" Inherits="VirginFrontEnd.CheckAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>CheckAdmin</title>
 <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">

        <header>
            <h2>Virgin Media </h2>
              
        </header>

        <article>
          <h1> Check Admin </h1>
            <ul>

                <li>
                    <asp:Label ID="lblPin" runat="server" style="z-index: 1;" Text="Please enter your pin"></asp:Label>
                     <asp:TextBox ID="txtPin" runat="server" style="z-index: 1;" TextMode="Password"></asp:TextBox>
                </li>

                <li>
                    <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1;" Text="Ok" />
                </li>

                <li>
                     <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
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
