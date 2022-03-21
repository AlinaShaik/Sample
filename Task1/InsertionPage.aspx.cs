using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Task1
{
    public partial class InsertionPage : System.Web.UI.Page
    {
     const string   path= "Default.aspx";
        string connection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection scon = new SqlConnection(connection))
                {
                    scon.Open();
                    using (SqlCommand scmd = new SqlCommand("Insert_Student", scon))
                    {
                        scmd.CommandType =CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("@Name",txtName.Text.Trim());
                        scmd.Parameters.AddWithValue("@Subjects", txtSubjects.Text.Trim());
                        scmd.Parameters.AddWithValue("@Marks", txtMarks.Text.Trim());
                        scmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                        scmd.Parameters.AddWithValue("@MailId", txtMailId.Text.Trim());

                        scmd.ExecuteNonQuery();
                    }


                }
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            Response.Redirect(path);

        }

    }
}