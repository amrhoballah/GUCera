<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentprofile.aspx.cs" Inherits="GUCera.studentprofile" %>

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
            Profile Details<br />
            <br />
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        First Name
                    </asp:TableHeaderCell>
                     <asp:TableHeaderCell>
                         Last Name
                     </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Password
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Gender
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Email
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Address
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        GPA
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
