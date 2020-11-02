using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website2.Models;

namespace Website2.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {


           /// string place = "Tvm";

            Teacher teacher = new Teacher();
            teacher.Name = "Vishnu";
            teacher.Subject = "physics";



            return View(teacher);
        }


        public IActionResult Index2()
        {
            Teacher teacher1 = new Teacher();
            teacher1.Name = "Vishnu";
            teacher1.Subject = "physics";

            Teacher  teacher2 = new Teacher();
            teacher2.Name = "Vipin";
            teacher2.Subject = "Biology";

            List<Teacher> teacherList = new List<Teacher>();
            teacherList.Add(teacher1);
            teacherList.Add(teacher2);

            return View(teacherList);
        }
    }
}
