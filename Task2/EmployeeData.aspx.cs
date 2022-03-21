using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Task2
{
    public partial class EmployeeData : System.Web.UI.Page
    {
        string cs=ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        protected void Page_Load(object sender,EventArgs e)
        {
            using(SqlConnection cn=new SqlConnection(cs))
            {
                cn.Open();
                SqlDataAdapter cd = new SqlDataAdapter("select * from Employee_1", cn);
                DataSet ds = new DataSet();
                cd.Fill(ds);
                gv1.DataSource = ds;
                gv1.DataBind();

            }

        }
    }
}