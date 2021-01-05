<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sRegister.aspx.cs" Inherits="GUCera.sRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registeration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Please fill in all this info"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="fname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="lname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
        <br />
        <asp:ListBox ID="gender" runat="server">
            <asp:ListItem Value="0">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="add" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="register" runat="server" OnClick="register_Click" Text="Register" />
        <br />
    </form>
</body>
</html>
