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
            <asp:Label ID="Label2" runat="server" Text="CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Accept" runat="server" Text="Accept" OnClick="Accept_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="All Non Accepted Courses"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
            &nbsp;<asp:Label ID="Label5" runat="server" Text="Credit Hours"></asp:Label>
&nbsp;<asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
&nbsp;<asp:Label ID="Label7" runat="server" Text="Content"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
