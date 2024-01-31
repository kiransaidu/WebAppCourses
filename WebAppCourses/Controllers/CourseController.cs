using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourses.Models;

namespace WebAppCourses.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course{CId=1,CName="kiran",Fee=1000,Technology="java",CStartDate=new DateTime(day:20,month:11,year:2019),CEndDate=new DateTime(day:24,month:3,year:2020)},
            new Course{CId=1,CName="surya",Fee=2000,Technology=".net",CStartDate=new DateTime(day:21,month:10,year:2019),CEndDate=new DateTime(day:23,month:2,year:2020)},
            new Course{CId=1,CName="sasi",Fee=3000,Technology="python",CStartDate=new DateTime(day:22,month:9,year:2019),CEndDate=new DateTime(day:22,month:1,year:2020)},
            new Course{CId=1,CName="chaitanya",Fee=4000,Technology="GO",CStartDate=new DateTime(day:23,month:8,year:2019),CEndDate=new DateTime(day:21,month:10,year:2020)},
            new Course{CId=1,CName="subham",Fee=5000,Technology=".net",CStartDate=new DateTime(day:24,month:7,year:2019),CEndDate=new DateTime(day:20,month:11,year:2020)}
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course cou)
        {
            if (ModelState.IsValid)
            {
                courses.Add(cou);
                return RedirectToAction("Index");
            }
            return View(cou);
        }
    }
}