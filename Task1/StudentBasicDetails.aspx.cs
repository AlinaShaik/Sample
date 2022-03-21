using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Task1
{
    public partial class StudentBasicDetails : System.Web.UI.Page
    {
       string cs=ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            using(SqlConnection scon=new SqlConnection(cs))
            {
                scon.Open();
                using(SqlCommand scmd=new SqlCommand("insert into StudentInfo_2 values('"+txtId.Text+"','"+txtName.Text+"','"+txtSubjects.Text+"','"+txtMarks.Text+"','"+txtPhoneNumber.Text+"','"+txtMailId.Text+"')", scon))
                {
                    scmd.ExecuteNonQuery();
                }

           
                lblMsg.Visible = true;
                lblMsg.Text = "Data Inserted Successfully....";
                LoadData();
                ResetForm();

            }

        }

        protected void LoadData()
        {
            using (SqlConnection scon = new SqlConnection(cs))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo_2", scon))
                {
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    gv1.DataSource = ds;
                    gv1.DataBind();
                }
            }

        }
        protected void ResetForm()
        {
            txtName.Text = txtSubjects.Text = txtMarks.Text = txtPhoneNumber.Text = txtMailId.Text = " ";
        }

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection scon = new SqlConnection(cs))
            {
                scon.Open();
                using (SqlCommand scmd = new SqlCommand("delete from StudentInfo_2  where StudentId='" + txtId.Text + "' ", scon))
                {
                    scmd.ExecuteNonQuery();
                }
               
                Response.Write("<script>alert('Data Deleted successfully')</script>");
            }
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv1.EditIndex = e.NewEditIndex;
        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv1.EditIndex = -1;
            LoadData();
            
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            
            LoadData();

            //rfvName.ErrorMessage = rfvSubjects.ErrorMessage = rfvMarks.ErrorMessage = " ";
            //revEmailid.Enabled = false;
        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            using (SqlConnection scon = new SqlConnection(cs))
            {
                scon.Open();
                using (SqlCommand scmd = new SqlCommand("update StudentInfo_2 set='"+txtName.Text+"','"+txtPhoneNumber.Text+"','"+txtMailId.Text+"','"+txtSubjects.Text+"','"+txtMailId.Text+"' where StudentId='"+txtId.Text+"'", scon))
                {
                    scmd.ExecuteNonQuery();
                }

            }
                Response.Write("<script>alert('data updated successfully') </script>");
        }
    }
}


   