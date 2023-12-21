using Microsoft.AspNetCore.Mvc;
using School.Core.Services;
using SchoolSis.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolSis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        static int id = 4;
        //static int id = 1;
        //    private static List<Teacher> teachers = new List<Teacher> { new Teacher { Id = id++, Name="Tachan",Subject="History",Status=0}
        //     };
            // GET: api/<TheacherController>
            [HttpGet]
            public IEnumerable<Teacher> Get()
            {
                return _teacherService.Get();
            }

            // GET api/<TheacherController>/5
            [HttpGet("{id}")]
            public ActionResult<Teacher> Get(int id)
            {
                Teacher t = _teacherService.Get(id);
                if (t == null)
                    return NotFound();
                return Ok(t);
            }

            // POST api/<TheacherController>
            [HttpPost]
            public void Post([FromBody] Teacher t)
            {
                _teacherService.Post(t);
            }

            // PUT api/<TheacherController>/5
            [HttpPut("{id}")]
            public ActionResult Put(int id, [FromBody] Teacher t)
            {
                if (_teacherService.Put(id,t))
                     return Ok();
                return NotFound();
            }
            [HttpPut("{id}/{status}")]
            public ActionResult Put(int id,int status, [FromBody] Teacher t)
            {
                if (_teacherService.Put(id,status,t))
                     return Ok();
                return NotFound();
            }


            // DELETE api/<TheacherController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
               _teacherService.Delete(id);
            }
    }
}
