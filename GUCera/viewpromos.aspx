﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewpromos.aspx.cs" Inherits="GUCera.viewpromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Promocodes</title>
    <style type="text/css">
        td,th
        {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My Promocodes
            <br />
            <br />
            <asp:Table ID="Table1" runat="server" >
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Code
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Issue Date
                    </asp:TableHeaderCell>
                     <asp:TableHeaderCell>
                        Expriy Date
                    </asp:TableHeaderCell>
                     <asp:TableHeaderCell>
                        Discount
                    </asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>
        </div>
    </form>
</body>
</html>
