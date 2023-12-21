using SchoolSis.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Services
{
    public interface IStudentService
    {
        public IEnumerable<Student> Get();
        public Student Get(int id);

        public void Post(Student student);

        public bool Put(int id, Student newStudent);
        public bool Put(int id, int status, Student newStudent);
        public void Delete(int id);
    }
}
