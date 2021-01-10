<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="GUCera.ViewFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            View Course Feedback<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="cid" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewf" runat="server" Text="View" OnClick="viewf_Click" />
            <br />
            <br />
            Feedback Found
            <asp:Table ID="table2" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Number
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Comments
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Likes
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
