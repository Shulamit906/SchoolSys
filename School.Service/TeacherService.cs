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
    public class TeacherService: ITeacherService
    {
        private readonly ITeacherRepository _repository;
        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Teacher> Get() => _repository.Get().Where(e => e.Status == 1);
        public Teacher Get(int id) => _repository.Get(id);
        public void Post(Teacher t)=>_repository.Post(t);
        public bool Put(int id, Teacher t)=>_repository.Put(id, t);
       
        public bool Put(int id, int status, Teacher t)=>_repository.Put(id,status,t);
        public void Delete(int id)=>_repository.Delete(id); 
    }
}
