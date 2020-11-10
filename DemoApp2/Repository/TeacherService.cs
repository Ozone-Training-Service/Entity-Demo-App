using DemoApp2.IRepository;
using DemoApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website2.Models;

namespace DemoApp2.Repository
{
    public class TeacherService : ITeacherService
    {
        AppDbContext dbContext;
        public TeacherService()
        {
            AppDbContext dbContext = new AppDbContext();

        }

        public void AddTeacher(Teacher teacher)
        {
            // db code
            dbContext.Teachers.Add(teacher);


            //using (AppDbContext dbContext = new AppDbContext())
            //{

            //    dbContext.Teachers.Add(newTeacher);
            //    dbContext.SaveChanges();



            //}


        }

        public Teacher Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Teacher Update(Teacher teacher, string id)
        {
            throw new NotImplementedException();
        }
    }
}
