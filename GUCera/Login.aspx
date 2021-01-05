<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera Log In Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your credentials<br />
            <br />
            Username:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="loginbutton" runat="server" OnClick="login" Text="Log In" />
            <br />
            <br />
            <asp:Button ID="studentregister" runat="server" OnClick="Studentregister" Text="Student Register" />
&nbsp;&nbsp;
            <asp:Button ID="instructorregister" runat="server" OnClick="Instructorregister" Text="Instructor Register" />
        </div>
    </form>
</body>
</html>
