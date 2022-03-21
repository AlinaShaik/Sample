using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Strings1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> str = new List<string>()
            {
                "string1",
                "string2",
                "string2",
                "string3"
            };
            
            foreach(string s in str)
            {
                
                Response.Write("<li>" + s + "</li>");
                
            }
            
        }
    }
}