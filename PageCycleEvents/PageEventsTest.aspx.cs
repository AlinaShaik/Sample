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
    public partial class PageEventsTest : System.Web.UI.Page
    {
        void Page_Load(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;user id=sa;password=Bhavna@123;");
            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo_Tab1", scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gv1.DataSource = dt;
            gv1.DataBind();

          
           

        }
        protected void page_PreInit(object sender,EventArgs e)
        {

        }
        
        protected override void OnInit(EventArgs e)
        {
           

            
            Response.Write("Init Called </br>");
            base.OnInit(e);
        }
        protected override void OnPreInit(EventArgs e)
        {
           

            Response.Write("PreInit Called </br>");
            base.OnPreInit(e);
        }
        protected override void OnInitComplete(EventArgs e)
        {
            Response.Write("OnInitComplete Called </br>");
            base.OnInitComplete(e);
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("OnPreload Called </br>");
            base.OnPreLoad(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            Response.Write("OnLoad Called </br>");

            base.OnLoad(e);
        }
        protected override void OnLoadComplete(EventArgs e)
        {
            Response.Write("OnLoadComplete Called </br>");
            base.OnLoadComplete(e);
        }
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("OnPreRender Called </br>");
            base.OnPreRender(e);
        }
        
        protected override void OnUnload(EventArgs e)
        {
            //Response.Write("OnUnLoad Called,</br>");

            base.OnUnload(e);
        }
        protected override void OnPreRenderComplete(EventArgs e)
        {
            Response.Write("OnPreRenderComplete </br>");
            base.OnPreRenderComplete(e);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Clicked this Button </br> ");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
