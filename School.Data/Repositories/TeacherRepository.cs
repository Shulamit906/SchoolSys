using School.Core.Repositories;
using SchoolSis.Utilities;
using SchoolSis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Repositories
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly DataContext _context;

        public TeacherRepository(DataContext context)
        {
           _context = context;
        }
        static int id = 4;
        
        public IEnumerable<Teacher> Get()
        {
            return _context.Teachers;
        }
        public Teacher Get(int id)
        {
           return _context.Teachers.Find(item => item.Id == id);
        }
        public void Post( Teacher t)
        {
            _context.Teachers.Add(new Teacher { Id = id++, Name = t.Name, Subject = t.Subject, Status = t.Status });

        }
        public bool Put(int id, Teacher t)
        {
            Teacher te = _context.Teachers.Find(item => item.Id == id);
            if (t != null)
            {
                _context.Teachers.Remove(te);
                te.Name = t.Name;
                te.Subject = t.Subject;
                te.Status = t.Status;
                return true;
            }
            return false;
        }
     
        public bool Put(int id, int status, Teacher t)
        {
            Teacher te = _context.Teachers.Find(item => item.Id == id);
            if (te != null)
            {
                _context.Teachers.Remove(te);
                te.Name = t.Name;
                te.Subject = t.Subject;
                te.Status = status;
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            Teacher te = _context.Teachers.Find(item => item.Id == id);
            _context.Teachers.Remove(te);
        }
    }
}
