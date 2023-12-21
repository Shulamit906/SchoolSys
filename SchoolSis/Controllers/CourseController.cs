using Microsoft.AspNetCore.Mvc;
using School.Core.Services;
using School.Service;
using SchoolSis.Utilities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolSis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService= courseService;
        }
   
    //private static List<Course> courses = new List<Course> { new Course { Id = id++, Name="History",Description="A heavy and boring theoretical course"}
    // };
    // GET: api/<CourseController>
    [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courseService.Get();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            Course c = _courseService.Get(id);
            if (c == null)
                return NotFound();
            return Ok(c);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            _courseService.Post(course);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course course)
        {
            if (_courseService.Put(id, course) == true)
                return Ok();
            return NotFound();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _courseService.Delete(id); 
        }
    }
}
