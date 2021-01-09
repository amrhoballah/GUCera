<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mobileadd.aspx.cs" Inherits="GUCera.mobileadd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Mobile Number</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Mobile Number<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mobile Number"></asp:Label>
            <br />
            <asp:TextBox ID="number" runat="server" required="required" MaxLength="11" MinLength="11"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <br />
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>
    </form>
</body>
</html>
