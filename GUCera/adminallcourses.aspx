<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminallcourses.aspx.cs" Inherits="GUCera.adminallcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Courses</title>
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
            All Courses<br />
&nbsp;<asp:Table ID="table2" runat="server" >
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
                    <asp:TableHeaderCell>
                        Accepted
                    </asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
            <br />
        </div>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

    </form>
</body>
</html>
