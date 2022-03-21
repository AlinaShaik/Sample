using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Task1
{
    public partial  class Navigation : System.Web.UI.Page
    {
        string cs1 = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RefreshData();
            }

        }

        public void RefreshData()
        {
            try
            {
                using (SqlConnection scon = new SqlConnection(cs1))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfoBasic_1 ", scon))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        gd.DataSource = ds;
                        gd.DataBind();
                    }
                }
            }
            catch(Exception e)
            {
                Response.Write(e.Message);
            }
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {

            Response.Redirect("InsertingBasicDetails.aspx");
        }

        protected void gd_DeleteCommand(object source, DataGridCommandEventArgs e)
        {



        }

        protected void gd_EditCommand(object source, DataGridCommandEventArgs e)
        {
         

        }

        protected void gd_CancelCommand(object source, DataGridCommandEventArgs e)
        {

            gd.EditItemIndex = -1;
            RefreshData();
        }
    }
}