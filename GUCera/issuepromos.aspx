<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issuepromos.aspx.cs" Inherits="GUCera.issuepromos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label6" runat="server" Text="Issue Promocode"></asp:Label>

            <br />

            <br />
            <asp:Label ID="Label7" runat="server" Text="Student ID"></asp:Label>
            <br />
            <asp:TextBox ID="username" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Promocode"></asp:Label>
            <br />
            <asp:TextBox ID="issuedpromo" runat="server" required="required" MaxLength="6"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Issuep" runat="server" Text="Issue" OnClick="Issuep_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="All Students"></asp:Label>

            <br />
            <asp:Table ID="table2" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Student ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        First Name
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Last Name                    
                    </asp:TableHeaderCell>
                    
                </asp:TableRow>
            </asp:Table>
            <br />
        </div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

    </form>
</body>
</html>
