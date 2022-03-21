<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="Task1.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:GridView ID="gd1" runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCancelingEdit="gd1_RowCancelingEdit" OnRowDeleting="gd1_RowDeleting" OnRowEditing="gd1_RowEditing" OnRowUpdating="gd1_RowUpdating" DataKeyNames="StudentId" >
                 <Columns>
                <asp:TemplateField HeaderText="StudentId">
                    <EditItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%#Bind("StudentId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentId" runat="server" Text='<%#Bind("StudentId") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtname" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblname" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="Subjects">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSubjects" runat="server" Text='<%#Bind("Subjects") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblSubjects" runat="server" Text='<%#Bind("Subjects") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="Marks">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMarks" runat="server" Text='<%#Bind("Marks") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMarks" runat="server" Text='<%#Bind("Marks") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="PhoneNumber">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNumber" runat="server" Text='<%#Bind( "PhoneNumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNumber" runat="server" Text='<%#Bind("PhoneNumber") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="EmailId">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMailId" runat="server" Text='<%#Bind("MailId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMailId" runat="server" Text='<%#Bind("MailId") %>'></asp:Label>
                    </ItemTemplate>
             </asp:TemplateField>
                     <asp:TemplateField HeaderText="">
                         <ItemTemplate>
                             <asp:LinkButton ID="lb1" runat="server" CommandName="Edit" Text="Edit"></asp:LinkButton>
                             <asp:LinkButton ID="lb2" runat="server" CommandName="Delete" Text="Delete"></asp:LinkButton>
                         </ItemTemplate>
                         <EditItemTemplate>
                              <asp:LinkButton ID="lb3" runat="server" CommandName="Update" Text="Update"></asp:LinkButton>
                             <asp:LinkButton ID="lb4" runat="server" CommandName="Cancel" Text="Cancel"></asp:LinkButton>

                         </EditItemTemplate>
                     </asp:TemplateField>
                     

            </Columns>
                
                
                
                
                
                
                
                
                
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
                </center>
        </div>
    </form>
</body>
</html>
