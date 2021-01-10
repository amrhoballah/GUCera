<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignmentsInstructor.aspx.cs" Inherits="GUCera.ManageAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Assignments</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View Assignments Form<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="CourseID" ></asp:Label>
            <br />
            <asp:TextBox ID="courseid" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Accept" runat="server" Text="View" OnClick="Accept_Click" />
            <br />
            <br />
            All Assignments
            <asp:Table ID="table2" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Student-ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Course-ID
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Assignment-Number
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Assignment-Type
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Grade
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
