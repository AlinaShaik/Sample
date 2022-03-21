﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentBasicDetails.aspx.cs" Inherits="Task1.StudentBasicDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
   <form id="form1" runat="server">
        <div style="color:navy; text-align:center; font-size:30px;">
            Student BasicInfo Details</div>
        <table align="center">
            <tr>
                <td>StudentId</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                </tr>
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
                <td>
                   <asp:RegularExpressionValidator ID="revPhoneNumber" runat="server" ErrorMessage="PhoneNumber should be Correct Format" ControlToValidate="txtPhoneNumber" Display="Dynamic" ForeColor="Red"  ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
              </td>
            </tr>
            <tr>
                <td>MailId</td>
                <td>
                    <asp:TextBox ID="txtMailId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="revEmailid" runat="server" ErrorMessage="EmailId is Correct Format" ControlToValidate="txtMailId" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" Width="73px" OnClick="btnInsert_Click"/>
                    
               
                                 </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                 <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <asp:ValidationSummary ID="vsErrors" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
          
        <asp:GridView ID="gv1" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" OnRowCancelingEdit="gv1_RowCancelingEdit" OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" OnRowUpdating="gv1_RowUpdating"></asp:GridView>
    
    </form>
    </body>
    </html>
    




