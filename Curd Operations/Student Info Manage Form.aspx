<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Info Manage Form.aspx.cs" Inherits="Curd_Operations.Student_Info_Manage_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <div style="font-size:xx-large;color:aquamarine;font-weight:bold;" align="center">
         Student Info Manage Form
        </div>
    <form id="form1" runat="server">
        
        <div>

            <table align="center">
                <tr>
                    <td>Student ID</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" ></asp:TextBox>
                        <asp:Button ID="Button6" runat="server" Text="Search" CssClass="auto-style1" Width="61px" OnClick="Button6_Click" />
                    </td>
                </tr>
                <tr>
                    <td>StudentName</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:DropDownList ID="ddlAddress" runat="server">
                            <asp:ListItem>Selected Value</asp:ListItem>
                            <asp:ListItem>Andhrapradesh</asp:ListItem>
                            <asp:ListItem>Chennai</asp:ListItem>
                            <asp:ListItem>Bengaluru</asp:ListItem>
                            <asp:ListItem>Kurnool</asp:ListItem>
                            <asp:ListItem>Kerala</asp:ListItem>
                            <asp:ListItem>Telangana</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contact</td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
&nbsp;&nbsp;&nbsp;<asp:Button ID="btnInsert" runat="server" Text="Insert" Width="69px" OnClick="Button1_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Delete" Width="58px" OnClick="Button3_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnView" runat="server" Text="View" CssClass="auto-style1" Width="61px" OnClick="Button4_Click" />
                        &nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button5" runat="server" Text="Search" CssClass="auto-style1" Width="61px" OnClick="Button5_Click" />
                        &nbsp;&nbsp; </td>
                </tr>
            </table>

        </div>
        <asp:GridView ID="GridView1" runat="server" >
            
           
        </asp:GridView>

        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="StudentId" Height="182px" OnRowCancelingEdit="gv1_RowCancelingEdit" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowUpdating="gv1_RowUpdating" ShowFooter="True" Width="489px" >
            <Columns>
                
                <asp:TemplateField HeaderText="StudentId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("StudentId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="true"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("StudentId") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StudentName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("StudentName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("StudentName") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("Address") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StudentAge">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("StudentAge") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("StudentAge") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Contact">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Contact") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Contact") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Operations">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton3" runat="server">Edit</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbDelete" runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                            &nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete">Update</asp:LinkButton>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btnInsert"  runat="server" Text="Insert" Width="100px"></asp:Button>
                            </FooterTemplate>
                   

                            <ItemStyle HorizontalAlign="Center" />

                            </asp:TemplateField>
                                    
                            
                    
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>

</body>
</html>
