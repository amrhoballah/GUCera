<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Home<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View My Profile" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="View All Available Course" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Add Credit Card" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="View Promocodes" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Add Mobile Number" OnClick="Button6_Click" />
        </div>
    </form>
</body>
</html>
