<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createpromos.aspx.cs" Inherits="GUCera.managepromos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Promocodes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Create Promocode"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Code"></asp:Label>
            <br />
            <asp:TextBox ID="promocode" runat="server" required="required" MaxLength="6"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Issue Date" ></asp:Label>
            <br />
            <asp:Calendar ID="issue" runat="server" BackColor="White" required="required" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
            <br />
            <asp:Label ID="Label4" runat="server" Text="Expiry Date" required="required"></asp:Label>
            <br />
            <asp:Calendar ID="expiry" runat="server" BackColor="White" BorderColor="#999999" required="required" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
            <br />
            <asp:Label ID="Label5" runat="server" Text="Discount" required="required"></asp:Label>
            <br />
            <asp:TextBox ID="discount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />
            <br />
            <br />
        </div>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Homepage</asp:LinkButton>

    </form>
</body>
</html>
