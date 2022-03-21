using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCurdTask.Models;
namespace WebApiCurdTask.Controllers
{

    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        CURD_AngularEntities cae = new CURD_AngularEntities();

        [HttpGet]
        //[Route("GetAllDetails")]
        public IHttpActionResult GetEmployees()
        {
            var e1 = cae.EmployeeDe_1.ToList();
            return Ok(e1);
        }
       // [Route("GetAllDetailsById/{employeeId}")]
        public IHttpActionResult GetEmployeeById(string employeeId)
        {
            EmployeeDe_1 objEmp = new EmployeeDe_1();
            int Id = Convert.ToInt32(employeeId);
            try
            {
                objEmp = cae.EmployeeDe_1.Find(Id);
                if (objEmp == null)
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(objEmp);
        }

        [HttpPost]
        [Route("InsertEmployeeDetails")]
        public IHttpActionResult PostEmployee(EmployeeDe_1 emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                cae.EmployeeDe_1.Add(emp);
                cae.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(emp);
        }

        [HttpPut]
        //updateEmployeeDetails
       //[Route("updateEmployeeDetails")]
        public IHttpActionResult PutEmployee(int id ,EmployeeDe_1 employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                EmployeeDe_1 emp1 = new EmployeeDe_1();
                emp1 = cae.EmployeeDe_1.FirstOrDefault(x => x.EmpId == id);
                if (emp1 != null)
                {
                    emp1.EmpName = employee.EmpName;
                    emp1.Address = employee.Address;
                    emp1.EmailId = employee.EmailId;
                    emp1.DateofBirth = employee.DateofBirth;
                    emp1.Gender = employee.Gender;
                    emp1.pincode = employee.pincode;

                    //int i = this.cae.SaveChanges();
                    cae.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(employee);
        }
    
        [HttpDelete]
        
       //[Route("DeleteEmployeeDetails")]
        public IHttpActionResult Delete(int id)
        {
              EmployeeDe_1   Empid = cae.EmployeeDe_1.Find(id);
            if (Empid == null)
            {
                return NotFound();
            }

            cae.EmployeeDe_1.Remove(Empid);
            cae.SaveChanges();

            return Ok(Empid);

        }

    }


}
