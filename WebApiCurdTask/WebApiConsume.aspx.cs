using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using WebApiCurdTask.Models;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace WebApiCurdTask
{
    public partial class WebApiConsume : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }

        }

        public void LoadData()
        {
            try
            {
                IEnumerable<EmployeeDe_1> objemp = null;

                using (HttpClient hc = new HttpClient())
                {
                    hc.BaseAddress = new Uri("http://localhost:61166/");
                    var cosumeapi = hc.GetAsync("api/Employee/");
                    cosumeapi.Wait();

                    var readdata = cosumeapi.Result;
                    if (readdata.IsSuccessStatusCode)
                    {
                        var displayrecords = readdata.Content.ReadAsAsync<IList<EmployeeDe_1>>();
                        displayrecords.Wait();
                        objemp = displayrecords.Result;
                        gv.DataSource = objemp;
                        gv.DataBind();


                    }

                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDe_1 e1 = new EmployeeDe_1();
                e1.EmpName = Convert.ToString(txtName.Text);
                e1.DateofBirth = Convert.ToDateTime(txtDob.Text);
                e1.EmailId = Convert.ToString(txtMailId.Text);
                e1.Gender = Convert.ToString(txtGender.Text);
                e1.Address = Convert.ToString(txtAddress.Text);
                e1.pincode = Convert.ToString(txtPincode.Text);



                Consume_Webapi(e1).Wait();
                Clear();
                LoadData();

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        static async Task Consume_Webapi(EmployeeDe_1 e1)
        {
            using(HttpClient hc1=new HttpClient())
            {
                hc1.BaseAddress = new Uri("http://localhost:61166/api/Employee/");
                hc1.DefaultRequestHeaders.Accept.Clear();
                hc1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var stringcontent = new StringContent(JsonConvert.SerializeObject(e1),Encoding.UTF8 ,"application/json");

                var response = await hc1.PostAsync("InsertEmployeeDetails", stringcontent).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                if(response.IsSuccessStatusCode)
                {
                    dynamic result = await response.Content.ReadAsStringAsync();
                }
                
            }
        }




    protected void Clear()
        {

            txtName.Text = txtDob.Text = txtMailId.Text = txtAddress.Text = txtPincode.Text=txtGender.Text = " ";
          
        }

        protected void gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(gv.DataKeys[e.RowIndex].Values["EmpId"].ToString());


            try
            {

                ClientDeleteRequest(Id).Wait();

                try
                {
                    IEnumerable<EmployeeDe_1> objemp = null;

                    using (HttpClient hc = new HttpClient())
                    {
                        hc.BaseAddress = new Uri("http://localhost:61166/");
                        var cosumeapi = hc.GetAsync("api/Employee/");
                        cosumeapi.Wait();

                        var readdata = cosumeapi.Result;
                        if (readdata.IsSuccessStatusCode)
                        {
                            var displayrecords = readdata.Content.ReadAsAsync<IList<EmployeeDe_1>>();
                            displayrecords.Wait();
                            objemp = displayrecords.Result;
                            gv.DataSource = objemp;
                            gv.DataBind();


                        }

                    }
                }
                catch (Exception)
                {
                    throw;
                }


            }
            catch (Exception)
            {
               throw;
            }

        }
        static async Task<HttpResponseMessage> ClientDeleteRequest(int Id)
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:61166/");
                client.DefaultRequestHeaders.Accept.Clear();
                var stringcontent = new StringContent(JsonConvert.SerializeObject(Id), Encoding.UTF8, "application/json");

                var response = await client.DeleteAsync("api/Employee/"+Id).ConfigureAwait(false);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(gv.DataKeys[e.RowIndex].Values["EmpId"].ToString());

                TextBox txtName = gv.Rows[e.RowIndex].FindControl("txtName") as TextBox;
                TextBox txtDob = gv.Rows[e.RowIndex].FindControl("txtDob") as TextBox;
                TextBox txtMailId = gv.Rows[e.RowIndex].FindControl("txtMailId") as TextBox;
                TextBox txtGender = gv.Rows[e.RowIndex].FindControl("txtGender") as TextBox;
                TextBox txtAddress = gv.Rows[e.RowIndex].FindControl("txtAddress") as TextBox;
                TextBox txtPincode = gv.Rows[e.RowIndex].FindControl("txtPincode") as TextBox;


                var obj = new EmployeeDe_1()
                {

                    EmpName = Convert.ToString(txtName.Text),
                    Address = Convert.ToString(txtAddress.Text),
                    EmailId = Convert.ToString(txtMailId.Text),
                    DateofBirth = Convert.ToDateTime(txtDob.Text),

                    Gender = Convert.ToString(txtGender.Text),
                    pincode = Convert.ToString(txtPincode.Text)

                };
                ClientUpdateRequest(Id,obj).Wait();
                LoadData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
          }


        static async Task<EmployeeDe_1> ClientUpdateRequest(int Id,EmployeeDe_1 obj)
        {

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:61166/");
                client.DefaultRequestHeaders.Accept.Clear();
                var stringcontent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                //var response = await client.PutAsJsonAsync<EmployeeDe_1>("api/Employee/"+Id.ToString(),obj );
                //return response;
                var response = await client.PutAsJsonAsync("api/Employee/" + Id ,obj).ConfigureAwait(false);
                //response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                obj = await response.Content.ReadAsAsync<EmployeeDe_1>();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }



        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            LoadData();
        }
    }
}