using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PageCycleEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;user id=sa;password=Bhavna@123;");
            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo_Tab1", scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gv2.DataSource = dt;
            gv2.DataBind();

        }
    }
}