using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCurd1.Models;
namespace WebApiCurd1.Controllers
{
   [RoutePrefix("api/Employee")]
    public class CURDAPIController : ApiController
    {
        CURD_AngularEntities objentity = new CURD_AngularEntities();

        //get data from the database
        [HttpGet]
       [Route("AllEmployeeDetails")]
        public  IQueryable<EmployeeDe_1> GetEmployees()
        {
            try
            {
                return objentity.EmployeeDe_1;
            }
            catch(Exception)
            {
                throw;
            }
        }
        //Get Employee by id
        [Route("GetEmployeeDetailsById/{employeeId}")]
        public IHttpActionResult GetEmployeeId(string employeeId)
        {
            EmployeeDe_1 objEmp = new EmployeeDe_1();
            int Id = Convert.ToInt32(employeeId);
            try
            {
                objEmp = objentity.EmployeeDe_1.Find(Id);
                if(objEmp == null)
                {
                    return NotFound();
                }
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(objEmp);
        }

        //postEmployee
        [HttpPost]
       [Route("InsertEmployeeDetails")]
        public IHttpActionResult PostEmployee(EmployeeDe_1 emp)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objentity.EmployeeDe_1.Add(emp);
                objentity.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(emp);
        }

        //updateEmployeeDetails
       [Route("updateEmployeeDetails")]
        public IHttpActionResult PutEmployee(EmployeeDe_1 employee)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                EmployeeDe_1 emp1 = new EmployeeDe_1();
                emp1 = objentity.EmployeeDe_1.Find(employee.EmpId);
                if(emp1!=null)
                {
                    emp1.EmpName = employee.EmpName;
                    emp1.Address = employee.Address;
                    emp1.EmailId = employee.EmailId;
                    emp1.DateofBirth = employee.DateofBirth;
                    emp1.Gender = employee.Gender;
                    emp1.pincode = employee.pincode;
                }
                int i = this.objentity.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(employee);
        }
        //DeleteEmployee
        [HttpDelete]
       [Route("DeleteEmployeeDetails")]
        public IHttpActionResult DeleteEmployee(int id)
        {
            EmployeeDe_1 employee = objentity.EmployeeDe_1.Find(id);
            if(employee==null)
            {
                return NotFound();
            }
            objentity.EmployeeDe_1.Remove(employee);
            objentity.SaveChanges();

            return Ok(employee);

        }


    }
}
