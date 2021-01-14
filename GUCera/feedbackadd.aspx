<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedbackadd.aspx.cs" Inherits="GUCera.feedbackadd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Feedack</title>
</head>
<body>
    <form id="form1" runat="server">
        Add Feedback<br />
        <br />
        Course ID<br />
        <asp:TextBox ID="course" runat="server" required="required"></asp:TextBox>
        <br />
        <br />
        Comment<br />
        <asp:TextBox ID="comm" runat="server" required="required" MaxLength="100"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>
    </form>
</body>
</html>
