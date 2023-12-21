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
    public class StudentRepository: IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        static int id = 4;
 
        public IEnumerable<Student> Get()
        {
            return _context.Students;
        }

        public Student Get(int id)
        {
            return _context.Students.Find(item => item.Id == id);
        }
        public void Post( Student student)
        {
            _context.Students.Add(new Student { Id = id++, Name = student.Name, Age = student.Age, Status = student.Status });
        }

        public bool Put(int id,  Student newStudent)
        {
            Student st = _context.Students.Find(item => item.Id == id);
            if (st != null)
            { 
                _context.Students.Remove(st);
                st.Name = newStudent.Name;
                st.Age = newStudent.Age;
                st.Status = newStudent.Status;
                _context.Students.Add(st);
                return true;
            }
            return false;
        }
      
        public bool Put(int id, int status, Student newStudent)
        {
            Student st = _context.Students.Find(item => item.Id == id);
            if (st == null)
            {
                _context.Students.Remove(st);
                st.Name = newStudent.Name;
                st.Age = newStudent.Age;
                st.Status = status;
                _context.Students.Add(st);
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            Student st = _context.Students.Find(item => item.Id == id);
            _context.Students.Remove(st);
        }
    }
}
