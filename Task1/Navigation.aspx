<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation.aspx.cs" Inherits="Task1.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:DataGrid ID="gd" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" UpdateText="Update"></asp:EditCommandColumn>
                    <asp:ButtonColumn CommandName="Delete" Text="Delete"></asp:ButtonColumn>
                    <asp:BoundColumn DataFormatString="Eval(&quot;StudentId&quot;)" HeaderText="StudentId"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Eval(&quot;Name&quot;)" HeaderText="Name"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Eval(&quot;Subjects&quot;)" HeaderText="Subjects"></asp:BoundColumn>
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            </asp:DataGrid>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" SelectCommand="SELECT * FROM [StudentInfoBasic_1]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="btninsert" runat="server" Text="insert"  OnClick="btninsert_Click"/>
        </div>
    </form>
</body>
</html>
