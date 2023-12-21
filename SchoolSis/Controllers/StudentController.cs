using Microsoft.AspNetCore.Mvc;
using School.Core.Services;
using SchoolSis.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolSis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
    //static int id = 1;
    //private static List<Student> students = new List<Student> { new Student { Id = id++, Name="Ruth",Age= 15, Status=1},
    //   new Student { Id = id++, Name="Miri",Age= 19, Status=0},
    //    new Student { Id = id++, Name="Shulamith",Age= 18, Status=1}
    //};
    // GET: api/<StudentsController>
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
      _studentService = studentService;
    }
    static int id = 4;
    [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.Get();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student st =_studentService.Get(id);
            if (st == null)
                return NotFound();
            return Ok(st);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
           _studentService.Post(student);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student newStudent)
        {
           
            if (_studentService.Put(id,newStudent)==true)
                 return Ok();
            return NotFound();
        }
        [HttpPut("{id}/{status}")]
        public ActionResult Put(int id,int status, [FromBody] Student newStudent)
        {
           
            if (_studentService.Put(id,status,newStudent)==true)
                return Ok();
            return NotFound();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}
