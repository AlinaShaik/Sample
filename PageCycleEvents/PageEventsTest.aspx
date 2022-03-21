<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEventsTest.aspx.cs" Inherits="PageCycleEvents.PageEventsTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv1" runat="server"></asp:GridView>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
