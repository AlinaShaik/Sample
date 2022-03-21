<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleFileUpload.aspx.cs" Inherits="UploadFile.MultipleFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 290px;
        }
        .auto-style3 {
            text-align: center;
            width: 237px;
        }
        .auto-style4 {
            text-align: center;
            width: 232px;
        }
        .auto-style5 {
            text-align: center;
            width: 231px;
        }
        .auto-style6 {
            text-align: center;
            width: 261px;
        }
        .auto-style7 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            File Upload Multiple Images
        </div>
        <table align="center">
            <tr>
                <td>
                 UploadImage1
                </td>
                <td>
             <asp:FileUpload ID="fupFile1" runat="server" />
                    </td>
                </tr>
                        <tr>
                <td>
                 UploadImage2
                </td>
                <td>
             <asp:FileUpload ID="fupFile2" runat="server" />
                    </td>
                </tr>
                 <tr>
                <td>
                 UploadImage3
                </td>
                <td>
             <asp:FileUpload ID="fupFile3" runat="server" />
                    </td>
                  </tr>
                      <tr>
                <td>
                 UploadImage4
                </td>
                <td>
             <asp:FileUpload ID="fupFile4" runat="server" />
                    </td>
                </tr>
                     <tr>
                <td>
                 UploadImage5
                </td>
                <td>
             <asp:FileUpload ID="fupFile5" runat="server" />
                    </td>
                </tr>
            <tr>
               
                <td colspan="2" align="center">
                    <asp:Button ID="btnUpload" runat="server" Text="UploadAll" />
                </td>
                </tr>
        </table>
       
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Image ID="Image1" runat="server" Width="16px" />
                </td>
                <td class="auto-style3">
                    <asp:Image ID="Image2" runat="server" />
                </td>
                <td class="auto-style4">
                    <asp:Image ID="Image3" runat="server" />
                </td>
                <td class="auto-style6">
                    <asp:Image ID="Image4" runat="server" />
                </td>
                <td class="auto-style7">
                    <asp:Image ID="Image5" runat="server" />
                </td>
            </tr>
        </table>
       
    </form>
</body>
</html>
