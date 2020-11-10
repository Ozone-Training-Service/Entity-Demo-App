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
    public class Teacher2Controller : Controller
    {

        ISms ob;
        /// AppDbContext dbContext;

        ITeacherDbService DbService;
        public Teacher2Controller( )
        {
            ob= new Sms();
            //   dbContext = new AppDbContext();
            DbService = new TeacherDbService();


        }


      

        public IActionResult Index()
        {
           
            ob.SendSms();

            return View();
        }

        public IActionResult Add(Teacher teacher)
        {


            DbService.AddNewteacher(teacher);


            return View();
        }



     

    }
}
