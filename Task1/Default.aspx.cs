using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;

namespace Task1
{
    public partial class Default : System.Web.UI.Page
    {
        const string url = "InsertionPage.aspx";


        string connectionstring =ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }




        }

        public void BindData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("Select * from StudentInfoBasic_1 ", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "StudentInfoBasic_1");
                        DataGrid1.DataSource = ds.Tables["StudentInfoBasic_1"].DefaultView;
                        DataGrid1.DataBind();
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect(url);
        }

        protected void DataGrid1_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrid1.DataKeys[e.Item.ItemIndex].ToString());
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand("Delete_Student", con))
                    {
                       con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StudentId",id);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Deleted", "<script>alert('Deleted Successfully')</script>");

                            BindData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrid1.DataKeys[e.Item.ItemIndex].ToString());
                TextBox name = (TextBox)DataGrid1.Items[e.Item.ItemIndex].Cells[1].FindControl("txtname");
                TextBox subject = (TextBox)DataGrid1.Items[e.Item.ItemIndex].Cells[2].FindControl("txtSubject");
                TextBox marks = (TextBox)DataGrid1.Items[e.Item.ItemIndex].Cells[3].FindControl("txtMarks");
                TextBox PhoneNumber = (TextBox)DataGrid1.Items[e.Item.ItemIndex].Cells[4].FindControl("txtNumber");
                TextBox mailId = (TextBox)DataGrid1.Items[e.Item.ItemIndex].Cells[5].FindControl("txtMailId");

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    //Update StudentInfoBasic_1 set Name = '" + name.Text + "', Subjects = '" + subject.Text + "', Marks = '" + marks.Text + "', PhoneNumber = '" + PhoneNumber.Text + "', MailId = '" + mailId.Text + "' where StudentId = '" + DataGrid1.DataKeys[e.Item.ItemIndex].ToString() + "' "
                    using (SqlCommand cmd = new SqlCommand("Upadte_Student", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name",name.Text);
                        cmd.Parameters.AddWithValue("@Subjects", subject.Text);
                        cmd.Parameters.AddWithValue("@Marks",marks.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@MailId", mailId.Text);
                        cmd.Parameters.AddWithValue("@StudentId", id);
                       
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Updated", "<script>alert('Updated Successfully')</script>");
                            DataGrid1.EditItemIndex = -1;
                            BindData();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            }
        
        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = e.Item.ItemIndex;
            
            BindData();
        }

        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = -1;
            BindData();
        }
    }
}