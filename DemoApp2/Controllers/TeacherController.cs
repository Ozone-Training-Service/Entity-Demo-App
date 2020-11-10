using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp2.IRepository;
using DemoApp2.Models;
using DemoApp2.Repository;
using DemoApp2.Utils;
using Microsoft.AspNetCore.Mvc;
using Website2.Models;

namespace DemoApp2.Controllers
{
    public class TeacherController : Controller
    {
        private ISendEmail send;
        private ITeacherService teacherService;
        public TeacherController(  ISendEmail send,
            ITeacherService teacherService)
        {
            this.teacherService = new TeacherService();
            this.send = send;

          ///  this.send = send;
       // send = new SendEmail();
       
        
        }

        public IActionResult Index()
        {

          

            AppDbContext dbContext = new AppDbContext();

             var teacherList= dbContext.Teachers.ToList();
            return View(teacherList);
        }



        [HttpPost]
        public IActionResult Add(Teacher newTeacher)
        {

            teacherService.AddTeacher(newTeacher);


            //using (AppDbContext dbContext = new AppDbContext())
            //{

            //    dbContext.Teachers.Add(newTeacher);
            //    dbContext.SaveChanges();



            //}






            return View();
        }
    }
}
