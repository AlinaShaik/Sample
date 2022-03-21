<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Active.aspx.cs" Inherits="Curds_With_GridView.Active" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >

            <table  align="center">
                <tr>
                    <td>Tittle</td>
                    <td>
                        <asp:TextBox ID="txtTittle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Descriptions</td>
                    <td>
                        <textarea id="taDescriptions" cols="20" name="S1" rows="2"></textarea></td>
                </tr>
                <tr>
                    <td>Edited</td>
                    <td>
                        <asp:CheckBox ID="chEdited" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSave" runat="server" Text="Save" />&nbsp&nbsp
                        <asp:Button ID="btnClear" runat="server" Text="Clear" />
                    </td>
                </tr>

            </table>

        </div>
            <asp:GridView ID="gv" runat="server">
         </asp:GridView>
    </form>
</body>
</html>
