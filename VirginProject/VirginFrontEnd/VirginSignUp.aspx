<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginSignUp.aspx.cs" Inherits="VirginFrontEnd.VirginSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <head id="Head1" runat="server">
        <title>Sample Master Page</title>
        <link href="VirginProject.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
             
                <li>
                <asp:Label ID="lblUsername" runat="server" style="z-index: 1;" Text="UserName"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1;"></asp:TextBox>
               </li>
              
                 <li> 
                <asp:Label ID="lblPassword" runat="server" style="z-index: 1; " Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; " TextMode="Password"></asp:TextBox>
                </li>
                    
                 <li> 
                 <asp:Label ID="lblPasswordConfirm" runat="server" style="z-index: 1;" Text="Password Confirm"></asp:Label>
                 <asp:TextBox ID="txtPasswordConfirm" runat="server" style="z-index: 1;" TextMode="Password"></asp:TextBox>
                 </li>
                 <li>
                <asp:Label ID="lblSecret" runat="server" style="z-index: 1; " Text="Secret"></asp:Label>
                 <asp:TextBox ID="txtSecret" runat="server" style="z-index: 1 "></asp:TextBox>
                </li>
                <li>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>
                           
                 
                           
                    </li>
                    <li>            
                           <asp:Button ID="btnSignUp" CssClass="navButton" runat="server" OnClick="btnSignUp_Click" style="z-index: 1;" Text="Sign Up" Height="46px" />
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
