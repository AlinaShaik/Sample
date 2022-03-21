using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadFile
{
    public partial class HitCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count;
            if (ViewState["count"] == null)
            {
                count = 0;
            }

            else
            {
                count = ((int)ViewState["count"]) + 1;
            }
                ViewState["count"] = count;
                //Response.Write("hit count:" + count);
            

        }

        protected void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text=ViewState["count"].ToString();

        }
    }
}