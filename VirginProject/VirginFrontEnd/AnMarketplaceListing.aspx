<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnMarketplaceListing.aspx.cs" Inherits="VirginFrontEnd.AnMarketplaceListing" %>

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
                <ul>
       
                      <li>
                          <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>
                       </li>
                       <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                           <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                           <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" />
                       </li>
               
                 </ul>
                               
                        <asp:Label ID="lblListingType" runat="server" style="z-index: 1;"></asp:Label>               
                    
                         <br />
                  <ul class="AnListing">
                    <li>
                         <asp:Label ID="Label2" runat="server" style="z-index: 1;" Text="Listing Name"></asp:Label>
                        <asp:TextBox ID="txtListingName" runat="server" style="z-index: 1; "></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Img Path"></asp:Label>
                        <asp:TextBox ID="txtImg" runat="server" style="z-index: 1; height: 21px"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label6" runat="server" style="z-index: 1;" Text="Delivery Type"></asp:Label>
                        
                         <asp:TextBox ID="txtDeliveryType" runat="server" style="z-index: 1; "></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label9" runat="server" style="z-index: 1;" Text="Price"></asp:Label>
                        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label8" runat="server" style="z-index: 1;" Text="Quantity"></asp:Label>
                        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1;"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="Label5" runat="server" style="z-index: 1; " Text="Category"></asp:Label>
                         <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; "></asp:TextBox>
                         
                    </li>
                    <li>
                        <asp:Label ID="Label4" runat="server" style="z-index: 1;" Text="Description"></asp:Label>
                        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1;"></asp:TextBox>
                         
                        
                    </li>
                    <li>
                        
                       <asp:Label ID="Label10" runat="server" style="z-index: 1;" Text="New?"></asp:Label>
                       <asp:CheckBox ID="chkboxNew" runat="server" style="z-index: 1;" />
                    </li>
                   <li>
                        
                        <asp:Button ID="btnOk" CssClass="navButton" runat="server" style="z-index: 1; " Text="Ok" OnClick="btnOk_Click" />
                        <asp:Button ID="btnCancel" CssClass="navButton" runat="server" style="z-index: 1; " Text="Cancel" OnClick="btnCancel_Click" />
                       <asp:Label ID="lblError"  runat="server" style="z-index: 1;"></asp:Label>
                       
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
