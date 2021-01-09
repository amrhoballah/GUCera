<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="GUCera.ViewFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View Course Feedback<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="cid" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewf" runat="server" Text="View" OnClick="viewf_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
