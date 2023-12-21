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
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
                _studentRepository = studentRepository;
        }
        public IEnumerable<Student> Get() => _studentRepository.Get().Where(e => e.Status == 1);


        public Student Get(int id) => _studentRepository.Get(id);

        public void Post(Student student) => _studentRepository.Post(student);

        public bool Put(int id, Student newStudent) => _studentRepository.Put(id, newStudent);



        public bool Put(int id, int status, Student newStudent) => _studentRepository.Put(id,status,newStudent);


        public void Delete(int id) => _studentRepository.Delete(id);


    }
}
