<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAssignments.aspx.cs" Inherits="GUCera.GradeAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Grade Assignments<br />
            <br />
            Student ID<br />
            <asp:TextBox ID="student" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Course ID<br />
            <asp:TextBox ID="course" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Number<br />
            <asp:TextBox ID="number" runat="server" required="required" ></asp:TextBox>
            <br />
            <br />
            Assignment Type<br />
            <asp:DropDownList ID="type" runat="server" required="required">
                <asp:ListItem>Project</asp:ListItem>
                <asp:ListItem>Quiz</asp:ListItem>
                <asp:ListItem>Exam</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Grade<br />
            <asp:TextBox ID="grade" runat="server" required="required"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Grade" OnClick="Button1_Click" />

            <br />
            <br />
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

        </div>
    </form>
</body>
</html>


