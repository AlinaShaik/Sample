<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Integration.aspx.cs" Inherits="WebApiCurdTask.Integration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts / jquery - 3.4.1.min.js"></script>
    <script type="text/javascript">  
        function getStudents() {
            $.getJSON("api/Employee/GetAllDetails",
                function (data) {
                    $('#stud').empty(); // Clear table body.  

                    // Loop through the list of students.  
                    $.each(data, function (key, val) {
                        // Add a table row for the student.  
                        var row = '<tr><td>' + val.EmpName +
                            '</td><td>' + val.DateofBirth + '</td><td>' +
                            val.EmailId + '</td><td>' + val.Gender +
                            '</td><td>' + val.Address + '</td><td>' + val.pincode + '</td></tr>';
                        $("#stud").append(row);

                    });
                });
        }
        $(document).ready(getStudents);
    </script>  
 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Here is the Students Record</h2>  
            <table>  
                <thead>  
                    <tr>  
                        <th>EmpName</th>  
                        <th>DateofBirth</th>  
                        <th>EmailId</th>  
                        <th>Gender</th> 
                        <th>Address</th>
                        <th>pincode</th>
                    </tr>  
                </thead>  
                <tbody id="stud">  
                </tbody>  
            </table>  

        </div>
    </form>
</body>
</html>
