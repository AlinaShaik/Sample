using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTask1.Models;
using System.Data.Entity;
namespace WebApiTask1.Controllers
{
    public class EmployeeBasicController : ApiController
    {
         EmployeeDBEntities1 db = new EmployeeDBEntities1();

        public IEnumerable<EmployeeDetails> GetEmployeeDetails()
        {
            return db.EmployeeDetails;

        }

        [HttpGet]
        public IHttpActionResult GetEmployee(int id)
        {
           EmployeeDetails emp =db.EmployeeDetails.Find(id);
            if(emp==null)
            {
                return NotFound();
            }
            return Ok(emp);
            //return db.EmployeeDetails.FirstOrDefault();
        }
        [HttpPost]
        public IHttpActionResult PostEmployee(EmployeeDetails e)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.EmployeeDetails.Add(e);
            db.SaveChanges();

            return CreatedAtRoute("EmployeeApi",new { id=RouteParameter.Optional},e);
        }

        [HttpPut]
        public IHttpActionResult UpadateEmployee(int id,EmployeeDetails e)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //if(id!=e.ID)
            //{
            //    return NotFound();
            //}

            db.Entry(e).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return StatusCode(HttpStatusCode.OK);
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            EmployeeDetails Empid = db.EmployeeDetails.Find(id);
            if(Empid == null)
            {
                return NotFound();
            }

            db.EmployeeDetails.Remove(Empid);
            db.SaveChanges();

            return Ok(Empid);

        }
    }
}
