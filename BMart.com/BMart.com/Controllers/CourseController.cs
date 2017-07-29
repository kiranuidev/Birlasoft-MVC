using BMart.com.Filters;
using BMart.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMart.com.Controllers
{
    [LogActionFilter]
    [ExceptionFilterCustom]
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var course = new Course();
            //throw new Exception();
            return View(course);
        }

        
        public ActionResult Edit()
        {
            //var course = new Course();
            //course.Id = 1;
            //course.Name = "Angular";
            //course.Category = "Software";

            return View();

        }
        [HttpPost]
        public ActionResult Edit(Course course)
        {
            if (string.IsNullOrEmpty(course.Name))
            {
                ModelState.AddModelError("Name", "Course Name is Required");
            }
            if (ModelState.IsValid)
            {
                Redirect("index");
            }

            return View(course);
        }

        public ActionResult JsonData()
        {
            var course = new Course();

            return Json(course.GetCourses(), JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration =60)]
        public String OuputCaching()
        {
            return DateTime.Now.ToString("T");
        }

        [HttpGet]
        public FileResult DownloadFile()
        {
            return new FilePathResult("~/files/data.txt", "application/text");
        }
    }
}