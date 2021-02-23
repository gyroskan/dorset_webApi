using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private List<Students> students = new List<Students>(new Students[] { new Students(0, "Baptiste", "Nehmé", 19) });

        [HttpGet]
        public IEnumerable<Students> GetStudents() => students;

        [HttpGet("id/{id}")]
        public ActionResult<Students> GetStudentsByID(int ID)
        {
            var student = students.Find(st => st.ID == ID);
            if (student != null)
                return student;
            return NotFound();
        }

        [HttpGet("name/{Name}")]
        public ActionResult<Students> GetStudentsByName(string name)
        {
            var student = students.Find(st => st.First_name == name || st.Last_Name == name);
            if (student != null)
                return student;
            return NotFound();
        }

        // [HttpPost]
        // public ActionResult<Students> PostStudents(Students std)
        // {
        //     if (students.Exists(st => st.Last_Name == std.Last_Name && st.First_name == std.First_name))
        //         return BadRequest();
        // }
    }
}