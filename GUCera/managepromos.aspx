<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="managepromos.aspx.cs" Inherits="GUCera.managepromos" %>

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
            <asp:TextBox ID="promocode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Issue Date"></asp:Label>
            <br />
            <asp:Calendar ID="issue" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
            <asp:Label ID="Label4" runat="server" Text="Expiry Date"></asp:Label>
            <br />
            <asp:Calendar ID="expiry" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
            <asp:Label ID="Label5" runat="server" Text="Discount"></asp:Label>
            <br />
            <asp:TextBox ID="discount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />
            <br />
            <br />

            <asp:Label ID="Label6" runat="server" Text="Issue Promocode"></asp:Label>

            <br />

            <br />
            <asp:Label ID="Label7" runat="server" Text="Student ID"></asp:Label>
            <br />
            <asp:TextBox ID="username" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Promocode"></asp:Label>
            <br />
            <asp:TextBox ID="issuedpromo" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Issuep" runat="server" Text="Issue" OnClick="Issuep_Click" />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="All Students"></asp:Label>

            <br />

            <br />
        </div>
    </form>
</body>
</html>
