<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HitCount.aspx.cs" Inherits="UploadFile.HitCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCount" runat="server" Text="HitCount" OnClick="btnCount_Click"/>
            <asp:Label ID="lblCount" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
