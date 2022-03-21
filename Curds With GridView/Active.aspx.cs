using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Curds_With_GridView
{
    public partial class Active : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RefreshData();
            }

        }
        protected void RefreshData()
        {
            SqlConnection scon = new SqlConnection();
            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Active_Tab",scon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            scon.Close();
            
        }
    }
}
