<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerySring.aspx.cs" Inherits="UploadFile.QuerySring" %>

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
                  <td>FristName</td>
                  <td>
                      <asp:Textbox ID="txtFrist" runat="server"></asp:Textbox>
                  </td>
                  </tr>
              <tr>
                  <td>LastName</td>
                  <td>
                      <asp:Textbox ID="txtLast" runat="server"></asp:Textbox>
                   </td>
              </tr>
              <tr>
                  <td colspan="2" align="center">
                      <asp:Button ID="btnSubmit" runat="server"  Text="Submit" OnClick="btnSubmit_Click"/>
                  </td>
              </tr>
          </table>
        </div>
    </form>
</body>
</html>
