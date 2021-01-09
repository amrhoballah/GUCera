<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminnonaccepted.aspx.cs" Inherits="GUCera.adminnonaccepted" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Accept Course Form"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="CourseID" required="required"></asp:Label>
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Accept" runat="server" Text="Accept" OnClick="Accept_Click" />
            <br />
            <br />

            <asp:Table ID="table2" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Course ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Name
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Credit Hours
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Price
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Content
                    </asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
            <br />
        </div>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

    </form>
</body>
</html>
