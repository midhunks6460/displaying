using collegeapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace collegeapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //need to inherit from controller base
    public class StudentController : ControllerBase
    {
        [HttpGet]
        //create an end point 

        //action is get students

        //return ienumerable of students
        public IEnumerable<Student> GetStudents()
        {
            return College.Students;
        }

        //if we need to get student data by id or single student
        [HttpGet("{id:int}")]
        //create an end point 

        //action is get students

        //return ienumerable of students
        public Student GetStudentsById(int id)
        {
            return College.Students.Where(n => n.Id == id).FirstOrDefault();
        }

    }
}
