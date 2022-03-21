using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace UploadFile
{
    public partial class Practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (ViewState["Count"] != null)
            {
                ViewState["Count"] = count;
                count = (int)ViewState["Count"] + 1;
                ViewState["Count"] = count;
            }

            lblmsg.Text = ViewState["count"].ToString();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            lblmsg.Visible = false;
            lblmsg1.Visible = false;
            SqlConnection scon = new SqlConnection("Data Source=BHAVNAWKS735;Database=EmployeeDB;User id=sa;Password=Bhavna@123");
            string path = Server.MapPath("Images/");
            if (fupUpload.HasFile)
            {
                string extension = Path.GetExtension(fupUpload.FileName);
                if (extension == ".jpg" || extension == ".png")
                {
                    fupUpload.SaveAs(path + fupUpload.FileName);

                    string name = "Images/" + fupUpload.FileName;
                    string s1 = "Insert into UploadData_1 (Name,Address,Image) values('" +txtName.Text + "','" + txtAddress.Text + "','" + name + "')";
                    SqlCommand scmd = new SqlCommand(s1, scon);
                    scon.Open();
                    scmd.ExecuteNonQuery();
                    scon.Close();

                    lblmsg1.Visible = true;
                    lblmsg1.Text = "you have successlly inserted the data";
                    lblmsg1.ForeColor = System.Drawing.Color.Green;
                }

            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "you have to select .jpg or .png file only";
            }
            

        }
    }
}