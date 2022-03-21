using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class Employee1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> emplist = new List<Employee>()
            {

               
             new Employee(){Eid=1,Ename="Seema",Age=25,Salary=16000,designination="Manager"},
               new Employee(){Eid=2,Ename="Sanju",Age=27,Salary=18000,designination="Executive"},
                 new Employee(){Eid=3,Ename="Ravi",Age=28,Salary=25000,designination="Tester"},
               new Employee(){Eid=4,Ename="Goutham",Age=29,Salary=29000,designination="Developer"}

            };

            datagrid.DataSource = emplist;
            datagrid.DataBind();
            
            
        }
    }
}