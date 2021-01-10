<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="availablecourses.aspx.cs" Inherits="GUCera.availablecourses" %>

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
            Available Course<br />
            <br />
            <asp:Table ID="Table1" runat="server" >
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Course-ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Name
                    </asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            Course ID<br />
            <asp:TextBox ID="cid" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enroll" OnClick="Button1_Click" />
            <br />
            <br />
                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

        </div>
    </form>
</body>
</html>
