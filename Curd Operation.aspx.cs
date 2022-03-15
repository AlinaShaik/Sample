using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace Curd_Operation
{
    public partial class Curd_Operation : System.Web.UI.Page
    {
        SqlConnection scon=new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;user id=sa;password=Bhavna@123;");
        SqlDataAdapter sda;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
         scon.Open();
         SqlCommand cmd = new SqlCommand("insert into EmployeeInfos values('"+txtName.Text+"','"+txtCity.Text+"','"+txtAge.Text+"','"+txtJoiningDate.Text+"','"+txtContact.Text+"')",scon);
        cmd.ExecuteNonQuery();
            Response.Write("Data inserted Successfully...");
            //LoadData();
        scon.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand scmd = new SqlCommand("Update EmployeeInfos set EName='"+txtName.Text+"',ECity='"+ txtCity.Text+"', EAge='"+txtAge.Text+"' where EId='"+txtId.Text+"'  ", scon);
            scmd.ExecuteNonQuery();

            Response.Write("Updated Successfully....");
           scon.Close();


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand scmd = new SqlCommand("Delete from EmployeeInfos where EId='"+txtId.Text+"' ", scon);
            scmd.ExecuteNonQuery();
            Response.Write("Deleted the Successfully...");
           scon.Close();

        }
        //protected void LoadData()
        //{
        //    scon = new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;user Id=sa;Password=Bhavna@123;");
        //    scon.Open();
        //    sda = new SqlDataAdapter("select * from EmployeeInfo", scon);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    gvDetails.DataSource = dt;
        //    gvDetails.DataBind();

        //}

        protected void btnView_Click(object sender, EventArgs e)
        {
            
                scon = new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;user Id=sa;Password=Bhavna@123;");
                scon.Open();
                sda = new SqlDataAdapter("select * from EmployeeInfos", scon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gvDetails.DataSource = dt;
                gvDetails.DataBind();
           
            
            

        }



        protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}