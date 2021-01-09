<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GUCera.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Homepage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Admin Homepage"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="allcourses" Text="All Courses" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="nonaccepted" Text="Non-Accepted Courses" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Create Promocode" OnClick="promos" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Issue Promocode" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Add Mobile Number" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
