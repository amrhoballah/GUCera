<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="GUCera.InstructorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label ID="Label1" runat="server" Text="Instructor Home Page"></asp:Label>
            <br />
            <br />
        <asp:Button ID="addcourse" runat="server" Text="Add Course" OnClick="addcourse_Click" />
        <br />
        <br />
        <asp:Button ID="defineass" runat="server" Text="Define Assignments" OnClick="defineass_Click" />
        <br />
        <br />
        <asp:Button ID="manageass" runat="server" Text="Manage Assignments" OnClick="manageass_Click" />
        <br />
        <br />
        <asp:Button ID="viewfeed" runat="server" Text="View Feedback" OnClick="viewfeed_Click" />
        <br />
        <br />
        <asp:Button ID="issuecert" runat="server" Text="Issue Certificate" OnClick="issuecert_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Mobile Number" OnClick="Button1_Click" />
            </div>
    </form>
   </body>
</html>
