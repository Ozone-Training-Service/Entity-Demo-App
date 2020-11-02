using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Website2.Models;

namespace DemoApp2.Controllers
{
    public class TeacherController : Controller
    {

        
        public IActionResult Index()
        {

            AppDbContext dbContext = new AppDbContext();

             var teacherList= dbContext.Teachers.ToList();
            return View(teacherList);
        }



        [HttpPost]
        public IActionResult Add(Teacher newTeacher)
        {

            using (AppDbContext dbContext = new AppDbContext())
            {

                dbContext.Teachers.Add(newTeacher);
                dbContext.SaveChanges();



            }



                return View();
        }
    }
}
