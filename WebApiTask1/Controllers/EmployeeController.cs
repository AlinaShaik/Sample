using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTask1.Models;

namespace WebApiTask1.Controllers
{
  
    public class EmployeeController : ApiController
    {
     EmployeeDBEntities1 db = new EmployeeDBEntities1();

        [HttpGet]
        public IEnumerable<EmployeeDetails> GetData()
        {
            return db.EmployeeDetails.ToList();
        }

        public EmployeeDetails GetData(int id)
        {
            return db.EmployeeDetails.Find(id);
        }
    }
}
