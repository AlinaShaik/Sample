<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div  align="center">
            <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" DataKeyField="StudentId"  BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnUpdateCommand="DataGrid1_UpdateCommand">
                <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateColumn HeaderText="StudentId">
                    <EditItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StudentId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentId" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StudentId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtname" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblname" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Name") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Subjects">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSubject" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Subjects") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblSubject" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Subjects") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Marks">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMarks" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Marks") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMarks" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Marks") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="PhoneNumber">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNumber" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PhoneNumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNumber" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PhoneNumber") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="EmailId">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMailId" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MailId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMailId" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MailId") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateColumn>
                <asp:EditCommandColumn CancelText="Cancel" EditText="Edit"  UpdateText="Update">
                </asp:EditCommandColumn>
                <asp:ButtonColumn CommandName="Delete"  Text="Delete"></asp:ButtonColumn>
            </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            </asp:DataGrid><br />
      <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="79px" />
        </div>
    </form>
</body>
</html>
