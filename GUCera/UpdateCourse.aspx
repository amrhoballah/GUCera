<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCourse.aspx.cs" Inherits="GUCera.UpdateCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Course</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update Course<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="course" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Content<br />
            <asp:TextBox ID="con" runat="server"></asp:TextBox>
            <br />
            <br />
            Description<br />
            <asp:TextBox ID="des" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                                            <br />
            <br />
                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

        </div>
    </form>
</body>
</html>
