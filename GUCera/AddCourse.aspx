﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="GUCera.AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Course<br />
            <br />
            Name<br />
            <asp:TextBox ID="name" runat="server" required="required" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Credit Hours<br />
            <asp:TextBox ID="credit" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Price<br />
            <asp:TextBox ID="price" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addc" runat="server" Text="Add" OnClick="addc_Click" />
        </div>
    </form>
</body>
</html>