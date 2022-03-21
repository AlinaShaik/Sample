using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1
{
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshData();
            }
        }
        public void RefreshData()
        {
            try
            {
                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    if (db.StudentInfoBasic_1.Count() > 0)
                    {
                        gd1.DataSource = (from s in db.StudentInfoBasic_1 select s).ToList();
                        gd1.DataBind();
                    }
                    else
                    {
                        gd1.DataSource = null;
                        gd1.DataBind();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            }


        protected void gd1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gd1.DataKeys[e.RowIndex].Value);
                TextBox name = ((TextBox)gd1.Rows[e.RowIndex].FindControl("txtName"));
                TextBox subject = ((TextBox)gd1.Rows[e.RowIndex].FindControl("txtSubjects"));
                TextBox marks = (gd1.Rows[e.RowIndex].FindControl("txtMarks") as TextBox);
                TextBox phoneNumber = ((TextBox)gd1.Rows[e.RowIndex].FindControl("txtNumber"));
                TextBox mailId = ((TextBox)gd1.Rows[e.RowIndex].FindControl("txtMailId"));


                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    StudentInfoBasic_1 std1 = db.StudentInfoBasic_1.First(x=>x.StudentId==id);
                    std1.Name = name.Text;
                    std1.Subjects = subject.Text;
                    std1.Marks = int.Parse(marks.Text);
                    std1.PhoneNumber = phoneNumber.Text;
                    std1.MailId = mailId.Text;



                   


                    db.SaveChanges();
                    Response.Write("<script>alert('Data Updated successfully')</script>");
                    gd1.EditIndex = -1;
                    RefreshData();
                }
                


            }
            catch(Exception ex)
            {
                throw ex;
            }
           

        }

        protected void gd1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gd1.EditIndex = -1;
            RefreshData();
        }

        protected void gd1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(gd1.DataKeys[e.RowIndex].Value);
                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    StudentInfoBasic_1 std = db.StudentInfoBasic_1.First(x => x.StudentId == id);
                    db.StudentInfoBasic_1.Remove(std);
                    db.SaveChanges();
                    RefreshData();
                    
                }
                Response.Write("<script>alert('Data Deleted successfully')</script>");
            }
            catch(Exception ex)
            {
                //throw ex;
               Response.Write(ex.Message);
            }

            }

        protected void gd1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gd1.EditIndex = e.NewEditIndex;
            RefreshData();
            
        }
    }
}