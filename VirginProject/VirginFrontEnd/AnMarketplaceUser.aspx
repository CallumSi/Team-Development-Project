<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnMarketplaceUser.aspx.cs" Inherits="VirginFrontEnd.AnMarketplaceUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
      <head id="Head1" runat="server">
        <title>Sample Master Page</title>
        <link href="VirginProject.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form2" runat="server">
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul class="row">
       
                      <li>
                          <asp:Label ID="Label2" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblOriginalID" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                            <asp:Label ID="Label1" runat="server" style="z-index: 1;" Text="Please Update your details"></asp:Label>
                       </li>
                  
               
                 </ul>
                               
                        
                    
                         <br />
                  <ul class="AnListing">
                    <li>
                         <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Email"></asp:Label>
                         <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; "></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Line One"></asp:Label>
              <asp:TextBox ID="txtDeliveryAdressLineOne" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                          <asp:Label ID="Label8" runat="server" style="z-index: 1;" Text="Line Two"></asp:Label>
                          <asp:TextBox ID="txtDeliveryAdressLineTwo" runat="server" style="z-index: 1;"></asp:TextBox>
                       
                    </li>

                    <li>
              
                        <asp:Label ID="Label9" runat="server" style="z-index: 1;" Text="PostCode"></asp:Label>
                         <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
              
                   <li>
                        
                         
                        <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>
                        <asp:Button ID="btnOk" CssClass="navButton" runat="server" style="z-index: 1;" Text="OK" OnClick="btnOk_Click" />
                        <asp:Button ID="btnCancel" CssClass="navButton" runat="server" style="z-index: 1;" Text="Cancel" OnClick="btnCancel_Click" />
                       
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
        <p>
            AllStaff</p>
    </body>
       
</html>


