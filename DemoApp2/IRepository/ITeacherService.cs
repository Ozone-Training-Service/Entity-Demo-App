using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website2.Models;

namespace DemoApp2.IRepository
{
    public interface ITeacherService
    {
        void AddTeacher(Teacher teacher);
        List<Teacher> GetAll();
        Teacher Get(string id);
        Teacher Update(Teacher teacher, string id);


    }
}
