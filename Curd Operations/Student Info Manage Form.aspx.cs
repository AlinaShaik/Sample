using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Curd_Operations
{
    public partial class Student_Info_Manage_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
                RefreshData();
            }

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            
                scon.Open();
           SqlCommand scmd = new SqlCommand("Insert into StudentInfo_Tab1 values('"+txtId.Text+"','" + txtName.Text + "','" + ddlAddress.SelectedValue + "','" + int.Parse(txtAge.Text) + "','" + txtContact.Text + "')",scon);
                
                    scmd.ExecuteNonQuery();
                       scon.Close();
            //Response.Write("Data Inserted Successfully.....");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully inserted');", true);


            LoadData();
            Clear();
             
                


            


        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            LoadData();

            }




        
        protected void LoadData()
        {
       SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
        
            scon.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from StudentInfo_Tab1", scon);
            
                DataTable dt = new DataTable();
                sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            scon.Close();
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            scon.Open();
            SqlCommand scmd = new SqlCommand("Update StudentInfo_Tab1  set StudentName='"+txtName.Text+"',Address='"+ddlAddress.SelectedValue+"',StudentAge='"+int.Parse(txtAge.Text)+"',Contact='"+txtContact.Text+"' where StudentId='"+txtId.Text+"' ",scon);
            scmd.ExecuteNonQuery();
            scon.Close();
            //Response.Write("Updated Successfully.....");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully updated');", true);

            LoadData();
            Clear();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            scon.Open();
            SqlCommand scmd = new SqlCommand("Delete from StudentInfo_Tab1 where StudentId='"+txtId.Text+"'",scon);
            scmd.ExecuteNonQuery();
            scon.Close();

            //Response.Write("Deleted Successfully.........");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully deleted ');", true);

            LoadData();
            Clear();
            


        }
        
        protected void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtContact.Text = "";
        

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo_Tab1 where StudentId='" + int.Parse(txtId.Text) + "'", scon);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            scon.Close();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            scon.Open();
            SqlCommand scmd = new SqlCommand("select * from StudentInfo_Tab1 where StudentId='" + int.Parse(txtId.Text) + "'", scon);
            SqlDataReader dr = scmd.ExecuteReader();
            while(dr.Read())
            {
                txtName.Text = dr.GetValue(1).ToString();
                ddlAddress.SelectedValue = dr.GetValue(2).ToString();
                txtAge.Text = dr.GetValue(3).ToString();
                txtContact.Text = dr.GetValue(4).ToString();

            }
            Clear();

        }
        protected void RefreshData()
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");

            scon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from StudentInfo_Tab1", scon);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            gv1.DataSource = dt;
            gv1.DataBind();
            scon.Close();


        }

        protected void gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");

            TextBox txtName = gv1.Rows[e.RowIndex].FindControl("txtName") as TextBox;
          DropDownList ddlAddress = gv1.Rows[e.RowIndex].FindControl("ddlAddress") as DropDownList;
           TextBox txtAge =gv1.Rows[e.RowIndex].FindControl("txtAge") as TextBox;
            TextBox txtContact = gv1.Rows[e.RowIndex].FindControl("txtContact") as TextBox;
           int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
            scon.Open();
            SqlCommand cmd = new SqlCommand("Update StudentInfo_Tab1  set StudentName='" + txtName.Text + "',Address='" + ddlAddress.SelectedValue + "',StudentAge='" + int.Parse(txtAge.Text) + "',Contact='" + txtContact.Text + "' where StudentId='" + txtId.Text + "'", scon);
            int i=cmd.ExecuteNonQuery();
            scon.Close();
            gv1.EditIndex = -1;
            RefreshData();


        }
    

        protected void gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BHAVNAWKS735;Initial Catalog=EmployeeDB;User ID=sa;Password=Bhavna@123;");
            int StudentId = Convert.ToInt32(gv1.DataKeys[e.RowIndex].Values["StudentId"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from StudentInfo_Tab1 where StudentId ='"+txtId.Text+"'", con);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            RefreshData();
        }

        protected void gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            RefreshData();
        }

        protected void gv1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            RefreshData();
        }

        
    }
}