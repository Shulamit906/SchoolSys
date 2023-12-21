using SchoolSis.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Services
{
    public interface ICourseService
    {
        public IEnumerable<Course> Get();

        public Course Get(int id);

        public void Post(Course course);

        public bool Put(int id, Course course);

        public void Delete(int id);
    }
}
