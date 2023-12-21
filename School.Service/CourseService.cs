using School.Core.Repositories;
using School.Core.Services;
using SchoolSis.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public class CourseService: ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)=>_courseRepository = courseRepository;

        public IEnumerable<Course> Get()=>_courseRepository.Get();
        public Course Get(int id)=>_courseRepository.Get(id);
       
        public void Post( Course course)=>_courseRepository.Post(course);
       
        public bool Put(int id,  Course course)=>_courseRepository.Put(id, course);
        public void Delete(int id) => _courseRepository.Delete(id);
      
    }
}
