using DemoApp2.IRepository;
using DemoApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website2.Models;

namespace DemoApp2.Repository
{
    public class TeacherDbService : ITeacherDbService
    {
        AppDbContext dbContext;
        public TeacherDbService()
        {
            dbContext = new AppDbContext();
        }
        public void AddNewteacher(Teacher newTeacher)
        {
            //db code
            dbContext.Teachers.Add(newTeacher);
        }
    }
}
