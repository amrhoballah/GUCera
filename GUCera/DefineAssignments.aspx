<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefineAssignments.aspx.cs" Inherits="GUCera.DefineAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        Define Assignment<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="cid" runat="server" required="required" ></asp:TextBox>
            <br />
            <br />
            Number<br />
            <asp:TextBox ID="number" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Type<br />
            <asp:DropDownList ID="type1" runat="server">
                <asp:ListItem>Project</asp:ListItem>
                <asp:ListItem>Quiz</asp:ListItem>
                <asp:ListItem>Exam</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Content<br />
            <asp:TextBox ID="content" runat="server" required="required" MaxLength="200"></asp:TextBox>
            <br />
            <br />
            Weight<br />
            <asp:TextBox ID="weight" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Full Grade<br />
            <asp:TextBox ID="full" runat="server" required="required"></asp:TextBox>
            <br />
            <br />
            Deadline<asp:Calendar ID="deadline" runat="server" required="required" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            <asp:Button ID="defass" runat="server" Text="Define" OnClick="defass_Click" />

                                            <br />
            <br />

                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

        </div>
    </form>
</body>
</html>
