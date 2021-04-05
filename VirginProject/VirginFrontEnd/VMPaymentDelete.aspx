<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMPaymentDelete.aspx.cs" Inherits="VirginFrontEnd.VMPaymentDelete" %>
<!DOCTYPE html>
<html>
<head>
	<title></title>
	<link href="VirginProject.css" rel="stylesheet">
</head>
<body>
	<form id="form1" runat="server">
		<header>
			<h2>Virgin Media</h2>
		</header>
		<article>
			<ul>
				<li>
                   
				<li></li>
			</ul><br>
			<ul>
				<li><asp:Label ID="lblPaymentDelete" runat="server" Text="ARE YOU SURE YOU WANT TO DELETE THIS PAYMENT?" style="z-index: 1; left: 500px; top: 108px; position: absolute; width: 515px; text-align: center;" BorderStyle="None" Font-Bold="True" ForeColor="Red"></asp:Label></li>
				<li></li>
				<li><asp:Button ID="btnYes" runat ="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 271px; top: 137px; position: absolute; width: 111px" Text="YES" OnClick="btnYes_Click" /> 
                    <asp:Button ID="btnNo" runat ="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 471px; top: 137px; position: absolute; width: 111px" Text="NO"/>

				</li>
                </ul>
		</article>
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


