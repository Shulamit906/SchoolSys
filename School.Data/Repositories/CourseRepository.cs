using School.Core.Repositories;
using SchoolSis;
using SchoolSis.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        static public int id = 4;
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> Get()
        {
            return _context.Courses;
        }
        public Course Get(int id)
        {
            return _context.Courses.Find(item => item.Id == id);
        }
        public void Post(Course course)
        {
            _context.Courses.Add(new Course { Id = id++, Name = course.Name, Description = course.Description });

        }
        public bool Put(int id, Course course)
        {

            Course c = _context.Courses.Find(item => item.Id == id);
            if (c != null)
            {
                _context.Courses.Remove(c);
                c.Name = course.Name;
                c.Description = course.Description;
                _context.Courses.Add(c);
                return true;
            }
            return false;
           
        }
        public void Delete(int id)
        {
            Course c = _context.Courses.Find(item => item.Id == id);
           
            _context.Courses.Remove(c);
            
        }
    }
}
