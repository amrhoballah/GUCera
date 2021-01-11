<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>viewpromos</title>
	<script runat="server">
	
	</script>
    <style type="text/css">
        td,th
        {
            border: 1px solid black;
        }
    </style>
</head>
<body>
	<form id="form1" runat="server">
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

	</form>
</body>
</html>
