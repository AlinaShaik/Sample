<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertingBasicDetails.aspx.cs" Inherits="Task1.InsertingBasicDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage=" Name Field Can't be Empty" ControlToValidate="txtName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Subjects</td>
                <td>
                    <asp:TextBox ID="txtSubjects" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSubjects" runat="server" ErrorMessage="Subjects Can't Empty Field" ControlToValidate="txtSubjects" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Marks</td>
                <td>
                    <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvMarks" runat="server" ErrorMessage="Marks Field Can't be Empty" ControlToValidate="txtMarks" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>MailId</td>
                <td>
                    <asp:TextBox ID="txtMailId" runat="server"></asp:TextBox>
                </td>

            </tr>
                <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
                    </tr>
           <%-- <tr>
                <td colspan="2" align="center">
                 <asp:Label ID="lblMsg" runat="server" OnDataBinding="Page_Load"></asp:Label>
                </td>
            </tr>--%>
        </table>

              
        </div>
    </form>
</body>
</html>
