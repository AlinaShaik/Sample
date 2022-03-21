using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;



namespace Task1
{
    public partial class InsertingBasicDetails : System.Web.UI.Page
    {
      
      string cs2 = ConfigurationManager.ConnectionStrings["DBConnections"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //"Data Source = BHAVNAWKS735; Database = EmployeeDB; user id = sa; Password = Bhavna@123"
                //lblMsg.Visible = false;
                using (SqlConnection scon = new SqlConnection("Data Source = BHAVNAWKS735; Database = EmployeeDB; user id = sa; Password = Bhavna@123"))
                {
                    scon.Open();
                    using (SqlCommand scmd = new SqlCommand("insert into StudentInfoBasic_1 values('" + txtName.Text + "','" + txtSubjects.Text + "','" + txtMarks.Text + "','" + txtPhoneNumber.Text + "','" + txtMailId.Text + "')", scon))
                    {
                        scmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
         
                // lblMsg.Visible = true;

                //lblMsg.Text = "Data Inserted Successfully....";
                Response.Write("<script>alert('Data Inserted Successfully....' )</script>");
                Response.Redirect("Navigation.aspx");



            }

        }
    }
