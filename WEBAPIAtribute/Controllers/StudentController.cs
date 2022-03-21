using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIAtribute.Models;

namespace WEBAPIAtribute.Controllers
{

     [RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {

        List<Student> students = new List<Student>()

        {

        new Student() { Id = 1, Name = "Tom" },

        new Student() { Id = 2, Name = "Sam" },

        new Student() { Id = 3, Name = "John" }

        };

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
        [Route("{id}")]

        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        List<Teachers> teachers = new List<Teachers>()
            {
             new Teachers (){Id=1,Name="Sairam" },
             new Teachers(){Id=2,Name="seema" },
             new Teachers(){Id=3,Name="usha" }

            };
        [Route("~/api/Shameema")]
        [HttpGet]
        public IEnumerable<Teachers> GetTeachers()
        {

            return teachers;
        }
        [Route("~/api/Shameema/{id}")]
        public Teachers GetById(int id)
        {
            return teachers.FirstOrDefault(s => s.Id == id);
        }
        //    List<ItEmployees> ItEmployees = new List<ItEmployees>()
        //    {
        //     new ItEmployees (){Id=1,Name="Sairam" },
        //     new ItEmployees(){Id=2,Name="seema" },
        //     new ItEmployees(){Id=3,Name="usha" }

        //    };
        //    [Route("~/api/Teacher")]
        //    public IEnumerable<ItEmployees> GetEmployees()
        //    {

        //        return ItEmployees;
        //    }
        //    [Route("~/api/Teacher/{id}")]
        //    public ItEmployees GetEmployeesById(int id)
        //    {
        //        return ItEmployees.FirstOrDefault(s => s.Id == id);
        //    }


        //    public HttpResponseMessage GetInfo()
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.OK,"this the error message");
        //    }


        //}


        //[RoutePrefix("~/api/Teacher")]
        //public class TeacherController:ApiController
        //{



        //}

        //public IHttpActionResult GetAllStudents()
        //{
        //    return Ok(students);
        //}
        //public IHttpActionResult GetById(int id)
        //{
        //    Student std = students.FirstOrDefault(s => s.Id == id);
        //    if(std ==null)
        //    {
        //        // return NotFound();
        //        return Content(HttpStatusCode.NotFound,"Student id not found");
        //    }
        //    return Ok(std);
        //}
        //public HttpResponseMessage GetAllStudents()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK,students);
        //}


        //[HttpGet]
        //public List<Student> StudentDetails()
        //{
        //    //return students.ToList();
        //    return students.ToList();

        //}

        //[HttpGet]
        //public Student Name(string name)
        //{
        //    name= new Student().Name;
        //    return name;
        //}
        //[HttpGet]
        //public void Student(string name)
        //{
        //    //name = "seema";
        //    //Console.WriteLine(name);
        //}
        //public string GetName(string name)
        //{
        //    name = "seema";
        //    return "student name is" + name;
        //}

        //public HttpResponseMessage GetStudentById(int id)
        //{
        //    Student std = students.Find(s => s.Id == id);

        //    if(std==null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Student id not found");
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK,std);

        //}

        //public IHttpActionResult GetName(int id)
        //{
        //    string name = GetStudentName(id);

        //    if (String.IsNullOrEmpty(name))
        //    {
        //        return NotFound();
        //    }

        //    return new TextResult(name, Request);
        //}

    }

}