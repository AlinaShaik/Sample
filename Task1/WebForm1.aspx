﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task1.WebForm1" %>

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
        <div align="center" style="color:aqua;font-size:30px;">

            Employee Basic Details</div>
        <table align="center">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>DOB</td>
                <td>
                    <asp:TextBox ID="txtDOB" runat="server" type="date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Skills</td>
                <td>
                    <asp:TextBox ID="txtSkills" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Role</td>
                <td>
                    <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Salary</td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>

                <tr>
              
                <td colspan="2" align="center">
                    <asp:button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"></asp:button>
                
                </td>
            </tr>
        </table>
        <div>
         <asp:GridView ID="gv1" runat="server" AutoGenerateDeleteButton="true" AutoGenerateEditButton="true" OnRowDeleting="gv1_RowDeleting"></asp:GridView>
   
        </div>
 </form>
</body>
</html>
