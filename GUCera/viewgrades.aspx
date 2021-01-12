<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewgrades.aspx.cs" Inherits="GUCera.viewgrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        td,th
        {
            border: 1px solid black;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Assignment Grade<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="course" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Number<br />
            <asp:TextBox ID="number" runat="server" required="required" ></asp:TextBox>
            <br />
            <br />
            Assignment Type<br />
            <asp:DropDownList ID="type" runat="server" required="required">
                <asp:ListItem>Project</asp:ListItem>
                <asp:ListItem>Quiz</asp:ListItem>
                <asp:ListItem>Exam</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View Grade" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>
                        Grade
                    </asp:TableHeaderCell>
                </asp:TableRow>

            </asp:Table>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>
        </div>
    </form>
</body>
</html>
