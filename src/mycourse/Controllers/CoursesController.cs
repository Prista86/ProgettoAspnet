using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mycourse.Models.Services.Application;

namespace mycourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetServices();
            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}