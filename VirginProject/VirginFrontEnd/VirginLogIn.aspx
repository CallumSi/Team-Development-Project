<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginLogIn.aspx.cs" Inherits="VirginFrontEnd.VirginLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VirginLogIn</title>
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
                    <asp:Label ID="lblUserName" runat="server" style="z-index: 1;" Text="User Name"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 130px; top: 0px; position: absolute"></asp:TextBox>
               </li>
              
                 <li> 
                     <asp:Label ID="lblPassword" runat="server" style="z-index: 1;" Text="Password"></asp:Label>
                     <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1;" TextMode="Password"></asp:TextBox>
                </li>
                      
                 <li> 
                     <asp:Button ID="btnLogIn" runat="server" style="z-index: 1;" Text="Log In" OnClick="btnLogIn_Click" />
                 </li>

                 <li>
                      <asp:Button ID="btnSignUp" runat="server" style="z-index: 1;" Text="Sign Up" OnClick="btnSignUp_Click1" />
                </li>
                <li>
                   
                     <asp:Button ID="btnForgotPassword" runat="server" style="z-index: 1;" Text="Forgot Password" OnClick="btnForgotPassword_Click" />

               </li>
                    <li>                
                           
                <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>

                    </li>
                </ul>
            </article>
 
            <nav>
                Navigation links here
                 <asp:Button ID="btnForumAdmin" runat="server" OnClick="btnForumAdmin_Click" style="z-index: 1; left: 12px; top: 211px; position: absolute" Text="Forum Admin" />
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
            
             
        </form>
    </body>
</html>
