<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalAdd.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalAdd" %>

<!DOCTYPE html>
    <html>
        <%--HEAD SECTION--%>
        <head id="Head1" runat="server">
            <meta charset="utf-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <title>Virgin Healthcare</title>
            <link href="VHCHospital.css" rel="stylesheet" type="text/css" />
            <style type="text/css">
                .lblHospital_Name {
                    position: absolute;
                    top: 176px;
                    left: 192px;
                    z-index: 1;
                }
                .lblHospital_Place {
                    position: absolute;
                    top: 218px;
                    left: 193px;
                    z-index: 1;
                }
            </style>
        </head>

        <%--BODY SECTION--%>
        <body>
            <form id="form1" runat="server">
                <%--HEADER SECTION--%>
                <header>
                    <h2>Virgin Healthcare: Hospital</h2>
                </header>
                <%--ARTICLE SECTION--%>
                <article>
                    <h4> ADD HOSPITAL SECTION </h4>
                    <asp:Label ID="lblHospital_Name" runat="server" CssClass="lblHospital_Name" Text="Hospital Name: "></asp:Label>
                    <asp:Label ID="lblHospital_Place" runat="server" CssClass="lblHospital_Place" Text="Hospital Place: "></asp:Label>
                </article>
                <%--NAVIGATION SECTION--%>
                <nav>
                    <asp:Button ID="Home_Button" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Click"/>
                </nav>
                <%--FOOTER SECTION--%>
                <footer>
                    <div id="FooterText"> © 2021 Virgin Media | All Rights Reserved </div>
                </footer>
            </form>
        </body>
    </html>