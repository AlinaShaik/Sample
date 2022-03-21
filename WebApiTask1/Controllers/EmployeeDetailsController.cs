﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiTask1.Models;

namespace WebApiTask1.Controllers
{
    public class EmployeeDetailsController : ApiController
    {
        private EmployeeDBEntities1 db = new EmployeeDBEntities1();

        // GET: api/EmployeeDetails
        public IQueryable<EmployeeDetails> GetEmployeeDetails()
        {
            return db.EmployeeDetails;
        }

        // GET: api/EmployeeDetails/5
        [ResponseType(typeof(EmployeeDetails))]
        public IHttpActionResult GetEmployeeDetails(int id)
        {
            EmployeeDetails employeeDetails = db.EmployeeDetails.Find(id);
            if (employeeDetails == null)
            {
                return NotFound();
            }

            return Ok(employeeDetails);
        }

        // PUT: api/EmployeeDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployeeDetails(int id, EmployeeDetails employeeDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeDetails.ID)
            {
                return BadRequest();
            }

            db.Entry(employeeDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EmployeeDetails
        [ResponseType(typeof(EmployeeDetails))]
        public IHttpActionResult PostEmployeeDetails(EmployeeDetails employeeDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EmployeeDetails.Add(employeeDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeDetails.ID }, employeeDetails);
        }

        // DELETE: api/EmployeeDetails/5
        [ResponseType(typeof(EmployeeDetails))]
        public IHttpActionResult DeleteEmployeeDetails(int id)
        {
            EmployeeDetails employeeDetails = db.EmployeeDetails.Find(id);
            if (employeeDetails == null)
            {
                return NotFound();
            }

            db.EmployeeDetails.Remove(employeeDetails);
            db.SaveChanges();

            return Ok(employeeDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeDetailsExists(int id)
        {
            return db.EmployeeDetails.Count(e => e.ID == id) > 0;
        }
    }
}