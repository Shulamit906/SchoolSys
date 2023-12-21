using SchoolSis.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Services
{
    public interface ITeacherService
    {
        public IEnumerable<Teacher> Get();
        public Teacher Get(int id);
        public void Post(Teacher t);
        public bool Put(int id, Teacher t);
        public bool Put(int id, int status, Teacher t);
        public void Delete(int id);
    }
}
