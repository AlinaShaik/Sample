using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Task1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable dbl = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                LoadData();
            }
        }

       public void LoadData()
        {

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Name");
            DataColumn dc2 = new DataColumn("DOB");
            DataColumn dc3 = new DataColumn("Skills");
            DataColumn dc4 = new DataColumn("Address");
            DataColumn dc5 = new DataColumn("Role");
            DataColumn dc6 = new DataColumn("Salary");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            DataRow dr1 = dt.NewRow();
            ViewState["Data"] = dt;
            gv1.DataSource =(DataTable) ViewState["Data"];
            gv1.DataBind();






        }

         
        protected void btnCreate_Click(object sender, EventArgs e)
        {

            DataTable dt =  (DataTable) ViewState["Data"];  
               dt.Rows.Add(txtName.Text.Trim(),txtDOB.Text,txtSkills.Text.Trim(),txtAddress.Text.Trim(),txtRole.Text.Trim(),txtSalary.Text.Trim());

           
                ViewState["Data"] = dt;
                gv1.DataSource =(DataTable) ViewState["Data"];
                gv1.DataBind();


           
        }

        
  
        protected void ResetForm()
        {
            txtName.Text = txtDOB.Text = txtSkills.Text = txtAddress.Text = txtRole.Text = txtSalary.Text = string.Empty;
        }
        

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        DataTable dt = (DataTable) ViewState["Data"];
            if (dt.Rows.Count > 0)
            {
                dt.Rows[e.RowIndex].Delete();
                gv1.DataSource = dt;
                gv1.DataBind();
            }
        }
    }
}


    
