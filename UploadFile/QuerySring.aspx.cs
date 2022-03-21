using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadFile
{
    public partial class QuerySring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

          
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuerySring.aspx?firstname=" + txtFrist.Text + "&lastname=" + txtLast.Text);
        }
    }
   
}
