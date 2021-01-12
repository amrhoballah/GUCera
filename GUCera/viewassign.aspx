<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewassign.aspx.cs" Inherits="GUCera.viewassign" %>

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
            View Assignments<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="courseid" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Course ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Number
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Type
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Full Grade
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Weight
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Deadline
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Content
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
