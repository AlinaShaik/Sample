<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="UploadFile.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>

            <table  align="center">
              <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Image</td>
                    <td>
                        <asp:FileUpload ID="fupUpload" runat="server" Width="270px" />&nbsp
                         <asp:Label ID="lblmsg" runat="server" ></asp:Label>
                </td>
                </tr>
                <tr>
                    
                    <td colspan="2" align="center">
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />&nbsp
                    <asp:Label ID="lblmsg1" runat="server" ></asp:Label>
               </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
