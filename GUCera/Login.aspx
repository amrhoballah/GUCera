<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your credentials<br />
            <br />
            Username:<br />
            <asp:TextBox ID="username" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server" TextMode="Password" MaxLength="20" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="loginbutton" runat="server" OnClick="login" Text="Log In" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Student Register</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Instructor Register</asp:LinkButton>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
