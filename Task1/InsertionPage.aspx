<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertionPage.aspx.cs" Inherits="Task1.InsertionPage" %>

<!DOCTYPE html

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <script type="text/javascript">

        function Validate() {

         
            var Name = document.getElementById('<%=txtName.ClientID%>').value;


            

            if (Name.value == null || Name.value == '') {

                document.getElementById('spanname').innerHTML = "** Please Enter Your Name";
                document.getElementById('spanname').style.color = 'red';
                document.getElementById('spanname').style.display = 'inline-flex';
                //document.getElementById('<%=txtName.ClientID%>').style.color = 'red';
                document.getElementById('<%=txtName.ClientID%>').focus();
                return false;
            }
            else if (Name.value != "") {
                document.getElementById('spanname').style.display = 'none';
               document.getElementById('spanname').innerHTML = "";
                return true;
               // document.getElementById('<%=txtName.ClientID%>').style.border = 'green';
            }

           

       
    
            return true;
          

        


          


        }
      




   </script>
   <%-- <style type="text/css">
        label.error {
            color: red;
            display: inline-flex;
        }
    </style>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/additional-methods.min.js"></script>
    <script>  

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    //This section we need to place our custom rule for the control.  
                      <%=txtName.UniqueID %>:{
                required: true
            },
                 <%=txtSubjects.UniqueID %>: {
                    required: true
                },
                  <%=txtMarks.UniqueID %>: {
                    required: true
                },
                   <%=txtPhoneNumber.UniqueID %>: {
                    required: true
                },
                    <%=txtMailId.UniqueID %>: {
                    required: true
                },
                  
                },
                messages: {
                    //This section we need to place our custom validation message for each control.  
                     <%=txtName.UniqueID %>:{
            required: "Name is required."
        },
                <%=txtSubjects.UniqueID %>: {
                required: "Subject is required."
            },
                <%=txtMarks.UniqueID %>: {
                required: "Marks is required."
            },
                    <%=txtPhoneNumber.UniqueID %>:{
            required: "PhoneNumber is required."
        },
                <%=txtMailId.UniqueID %>: {
                required: "MailId is required."
            },
           

                },
            });
        });
       </script>

   --%>   


    

</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <table align="center">
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    
                   
                       <span id="spanname"></span>
                          </td> 
             

                    <%--<td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage=" Name Field Can't be Empty" ControlToValidate="txtName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>--%>
                </tr>
                <tr>
                    <td>Subjects</td>
                    <td>
                        <asp:TextBox ID="txtSubjects" runat="server"></asp:TextBox>
                    </td>

                    <%-- <td>
                    <asp:RequiredFieldValidator ID="rfvSubjects" runat="server" ErrorMessage="Subjects Can't Empty Field" ControlToValidate="txtSubjects" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>--%>
                </tr>
                <tr>
                    <td>Marks</td>
                    <td>
                        <asp:TextBox ID="txtMarks" runat="server" TextMode="Number"></asp:TextBox>
                    </td>

                    <%--<td>
                    <asp:RequiredFieldValidator ID="rfvMarks" runat="server" ErrorMessage="Marks Field Can't be Empty" ControlToValidate="txtMarks" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>--%>
                </tr>
                <tr>
                    <td>Phone Number</td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server" TextMode="Phone"></asp:TextBox>

                    </td>

                    <%-- <td>
                <asp:RegularExpressionValidator ID="revPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="Phone Number not valid" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                </td>--%>
                </tr>
                <tr>
                    <td>MailId</td>
                    <td>
                        <asp:TextBox ID="txtMailId" runat="server" TextMode="Email"></asp:TextBox>
                    </td>

                    <%-- <td>
                    <asp:RegularExpressionValidator ID="revMailId" runat="server" ControlToValidate="txtMailId" Display="Dynamic" ErrorMessage="MailId is not CorrectFormat" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                    --%>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                         <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  OnClientClick=" return Validate();"/>
                        <%--<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />--%>
                    </td>
                </tr>

            </table>

        </div>
    </form>
</body>
</html>
